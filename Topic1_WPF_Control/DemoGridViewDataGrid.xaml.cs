using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Topic1_WPF_Control
{
    /// <summary>
    /// Interaction logic for DemoGridViewDataGrid.xaml
    /// </summary>
    public partial class DemoGridViewDataGrid : Window
    {
        List<City> cityList = new List<City>
        {
            new City(){ CId =1, CName ="HN"},
            new City(){ CId =2, CName ="HCM"},
            new City(){ CId =3, CName ="HY"},
            new City(){ CId =4, CName ="TB"},
        };
        public DemoGridViewDataGrid()
        {
            InitializeComponent();
            Loaded += DemoDataGrid_Loaded;

            MenList.Items.Add(new Person() { Name = "Ali", ID = "123A", Age = 20, Phone="123456789"});
            MenList.Items.Add(new Person() { Name = "Akram", ID = "456X", Age = 35, Phone = "12222222222"});
            MenList.Items.Add(new Person() { Name = "Salman", ID = "333E", Age = 88, Phone = "13333333336"});

            //cbbCity.ItemsSource = cityList;
        }
        class Person
        {
            public string Name { get; set; }
            public string ID { get; set; }
            public int Age { get; set; }
            public string Phone { get; set; }
            public DateTime DOB { get; set; }
            //public City City { get; set; }
            public bool Active { get; set; }
        }

        class City
        {
            public int CId { get; set; }
            public string CName { get; set; }
        }

        private void DemoDataGrid_Loaded(object sender, RoutedEventArgs e)
        {            
            List<Person> list = new List<Person>
            {
                new Person() { Name = "Ali", ID = "123A", Age = 20, Phone="123456789", DOB= new DateTime(2022,02,03),  Active=true },
                new Person() { Name = "Salman", ID = "333E", Age = 88, Phone = "13333333336", DOB = new DateTime(2023,09,06), Active = false },
                new Person() { Name = "Akram", ID = "456X", Age = 35, Phone = "12222222222", DOB = new DateTime(2012,04,08), Active = true }
            };
            //List<Person> list = new List<Person>
            //{
            //    new Person() { Name = "Ali", ID = "123A", Age = 20, Phone="123456789", DOB= new DateTime(2022,02,03), City={CId=1,CName="HN"}, Active=true },
            //    new Person() { Name = "Salman", ID = "333E", Age = 88, Phone = "13333333336", DOB = new DateTime(2023,09,06), City={CId=2,CName="HCM"}, Active = false },
            //    new Person() { Name = "Akram", ID = "456X", Age = 35, Phone = "12222222222", DOB = new DateTime(2012,04,08), City={CId=3,CName="HY"}, Active = true }
            //};
            cbbCity.ItemsSource = cityList;

            dbItems.ItemsSource = list;
        }

        private void dbItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtCar.Text = dbItems.SelectedItem.ToString();
        }

        private void gridSelectionChange(object sender, SelectionChangedEventArgs e)
        {
            txtPerson.Text = ((Person) MenList.SelectedItem).Name;
        }
    }
}
