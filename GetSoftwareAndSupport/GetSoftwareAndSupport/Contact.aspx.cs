using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Script.Services;
using System.Web.Security;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GetSoftwareAndSupport
{
    public partial class Contact : Page
    {

      //  HttpContext context = HttpContext.Current;
        

        protected void Page_Init(object sender, EventArgs e)
        {


           
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

            }


            //try
            //{
            //    if (Session["Logged_in"] != null)
            //    {
            //        string str_read_login_var = Convert.ToString(Session["Logged_in"]);

            //        //////////////////////////////// If User is logged in 
            //        if (str_read_login_var == "True")
            //        {


            //            btn_logout.Visible = true;
            //        }
            //    }
            //    else
            //    {
            //        //////////////////////////////// If User is NOT logged in 

            //        btn_logout.Visible = false;
            //    }

            //}
            //catch (Exception ex)
            //{
            //    //////////////////////////////// If User is NOT logged in 
            //    btn_logout.Visible = false;

            //}

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

        }








        public static bool SaveCapturedImage(string data)
        {
            string fileName = DateTime.Now.ToString("dd-MM-yy hh-mm-ss");

           // Convert Base64 Encoded string to Byte Array.
             byte[] imageBytes = Convert.FromBase64String(data.Split(',')[1]);

          //  Save the Byte Array as Image File.
           //    string filePath = HttpContext.Current.Server.MapPath(string.Format("~/Captures/{0}.jpg", fileName));
           // File.WriteAllBytes(filePath, imageBytes);
            return true;
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