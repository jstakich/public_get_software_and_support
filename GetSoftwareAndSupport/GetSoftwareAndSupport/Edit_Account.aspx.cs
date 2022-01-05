using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GetSoftwareAndSupport
{
    public partial class Edit_Accout : System.Web.UI.Page
    {
        // HttpContext context = HttpContext.Current;


         
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


                      //  btn_logout.Visible = true;
                    }
                }
                else
                {
                    //////////////////////////////// If User is NOT logged in 
                    Response.Redirect("/Account/App_Logout");
                 //   btn_logout.Visible = false;
                }

            }
            catch (Exception ex)
            {
                //////////////////////////////// If User is NOT logged in 
              //  btn_logout.Visible = false;

            }




           

            string md = "";

            try
            {


                var connection = new Connection_Strings();

                
                MySql.Data.MySqlClient.MySqlConnection connection6 = new MySql.Data.MySqlClient.MySqlConnection(connection.prod_conn_string.ToString());

                decrypted_usernameq = Decrypt(Session["Username_to_use"].ToString());

                decrypted_passwordq = Decryptpassword(Session["Password_to_use"].ToString());


                md = verify_email(connection6, decrypted_usernameq, decrypted_passwordq);

            }
            catch (Exception ex)
            {

            }





            if (md == "found it.")
            {
                try
                {
                    var connection = new Connection_Strings();
                    MySql.Data.MySqlClient.MySqlConnection connection7 = new MySql.Data.MySqlClient.MySqlConnection(connection.prod_conn_string.ToString());

                decrypted_usernameq = Decrypt(Session["Username_to_use"].ToString());

                decrypted_passwordq = Decryptpassword(Session["Password_to_use"].ToString());
                Read_Username_And_Password(connection7, decrypted_usernameq, decrypted_passwordq);
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                try
                {

                    Response.Redirect("/AccessDenied");


                }
                catch (Exception ex)
                {

                }

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
                if (Session["Logged_in"] != null)
                {
                    string str_read_login_var = Convert.ToString(Session["Logged_in"]);

                    //////////////////////////////// If User is logged in 
                    if (str_read_login_var == "True")
                    {


                      //  btn_logout.Visible = true;
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




            //// It is a postback
            //string md = "";

            //try
            //{



            //    MySql.Data.MySqlClient.MySqlConnection connection6 = new MySql.Data.MySqlClient.MySqlConnection(cn.connection_to_use);

            //    decrypted_usernameq = Decrypt(Session["Username_to_use"].ToString());

            //    decrypted_passwordq = Decryptpassword(Session["Password_to_use"].ToString());


            //    md = verify_email(connection6, decrypted_usernameq, decrypted_passwordq);

            //}
            //    catch (Exception ex)
            //    {

            //    }





            //if (md == "found it.")
            //{

            //}
            //else
            //{
            //    try
            //    {

            //        Response.Redirect("/AccessDenied");


            //    }
            //    catch (Exception ex)
            //    {

            //    }

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

        private string verify_email(MySql.Data.MySqlClient.MySqlConnection The_connection, string The_Username, string The_Password)
        {

            string modifiedstring = "";


            try
            {

                using (The_connection)
                {

                    //"create table getsoftware_users3( id INT NOT NULL AUTO_INCREMENT PRIMARY KEY , email VARCHAR(255) NOT NULL , password VARCHAR(255) NOT NULL , password_temp VARCHAR(255)  NULL , password_send INT  NULL , first_name VARCHAR(255) NOT NULL , middle_name VARCHAR(255) NOT NULL , last_name VARCHAR(255) NOT NULL , phone_number VARCHAR(255), Security_Question MEDIUMTEXT NOT NULL , Security_Answer MEDIUMTEXT NOT NULL , last_Login_date TIMESTAMP NOT NULL, the_date TIMESTAMP NOT NULL )"

                    //  string selectQueryString = "SELECT  email , password , password_temp , password_send  FROM   getsoftware_users3 where    email =  '" + The_Username + "' and  Password =  '" + The_Password + "' Limit 1;";
                    // string selectQueryString = "SELECT  email , password , password_temp , password_send  FROM   getsoftware_users3 where    email =  '" + The_Username + "'  Limit 1;";
                    string selectQueryString = "SELECT  email , password   FROM   getsoftware_users3 where (email =  '" + The_Username + "' and  password =  '" + The_Password + "')";

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

                              modifiedstring = "found it.";





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

        private string Read_Username_And_Password(MySql.Data.MySqlClient.MySqlConnection The_connection, string The_Username, string The_Password)
        {

            string modifiedstring = "";


            try
            {

                using (The_connection)
                {

                    //"create table getsoftware_users3( id INT NOT NULL AUTO_INCREMENT PRIMARY KEY , email VARCHAR(255) NOT NULL , password VARCHAR(255) NOT NULL , password_temp VARCHAR(255)  NULL , password_send INT  NULL , first_name VARCHAR(255) NOT NULL , middle_name VARCHAR(255) NOT NULL , last_name VARCHAR(255) NOT NULL , phone_number VARCHAR(255), Security_Question MEDIUMTEXT NOT NULL , Security_Answer MEDIUMTEXT NOT NULL , last_Login_date TIMESTAMP NOT NULL, the_date TIMESTAMP NOT NULL )"

                    //  string selectQueryString = "SELECT  email , password , password_temp , password_send  FROM   getsoftware_users3 where    email =  '" + The_Username + "' and  Password =  '" + The_Password + "' Limit 1;";
                    // string selectQueryString = "SELECT  email , password , password_temp , password_send  FROM   getsoftware_users3 where    email =  '" + The_Username + "'  Limit 1;";
                    string selectQueryString = "SELECT  email , first_name , middle_name , last_name , phone_number , Security_Question , Security_Answer   FROM   getsoftware_users3 where  (  (email =  '" + The_Username + "' and  password_send =  1) OR     (email =  '" + The_Username + "' and  Password =  '" + The_Password + "' ))";

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
                             
                            txt_reg_email.Text = reader.GetString(0);
                            txt_firstname.Text = reader.GetString(1);
                            txt_middlename.Text = reader.GetString(2);
                            txt_lastname.Text = reader.GetString(3);
                            txt_phone_number.Text = reader.GetString(4);
                            txt_Security_Question.Text = reader.GetString(5);
                            txt_Security_Answer.Text = reader.GetString(6);
                        
                          
 


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

        bool IsValidEmail(string email)
        {
            if (email.Trim().EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string userName1 = "";
            string userName = userName1;
            lbl_message.Visible = false;
            lbl_message.Text = "";
            string mdaaaaa = "";






            if (txt_reg_email.Text.Replace(" ", "") == "")
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter an email.";
                txt_reg_email.Focus();
                return;
            }

            bool aa = IsValidEmail(txt_reg_email.Text);
            if (aa != true)
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter a valid email .";
                txt_reg_email.Focus();
                return;
            }


            if (txt_reg_email.Text.Length < 5)
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please make sure your password is at least 5 characters .";
                txt_reg_email.Focus();
                return;
            }


            //if (txt_passwordmysql.Text.Replace(" ", "") == "")
            //{
            //    lbl_message.Visible = true;
            //    lbl_message.Text = "Please enter a password.";
            //    txt_reg_email.Focus();
            //    return;
            //}






            if (txt_firstname.Text.Replace(" ", "") == "")
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter a first name.";
                txt_firstname.Focus();
                return;
            }

            if (txt_firstname.Text.Length < 1)
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter a valid first name .";
                txt_firstname.Focus();
                return;
            }








            if (txt_middlename.Text.Replace(" ", "") == "")
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter a middle name.";
                txt_middlename.Focus();
                return;
            }

            if (txt_middlename.Text.Length < 0)
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter a valid middle name .";
                txt_middlename.Focus();
                return;
            }



            if (txt_lastname.Text.Replace(" ", "") == "")
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter a last name.";
                txt_lastname.Focus();
                return;
            }

            if (txt_lastname.Text.Length < 1)
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter a valid last name .";
                txt_lastname.Focus();
                return;
            }



            if (txt_lastname.Text.Replace(" ", "") == "")
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter a phone number.";
                txt_lastname.Focus();
                return;
            }

            bool isIntString1 = txt_phone_number.Text.All(char.IsDigit);
            if (isIntString1 == false)
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter only numbers in the phone number field .";
                txt_phone_number.Focus();
                return;
            }

            if (txt_phone_number.Text.Length != 10)
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter 10 digits for the phone number .";
                txt_phone_number.Focus();
                return;
            }


            if (txt_Security_Question.Text.Replace(" ", "") == "")
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter a security question.";
                txt_Security_Question.Focus();
                return;
            }

            if (txt_Security_Question.Text.Length < 3)
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter a valid security question.";
                txt_Security_Question.Focus();
                return;
            }

            if (txt_Security_Question.Text.Replace(" ", "") == "")
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter a security answer.";
                txt_Security_Question.Focus();
                return;
            }

            if (txt_Security_Question.Text.Length < 0)
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter a valid security answer.";
                txt_Security_Question.Focus();
                return;
            }


            string pwd_check = txt_passwordmysql.Text;
            Regex rgx = new Regex("[^A-Za-z0-9]");
            bool containsSpecialCharacter = rgx.IsMatch(pwd_check);



            if (containsSpecialCharacter != true)
            {

                lbl_message.Visible = true;
                lbl_message.Text = "Please include a special character in your password .";
                txt_passwordmysql.Focus();
                return;
            }

            bool containsInt = txt_passwordmysql.Text.Any(char.IsDigit);
            if (containsInt == false)
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please include a number in your password .";
                txt_passwordmysql.Focus();
                return;
            }



            if (txt_passwordmysql.Text.Length > 6)
            {

            }
            else
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter at least 7 characters for your password.";
                txt_passwordmysql.Focus();
                return;
            }


            if (txt_passwordmysql.Text != txt_confirm_Password.Text)
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Sorry ... your passwords do not match.";
                txt_passwordmysql.Focus();
                return;
            }


            //string mdsa = "";
            //try
            //{

            //    MySql.Data.MySqlClient.MySqlConnection connection6 = new MySql.Data.MySqlClient.MySqlConnection(cn.connection_to_use);

            //    mdsa = Does_email_exist(connection6, txt_reg_email.Text);



            //    if (mdsa == "1asdfartw56wesgbvasert4tqgw45tbasdfasrea")
            //    {

            //        lbl_message.Visible = true;
            //        lbl_message.Text = "That email already exists in our database. Please login.";
            //        txt_firstname.Focus();
            //        return;

            //    }

            //}
            //catch (Exception nerrordd)
            //{
            //    //////////////////no need to read error
            //    string noerror = nerrordd.ToString();

            //}


            try
            {
                string new_password = Guid.NewGuid().ToString();
                var connection = new Connection_Strings();
                MySql.Data.MySqlClient.MySqlConnection connection44s = new MySql.Data.MySqlClient.MySqlConnection(connection.prod_conn_string.ToString());

                try
                {

                    if ((Session["Logged_in"] == null) || (Session["Username_to_use"] == null) || (Session["Password_to_use"] == null))
                    {
                        Response.Redirect("/Account/App_Logout");

                    }
                    else
                    {

                    }



                }
                catch (Exception ex)
                {

                }


                string decrypted_usernameq = "";
                string decrypted_passwordq = "";

                decrypted_usernameq = Decrypt(Session["Username_to_use"].ToString());

                decrypted_passwordq = Decryptpassword(Session["Password_to_use"].ToString());


              //  md = Read_Username_And_Password(connection44s, decrypted_usernameq, decrypted_passwordq);

                mdaaaaa = Update_Registration(connection44s, decrypted_usernameq, decrypted_passwordq);

            }
            catch (Exception nerrordd)
            {
                //////////////////no need to read error
                string noerror = nerrordd.ToString();

            }








            try
            {



                //   "create table getsoftware_users1( id INT NOT NULL AUTO_INCREMENT PRIMARY KEY , email VARCHAR(255) NOT NULL , password VARCHAR(255) NOT NULL , first_name VARCHAR(255) NOT NULL , middle_name VARCHAR(255) NOT NULL , last_name VARCHAR(255) NOT NULL , phone_number INT NULL, last_Login_date TIMESTAMP NOT NULL, the_date TIMESTAMP NOT NULL )"

                if (mdaaaaa == "1asdfartw56wesgbasdfasfdasfdvasert4tqgw45tbaaaaateee")
                {

                    lbl_message.Visible = true;
                    lbl_message.Text = "Update was successful! ";
                    txt_firstname.Focus();
                   // Panel_registration.Visible = false;

                }

                else

                {

                    try
                    {

                        lbl_message.Visible = true;
                        lbl_message.Text = "Update was not successful!";
                        txt_firstname.Focus();

                    }
                    catch (Exception jerror1FF)
                    {
                        ///Do nothing
                        string jj = jerror1FF.ToString();


                    }

                }




            }
            catch (Exception jerror1FF)
            {
                ///Do nothing
                string jj = jerror1FF.ToString();

                return;
            }


        }
        public string Encrypt(string encryptString)
        {


            try
            {
                string EncryptionKey = "62e24b33099d46e88389d72ef814219a";

                byte[] clearBytes = Encoding.Unicode.GetBytes(encryptString);
                using (Aes encryptor = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(clearBytes, 0, clearBytes.Length);
                            cs.Close();
                        }
                        encryptString = Convert.ToBase64String(ms.ToArray());
                    }
                }
                return encryptString;


            }
            catch (Exception jerror1)
            {
                string jj = jerror1.ToString();



                string mymessage = jerror1.ToString();

                ///start
                string guid_script_coded_bbbb567913e4qwesawq1w2ew1 = Guid.NewGuid().ToString();
                StringBuilder jerscriptbbbb567913e4qwesawq1w2ew1 = new StringBuilder();

                jerscriptbbbb567913e4qwesawq1w2ew1.Append("$(document).ready(function(){");

                jerscriptbbbb567913e4qwesawq1w2ew1.Append("alert('Enable to Encrypt String!');");

                jerscriptbbbb567913e4qwesawq1w2ew1.Append("});");

                ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_bbbb567913e4qwesawq1w2ew1,

               jerscriptbbbb567913e4qwesawq1w2ew1.ToString(), true);
                return encryptString;

            }
        }
        public string Encrypt_password(string encryptString)
        {


            try
            {
                string EncryptionKey = "62e24b33099d46e88389d72ef814219a";

                byte[] clearBytes = Encoding.Unicode.GetBytes(encryptString);
                using (Aes encryptor = Aes.Create())
                {
                    Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76
        });
                    encryptor.Key = pdb.GetBytes(32);
                    encryptor.IV = pdb.GetBytes(16);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            cs.Write(clearBytes, 0, clearBytes.Length);
                            cs.Close();
                        }
                        encryptString = Convert.ToBase64String(ms.ToArray());
                    }
                }
                return encryptString;


            }
            catch (Exception jerror1)
            {
                string jj = jerror1.ToString();



                string mymessage = jerror1.ToString();

                ///start
                string guid_script_coded_bbbb567913e4qwesawq1w2ew1 = Guid.NewGuid().ToString();
                StringBuilder jerscriptbbbb567913e4qwesawq1w2ew1 = new StringBuilder();

                jerscriptbbbb567913e4qwesawq1w2ew1.Append("$(document).ready(function(){");

                jerscriptbbbb567913e4qwesawq1w2ew1.Append("alert('Enable to Encrypt String!');");

                jerscriptbbbb567913e4qwesawq1w2ew1.Append("});");

                ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_bbbb567913e4qwesawq1w2ew1,

               jerscriptbbbb567913e4qwesawq1w2ew1.ToString(), true);
                return encryptString;

            }
        }
        private string Update_Registration(MySql.Data.MySqlClient.MySqlConnection The_connection, string the_email, string old_Password)
        {

            string modifiedstring = "";


            try
            {

                using (The_connection)
                {
                    string StringommandText = "";

                    The_connection.Open();
                    MySqlCommand comm = The_connection.CreateCommand();

                    //  decimal phone_number = decimal.Parse(txt_phone_number.Text);

                    //   "create table getsoftware_users1( id INT NOT NULL AUTO_INCREMENT PRIMARY KEY , email VARCHAR(255) NOT NULL , password VARCHAR(255) NOT NULL , first_name VARCHAR(255) NOT NULL , middle_name VARCHAR(255) NOT NULL , last_name VARCHAR(255) NOT NULL , phone_number INT NULL, last_Login_date TIMESTAMP NOT NULL, the_date TIMESTAMP NOT NULL )"

                    //"create table getsoftware_users1( id INT NOT NULL AUTO_INCREMENT PRIMARY KEY , email VARCHAR(255) NOT NULL , password VARCHAR(255) NOT NULL , first_name VARCHAR(255) NOT NULL , middle_name VARCHAR(255) NOT NULL , last_name VARCHAR(255) NOT NULL , phone_number INT NULL, Security_Question MEDIUMTEXT NOT NULL , Security_Answer MEDIUMTEXT NOT NULL , last_Login_date TIMESTAMP NOT NULL, the_date TIMESTAMP NOT NULL )"
                    //  "create table getsoftware_users2( id INT NOT NULL AUTO_INCREMENT PRIMARY KEY , email VARCHAR(255) NOT NULL , password VARCHAR(255) NOT NULL , first_name VARCHAR(255) NOT NULL , middle_name VARCHAR(255) NOT NULL , last_name VARCHAR(255) NOT NULL , phone_number VARCHAR(255), Security_Question MEDIUMTEXT NOT NULL , Security_Answer MEDIUMTEXT NOT NULL , last_Login_date TIMESTAMP NOT NULL, the_date TIMESTAMP NOT NULL )"
                    //"create table getsoftware_users3( id INT NOT NULL AUTO_INCREMENT PRIMARY KEY , email VARCHAR(255) NOT NULL , password VARCHAR(255) NOT NULL , password_temp VARCHAR(255)  NULL , password_send INT  NULL , first_name VARCHAR(255) NOT NULL , middle_name VARCHAR(255) NOT NULL , last_name VARCHAR(255) NOT NULL , phone_number VARCHAR(255), Security_Question MEDIUMTEXT NOT NULL , Security_Answer MEDIUMTEXT NOT NULL , last_Login_date TIMESTAMP NOT NULL, the_date TIMESTAMP NOT NULL )"

                    //  StringommandText = "UPDATE  getsoftware_users2  SET  id =[value-1], email =[value-2], password =[value-3], first_name =[value-4], middle_name =[value-5], last_name =[value-6], phone_number =[value-7], Security_Question =[value-8], Security_Answer =[value-9], last_Login_date =[value-10], the_date =[value-11] WHERE 1"
                    DateTime theDate1 = DateTime.Now;
                    //  comm.Parameters.AddWithValue("@email", txt_reg_email.Text);
                    comm.Parameters.AddWithValue("@email", the_email);
                    comm.Parameters.AddWithValue("@password", txt_passwordmysql.Text);
                    comm.Parameters.AddWithValue("@first_name", txt_firstname.Text);
                    comm.Parameters.AddWithValue("@middle_name", txt_middlename.Text);
                    comm.Parameters.AddWithValue("@last_name", txt_lastname.Text);
                    comm.Parameters.AddWithValue("@phone_number", txt_phone_number.Text);
                    comm.Parameters.AddWithValue("@Security_Question", txt_Security_Question.Text);
                    comm.Parameters.AddWithValue("@Security_Answer", txt_Security_Answer.Text);
                    comm.Parameters.AddWithValue("@last_Login_date", theDate1);
                    comm.Parameters.AddWithValue("@the_date", theDate1);

                    StringommandText = "UPDATE  getsoftware_users3  SET  email = @email , password = @password , first_name= @first_name,  middle_name =@middle_name , last_name = @last_name , phone_number = @phone_number , Security_Question = @Security_Question , Security_Answer = @Security_Answer ,  last_Login_date = @last_Login_date ,     the_date = @the_date  WHERE   email =  '" + the_email + "'  and  password =  '" + old_Password + "'";


                    comm.CommandText = StringommandText;
                    comm.ExecuteNonQuery();
                    modifiedstring = "1asdfartw56wesgbasdfasfdasfdvasert4tqgw45tbaaaaateee";
                    comm.Parameters.Clear();
                    StringommandText = "";





                    string encrypt_username1 = Encrypt(the_email);


                   // Session["Username_to_use"] = encrypt_username1;
                   // Session["Username_to_use"] = encrypt_username1;


                    string encrypt_password2 = Encrypt_password(txt_passwordmysql.Text);


                  //  Session["Password_to_use"] = encrypt_password2;
                   // Session["Password_to_use"] = encrypt_password2;



                    try

                    {


                        comm.Dispose();

                    }
                    catch (Exception asfdasdf)
                    {
                        /// do nothing here
                        string la = asfdasdf.ToString();

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

        protected void Runapp4(object sender, EventArgs e)
        {
            try
            {


                Response.Redirect("/Edit_Profile_Picture");
            }
            catch (Exception ex)
            {

            }
        }
    }
}