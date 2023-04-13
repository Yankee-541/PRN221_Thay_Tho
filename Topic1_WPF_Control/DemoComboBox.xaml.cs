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
    /// Interaction logic for DemoComboBox.xaml
    /// </summary>
    public partial class DemoComboBox : Window
    {
        public DemoComboBox()
        {
            InitializeComponent();
            List<string> listitems = new List<string> { "PRN211", "PRN221", "PRN231", "MNL111", "MLN122", "MLN123", "MLN124" };
            cbItems.ItemsSource = listitems;
        }

        private void selectedItem(object sender, SelectionChangedEventArgs e)
        {
            lbItems.Content = "Items: " + cbItems.SelectedItem.ToString();
        }
    }
}
