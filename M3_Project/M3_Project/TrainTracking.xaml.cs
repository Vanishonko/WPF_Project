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

namespace M3_Project
{
    /// <summary>
    /// Interaction logic for trainTracking.xaml
    /// </summary>
    public partial class TrainTracking : Window
    {
        public TrainTracking()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            string ID = trainIDTextBox.Text;
            if (ID.Length == 0)
            {
                MessageBox.Show("Please enter your desired train's ID.");
            }
        }

        private void menuButton_Click(object sender, RoutedEventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }
    }
}
