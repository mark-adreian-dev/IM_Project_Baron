using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm_Assignment
{
    public partial class LoginForm : Form
    {
        static String con = "Server=localhost;Database=companydb;User=root;Password=giromanzusuki1;";
        static MySqlConnection connection = new MySqlConnection(con);

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = usernameInput.Text;
                string password = passwordInput.Text;

                connection.Open();
                String query = $"SELECT * FROM accounts WHERE username = '{username}' AND password = '{password}';";
                String accountName = "";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Set the parameter value
                   
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()){ // Read the single row
                            accountName = reader["username"].ToString();
                           
                            new mainWindow(accountName).Show();
                            this.Hide();
                            
                            
                  
                        }
                        else
                        {
                            MessageBox.Show("No Account Found");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
