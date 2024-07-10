using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareInventorySys
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Loaded(object sender, EventArgs e)
        {
            
        }


        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MaximizeBtn_Click(object sender, EventArgs e)
        {
            int height = Screen.PrimaryScreen.WorkingArea.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;

            this.Size = new Size(width,height);
            MaximizeBtn.Enabled = false;
            MaximizeBtn.Visible = false;
            int x = width - this.Width;
            int y = height - this.Height;
            this.Location = new Point(x / 2, y / 2);




            categoryForm1.BackColor = Color.White;
         
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void RestoreDownBtn_Click(object sender, EventArgs e)
        {
            int height = Screen.PrimaryScreen.Bounds.Height;
            int width = Screen.PrimaryScreen.Bounds.Width;

            this.Size = new Size(1000, 600);
            MaximizeBtn.Enabled = true;
            MaximizeBtn.Visible = true;
            int x = width - this.Width;
            int y = height - this.Height;
            this.Location = new Point(x / 2, y / 2);
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            productForm1.BringToFront();
            DashboardBtn.BackColor = Color.Transparent;
            CategoryBtn.BackColor = Color.Transparent;
            SalesReportBtn.BackColor = Color.Transparent;
            ProductBtn.BackColor = Color.FromArgb(172, 153, 234);

        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            dashboardForm1.BringToFront();
            ProductBtn.BackColor = Color.Transparent;
            CategoryBtn.BackColor = Color.Transparent;
            SalesReportBtn.BackColor = Color.Transparent;
            DashboardBtn.BackColor = Color.FromArgb(172, 153, 234);
        }

        private void CategoryBtn_Click(object sender, EventArgs e)
        {
            categoryForm1.BringToFront();
            ProductBtn.BackColor = Color.Transparent;
            DashboardBtn.BackColor = Color.Transparent;
            SalesReportBtn.BackColor = Color.Transparent;
            CategoryBtn.BackColor = Color.FromArgb(172, 153, 234);

        }

        private void SalesReportBtn_Click(object sender, EventArgs e)
        {
            salesReportForm1.BringToFront();
            ProductBtn.BackColor = Color.Transparent;
            DashboardBtn.BackColor = Color.Transparent;
            CategoryBtn.BackColor = Color.Transparent;
            SalesReportBtn.BackColor = Color.FromArgb(172, 153, 234);
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            LogInForm loginpage = new LogInForm();
            loginpage.Show();
            this.Close();
        }
    }
}
