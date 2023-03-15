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
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        public Home()
        {
            InitializeComponent();
        }

        private void scheduleButton_Click(object sender, RoutedEventArgs e)
        {
            Schedule schedule = new Schedule();
            schedule.Show();
            this.Close();
        }

        private void trainTrackerButton_Click(object sender, RoutedEventArgs e)
        {
            TrainTracking trainTracking = new TrainTracking();
            trainTracking.Show();
            this.Close();
        }

        private void myTicketsButton_Click(object sender, RoutedEventArgs e)
        {
            Tickets tickets = new Tickets();
            tickets.Show();
            this.Close();
        }

        private void LogOutButton_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
