using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRoll_Application
{
    public partial class LogIn : Form
    {
        bool focus = true;
        bool isValid = false;
        EmployeeForm ef;
        public LogIn()
        {
            InitializeComponent();
            this.password.GotFocus += password_GotFocus;
            this.username.GotFocus += username_GotFocus;
            this.password.LostFocus += password_LostFocus;
            this.username.LostFocus += username_LostFocus;
        }   
        public void setForm(EmployeeForm ef)
        {
            this.ef = ef;
            this.btnlogin.Focus();
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(username.Text.Equals("admin") && password.Text.Equals("admin"))
            {
                isValid = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorrect username or password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.ef.Closeisvalid(isValid);
        }
        private void username_GotFocus(object sender, EventArgs e)
        {

                if(this.username.ForeColor == System.Drawing.Color.DimGray)
                {
                    this.username.ForeColor = System.Drawing.Color.DarkBlue;
                    this.username.Text = "";
                    if (focus)
                    {
                        this.btnlogin.Focus();
                        focus = false;
                        this.username.ForeColor = System.Drawing.Color.DimGray;
                        this.username.Text = " Username";
                    }
                }
        }
        
        private void password_GotFocus(object sender, EventArgs e)
        {
            if(this.password.UseSystemPasswordChar == false)
            {
                this.password.ForeColor = System.Drawing.Color.DarkBlue;
                this.password.UseSystemPasswordChar = true;
                this.password.Text = "";
            }
            
        }

        private void username_LostFocus(object sender, EventArgs e)
        {
            if(username.Text=="")
            {
                this.username.ForeColor = System.Drawing.Color.DimGray;
                this.username.Text = " Username";
            }
        }

        private void password_LostFocus(object sender, EventArgs e)
        {
            if(password.Text=="")
            {
                this.password.ForeColor = System.Drawing.Color.DimGray;
                this.password.UseSystemPasswordChar = false;
                this.password.Text = " Password";
            }
            
        }
        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
