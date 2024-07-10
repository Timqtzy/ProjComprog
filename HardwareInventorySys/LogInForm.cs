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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }
        string uname = "Admin";
        string pword = "Admin123";

        string Username;
        string Password;

        private void LogInForm_Load(object sender, EventArgs e)
        {
            
        }

        private void HidePwordBtn_Click(object sender, EventArgs e)
        {
            PasswordTxt.PasswordChar = '•';
            ShowPwordBtn.Visible = true;
            ShowPwordBtn.Enabled = true;
        }

        private void PasswordTxt_TextChanged(object sender, EventArgs e)
        {
            Password = PasswordTxt.Text;

            if (UsernameTxt.Text != "" && UsernameTxt.Text != null)
            {
                usernameWarnTxt.ForeColor = Color.Red;
                usernameWarnTxt.Text = "";
            }
            if (PasswordTxt.Text != "" && PasswordTxt.Text != null)
            {
                passwordWarnTxt.ForeColor = Color.Red;
                passwordWarnTxt.Text = "";
            }
        }

        private void ShowPwordBtn_Click(object sender, EventArgs e)
        {
            PasswordTxt.PasswordChar = '\0';
            
            ShowPwordBtn.Visible = false;
            ShowPwordBtn.Enabled = false;
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            if(UsernameTxt.Text == "" || UsernameTxt.Text == null)
            {
                usernameWarnTxt.ForeColor = Color.Red;
                usernameWarnTxt.Text = "This field is required!";
            }
            if (PasswordTxt.Text == "" || PasswordTxt.Text == null)
            {
                passwordWarnTxt.ForeColor = Color.Red;
                passwordWarnTxt.Text = "This field is required!";
            }

            Console.WriteLine(Username);
            Console.WriteLine(Password);
    
            if(Username == uname && Password == pword)
            {
                Console.WriteLine("Log in Successfully!");
                MainForm mainform = new MainForm();
                this.Close();
                mainform.Show();    
            }
            else
            {
                
                Console.WriteLine("Incorrect!");
            }
        }

        private void UsernameTxt_TextChanged(object sender, EventArgs e)
        {
            
            Username = UsernameTxt.Text;
            if (UsernameTxt.Text != "" && UsernameTxt.Text != null)
            {
                usernameWarnTxt.ForeColor = Color.FromArgb(247, 56, 89);
                usernameWarnTxt.Text = "";
            }
            if (PasswordTxt.Text != "" && PasswordTxt.Text != null)
            {
                passwordWarnTxt.ForeColor = Color.FromArgb(247, 56, 89);
                passwordWarnTxt.Text = "";
            }
        }

        private void usernameWarnTxt_Click(object sender, EventArgs e)
        {

        }
    }
}
