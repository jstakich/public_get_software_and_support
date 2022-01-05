using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GetSoftwareAndSupport
{
    public partial class EditProfilePicture : System.Web.UI.UserControl
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
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                if (Session["Username_to_use"] != null)

                {
                    string decrypted_usernameq = Decrypt(Session["Username_to_use"].ToString());

                    // txt_email.Text = decrypted_usernameq.ToString();
                    textbox1.Value = decrypted_usernameq.ToString().ToLower();
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
                // Label1.Text = ex.Message.ToString();
                //  Label1.ForeColor = Color.Red;
                //////////////////////////////// If User is NOT logged in 
                //   btn_logout.Visible = false;

            }

        }

        private static string Does_email_exist(MySql.Data.MySqlClient.MySqlConnection The_connection, string The_Email)
        {

            string modifiedstring = "";


            try
            {

                using (The_connection)
                {


                    string selectQueryString = "SELECT * FROM   getsoftware_users3 where    email =  '" + The_Email + "'  Limit 1;";

                    MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(
                          selectQueryString, The_connection);
                    The_connection.Open();

                    MySql.Data.MySqlClient.MySqlDataReader reader = command.ExecuteReader();



                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            /// if we found a row
                            modifiedstring = "1asdfartw56wesgbvasert4tqgw45tbasdfasrea";

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
        protected void Upload_File(object sender, EventArgs e)
        {
            string decrypted_usernameq = "";
            lbl_upload_Status.Text = "";
            string does_that_email_exist = "";
            try
            {
                decrypted_usernameq = textbox1.Value;
                var connection = new Connection_Strings();
                MySql.Data.MySqlClient.MySqlConnection connection6 = new MySql.Data.MySqlClient.MySqlConnection(connection.prod_conn_string.ToString());

                does_that_email_exist = Does_email_exist(connection6, decrypted_usernameq);



                if (does_that_email_exist == "1asdfartw56wesgbvasert4tqgw45tbasdfasrea")
                {
                    //// Update the picture instead of inserting it
                    //lbl_message.Visible = true;
                    //lbl_message.Text = "That email already exists in our database. Please login.";
                    //txt_username.Focus();
                    //return;

                }

            }
            catch (Exception nerrordd)
            {
                //////////////////no need to read error
                string noerror = nerrordd.ToString();
                lbl_upload_Status.Text = nerrordd.Message.ToString();
            }





            if (customFile.Value != null)
            //if (FileUpload1.HasFile)
            {
                string sss = "stop";
                try
                {
                    string filename = Path.GetFileName(customFile.PostedFile.FileName);
                    string contentTypeuploaded = customFile.PostedFile.ContentType;

                    if (contentTypeuploaded.ToLower().StartsWith("image") == true)
                    {
                        using (Stream fs = customFile.PostedFile.InputStream)
                        {
                            DateTime theDate1 = DateTime.Now;

                            //create table profile_images( id INT NOT NULL AUTO_INCREMENT PRIMARY KEY , email VARCHAR(255) NOT NULL , The_Image MEDIUMBLOB NOT NULL , Block TIMESTAMP NOT NULL, the_date TIMESTAMP NOT NULL )
                            using (BinaryReader br = new BinaryReader(fs))
                            {
                                byte[] bytes = br.ReadBytes((Int32)fs.Length);
                                var connection = new Connection_Strings();
                                using (MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection(connection.prod_conn_string.ToString()))
                                {

                                    string query = "";
                                    if (does_that_email_exist == "1asdfartw56wesgbvasert4tqgw45tbasdfasrea")
                                    {
                                        //// Update the picture instead of inserting it
                                        //lbl_message.Visible = true;
                                        //lbl_message.Text = "That email already exists in our database. Please login.";
                                        //txt_username.Focus();
                                        //return;
                                        query = "UPDATE  profile_images  SET  The_Image = @The_Image WHERE   email =  '" + decrypted_usernameq + "'";

                                        using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query))
                                        {
                                            cmd.Connection = con;

                                            cmd.Parameters.AddWithValue("@The_Image", bytes);
                                            string imageUrl = "data:image/jpg;base64," + Convert.ToBase64String(bytes);
                                            Image5.ImageUrl = imageUrl;

                                            //DataRowView dr = (DataRowView)e.Row.DataItem;
                                            //string imageUrl = "data:image/jpg;base64," + Convert.ToBase64String((byte[])dr["The_Image"]);
                                            //(e.Row.FindControl("Image1") as Image).ImageUrl = imageUrl;


                                            con.Open();
                                            cmd.ExecuteNonQuery();
                                            con.Close();
                                            lbl_upload_Status.Text = "Profile picture was updated.";
                                        }
                                    }
                                    else
                                    {
                                        query = "INSERT INTO profile_images(" +
                                     "email, " +
                                     "The_Image, " +
                                        "Block, " +
                                             "the_date " +
                                     ") VALUES (" +
                                    "@email" +
                                     ", " +
                                      "@The_Image" +
                                     ", " +
                                        "@Block" +
                                     ", " +
                                        "@the_date" +
                                     ")";
                                        using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query))
                                        {
                                            cmd.Connection = con;
                                            cmd.Parameters.AddWithValue("@email", decrypted_usernameq);
                                            cmd.Parameters.AddWithValue("@The_Image", bytes);
                                            string imageUrl = "data:image/jpg;base64," + Convert.ToBase64String(bytes);
                                            Image5.ImageUrl = imageUrl;
                                            cmd.Parameters.AddWithValue("@Block", 0);
                                            cmd.Parameters.AddWithValue("@the_date", theDate1);
                                            con.Open();
                                            cmd.ExecuteNonQuery();
                                            con.Close();
                                            lbl_upload_Status.Text = "Profile picture was inserted.";
                                        }
                                    }





                                }
                            }
                        }
                        //Response.Redirect(Request.Url.AbsoluteUri);
                    }
                    else
                    {
                        lbl_upload_Status.Text = "That file doesn't appear to be an image . Please try again.";
                    }
                }
                catch (Exception eee)
                {
                    string jj = eee.ToString();
                    lbl_upload_Status.Text = eee.Message.ToString();
                }
            }
            else
            {
                lbl_upload_Status.Text = "Please upload a profile picture.";
                return;
            }

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
    }
}