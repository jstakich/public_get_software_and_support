using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using System.Diagnostics;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Web.Security;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Text;
using System.DirectoryServices;
using System.Data.SqlClient;
using System.Net.Mail;
using System.DirectoryServices.AccountManagement;
using System.Web.Services;

using System.Collections.Specialized;
using System.Web.Configuration;
using System.Security.Cryptography;
using System.IO;
using System.Drawing;
using System.Globalization;
using System.Security.Principal;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Net;

namespace GetSoftwareAndSupport.Account
{
    public partial class Login : System.Web.UI.Page
    {
        
        
     readonly HttpContext context11 = HttpContext.Current;
        protected void Page_Load(object sender, EventArgs e)
        {


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

            Page.Form.Attributes.Add("enctype", "multipart/form-data");
            #region Set Connection_Type_And_String 
            
            #endregion
            if (!IsPostBack)
            {
               // this.BindGrid();
            }





            if (!IsPostBack)
            {
                //   fillData();
            }




            #region Set Connection_Type_And_String 
            
            #endregion

            #region Login And_Security_Run_on_Every_Page 
            try
            {




                try
                {



                    try
                    {

                        //if (Session["View_Edit_Permissions"].ToString() == "cognitio_edit_ls")
                        //{
                        //    Image_Access.ImageUrl = "/icon/Edit_Access2.png";

                        //    is_User_in_a_group_for_this_page = true;
                        //}

                    }
                    catch (Exception err)
                    {
                        //try
                        //{
                        //    ///catch if null
                        //    string erre = err.ToString();

                        //    Response.Redirect("/Account/Cog_Login");
                        //}
                        //catch (Exception jerror1tt)
                        //{
                        //    string jj = jerror1tt.ToString();

                        //}

                    }






                    try
                    {

                        //if (Session["View_Edit_Permissions"].ToString() == "cognitio_admin_ls")
                        //{
                        //    Image_Access.ImageUrl = "/icon/Admin_Access2.png";
                        //    is_User_in_a_group_for_this_page = true;
                        //}
                    }
                    catch (Exception err)
                    {
                        //try
                        //{
                        //    ///catch if null
                        //    string erre = err.ToString();

                        //    Response.Redirect("/Account/Cog_Login");
                        //}
                        //catch (Exception jerror1tt)
                        //{
                        //    string jj = jerror1tt.ToString();

                        //}

                    }





                    //////////////////////redirect if user is not in a group needed




                }
                catch (Exception jerror1ff)
                {
                    ///// no redirect here because we are handling above and they bug out below
                    string je = jerror1ff.ToString();

                }





            }
            catch (Exception error2)
            {
                string dddr = error2.ToString();

            }



            ////////////////////////Run any other code after the fact
            #endregion


            #region Check For_App)ID 
            //// All of this code must run below the normal check for session vars and redirects

            #endregion
            #region First Page_Load 
            if (!Page.IsPostBack)
            {





                #region read page_session 


                ////////////////////////////////////////////////////////////////////////////////
                //try
                //{

                //    try
                //    {
                //        if (Session["Application_Name_App_Edit"] != null)
                //        {
                //            //lbl_app_to_add_edit_or_delete.Text = Session["Application_Name_App_Edit"].ToString();
                //        }

                //    }
                //    catch (Exception dddd)
                //    {
                //        ///////////// No need to catch this
                //        string the_e = dddd.Message.ToString();
                //    }
                //    //////////////////////////////////////



                //}
                //catch (Exception dddd)
                //{
                //    string the_e = dddd.Message.ToString();
                //    string guid_script_coded_a1 = Guid.NewGuid().ToString();
                //    StringBuilder jerscripta1 = new StringBuilder();
                //    jerscripta1.Append("$(document).ready(function(){");
                //    jerscripta1.Append("alert('" + the_e + "');");
                //    jerscripta1.Append("});");
                //    ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
                //    jerscripta1.ToString(), true);
                //    ///end
                //    return;

                //}
                ////////////////////////////////////////////////////////////////////////////////
                #endregion

                #region Database Read 
                try
                {










                    //MySql.Data.MySqlClient.MySqlConnection connection7 = new MySql.Data.MySqlClient.MySqlConnection(cs);
                    //Read_Data_Previously_Inserted_application_User_relation(connection7);
                    //  SqlConnection connection6 = new SqlConnection(con_string_new);
                    // Read_App_to_edit(connection6, Session["Application_Name_App"].ToString());



                }
                catch (Exception the_error1)
                {
                    string sadf = the_error1.Message.ToString();
                    string guid_script_coded_a1 = Guid.NewGuid().ToString();
                    StringBuilder jerscripta1 = new StringBuilder();
                    jerscripta1.Append("$(document).ready(function(){");
                    jerscripta1.Append("alert('" + sadf + "');");
                    jerscripta1.Append("});");
                    ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
                    jerscripta1.ToString(), true);
                    ///end


                }


                #endregion







            }
            #endregion
            else
            #region Every Page_Load 
            {





            }
            #endregion




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


                Error_Redirect("/Account/AccessDenied");

                return "";

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


        /// <summary>
        /// Abando Session
        /// </summary>







        /// <summary>
        /// Login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LogIn(object sender, EventArgs e)
        {
            Panel_Change_Password1.Visible = false;
          //  string encrypted_password1 = Encrypt(txt_password.Text);
          //   txt_password.Text = encrypted_password1;
          //0J264bTs4bwBJ/mj+APCPDWdhewBNb1OtpP/qhK41Ig=
          //0J264bTs4bwBJ/mj+APCPDWdhewBNb1OtpP/qhK41Ig=

            string userName1 = "";
            string userName = userName1;


            lbl_message.Visible = false;
            lbl_message.Text = "";
            string md = "";
            try
            {
                var connection = new Connection_Strings();
                MySql.Data.MySqlClient.MySqlConnection connection6 = new MySql.Data.MySqlClient.MySqlConnection(connection.prod_conn_string.ToString());
            
             md = Read_Username_And_Password(connection6, txt_username.Text, txt_password.Text);

            }
            catch (Exception nerrordd)
            {
                //////////////////no need to read error
                string noerror = nerrordd.ToString();

            }








            try
            {



                if ((txt_username.Text.Replace(" ", "") == ""))
                {
                    lbl_message.Visible = true;
                    lbl_message.Text = "Username is blank";
                    txt_username.Focus();
                    return;
                }

                if ((txt_password.Text.Replace(" ", "") == ""))
                {
                    lbl_message.Visible = true;
                    lbl_message.Text = "Password is blank";
                    txt_username.Focus();
                    return;
                }



                //   "create table getsoftware_users1( id INT NOT NULL AUTO_INCREMENT PRIMARY KEY , email VARCHAR(255) NOT NULL , password VARCHAR(255) NOT NULL , first_name VARCHAR(255) NOT NULL , middle_name VARCHAR(255) NOT NULL , last_name VARCHAR(255) NOT NULL , phone_number INT NULL, last_Login_date TIMESTAMP NOT NULL, the_date TIMESTAMP NOT NULL )"
                //"create table getsoftware_users3( id INT NOT NULL AUTO_INCREMENT PRIMARY KEY , email VARCHAR(255) NOT NULL , password VARCHAR(255) NOT NULL , password_temp VARCHAR(255)  NULL , password_send INT  NULL , first_name VARCHAR(255) NOT NULL , middle_name VARCHAR(255) NOT NULL , last_name VARCHAR(255) NOT NULL , phone_number VARCHAR(255), Security_Question MEDIUMTEXT NOT NULL , Security_Answer MEDIUMTEXT NOT NULL , last_Login_date TIMESTAMP NOT NULL, the_date TIMESTAMP NOT NULL )"

                if (md == "1asdfartw56wesgbvasert4tqgw45tb") 
                    {
                     
                        string encrypt_username1 = Encrypt(txt_username.Text);


                       
                        Session["Username_to_use"] = encrypt_username1;


                    string encrypt_password2 = Encrypt_password(txt_password.Text);


                  //  context.Session["Password_to_use"] = encrypt_password2;
                    Session["Password_to_use"] = encrypt_password2;



                  //  context.Session["Logged_in"] = "True";
                     //   context.Session["Login_Verified"] = "True";
                     //   context.Session["two_Step_Verified"] = "True";

                        Session["Logged_in"] = "True";
                        Session["Login_Verified"] = "True";
                        Session["two_Step_Verified"] = "True";


                        //////////////////////////////////////////////////   Set the views and permissions start.
                        ////////////////////////

                     //   context.Session["View_Edit_Permissions"] = "";
                        Session["View_Edit_Permissions"] = "";

                        ////////////////////////


                        Boolean is_this_user_in_any_Group_at_all = false;

                    ////////////////////////

                    string mdsasfafsasssss = "";
                    try
                    {
                        string new_password = Guid.NewGuid().ToString();
                        var connection = new Connection_Strings();
                        MySql.Data.MySqlClient.MySqlConnection connection44e = new MySql.Data.MySqlClient.MySqlConnection(connection.prod_conn_string.ToString());

                        mdsasfafsasssss = Update_Registration_Login_Time(connection44e, txt_username.Text);

                    }
                    catch (Exception nerrordd)
                    {
                        //////////////////no need to read error
                        string noerror = nerrordd.ToString();

                    }








                    try
                            {
                                Response.Redirect("/Default");

                            }
                            catch (Exception jerror1FF)
                            {
                                ///Do nothing
                                string jj = jerror1FF.ToString();


                            }

                     

            

                    }

                    else

                    {
                    if (md == "1")
                    {
                        lbl_message.Visible = true;
                        lbl_message.Text = "Please set a new password now.";
                        txt_passwordmysql.Focus();
                        return;
                    }

                    try
                        {

                            lbl_message.Visible = true;
                            lbl_message.Text = "That was an incorrect email or password or you have not registered yet.";
                            txt_username.Focus();
                          
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



        //private bool Is_This_User_In_An_AD_Group(string ingroup, string usernametoquery)
        //{
        //    bool isMember = false;
        //    try
        //    {
        //        string domain = cn.domain_to_use;
        //        PrincipalContext ADDomain = new PrincipalContext(ContextType.Domain, cn.domain_to_use, cn.username_read_AD_Groups_to_use, cn.password_read_AD_Groups_to_use);
        //        UserPrincipal user = UserPrincipal.FindByIdentity(ADDomain, usernametoquery);
        //        if (user.IsMemberOf(ADDomain, IdentityType.Name, ingroup.Trim()))
        //        {
        //            isMember = true;
        //        }
        //        return isMember;

        //    }
        //    catch (Exception ex)
        //    {
        //        /// no need to read error ...we know if the user is in or not.
        //        string the_error = ex.ToString();
        //        return isMember;
        //    }
        //}


        /// <summary>
        /// Check to see if Account is locked of Disabled
        /// </summary>
        /// <param name="the_user"></param>
        //private void Check_Security(string the_user)
        //{

        //    //////Security code start 

        //    /////Disabled Status Start
        //    try
        //    {



        //        string Is_this_App_user_Disabled = Get_Security_is_app_User_account_Disabled(cn.domain_to_use, the_user);

        //        if (Is_this_App_user_Disabled == "Disabled")
        //        {
        //            try
        //            {
        //                Response.Redirect("/Account/Account_Disabled");

        //            }
        //            catch (Exception jerror1tt)
        //            {
        //                string jj = jerror1tt.ToString();

        //            }
        //        }


        //    }
        //    catch (Exception jerror1FF)
        //    {
        //        ///Do nothing
        //        string jj = jerror1FF.ToString();

        //        return;
        //    }
        //    /////Disabled Status End


        //    /////Locked Status Start
        //    try
        //    {



        //        string Is_this_App_user_locked_out = Get_Security_is_app_User_account_Locked(cn.domain_to_use, the_user);

        //        if (Is_this_App_user_locked_out == "Locked")
        //        {
        //            try
        //            {
        //                Response.Redirect("/Account/Account_Locked");

        //            }
        //            catch (Exception jerror1tt)
        //            {
        //                string jj = jerror1tt.ToString();

        //            }
        //        }


        //    }
        //    catch (Exception jerror1FF)
        //    {
        //        ///Do nothing
        //        string jj = jerror1FF.ToString();

        //        return;
        //    }
        //    /////Locked Status End

        //    //////Security code end 


        //}



        /// <summary>
        /// See if account is locked out
        /// </summary>
        /// <param name="strDOMAIN"></param>
        /// <param name="strUSER"></param>
        /// <returns></returns>
        //private string Get_Security_is_app_User_account_Locked(string strDOMAIN, string strUSER)
        //{
        //    string strGUID = "";


        //    try
        //    {



        //        PrincipalContext ADDomain = new PrincipalContext(ContextType.Domain, cn.domain_to_use, cn.username_read_AD_Groups_to_use, cn.password_read_AD_Groups_to_use);

        //        UserPrincipal user = UserPrincipal.FindByIdentity(ADDomain, strUSER);
        //        if (user != null)
        //        {
        //            string displayName = user.DisplayName;

        //            if (user.IsAccountLockedOut())
        //            {
        //                strGUID = "Locked";
        //                return strGUID;

        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        string je = ex.ToString();
        //        strGUID = "Unable to read lockout status!";
        //        return strGUID;

        //    }
        //    return strGUID;

        //}



        /// <summary>
        /// See if account is disabled
        /// </summary>
        /// <param name="strDOMAIN"></param>
        /// <param name="strUSER"></param>
        /// <returns></returns>
        //private string Get_Security_is_app_User_account_Disabled(string strDOMAIN, string strUSER)
        //{
        //    string strGUID = "";




        //    try
        //    {




        //        DirectoryEntry de = new DirectoryEntry("LDAP://" + strDOMAIN, cn.username_read_AD_Groups_to_use, cn.password_read_AD_Groups_to_use);

        //        DirectorySearcher objADSearcher = new DirectorySearcher(de);
        //        objADSearcher.SearchRoot = de;
        //        objADSearcher.Filter = "(SAMAccountName=" + strUSER + ")";
        //        SearchResult results = objADSearcher.FindOne();
        //        strGUID = "Was Unable to read if it was locked.";

        //        strGUID = "Account is Enabled";
        //        int flags = Convert.ToInt32(results.Properties["userAccountControl"][0].ToString());




        //        strGUID = flags.ToString();



        //        if (flags == 514)
        //        {
        //            strGUID = "514 Disabled Account";
        //            strGUID = "Disabled";
        //            return strGUID;
        //        }

        //        if (flags == 2)
        //        {
        //            strGUID = "2 Account is Disabled";
        //            strGUID = "Disabled";
        //            return strGUID;
        //        }

        //        if (flags == 546)
        //        {
        //            strGUID = "546 Disabled, Password Not Required";
        //            strGUID = "Disabled";
        //            return strGUID;
        //        }

        //        if (flags == 66050)
        //        {
        //            strGUID = "66050 Disabled, Password Doesn't Expire";
        //            strGUID = "Disabled";
        //            return strGUID;
        //        }

        //        if (flags == 66082)
        //        {
        //            strGUID = "66082 Disabled, Password Doesn't Expire & Not Required";
        //            strGUID = "Disabled";
        //            return strGUID;
        //        }

        //        if (flags == 262658)
        //        {
        //            strGUID = "262658 Disabled, Smartcard Required";
        //            strGUID = "Disabled";
        //            return strGUID;
        //        }

        //        if (flags == 262690)
        //        {
        //            strGUID = "262690 Disabled, Smartcard Required, Password Not Required";
        //            strGUID = "Disabled";
        //            return strGUID;
        //        }

        //        if (flags == 328194)
        //        {
        //            strGUID = "Disabled, Smartcard Required, Password Doesn't Expire";
        //            strGUID = "Disabled";
        //            return strGUID;
        //        }

        //        if (flags == 328226)
        //        {
        //            strGUID = "Disabled, Smartcard Required, Password Doesn't Expire & Not Required";
        //            strGUID = "Disabled";
        //            return strGUID;
        //        }


        //        return strGUID;
        //        //  }
        //    }
        //    catch (Exception ex)
        //    {
        //        string je = ex.ToString();
        //        strGUID = "Unable to read Enabled/Lockout status!";

        //        return strGUID;

        //    }
        //}




        /// <summary>
        /// redirect on error
        /// </summary>
        /// <param name="Redirect_Location"></param>
        protected void Error_Redirect(string Redirect_Location)
        {
            try
            {


                try
                {

                    Response.Redirect(Redirect_Location);
                }
                catch (Exception jerror1FF)
                {

                    string eee = jerror1FF.ToString();

                }

            }
            catch (Exception jerror1)
            {
                string eee = jerror1.ToString();
                Error_Redirect("/Account/AccessDenied");
                return;
            }

        }



        /// <summary>
        /// Clearing login session variables
        /// </summary>
        protected void Set_Login_Session_Variables_to_Nothing()
        {




            try

            {
                lbl_message.Text = "";
                // Page_Username_to_use_this_page = "";
                // Page_password_to_use_this_page = "";

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
                    Session.Clear();
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

                #endregion

            }

            catch (Exception errt)

            {
                string sss = errt.ToString();

                Error_Redirect("/Account/AccessDenied");
                return;
            }

        }



        ////////////Impersonate code start

        public const int LOGON32_LOGON_INTERACTIVE = 2;
        public const int LOGON32_PROVIDER_DEFAULT = 0;

        WindowsImpersonationContext impersonationContext;

        [DllImport("advapi32.dll")]
        public static extern int LogonUserA(String lpszUserName,
        String lpszDomain,
        String lpszPassword,
        int dwLogonType,
        int dwLogonProvider,
        ref IntPtr phToken);
        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern int DuplicateToken(IntPtr hToken,
        int impersonationLevel,
        ref IntPtr hNewToken);

        [DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool RevertToSelf();

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public static extern bool CloseHandle(IntPtr handle);

        //public void Page_Load(Object s, EventArgs e)
        //{
        //    if (impersonateValidUser("username", "domain", "password"))
        //    {
        //        //Insert your code that runs under the security context of a specific user here.
        //        undoImpersonation();
        //    }
        //    else
        //    {
        //        //Your impersonation failed. Therefore, include a fail-safe mechanism here.
        //    }
        //}

        private bool impersonateValidUser(String userName, String domain, String password)
        {
            WindowsIdentity tempWindowsIdentity;
            IntPtr token = IntPtr.Zero;
            IntPtr tokenDuplicate = IntPtr.Zero;

            if (RevertToSelf())
            {
                if (LogonUserA(userName, domain, password, LOGON32_LOGON_INTERACTIVE,
                LOGON32_PROVIDER_DEFAULT, ref token) != 0)
                {
                    if (DuplicateToken(token, 2, ref tokenDuplicate) != 0)
                    {
                        tempWindowsIdentity = new WindowsIdentity(tokenDuplicate);
                        impersonationContext = tempWindowsIdentity.Impersonate();
                        if (impersonationContext != null)
                        {
                            CloseHandle(token);
                            CloseHandle(tokenDuplicate);
                            return true;
                        }
                    }
                }
            }
            if (token != IntPtr.Zero)
                CloseHandle(token);
            if (tokenDuplicate != IntPtr.Zero)
                CloseHandle(tokenDuplicate);
            return false;
        }

        private void undoImpersonation()
        {
            impersonationContext.Undo();
        }

        ////////////Impersonate code start



        protected void log_in_user(object sender, EventArgs e)
        {
            object Sender_Object_A = null;
            EventArgs EventArgs_B = null;

            try
            {
                LogIn(Sender_Object_A, EventArgs_B);
            }
            catch (Exception jerror1FF)
            {

                string eee = jerror1FF.ToString();

            }
        }


        protected void test1(object sender, EventArgs e)
        {
            string test = "it worked";
        }



        private string Update_Registration_Login_Time(MySql.Data.MySqlClient.MySqlConnection The_connection, string the_email)
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
                  //  comm.Parameters.AddWithValue("@password", new_Password);
                   // comm.Parameters.AddWithValue("@password_temp", "1234asldfkjadsfjuauuaeb");
                   // comm.Parameters.AddWithValue("@password_send", 0);
                    //comm.Parameters.AddWithValue("@first_name", txt_firstname.Text);
                    //comm.Parameters.AddWithValue("@middle_name", txt_middlename.Text);
                    //comm.Parameters.AddWithValue("@last_name", txt_lastname.Text);
                    //comm.Parameters.AddWithValue("@phone_number", txt_phone_number.Text);
                    //comm.Parameters.AddWithValue("@Security_Question", txt_Security_Question.Text);
                    //comm.Parameters.AddWithValue("@Security_Answer", txt_Security_Answer.Text);
                    //  comm.Parameters.AddWithValue("@last_Login_date", theDate1);
                    comm.Parameters.AddWithValue("@last_Login_date", theDate1);

                    StringommandText = "UPDATE  getsoftware_users3  SET  last_Login_date = @last_Login_date WHERE   email =  '" + the_email + "'";


                    comm.CommandText = StringommandText;
                    comm.ExecuteNonQuery();
                    modifiedstring = "1asdfartw56wesgbasdfasfdasfdvasert4tqgw45tbaaggg11";
                    comm.Parameters.Clear();
                    StringommandText = "";









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

        private string Update_Registration_Password(MySql.Data.MySqlClient.MySqlConnection The_connection, string the_email, string new_Password)
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
                    int aa = 0;
                    //  comm.Parameters.AddWithValue("@email", txt_reg_email.Text);
                    comm.Parameters.AddWithValue("@password", new_Password);
                    comm.Parameters.AddWithValue("@password_temp", "1234asldfkjadsfjuauuaeb");
                    comm.Parameters.AddWithValue("@password_send", aa);
                    //comm.Parameters.AddWithValue("@first_name", txt_firstname.Text);
                    //comm.Parameters.AddWithValue("@middle_name", txt_middlename.Text);
                    //comm.Parameters.AddWithValue("@last_name", txt_lastname.Text);
                    //comm.Parameters.AddWithValue("@phone_number", txt_phone_number.Text);
                    //comm.Parameters.AddWithValue("@Security_Question", txt_Security_Question.Text);
                    //comm.Parameters.AddWithValue("@Security_Answer", txt_Security_Answer.Text);
                    //  comm.Parameters.AddWithValue("@last_Login_date", theDate1);
                    comm.Parameters.AddWithValue("@the_date", theDate1);

                    StringommandText = "UPDATE  getsoftware_users3  SET  password = @password, password_temp = @password_temp,  password_send =@password_send , the_date = @the_date WHERE   email =  '" + the_email + "'";


                    comm.CommandText = StringommandText;
                    comm.ExecuteNonQuery();
                    modifiedstring = "1asdfartw56wesgbasdfasfdasfdvasert4tqgw45tbaaggg2222";
                    comm.Parameters.Clear();
                    StringommandText = "";









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
        private string Update_Registration(MySql.Data.MySqlClient.MySqlConnection The_connection , string the_email , string new_Password)
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
                    comm.Parameters.AddWithValue("@password_temp", new_Password);
                    comm.Parameters.AddWithValue("@password_send", 1);
                    //comm.Parameters.AddWithValue("@first_name", txt_firstname.Text);
                    //comm.Parameters.AddWithValue("@middle_name", txt_middlename.Text);
                    //comm.Parameters.AddWithValue("@last_name", txt_lastname.Text);
                    //comm.Parameters.AddWithValue("@phone_number", txt_phone_number.Text);
                    //comm.Parameters.AddWithValue("@Security_Question", txt_Security_Question.Text);
                    //comm.Parameters.AddWithValue("@Security_Answer", txt_Security_Answer.Text);
                    //  comm.Parameters.AddWithValue("@last_Login_date", theDate1);
                     comm.Parameters.AddWithValue("@the_date", theDate1);

                    StringommandText = "UPDATE  getsoftware_users3  SET  password_temp = @password_temp,  password_send =@password_send , the_date = @the_date WHERE   email =  '" + the_email + "'";


                    comm.CommandText = StringommandText;
                    comm.ExecuteNonQuery();
                    modifiedstring = "1asdfartw56wesgbasdfasfdasfdvasert4tqgw45tbaa";
                    comm.Parameters.Clear();
                    StringommandText = "";









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
        private  string Write_Registration(MySql.Data.MySqlClient.MySqlConnection The_connection ,string new_password)
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
                    

                    DateTime theDate1 = DateTime.Now;
                    comm.Parameters.AddWithValue("@email", txt_reg_email.Text);
                    comm.Parameters.AddWithValue("@password", new_password);
                    comm.Parameters.AddWithValue("@password_temp", new_password);
                    comm.Parameters.AddWithValue("@password_send", 1);
                    comm.Parameters.AddWithValue("@first_name", txt_firstname.Text);
                    comm.Parameters.AddWithValue("@middle_name", txt_middlename.Text);
                    comm.Parameters.AddWithValue("@last_name", txt_lastname.Text);
                    comm.Parameters.AddWithValue("@phone_number", txt_phone_number.Text);
                    comm.Parameters.AddWithValue("@Security_Question", txt_Security_Question1.Text);
                    comm.Parameters.AddWithValue("@Security_Answer", txt_Security_Answer.Text);
                    comm.Parameters.AddWithValue("@last_Login_date", theDate1);
                    comm.Parameters.AddWithValue("@the_Date", theDate1);
                    StringommandText = "INSERT INTO getsoftware_users3(email , password, password_temp , password_send , first_name, middle_name, last_name, phone_number, Security_Question , Security_Answer ,  last_Login_date, the_date ) VALUES ( @email , @password, @password_temp , @password_send , @first_name, @middle_name, @last_name, @phone_number, @Security_Question , @Security_Answer , @last_Login_date, @the_date)";

                    comm.CommandText = StringommandText;
                    comm.ExecuteNonQuery();
                    modifiedstring = "1asdfartw56wesgbasdfasfdasfdvasert4tqgw45tb";
                    comm.Parameters.Clear();
                    StringommandText = "";

                    
                    



                   


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
        private  string Read_Username_And_Password(MySql.Data.MySqlClient.MySqlConnection The_connection, string The_Username , string The_Password)
        {

            string modifiedstring = "";


            try
            {

                using (The_connection)
                {

                    //"create table getsoftware_users3( id INT NOT NULL AUTO_INCREMENT PRIMARY KEY , email VARCHAR(255) NOT NULL , password VARCHAR(255) NOT NULL , password_temp VARCHAR(255)  NULL , password_send INT  NULL , first_name VARCHAR(255) NOT NULL , middle_name VARCHAR(255) NOT NULL , last_name VARCHAR(255) NOT NULL , phone_number VARCHAR(255), Security_Question MEDIUMTEXT NOT NULL , Security_Answer MEDIUMTEXT NOT NULL , last_Login_date TIMESTAMP NOT NULL, the_date TIMESTAMP NOT NULL )"

                    //  string selectQueryString = "SELECT  email , password , password_temp , password_send  FROM   getsoftware_users3 where    email =  '" + The_Username + "' and  Password =  '" + The_Password + "' Limit 1;";
                    // string selectQueryString = "SELECT  email , password , password_temp , password_send  FROM   getsoftware_users3 where    email =  '" + The_Username + "'  Limit 1;";
                   string selectQueryString = "SELECT  email , password , password_temp , password_send  FROM   getsoftware_users3 where  (  (email =  '" + The_Username + "' and  password_send =  1) OR     (email =  '" + The_Username + "' and  Password =  '" + The_Password + "' ))";

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
                            string email1 = reader.GetString(0);
                            string password1 = reader.GetString(1);
                            string password_temp = reader.GetString(2);
                            int password_send = reader.GetInt32(3);

                            if (password_send == 1)
                            {
                                if (password_temp == The_Password)
                                {
                                    modifiedstring = "1";
                                    Panel_Change_Password1.Visible = true;
                                }
                            }
                            else
                            {
                                if (password1 == The_Password)
                                {
                                    modifiedstring = "1asdfartw56wesgbvasert4tqgw45tb";
                                }
                            }


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

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

            if  (CheckBox1.Checked == true) 
            {
                cboxforgotpassword.Checked = false;
            }

            Fix_Checkboxes();



        }

        
        
        //protected void FileUpLoad1_DataBinding(object sender, EventArgs e)
        //{
           
        //}

        //protected void UploadBtn_Click(object sender, EventArgs e)
        //{
        //    if (FileUpLoad1.HasFile)
        //    {

        //        FileUpLoad1.SaveAs(@"C:\temp\" + FileUpLoad1.FileName);
        //        Label1.Text = "File Uploaded: " + FileUpLoad1.FileName;
        //    }
        //    else
        //    {
        //        Label1.Text = "No File Uploaded.";
        //    }
        //}

        protected void Registernow(object sender, EventArgs e)
        {
            //MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection(cn.connection_to_use);
            //MySql.Data.MySqlClient.MySqlCommand cmd;
            //FileStream fs;
            //BinaryReader br;
            //try
            //{
            //    if (txt_first_name.Text != ""  )
            //    {
            //        string FileName = FileUpLoad1;
            //        byte[] ImageData;
            //        fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            //        br = new BinaryReader(fs);
            //        ImageData = br.ReadBytes((int)fs.Length);
            //        br.Close();
            //        fs.Close();
            //        string CmdString = "INSERT INTO Students(FirstName, LastName, Image, Address) VALUES(@FirstName, @LastName, @Image, @Address)";
            //        cmd = new MySqlCommand(CmdString, con);
            //        cmd.Parameters.Add("@FirstName", MySqlDbType.VarChar, 45);
            //        cmd.Parameters.Add("@LastName", MySqlDbType.VarChar, 45);
            //        cmd.Parameters.Add("@Image", MySqlDbType.Blob);
            //        cmd.Parameters.Add("@Address", MySqlDbType.VarChar, 100);
            //        cmd.Parameters["@FirstName"].Value = txtFirstName.Text;
            //        cmd.Parameters["@LastName"].Value = txtLastName.Text;
            //        cmd.Parameters["@Image"].Value = ImageData;
            //        cmd.Parameters["@Address"].Value = txtAddress.Text;
            //        con.Open();
            //        int RowsAffected = cmd.ExecuteNonQuery();
            //        if (RowsAffected > 0)
            //        {
            //            MessageBox.Show("Image saved sucessfully!");
            //        }
            //        con.Close();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Incomplete data!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    if (con.State == ConnectionState.Open)
            //    {
            //        con.Close();
            //    }
            //}
        }
        
        protected void showbrowsedia(object sender, EventArgs e)
        {
            string jj = "";
        }

        protected void UploadButton_Click(object sender, EventArgs e)
        {
            //string jj = "";

            //if (FileUpload1.HasFile)
            //{
            //    string sss = "stop";

            //    try
            //    {
            //        string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
            //        string contentType = FileUpload1.PostedFile.ContentType;
            //        using (Stream fs = FileUpload1.PostedFile.InputStream)
            //        {

            //            //Id ,  First_Name , Middle_Name , Last_Name , Username , Password , Email , Phone , Approved , The_Image , tsv , dt , FROM , tbl_user2 , 
            //            using (BinaryReader br = new BinaryReader(fs))
            //            {
            //                byte[] bytes = br.ReadBytes((Int32)fs.Length);
            //                string constr = cn.connection_to_use;
            //                using (MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection(constr))
            //                {
            //                    string query = "INSERT INTO tbl_user2(" +
            //                            "Id, " +
            //                            "First_Name, " +
            //                               "Middle_Name, " +
            //                                    "Last_Name, " +
            //                                        "Username, " +
            //                                           "Password, " +
            //                                              "Email, " +
            //                                                 "Phone, " +
            //                                                    "Approved, " +
            //                                                    "The_Image" +
            //                            ") VALUES (" +
            //                           "@Id" +
            //                            ", " +
            //                            "@First_Name" +
            //                            ", " +
            //                               "@Middle_Name" +
            //                            ", " +
            //                               "@Last_Name" +
            //                            ", " +
            //                               "@Username" +
            //                            ", " +
            //                               "@Password" +
            //                            ", " +
            //                               "@Email" +
            //                            ", " +
            //                               "@Phone" +
            //                            ", " +
            //                                "@Approved" +
            //                            ", " +
            //                            "@The_Image" +
            //                            ")";
            //                    using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query))
            //                    {
            //                        cmd.Connection = con; 
            //                        cmd.Parameters.AddWithValue("@Id", Guid.NewGuid().ToString());
            //                        cmd.Parameters.AddWithValue("@First_Name", txt_first_name.Text);
            //                        cmd.Parameters.AddWithValue("@Middle_Name", txt_first_name.Text);
            //                        cmd.Parameters.AddWithValue("@Last_Name", txt_first_name.Text);
            //                        cmd.Parameters.AddWithValue("@Username", Guid.NewGuid().ToString());
            //                        cmd.Parameters.AddWithValue("@Password", txt_first_name.Text);
            //                        cmd.Parameters.AddWithValue("@Email", txt_first_name.Text);
            //                        cmd.Parameters.AddWithValue("@Phone", txt_first_name.Text);
            //                        cmd.Parameters.AddWithValue("@Approved", 0);
            //                        cmd.Parameters.AddWithValue("@The_Image", bytes);
            //                        con.Open();
            //                        cmd.ExecuteNonQuery();
            //                        con.Close();
            //                    }
            //                }
            //            }
            //        }
            //        Response.Redirect(Request.Url.AbsoluteUri);

            //    }
            //    catch (Exception eee)
            //    {
            //        string jjdd = eee.ToString();

            //    }
            //}
            //else
            //{
            //    return;
            //}

        }

        protected void registernowwww(object sender, EventArgs e)
        {


            //string folderPath = Server.MapPath("~/Files/");

            ////Check whether Directory (Folder) exists.
            //if (!Directory.Exists(folderPath))
            //{
            //    //If Directory (Folder) does not exists Create it.
            //    Directory.CreateDirectory(folderPath);
            //}

            ////Save the File to the Directory (Folder).
            //FileUpload1.SaveAs(folderPath + Path.GetFileName(FileUpload1.FileName));

            ////Display the Picture in Image control.
            //Image1.ImageUrl = "~/Files/" + Path.GetFileName(FileUpload1.FileName);


            //if (myFile.PostedFile != null)
            //{
            //    // File was sent
            //    var postedFile = myFile.PostedFile;
            //    int dataLength = postedFile.ContentLength;
            //    byte[] myData = new byte[dataLength];
            //    postedFile.InputStream.Read(myData, 0, dataLength);
            //}
            //else
            //{
            //    // No file was sent

            //}
        }



        private void BindGrid()
        {
            gvImages.DataSource = null;
            gvImages.DataBind();

            var connection = new Connection_Strings();
            using (MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection(connection.prod_conn_string.ToString()))
            {
                using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand())
                {
                    cmd.CommandText = "SELECT Id , First_Name , Middle_Name , Last_Name , Username , Password , Email , Phone , Approved , The_Image , ts , dt   FROM tbl_user2  ";
                    cmd.Connection = con;
                    using (MySql.Data.MySqlClient.MySqlDataAdapter sda = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        gvImages.DataSource = dt;
                        gvImages.DataBind();
                    }
                }
            }
        }

        protected void Async_Upload_File(object sender, EventArgs e)
        {

        //    if (FileUpload1.HasFile)
        //    {
        //        string sss = "stop";
        //    }
        //    else
        //    {
        //        return;
        //    }

        //    try
        //    {
              


        //        string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
        //    string contentType = FileUpload1.PostedFile.ContentType;
        //    using (Stream fs = FileUpload1.PostedFile.InputStream)
        //    {
        //        using (BinaryReader br = new BinaryReader(fs))
        //        {
        //            byte[] bytes = br.ReadBytes((Int32)fs.Length);
        //            string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        //            using (MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection(constr))
        //            {
        //                string query = "INSERT INTO Files(FileName, ContentType, Content) VALUES (@FileName, @ContentType, @Content)";
        //                using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query))
        //                {
        //                    cmd.Connection = con;
        //                    cmd.Parameters.AddWithValue("@FileName", filename);
        //                    cmd.Parameters.AddWithValue("@ContentType", contentType);
        //                    cmd.Parameters.AddWithValue("@Content", bytes);
        //                    con.Open();
        //                    cmd.ExecuteNonQuery();
        //                    con.Close();
        //                }
        //            }
        //        }
        //    }
        //    Response.Redirect(Request.Url.AbsoluteUri);
        //}
        //      catch (Exception eee)
        //    {
        //        string jj = eee.ToString();
            
        //    }
        }
        protected void UploadFile(object sender, EventArgs e)
        {
          
            //string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
            //string contentType = FileUpload1.PostedFile.ContentType;
            //using (Stream fs = FileUpload1.PostedFile.InputStream)
            //{
            //    using (BinaryReader br = new BinaryReader(fs))
            //    {
            //        byte[] bytes = br.ReadBytes((Int32)fs.Length);
            //        string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
            //        using (MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection(constr))
            //        {
            //            string query = "INSERT INTO Files(FileName, ContentType, Content) VALUES (@FileName, @ContentType, @Content)";
            //            using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query))
            //            {
            //                cmd.Connection = con;
            //                cmd.Parameters.AddWithValue("@FileName", filename);
            //                cmd.Parameters.AddWithValue("@ContentType", contentType);
            //                cmd.Parameters.AddWithValue("@Content", bytes);
            //                con.Open();
            //                cmd.ExecuteNonQuery();
            //                con.Close();
            //            }
            //        }
            //    }
            //}
            //Response.Redirect(Request.Url.AbsoluteUri);
        }

        private void upload_Insert_file()
        {
            lbl_upload_Status.Text = "";
            string does_that_email_exist = "";
            try
            {
                var connection = new Connection_Strings();
                MySql.Data.MySqlClient.MySqlConnection connection6 = new MySql.Data.MySqlClient.MySqlConnection(connection.prod_conn_string.ToString());

                does_that_email_exist = Does_email_exist(connection6, txt_reg_email.Text);



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

            }

            lbl_message.Visible = false;
            lbl_message.Text = "";


            if (txt_reg_email.Text.Replace(" ", "") == "")
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter an email.";
                lbl_upload_Status.Text = "Please enter a valid email .";
                txt_reg_email.Focus();
                return;
            }

            bool aa = IsValidEmail(txt_reg_email.Text);
            if (aa != true)
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter a valid email .";
                lbl_upload_Status.Text = "Please enter a valid email .";
                txt_reg_email.Focus();
                return;
            }


            if (txt_reg_email.Text.Length < 5)
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please make sure your password is at least 5 characters .";
                lbl_upload_Status.Text = "Please make sure your password is at least 5 characters .";
                txt_reg_email.Focus();
                return;
            }
            if (customFile.Value != "")
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
                                        query = "UPDATE  profile_images  SET  The_Image = @The_Image WHERE   email =  '" + txt_reg_email.Text + "'";

                                        using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query))
                                        {
                                            cmd.Connection = con;

                                            cmd.Parameters.AddWithValue("@The_Image", bytes);
                                            string imageUrl = "data:image/jpg;base64," + Convert.ToBase64String(bytes);
                                            Image5.ImageUrl = imageUrl;
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
                                            cmd.Parameters.AddWithValue("@email", txt_reg_email.Text);
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
                    lbl_message.Visible = true;
                    lbl_message.Text = eee.Message.ToString();
                }
            }
            else
            {
                lbl_upload_Status.Text = "Please upload a profile picture.";
                return;
            }

        }
        protected void Upload_File(object sender, EventArgs e)
        {
            lbl_upload_Status.Text = "";
          string does_that_email_exist = "";
            try
            {
                var connection = new Connection_Strings();
                MySql.Data.MySqlClient.MySqlConnection connection6 = new MySql.Data.MySqlClient.MySqlConnection(connection.prod_conn_string.ToString());

                does_that_email_exist = Does_email_exist(connection6, txt_reg_email.Text);



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

            }

            lbl_message.Visible = false;
            lbl_message.Text = "";


            if (txt_reg_email.Text.Replace(" ", "") == "")
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter an email.";
                lbl_upload_Status.Text = "Please enter a valid email .";
                txt_reg_email.Focus();
                return;
            }

            bool aa = IsValidEmail(txt_reg_email.Text);
            if (aa != true)
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter a valid email .";
                lbl_upload_Status.Text = "Please enter a valid email .";
                txt_reg_email.Focus();
                return;
            }


            if (txt_reg_email.Text.Length < 5)
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please make sure your password is at least 5 characters .";
                lbl_upload_Status.Text = "Please make sure your password is at least 5 characters .";
                txt_reg_email.Focus();
                return;
            }
            if (customFile.Value != null)
                //if (FileUpload1.HasFile)
            {
                string sss = "stop";
                try
                {
                    string filename = Path.GetFileName(customFile.PostedFile.FileName);
                    string contentTypeuploaded = customFile.PostedFile.ContentType;

                    if (contentTypeuploaded.ToLower().StartsWith("image") ==true)
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
                                        query = "UPDATE  profile_images  SET  The_Image = @The_Image WHERE   email =  '" + txt_reg_email.Text + "'";

                                        using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(query))
                                        {
                                            cmd.Connection = con;
                                            
                                            cmd.Parameters.AddWithValue("@The_Image", bytes); 
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
                                            cmd.Parameters.AddWithValue("@email", txt_reg_email.Text);
                                            cmd.Parameters.AddWithValue("@The_Image", bytes);
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
                    lbl_message.Visible = true;
                    lbl_message.Text = eee.Message.ToString() ;
                }
            }
            else
            {
                lbl_upload_Status.Text = "Please upload a profile picture.";
                return;
            }
       
    }

        protected void gvImagesOnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            //if ((e.Row.FindControl("The_Image") as System.Web.UI.WebControls.Image).ImageUrl != null)
            //{
            //    string itnotnull = "aaa";
            //}
            //else
            //{
            //    string itisnull = "aaa";
            //}

            //if (!String.IsNullOrEmpty((e.Row.FindControl("Image1") as System.Web.UI.WebControls.Image).ImageUrl))
            //{
            //    string itnotnull = "aaa";
            //}
            //else
            //{
            //    string itisnull = "aaa";
            //}
            //try
            //{
            //    if (e.Row.RowType == DataControlRowType.DataRow)
            //    {
            //        byte[] bytes = (byte[])(e.Row.DataItem as DataRowView)["The_Image"];
            //        string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
            //        try
            //        {
            //            (e.Row.FindControl("Image2s") as System.Web.UI.WebControls.Image).ImageUrl = "data:image/png;base64," + base64String;
            //        }
            //        catch (Exception dddd)
            //        {
            //            string the_e = dddd.Message.ToString();

            //        }

            //    }

            //}
            //catch (Exception dddd)
            //{
            //    string the_e = dddd.Message.ToString();

            //}
        }










        private void Load_view()
        {
            try
            {
                // label_info1.Text = "";
                string selectQueryString = "Select  Id , First_Name , Middle_Name , Last_Name , Username , Password , Email , Phone , Approved , The_Image , ts , dt    from tbl_user2 Order by ts desc limit 1000";
                //  string selectQueryString = "SELECT  Id   , Name   , Email  , Comment  , ts FROM tbl_Comments4    WHERE        ( Id = '" + Session["Edit_App_ID"].ToString() + "' )";

                //   string selectQueryString = "SELECT  Id   , Name   , Email  , Comment  , ts FROM tbl_Comments4    WHERE        ( Id = '" + Session["Edit_App_ID"].ToString() + "' )";

                var connection = new Connection_Strings(); 
                MySql.Data.MySqlClient.MySqlConnection connection2 = new MySql.Data.MySqlClient.MySqlConnection(connection.prod_conn_string.ToString());

                MySql.Data.MySqlClient.MySqlDataAdapter sqlDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(selectQueryString, connection2);
                MySql.Data.MySqlClient.MySqlCommandBuilder sqlCommandBuilder = new MySql.Data.MySqlClient.MySqlCommandBuilder(sqlDataAdapter);
                sqlDataAdapter.SelectCommand.CommandTimeout = 0;
                System.Data.DataTable dataTable = new System.Data.DataTable();
                sqlDataAdapter.Fill(dataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;
                gvImages.DataSourceID = null;

                gvImages.DataSource = bindingSource;
                gvImages.DataBind();

                int c = 0;

                try
                {

                    c = dataTable.Rows.Count;
                    if (c == 0)
                    {

                    }
                    else
                    {

                    }

                }
                catch (Exception dddd)
                {
                    string the_e = dddd.Message.ToString();

                }


                try
                {
                    connection2.Close();
                }
                catch (Exception dddd)
                {
                    string sadf = dddd.ToString();
                }

                try
                {
                    sqlDataAdapter.Dispose();
                }
                catch (Exception dddd)
                {
                    string sadf = dddd.ToString();
                }

                try
                {
                    dataTable.Dispose();
                }
                catch (Exception dddd)
                {
                    string sadf = dddd.ToString();
                }

                try
                {
                    connection2.Dispose();
                }
                catch (Exception dddd)
                {
                    string sadf = dddd.ToString();
                }
                //  linkcancelfocus.Focus();


            }
            catch (Exception dddd)
            {
                string sadf = dddd.ToString(); ;
                string guid_script_coded_a1 = Guid.NewGuid().ToString();
                StringBuilder jerscripta1 = new StringBuilder();
                jerscripta1.Append("$(document).ready(function(){");
                jerscripta1.Append("alert('" + sadf + "');");
                jerscripta1.Append("});");
                ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
                jerscripta1.ToString(), true);
                ///end
                return;

            }

        }
        protected void PageIndexChanging(object sender, GridViewPageEventArgs e)

        {

            gvImages.PageIndex = e.NewPageIndex;

            Load_view();

        }


        protected void gvImages_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {


            #region Check_Update Permissions 
            try
            {

                //  label_info1.Text = "You do not have permissions to delete.";
                if (Session["View_Edit_Permissions"].ToString() == "cognitio_view_ls")
                {
                    //  label_info1.Text = "You do not have permissions to delete.";
                    string sadf = "You do not have permissions to delete.";
                    string guid_script_coded_a1 = Guid.NewGuid().ToString();
                    StringBuilder jerscripta1 = new StringBuilder();
                    jerscripta1.Append("$(document).ready(function(){");
                    jerscripta1.Append("alert('" + sadf + "');");
                    jerscripta1.Append("});");
                    ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
                    jerscripta1.ToString(), true);
                    ///end

                    return;
                }
                else
                {


                }
            }
            catch (Exception err)
            {
                ///catch if null
                string erre = err.ToString();
                //  label_info1.Text = "You do not have permissions to delete.";

                string sadf = "You do not have permissions to delete.";
                string guid_script_coded_a1 = Guid.NewGuid().ToString();
                StringBuilder jerscripta1 = new StringBuilder();
                jerscripta1.Append("$(document).ready(function(){");
                jerscripta1.Append("alert('" + sadf + "');");
                jerscripta1.Append("});");
                ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
                jerscripta1.ToString(), true);
                return;
            }



            #endregion



            Boolean Has_user_selected_Something = false;
            try
            {
                Comment New_Comment = new Comment();

                #region Get_ID From_Grid_View 

                System.Web.UI.WebControls.Label id = gvImages.Rows[e.RowIndex].FindControl("lbl_Name") as System.Web.UI.WebControls.Label;
                System.Web.UI.WebControls.TextBox name = gvImages.Rows[e.RowIndex].FindControl("txt_Name") as System.Web.UI.WebControls.TextBox;




                System.Web.UI.WebControls.TextBox var_txt_Email = gvImages.Rows[e.RowIndex].FindControl("txt_Email") as System.Web.UI.WebControls.TextBox;
                System.Web.UI.WebControls.TextBox var_txt_Comment = gvImages.Rows[e.RowIndex].FindControl("txt_Comment") as System.Web.UI.WebControls.TextBox;
                System.Web.UI.WebControls.TextBox var_txt_ts = gvImages.Rows[e.RowIndex].FindControl("txt_ts") as System.Web.UI.WebControls.TextBox;





                Boolean It_exits = false;
                Boolean Validated = false;
                Boolean Data_Was_Updated = false;
                // label_info1.Text = "";
                //  label_info_Edit.Text = "";

                int id_of_app = -99;
                Boolean Do_update_Instead = false;


                string string_namme = name.Text;
                int id_to_delete_by = -99;

                id_to_delete_by = Convert.ToInt32(string_namme);
                New_Comment.app_user_relation = id_to_delete_by;
                #endregion


                //   label_info1.Text = "";

                //Anything in here will run as user






                try
                {


                    if (var_txt_ts.Text.Replace(" ", "") == "")
                    {


                    }
                    else
                    {
                        Has_user_selected_Something = true;
                    }
                }
                catch (Exception the_error1)
                {
                    string sadf = the_error1.Message.ToString();
                    string guid_script_coded_a1 = Guid.NewGuid().ToString();
                    StringBuilder jerscripta1 = new StringBuilder();
                    jerscripta1.Append("$(document).ready(function(){");
                    jerscripta1.Append("alert('" + the_error1 + "');");
                    jerscripta1.Append("});");
                    ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
                    jerscripta1.ToString(), true);
                    ///end
                    return;

                }




                try
                {
                    Boolean true_or_false = var_txt_Email.Text.Contains(" ");
                    if (true_or_false == true)
                    {

                        string sadf = "Please remove the space in SID.";
                        string guid_script_coded_a1 = Guid.NewGuid().ToString();
                        StringBuilder jerscripta1 = new StringBuilder();
                        jerscripta1.Append("$(document).ready(function(){");
                        jerscripta1.Append("alert('" + sadf + "');");
                        jerscripta1.Append("});");
                        ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
                        jerscripta1.ToString(), true);

                        return;
                    }
                }
                catch (Exception dddd)
                {
                    string sadf = dddd.ToString();
                }





                try
                {
                    Boolean true_or_false = var_txt_Comment.Text.Contains(" ");
                    if (true_or_false == true)
                    {

                        string sadf = "Please remove the space in AD Group.";
                        string guid_script_coded_a1 = Guid.NewGuid().ToString();
                        StringBuilder jerscripta1 = new StringBuilder();
                        jerscripta1.Append("$(document).ready(function(){");
                        jerscripta1.Append("alert('" + sadf + "');");
                        jerscripta1.Append("});");
                        ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
                        jerscripta1.ToString(), true);

                        return;
                    }
                }
                catch (Exception dddd)
                {
                    string sadf = dddd.ToString();
                }






                try
                {


                    if ((var_txt_Email.Text.Replace(" ", "") != "") || (var_txt_Comment.Text.Replace(" ", "") != ""))
                    {


                    }
                    else

                    {
                        string sadf = "Please enter a Sid or an AD Group Name.";
                        string guid_script_coded_a1 = Guid.NewGuid().ToString();
                        StringBuilder jerscripta1 = new StringBuilder();
                        jerscripta1.Append("$(document).ready(function(){");
                        jerscripta1.Append("alert('" + sadf + "');");
                        jerscripta1.Append("});");
                        ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
                        jerscripta1.ToString(), true);
                        ///end
                        return;
                    }
                }
                catch (Exception the_error1)
                {
                    string sadf = the_error1.Message.ToString();
                    string guid_script_coded_a1 = Guid.NewGuid().ToString();
                    StringBuilder jerscripta1 = new StringBuilder();
                    jerscripta1.Append("$(document).ready(function(){");
                    jerscripta1.Append("alert('" + the_error1 + "');");
                    jerscripta1.Append("});");
                    ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
                    jerscripta1.ToString(), true);
                    ///end
                    return;

                }


                try
                {


                    if ((var_txt_ts.Text.Replace(" ", "") != ""))
                    {


                    }
                    else

                    {
                        string sadf = "Please enter Permissions.";
                        string guid_script_coded_a1 = Guid.NewGuid().ToString();
                        StringBuilder jerscripta1 = new StringBuilder();
                        jerscripta1.Append("$(document).ready(function(){");
                        jerscripta1.Append("alert('" + sadf + "');");
                        jerscripta1.Append("});");
                        ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
                        jerscripta1.ToString(), true);
                        ///end
                        return;
                    }
                }
                catch (Exception the_error1)
                {
                    string sadf = the_error1.Message.ToString();
                    string guid_script_coded_a1 = Guid.NewGuid().ToString();
                    StringBuilder jerscripta1 = new StringBuilder();
                    jerscripta1.Append("$(document).ready(function(){");
                    jerscripta1.Append("alert('" + the_error1 + "');");
                    jerscripta1.Append("});");
                    ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
                    jerscripta1.ToString(), true);
                    ///end
                    return;

                }





                try
                {


                    if (Has_user_selected_Something == false)
                    {

                        string sadf = "Please enter the group info to add.";
                        string guid_script_coded_a1 = Guid.NewGuid().ToString();
                        StringBuilder jerscripta1 = new StringBuilder();
                        jerscripta1.Append("$(document).ready(function(){");
                        jerscripta1.Append("alert('" + sadf + "');");
                        jerscripta1.Append("});");
                        ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
                        jerscripta1.ToString(), true);
                        ///end
                        return;

                    }
                    else
                    {

                    }
                }
                catch (Exception the_error1)
                {
                    string sadf = the_error1.Message.ToString();
                    string guid_script_coded_a1 = Guid.NewGuid().ToString();
                    StringBuilder jerscripta1 = new StringBuilder();
                    jerscripta1.Append("$(document).ready(function(){");
                    jerscripta1.Append("alert('" + the_error1 + "');");
                    jerscripta1.Append("});");
                    ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
                    jerscripta1.ToString(), true);
                    ///end
                    return;

                }







                #region Set Structure 

                try
                {








                    try
                    {
                        New_Comment.c_txt_Comment = var_txt_Comment.Text;
                    }
                    catch (Exception the_error1)
                    {
                        string sadf = the_error1.Message.ToString();
                        New_Comment.c_txt_Comment = "";
                    }

                    try
                    {
                        New_Comment.c_txt_Email = var_txt_Email.Text;
                    }
                    catch (Exception the_error1)
                    {
                        string sadf = the_error1.Message.ToString();
                        New_Comment.c_txt_Email = "";
                    }


                    try
                    {
                        New_Comment.c_txt_ts = var_txt_ts.Text;
                    }
                    catch (Exception the_error1)
                    {
                        string sadf = the_error1.Message.ToString();
                        New_Comment.c_txt_ts = "";
                    }









                }
                catch (Exception the_error1)
                {
                    string sadf = the_error1.Message.ToString();
                    string guid_script_coded_a1 = Guid.NewGuid().ToString();
                    StringBuilder jerscripta1 = new StringBuilder();
                    jerscripta1.Append("$(document).ready(function(){");
                    jerscripta1.Append("alert('" + the_error1 + "');");
                    jerscripta1.Append("});");
                    ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
                    jerscripta1.ToString(), true);
                    ///end
                    return;

                }

                #endregion




                try
                {
                    if (name.Text.ToString().Replace(" ", "") == "")
                    {
                        //  label_info1.Text = "Please enter a value.";
                        string sadf = "Please enter a value.";
                        string guid_script_coded_a1 = Guid.NewGuid().ToString();
                        StringBuilder jerscripta1 = new StringBuilder();
                        jerscripta1.Append("$(document).ready(function(){");
                        jerscripta1.Append("alert('" + sadf + "');");
                        jerscripta1.Append("});");
                        ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
                        jerscripta1.ToString(), true);
                        return;
                    }
                }
                catch (Exception dddd)
                {
                    string sadf = dddd.ToString();
                }

                #region Do Update_Instead 
                try
                {
                    //  label_info_Edit.Text = "";



                    string run_update = "";

                    var connection = new Connection_Strings();
                    run_update = Update_User_Information(connection.prod_conn_string.ToString(), New_Comment.app_user_relation, New_Comment.c_lbl_Name, New_Comment.c_txt_Name, New_Comment.c_txt_Comment);





                    if (run_update != "")
                    {
                        Data_Was_Updated = true;
                    }

                    if (Data_Was_Updated == true)
                    {
                        //   label_info_Edit.Text = "Item was updated in the database.";
                        //string sadf = "Item was updated in the database.";
                        //string guid_script_coded_a1 = Guid.NewGuid().ToString();
                        //StringBuilder jerscripta1 = new StringBuilder();
                        //jerscripta1.Append("$(document).ready(function(){");
                        //jerscripta1.Append("alert('" + sadf + "');");
                        //jerscripta1.Append("});");
                        //ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
                        //jerscripta1.ToString(), true);
                    }
                    else
                    {
                        //   label_info_Edit.Text = "Item was Not updated in the database!";
                        //string sadf = "Item was Not updated in the database!";
                        //string guid_script_coded_a1 = Guid.NewGuid().ToString();
                        //StringBuilder jerscripta1 = new StringBuilder();
                        //jerscripta1.Append("$(document).ready(function(){");
                        //jerscripta1.Append("alert('" + sadf + "');");
                        //jerscripta1.Append("});");
                        //ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
                        //jerscripta1.ToString(), true);
                    }



                    //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
                    gvImages.EditIndex = -1;


                    update_listboxes();

                    /// Searching data again to clear form
                    Search_Data_2();

                    /// Set focus on bottom so we can see
                    //   linkcancelfocus.Focus();


                }
                catch (Exception the_error1)
                {
                    //  label_info_Edit.Text = "An error occurred.";
                    string sadf = the_error1.ToString(); ;
                    //string guid_script_coded_a1 = Guid.NewGuid().ToString();
                    //StringBuilder jerscripta1 = new StringBuilder();
                    //jerscripta1.Append("$(document).ready(function(){");
                    //jerscripta1.Append("alert('" + sadf + "');");
                    //jerscripta1.Append("});");
                    //ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
                    //jerscripta1.ToString(), true);
                    /////end
                    //return;


                }

                #endregion




            }
            catch (Exception dddd)
            {
                // label_info1.Text = "Error while updating.";
                string sadf = dddd.ToString();
                //string guid_script_coded_a1 = Guid.NewGuid().ToString();
                //StringBuilder jerscripta1 = new StringBuilder();
                //jerscripta1.Append("$(document).ready(function(){");
                //jerscripta1.Append("alert('" + sadf + "');");
                //jerscripta1.Append("});");
                //ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
                //jerscripta1.ToString(), true);
                ///end
                return;

            }

        }



        private void update_listboxes()
        {
            try
            {






                var connection = new Connection_Strings();
                MySql.Data.MySqlClient.MySqlConnection connection7 = new MySql.Data.MySqlClient.MySqlConnection(connection.prod_conn_string.ToString());
                Read_Data_Previously_Inserted_application_User_relation(connection7);


            }
            catch (Exception the_error1)
            {
                string sadf = the_error1.Message.ToString();
                string guid_script_coded_a1 = Guid.NewGuid().ToString();
                StringBuilder jerscripta1 = new StringBuilder();
                jerscripta1.Append("$(document).ready(function(){");
                jerscripta1.Append("alert('" + sadf + "');");
                jerscripta1.Append("});");
                ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
                jerscripta1.ToString(), true);
                ///end


            }
        }


        protected void gvImages_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {



            //  label_info1.Text = "";
            // label_info_Edit.Text = "";

            #region Check_Delete Permissions 
            try
            {

                //  label_info1.Text = "You do not have permissions to delete.";
                if (Session["View_Edit_Permissions"].ToString() == "cognitio_view_ls")
                {
                    //  label_info1.Text = "You do not have permissions to delete.";
                    string sadf = "You do not have permissions to delete.";
                    string guid_script_coded_a1 = Guid.NewGuid().ToString();
                    StringBuilder jerscripta1 = new StringBuilder();
                    jerscripta1.Append("$(document).ready(function(){");
                    jerscripta1.Append("alert('" + sadf + "');");
                    jerscripta1.Append("});");
                    ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
                    jerscripta1.ToString(), true);
                    ///end

                    return;
                }
                else
                {


                }
            }
            catch (Exception err)
            {
                ///catch if null
                string erre = err.ToString();
                //  label_info1.Text = "You do not have permissions to delete.";

                string sadf = "You do not have permissions to delete.";
                string guid_script_coded_a1 = Guid.NewGuid().ToString();
                StringBuilder jerscripta1 = new StringBuilder();
                jerscripta1.Append("$(document).ready(function(){");
                jerscripta1.Append("alert('" + sadf + "');");
                jerscripta1.Append("});");
                ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
                jerscripta1.ToString(), true);
                return;
            }



            #endregion

            try
            {





                #region Get_ID From_Grid_View 

                System.Web.UI.WebControls.Label id = gvImages.Rows[e.RowIndex].FindControl("lbl_app_group_relation_id") as System.Web.UI.WebControls.Label;
                System.Web.UI.WebControls.TextBox name = gvImages.Rows[e.RowIndex].FindControl("txt_app_group_relation_id") as System.Web.UI.WebControls.TextBox;

                string string_namme = name.Text;
                int id_to_delete_by = -99;

                id_to_delete_by = Convert.ToInt32(string_namme);

                #endregion


                #region Delete Item_From_Database 

                if (id_to_delete_by != 99)
                {
                    var connection = new Connection_Strings();
                    MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection(connection.prod_conn_string.ToString());
                    con.Open();
                    //updating the record  
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("DELETE FROM [dbo].[ad_groups_relation]  WHERE   [dbo].[ad_groups_relation].[ad_group_relation_id] =" + id_to_delete_by, con);
                    cmd.ExecuteNonQuery();
                    // label_info1.Text = "Item deleted.";
                    string sadf333 = "Item deleted.";
                    string guid_script_coded_a1 = Guid.NewGuid().ToString();
                    StringBuilder jerscripta1 = new StringBuilder();
                    jerscripta1.Append("$(document).ready(function(){");
                    jerscripta1.Append("alert('" + sadf333 + "');");
                    jerscripta1.Append("});");
                    ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
                    jerscripta1.ToString(), true);

                    try
                    {
                        con.Close();
                    }
                    catch (Exception dddd)
                    {
                        string sadf = dddd.ToString();
                    }

                    try
                    {
                        cmd.Dispose();
                    }
                    catch (Exception dddd)
                    {
                        string sadf = dddd.ToString();
                    }

                    try
                    {
                        con.Dispose();
                    }
                    catch (Exception dddd)
                    {
                        string sadf = dddd.ToString();
                    }

                }
                else
                {

                    string sadf = "Unable to read ID.";
                    //  label_info1.Text = "Unable to read ID.";
                    string guid_script_coded_a1 = Guid.NewGuid().ToString();
                    StringBuilder jerscripta1 = new StringBuilder();
                    jerscripta1.Append("$(document).ready(function(){");
                    jerscripta1.Append("alert('" + sadf + "');");
                    jerscripta1.Append("});");
                    ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
                    jerscripta1.ToString(), true);
                    ///end
                    return;
                }
                #endregion





                //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
                gvImages.EditIndex = -2;


                update_listboxes();

                /// Searching data again to clear form
                Search_Data_2();

                /// Set focus on bottom so we can see
                // linkcancelfocus.Focus();



            }
            catch (Exception dddd)
            {
                // label_info1.Text = "An error occurred.";
                string sadf = dddd.ToString();
                string guid_script_coded_a1 = Guid.NewGuid().ToString();
                StringBuilder jerscripta1 = new StringBuilder();
                jerscripta1.Append("$(document).ready(function(){");
                jerscripta1.Append("alert('" + sadf + "');");
                jerscripta1.Append("});");
                ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
                jerscripta1.ToString(), true);
                ///end
                return;

            }

        }



        private void Read_Data_Previously_Inserted_application_User_relation(MySql.Data.MySqlClient.MySqlConnection connection)
        {
            Load_view();




        }

        private string Update_User_Information(string conn_string, Nullable<int> app_u_ral, string ad_group_sid, string ad_group_name, string permissions)
        {



            string modifiedstring = "";

            try

            {



                var connection = new Connection_Strings();
                MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connection.prod_conn_string.ToString());



                int asdf = 1;

                using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("Update tbl_Comments4  SET  [ad_group_sid] = @field_two    , [ad_group_name] = @field_three    , [permissions] = @field_four      Where  [ad_group_relation_id] = @the_ID", conn))
                {




                    try
                    {

                        cmd.Parameters.AddWithValue("@the_ID", app_u_ral);
                    }
                    catch (Exception dddd)
                    {
                        string the_e = dddd.Message.ToString();
                        //////// return on this because it can never be null
                        return modifiedstring;
                    }



                    try
                    {
                        if (ad_group_sid.Replace(" ", "") == "")
                            //// it will never make it here.
                            cmd.Parameters.AddWithValue("@field_two", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@field_two", ad_group_sid);
                    }
                    catch (Exception dddd)
                    {
                        string the_e = dddd.Message.ToString();
                    }



                    try
                    {
                        if (ad_group_name.Replace(" ", "") == "")
                            //// it will never make it here.
                            cmd.Parameters.AddWithValue("@field_three", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@field_three", ad_group_name);
                    }
                    catch (Exception dddd)
                    {
                        string the_e = dddd.Message.ToString();
                    }



                    try
                    {
                        if (permissions.Replace(" ", "") == "")
                            //// it will never make it here.
                            cmd.Parameters.AddWithValue("@field_four", DBNull.Value);
                        else
                            cmd.Parameters.AddWithValue("@field_four", permissions);
                    }
                    catch (Exception dddd)
                    {
                        string the_e = dddd.Message.ToString();
                    }





                    cmd.Connection.Open();


                    int ID_TO_Return = Convert.ToInt32(cmd.ExecuteScalar());
                    //This is the only place we set this value to other than nothing in this sub   We are just going to tell the user if it updated or not.
                    modifiedstring = ID_TO_Return.ToString();


                    try
                    {
                        cmd.Dispose();
                    }
                    catch (Exception the_error)
                    {
                        string the_errorstere = the_error.ToString();
                        ///don't return 
                    }



                    try
                    {
                        conn.Close();
                    }
                    catch (Exception the_error)
                    {
                        string the_errorstere = the_error.ToString();
                        ///don't return 
                    }

                    try
                    {
                        conn.Dispose();
                    }
                    catch (Exception the_error)
                    {
                        string the_errorstere = the_error.ToString();
                        ///don't return 
                    }




                    return modifiedstring;
                }

            }
            catch (Exception the_error)
            {
                string the_errorstere = the_error.ToString();
                ////keep this to nothing unless we get a value. We are just going to tell the user if it updated or not.
                modifiedstring = "";
                return modifiedstring;

            }

        }


        private void Search_Data_2()
        {
            try
            {


                //Anything in here will run as user

                //   string selectQueryString = "SELECT  [dbo].[ad_groups_relation].[ad_group_relation_id]  ,[dbo].[ad_groups_relation].[application_id]  ,[dbo].[ad_groups_relation].[ad_group_sid]  ,[dbo].[ad_groups_relation].[ad_group_name]  ,[dbo].[ad_groups_relation].[permissions] FROM [dbo].[ad_groups_relation]    WHERE (       (       ([dbo].[ad_groups_relation].[ad_group_sid]  like '%" + Txtsearch.Text + "%') or ([dbo].[ad_groups_relation].[ad_group_name]  like '%" + Txtsearch.Text + "%')    )            and ([dbo].[ad_groups_relation].[application_id] = '" + Session["Edit_App_ID"].ToString() + "') )";
                string selectQueryString = "Select * from tbl_user2 Order by ts desc limit 1000";
                var connection = new Connection_Strings();
                MySql.Data.MySqlClient.MySqlConnection connection2 = new MySql.Data.MySqlClient.MySqlConnection(connection.prod_conn_string.ToString());

                MySql.Data.MySqlClient.MySqlDataAdapter sqlDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(selectQueryString, connection2);
                MySql.Data.MySqlClient.MySqlCommandBuilder sqlCommandBuilder = new MySql.Data.MySqlClient.MySqlCommandBuilder(sqlDataAdapter);
                sqlDataAdapter.SelectCommand.CommandTimeout = 0;
                System.Data.DataTable dataTable = new System.Data.DataTable();
                sqlDataAdapter.Fill(dataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;
                gvImages.DataSourceID = null;

                gvImages.DataSource = bindingSource;
                gvImages.DataBind();

                try
                {
                    connection2.Close();
                }
                catch (Exception dddd)
                {
                    string sadf = dddd.ToString();
                }

                try
                {
                    sqlDataAdapter.Dispose();
                }
                catch (Exception dddd)
                {
                    string sadf = dddd.ToString();
                }

                try
                {
                    dataTable.Dispose();
                }
                catch (Exception dddd)
                {
                    string sadf = dddd.ToString();
                }

                try
                {
                    connection2.Dispose();
                }
                catch (Exception dddd)
                {
                    string sadf = dddd.ToString();
                }
                //  linkcancelfocus.Focus();



            }
            catch (Exception dddd)
            {
                string sadf = dddd.ToString(); ;
                string guid_script_coded_a1 = Guid.NewGuid().ToString();
                StringBuilder jerscripta1 = new StringBuilder();
                jerscripta1.Append("$(document).ready(function(){");
                jerscripta1.Append("alert('" + sadf + "');");
                jerscripta1.Append("});");
                ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
                jerscripta1.ToString(), true);
                ///end
                return;

            }

        }


        protected void gvImages_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            //NewEditIndex property used to determine the index of the row being edited.  
            gvImages.EditIndex = e.NewEditIndex;
            ShowData();
        }
        private void ShowData()
        {
            try
            {
                //  label_info1.Text = "";

                string selectQueryString = "Select * from tbl_user2 Order by ts desc limit 1000";
                //  string selectQueryString = "SELECT  [dbo].[ad_groups_relation].[ad_group_relation_id]  ,[dbo].[ad_groups_relation].[application_id]  ,[dbo].[ad_groups_relation].[ad_group_sid]  ,[dbo].[ad_groups_relation].[ad_group_name]  ,[dbo].[ad_groups_relation].[permissions] FROM [dbo].[ad_groups_relation]    WHERE (       (       ([dbo].[ad_groups_relation].[ad_group_sid]  like '%" + Txtsearch.Text + "%') or ([dbo].[ad_groups_relation].[ad_group_name]  like '%" + Txtsearch.Text + "%')    )            and ([dbo].[ad_groups_relation].[application_id] = '" + Session["Edit_App_ID"].ToString() + "') )";
                var connection = new Connection_Strings();
                MySql.Data.MySqlClient.MySqlConnection connection2 = new MySql.Data.MySqlClient.MySqlConnection(connection.prod_conn_string.ToString());

                MySql.Data.MySqlClient.MySqlDataAdapter sqlDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(selectQueryString, connection2);
                MySql.Data.MySqlClient.MySqlCommandBuilder sqlCommandBuilder = new MySql.Data.MySqlClient.MySqlCommandBuilder(sqlDataAdapter);
                sqlDataAdapter.SelectCommand.CommandTimeout = 0;
                System.Data.DataTable dataTable = new System.Data.DataTable();
                sqlDataAdapter.Fill(dataTable);
                BindingSource bindingSource = new BindingSource();
                bindingSource.DataSource = dataTable;
                gvImages.DataSourceID = null;

                gvImages.DataSource = bindingSource;
                gvImages.DataBind();

                int c = 0;

                try
                {

                    c = dataTable.Rows.Count;
                    if (c == 0)
                    {
                        //  label_info1.Text = "No data located.";
                    }
                    else
                    {
                        //  label_info1.Text = "Located data.";
                    }

                }
                catch (Exception dddd)
                {
                    string the_e = dddd.Message.ToString();

                }


                try
                {
                    connection2.Close();
                }
                catch (Exception dddd)
                {
                    string sadf = dddd.ToString();
                }

                try
                {
                    sqlDataAdapter.Dispose();
                }
                catch (Exception dddd)
                {
                    string sadf = dddd.ToString();
                }

                try
                {
                    dataTable.Dispose();
                }
                catch (Exception dddd)
                {
                    string sadf = dddd.ToString();
                }

                try
                {
                    connection2.Dispose();
                }
                catch (Exception dddd)
                {
                    string sadf = dddd.ToString();
                }



            }
            catch (Exception dddd)
            {
                string sadf = dddd.ToString(); ;
                //string guid_script_coded_a1 = Guid.NewGuid().ToString();
                //StringBuilder jerscripta1 = new StringBuilder();
                //jerscripta1.Append("$(document).ready(function(){");
                //jerscripta1.Append("alert('" + sadf + "');");
                //jerscripta1.Append("});");
                //ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
                //jerscripta1.ToString(), true);
                /////end
                return;

            }

        }
        protected void gvImages_RowCancelingEdit(object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
            //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
            gvImages.EditIndex = -1;
            ShowData();
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
            string md = "";

            

           
            
            
            if (  txt_reg_email.Text.Replace(" ","") == "" )
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter an email.";
                txt_reg_email.Focus();
                return;
            } 

          bool aa  = IsValidEmail(txt_reg_email.Text);
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

            if (txt_firstname.Text.Length < 1  )
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
            if (isIntString1 == false )
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


            if (txt_Security_Question1.Text.Replace(" ", "") == "")
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter a security question.";
                txt_Security_Question1.Focus();
                return;
            }

            if (txt_Security_Question1.Text.Length < 3)
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter a valid security question.";
                txt_Security_Question1.Focus();
                return;
            }

            if (txt_Security_Question1.Text.Replace(" ", "") == "")
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter a security answer.";
                txt_Security_Question1.Focus();
                return;
            }

            if (txt_Security_Question1.Text.Length < 0)
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter a valid security answer.";
                txt_Security_Question1.Focus();
                return;
            }


            //string pwd_check = txt_passwordmysql.Text;
            //Regex rgx = new Regex("[^A-Za-z0-9]");
            //bool containsSpecialCharacter = rgx.IsMatch(pwd_check);



            //if (containsSpecialCharacter != true)
            //{

            //    lbl_message.Visible = true;
            //    lbl_message.Text = "Please include a special character in your password .";
            //    txt_passwordmysql.Focus();
            //    return;
            //}

            //bool containsInt = txt_passwordmysql.Text.Any(char.IsDigit);
            //if (containsInt == false)
            //{
            //    lbl_message.Visible = true;
            //    lbl_message.Text = "Please include a number in your password .";
            //    txt_passwordmysql.Focus();
            //    return;
            //}



            //if (txt_passwordmysql.Text.Length > 6)
            //{

            //}
            //else
            //{
            //    lbl_message.Visible = true;
            //    lbl_message.Text = "Please enter at least 7 characters for your password.";
            //    txt_passwordmysql.Focus();
            //    return;
            //}


            //if (txt_passwordmysql.Text != txt_confirm_Password.Text)
            //{
            //    lbl_message.Visible = true;
            //    lbl_message.Text = "Sorry ... your passwords do not match.";
            //    txt_passwordmysql.Focus();
            //    return;
            //}


            string mdsa = "";
            try
            {
                var connection = new Connection_Strings();
                MySql.Data.MySqlClient.MySqlConnection connection6 = new MySql.Data.MySqlClient.MySqlConnection(connection.prod_conn_string.ToString());

                mdsa = Does_email_exist(connection6, txt_reg_email.Text );



                if (mdsa == "1asdfartw56wesgbvasert4tqgw45tbasdfasrea")
                {

                    lbl_message.Visible = true;
                    lbl_message.Text = "That email already exists in our database. Please login.";
                    txt_username.Focus();
                    return;

                }

            }
            catch (Exception nerrordd)
            {
                //////////////////no need to read error
                string noerror = nerrordd.ToString();

            }


            try
            {
                string new_password = Guid.NewGuid().ToString();
                var connection = new Connection_Strings();
                MySql.Data.MySqlClient.MySqlConnection connection44 = new MySql.Data.MySqlClient.MySqlConnection(connection.prod_conn_string.ToString());

                md = Write_Registration(connection44 ,  new_password);

            }
            catch (Exception nerrordd)
            {
                //////////////////no need to read error
                string noerror = nerrordd.ToString();

            }








            try
            {
                 


                //   "create table getsoftware_users1( id INT NOT NULL AUTO_INCREMENT PRIMARY KEY , email VARCHAR(255) NOT NULL , password VARCHAR(255) NOT NULL , first_name VARCHAR(255) NOT NULL , middle_name VARCHAR(255) NOT NULL , last_name VARCHAR(255) NOT NULL , phone_number INT NULL, last_Login_date TIMESTAMP NOT NULL, the_date TIMESTAMP NOT NULL )"

                if (md == "1asdfartw56wesgbasdfasfdasfdvasert4tqgw45tb")
                {

                    lbl_message.Visible = true;
                    lbl_message.Text = "Registration was successful! A temporary password was sent to your email. *** Please allow up to 10 minutes for the email to arrive . - GetSoftwareSupport.com ***";
                    txt_username.Focus();
                    Panel_registration.Visible = false;

                }

                else

                {

                    try
                    {

                        lbl_message.Visible = true;
                        lbl_message.Text = "Registration was not successful!";
                        txt_username.Focus();

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




        static string smtpAddress = "smtp.gmail.com";
        static int portNumber = 587;
        static bool enableSSL = true;
        static string emailFromAddress = "jeremystakich@getsoftwareandsupport.com"; //Sender Email Address  
        static string password = "Testing*99"; //Sender Password  
                                               //static string emailToAddress = "receiver@gmail.com"; //Receiver Email Address  



        public void SendEmail_Registration(string emailToAddress, string the_password)
        {
            lbl_message.Visible = false;
            lbl_message.Text = "";
            try
            {


                using (MailMessage mail = new MailMessage())
                {

                    mail.From = new MailAddress(emailFromAddress);

                    mail.To.Add(new MailAddress(emailToAddress));

                    mail.Subject = "Welcome to GetSoftwareAndSupport.com - Temporary Password from GetSoftwarAndSupport.com";
                    mail.Body = "Welcome to GetSoftwareAndSupport.com . Here is your temporary password from GetSoftwarAndSupport.com" + " " + Environment.NewLine + the_password; ;

                    SmtpClient client = new SmtpClient();
                    //client.Credentials = new NetworkCredential(emailFromAddress, password);
                    // client.EnableSsl = enableSSL;
                    client.Send(mail);
                    Panel4_forgotpassword.Visible = false;
                }

                //    mail.From = new MailAddress(emailFromAddress);
                //mail.To.Add(emailToAddress);
                //mail.Subject = subject;
                //mail.Body = body + "  " + Environment.NewLine + the_password;
                //mail.IsBodyHtml = true;
                //mail.Attachments.Add(new Attachment("D:\\TestFile.txt"));//--Uncomment this to send any attachment  
                //    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                //    {
                //        smtp.Credentials = new NetworkCredential(emailFromAddress, password);
                //        smtp.EnableSsl = enableSSL;
                //        smtp.Send(mail);
                //            lbl_message.Visible = true;
                //            lbl_message.Text = "A temporary password has been sent to your email.";
                //            Panel4_forgotpassword.Visible = false;
                //        }
                //}

            }
            catch (Exception jerror1FF)
            {
                ///Do nothing
                string jj = jerror1FF.ToString();
                lbl_message.Visible = true;
                lbl_message.Text = jerror1FF.Message.ToString();
                return;
            }

        }
        public   void SendEmail(string emailToAddress , string the_password)
        {
            lbl_message.Visible = false;
            lbl_message.Text = "";
            try
            { 


            using (MailMessage mail = new MailMessage())
            {

                    mail.From = new MailAddress(emailFromAddress);

                    mail.To.Add(new MailAddress(emailToAddress));

                    mail.Subject = "Temporary Password from GetSoftwarAndSupport.com";
                    mail.Body = "Here is your temporary password from GetSoftwarAndSupport.com" + " " + Environment.NewLine + the_password; ;
                    
                    SmtpClient client = new SmtpClient();
                    //client.Credentials = new NetworkCredential(emailFromAddress, password);
                   // client.EnableSsl = enableSSL;
                    client.Send(mail);
                    Panel4_forgotpassword.Visible = false;
                }

                //    mail.From = new MailAddress(emailFromAddress);
                //mail.To.Add(emailToAddress);
                //mail.Subject = subject;
                //mail.Body = body + "  " + Environment.NewLine + the_password;
                //mail.IsBodyHtml = true;
                //mail.Attachments.Add(new Attachment("D:\\TestFile.txt"));//--Uncomment this to send any attachment  
                //    using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                //    {
                //        smtp.Credentials = new NetworkCredential(emailFromAddress, password);
                //        smtp.EnableSsl = enableSSL;
                //        smtp.Send(mail);
                //            lbl_message.Visible = true;
                //            lbl_message.Text = "A temporary password has been sent to your email.";
                //            Panel4_forgotpassword.Visible = false;
                //        }
                //}

            }
            catch (Exception jerror1FF)
            {
                ///Do nothing
                string jj = jerror1FF.ToString();
                lbl_message.Visible = true;
                lbl_message.Text = jerror1FF.Message.ToString();
                return;
            }

        }
        protected void forgot_Password_Click(object sender, EventArgs e)
        {

           
            lbl_message.Visible = false;
            lbl_message.Text = "";

            if (txt_forgotten_email.Text.Replace(" ", "") == "")
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter an email.";
                txt_forgotten_email.Focus();
                return;
            }

            bool aa = IsValidEmail(txt_forgotten_email.Text);
            if (aa != true)
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter a valid email .";
                txt_forgotten_email.Focus();
                return;
            }


            string mdsa = "";
            try
            {
                var connection = new Connection_Strings();
                MySql.Data.MySqlClient.MySqlConnection connection6 = new MySql.Data.MySqlClient.MySqlConnection(connection.prod_conn_string.ToString());

                mdsa = Does_email_exist(connection6, txt_forgotten_email.Text);



                if (mdsa == "1asdfartw56wesgbvasert4tqgw45tbasdfasrea")
                {

                  

                }

                else
                {
                    lbl_message.Visible = true;
                    lbl_message.Text = "That email does not exist. Please register.";
                    txt_firstname.Focus();
                    return;
                }

            }
            catch (Exception nerrordd)
            {
                //////////////////no need to read error
                string noerror = nerrordd.ToString();

            }

            ///// create a password
            Guid id = Guid.NewGuid();

            try
            {
                var connection = new Connection_Strings();
                MySql.Data.MySqlClient.MySqlConnection connection44 = new MySql.Data.MySqlClient.MySqlConnection(connection.prod_conn_string.ToString());

               

            }
            catch (Exception nerrordd)
            {
                //////////////////no need to read error
                string noerror = nerrordd.ToString();

            }

            

            string mdsasfafsa = "";
            try
            {
                var connection = new Connection_Strings();
                MySql.Data.MySqlClient.MySqlConnection connection6dd = new MySql.Data.MySqlClient.MySqlConnection(connection.prod_conn_string.ToString());

                ///// update password in registration
                mdsasfafsa = Update_Registration(connection6dd , txt_forgotten_email.Text , id.ToString());



                if (mdsasfafsa == "1asdfartw56wesgbasdfasfdasfdvasert4tqgw45tbaa")
                {

                    lbl_message.Visible = true;
                    lbl_message.Text = "Password updated";
                    

                }

                else
                {
                    lbl_message.Visible = true;
                    lbl_message.Text = "Unable to update password";
                    txt_forgotten_email.Focus();
                    return;
                }

            }
            catch (Exception nerrordd)
            {
                //////////////////no need to read error
                string noerror = nerrordd.ToString();

            }


        

          

            SendEmail(txt_forgotten_email.Text , id.ToString());
        }

        protected void txt_forgotten_email_TextChanged(object sender, EventArgs e)
        {
            Fix_Checkboxes();
        }

        private void Fix_Checkboxes()
        {
             Panel4_forgotpassword.Visible = false;
            Panel_registration.Visible = false;
            lbl_message.Visible = true;
            lbl_message.Text = "";
            if ( (CheckBox1.Checked == true)  )
            {
                try
                {
                     
                    Panel_registration.Visible = true;
                    Panel4_forgotpassword.Visible = false;
                   // cboxforgotpassword.Checked = false;
                   
                   // return;

                }
                catch (Exception eee)
                {
                    string eeee = eee.Message.ToString();
                    lbl_message.Visible = true;
                    lbl_message.Text = eee.ToString();
                    txt_username.Focus();
                    return;
                }
            }

            if ((cboxforgotpassword.Checked == true) )
            {
                try
                {
                     
                    Panel_registration.Visible = false;
                    Panel4_forgotpassword.Visible = true;
                //    CheckBox1.Checked = false;
                  //  return;

                }
                catch (Exception eee)
                {
                    string eeee = eee.Message.ToString();
                    lbl_message.Visible = true;
                    lbl_message.Text = eee.ToString();
                    txt_username.Focus();
                    return;
                }
            }
        }
        protected void cboxforgotpassword_CheckedChanged(object sender, EventArgs e)
        {

            if (cboxforgotpassword.Checked == true)
            {
                CheckBox1.Checked = false;
            }

           

            Fix_Checkboxes();

        }

        protected void ChangePassword_Click(object sender, EventArgs e)
        {
            //string userName1 = "";
            //string userName = userName1;
            lbl_message.Visible = false;
            lbl_message.Text = "";
            string md = "";




          
           


            //if (txt_reg_email.Text.Replace(" ", "") == "")
            //{
            //    lbl_message.Visible = true;
            //    lbl_message.Text = "Please enter an email.";
            //    txt_reg_email.Focus();
            //    return;
            //}

            //bool aa = IsValidEmail(txt_reg_email.Text);
            //if (aa != true)
            //{
            //    lbl_message.Visible = true;
            //    lbl_message.Text = "Please enter a valid email .";
            //    txt_reg_email.Focus();
            //    return;
            //}


            //if (txt_reg_email.Text.Length < 5)
            //{
            //    lbl_message.Visible = true;
            //    lbl_message.Text = "Please make sure your password is at least 5 characters .";
            //    txt_reg_email.Focus();
            //    return;
            //}


            //if (txt_passwordmysql.Text.Replace(" ", "") == "")
            //{
            //    lbl_message.Visible = true;
            //    lbl_message.Text = "Please enter a password.";
            //    txt_reg_email.Focus();
            //    return;
            //}












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


            string mdsasfafsadddd = "";
            


            try
            {
                string new_password = Guid.NewGuid().ToString();
                var connection = new Connection_Strings();
                MySql.Data.MySqlClient.MySqlConnection connection44e = new MySql.Data.MySqlClient.MySqlConnection(connection.prod_conn_string.ToString());

                mdsasfafsadddd = Update_Registration_Password(connection44e, txt_username.Text, txt_passwordmysql.Text);

            }
            catch (Exception nerrordd)
            {
                //////////////////no need to read error
                string noerror = nerrordd.ToString();

            }








            try
            {



                //   "create table getsoftware_users1( id INT NOT NULL AUTO_INCREMENT PRIMARY KEY , email VARCHAR(255) NOT NULL , password VARCHAR(255) NOT NULL , first_name VARCHAR(255) NOT NULL , middle_name VARCHAR(255) NOT NULL , last_name VARCHAR(255) NOT NULL , phone_number INT NULL, last_Login_date TIMESTAMP NOT NULL, the_date TIMESTAMP NOT NULL )"

                if (mdsasfafsadddd == "1asdfartw56wesgbasdfasfdasfdvasert4tqgw45tbaaggg2222")
                {

                    lbl_message.Visible = true;
                    lbl_message.Text = "Password update was was successful! You may now login.";
                    txt_username.Focus();

                    Panel_Change_Password1.Visible = false;
                }

                else

                {

                    try
                    {

                        lbl_message.Visible = true;
                        lbl_message.Text = "Password update was was not successful!";
                        txt_passwordmysql.Focus();

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

        protected void register_Click(object sender, EventArgs e)
        {

           

            string userName1 = "";
            string userName = userName1;
            lbl_message.Visible = false;
            lbl_message.Text = "";
            string md = "";


            if (customFile.Value != "")

            {

                try
                {
                    string filename = Path.GetFileName(customFile.PostedFile.FileName);
                    string contentTypeuploaded = customFile.PostedFile.ContentType;

                    if (contentTypeuploaded.ToLower().StartsWith("image") == true)
                    {

                    }
                    else
                    {
                        lbl_upload_Status.Text = "That file doesn't appear to be an image . Please try again.";
                        return;
                    }
                }
                catch (Exception eee)
                {
                    string jj = eee.ToString();
                    lbl_message.Visible = true;
                    lbl_message.Text = eee.Message.ToString();
                    return;
                }
            }
            else
            {
                lbl_upload_Status.Text = "Please upload a profile picture!!!!";
                lbl_message.Visible = true;
                lbl_message.Text = "Please upload a profile picture!!!!";
                return;
            }
            //////sfadfsad

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


            if (txt_Security_Question1.Text.Replace(" ", "") == "")
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter a security question.";
                txt_Security_Question1.Focus();
                return;
            }

            if (txt_Security_Question1.Text.Length < 3)
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter a valid security question.";
                txt_Security_Question1.Focus();
                return;
            }

            if (txt_Security_Question1.Text.Replace(" ", "") == "")
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter a security answer.";
                txt_Security_Question1.Focus();
                return;
            }

            if (txt_Security_Question1.Text.Length < 0)
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Please enter a valid security answer.";
                txt_Security_Question1.Focus();
                return;
            }


            //string pwd_check = txt_passwordmysql.Text;
            //Regex rgx = new Regex("[^A-Za-z0-9]");
            //bool containsSpecialCharacter = rgx.IsMatch(pwd_check);



            //if (containsSpecialCharacter != true)
            //{

            //    lbl_message.Visible = true;
            //    lbl_message.Text = "Please include a special character in your password .";
            //    txt_passwordmysql.Focus();
            //    return;
            //}

            //bool containsInt = txt_passwordmysql.Text.Any(char.IsDigit);
            //if (containsInt == false)
            //{
            //    lbl_message.Visible = true;
            //    lbl_message.Text = "Please include a number in your password .";
            //    txt_passwordmysql.Focus();
            //    return;
            //}



            //if (txt_passwordmysql.Text.Length > 6)
            //{

            //}
            //else
            //{
            //    lbl_message.Visible = true;
            //    lbl_message.Text = "Please enter at least 7 characters for your password.";
            //    txt_passwordmysql.Focus();
            //    return;
            //}


            //if (txt_passwordmysql.Text != txt_confirm_Password.Text)
            //{
            //    lbl_message.Visible = true;
            //    lbl_message.Text = "Sorry ... your passwords do not match.";
            //    txt_passwordmysql.Focus();
            //    return;
            //}


            string mdsa = "";
            try
            {
                var connection = new Connection_Strings();
                MySql.Data.MySqlClient.MySqlConnection connection6 = new MySql.Data.MySqlClient.MySqlConnection(connection.prod_conn_string.ToString());

                mdsa = Does_email_exist(connection6, txt_reg_email.Text);



                if (mdsa == "1asdfartw56wesgbvasert4tqgw45tbasdfasrea")
                {

                    lbl_message.Visible = true;
                    lbl_message.Text = "That email already exists in our database. Please login.";
                    txt_username.Focus();
                    return;

                }

            }
            catch (Exception nerrordd)
            {
                //////////////////no need to read error
                string noerror = nerrordd.ToString();

            }
            string new_password = "";

            try
            {
                new_password = Guid.NewGuid().ToString();
                var connection = new Connection_Strings();
                MySql.Data.MySqlClient.MySqlConnection connection44 = new MySql.Data.MySqlClient.MySqlConnection(connection.prod_conn_string.ToString());

                md = Write_Registration(connection44, new_password);
                upload_Insert_file();

            }
            catch (Exception nerrordd)
            {
                //////////////////no need to read error
                string noerror = nerrordd.ToString();

            }



            




            try
            {



                //   "create table getsoftware_users1( id INT NOT NULL AUTO_INCREMENT PRIMARY KEY , email VARCHAR(255) NOT NULL , password VARCHAR(255) NOT NULL , first_name VARCHAR(255) NOT NULL , middle_name VARCHAR(255) NOT NULL , last_name VARCHAR(255) NOT NULL , phone_number INT NULL, last_Login_date TIMESTAMP NOT NULL, the_date TIMESTAMP NOT NULL )"

                if (md == "1asdfartw56wesgbasdfasfdasfdvasert4tqgw45tb")
                {

                    lbl_message.Visible = true;
                    lbl_message.Text = "Registration was successful! A temporary password was sent to your email. *** Please allow up to 10 minutes for the email to arrive . - GetSoftwareSupport.com ***";
                    txt_username.Focus();
                    Panel_registration.Visible = false;


                    SendEmail_Registration(txt_reg_email.Text, new_password.ToString());

                   
                }

                else

                {

                    try
                    {

                        lbl_message.Visible = true;
                        lbl_message.Text = "Registration was not successful!";
                        txt_username.Focus();

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