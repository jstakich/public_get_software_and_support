using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace GetSoftwareAndSupport
{
    public partial class MyVideos : System.Web.UI.Page
    {
        
        protected void Page_Init(object sender, EventArgs e)
        {
            string decrypted_usernameq = "";
            string decrypted_passwordq = "";

            try
            {

                if (Session["Username_to_use"] != null)

                {
                    string decrypted_usernameq1 = Decrypt(Session["Username_to_use"].ToString());

                    // txt_email.Text = decrypted_usernameq.ToString();
                    textbox1.Value = decrypted_usernameq1.ToString();
                    label_logged_in.Text = " Logged in as ... " + decrypted_usernameq1.ToString();
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
                if (Session["Logged_in"] == null)
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











        }

        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (Session["Logged_in"] == null)
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


            try
            {
                // LinkButton_editaccountbutton.Visible = false;
                // LinkButton_logoutbutton.Visible = false;
                // LinkButton_loginbutton.Visible = true;

                if (Session["Logged_in"] != null)
                {
                    string str_read_login_var = Convert.ToString(Session["Logged_in"]);

                    //////////////////////////////// If User is logged in 
                    if (str_read_login_var == "True")
                    {

                        //   LinkButton_editaccountbutton.Visible = true;
                        //   LinkButton_logoutbutton.Visible = true;
                        //  LinkButton_loginbutton.Visible = false;


                    }
                }


            }
            catch (Exception ex)
            {
                string aa = ex.ToString();

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

            BindGrid();
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

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {

             


        }
        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            lbl_message.Visible = false;
            lbl_message.Text = "";

            GridView1.PageIndex = e.NewPageIndex;
            this.BindGrid();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            lbl_message.Visible = false;
            lbl_message.Text = "";

            

            

            try
            {





                #region Get_ID From_Grid_View 
                //System.Web.UI.WebControls.TextBox TextBox = GridView1.Rows[e.RowIndex].FindControl("id") as System.Web.UI.WebControls.TextBox;
                //string test = TextBox.Text;
                //System.Web.UI.WebControls.Label id = GridView1.Rows[e.RowIndex].FindControl("lbl_app_group_relation_id") as System.Web.UI.WebControls.Label;
                System.Web.UI.WebControls.TextBox name = GridView1.Rows[e.RowIndex].FindControl("txtId") as System.Web.UI.WebControls.TextBox;
                
                
                //GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex]; 
                //int res = Convert.ToInt32(row.RowIndex.ToString());
                //System.Web.UI.WebControls.TextBox name =  GridView1.Rows[e.RowIndex].Cells[1].FindControl("id") as System.Web.UI.WebControls.TextBox;

                //  System.Web.UI.WebControls.Label id = GridView1.Rows[e.RowIndex].FindControl("id") as System.Web.UI.WebControls.Label;
                // System.Web.UI.WebControls.TextBox name = GridView1.Rows[e.RowIndex].FindControl("id") as System.Web.UI.WebControls.TextBox;
                string string_namme = name.Text;
               // string string_namme = res.ToString();
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
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("DELETE FROM getsoftware_Links7   WHERE   id =" + id_to_delete_by, con);
                    cmd.ExecuteNonQuery();
                    // label_info1.Text = "Item deleted.";
                    
                    
                    lbl_message.Visible = true;
                    lbl_message.Text = "Video deleted.";

                    

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

                    
                    lbl_message.Visible = true;
                    lbl_message.Text = "Unable to read Video ID.";
                    return;
                }
                #endregion





                //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
                GridView1.EditIndex = -1;


              
                Search_Data_2();
 



            }
            catch (Exception dddd)
            {
                string jj = dddd.ToString();
                lbl_message.Visible = true;
                lbl_message.Text = dddd.Message.ToString();

                return;

            }

        }
        private void Search_Data_2()
        {
            try
            {

                BindGrid();
                



            }
            catch (Exception dddd)
            {
                

            }

        }


        //private string Update_User_Information(string conn_string, Nullable<int> app_u_ral, string ad_group_sid, string ad_group_name, string permissions)
        //{



        //    string modifiedstring = "";

        //    try

        //    {



        //        string connectionString = cs;
        //        MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connectionString);



        //        int asdf = 1;

        //        using (MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("Update tbl_Comments4  SET  [ad_group_sid] = @field_two    , [ad_group_name] = @field_three    , [permissions] = @field_four      Where  [ad_group_relation_id] = @the_ID", conn))
        //        {




        //            try
        //            {

        //                cmd.Parameters.AddWithValue("@the_ID", app_u_ral);
        //            }
        //            catch (Exception dddd)
        //            {
        //                string the_e = dddd.Message.ToString();
        //                //////// return on this because it can never be null
        //                return modifiedstring;
        //            }



        //            try
        //            {
        //                if (ad_group_sid.Replace(" ", "") == "")
        //                    //// it will never make it here.
        //                    cmd.Parameters.AddWithValue("@field_two", DBNull.Value);
        //                else
        //                    cmd.Parameters.AddWithValue("@field_two", ad_group_sid);
        //            }
        //            catch (Exception dddd)
        //            {
        //                string the_e = dddd.Message.ToString();
        //            }



        //            try
        //            {
        //                if (ad_group_name.Replace(" ", "") == "")
        //                    //// it will never make it here.
        //                    cmd.Parameters.AddWithValue("@field_three", DBNull.Value);
        //                else
        //                    cmd.Parameters.AddWithValue("@field_three", ad_group_name);
        //            }
        //            catch (Exception dddd)
        //            {
        //                string the_e = dddd.Message.ToString();
        //            }



        //            try
        //            {
        //                if (permissions.Replace(" ", "") == "")
        //                    //// it will never make it here.
        //                    cmd.Parameters.AddWithValue("@field_four", DBNull.Value);
        //                else
        //                    cmd.Parameters.AddWithValue("@field_four", permissions);
        //            }
        //            catch (Exception dddd)
        //            {
        //                string the_e = dddd.Message.ToString();
        //            }





        //            cmd.Connection.Open();


        //            int ID_TO_Return = Convert.ToInt32(cmd.ExecuteScalar());
        //            //This is the only place we set this value to other than nothing in this sub   We are just going to tell the user if it updated or not.
        //            modifiedstring = ID_TO_Return.ToString();


        //            try
        //            {
        //                cmd.Dispose();
        //            }
        //            catch (Exception the_error)
        //            {
        //                string the_errorstere = the_error.ToString();
        //                ///don't return 
        //            }



        //            try
        //            {
        //                conn.Close();
        //            }
        //            catch (Exception the_error)
        //            {
        //                string the_errorstere = the_error.ToString();
        //                ///don't return 
        //            }

        //            try
        //            {
        //                conn.Dispose();
        //            }
        //            catch (Exception the_error)
        //            {
        //                string the_errorstere = the_error.ToString();
        //                ///don't return 
        //            }




        //            return modifiedstring;
        //        }

        //    }
        //    catch (Exception the_error)
        //    {
        //        string the_errorstere = the_error.ToString();
        //        ////keep this to nothing unless we get a value. We are just going to tell the user if it updated or not.
        //        modifiedstring = "";
        //        return modifiedstring;

        //    }

        //}

        protected void GridView1_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {


           
        }

        private void ShowData()
        {
            try
            {
                BindGrid();
                

            }
            catch (Exception dddd)
            {
                
            }

        }
        protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            lbl_message.Visible = false;
            lbl_message.Text = "";

            //NewEditIndex property used to determine the index of the row being edited.  
            GridView1.EditIndex = e.NewEditIndex;
            ShowData();
        }
        protected void GridView1_RowCancelingEdit(object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
            //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
            GridView1.EditIndex = -1;
            ShowData();
        }
        protected void OnPaging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            this.BindGrid();
        }
        public void BindGrid()
        {
            try
            { 
            GridView1.DataSource = null;
            GridView1.DataBind();
            ArrayList Myarraylist = new ArrayList();
                var connection = new Connection_Strings();
                using (MySqlConnection con = new MySqlConnection(connection.prod_conn_string.ToString()))
            {
                string decrypted_usernameq = Decrypt(Session["Username_to_use"].ToString());

                //MySqlCommand command = new MySqlCommand(
                //  "select  email , link  , the_date , Organization  , Block  from getsoftware_Links7 where email = '" + decrypted_usernameq.ToString().ToLower() + "' order by the_date desc",
                //  con);
                //con.Open();

                MySqlCommand command = new MySqlCommand(
              " select *  from getsoftware_Links7 where email = '" + decrypted_usernameq.ToString().ToLower() + "' order by the_date desc",
              con);
                con.Open();

                // MySqlDataReader reader = command.ExecuteReader();

                using (MySqlDataAdapter sda = new MySqlDataAdapter())
                {
                    command.Connection = con;
                    sda.SelectCommand = command;
                    using (DataTable dt = new DataTable())
                    {
                        sda.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }

                string aa = "";
                string readingEmail = "";
                string readingLink = "";
                string Name = "";
                string date2 = "";
                //if (reader.HasRows)
                //{
                //    while (reader.Read())
                //    {
                //        readingEmail = reader.GetString(0);
                //        readingLink = reader.GetString(1);
                //        date2 = reader.GetString(2);
                //        if (Session["Username_to_use"] != null)

                //        {
                //            string decrypted_usernameq = Decrypt(Session["Username_to_use"].ToString());

                //            if (readingEmail.ToString().ToLower() == decrypted_usernameq.ToString().ToLower())
                //            {






                //           string Control_To_Add = "";
                //        //string Quote = @"''";
                //        Guid id = Guid.NewGuid();

                //       // var string0 = " <div style=" + "\"" + " overflow-y: scroll; overflow-x: scroll; margin: auto; width: 425; border: 3px solid  #000000;  padding: 10px;" + "\"" + " > ";
                //                var String_Div_Start_Tag = "</br>  <div>  " + date2 + " </br> ";


                //                var String_Video_Head_Tag = " <video   width =" + "\"" + "400" + "\"" + " height =" + "\"" + "350" + "\"" +     " id =" + "\"" + "VideoPlayer" + id.ToString() + "\"" + " controls muted loop playsinline autoplay ";

                //              //  var String_Video_Head_Tag = " <video controls loop playsinline autoplay muted  id=" + single + "VideoPlayer" + id.ToString() + single + ">";
                //                var String_Source_Start_Tag = " src =" + "\"" + readingLink + "\"" ;
                //                var String_Type = " type =" + "\"" + "video/mp4" + "\"";
                //              //  var String_Source_End_Tag = "";
                //              //  var String_Source_End_Tag = "";
                //                // var String_Width_Tag = " width =" + "\"" + "400" + "\"";
                //                // var String_Height = " height =" + "\"" + "350" + "\"";
                //                var String_Browser_Wording = " Your browser does not support the video tag.";
                //                var String_Video_End_Tag = " </video> ";
                //                var String_Div_End_Tag = " </div>";
                //                //     control_to_Add = string0 + string1   + string3 + string4 + string5 + string6 + string7 + string8 + string9;
                //                Control_To_Add = 
                //                  String_Div_Start_Tag
                //                + String_Video_Head_Tag
                //                //+ String_Width_Tag
                //                //+ String_Height
                //                + String_Source_Start_Tag
                //                + String_Type
                //              // + String_Source_End_Tag
                //                + String_Browser_Wording
                //                + String_Video_End_Tag
                //                + String_Div_End_Tag ;

                //               Myarraylist.Add(Control_To_Add);

                //        }
                //    }
                //    }
                //}
                //else
                //{
                //    Console.WriteLine("No rows found.");
                //}
                //reader.Close();
                //reader.Dispose();

                try
                {

                    con.Close();
                }
                catch (Exception ex)
                {

                }
                try
                {
                    con.Dispose();
            }
            catch (Exception ex)
            {

            }


        }

                //foreach(string aa in Myarraylist)
                //{ 
                //     Test1.Controls.Add(new LiteralControl(aa)); 

                //}


            }
            catch (Exception dddd)
            {
           
                lbl_message.Visible = true;
                lbl_message.Text = dddd.Message.ToString();

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

        protected void btnRefreshVideos(object sender, EventArgs e)
        {
            try
            {
                lbl_message.Visible = false;
                lbl_message.Text = "";

                Response.Redirect("/MyVideos");
            }
            catch (Exception ex)
            {
                 
                lbl_message.Visible = true;
                lbl_message.Text = ex.Message.ToString();
            }
        }
    }
}