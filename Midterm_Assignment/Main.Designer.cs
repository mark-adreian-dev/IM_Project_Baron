using System;

namespace Midterm_Assignment
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.posMenuPanel = new System.Windows.Forms.Panel();
            this.PosMenuBtn = new System.Windows.Forms.Button();
            this.inventoryMenuPanel = new System.Windows.Forms.Panel();
            this.InventoryMenuBtn = new System.Windows.Forms.Button();
            this.transactionMenuPanel = new System.Windows.Forms.Panel();
            this.TransactionMenuBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.posTitleLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.posMenuPanel.SuspendLayout();
            this.inventoryMenuPanel.SuspendLayout();
            this.transactionMenuPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 625);
            this.panel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.posMenuPanel);
            this.flowLayoutPanel1.Controls.Add(this.inventoryMenuPanel);
            this.flowLayoutPanel1.Controls.Add(this.transactionMenuPanel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 93);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(310, 532);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // posMenuPanel
            // 
            this.posMenuPanel.Controls.Add(this.PosMenuBtn);
            this.posMenuPanel.Location = new System.Drawing.Point(3, 53);
            this.posMenuPanel.Name = "posMenuPanel";
            this.posMenuPanel.Size = new System.Drawing.Size(307, 52);
            this.posMenuPanel.TabIndex = 3;
            // 
            // PosMenuBtn
            // 
            this.PosMenuBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PosMenuBtn.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PosMenuBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.PosMenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("PosMenuBtn.Image")));
            this.PosMenuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PosMenuBtn.Location = new System.Drawing.Point(-7, -5);
            this.PosMenuBtn.Name = "PosMenuBtn";
            this.PosMenuBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.PosMenuBtn.Size = new System.Drawing.Size(322, 65);
            this.PosMenuBtn.TabIndex = 0;
            this.PosMenuBtn.Text = "          Department";
            this.PosMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PosMenuBtn.UseVisualStyleBackColor = false;
            this.PosMenuBtn.Click += new System.EventHandler(this.PosMenuBtn_Click);
            // 
            // inventoryMenuPanel
            // 
            this.inventoryMenuPanel.Controls.Add(this.InventoryMenuBtn);
            this.inventoryMenuPanel.Location = new System.Drawing.Point(3, 111);
            this.inventoryMenuPanel.Name = "inventoryMenuPanel";
            this.inventoryMenuPanel.Size = new System.Drawing.Size(307, 52);
            this.inventoryMenuPanel.TabIndex = 4;
            // 
            // InventoryMenuBtn
            // 
            this.InventoryMenuBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.InventoryMenuBtn.Font = new System.Drawing.Font("Inter Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryMenuBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.InventoryMenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("InventoryMenuBtn.Image")));
            this.InventoryMenuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InventoryMenuBtn.Location = new System.Drawing.Point(-7, -5);
            this.InventoryMenuBtn.Name = "InventoryMenuBtn";
            this.InventoryMenuBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.InventoryMenuBtn.Size = new System.Drawing.Size(322, 65);
            this.InventoryMenuBtn.TabIndex = 0;
            this.InventoryMenuBtn.Text = "        Employee";
            this.InventoryMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InventoryMenuBtn.UseVisualStyleBackColor = false;
            this.InventoryMenuBtn.Click += new System.EventHandler(this.InventoryMenuBtn_Click);
            // 
            // transactionMenuPanel
            // 
            this.transactionMenuPanel.Controls.Add(this.TransactionMenuBtn);
            this.transactionMenuPanel.Location = new System.Drawing.Point(3, 169);
            this.transactionMenuPanel.Name = "transactionMenuPanel";
            this.transactionMenuPanel.Size = new System.Drawing.Size(307, 52);
            this.transactionMenuPanel.TabIndex = 5;
            // 
            // TransactionMenuBtn
            // 
            this.TransactionMenuBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TransactionMenuBtn.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionMenuBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.TransactionMenuBtn.Image = ((System.Drawing.Image)(resources.GetObject("TransactionMenuBtn.Image")));
            this.TransactionMenuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransactionMenuBtn.Location = new System.Drawing.Point(-7, -5);
            this.TransactionMenuBtn.Name = "TransactionMenuBtn";
            this.TransactionMenuBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.TransactionMenuBtn.Size = new System.Drawing.Size(322, 65);
            this.TransactionMenuBtn.TabIndex = 0;
            this.TransactionMenuBtn.Text = "          Projects";
            this.TransactionMenuBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransactionMenuBtn.UseVisualStyleBackColor = false;
            this.TransactionMenuBtn.Click += new System.EventHandler(this.TransactionMenuBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.posTitleLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 93);
            this.panel2.TabIndex = 0;
            // 
            // posTitleLabel
            // 
            this.posTitleLabel.AutoSize = true;
            this.posTitleLabel.Font = new System.Drawing.Font("Inter ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.posTitleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.posTitleLabel.Location = new System.Drawing.Point(22, 33);
            this.posTitleLabel.Name = "posTitleLabel";
            this.posTitleLabel.Size = new System.Drawing.Size(256, 29);
            this.posTitleLabel.TabIndex = 0;
            this.posTitleLabel.Text = "Mark Adreian Ramos";
            this.posTitleLabel.Click += new System.EventHandler(this.posTitleLabel_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 625);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IM PROJECT";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OnWindowLoad);
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.posMenuPanel.ResumeLayout(false);
            this.inventoryMenuPanel.ResumeLayout(false);
            this.transactionMenuPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label posTitleLabel;
        private System.Windows.Forms.Panel posMenuPanel;
        private System.Windows.Forms.Button PosMenuBtn;
        private System.Windows.Forms.Panel inventoryMenuPanel;
        private System.Windows.Forms.Button InventoryMenuBtn;
        private System.Windows.Forms.Panel transactionMenuPanel;
        private System.Windows.Forms.Button TransactionMenuBtn;
    }
}

