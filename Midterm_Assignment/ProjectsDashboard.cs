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

namespace Midterm_Assignment
{
    public partial class ProjectsDashboard : Form
    {
        static String con = "Server=localhost;Database=companydb;User=root;Password=giromanzusuki1;";
        static MySqlConnection connection = new MySqlConnection(con);
        static DataGridViewRow selectedProjectRow;
        static DataGridViewRow selectedTaskRow;


        public ProjectsDashboard()
        {
            InitializeComponent();
        }

        private void TransactionDashboard_Load(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM companydb.department;";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet projList = new DataSet();
                adap.Fill(projList);

                foreach (DataTable projTable in projList.Tables)
                {
                    foreach (DataRow row in projTable.Rows)
                    {

                        addProjectDepartment.Items.Add(row[1].ToString());
                        updateProjectDepartment.Items.Add(row[1].ToString());



                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }

            try
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM companydb.employee;";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet projList = new DataSet();
                adap.Fill(projList);

                foreach (DataTable projTable in projList.Tables)
                {
                    foreach (DataRow row in projTable.Rows)
                    {

                        assignedEmployeeBox.Items.Add(row[1].ToString());

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            MountQueryResult(projectList, $"SELECT project.project_id AS ProjectID, project.project_NAME AS ProjectName, department.department_name AS DepartmentName FROM companydb.project LEFT JOIN companydb.department ON project.department_id = department.department_id;");
            addTaskBtn.Enabled = false;
            updateTaskBtn.Enabled = false;
            updateProjBtn.Enabled = false;
            addProjectBtn.Enabled = false;
            removeProjBtn.Enabled = false;
        }

        private void employeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedIndex = e.RowIndex;
            selectedProjectRow = projectList.Rows[selectedIndex];

            string projId = selectedProjectRow.Cells[0].Value.ToString();
            string projName = selectedProjectRow.Cells[1].Value.ToString();
            string selectedDept = selectedProjectRow.Cells[2].Value.ToString();

            updateProjectDepartment.SelectedItem = selectedDept;
            updateProjectInput.Text = projName;

            removeProjBtn.Enabled = true;
            removeProjBtn.BackColor = Color.Red;

            MountQueryResult(taskList, $"SELECT task_id AS TaskID, task_name AS TaskName, employee.name AS AssignedTo FROM task JOIN employee ON task.employee_id = employee.employee_id WHERE project_id = {projId};");



        }

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


                if (projectList.Rows.Count == 0)
                {
                    MessageBox.Show("No products found in the inventory", "No Product Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    

                }


                connection.Close();
            }
        }

        private void updateProjectInput_TextChanged(object sender, EventArgs e)
        {
 
            
            if(updateProjectInput.Text.Length > 0)
            {
                updateProjBtn.Enabled = true;
                updateProjBtn.BackColor = Color.Lime;
            }


            else
            {
                updateProjBtn.Enabled = false;
                updateProjBtn.BackColor = Color.Silver;
            }
        }

        private void updateProjBtn_Click(object sender, EventArgs e)
        {
            
            string selectedRowId = selectedProjectRow.Cells[0].Value.ToString();

            string selecetedDepartment = updateProjectDepartment.SelectedItem != null ? updateProjectDepartment.SelectedItem.ToString() : "";
            string newProjectName = updateProjectInput.Text;

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
                string query2 = $"UPDATE project SET project_name = '{newProjectName}', department_id = {id} WHERE project_id = {selectedRowId}";
                MySqlCommand cmd2 = connection.CreateCommand();
                cmd2.CommandText = query2;
                cmd2.ExecuteNonQuery();
                connection.Close();

                MountQueryResult(projectList, $"SELECT project.project_id AS ProjectID, project.project_NAME AS ProjectName, department.department_name AS DepartmentName FROM companydb.project LEFT JOIN companydb.department ON project.department_id = department.department_id;");

                updateProjectInput.Text = "";
                updateProjectDepartment.Text = "";
                updateProjectDepartment.SelectedIndex = -1;
                updateProjBtn.Enabled = false;

            }
        }

        private void AddEmployeeNameInput_TextChanged(object sender, EventArgs e)
        {
             if(addProjectNameInput.Text.Length > 0)
            {
                addProjectBtn.Enabled = true;
                addProjectBtn.BackColor = Color.Lime;
            }


            else
            {
                addProjectBtn.Enabled = false;
                addProjectBtn.BackColor = Color.Silver;
            }
        }

        private void addProjectBtn_Click(object sender, EventArgs e)
        {
            if(addProjectNameInput.Text.Length > 0)
            {
                string projName = addProjectNameInput.Text;
                string selecetedDepartment = addProjectDepartment.SelectedItem != null ? addProjectDepartment.SelectedItem.ToString() : "";
                string projDepartment = addProjectDepartment.Text;


                string query = $"SELECT * FROM department WHERE department_name = '{projDepartment}'";





                if (selecetedDepartment != "")
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
                    string query2 = $"INSERT INTO project (project_name, department_id) VALUES ('{projName}', {id})";
                    MySqlCommand cmd2 = connection.CreateCommand();
                    cmd2.CommandText = query2;
                    cmd2.ExecuteNonQuery();
                    connection.Close();

                    MountQueryResult(projectList, $"SELECT project.project_id AS ProjectID, project.project_NAME AS ProjectName, department.department_name AS DepartmentName FROM companydb.project LEFT JOIN companydb.department ON project.department_id = department.department_id;");

                    addProjectNameInput.Text = "";
                    addProjectDepartment.SelectedIndex = -1;
                    addProjectDepartment.Text = "";
                    addProjectBtn.Enabled = false;
                    selecetedDepartment = "";


                }
                else
                {
                    MessageBox.Show("No Department Selected");
                }



            }
            else
            {
                MessageBox.Show("Empty Fields found please insert data");
            }
        
        }

        private void removeProjBtn_Click(object sender, EventArgs e)
        {
           
                string project_id = selectedProjectRow.Cells[0].Value.ToString();

                connection.Open();
              
                string query = $"DELETE FROM project WHERE project_id = {project_id}";
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                connection.Close();

                addProjectNameInput.Text = "";
                addProjectDepartment.SelectedIndex = -1;
                addProjectDepartment.Text = "";
                addProjectBtn.Enabled = false;

                updateProjectInput.Text = "";
                updateProjectDepartment.Text = "";
                updateProjectDepartment.SelectedIndex = -1;
                updateProjBtn.Enabled = false;

                removeProjBtn.Enabled = false;
                removeProjBtn.BackColor = Color.Silver;

                MountQueryResult(projectList, $"SELECT employee.employee_id AS EmployeeID, employee.name AS EmployeeName, department.department_name AS DepartmentName FROM companydb.employee LEFT JOIN companydb.department ON employee.department_id = department.department_id;");

          
            
        }

        private void AssignToMouseDown(object sender, MouseEventArgs e)
        {

            try
            {
                connection.Open();
                MySqlCommand cmd = connection.CreateCommand();
                cmd.CommandText = "SELECT * FROM companydb.employee;";
                MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
                DataSet projList = new DataSet();
                adap.Fill(projList);


                if (assignedEmployeeBox.Items.Count != 0) 
                {
                    assignedEmployeeBox.Items.Clear();
                    foreach (DataTable projTable in projList.Tables)
                    {
                        foreach (DataRow row in projTable.Rows)
                        {


                            assignedEmployeeBox.Items.Add(row[1].ToString());

                        }

                    }
                } else
                {
                    foreach (DataTable projTable in projList.Tables)
                    {
                        foreach (DataRow row in projTable.Rows)
                        {


                            assignedEmployeeBox.Items.Add(row[1].ToString());

                        }

                    }
                }
                

                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        private void taskNameInput_TextChanged(object sender, EventArgs e)
        {


        
           

           if(taskNameInput.Text.Length > 0)
            {
                addTaskBtn.Enabled = true;
                addTaskBtn.BackColor = Color.Lime;

                updateTaskBtn.Enabled = true;
                updateTaskBtn.BackColor = Color.Lime;

                removeTaskBtn.Enabled = true;
                removeTaskBtn.BackColor = Color.Red;
            } 

           else
            {
                addTaskBtn.Enabled = false;
                addTaskBtn.BackColor = Color.Silver;

                updateTaskBtn.Enabled = false;
                updateTaskBtn.BackColor = Color.Silver;

                removeTaskBtn.Enabled = false;
                removeTaskBtn.BackColor = Color.Silver;
            }

            
        

        }

        private void addTaskBtn_Click(object sender, EventArgs e)
        {


            string selectedEmployee = assignedEmployeeBox.SelectedItem != null ? assignedEmployeeBox.SelectedItem.ToString() : "";
            string taskName = taskNameInput.Text;
            string query = $"SELECT * FROM employee WHERE name = '{selectedEmployee}'";
            string projId = selectedProjectRow.Cells[0].Value.ToString();





            if (selectedEmployee != "")
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
                        id = dr["employee_id"].ToString();

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
                string query2 = $"INSERT INTO task (task_name, project_id, employee_id) VALUES ('{taskName}', {projId}, {id})";
                MySqlCommand cmd2 = connection.CreateCommand();
                cmd2.CommandText = query2;
                cmd2.ExecuteNonQuery();
                connection.Close();

                MountQueryResult(taskList, $"SELECT task_id AS TaskID, task_name AS TaskName, employee.name AS AssignedTo FROM task JOIN employee ON task.employee_id = employee.employee_id WHERE project_id = {projId};");

                taskNameInput.Text = "";
                assignedEmployeeBox.Text = "";
                assignedEmployeeBox.SelectedIndex = -1;
               
         


            }
            else if(selectedProjectRow == null)
            {
                MessageBox.Show("No Project Selected");
            }
            else
            {
                MessageBox.Show("No Employee Selected");
            }



        }

        private void taskList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedIndex = e.RowIndex;
            selectedTaskRow = taskList.Rows[selectedIndex];

            taskNameInput.Text = selectedTaskRow.Cells[1].Value.ToString();

            assignedEmployeeBox.SelectedItem = selectedTaskRow.Cells[2].Value.ToString();
            assignedEmployeeBox.Text = selectedTaskRow.Cells[2].Value.ToString();

     
 
   
        }

        private void updateTaskBtn_Click(object sender, EventArgs e)
        {


            string selectedEmployee = assignedEmployeeBox.SelectedItem.ToString();
            string taskName = taskNameInput.Text;
            string query = $"SELECT * FROM employee WHERE name = '{selectedEmployee}'";
            string projId = selectedProjectRow.Cells[0].Value.ToString();



            if (selectedEmployee != "")
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
                        id = dr["employee_id"].ToString();

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


                string project_id = selectedProjectRow.Cells[0].Value.ToString();
                string taskId = selectedTaskRow.Cells[0].Value.ToString();

                connection.Open();
                string query2 = $"UPDATE task SET task_name = '{taskName}', employee_id = {id}, project_id = {project_id} WHERE task_id = {taskId}";
                MySqlCommand cmd2 = connection.CreateCommand();
                cmd2.CommandText = query2;
                cmd2.ExecuteNonQuery();
                connection.Close();

                MountQueryResult(taskList, $"SELECT task_id AS TaskID, task_name AS TaskName, employee.name AS AssignedTo FROM task JOIN employee ON task.employee_id = employee.employee_id WHERE project_id = {projId};");

                taskNameInput.Text = "";
                assignedEmployeeBox.Text = "";
                assignedEmployeeBox.SelectedIndex = -1;


            }
        }

        private void removeTaskBtn_Click(object sender, EventArgs e)
        {

            string project_id = selectedProjectRow.Cells[0].Value.ToString();

            connection.Open();

            string query = $"DELETE FROM task WHERE task_id = {selectedTaskRow.Cells[0].Value.ToString()}";
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            connection.Close();

            addProjectNameInput.Text = "";
            addProjectDepartment.SelectedIndex = -1;
            addProjectDepartment.Text = "";
            addProjectBtn.Enabled = false;

            updateProjectInput.Text = "";
            updateProjectDepartment.Text = "";
            updateProjectDepartment.SelectedIndex = -1;
            updateProjBtn.Enabled = false;

            removeProjBtn.Enabled = false;
            removeProjBtn.BackColor = Color.Silver;

            taskNameInput.Text = "";
            assignedEmployeeBox.Text = "";
            assignedEmployeeBox.SelectedIndex = -1;
            selectedTaskRow = null;

            MountQueryResult(taskList, $"SELECT task_id AS TaskID, task_name AS TaskName, employee.name AS AssignedTo FROM task JOIN employee ON task.employee_id = employee.employee_id WHERE project_id = {project_id};");

        }
    }
}
