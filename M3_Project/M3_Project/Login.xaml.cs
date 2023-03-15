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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace M3_Project
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordBox.Password;

            // TODO: Add authentication logic 
            if (username == "root" && password == "root")
            {
                // Create an instance of the new window
                Home homeWindow = new Home();

                // Show the new window
                homeWindow.Show();

                // Close the current window
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong credentials.");
            }
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            SignUp signUpWindow = new SignUp();

            signUpWindow.Show();

            this.Close();
        }
    }
}
