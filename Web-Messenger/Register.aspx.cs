using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using MySqlX.XDevAPI.Relational;
using System.Diagnostics;
using System.Security.Policy;
namespace Kabindra_Project_Web_III
{
    public partial class Register : System.Web.UI.Page
    {
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Registration Data";
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            int error = 0;
            errName.Text = errEmail.Text = errPassword.Text = errPhone.Text = errGender.Text = errFaculty.Text = "";

            string name = txtName.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string faculty = txtFaculty.Text;
            string semister = txtSemister.Text;
            string roll = txtRoll.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string gender = txtGender.Text;
            string dob = txtDob.Text;

            if (name == "")
            {
                lblResult.Text = "Enter Name";
                error++;
            }
            if (username == "")
            {
                lblResult.Text = "Enter Username";
                error++;
            }
            if (password == "")
            {
                lblResult.Text = "Enter Password";
                error++;
            }
            if (faculty == "")
            {
                lblResult.Text = "Enter Faculty";
                error++;
            }
            if (semister == "")
            {
                lblResult.Text = "Enter semister";
                error++;
            }
            if (roll == "")
            {
                lblResult.Text = "Enter roll";
                error++;
            }
            if (email == "")
            {
                lblResult.Text = "Enter Email";
                error++;
            }
            if (phone == "")
            {
                lblResult.Text = "Enter Phone";
                error++;
            }
            if (gender == "")
            {
                lblResult.Text = "Enter Gender";
                error++;
            }
            if (dob == "")
            {
                lblResult.Text = "Enter dob";
                error++;
            }
            

            if (error == 0)
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("insert into userdata(name,username,password,faculty,semister,roll,email,phone,gender,dob) values(@name,@username,@password, @faculty, @semister, @roll,@email,@phone,@gender,@dob)", conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@faculty", faculty);
                    cmd.Parameters.AddWithValue("@semister", semister);
                    cmd.Parameters.AddWithValue("@roll", roll);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@dob", dob);

                    int count = cmd.ExecuteNonQuery();
                    if (count == 1)
                    {
                        lblResult.Text = "Registration success";
                    }
                    else
                    {
                        lblResult.Text = "Registration failed";
                    }
                    //close connection
                }
                catch (MySqlException ex1)
                {
                    lblResult.Text = ex1.Message;
                }
                catch (Exception ex)
                {
                    lblResult.Text = ex.Message;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}