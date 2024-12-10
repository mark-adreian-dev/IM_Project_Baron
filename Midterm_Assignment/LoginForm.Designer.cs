namespace Midterm_Assignment
{
    partial class LoginForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addProductBtnPanel = new System.Windows.Forms.Panel();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.addProductBtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.productNameLabel);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.usernameInput);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.addProductBtnPanel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(30);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(574, 458);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Inter", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.Location = new System.Drawing.Point(33, 30);
            this.productNameLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(138, 52);
            this.productNameLabel.TabIndex = 33;
            this.productNameLabel.Text = "Login";
            this.productNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Username:";
            // 
            // usernameInput
            // 
            this.usernameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameInput.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameInput.Location = new System.Drawing.Point(33, 134);
            this.usernameInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.usernameInput.Multiline = true;
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(497, 45);
            this.usernameInput.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.passwordInput);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(33, 202);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 69);
            this.panel1.TabIndex = 31;
            // 
            // passwordInput
            // 
            this.passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordInput.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInput.Location = new System.Drawing.Point(0, 22);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.passwordInput.Multiline = true;
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(494, 45);
            this.passwordInput.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Password:";
            // 
            // addProductBtnPanel
            // 
            this.addProductBtnPanel.Controls.Add(this.addProductBtn);
            this.addProductBtnPanel.Location = new System.Drawing.Point(33, 304);
            this.addProductBtnPanel.Name = "addProductBtnPanel";
            this.addProductBtnPanel.Size = new System.Drawing.Size(497, 77);
            this.addProductBtnPanel.TabIndex = 32;
            // 
            // addProductBtn
            // 
            this.addProductBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.addProductBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addProductBtn.Font = new System.Drawing.Font("Inter SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.addProductBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addProductBtn.Location = new System.Drawing.Point(-13, -13);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Padding = new System.Windows.Forms.Padding(205, 0, 0, 0);
            this.addProductBtn.Size = new System.Drawing.Size(522, 102);
            this.addProductBtn.TabIndex = 1;
            this.addProductBtn.Text = "      Login";
            this.addProductBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addProductBtn.UseVisualStyleBackColor = false;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 458);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.addProductBtnPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel addProductBtnPanel;
        private System.Windows.Forms.Button addProductBtn;
    }
}