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
    /// Interaction logic for CtrControlChexbox.xaml
    /// </summary>
    public partial class CtrControlChexbox : Window
    {
        List<string> course = new List<string>();
        string txt = "Course: ";
        public CtrControlChexbox()
        {
            InitializeComponent();
        }

        private void btnCheckbox1_Checked(object sender, RoutedEventArgs e)
        {
            string chk = btnCheckbox1.Content.ToString();

            if(!course.Contains(chk))
            {
                course.Add(chk);
            }
            string result = string.Join(",", course);
            label.Content = txt + result;
            
        }

        private void checkBox_Uncheck(object sender, RoutedEventArgs e)
        {
            string chk = btnCheckbox1.Content.ToString();
            if (course.Contains(chk))
            {
                course.Remove(chk);
            }
            string result = string.Join(",", course);
            label.Content = txt + result;
        }

        private void btnCheckbox2_Checked(object sender, RoutedEventArgs e)
        {
            string chk = btnCheckbox2.Content.ToString();

            if (!course.Contains(chk))
            {
                course.Add(chk);
            }
            string result = string.Join(",", course);
            label.Content = txt + result;
        }

        private void btnCheckbox2_Unchecked(object sender, RoutedEventArgs e)
        {
            string chk = btnCheckbox2.Content.ToString();
            if (course.Contains(chk))
            {
                course.Remove(chk);
            }
            string result = string.Join(",", course);
            label.Content = txt + result;
        }

        private void btnCheckbox3_Unchecked(object sender, RoutedEventArgs e)
        {
            string chk = btnCheckbox3.Content.ToString();
            if (course.Contains(chk))
            {
                course.Remove(chk);
            }
            string result = string.Join(",", course);
            label.Content = txt + result;
        }

        private void btnCheckbox3_Checked(object sender, RoutedEventArgs e)
        {
            string chk = btnCheckbox3.Content.ToString();

            if (!course.Contains(chk))
            {
                course.Add(chk);
            }
            string result = string.Join(",", course);
            label.Content = txt + result;
        }
    }
}
