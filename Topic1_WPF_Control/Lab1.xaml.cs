using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Topic1_WPF_Control.Models;

namespace Topic1_WPF_Control
{

    public partial class Lab1 : Window
    {
        public Prn221Context dbContext;

        public Lab1()
        {
            InitializeComponent();
            dbContext = new Prn221Context();
        }
        private Country getCountryByID(int id)
        {
            return dbContext.Countries.FirstOrDefault(c => c.Id == id);
        }

        private void LoadData()
        {
            dbItems.ItemsSource = dbContext.People.ToList();
            cbbCity.ItemsSource = dbContext.Countries.ToList();
            cbCountry.ItemsSource = dbContext.Countries.ToList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (txtId.Text == "" || txtName.Text == "" || dpDob.SelectedDate == null)
            {
                MessageBox.Show("Not empty ID or Name Or DOB");
                return;
            }
            else if (DateTime.Parse(dpDob.Text) >= DateTime.Now)
            {
                MessageBox.Show("DOB greater than datetime now");
                return;
            }
            else
            {
                Person p = dbContext.People.FirstOrDefault(p => p.Id == int.Parse(txtId.Text));
                if (p != null)
                {
                    MessageBox.Show("Id is exist");
                    return;
                }

                p = new Person();
                p.Id = int.Parse(txtId.Text);
                p.Name = txtName.Text;
                p.Dob = (DateTime)dpDob.SelectedDate;
                p.Gender = isMale.IsChecked == true ? "Male" : "Female";
                p.Active = cbActive.IsChecked;

                p.Country = cbCountry.SelectedIndex;

                dbContext.Add(p);
                dbContext.SaveChanges();
                MessageBox.Show("Create successfull");
                LoadData();
                clearData();
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (txtId.Text == "" || txtName.Text == "" || dpDob.SelectedDate == null)
            {
                MessageBox.Show("Not empty ID or Name Or DOB");
                return;
            }
            else if (DateTime.Parse(dpDob.Text) >= DateTime.Now)
            {
                MessageBox.Show("DOB greater than datetime now");
                return;
            }

            Person _per = dbContext.People.FirstOrDefault(p => p.Id == int.Parse(txtId.Text));
            if (_per != null)
            {
                try
                {
                    _per.Name = txtName.Text;
                    _per.Dob = DateTime.Parse(dpDob.Text);
                    _per.Country = cbCountry.SelectedIndex;
                    _per.Active = cbActive.IsChecked;
                    _per.Gender = isMale.IsChecked == true ? "Male" : "Female";
                    dbContext.People.Update(_per);
                    dbContext.SaveChanges();
                    MessageBox.Show("Update successful", "Add");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
            }
            else
            {
                MessageBox.Show("This person doesn't exsit!", "ERROR");
            }


        }

        List<Person> lstSeleted = new List<Person>();
        private void btnDeleteAll_Click(object sender, RoutedEventArgs e)
        {
            if (lstSeleted.Count != 0)
            {
                try
                {
                    foreach (Person p in lstSeleted)
                    {
                        Person person = dbContext.People.FirstOrDefault(per => per.Id == p.Id);
                        dbContext.People.Remove(person);
                    }
                    dbContext.SaveChanges();
                    LoadData();
                    MessageBox.Show("Delete selected people", "Delete");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
            }
            else
            {
                MessageBox.Show("Don't have any seleted", "Notice");
            }
        }

        private void selectedPerson_Checked(object sender, RoutedEventArgs e)
        {
            lstSeleted.Add(getPerson());
        }

        private void selectedPerson_Unchecked(object sender, RoutedEventArgs e)
        {
            lstSeleted.Remove(getPerson());
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            Person _per = dbContext.People.FirstOrDefault(p => p.Id == getPerson().Id);
            if (_per != null)
            {
                try
                {
                    dbContext.People.Remove(_per);
                    dbContext.SaveChanges();
                    MessageBox.Show("Delete successfully", "Delete");
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR");
                }
            }
            else
            {
                MessageBox.Show("This person doesn't exist!");
            }
        }

        private Person getPerson()
        {

            Person person = new Person()
            {

                Id = int.Parse(txtId.Text),
                Name = txtName.Text,
                Dob = DateTime.Parse(dpDob.Text),
                Country = cbCountry.SelectedIndex != null ? cbCountry.SelectedIndex : null,
                Active = cbActive.IsChecked,
                Gender = isMale.IsChecked == true ? "Male" : "Female"
            };
            return person;
        }

        public void clearData()
        {
            txtId.Clear();
            txtName.Clear();
            cbActive.IsChecked = false;
            dpDob.SelectedDate = null;
            isFemale.IsChecked = false;
            isMale.IsChecked = false;
        }

        private void dbItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Person p = dbItems.SelectedItem as Person;
            if (p != null)
            {
                if (p.Gender.Trim().Equals("Male"))
                {
                    isMale.IsChecked = true;
                }
                else
                {
                    isFemale.IsChecked = true;
                }
            }
        }



        //public class City
        //{
        //    public int CId { get; set; }
        //    public string CName { get; set; }
        //}

        //List<City> cityList = new List<City>
        //{
        //    new City(){ CId =1, CName ="HN"},
        //    new City(){ CId =2, CName ="HCM"},
        //    new City(){ CId =3, CName ="HY"},
        //    new City(){ CId =4, CName ="TB"},
        //};
        //class Person
        //{
        //    public string Name { get; set; }
        //    public string ID { get; set; }
        //    public int Age { get; set; }
        //    public string Phone { get; set; }
        //    public DateTime DOB { get; set; }
        //    public City City { get; set; }
        //    public bool Active { get; set; }
        //    public bool Gender { get; set; }
        //}
        //public Lab11()
        //{
        //    InitializeComponent();
        //    Loaded += Lab1_Loaded;

        //}

        //List<Person> list = new List<Person>
        //    {
        //        new Person() { Name = "Ali", ID = "123A", Age = 20, Phone="123456789", DOB= new DateTime(2022,02,03), City={CId=1,CName="HN"}, Active=true, Gender= true },
        //        new Person() { Name = "Salman", ID = "333E", Age = 88, Phone = "13333333336", DOB = new DateTime(2023,09,06), Active = false, Gender= false },
        //        new Person() { Name = "Akram", ID = "456X", Age = 35, Phone = "12222222222", DOB = new DateTime(2012,04,08), Active = true , Gender= false}
        //    };
        //public List<City> Cities = new List<City>();

        //public City GetCity(int id)
        //{
        //    return cityList.FirstOrDefault(x => x.CId == id);
        //}

        //private void Lab1_Loaded(object sender, RoutedEventArgs e)
        //{
        //    cbbCity.DisplayMemberPath = "CName";
        //    cbCountry.DisplayMemberPath = "CName";
        //    cbbCity.SelectedValuePath = "CName";


        //    cbbCity.ItemsSource = cityList;
        //    cbCountry.ItemsSource = cityList;
        //    dbItems.ItemsSource = list;
        //}

        //private void dbItems_Selection(object sender, SelectionChangedEventArgs e)
        //{
        //    Person p = dbItems.SelectedItem as Person;
        //    if (p != null)
        //    {
        //        txtId.Text = p.ID.ToString();
        //        txtName.Text = p.Name.ToString();
        //        dpDob.Text = p.DOB.ToString();
        //        cbActive.IsChecked = p.Active;
        //        cbCountry.SelectedItem = p.City;
        //        if (p.Gender) isMale.IsChecked = true;
        //        else isFemale.IsChecked = true;
        //    }

        //}

        //private void btnAdd_Click(object sender, RoutedEventArgs e)
        //{
        //    if (txtId.Text == "" || txtName.Text == "" || dpDob.SelectedDate == null)
        //    {
        //        MessageBox.Show("Not empty ID or Name Or DOB");
        //    }
        //    else if (dpDob.SelectedDate >= DateTime.Now)
        //    {
        //        MessageBox.Show("DOB greater than datetime now");
        //    }
        //    else
        //    {
        //        foreach (Person id in list)
        //        {
        //            if (id.ID == txtId.Text)
        //            {
        //                MessageBox.Show("Id not duplicate ");
        //                break;
        //            }
        //        }
        //        Person p = new Person();
        //        p.ID = txtId.Text;
        //        p.Name = txtName.Text;
        //        p.DOB = (DateTime)dpDob.SelectedDate;
        //        p.Gender = (bool)isMale.IsChecked == true ? true : false;
        //        p.Active = (bool)cbActive.IsChecked;

        //        list.Add(p);

        //        dbItems.ItemsSource = null;
        //        dbItems.ItemsSource = list;
        //        MessageBox.Show("Create successfull");
        //        clearData();
        //    }


        //}
        //private void btnDelete_Click(object sender, RoutedEventArgs e)
        //{
        //    if (txtId.Text == "")
        //    {
        //        MessageBox.Show("Not empty ID");
        //    }
        //    else
        //    {
        //        list.RemoveAll(r => r.ID == txtId.Text);
        //        dbItems.ItemsSource = null;
        //        dbItems.ItemsSource = list;
        //        MessageBox.Show("Delete successfull");
        //        clearData();
        //    }
        //}


        //private void btnEdit_Click(object sender, RoutedEventArgs e)
        //{
        //    Person p = new Person();
        //    if (txtId.Text == "" && txtName.Text == "" && dpDob.SelectedDate == null)
        //    {
        //        MessageBox.Show("Not empty ID or Name Or DOB");

        //    }
        //    else if (txtId.Text != p.ID)
        //    {
        //        list.RemoveAll(r => r.ID == txtId.Text);
        //        p.ID=txtId.Text;
        //        p.Name = txtName.Text;
        //        p.DOB = (DateTime)dpDob.SelectedDate;
        //        p.Gender = (bool)isMale.IsChecked == true ? true : false;
        //        p.Active = (bool)cbActive.IsChecked;

        //        list.Add(p);

        //        dbItems.ItemsSource = null;
        //        dbItems.ItemsSource = list;
        //        MessageBox.Show("Update successfull");
        //        clearData();
        //    }
        //}
    }
}
