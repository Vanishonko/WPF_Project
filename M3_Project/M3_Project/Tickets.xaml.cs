using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for Tickets.xaml
    /// </summary>
    public partial class Tickets : Window
    {
        public Tickets()
        {
            InitializeComponent();
           // populateTable();
        }


        /**
         * TODO: IMPLEMENT THE TABLE
         * 
        private void populateTable()
        {
            SqlConnection sqlCon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=SignUpDB; Integrated Security=True");

            try
            {

                //opening the connection to the db 

                sqlCon.Open();

                //Build our actual query 

                string query = " select * from Tickets where ID = '" + this.firstNameblock.Text + "'";
                //Establish a sql command

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    firstNameblock.Text = reader["FirstName"].ToString();
                    lastNameblock.Text = reader["LastName"].ToString();
                    emailblock.Text = reader["Email"].ToString();
                    passwordBlock.Text = reader["Password"].ToString();

                }

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message);

            }

            finally

            {

                sqlCon.Close();

            }
        }

        **/

        private void menuButton_Click(object sender, RoutedEventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Close();
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            string ID = ticketIDTextBox.Text;
            if (ID.Length == 0) {
                MessageBox.Show("Please enter your ticket's ID.");
            }
        }
    }
}
