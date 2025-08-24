using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();

            // Custom Password text box setting through code
            // We can do it directly from propertise of textPassword also
            //textPassword.PasswordChar = '@';
            //textPassword.UseSystemPasswordChar = false;

            // Custom Password text box but of running system
            textPassword.UseSystemPasswordChar = true;
        }

        //Click event for login button
        private void button1_Click(object sender, EventArgs e)
        {
            string email = textEmail.Text;
            string password = textPassword.Text;

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter your email!");
            }
            else if(string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter valid password.");
            }
            else
            {
                MessageBox.Show("Login successful!");
            }
        }
    }
}
