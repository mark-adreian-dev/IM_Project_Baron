using System.Drawing;
using System.Windows.Forms;

namespace Midterm_Assignment
{
    partial class DepartmentDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.headerPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.title = new System.Windows.Forms.Label();
            this.dividerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.processSection = new System.Windows.Forms.Panel();
            this.productListPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.departmentList = new System.Windows.Forms.DataGridView();
            this.deleteDepartmentBtn = new System.Windows.Forms.Button();
            this.searchPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchBarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.productInput = new System.Windows.Forms.TextBox();
            this.searchBtnPanel = new System.Windows.Forms.Panel();
            this.searchBtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.searchBarLabel = new System.Windows.Forms.Label();
            this.checkoutSectionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addDepartmentInput = new System.Windows.Forms.TextBox();
            this.checkoutBtnPanel = new System.Windows.Forms.Panel();
            this.addDepartmentBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.updateDepartmentInput = new System.Windows.Forms.TextBox();
            this.updateDepartmentBtn = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.dividerPanel.SuspendLayout();
            this.processSection.SuspendLayout();
            this.productListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentList)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.searchBarPanel.SuspendLayout();
            this.searchBtnPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.checkoutSectionPanel.SuspendLayout();
            this.checkoutBtnPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.title);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Padding = new System.Windows.Forms.Padding(32, 32, 0, 0);
            this.headerPanel.Size = new System.Drawing.Size(1606, 104);
            this.headerPanel.TabIndex = 0;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Inter ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(35, 32);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(241, 39);
            this.title.TabIndex = 0;
            this.title.Text = "DEPARTMENT";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dividerPanel
            // 
            this.dividerPanel.ColumnCount = 2;
            this.dividerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dividerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dividerPanel.Controls.Add(this.processSection, 0, 0);
            this.dividerPanel.Controls.Add(this.checkoutSectionPanel, 1, 0);
            this.dividerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dividerPanel.Location = new System.Drawing.Point(0, 104);
            this.dividerPanel.Name = "dividerPanel";
            this.dividerPanel.RowCount = 1;
            this.dividerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.dividerPanel.Size = new System.Drawing.Size(1606, 949);
            this.dividerPanel.TabIndex = 1;
            // 
            // processSection
            // 
            this.processSection.Controls.Add(this.productListPanel);
            this.processSection.Controls.Add(this.searchPanel);
            this.processSection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.processSection.Location = new System.Drawing.Point(3, 3);
            this.processSection.Name = "processSection";
            this.processSection.Size = new System.Drawing.Size(797, 943);
            this.processSection.TabIndex = 0;
            // 
            // productListPanel
            // 
            this.productListPanel.Controls.Add(this.departmentList);
            this.productListPanel.Controls.Add(this.deleteDepartmentBtn);
            this.productListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productListPanel.Location = new System.Drawing.Point(0, 132);
            this.productListPanel.Name = "productListPanel";
            this.productListPanel.Padding = new System.Windows.Forms.Padding(30, 10, 30, 30);
            this.productListPanel.Size = new System.Drawing.Size(797, 811);
            this.productListPanel.TabIndex = 2;
            // 
            // departmentList
            // 
            this.departmentList.AllowUserToAddRows = false;
            this.departmentList.AllowUserToResizeColumns = false;
            this.departmentList.AllowUserToResizeRows = false;
            this.departmentList.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Inter", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.departmentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.departmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentList.EnableHeadersVisualStyles = false;
            this.departmentList.Location = new System.Drawing.Point(33, 13);
            this.departmentList.MultiSelect = false;
            this.departmentList.Name = "departmentList";
            this.departmentList.ReadOnly = true;
            this.departmentList.RowHeadersVisible = false;
            this.departmentList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            this.departmentList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.departmentList.RowTemplate.Height = 25;
            this.departmentList.Size = new System.Drawing.Size(729, 653);
            this.departmentList.TabIndex = 0;
            this.departmentList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductListTable_CellContentClick);
            // 
            // deleteDepartmentBtn
            // 
            this.deleteDepartmentBtn.BackColor = System.Drawing.Color.Silver;
            this.deleteDepartmentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.deleteDepartmentBtn.Font = new System.Drawing.Font("Inter SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteDepartmentBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteDepartmentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteDepartmentBtn.Location = new System.Drawing.Point(33, 672);
            this.deleteDepartmentBtn.Name = "deleteDepartmentBtn";
            this.deleteDepartmentBtn.Padding = new System.Windows.Forms.Padding(300, 0, 0, 0);
            this.deleteDepartmentBtn.Size = new System.Drawing.Size(729, 102);
            this.deleteDepartmentBtn.TabIndex = 19;
            this.deleteDepartmentBtn.Text = "Remove Department";
            this.deleteDepartmentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteDepartmentBtn.UseVisualStyleBackColor = false;
            this.deleteDepartmentBtn.Click += new System.EventHandler(this.deleteDepartment_Click);
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.searchBarPanel);
            this.searchPanel.Controls.Add(this.searchBarLabel);
            this.searchPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.searchPanel.Location = new System.Drawing.Point(0, 0);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Padding = new System.Windows.Forms.Padding(30, 30, 30, 0);
            this.searchPanel.Size = new System.Drawing.Size(797, 132);
            this.searchPanel.TabIndex = 1;
            // 
            // searchBarPanel
            // 
            this.searchBarPanel.Controls.Add(this.productInput);
            this.searchBarPanel.Controls.Add(this.searchBtnPanel);
            this.searchBarPanel.Controls.Add(this.dataGridView2);
            this.searchBarPanel.Location = new System.Drawing.Point(33, 60);
            this.searchBarPanel.Name = "searchBarPanel";
            this.searchBarPanel.Size = new System.Drawing.Size(729, 39);
            this.searchBarPanel.TabIndex = 3;
            // 
            // productInput
            // 
            this.productInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productInput.Location = new System.Drawing.Point(3, 3);
            this.productInput.Multiline = true;
            this.productInput.Name = "productInput";
            this.productInput.Size = new System.Drawing.Size(576, 32);
            this.productInput.TabIndex = 0;
            this.productInput.TextChanged += new System.EventHandler(this.ProductInput_TextChanged);
            // 
            // searchBtnPanel
            // 
            this.searchBtnPanel.Controls.Add(this.searchBtn);
            this.searchBtnPanel.Location = new System.Drawing.Point(585, 3);
            this.searchBtnPanel.Name = "searchBtnPanel";
            this.searchBtnPanel.Size = new System.Drawing.Size(141, 32);
            this.searchBtnPanel.TabIndex = 2;
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.searchBtn.Font = new System.Drawing.Font("Inter SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.searchBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.Location = new System.Drawing.Point(-10, -10);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.searchBtn.Size = new System.Drawing.Size(167, 53);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "      Search";
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 41);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 3;
            // 
            // searchBarLabel
            // 
            this.searchBarLabel.AutoSize = true;
            this.searchBarLabel.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBarLabel.Location = new System.Drawing.Point(33, 28);
            this.searchBarLabel.Name = "searchBarLabel";
            this.searchBarLabel.Size = new System.Drawing.Size(241, 29);
            this.searchBarLabel.TabIndex = 4;
            this.searchBarLabel.Text = "Search Department";
            // 
            // checkoutSectionPanel
            // 
            this.checkoutSectionPanel.Controls.Add(this.label1);
            this.checkoutSectionPanel.Controls.Add(this.label4);
            this.checkoutSectionPanel.Controls.Add(this.addDepartmentInput);
            this.checkoutSectionPanel.Controls.Add(this.checkoutBtnPanel);
            this.checkoutSectionPanel.Controls.Add(this.label2);
            this.checkoutSectionPanel.Controls.Add(this.panel1);
            this.checkoutSectionPanel.Controls.Add(this.updateDepartmentInput);
            this.checkoutSectionPanel.Controls.Add(this.updateDepartmentBtn);
            this.checkoutSectionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkoutSectionPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.checkoutSectionPanel.Location = new System.Drawing.Point(806, 3);
            this.checkoutSectionPanel.Name = "checkoutSectionPanel";
            this.checkoutSectionPanel.Padding = new System.Windows.Forms.Padding(30);
            this.checkoutSectionPanel.Size = new System.Drawing.Size(797, 943);
            this.checkoutSectionPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Department Name";
            // 
            // addDepartmentInput
            // 
            this.addDepartmentInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addDepartmentInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDepartmentInput.Location = new System.Drawing.Point(33, 136);
            this.addDepartmentInput.Multiline = true;
            this.addDepartmentInput.Name = "addDepartmentInput";
            this.addDepartmentInput.Size = new System.Drawing.Size(729, 66);
            this.addDepartmentInput.TabIndex = 14;
            this.addDepartmentInput.TextChanged += new System.EventHandler(this.AddDepartmentInput_TextChanged);
            // 
            // checkoutBtnPanel
            // 
            this.checkoutBtnPanel.Controls.Add(this.addDepartmentBtn);
            this.checkoutBtnPanel.Location = new System.Drawing.Point(33, 208);
            this.checkoutBtnPanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 50);
            this.checkoutBtnPanel.Name = "checkoutBtnPanel";
            this.checkoutBtnPanel.Size = new System.Drawing.Size(729, 77);
            this.checkoutBtnPanel.TabIndex = 13;
            // 
            // addDepartmentBtn
            // 
            this.addDepartmentBtn.BackColor = System.Drawing.Color.Silver;
            this.addDepartmentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addDepartmentBtn.Font = new System.Drawing.Font("Inter SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDepartmentBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addDepartmentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addDepartmentBtn.Location = new System.Drawing.Point(0, -13);
            this.addDepartmentBtn.Name = "addDepartmentBtn";
            this.addDepartmentBtn.Padding = new System.Windows.Forms.Padding(300, 0, 0, 0);
            this.addDepartmentBtn.Size = new System.Drawing.Size(742, 102);
            this.addDepartmentBtn.TabIndex = 1;
            this.addDepartmentBtn.Text = "Add Department";
            this.addDepartmentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addDepartmentBtn.UseVisualStyleBackColor = false;
            this.addDepartmentBtn.Click += new System.EventHandler(this.AddDepartment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 335);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = " Update Department";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.idLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(33, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 28);
            this.panel1.TabIndex = 22;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel.Location = new System.Drawing.Point(694, -3);
            this.idLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 19);
            this.idLabel.TabIndex = 23;
            this.idLabel.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(521, -3);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "DepartmentID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, -3);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Department Name";
            // 
            // updateDepartmentInput
            // 
            this.updateDepartmentInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.updateDepartmentInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDepartmentInput.Location = new System.Drawing.Point(33, 451);
            this.updateDepartmentInput.Multiline = true;
            this.updateDepartmentInput.Name = "updateDepartmentInput";
            this.updateDepartmentInput.Size = new System.Drawing.Size(729, 66);
            this.updateDepartmentInput.TabIndex = 20;
            this.updateDepartmentInput.TextChanged += new System.EventHandler(this.updateDepartmentInput_TextChanged);
            // 
            // updateDepartmentBtn
            // 
            this.updateDepartmentBtn.BackColor = System.Drawing.Color.Silver;
            this.updateDepartmentBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.updateDepartmentBtn.Enabled = false;
            this.updateDepartmentBtn.Font = new System.Drawing.Font("Inter SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateDepartmentBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updateDepartmentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateDepartmentBtn.Location = new System.Drawing.Point(33, 523);
            this.updateDepartmentBtn.Name = "updateDepartmentBtn";
            this.updateDepartmentBtn.Padding = new System.Windows.Forms.Padding(300, 0, 0, 0);
            this.updateDepartmentBtn.Size = new System.Drawing.Size(729, 102);
            this.updateDepartmentBtn.TabIndex = 18;
            this.updateDepartmentBtn.Text = "Update Department";
            this.updateDepartmentBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.updateDepartmentBtn.UseVisualStyleBackColor = false;
            this.updateDepartmentBtn.Click += new System.EventHandler(this.updateDepartmentBtn_Click);
            // 
            // DepartmentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1606, 1053);
            this.Controls.Add(this.dividerPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DepartmentDashboard";
            this.ShowIcon = false;
            this.Text = "PointOfSaleDashboard";
            this.Load += new System.EventHandler(this.PointOfSaleDashboard_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.dividerPanel.ResumeLayout(false);
            this.processSection.ResumeLayout(false);
            this.productListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.departmentList)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.searchBarPanel.ResumeLayout(false);
            this.searchBarPanel.PerformLayout();
            this.searchBtnPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.checkoutSectionPanel.ResumeLayout(false);
            this.checkoutSectionPanel.PerformLayout();
            this.checkoutBtnPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel headerPanel;
        private Label title;
        private TableLayoutPanel dividerPanel;
        private Panel processSection;
        private TextBox productInput;
        private FlowLayoutPanel searchPanel;
        private Panel searchBtnPanel;
        private Button searchBtn;
        private FlowLayoutPanel productListPanel;
        private DataGridView departmentList;
        private FlowLayoutPanel searchBarPanel;
        private Label searchBarLabel;
        private DataGridView dataGridView2;
        private FlowLayoutPanel checkoutSectionPanel;
        private Panel checkoutBtnPanel;
        private Button addDepartmentBtn;
        private Label label1;
        private Label label4;
        private TextBox addDepartmentInput;
        private Button deleteDepartmentBtn;
        private Label label2;
        private Label label3;
        private TextBox updateDepartmentInput;
        private Button updateDepartmentBtn;
        private Panel panel1;
        private Label idLabel;
        private Label label5;
    }
}