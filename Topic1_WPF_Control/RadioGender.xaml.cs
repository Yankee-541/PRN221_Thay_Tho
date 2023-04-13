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
    /// Interaction logic for RadioGender.xaml
    /// </summary>
    public partial class RadioGender : Window
    {
        public RadioGender()
        {
            InitializeComponent();
        }

        private void checkGender(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            lbGender.Content = "Gender: "+radioButton.Content;
        }

        private void checkStatus(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            lbStatus.Content ="Status: "+ radioButton.Content;
        }
    }
}
