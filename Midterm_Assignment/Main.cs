using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterm_Assignment
{
 
    public partial class mainWindow : Form
    {
        
        DepartmentDashboard pointOfSaleDashboard;
        EmployeeDashboard inventoryDashboard;
        ProjectsDashboard transactionDashboard;

        String username = "";

        public mainWindow(String username) {
            this.username = username;
            InitializeComponent(); 
        }

        // Menu Clicked
        private void OnWindowLoad(object sender, EventArgs e) {
            posTitleLabel.Text = this.username;
            MountPointOfSaleDashboard(); 
        }
        private void PosMenuBtn_Click(object sender, EventArgs e)  { MountPointOfSaleDashboard(); }
        private void InventoryMenuBtn_Click(object sender, EventArgs e) { MountInventoryManagementDashboard(); }
        private void TransactionMenuBtn_Click(object sender, EventArgs e) { MountTransactionDashboard(); }

        //Menu Closed
        private void PointOfSaleDashboard_FormClosed(object sender, FormClosedEventArgs e) { pointOfSaleDashboard = null; }
        private void InventoryDashboard_FormClosed(object sender, FormClosedEventArgs e) { inventoryDashboard = null; }
        private void TransactionDashboard_FormClosed(object sender, FormClosedEventArgs e) { transactionDashboard = null; }

        //Mounting Forms Method
        private void MountPointOfSaleDashboard()
        {
            if (pointOfSaleDashboard == null)
            {
                pointOfSaleDashboard = new DepartmentDashboard();
                pointOfSaleDashboard.FormClosed += PointOfSaleDashboard_FormClosed;
                pointOfSaleDashboard.MdiParent = this;
                pointOfSaleDashboard.Show();
            } else
            {
                pointOfSaleDashboard.Activate();
            }
        }
        private void MountInventoryManagementDashboard()
        {
            if (inventoryDashboard == null)
            {
                inventoryDashboard = new EmployeeDashboard();
                inventoryDashboard.FormClosed += InventoryDashboard_FormClosed;
                inventoryDashboard.MdiParent = this;
                inventoryDashboard.Dock = DockStyle.Fill;
                inventoryDashboard.Show();
            }
            else { 
                inventoryDashboard.Activate();
            
            }       
        }
        private void MountTransactionDashboard()
        {
            if (transactionDashboard == null)
            {
                transactionDashboard = new ProjectsDashboard();
                transactionDashboard.FormClosed += TransactionDashboard_FormClosed;
                transactionDashboard.MdiParent = this;
                transactionDashboard.Dock = DockStyle.Fill;
                transactionDashboard.Show();
            }
            else
            {
                transactionDashboard.Activate();

            }
        }

        private void posTitleLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
