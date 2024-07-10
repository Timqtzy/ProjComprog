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
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
        }

        public int count = 0;
        private void LoadingScreen_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            progressBar1.Width += 50;
            if(label1.Text == "Loading")
            {
                label1.Text = "Loading.";
            }
            else if(label1.Text == "Loading.")
            {
                label1.Text = "Loading..";
            }
            else if (label1.Text == "Loading..")
            {
                label1.Text = "Loading...";
            }
            else if( label1.Text == "Loading...")
            {
                label1.Text = "Loading";
            }
           

            if (progressBar1.Width >= 680)
            {
                Console.WriteLine("Done");
                timer1.Enabled = false;
                LogInForm loginform = new LogInForm();
                this.Hide();
                loginform.Show();
            }
        }
    }
}
