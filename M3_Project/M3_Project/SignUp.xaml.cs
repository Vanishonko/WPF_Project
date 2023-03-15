using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            //TODO: Add logic to create a new user

            Regex regexUser = new Regex(@"^[a-zA-Z0-9_]{6,12}$"); // 6-12 long, upper/lower, numbers & _ only
            Regex regexPassword = new Regex(@"^(?=.*\d)[^\s]{8,16}$"); // 8-16 long, 1 number, no ws
            Regex regexEmail = new Regex(@"^[^\s@]+@[^\s@]+\.[^\s@]+$"); // @ and . after it

            string username = usernameTextBox.Text;
            string password = passwordBox.Password;
            string confirmPassword = confirmPasswordBox.Password;
            string email = emailTextBox.Text;
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;

            if (username != null && password != null)
            {
                if (regexUser.IsMatch(username) && regexPassword.IsMatch(password) && regexEmail.IsMatch(email))
                {
                    if (password == confirmPassword)
                    {
                        //TODO: Fetch the data and put it into a DB


                        Home homeWindow = new Home();
                        homeWindow.Show();
                        this.Close();
                    }
                }
            }

            if (firstName.Length == 0 || lastName.Length == 0 ||
                username.Length == 0 || email.Length == 0 ||
                password.Length == 0 || confirmPassword.Length == 0)
            {
                MessageBox.Show("Make sure you've filled out every field.");
            }

            if (!regexEmail.IsMatch(email))
            {
                MessageBox.Show("Make sure you have entered a valid email.");
            }
            if (!regexUser.IsMatch(username))
            {
                MessageBox.Show("Make sure you have entered a valid username between 6 and 12 characters. It can only contain letters, numbers and underscores.");
            }
            if (!regexPassword.IsMatch(password))
            {
                MessageBox.Show("Make sure you've entered a valid password. It must be between 8 and 16 characters and contain at least 1 number.");
            }
            if (password != confirmPassword && password != null)
            {
                MessageBox.Show("Make sure the passwords are matching.");
            }

        }

        private void LoginPage(object sender, MouseButtonEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
