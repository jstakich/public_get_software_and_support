using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using System.Web.Security;

namespace GetSoftwareAndSupport
{
    public partial class PCI_Data : System.Web.UI.Page
    {
      



       
        protected void Page_Init(object sender, EventArgs e)
        {
           
            string decrypted_usernameq = "";
            string decrypted_passwordq = "";


            try
            {
                if (Session["Logged_in"] != null)
                {
                    string str_read_login_var = Convert.ToString(Session["Logged_in"]);

                    //////////////////////////////// If User is logged in 
                    if (str_read_login_var == "True")
                    {


                       // btn_logout.Visible = true;
                    }
                }
                else
                {
                    //////////////////////////////// If User is NOT logged in 
                    Response.Redirect("/Account/App_Logout");
                  //  btn_logout.Visible = false;
                }

            }
            catch (Exception ex)
            {
                //////////////////////////////// If User is NOT logged in 
              //  btn_logout.Visible = false;

            }














            try
            {




               

                string md = "";

                var connection = new Connection_Strings();
                MySql.Data.MySqlClient.MySqlConnection connection6 = new MySql.Data.MySqlClient.MySqlConnection(connection.prod_conn_string.ToString());

                decrypted_usernameq = Decrypt(Session["Username_to_use"].ToString());

                decrypted_passwordq = Decryptpassword(Session["Password_to_use"].ToString());


                md = Does_User_Have_Access_To_Project_1(connection6, decrypted_usernameq, decrypted_passwordq);

                if (md == "user has access")
                {


                }
                else
                {
                    Response.Redirect("/AccessDenied");
                }
            }
            catch (Exception ex)
            {
                
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                if (Session["Username_to_use"] != null)

                {
                    string decrypted_usernameq = Decrypt(Session["Username_to_use"].ToString());

                    // txt_email.Text = decrypted_usernameq.ToString();
                    textbox1.Value = decrypted_usernameq.ToString();
                    label_logged_in.Text = " Logged in as ... " + decrypted_usernameq.ToString();
                }
                else
                {
                    label_logged_in.Text = " Please log in.";
                }


            }
            catch (Exception ex)
            {


            }
            Label1.Text = "Enter a keyword within the doument and click search.";
            Label1.ForeColor = Color.Black;
            try
            {
                if (Session["Logged_in"] != null)
                {
                    string str_read_login_var = Convert.ToString(Session["Logged_in"]);

                    //////////////////////////////// If User is logged in 
                    if (str_read_login_var == "True")
                    {


                     //   btn_logout.Visible = true;
                    }
                }
                else
                {
                    //////////////////////////////// If User is NOT logged in 
                    Response.Redirect("/Account/App_Logout");
                  //  btn_logout.Visible = false;
                }

            }
            catch (Exception ex)
            {
                //  Write_to_log_file(ex.Message.ToString());
                Label1.Text = ex.Message.ToString();
                Label1.ForeColor = Color.Red;
                //////////////////////////////// If User is NOT logged in 
                //   btn_logout.Visible = false;

            }


            try
            {
                LinkButton_editaccountbutton.Visible = false;
                LinkButton_logoutbutton.Visible = false;
                LinkButton_loginbutton.Visible = true;

                if (Session["Logged_in"] != null)
                {
                    string str_read_login_var = Convert.ToString(Session["Logged_in"]);

                    //////////////////////////////// If User is logged in 
                    if (str_read_login_var == "True")
                    {

                        LinkButton_editaccountbutton.Visible = true;
                        LinkButton_logoutbutton.Visible = true;
                        LinkButton_loginbutton.Visible = false;


                    }
                }


            }
            catch (Exception ex)
            {
                string aa = ex.ToString();
                //  Write_to_log_file(ex.Message.ToString());
                Label1.Text = ex.Message.ToString();
                Label1.ForeColor = Color.Red;

            }
            //string decrypted_usernameq = "";
            //string decrypted_passwordq = "";
            //try
            //{
            //    if ((Session["Logged_in"] == null) || (Session["Username_to_use"] == null) || (Session["Password_to_use"] == null))
            //    {
            //        Response.Redirect("/Account/App_Logout");
            //    }
            //    else
            //    {

            //    } 
            //}
            //catch (Exception ex)
            //{

            //}



            //Page.Form.Attributes.Add("enctype", "multipart/form-data");






            //#region Set Connection_Type_And_String 

            //#endregion


            //    try
            //    {



            //    cn.connection_to_use = cs;


            //    string md = "";


            //    MySql.Data.MySqlClient.MySqlConnection connection6 = new MySql.Data.MySqlClient.MySqlConnection(cn.connection_to_use);

            //    decrypted_usernameq = Decrypt(Session["Username_to_use"].ToString());

            //    decrypted_passwordq = Decryptpassword(Session["Password_to_use"].ToString());


            //    md = Does_User_Have_Access_To_Project_1(connection6, decrypted_usernameq, decrypted_passwordq);

            //    if (md == "user has access")
            //    {


            //    }
            //    else
            //    {
            //        Response.Redirect("/AccessDenied");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Response.Redirect("/AccessDenied");
            //}

        }


        public string Decryptpassword(string cipherText)
        {



            try
            {

                string EncryptionKey = "62e24b33099d46e88389d72ef814219a";
                cipherText = cipherText.Replace(" ", "+");
                byte[] cipherBytes = Convert.FromBase64String(cipherText);
                using (Aes encryptor = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (System.IO.MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(cipherBytes, 0, cipherBytes.Length);
                            cs.Close();
                        }
                        cipherText = Encoding.Unicode.GetString(ms.ToArray());
                    }
                }
                return cipherText;


            }
            catch (Exception jerror1)
            {
                string jj = jerror1.ToString();


                // Error_Redirect("/Account/AccessDenied");
                Response.Redirect("/Account/App_Logout");
                return "";

            }



        }
        public string Decrypt(string cipherText)
        {



            try
            {

                string EncryptionKey = "62e24b33099d46e88389d72ef814219a";
                cipherText = cipherText.Replace(" ", "+");
                byte[] cipherBytes = Convert.FromBase64String(cipherText);
                using (Aes encryptor = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (System.IO.MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(cipherBytes, 0, cipherBytes.Length);
                            cs.Close();
                        }
                        cipherText = Encoding.Unicode.GetString(ms.ToArray());
                    }
                }
                return cipherText;


            }
            catch (Exception jerror1)
            {
                string jj = jerror1.ToString();


                // Error_Redirect("/Account/AccessDenied");
                Response.Redirect("/Account/App_Logout");
                return "";

            }



        }
        private string Does_User_Have_Access_To_Project_1(MySql.Data.MySqlClient.MySqlConnection The_connection, string The_email, string The_Password)
        {

            string modifiedstring = "";


            try
            {

                using (The_connection)
                {

                    //"create table getsoftware_users3( id INT NOT NULL AUTO_INCREMENT PRIMARY KEY , email VARCHAR(255) NOT NULL , password VARCHAR(255) NOT NULL , password_temp VARCHAR(255)  NULL , password_send INT  NULL , first_name VARCHAR(255) NOT NULL , middle_name VARCHAR(255) NOT NULL , last_name VARCHAR(255) NOT NULL , phone_number VARCHAR(255), Security_Question MEDIUMTEXT NOT NULL , Security_Answer MEDIUMTEXT NOT NULL , last_Login_date TIMESTAMP NOT NULL, the_date TIMESTAMP NOT NULL )"

                    //  string selectQueryString = "SELECT  email , password , password_temp , password_send  FROM   getsoftware_users3 where    email =  '" + The_Username + "' and  Password =  '" + The_Password + "' Limit 1;";
                    // string selectQueryString = "SELECT  email , password , password_temp , password_send  FROM   getsoftware_users3 where    email =  '" + The_Username + "'  Limit 1;";
                    string selectQueryString = "SELECT  email    FROM   Project1 where  (email =  '" + The_email + "' )";

                    MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(
                          selectQueryString, The_connection);
                    The_connection.Open();

                    MySql.Data.MySqlClient.MySqlDataReader reader = command.ExecuteReader();



                    if (reader.HasRows)
                    {
                        //while (reader.Read())
                        //{
                        //    /// if we found a row
                        //    modifiedstring = "1asdfartw56wesgbvasert4tqgw45tb";

                        //}
                        while (reader.Read())
                        {


                            modifiedstring = "user has access";



                        }

                    }
                    else
                    {

                    }


                    try

                    {


                        command.Dispose();

                    }
                    catch (Exception asfdasdf)
                    {
                        /// do nothing here
                        string la = asfdasdf.ToString();

                    }



                    try

                    {


                        reader.Close();

                    }
                    catch (Exception aaaa)
                    {
                        /// do nothing here
                        string la = aaaa.ToString();

                    }

                    try

                    {


                        The_connection.Close();


                    }
                    catch (Exception aaaaaaa)
                    {
                        /// do nothing here
                        string la = aaaaaaa.ToString();

                    }
                    try

                    {



                        The_connection.Dispose();

                    }
                    catch (Exception aaaaaaa)
                    {
                        /// do nothing here
                        string la = aaaaaaa.ToString();

                    }



                }
                return modifiedstring;
            }
            catch (Exception tttttt)
            {
                modifiedstring = "";
                string la = tttttt.ToString();
                return modifiedstring;
                /// End

            }

        }


        

        protected void cbox_include_Date_CheckedChanged(object sender, EventArgs e)
        {
            if (cbox_include_Date.Checked == true)
            {
                cbox_include_Date2.Checked = false;
                Code_Search_Click();
            }
             

              

        }

        protected void cbox_include_Date0_CheckedChanged(object sender, EventArgs e)
        {

            if (cbox_include_Date2.Checked == true)
            {
                cbox_include_Date.Checked = false;
                Code_Search_Click();
            }


        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            Label1.Text = "Enter a keyword within the doument and click search.";
            Label1.ForeColor = Color.Black;
            try
            {


                TextBox2.Text = "";

            GridView1.DataSource = null;
            GridView1.DataBind();
           // cbox_include_Date.Checked = false;
           // cbox_include_Date2.Checked = false;
            TextBox2.Text = "";
           // TextBox1.Text = "";
            BindData();

        }
            catch (Exception ex)
            {
                //  Write_to_log_file(ex.Message.ToString());
                Label1.Text = ex.Message.ToString();
                Label1.ForeColor = Color.Red;
            }
}

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            Code_Search_Click();
        }

        private void Code_Search_IT()
        {
            Label1.Text = "Enter a keyword within the doument and click search.";
            Label1.ForeColor = Color.Black;
            try
            {
                GridView1.DataSource = null;
                GridView1.DataBind();
                cbox_include_Date.Checked = false;
                cbox_include_Date2.Checked = false;
                TextBox2.Text = "";
                TextBox1aa.Text = "";
                BindData();

            }
            catch (Exception ex)
            {
                //  Write_to_log_file(ex.Message.ToString());
                Label1.Text = ex.Message.ToString();
                Label1.ForeColor = Color.Red;
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Code_Search_IT();
        }


        private void Code_Search_Click()
        {
            Label1.Text = "Enter a keyword within the doument and click search.";
            Label1.ForeColor = Color.Black;
            try
            {
                GridView1.DataSource = null;
                GridView1.DataBind();
                string aa = TextBox2.Text;


                // string string_date_only = : DateObject.ToString("MM/dd/yyyy");
                DateTime DateObject;
                string string_date_only = "";
                Label1.ForeColor = Color.Black;
                if ((cbox_include_Date.Checked == true) && (cbox_include_Date2.Checked == true))
                {
                    Label1.ForeColor = Color.Red;
                    Label1.Text = "Please select only one checkbox";


                    return;
                }
                /////  Use date without keyword in search ( Note Time is not included in search. )
                if (cbox_include_Date.Checked == true)
                {
                    if (TextBox2.Text == "")
                    {

                        Label1.ForeColor = Color.Red;
                        Label1.Text = "Please select a Date";


                        return;

                    }
                    else
                    {
                        {
                            DateObject = Convert.ToDateTime(TextBox2.Text);
                            //  string_date_only = DateObject.ToString("MM/dd/yyyy");
                            string_date_only = DateObject.ToString("yyyy/MM/dd");
                            lookupdata_by_Date_Only(string_date_only);
                            return;
                        }
                    }

                }

                /////  Use date with keyword in search
                if (cbox_include_Date2.Checked == true)
                {
                    if (TextBox1aa.Text.Replace(" ", "") == "")
                    {
                        Label1.ForeColor = Color.Red;
                        Label1.Text = "Please enter a keyword to search for.";
                        return;
                    }

                    if (TextBox1aa.Text == "")
                    {
                        Label1.ForeColor = Color.Red;
                        Label1.Text = "Please enter a keyword to search for.";
                        return;
                    }

                    if (TextBox2.Text == "")
                    {

                        Label1.ForeColor = Color.Red;
                        Label1.Text = "Please select a Date";
                        return;
                    }
                    else
                    {
                        DateObject = Convert.ToDateTime(TextBox2.Text);
                        string string_date__with_keyword = DateObject.ToString("yyyy/MM/dd");
                        lookupdata_by_Date_WithKeyword(TextBox1aa.Text, string_date__with_keyword);
                        return;
                    }





                }


                /////  Nothing is checked
                if (((cbox_include_Date.Checked == false)
                &&
                (cbox_include_Date2.Checked == false)

                )
                ||
                  (cbox_include_Date2.Checked == true)

                  )


                {
                    if (TextBox1aa.Text.Replace(" ", "") == "")
                    {
                        Label1.ForeColor = Color.Red;
                        Label1.Text = "Please enter a keyword to search for or check the Box Search Date Only and then select a date.";
                        return;
                    }

                    if (TextBox1aa.Text == "")
                    {
                        Label1.ForeColor = Color.Red;
                        Label1.Text = "Please enter a keyword to search for.";
                        return;
                    }
                    lookupdata(TextBox1aa.Text);
                    return;
                }




            }
            catch (Exception ex)
            {
                //  Write_to_log_file(ex.Message.ToString());
                Label1.Text = ex.Message.ToString();
                Label1.ForeColor = Color.Red;
            }
        }
            protected void Button1_Click(object sender, EventArgs e)
        {

            Code_Search_Click();
        }

        protected void BindData()
        {

            Label1.Text = "Enter a keyword within the doument and click search.";
            Label1.ForeColor = Color.Black;
            try
            {
                var connection = new Connection_Strings();

                connection.PCIDATA_prod_conn_string.ToString();
                
            using (MySqlConnection con = new MySqlConnection(connection.prod_conn_string.ToString()))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM `tbl_pci_compliant_Data2` WHERE 1"))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter())
                    {
                        cmd.Connection = con;
                        da.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }

        }
            catch (Exception ex)
            {
                //  Write_to_log_file(ex.Message.ToString());
                Label1.Text = ex.Message.ToString();
                Label1.ForeColor = Color.Red;
            }
}
        protected void lookupdata_by_Date_Only(string the_data_with_Date)
        {
            Label1.Text = "Enter a keyword within the doument and click search.";
            Label1.ForeColor = Color.Black;
            try
            {

                var connection = new Connection_Strings();
                using (MySqlConnection con = new MySqlConnection(connection.PCIDATA_prod_conn_string.ToString()))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM `tbl_pci_compliant_Data2` WHERE the_date BETWEEN '" + the_data_with_Date + " 00:00:00' AND '" + the_data_with_Date + " 23:59:59' ; "))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter())
                    {
                        cmd.Connection = con;
                        da.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }
            }
            catch (Exception ex)
            {
                //  Write_to_log_file(ex.Message.ToString());
                Label1.Text = ex.Message.ToString();
                Label1.ForeColor = Color.Red;
            }
        }

        protected void lookupdata_by_Date_WithKeyword(string the_data, string the_data_with_Date)
        {
            Label1.Text = "Enter a keyword within the doument and click search.";
            Label1.ForeColor = Color.Black;
            try
            {
                var connection = new Connection_Strings();
               
            using (MySqlConnection con = new MySqlConnection(connection.PCIDATA_prod_conn_string.ToString()))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM `tbl_pci_compliant_Data2` WHERE ( (column1 LIKE '%" + the_data + "%'  OR  column2 LIKE '%" + the_data + "%'  OR  column3 LIKE '%" + the_data + "%' OR  column4 LIKE '%" + the_data + "%'  OR  column5 LIKE '%" + the_data + "%'  OR  column6 LIKE '%" + the_data + "%'  OR  column7 LIKE '%" + the_data + "%' OR  column8 LIKE '%" + the_data + "%' OR  column9 LIKE '%" + the_data + "%'  OR  doc_name LIKE '%" + the_data + "%'   OR  user_name LIKE '%" + the_data + "%' ) And ( the_date BETWEEN '" + the_data_with_Date + " 00:00:00' AND '" + the_data_with_Date + " 23:59:59') )  ; "))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter())
                    {
                        cmd.Connection = con;
                        da.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }
        }
            catch (Exception ex)
            {
                //  Write_to_log_file(ex.Message.ToString());
                Label1.Text = ex.Message.ToString();
                Label1.ForeColor = Color.Red;
            }
}

        protected void lookupdata(string the_data)
        {
            Label1.Text = "Enter a keyword within the doument and click search.";
            Label1.ForeColor = Color.Black;
            try
            {
                var connection = new Connection_Strings();
                using (MySqlConnection con = new MySqlConnection(connection.PCIDATA_prod_conn_string.ToString()))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM `tbl_pci_compliant_Data2` WHERE column1 LIKE '%" + the_data + "%'  OR  column2 LIKE '%" + the_data + "%'  OR  column3 LIKE '%" + the_data + "%' OR  column4 LIKE '%" + the_data + "%'  OR  column5 LIKE '%" + the_data + "%'  OR  column6 LIKE '%" + the_data + "%'  OR  column7 LIKE '%" + the_data + "%' OR  column8 LIKE '%" + the_data + "%' OR  column9 LIKE '%" + the_data + "%'  OR  doc_name LIKE '%" + the_data + "%'   OR  user_name LIKE '%" + the_data + "%'   ; "))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter())
                    {
                        cmd.Connection = con;
                        da.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }
            }
            catch (Exception ex)
            {
                //  Write_to_log_file(ex.Message.ToString());
                Label1.Text = ex.Message.ToString();
                Label1.ForeColor = Color.Red;
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            Label1.Text = "Enter a keyword within the doument and click search.";
            Label1.ForeColor = Color.Black;
            try
            {
                GridView1.PageIndex = e.NewPageIndex;
            BindData();
        }
            catch (Exception ex)
            {
                //  Write_to_log_file(ex.Message.ToString());
                Label1.Text = ex.Message.ToString();
                Label1.ForeColor = Color.Red;
            }
}

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        protected void Logout_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    context.Session["Username_to_use"] = null;
            //    Session["Username_to_use"] = null;

            //    context.Session["Password_to_use"] = null;
            //    Session["Password_to_use"] = null;

            //    context.Session["Logged_in"] = null;
            //    Session["Logged_in"] = null;
            //    Response.Redirect("~/Account/App_Logout.aspx");
            //}
            //catch (Exception ex)
            //{

            //}
            #region kILL Session 

            try
            {
                //  context.Session["Username_to_use"] = null;
                //Session["Username_to_use"] = null;

                ////  context.Session["Password_to_use"] = null;
                //Session["Password_to_use"] = null;

                //// context.Session["Logged_in"] = null;
                //Session["Logged_in"] = null;


            }
            catch (Exception the_error1)
            {
                string sadf = the_error1.Message.ToString();

            }



            #region Abandon Session 
            try

            {
                HttpContext.Current.Session.Abandon();
            }

            catch (Exception the_err)

            {

                string the_errd = the_err.ToString();

            }

            try

            {
                HttpContext.Current.Session.Contents.Abandon();
            }

            catch (Exception the_err)

            {

                string the_errd = the_err.ToString();

            }

            try

            {
                HttpContext.Current.Session.Contents.RemoveAll();
            }

            catch (Exception the_err)

            {

                string the_errd = the_err.ToString();

            }

            try

            {
                HttpContext.Current.Session.Clear();
            }

            catch (Exception the_err)

            {

                string the_errd = the_err.ToString();

            }

            try

            {
                HttpContext.Current.Session.RemoveAll();
            }

            catch (Exception the_err)

            {

                string the_errd = the_err.ToString();

            }








            try

            {
                Session.Abandon();
            }

            catch (Exception the_err)

            {

                string the_errd = the_err.ToString();

            }


            try

            {
                Session.Contents.Abandon();
            }

            catch (Exception the_err)

            {

                string the_errd = the_err.ToString();

            }

            try

            {
                Session.Contents.RemoveAll();
            }

            catch (Exception the_err)

            {

                string the_errd = the_err.ToString();

            }

            try

            {
                Session.Clear();
            }

            catch (Exception the_err)

            {

                string the_errd = the_err.ToString();

            }

            try

            {
                Session.RemoveAll();
            }

            catch (Exception the_err)

            {

                string the_errd = the_err.ToString();

            }





            try
            {

                //  Response.Redirect("~/Account/App_Logout");

            }
            catch (Exception jerror1FF)
            {
                ///Do nothing
                string jj = jerror1FF.ToString();


            }

            #endregion
            try
            {

                FormsAuthentication.SignOut();
                Session.Clear();  // This may not be needed -- but can't hurt
                Session.Abandon();

                // Clear authentication cookie
                HttpCookie rFormsCookie = new HttpCookie(FormsAuthentication.FormsCookieName, "");
                rFormsCookie.Expires = DateTime.Now.AddYears(-1);
                Response.Cookies.Add(rFormsCookie);

                // Clear session cookie 
                HttpCookie rSessionCookie = new HttpCookie("ASP.NET_SessionId", "");
                rSessionCookie.Expires = DateTime.Now.AddYears(-1);
                Response.Cookies.Add(rSessionCookie);



                Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(2));
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.Cache.SetNoStore();

                HttpContext.Current.Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(2));
                HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.NoCache);
                HttpContext.Current.Response.Cache.SetNoStore();


                //HttpContext.Current.Response.Cache.SetExpires(DateTime.UtcNow.AddDays(-1));
                //HttpContext.Current.Response.Cache.SetValidUntilExpires(false); 
                //HttpContext.Current.Response.Cache.SetRevalidation(HttpCacheRevalidation.AllCaches);
                //HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.NoCache);
                //HttpContext.Current.Response.Cache.SetNoStore();
                //HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache); 







                //FormsAuthentication.SignOut();
                //Session.Abandon();

                //// clear authentication cookie
                //HttpCookie cookie1 = new HttpCookie(FormsAuthentication.FormsCookieName, "");
                //cookie1.Expires = DateTime.Now.AddYears(-1);
                //Response.Cookies.Add(cookie1);

                //// clear session cookie (not necessary for your current problem but i would recommend you do it anyway)
                //SessionStateSection sessionStateSection = (SessionStateSection)WebConfigurationManager.GetSection("system.web/sessionState");
                //HttpCookie cookie2 = new HttpCookie(sessionStateSection.CookieName, "");
                //cookie2.Expires = DateTime.Now.AddYears(-1);
                //Response.Cookies.Add(cookie2);

                // FormsAuthentication.RedirectToLoginPage();
                Response.Redirect("~/Account/App_Logout");
            }
            catch (Exception jerror1FF)
            {
                ///Do nothing
                string jj = jerror1FF.ToString();


            }

            #endregion
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            try
            {

                Response.Redirect("~/Account/Login");
            }
            catch (Exception ex)
            {

            }
        }

        protected void Edit_Account_Click(object sender, EventArgs e)
        {
            try
            {


                Response.Redirect("/Edit_Account");
            }
            catch (Exception ex)
            {

            }
        }


        protected void Default_Click(object sender, EventArgs e)
        {
            try
            {


                Response.Redirect("/Default");
            }
            catch (Exception ex)
            {

            }
        }

        protected void About_Click(object sender, EventArgs e)
        {
            try
            {


                Response.Redirect("/About");
            }
            catch (Exception ex)
            {

            }
        }

        protected void ContactUS_Click(object sender, EventArgs e)
        {
            try
            {


                Response.Redirect("/Contact");
            }
            catch (Exception ex)
            {

            }
        }

        protected void run_this(object sender, EventArgs e)
        {
            object Sender_Object_A = null;
            EventArgs EventArgs_B = null;

            try
            {
                Button1_Click(Sender_Object_A, EventArgs_B);
            }
            catch (Exception jerror1FF)
            {

                string eee = jerror1FF.ToString();

            }
        }
    }
}