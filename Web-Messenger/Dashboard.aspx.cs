using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace Kabindra_Project_Web_III
{
    public partial class Dashboard : System.Web.UI.Page
    {
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            //Dashboard
            if (Session["sess_username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            Page.Title = "Dashboard Page";
            lblText.Text = "Welcome, " + Session["sess_username"];

            /*profile*/
            string msgSender = "" + Session["sess_username"];
            try
            {
                conn.Open();
                using (conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM userdata where username='"+msgSender+"';", conn))
                    {
                        using (MySqlDataAdapter da = new MySqlDataAdapter())
                        {
                            da.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);
                                idDisplayProfile.DataSource = dt;
                                idDisplayProfile.DataBind();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errOnline.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            //online
            try
            {
                conn.Open();
                using (conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT username FROM userdata;", conn))
                    {
                        using (MySqlDataAdapter da = new MySqlDataAdapter())
                        {
                            da.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);
                                idOnline.DataSource = dt;
                                idOnline.DataBind();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                errOnline.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }

        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Login.aspx");
        }

        //redirect messanger
        protected void btnSearchUsername_Click(object sender, EventArgs e)
        {
            string searchUsername = txtsearchUsername.Text;
            errSearchUsername.Text = "";
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT username FROM userdata where username = @username ", conn);
                cmd.Parameters.AddWithValue("@username", searchUsername);

                object result = cmd.ExecuteScalar();
                if (result == null) 
                {
                    errSearchUsername.Text = "username invalid";
                }
                else
                {
                    Response.Redirect("./Message.aspx?username=" + searchUsername);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }
    }
}