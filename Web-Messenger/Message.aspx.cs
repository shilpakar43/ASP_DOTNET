using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using MySqlX.XDevAPI.Relational;
using System.Xml.Linq;

namespace Kabindra_Project_Web_III
{
    public partial class Message : System.Web.UI.Page
    {
        MySqlConnection conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["sess_username"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            Page.Title = "Dashboard Page";
            lblUsername.Text = "Welcome, " + Session["sess_username"];

            //receiver
            string searchUsername = Request.QueryString["username"];
            string msgReceiver = searchUsername;
            //sender
            string msgSender = "" + Session["sess_username"];

            //SendREceive
            string SendReceive = msgSender + "_@#_" + msgReceiver;
            //ReceiveSend
            string ReceiveSend = msgReceiver + "_@#_" + msgSender;
            //Chatting With
            lblChattingWith.Text = "Chatting With " + msgReceiver;

            //display sender message
            try
            {
                conn.Open();
                using (conn)
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT sender,txtmessage FROM message where sendreceive='"+SendReceive+ "' or sendreceive='"+ReceiveSend+"' order by id desc LIMIT 10 ;", conn))
                    {
                        using (MySqlDataAdapter da = new MySqlDataAdapter())
                        {
                            da.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                da.Fill(dt);
                                gridBookList.DataSource = dt;
                                gridBookList.DataBind();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblUsername.Text = ex.Message;
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

        /*logout*/
        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Login.aspx");
        }

        /*send message*/
        protected void btnSend_Click(object sender, EventArgs e)
        {
            string searchUsername = Request.QueryString["username"];
            string msgSender = "" + Session["sess_username"];
            //string msgSender = "ram";
            string msgReceiver = searchUsername;
            string msgSendReceive = msgSender +"_@#_" + msgReceiver;
            string msgMessage = txtMessage.Text;
            txtMessage.Text = "";

            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("insert into message(sender,receiver,sendreceive,txtmessage) values(@sender,@receiver,@sendreceive, @txtmessage)", conn);
                cmd.Parameters.AddWithValue("@sender", msgSender);
                cmd.Parameters.AddWithValue("@receiver", msgReceiver);
                cmd.Parameters.AddWithValue("@sendreceive", msgSendReceive);
                cmd.Parameters.AddWithValue("@txtmessage", msgMessage);

                int count = cmd.ExecuteNonQuery();
                if (count == 1)
                {
                    lblResult.Text = "Messange Send";
                }
                else
                {
                    lblResult.Text = "Message Send failed";
                }
            }
            catch (MySqlException ex)
            {
                lblResult.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            Page_Load(sender, e);
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
        //Refresh
        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            Page_Load(sender, e);
        }
    }   
}