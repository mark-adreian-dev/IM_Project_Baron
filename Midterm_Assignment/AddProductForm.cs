using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm_Assignment
{
    public partial class AddProductForm : Form
    {
        static String con = "Server=localhost;Database=pointofsale;User=root;Password=giromanzusuki1;";
        static MySqlConnection connection = new MySqlConnection(con);
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9\b\.]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            var regex = new Regex(@"[^0-9\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {

            if (productName.Text.ToString() == "" || unitPrice.Text.ToString() == "" || quantityInput.Text.ToString() == "")
            {
                MessageBox.Show("Please fill up all fields", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {

                DialogResult response = MessageBox.Show("Are you to add this item?", "Add Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (response == DialogResult.Yes)
                {
                    connection.Open();
                    String productNameValue = productName.Text.ToString();
                    String unitPriceValue = Convert.ToDouble(unitPrice.Text.ToString()).ToString("F");
                    int quantity = Convert.ToInt32(quantityInput.Text.ToString());


                    MySqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = $"INSERT INTO pointofsale.inventory (product_name, price, quantity) VALUES ('{productNameValue}', {unitPriceValue}, {quantity});";
                    MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Item added Successfully", "Add Item", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connection.Close();
                    this.Close();
                }
                
            }


        }

        private void productName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
