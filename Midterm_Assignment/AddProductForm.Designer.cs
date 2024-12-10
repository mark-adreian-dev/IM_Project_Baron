namespace Midterm_Assignment
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.productName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.quantityInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.unitPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addProductBtnPanel = new System.Windows.Forms.Panel();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.addProductBtnPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.productNameLabel);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.productName);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.addProductBtnPanel);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(30);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(573, 519);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Font = new System.Drawing.Font("Inter", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.Location = new System.Drawing.Point(33, 30);
            this.productNameLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 30);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(284, 52);
            this.productNameLabel.TabIndex = 33;
            this.productNameLabel.Text = "Add Product";
            this.productNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Product Name:";
            // 
            // productName
            // 
            this.productName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productName.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.Location = new System.Drawing.Point(33, 134);
            this.productName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.productName.Multiline = true;
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(497, 45);
            this.productName.TabIndex = 30;
            this.productName.TextChanged += new System.EventHandler(this.productName_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.quantityInput);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.unitPrice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(33, 202);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 69);
            this.panel1.TabIndex = 31;
            // 
            // quantityInput
            // 
            this.quantityInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.quantityInput.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityInput.Location = new System.Drawing.Point(376, 22);
            this.quantityInput.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.quantityInput.Multiline = true;
            this.quantityInput.Name = "quantityInput";
            this.quantityInput.Size = new System.Drawing.Size(121, 45);
            this.quantityInput.TabIndex = 26;
            this.quantityInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Quantity_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Quantity:";
            // 
            // unitPrice
            // 
            this.unitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unitPrice.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPrice.Location = new System.Drawing.Point(0, 22);
            this.unitPrice.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.unitPrice.Multiline = true;
            this.unitPrice.Name = "unitPrice";
            this.unitPrice.Size = new System.Drawing.Size(370, 45);
            this.unitPrice.TabIndex = 24;
            this.unitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UnitPrice_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Unit Price:";
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
            this.addProductBtn.BackColor = System.Drawing.Color.Black;
            this.addProductBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addProductBtn.Font = new System.Drawing.Font("Inter SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.addProductBtn.Image = ((System.Drawing.Image)(resources.GetObject("addProductBtn.Image")));
            this.addProductBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addProductBtn.Location = new System.Drawing.Point(-13, -13);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Padding = new System.Windows.Forms.Padding(185, 0, 0, 0);
            this.addProductBtn.Size = new System.Drawing.Size(522, 102);
            this.addProductBtn.TabIndex = 1;
            this.addProductBtn.Text = "         Add Product";
            this.addProductBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addProductBtn.UseVisualStyleBackColor = false;
            this.addProductBtn.Click += new System.EventHandler(this.AddProductBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(33, 387);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 24);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 76);
            this.panel2.TabIndex = 34;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Inter SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-13, -13);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(205, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(522, 102);
            this.button1.TabIndex = 1;
            this.button1.Text = "         Cancel";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 519);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProductForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.addProductBtnPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox productName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox quantityInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox unitPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel addProductBtnPanel;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}