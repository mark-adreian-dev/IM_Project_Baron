namespace Midterm_Assignment
{
    partial class ProjectsDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.headerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.inventoryTitle = new System.Windows.Forms.Label();
            this.projectList = new System.Windows.Forms.DataGridView();
            this.taskList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.employeeName = new System.Windows.Forms.Label();
            this.addProjectNameInput = new System.Windows.Forms.TextBox();
            this.addProjectDepartment = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addProjectBtn = new System.Windows.Forms.Button();
            this.updateProjBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.updateProjectDepartment = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.updateProjectInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addTaskBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.assignedEmployeeBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.taskNameInput = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.updateTaskBtn = new System.Windows.Forms.Button();
            this.removeProjBtn = new System.Windows.Forms.Button();
            this.removeTaskBtn = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskList)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.inventoryTitle);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Padding = new System.Windows.Forms.Padding(32, 32, 0, 0);
            this.headerPanel.Size = new System.Drawing.Size(1590, 104);
            this.headerPanel.TabIndex = 3;
            // 
            // inventoryTitle
            // 
            this.inventoryTitle.AutoSize = true;
            this.inventoryTitle.Font = new System.Drawing.Font("Inter ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventoryTitle.Location = new System.Drawing.Point(35, 32);
            this.inventoryTitle.Name = "inventoryTitle";
            this.inventoryTitle.Size = new System.Drawing.Size(190, 39);
            this.inventoryTitle.TabIndex = 0;
            this.inventoryTitle.Text = "PROJECTS";
            this.inventoryTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // projectList
            // 
            this.projectList.AllowUserToAddRows = false;
            this.projectList.AllowUserToResizeColumns = false;
            this.projectList.AllowUserToResizeRows = false;
            this.projectList.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.projectList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.projectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectList.EnableHeadersVisualStyles = false;
            this.projectList.Location = new System.Drawing.Point(42, 129);
            this.projectList.MultiSelect = false;
            this.projectList.Name = "projectList";
            this.projectList.ReadOnly = true;
            this.projectList.RowHeadersVisible = false;
            this.projectList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            this.projectList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.projectList.RowTemplate.Height = 25;
            this.projectList.Size = new System.Drawing.Size(954, 402);
            this.projectList.TabIndex = 6;
            this.projectList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeList_CellContentClick);
            // 
            // taskList
            // 
            this.taskList.AllowUserToAddRows = false;
            this.taskList.AllowUserToResizeColumns = false;
            this.taskList.AllowUserToResizeRows = false;
            this.taskList.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.taskList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.taskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskList.EnableHeadersVisualStyles = false;
            this.taskList.Location = new System.Drawing.Point(1023, 210);
            this.taskList.MultiSelect = false;
            this.taskList.Name = "taskList";
            this.taskList.ReadOnly = true;
            this.taskList.RowHeadersVisible = false;
            this.taskList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            this.taskList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.taskList.RowTemplate.Height = 25;
            this.taskList.Size = new System.Drawing.Size(539, 321);
            this.taskList.TabIndex = 7;
            this.taskList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.taskList_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1016, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "TASKS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add Project";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // employeeName
            // 
            this.employeeName.AutoSize = true;
            this.employeeName.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeName.Location = new System.Drawing.Point(39, 595);
            this.employeeName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(112, 19);
            this.employeeName.TabIndex = 19;
            this.employeeName.Text = "Project Name";
            // 
            // addProjectNameInput
            // 
            this.addProjectNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addProjectNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProjectNameInput.Location = new System.Drawing.Point(42, 622);
            this.addProjectNameInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.addProjectNameInput.Multiline = true;
            this.addProjectNameInput.Name = "addProjectNameInput";
            this.addProjectNameInput.Size = new System.Drawing.Size(472, 66);
            this.addProjectNameInput.TabIndex = 18;
            this.addProjectNameInput.TextChanged += new System.EventHandler(this.AddEmployeeNameInput_TextChanged);
            // 
            // addProjectDepartment
            // 
            this.addProjectDepartment.Font = new System.Drawing.Font("Inter SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProjectDepartment.FormattingEnabled = true;
            this.addProjectDepartment.Location = new System.Drawing.Point(42, 723);
            this.addProjectDepartment.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.addProjectDepartment.Name = "addProjectDepartment";
            this.addProjectDepartment.Size = new System.Drawing.Size(472, 33);
            this.addProjectDepartment.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 696);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Department";
            // 
            // addProjectBtn
            // 
            this.addProjectBtn.BackColor = System.Drawing.Color.Silver;
            this.addProjectBtn.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProjectBtn.Location = new System.Drawing.Point(43, 779);
            this.addProjectBtn.Name = "addProjectBtn";
            this.addProjectBtn.Size = new System.Drawing.Size(471, 63);
            this.addProjectBtn.TabIndex = 26;
            this.addProjectBtn.Text = "Add Project";
            this.addProjectBtn.UseVisualStyleBackColor = false;
            this.addProjectBtn.Click += new System.EventHandler(this.addProjectBtn_Click);
            // 
            // updateProjBtn
            // 
            this.updateProjBtn.BackColor = System.Drawing.Color.Silver;
            this.updateProjBtn.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProjBtn.Location = new System.Drawing.Point(530, 779);
            this.updateProjBtn.Name = "updateProjBtn";
            this.updateProjBtn.Size = new System.Drawing.Size(466, 63);
            this.updateProjBtn.TabIndex = 32;
            this.updateProjBtn.Text = "Update Project";
            this.updateProjBtn.UseVisualStyleBackColor = false;
            this.updateProjBtn.Click += new System.EventHandler(this.updateProjBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(526, 696);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 19);
            this.label4.TabIndex = 31;
            this.label4.Text = "Department";
            // 
            // updateProjectDepartment
            // 
            this.updateProjectDepartment.Font = new System.Drawing.Font("Inter SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProjectDepartment.FormattingEnabled = true;
            this.updateProjectDepartment.Location = new System.Drawing.Point(529, 723);
            this.updateProjectDepartment.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.updateProjectDepartment.Name = "updateProjectDepartment";
            this.updateProjectDepartment.Size = new System.Drawing.Size(467, 33);
            this.updateProjectDepartment.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(525, 595);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Project Name";
            // 
            // updateProjectInput
            // 
            this.updateProjectInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateProjectInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProjectInput.Location = new System.Drawing.Point(529, 622);
            this.updateProjectInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.updateProjectInput.Multiline = true;
            this.updateProjectInput.Name = "updateProjectInput";
            this.updateProjectInput.Size = new System.Drawing.Size(467, 66);
            this.updateProjectInput.TabIndex = 28;
            this.updateProjectInput.TextChanged += new System.EventHandler(this.updateProjectInput_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(526, 550);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 23);
            this.label6.TabIndex = 27;
            this.label6.Text = "Update Project";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addTaskBtn
            // 
            this.addTaskBtn.BackColor = System.Drawing.Color.Silver;
            this.addTaskBtn.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTaskBtn.Location = new System.Drawing.Point(1023, 779);
            this.addTaskBtn.Name = "addTaskBtn";
            this.addTaskBtn.Size = new System.Drawing.Size(539, 63);
            this.addTaskBtn.TabIndex = 38;
            this.addTaskBtn.Text = "Add Task";
            this.addTaskBtn.UseVisualStyleBackColor = false;
            this.addTaskBtn.Click += new System.EventHandler(this.addTaskBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1019, 696);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 19);
            this.label7.TabIndex = 37;
            this.label7.Text = "Assigned To";
            // 
            // assignedEmployeeBox
            // 
            this.assignedEmployeeBox.Font = new System.Drawing.Font("Inter SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignedEmployeeBox.FormattingEnabled = true;
            this.assignedEmployeeBox.Location = new System.Drawing.Point(1022, 723);
            this.assignedEmployeeBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.assignedEmployeeBox.Name = "assignedEmployeeBox";
            this.assignedEmployeeBox.Size = new System.Drawing.Size(540, 33);
            this.assignedEmployeeBox.TabIndex = 36;
            this.assignedEmployeeBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AssignToMouseDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1018, 595);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 19);
            this.label8.TabIndex = 35;
            this.label8.Text = "Task Name";
            // 
            // taskNameInput
            // 
            this.taskNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taskNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskNameInput.Location = new System.Drawing.Point(1022, 622);
            this.taskNameInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.taskNameInput.Multiline = true;
            this.taskNameInput.Name = "taskNameInput";
            this.taskNameInput.Size = new System.Drawing.Size(540, 66);
            this.taskNameInput.TabIndex = 34;
            this.taskNameInput.TextChanged += new System.EventHandler(this.taskNameInput_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1019, 550);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 23);
            this.label9.TabIndex = 33;
            this.label9.Text = "Add Task";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updateTaskBtn
            // 
            this.updateTaskBtn.BackColor = System.Drawing.Color.Silver;
            this.updateTaskBtn.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTaskBtn.Location = new System.Drawing.Point(1023, 848);
            this.updateTaskBtn.Name = "updateTaskBtn";
            this.updateTaskBtn.Size = new System.Drawing.Size(539, 63);
            this.updateTaskBtn.TabIndex = 39;
            this.updateTaskBtn.Text = "Update Selected Task";
            this.updateTaskBtn.UseVisualStyleBackColor = false;
            this.updateTaskBtn.Click += new System.EventHandler(this.updateTaskBtn_Click);
            // 
            // removeProjBtn
            // 
            this.removeProjBtn.BackColor = System.Drawing.Color.Silver;
            this.removeProjBtn.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeProjBtn.Location = new System.Drawing.Point(43, 848);
            this.removeProjBtn.Name = "removeProjBtn";
            this.removeProjBtn.Size = new System.Drawing.Size(953, 63);
            this.removeProjBtn.TabIndex = 40;
            this.removeProjBtn.Text = "Remove Project";
            this.removeProjBtn.UseVisualStyleBackColor = false;
            this.removeProjBtn.Click += new System.EventHandler(this.removeProjBtn_Click);
            // 
            // removeTaskBtn
            // 
            this.removeTaskBtn.BackColor = System.Drawing.Color.Silver;
            this.removeTaskBtn.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeTaskBtn.Location = new System.Drawing.Point(1023, 917);
            this.removeTaskBtn.Name = "removeTaskBtn";
            this.removeTaskBtn.Size = new System.Drawing.Size(539, 63);
            this.removeTaskBtn.TabIndex = 41;
            this.removeTaskBtn.Text = "Remove Task";
            this.removeTaskBtn.UseVisualStyleBackColor = false;
            this.removeTaskBtn.Click += new System.EventHandler(this.removeTaskBtn_Click);
            // 
            // ProjectsDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1590, 1014);
            this.Controls.Add(this.removeTaskBtn);
            this.Controls.Add(this.removeProjBtn);
            this.Controls.Add(this.updateTaskBtn);
            this.Controls.Add(this.addTaskBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.assignedEmployeeBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.taskNameInput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.updateProjBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.updateProjectDepartment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.updateProjectInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addProjectBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addProjectDepartment);
            this.Controls.Add(this.employeeName);
            this.Controls.Add(this.addProjectNameInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.taskList);
            this.Controls.Add(this.projectList);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjectsDashboard";
            this.Text = "TransactionDashBoard";
            this.Load += new System.EventHandler(this.TransactionDashboard_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel headerPanel;
        private System.Windows.Forms.Label inventoryTitle;
        private System.Windows.Forms.DataGridView projectList;
        private System.Windows.Forms.DataGridView taskList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label employeeName;
        private System.Windows.Forms.TextBox addProjectNameInput;
        private System.Windows.Forms.ComboBox addProjectDepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addProjectBtn;
        private System.Windows.Forms.Button updateProjBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox updateProjectDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox updateProjectInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addTaskBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox assignedEmployeeBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox taskNameInput;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button updateTaskBtn;
        private System.Windows.Forms.Button removeProjBtn;
        private System.Windows.Forms.Button removeTaskBtn;
    }
}