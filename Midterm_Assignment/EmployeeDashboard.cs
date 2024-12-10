using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using TextBox = System.Windows.Forms.TextBox;

namespace Midterm_Assignment
{
    public partial class EmployeeDashboard : Form
    {
        static String con = "Server=localhost;Database=companydb;User=root;Password=giromanzusuki1;";
        static String queryAliasing = "ID as ID, product_name as ProductName, price as  Price, quantity as Quantity";
        static MySqlConnection connection = new MySqlConnection(con);
        static DataGridViewRow selectedRow;
       

        public EmployeeDashboard()
        {
            InitializeComponent();
        }

        private void InventoryDashboard_Load(object sender, EventArgs e)
        {
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


            try
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM department;";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet deptList = new DataSet();
                adap.Fill(deptList);

                foreach(DataTable departmentList in deptList.Tables)
                {
                    foreach (DataRow row in departmentList.Rows)
                    {
                        updateDepartmentList.Items.Add(row[1].ToString());
                        addDepartmentList.Items.Add(row[1].ToString());
                        
                    }

                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            } 
            finally
            {
                connection.Close(); 
            }
            MountQueryResult(employeeList, $"SELECT employee.employee_id AS EmployeeID, employee.name AS EmployeeName, department.department_name AS DepartmentName FROM companydb.employee LEFT JOIN companydb.department ON employee.department_id = department.department_id;");
        }

        //Custom methods
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
                    if (col.Name == "Price") col.FillWeight = 30;
                    if (col.Name == "Quantity") col.FillWeight = 30;
                }

            }
            catch (Exception err)
            {
                
            }

            finally
            {


                if (employeeList.Rows.Count == 0)
                {
                    MessageBox.Show("No products found in the inventory", "No Product Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    employeeSearchInput.Text = "";

                }


                connection.Close();
            }
        }
       
      
        //Event Listener
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            String productQuery = employeeSearchInput.Text;
            MountQueryResult(employeeList, $"SELECT {queryAliasing} FROM inventory WHERE product_name LIKE '%{productQuery}%';");
        }

     

      

     

        private void ProductSearchInput_TextChanged(object sender, EventArgs e)
        {
            String productQuery = employeeSearchInput.Text;
            MountQueryResult(employeeList, $"SELECT {queryAliasing} FROM inventory WHERE product_name LIKE '%{productQuery}%';");
        }

        private void InventoryDashboard_Activated(object sender, EventArgs e)
        {
            MountQueryResult(employeeList, $"SELECT items.item_id AS ID, item_name AS ProductName, quantity AS Quantity, base_price AS Price from inventory JOIN items ON inventory.item_id = items.item_id ORDER BY quantity;");
        }

       




        private void employeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedIndex = e.RowIndex;
            selectedRow = employeeList.Rows[selectedIndex];

            string employeeName = selectedRow.Cells[1].Value.ToString();
            string department = selectedRow.Cells[2].Value.ToString();

            deleteEmployeeBtn.Enabled = true;
            deleteEmployeeBtn.BackColor = Color.Red;
            updateEmplpyeeNameInput.Text = employeeName;
            updateDepartmentList.SelectedItem = department;
            updateDepartmentList.Text = department;







        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (AddEmployeeNameInput.Text.Length > 0)
            {
                addEmployeeBtn.Enabled = true;
                addEmployeeBtn.BackColor = Color.Lime;
            } 
            else
            {
                addEmployeeBtn.Enabled = false;
                addEmployeeBtn.BackColor = Color.Silver;
            }
        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
           

          
           
            string selecetedDepartment = addDepartmentList.SelectedItem != null ? addDepartmentList.SelectedItem.ToString() : "";
            string newEmployeeName = AddEmployeeNameInput.Text;
            string query = $"SELECT * FROM department WHERE department_name = '{selecetedDepartment}'";



           

            if(selecetedDepartment != "")
            {

                MySqlCommand cmd = new MySqlCommand(query);
                cmd.CommandType = CommandType.Text;


                cmd.Connection = connection;
                connection.Open();

                string id = "";

                try
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        id = dr["department_id"].ToString();

                    }
                    dr.Close();
                }
                catch (Exception z)
                {
                    MessageBox.Show(z.Message);
                }
                finally
                {


                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();





                    }
                }

                connection.Open();
                string query2 = $"INSERT INTO employee (name, department_id) VALUES ('{newEmployeeName}', {id})";
                MySqlCommand cmd2 = connection.CreateCommand();
                cmd2.CommandText = query2;
                cmd2.ExecuteNonQuery();
                connection.Close();

                MountQueryResult(employeeList, $"SELECT employee.employee_id AS EmployeeID, employee.name AS EmployeeName, department.department_name AS DepartmentName FROM companydb.employee LEFT JOIN companydb.department ON employee.department_id = department.department_id;");

                AddEmployeeNameInput.Text = "";
                addDepartmentList.Text = "";
                addDepartmentList.SelectedIndex = -1;
                selecetedDepartment = "";
                addEmployeeBtn.Enabled = false;

            
            } else
            {
                MessageBox.Show("No Department Selected");
            }


        



        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedRow != null)
            {
                string employee_id = selectedRow.Cells[0].Value.ToString();

                connection.Open();
                string newDeptName = updateDepartmentInput.Text;
                string query = $"DELETE FROM employee WHERE employee_id = {employee_id}";
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                connection.Close();

                updateDepartmentInput.Text = "";
                selectedRow = null;
                deleteEmployeeBtn.Enabled = false;
                deleteEmployeeBtn.BackColor = Color.Silver;

                MountQueryResult(employeeList, $"SELECT employee.employee_id AS EmployeeID, employee.name AS EmployeeName, department.department_name AS DepartmentName FROM companydb.employee LEFT JOIN companydb.department ON employee.department_id = department.department_id;");

                updateDepartmentList.SelectedIndex = -1;
                updateEmplpyeeNameInput.Text = "";
            }
        }

        private void updateEmplpyeeNameInput_TextChanged(object sender, EventArgs e)
        {
            if (updateEmplpyeeNameInput.Text.Length > 0) {
                updateEmployeeBtn.Enabled = true;
                updateEmployeeBtn.BackColor = Color.Lime;
            }

            else
            {
                updateEmployeeBtn.Enabled = false;
                updateEmployeeBtn.BackColor = Color.Silver;
            }
            
        }

        private void updateEmployeeBtn_Click(object sender, EventArgs e)
        {

           
            string selectedRowId = selectedRow.Cells[0].Value.ToString();
   
            string selecetedDepartment = updateDepartmentList.SelectedItem != null ? updateDepartmentList.SelectedItem.ToString() : "";
            string newEmployeeName = updateEmplpyeeNameInput.Text;

            string departmentQuery = $"SELECT * FROM department WHERE department_name = '{selecetedDepartment}'";


            if (selecetedDepartment != "")
            {

                MySqlCommand cmd = new MySqlCommand(departmentQuery);
                cmd.CommandType = CommandType.Text;


                cmd.Connection = connection;
                connection.Open();

                string id = "";

                try
                {
                    MySqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        id = dr["department_id"].ToString();

                    }
                    dr.Close();
                }
                catch (Exception z)
                {
                    MessageBox.Show(z.Message);
                }
                finally
                {


                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();





                    }
                }

                


                connection.Open();
                string query2 = $"UPDATE employee SET name = '{newEmployeeName}', department_id = {id} WHERE employee_id = {selectedRowId}";
                MySqlCommand cmd2 = connection.CreateCommand();
                cmd2.CommandText = query2;
                cmd2.ExecuteNonQuery();
                connection.Close();

                MountQueryResult(employeeList, $"SELECT employee.employee_id AS EmployeeID, employee.name AS EmployeeName, department.department_name AS DepartmentName FROM companydb.employee LEFT JOIN companydb.department ON employee.department_id = department.department_id;");

                updateEmplpyeeNameInput.Text = "";
                updateDepartmentList.Text = "";
                updateDepartmentList.SelectedIndex = -1;         
                updateEmployeeBtn.Enabled = false;


            }
           



        }

        private void employeeSearchInput_TextChanged(object sender, EventArgs e)
        {
            if (employeeSearchInput.Text.Length == 0)
            {
                MountQueryResult(employeeList, $"SELECT employee.employee_id AS EmployeeID, employee.name AS EmployeeName, department.department_name AS DepartmentName FROM companydb.employee LEFT JOIN companydb.department ON employee.department_id = department.department_id;");

            } else
            {
                String employeeQuery = employeeSearchInput.Text;
                MountQueryResult(employeeList, $"SELECT employee.employee_id AS EmployeeID, employee.name AS EmployeeName, department.department_name AS DepartmentName FROM companydb.employee LEFT JOIN companydb.department ON employee.department_id = department.department_id WHERE employee.name LIKE '%{employeeQuery}%';");
            }
        }
    }
}
 