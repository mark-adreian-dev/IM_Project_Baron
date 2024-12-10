using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Windows.Documents;

namespace Midterm_Assignment
{

    public partial class DepartmentDashboard : Form
    {
        static String con = "Server=localhost;Database=companydb;User=root;Password=giromanzusuki1;";
        static String queryAliasing = "ID as ID, product_name as ProductName, price as  Price, quantity as Quantity";
        static MySqlConnection connection = new MySqlConnection(con);
        static DataGridViewRow selectedRow;

       

        public DepartmentDashboard()
        {

            InitializeComponent();

        }

        private void PointOfSaleDashboard_Load(object sender, EventArgs e)
        {

            departmentList.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Black;
            if (this.MdiParent != null)
            {
                MdiClient client = null;
                foreach (Control ctl in this.MdiParent.Controls)
                {
                    if (ctl is MdiClient) { client = ctl as MdiClient; break; }
                }
                this.WindowState = FormWindowState.Normal;

                int width = client.Size.Width - 4;
                int height = client.Size.Height - 4;
                this.Size = new Size(width, height);
            }

            if(selectedRow == null) ResetSelections(departmentList);

        }
        
        //POS List Item Section
        private void ProductListTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedIndex = e.RowIndex;
            selectedRow = departmentList.Rows[selectedIndex];

            string deptId = selectedRow.Cells[0].Value.ToString();
            string deptName = selectedRow.Cells[1].Value.ToString();

            updateDepartmentInput.Text = deptName;
            idLabel.Text = deptId;

            deleteDepartmentBtn.Enabled = true;
            deleteDepartmentBtn.BackColor = Color.Red;


    

          
            
        }
       

        //Custom functions
        private void MountQueryResult(DataGridView table, String query)
        {
            

            try
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet productList = new DataSet();
                adap.Fill(productList);
                table.DataSource = productList.Tables[0].DefaultView;

                foreach (DataGridViewColumn col in table.Columns)
                {
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    if (col.Name == "ID") col.FillWeight = 20;
                    if (col.Name == "ProductName") col.FillWeight = 30;
                    if (col.Name == "Quantity") col.FillWeight = 30;
                }


            }
            catch (Exception err)
            {

            }

            finally
            {

                connection.Close();

                if (departmentList.Rows.Count == 0)
                {
                    MessageBox.Show("No products found in the inventory", "No Product Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    productInput.Text = "";
                    MountQueryResult(departmentList, $"SELECT items.item_id AS ID, item_name AS ProductName, quantity AS Quantity, base_price AS Price from inventory JOIN items ON inventory.item_id = items.item_id ORDER BY quantity;");
           
                }
            }
        }
       
        private void ResetSelections(DataGridView table)
        {
           
            selectedRow = null;
            MountQueryResult(table, $"SELECT department_id AS DepartmentID, department_name AS DepartmentName FROM companydb.department;");
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            String productQuery = productInput.Text;
            MountQueryResult(departmentList, $"SELECT {queryAliasing} FROM inventory WHERE product_name LIKE '%{productQuery}%';");
        }
            
       
        private void AddDepartment_Click(object sender, EventArgs e)
        {
            connection.Open();
            string newDeptName = addDepartmentInput.Text;
            string query = $"INSERT INTO Department (department_name) VALUES ('{newDeptName}')";
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = query;   
            cmd.ExecuteNonQuery();
            connection.Close();
            addDepartmentInput.Text = "";

            MountQueryResult(departmentList, $"SELECT department_id AS DepartmentID, department_name AS DepartmentName FROM companydb.department");

        }

        private void ProductInput_TextChanged(object sender, EventArgs e)
        {
            String productQuery = productInput.Text;
            MountQueryResult(departmentList, $"SELECT department_id AS DepartmentID, department_name AS DepartmentName FROM companydb.department WHERE department_name LIKE '%{productQuery}%';");
        }

        private void AddDepartmentInput_TextChanged(object sender, EventArgs e)
        {
            if (addDepartmentInput.Text.Length > 0) { 
                addDepartmentBtn.Enabled = true;
                addDepartmentBtn.BackColor = Color.Lime;
            }

            else
            {
                addDepartmentBtn.Enabled = false;
                addDepartmentBtn.BackColor = Color.Silver;
            }
        }

        private void updateDepartmentInput_TextChanged(object sender, EventArgs e)
        {
            if (updateDepartmentInput.Text.Length > 0)
            {
                updateDepartmentBtn.Enabled = true;
                updateDepartmentBtn.BackColor = Color.Lime;
            }

            else
            {
                updateDepartmentBtn.Enabled = false;
                updateDepartmentBtn.BackColor = Color.Silver;
            }
        }

        private void updateDepartmentBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            string newDeptName = updateDepartmentInput.Text;
            string query = $"UPDATE department SET department_name = '{newDeptName}' WHERE department_id = {idLabel.Text}";
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            connection.Close();


            updateDepartmentInput.Text = "";
            idLabel.Text = "X";


            MountQueryResult(departmentList, $"SELECT department_id AS DepartmentID, department_name AS DepartmentName FROM companydb.department");

        }

        private void deleteDepartment_Click(object sender, EventArgs e)
        {
            if(selectedRow != null)
            {
                string deptId = selectedRow.Cells[0].Value.ToString();

                connection.Open();
                string newDeptName = updateDepartmentInput.Text;
                string query = $"DELETE FROM department WHERE department_id = {deptId}";
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                connection.Close();

                updateDepartmentInput.Text = "";
                selectedRow = null;
                deleteDepartmentBtn.Enabled = false;
                deleteDepartmentBtn.BackColor = Color.Silver;

                MountQueryResult(departmentList, $"SELECT department_id AS DepartmentID, department_name AS DepartmentName FROM companydb.department");
            }
        }
    }
}
