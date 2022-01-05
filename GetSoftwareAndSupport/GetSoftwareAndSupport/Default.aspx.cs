using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using MySql.Data;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Web.Security;
using MySql.Data.MySqlClient;
namespace GetSoftwareAndSupport
{
    public partial class Default : Page
    {
        
        

        protected void Page_Init(object sender, EventArgs e)
        {

           

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string md = "";
            try
            {

                if (Session["Username_to_use"] != null)

                {
                    string decrypted_usernameq = Decrypt(Session["Username_to_use"].ToString());

                    // txt_email.Text = decrypted_usernameq.ToString();
                    textbox1.Value = decrypted_usernameq.ToString();
                    label_logged_in.Text = " Logged in as ... " + decrypted_usernameq.ToString();
                    txtEmailComment.Text = decrypted_usernameq.ToString().ToLower();
                    lbl_comments.Text = "Please leave a comment.";
                    div_toshow.Visible = true;

                    try
                    {
                        var connection = new Connection_Strings();
                        MySql.Data.MySqlClient.MySqlConnection connection6ddd = new MySql.Data.MySqlClient.MySqlConnection(connection.prod_conn_string.ToString());

                        md = Read_Name_In_Database(connection6ddd, decrypted_usernameq);

                    }
                    catch (Exception nerrordd)
                    {
                        //////////////////no need to read error
                        string noerror = nerrordd.ToString();

                    }
                }
                else
                {
                    label_logged_in.Text = " Please log in." ;
                    lbl_comments.Text = "Please login to leave a comment.";
                    div_toshow.Visible = false;
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
            //if (!IsPostBack)
            //{
            // //   fillData();
            //}




            //#region Set Connection_Type_And_String 
            //try
            //{
            //    Boolean Set_Connection_to_DB = false;

            //    string connect_to_Prod_Dev_or_Test = ConfigurationManager.AppSettings["db_conn_type"];
            //    if (connect_to_Prod_Dev_or_Test.ToString().ToLower() == "dev")
            //    {
            //        cn.connection_to_use = cn.dev_conn_string;
            //        cn.password_to_use = cn.dev_password;
            //        cn.username_to_use = cn.dev_username;
            //        cn.domain_to_use = cn.dev_domain;
            //        cn.username_read_AD_Groups_to_use = cn.dev_username_read_AD_Groups;
            //        cn.password_read_AD_Groups_to_use = cn.dev_password_read_AD_Groups;
            //        Set_Connection_to_DB = true;
            //    }

            //    if (connect_to_Prod_Dev_or_Test.ToString().ToLower() == "prod")
            //    {
            //        cn.connection_to_use = cn.prod_conn_string;
            //        cn.password_to_use = cn.prod_password;
            //        cn.username_to_use = cn.prod_username;
            //        cn.domain_to_use = cn.prod_domain;
            //        cn.username_read_AD_Groups_to_use = cn.prod_username_read_AD_Groups;
            //        cn.password_read_AD_Groups_to_use = cn.prod_password_read_AD_Groups;
            //        Set_Connection_to_DB = true;
            //    }

            //    if (connect_to_Prod_Dev_or_Test.ToString().ToLower() == "test")
            //    {
            //        cn.connection_to_use = cn.test_conn_string;
            //        cn.password_to_use = cn.test_password;
            //        cn.username_to_use = cn.test_username;
            //        cn.domain_to_use = cn.test_domain;
            //        cn.username_read_AD_Groups_to_use = cn.test_username_read_AD_Groups;
            //        cn.password_read_AD_Groups_to_use = cn.test_password_read_AD_Groups;
            //        Set_Connection_to_DB = true;
            //    }

            //    if (Set_Connection_to_DB == false)
            //    {
            //        string sadf = "Unable to set database connection !";
            //        string guid_script_coded_a1 = Guid.NewGuid().ToString();
            //        StringBuilder jerscripta1 = new StringBuilder();
            //        jerscripta1.Append("$(document).ready(function(){");
            //        jerscripta1.Append("alert('" + sadf + "');");
            //        jerscripta1.Append("});");
            //        ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
            //        jerscripta1.ToString(), true);
            //        ///end
            //        return;
            //    }

            //}
            //catch (Exception errff)
            //{

            //    string errevvv = errff.ToString();
            //    string sadf = "Unable to set database connection !";
            //    string guid_script_coded_a1 = Guid.NewGuid().ToString();
            //    StringBuilder jerscripta1 = new StringBuilder();
            //    jerscripta1.Append("$(document).ready(function(){");
            //    jerscripta1.Append("alert('" + sadf + "');");
            //    jerscripta1.Append("});");
            //    ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
            //    jerscripta1.ToString(), true);
            //    ///end
            //    return;
            //}
            //#endregion

            //#region Login And_Security_Run_on_Every_Page 
            //try
            //{




            //    try
            //    {



            //        try
            //        {

            //            //if (Session["View_Edit_Permissions"].ToString() == "cognitio_edit_ls")
            //            //{
            //            //    Image_Access.ImageUrl = "/icon/Edit_Access2.png";

            //            //    is_User_in_a_group_for_this_page = true;
            //            //}

            //        }
            //        catch (Exception err)
            //        {
            //            //try
            //            //{
            //            //    ///catch if null
            //            //    string erre = err.ToString();

            //            //    Response.Redirect("/Account/Cog_Login");
            //            //}
            //            //catch (Exception jerror1tt)
            //            //{
            //            //    string jj = jerror1tt.ToString();

            //            //}

            //        }






            //        try
            //        {

            //            //if (Session["View_Edit_Permissions"].ToString() == "cognitio_admin_ls")
            //            //{
            //            //    Image_Access.ImageUrl = "/icon/Admin_Access2.png";
            //            //    is_User_in_a_group_for_this_page = true;
            //            //}
            //        }
            //        catch (Exception err)
            //        {
            //            //try
            //            //{
            //            //    ///catch if null
            //            //    string erre = err.ToString();

            //            //    Response.Redirect("/Account/Cog_Login");
            //            //}
            //            //catch (Exception jerror1tt)
            //            //{
            //            //    string jj = jerror1tt.ToString();

            //            //}

            //        }





            //        //////////////////////redirect if user is not in a group needed




            //    }
            //    catch (Exception jerror1ff)
            //    {
            //        ///// no redirect here because we are handling above and they bug out below
            //        string je = jerror1ff.ToString();

            //    }





            //}
            //catch (Exception error2)
            //{
            //    string dddr = error2.ToString();

            //}



            //////////////////////////Run any other code after the fact
            //#endregion


            //#region Check For_App)ID 
            ////// All of this code must run below the normal check for session vars and redirects

            //#endregion
            //#region First Page_Load 
            //if (!Page.IsPostBack)
            //{





            //    #region read page_session 


            //    ////////////////////////////////////////////////////////////////////////////////
            //    try
            //    {

            //        try
            //        {
            //            if (Session["Application_Name_App_Edit"] != null)
            //            {
            //                //lbl_app_to_add_edit_or_delete.Text = Session["Application_Name_App_Edit"].ToString();
            //            }

            //        }
            //        catch (Exception dddd)
            //        {
            //            ///////////// No need to catch this
            //            string the_e = dddd.Message.ToString();
            //        }
            //        //////////////////////////////////////



            //    }
            //    catch (Exception dddd)
            //    {
            //        string the_e = dddd.Message.ToString();
            //        string guid_script_coded_a1 = Guid.NewGuid().ToString();
            //        StringBuilder jerscripta1 = new StringBuilder();
            //        jerscripta1.Append("$(document).ready(function(){");
            //        jerscripta1.Append("alert('" + the_e + "');");
            //        jerscripta1.Append("});");
            //        ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
            //        jerscripta1.ToString(), true);
            //        ///end
            //        return;

            //    }
            //    ////////////////////////////////////////////////////////////////////////////////
            //    #endregion

            //    #region Database Read 
            //    try
            //    {










            //             MySql.Data.MySqlClient.MySqlConnection connection7 = new MySql.Data.MySqlClient.MySqlConnection(cs);
            //         //   Read_Data_Previously_Inserted_application_User_relation(connection7);
            //            //  SqlConnection connection6 = new SqlConnection(con_string_new);
            //            // Read_App_to_edit(connection6, Session["Application_Name_App"].ToString());



            //    }
            //    catch (Exception the_error1)
            //    {
            //        string sadf = the_error1.Message.ToString();
            //        string guid_script_coded_a1 = Guid.NewGuid().ToString();
            //        StringBuilder jerscripta1 = new StringBuilder();
            //        jerscripta1.Append("$(document).ready(function(){");
            //        jerscripta1.Append("alert('" + sadf + "');");
            //        jerscripta1.Append("});");
            //        ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
            //        jerscripta1.ToString(), true);
            //        ///end


            //    }


            //    #endregion







            //}
            //#endregion
            //else
            //#region Every Page_Load 
            //{





            //}
            //#endregion



            if (!this.IsPostBack)
            {
                this.BindGrid();
            }


        }


        private void BindGrid()
        {
            GridView1.DataSource = null ;
            GridView1.DataBind();
            var connection = new Connection_Strings();
            using (MySqlConnection   con = new MySqlConnection(connection.prod_conn_string.ToString()))
            {
               // using (MySqlCommand cmd = new MySqlCommand("SELECT The_Image , Name , Email, Comment, Comment_Date FROM tbl_Comment5 where block = 0 ORDER BY Comment_Date DESC"))
               // {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT pi.The_Image , tc.Name , tc.Email , tc.Comment , tc.Comment_Date FROM profile_images as pi left outer JOIN tbl_Comment5 tc ON pi.email = tc.Email ORDER by pi.the_date desc , tc.Comment_Date DESC"))
                    {
                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                             
                        }
                        
                    }
                    cmd.Dispose();
                }
                con.Close();
                con.Dispose();
            }
          
        }
        protected void btn_Submit_Click(object sender, EventArgs e)
        {
            DateTime theDate1 = DateTime.Now;

            // string decrypted_usernameq = Decrypt(Session["Username_to_use"].ToString().ToLower());

            //create table tbl_Comment6( Id INT NOT NULL AUTO_INCREMENT PRIMARY KEY , Email VARCHAR(255) NOT NULL , Comment MEDIUMTEXT NOT NULL , Block INT NOT NULL , Comment_Date TIMESTAMP NOT NULL )
            var connection = new Connection_Strings();
            MySqlConnection con = new MySqlConnection(connection.prod_conn_string.ToString());
            con.Open();
            MySqlCommand cmd = new MySqlCommand("insert into tbl_Comment5(Name ,Email,Comment,block,Comment_Date) values(@name,@email,@comment,@block,@Comment_Date)", con);
           cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@email", txtEmailComment.Text);
            cmd.Parameters.AddWithValue("@comment", txtComment.Text);
            cmd.Parameters.AddWithValue("@block", 0);
            cmd.Parameters.AddWithValue("@Comment_Date", theDate1);
            
            cmd.ExecuteNonQuery();
            con.Close();
            con.Dispose();
            //Displaying Javascript alert Comment Posted Successfully
            // ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Comment Posted Successfully.');window.location='default.aspx';", true);
          BindGrid();
          // txtName.Text = "";
           // txtEmailComment.Text = "";
            txtComment.Text = "";
        }
      

        //FillData method for filling Repeater Control with Data
        //private void fillData()
        //{


        //    MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection(cs);
        //    con.Open();
        //    DataTable dt = new DataTable();
        //    MySql.Data.MySqlClient.MySqlDataAdapter adapt = new MySql.Data.MySqlClient.MySqlDataAdapter("Select * from tbl_Comments4 Order by ts desc limit 1000", con);
        //    adapt.Fill(dt);
        //    con.Close();
        //    PagedDataSource pds = new PagedDataSource();
        //    DataView dv = new DataView(dt);
        //    pds.DataSource = dv;
        //    pds.AllowPaging = true;
        //    pds.PageSize = 4;
        //    pds.CurrentPageIndex = PageNumber;
        //    if (pds.PageCount > 1)
        //    {
        //        rptPaging.Visible = true;
        //        ArrayList arraylist = new ArrayList();
        //        for (int i = 0; i < pds.PageCount; i++)
        //            arraylist.Add((i + 1).ToString());
        //        rptPaging.DataSource = arraylist;
        //        rptPaging.DataBind();
        //    }
        //    else
        //    {
        //        rptPaging.Visible = false;
        //    }
        //    Repeater1.DataSource = pds;
        //    Repeater1.DataBind();
        //}
        //btn_Submit Click Event
        
        


        

        protected void LinkButton6_Click(object sender, EventArgs e)
        {



            //try
            //{
            //    StringBuilder strScriptdd = new StringBuilder();
            //    strScriptdd.Append("$(document).ready(function(){");
            //    strScriptdd.Append("});");
            //    ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), "Script",
            //    strScriptdd.ToString(), true);
            //}
            //catch (Exception the_error1)
            //{
            //    string sadf = the_error1.Message.ToString();
            //    string guid_script_coded_a1 = Guid.NewGuid().ToString();
            //    StringBuilder jerscripta1 = new StringBuilder();
            //    jerscripta1.Append("$(document).ready(function(){");
            //    jerscripta1.Append("alert('Error running startup Script!');");
            //    jerscripta1.Append("});");
            //    ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
            //    jerscripta1.ToString(), true);
            //    ///end
            //    return;

            //}


        
        }

        protected void Contract(object sender, EventArgs e)

        { 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
         //   fillData();

            //try
            //{
            //    StringBuilder strScriptdd = new StringBuilder();
            //    strScriptdd.Append("$(document).ready(function(){");
            //    strScriptdd.Append("});");
            //    ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), "Script",
            //    strScriptdd.ToString(), true);
            //}
            //catch (Exception the_error1)
            //{
            //    string sadf = the_error1.Message.ToString();
            //    string guid_script_coded_a1 = Guid.NewGuid().ToString();
            //    StringBuilder jerscripta1 = new StringBuilder();
            //    jerscripta1.Append("$(document).ready(function(){");
            //    jerscripta1.Append("alert('Error running startup Script!');");
            //    jerscripta1.Append("});");
            //    ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
            //    jerscripta1.ToString(), true);
            //    ///end
            //    return;

            //}

        //    Guid g = Guid.NewGuid();
        //    MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection(cs);
        //    con.Open();
        //MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("insert into tbl_Comments4(ID , Name,Email,Comment , ts , dt) values(@id , @name,@email,@comment , @ts , @dt)", con);
        //  //  MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("insert into tbl_Comments2(Name,Email,Comment) values(@id , @name,@email,@comment)", con);

        //  cmd.Parameters.AddWithValue("@id", g.ToString());
        //    cmd.Parameters.AddWithValue("@name", txtName.Text);
        //    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
        //    cmd.Parameters.AddWithValue("@comment", txtComment.Text);
        //    cmd.Parameters.AddWithValue("@ts", DateTime.Now);
        //    cmd.Parameters.AddWithValue("@dt", DateTime.Now);
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //    //Displaying Javascript alert Comment Posted Successfully
        //  //  ScriptManager.RegisterStartupScript(this, this.GetType(), "popup", "alert('Comment Posted Successfully.');window.location='default.aspx';", true);
        //  // fillData();
        //    txtName.Text = "";
        //    txtEmail.Text = "";
        //    txtComment.Text = "";

        }





        //protected void GridView2_RowCancelingEdit(object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        //{
        //    //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
        //  //  GridView2.EditIndex = -1;
        //    ShowData();
        //}


        //protected void GridView2_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        //{
        //    //NewEditIndex property used to determine the index of the row being edited.  
        // //   GridView2.EditIndex = e.NewEditIndex;
        //    ShowData();
        //}

        //private void ShowData()
        //{
        //    try
        //    {
        //        //  label_info1.Text = "";

        //        string selectQueryString = "Select * from tbl_Comments4 Order by ts desc limit 1000";
        //          //  string selectQueryString = "SELECT  [dbo].[ad_groups_relation].[ad_group_relation_id]  ,[dbo].[ad_groups_relation].[application_id]  ,[dbo].[ad_groups_relation].[ad_group_sid]  ,[dbo].[ad_groups_relation].[ad_group_name]  ,[dbo].[ad_groups_relation].[permissions] FROM [dbo].[ad_groups_relation]    WHERE (       (       ([dbo].[ad_groups_relation].[ad_group_sid]  like '%" + Txtsearch.Text + "%') or ([dbo].[ad_groups_relation].[ad_group_name]  like '%" + Txtsearch.Text + "%')    )            and ([dbo].[ad_groups_relation].[application_id] = '" + Session["Edit_App_ID"].ToString() + "') )";
        //            MySql.Data.MySqlClient.MySqlConnection connection2 = new MySql.Data.MySqlClient.MySqlConnection(cs);

        //            MySql.Data.MySqlClient.MySqlDataAdapter sqlDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(selectQueryString, connection2);
        //            MySql.Data.MySqlClient.MySqlCommandBuilder sqlCommandBuilder = new MySql.Data.MySqlClient.MySqlCommandBuilder(sqlDataAdapter);
        //            sqlDataAdapter.SelectCommand.CommandTimeout = 0;
        //            System.Data.DataTable dataTable = new System.Data.DataTable();
        //            sqlDataAdapter.Fill(dataTable);
        //            BindingSource bindingSource = new BindingSource();
        //            bindingSource.DataSource = dataTable;
        //            GridView2.DataSourceID = null;

        //            GridView2.DataSource = bindingSource;
        //            GridView2.DataBind();

        //            int c = 0;

        //            try
        //            {

        //                c = dataTable.Rows.Count;
        //                if (c == 0)
        //                {
        //                  //  label_info1.Text = "No data located.";
        //                }
        //                else
        //                {
        //                  //  label_info1.Text = "Located data.";
        //                }

        //            }
        //            catch (Exception dddd)
        //            {
        //                string the_e = dddd.Message.ToString();

        //            }


        //            try
        //            {
        //                connection2.Close();
        //            }
        //            catch (Exception dddd)
        //            {
        //                string sadf = dddd.ToString();
        //            }

        //            try
        //            {
        //                sqlDataAdapter.Dispose();
        //            }
        //            catch (Exception dddd)
        //            {
        //                string sadf = dddd.ToString();
        //            }

        //            try
        //            {
        //                dataTable.Dispose();
        //            }
        //            catch (Exception dddd)
        //            {
        //                string sadf = dddd.ToString();
        //            }

        //            try
        //            {
        //                connection2.Dispose();
        //            }
        //            catch (Exception dddd)
        //            {
        //                string sadf = dddd.ToString();
        //            }
                 


        //    }
        //    catch (Exception dddd)
        //    {
        //        string sadf = dddd.ToString(); ;
        //        //string guid_script_coded_a1 = Guid.NewGuid().ToString();
        //        //StringBuilder jerscripta1 = new StringBuilder();
        //        //jerscripta1.Append("$(document).ready(function(){");
        //        //jerscripta1.Append("alert('" + sadf + "');");
        //        //jerscripta1.Append("});");
        //        //ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
        //        //jerscripta1.ToString(), true);
        //        /////end
        //        return;

        //    }

        //}


        //protected void GridView2_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        //{


        //    #region Check_Update Permissions 
        //    try
        //    {

        //        //  label_info1.Text = "You do not have permissions to delete.";
        //        if (Session["View_Edit_Permissions"].ToString() == "cognitio_view_ls")
        //        {
        //            //  label_info1.Text = "You do not have permissions to delete.";
        //            string sadf = "You do not have permissions to delete.";
        //            string guid_script_coded_a1 = Guid.NewGuid().ToString();
        //            StringBuilder jerscripta1 = new StringBuilder();
        //            jerscripta1.Append("$(document).ready(function(){");
        //            jerscripta1.Append("alert('" + sadf + "');");
        //            jerscripta1.Append("});");
        //            ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
        //            jerscripta1.ToString(), true);
        //            ///end

        //            return;
        //        }
        //        else
        //        {


        //        }
        //    }
        //    catch (Exception err)
        //    {
        //        ///catch if null
        //        string erre = err.ToString();
        //        //  label_info1.Text = "You do not have permissions to delete.";

        //        string sadf = "You do not have permissions to delete.";
        //        string guid_script_coded_a1 = Guid.NewGuid().ToString();
        //        StringBuilder jerscripta1 = new StringBuilder();
        //        jerscripta1.Append("$(document).ready(function(){");
        //        jerscripta1.Append("alert('" + sadf + "');");
        //        jerscripta1.Append("});");
        //        ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
        //        jerscripta1.ToString(), true);
        //        return;
        //    }



        //    #endregion



        //    Boolean Has_user_selected_Something = false;
        //    try
        //    {
        //        Comment New_Comment = new Comment();

        //        #region Get_ID From_Grid_View 

        //        System.Web.UI.WebControls.Label id = GridView2.Rows[e.RowIndex].FindControl("lbl_Name") as System.Web.UI.WebControls.Label;
        //        System.Web.UI.WebControls.TextBox name = GridView2.Rows[e.RowIndex].FindControl("txt_Name") as System.Web.UI.WebControls.TextBox;




        //        System.Web.UI.WebControls.TextBox var_txt_Email = GridView2.Rows[e.RowIndex].FindControl("txt_Email") as System.Web.UI.WebControls.TextBox;
        //        System.Web.UI.WebControls.TextBox var_txt_Comment = GridView2.Rows[e.RowIndex].FindControl("txt_Comment") as System.Web.UI.WebControls.TextBox;
        //        System.Web.UI.WebControls.TextBox var_txt_ts = GridView2.Rows[e.RowIndex].FindControl("txt_ts") as System.Web.UI.WebControls.TextBox;





        //        Boolean It_exits = false;
        //        Boolean Validated = false;
        //        Boolean Data_Was_Updated = false;
        //       // label_info1.Text = "";
        //      //  label_info_Edit.Text = "";

        //        int id_of_app = -99;
        //        Boolean Do_update_Instead = false;


        //        string string_namme = name.Text;
        //        int id_to_delete_by = -99;

        //        id_to_delete_by = Convert.ToInt32(string_namme);
        //        New_Comment.app_user_relation = id_to_delete_by;
        //        #endregion


        //     //   label_info1.Text = "";

        //        //Anything in here will run as user






        //        try
        //        {


        //            if (var_txt_ts.Text.Replace(" ", "") == "")
        //            {


        //            }
        //            else
        //            {
        //                Has_user_selected_Something = true;
        //            }
        //        }
        //        catch (Exception the_error1)
        //        {
        //            string sadf = the_error1.Message.ToString();
        //            string guid_script_coded_a1 = Guid.NewGuid().ToString();
        //            StringBuilder jerscripta1 = new StringBuilder();
        //            jerscripta1.Append("$(document).ready(function(){");
        //            jerscripta1.Append("alert('" + the_error1 + "');");
        //            jerscripta1.Append("});");
        //            ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
        //            jerscripta1.ToString(), true);
        //            ///end
        //            return;

        //        }




        //        try
        //        {
        //            Boolean true_or_false = var_txt_Email.Text.Contains(" ");
        //            if (true_or_false == true)
        //            {

        //                string sadf = "Please remove the space in SID.";
        //                string guid_script_coded_a1 = Guid.NewGuid().ToString();
        //                StringBuilder jerscripta1 = new StringBuilder();
        //                jerscripta1.Append("$(document).ready(function(){");
        //                jerscripta1.Append("alert('" + sadf + "');");
        //                jerscripta1.Append("});");
        //                ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
        //                jerscripta1.ToString(), true);

        //                return;
        //            }
        //        }
        //        catch (Exception dddd)
        //        {
        //            string sadf = dddd.ToString();
        //        }





        //        try
        //        {
        //            Boolean true_or_false = var_txt_Comment.Text.Contains(" ");
        //            if (true_or_false == true)
        //            {

        //                string sadf = "Please remove the space in AD Group.";
        //                string guid_script_coded_a1 = Guid.NewGuid().ToString();
        //                StringBuilder jerscripta1 = new StringBuilder();
        //                jerscripta1.Append("$(document).ready(function(){");
        //                jerscripta1.Append("alert('" + sadf + "');");
        //                jerscripta1.Append("});");
        //                ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
        //                jerscripta1.ToString(), true);

        //                return;
        //            }
        //        }
        //        catch (Exception dddd)
        //        {
        //            string sadf = dddd.ToString();
        //        }






        //        try
        //        {


        //            if ((var_txt_Email.Text.Replace(" ", "") != "") || (var_txt_Comment.Text.Replace(" ", "") != ""))
        //            {


        //            }
        //            else

        //            {
        //                string sadf = "Please enter a Sid or an AD Group Name.";
        //                string guid_script_coded_a1 = Guid.NewGuid().ToString();
        //                StringBuilder jerscripta1 = new StringBuilder();
        //                jerscripta1.Append("$(document).ready(function(){");
        //                jerscripta1.Append("alert('" + sadf + "');");
        //                jerscripta1.Append("});");
        //                ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
        //                jerscripta1.ToString(), true);
        //                ///end
        //                return;
        //            }
        //        }
        //        catch (Exception the_error1)
        //        {
        //            string sadf = the_error1.Message.ToString();
        //            string guid_script_coded_a1 = Guid.NewGuid().ToString();
        //            StringBuilder jerscripta1 = new StringBuilder();
        //            jerscripta1.Append("$(document).ready(function(){");
        //            jerscripta1.Append("alert('" + the_error1 + "');");
        //            jerscripta1.Append("});");
        //            ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
        //            jerscripta1.ToString(), true);
        //            ///end
        //            return;

        //        }


        //        try
        //        {


        //            if ((var_txt_ts.Text.Replace(" ", "") != ""))
        //            {


        //            }
        //            else

        //            {
        //                string sadf = "Please enter Permissions.";
        //                string guid_script_coded_a1 = Guid.NewGuid().ToString();
        //                StringBuilder jerscripta1 = new StringBuilder();
        //                jerscripta1.Append("$(document).ready(function(){");
        //                jerscripta1.Append("alert('" + sadf + "');");
        //                jerscripta1.Append("});");
        //                ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
        //                jerscripta1.ToString(), true);
        //                ///end
        //                return;
        //            }
        //        }
        //        catch (Exception the_error1)
        //        {
        //            string sadf = the_error1.Message.ToString();
        //            string guid_script_coded_a1 = Guid.NewGuid().ToString();
        //            StringBuilder jerscripta1 = new StringBuilder();
        //            jerscripta1.Append("$(document).ready(function(){");
        //            jerscripta1.Append("alert('" + the_error1 + "');");
        //            jerscripta1.Append("});");
        //            ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
        //            jerscripta1.ToString(), true);
        //            ///end
        //            return;

        //        }





        //        try
        //        {


        //            if (Has_user_selected_Something == false)
        //            {

        //                string sadf = "Please enter the group info to add.";
        //                string guid_script_coded_a1 = Guid.NewGuid().ToString();
        //                StringBuilder jerscripta1 = new StringBuilder();
        //                jerscripta1.Append("$(document).ready(function(){");
        //                jerscripta1.Append("alert('" + sadf + "');");
        //                jerscripta1.Append("});");
        //                ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
        //                jerscripta1.ToString(), true);
        //                ///end
        //                return;

        //            }
        //            else
        //            {

        //            }
        //        }
        //        catch (Exception the_error1)
        //        {
        //            string sadf = the_error1.Message.ToString();
        //            string guid_script_coded_a1 = Guid.NewGuid().ToString();
        //            StringBuilder jerscripta1 = new StringBuilder();
        //            jerscripta1.Append("$(document).ready(function(){");
        //            jerscripta1.Append("alert('" + the_error1 + "');");
        //            jerscripta1.Append("});");
        //            ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
        //            jerscripta1.ToString(), true);
        //            ///end
        //            return;

        //        }



                



        //        #region Set Structure 

        //        try
        //        {








        //            try
        //            {
        //                New_Comment.c_txt_Comment = var_txt_Comment.Text;
        //            }
        //            catch (Exception the_error1)
        //            {
        //                string sadf = the_error1.Message.ToString();
        //                New_Comment.c_txt_Comment = "";
        //            }

        //            try
        //            {
        //                New_Comment.c_txt_Email = var_txt_Email.Text;
        //            }
        //            catch (Exception the_error1)
        //            {
        //                string sadf = the_error1.Message.ToString();
        //                New_Comment.c_txt_Email = "";
        //            }


        //            try
        //            {
        //                New_Comment.c_txt_ts = var_txt_ts.Text;
        //            }
        //            catch (Exception the_error1)
        //            {
        //                string sadf = the_error1.Message.ToString();
        //                New_Comment.c_txt_ts = "";
        //            }









        //        }
        //        catch (Exception the_error1)
        //        {
        //            string sadf = the_error1.Message.ToString();
        //            string guid_script_coded_a1 = Guid.NewGuid().ToString();
        //            StringBuilder jerscripta1 = new StringBuilder();
        //            jerscripta1.Append("$(document).ready(function(){");
        //            jerscripta1.Append("alert('" + the_error1 + "');");
        //            jerscripta1.Append("});");
        //            ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
        //            jerscripta1.ToString(), true);
        //            ///end
        //            return;

        //        }

        //        #endregion




        //        try
        //        {
        //            if (name.Text.ToString().Replace(" ", "") == "")
        //            {
        //              //  label_info1.Text = "Please enter a value.";
        //                string sadf = "Please enter a value.";
        //                string guid_script_coded_a1 = Guid.NewGuid().ToString();
        //                StringBuilder jerscripta1 = new StringBuilder();
        //                jerscripta1.Append("$(document).ready(function(){");
        //                jerscripta1.Append("alert('" + sadf + "');");
        //                jerscripta1.Append("});");
        //                ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
        //                jerscripta1.ToString(), true);
        //                return;
        //            }
        //        }
        //        catch (Exception dddd)
        //        {
        //            string sadf = dddd.ToString();
        //        }

        //        #region Do Update_Instead 
        //        try
        //        {
        //          //  label_info_Edit.Text = "";

                    

        //                string run_update = "";


        //                run_update = Update_User_Information(cs, New_Comment.app_user_relation, New_Comment.c_lbl_Name, New_Comment.c_txt_Name, New_Comment.c_txt_Comment);





        //                if (run_update != "")
        //                {
        //                    Data_Was_Updated = true;
        //                }

        //                if (Data_Was_Updated == true)
        //                {
        //                 //   label_info_Edit.Text = "Item was updated in the database.";
        //                    //string sadf = "Item was updated in the database.";
        //                    //string guid_script_coded_a1 = Guid.NewGuid().ToString();
        //                    //StringBuilder jerscripta1 = new StringBuilder();
        //                    //jerscripta1.Append("$(document).ready(function(){");
        //                    //jerscripta1.Append("alert('" + sadf + "');");
        //                    //jerscripta1.Append("});");
        //                    //ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
        //                    //jerscripta1.ToString(), true);
        //                }
        //                else
        //                {
        //                 //   label_info_Edit.Text = "Item was Not updated in the database!";
        //                    //string sadf = "Item was Not updated in the database!";
        //                    //string guid_script_coded_a1 = Guid.NewGuid().ToString();
        //                    //StringBuilder jerscripta1 = new StringBuilder();
        //                    //jerscripta1.Append("$(document).ready(function(){");
        //                    //jerscripta1.Append("alert('" + sadf + "');");
        //                    //jerscripta1.Append("});");
        //                    //ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
        //                    //jerscripta1.ToString(), true);
        //                }



        //                //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
        //                GridView2.EditIndex = -1;


        //                update_listboxes();

        //                /// Searching data again to clear form
        //                Search_Data_2();

        //                /// Set focus on bottom so we can see
        //             //   linkcancelfocus.Focus();

                    
        //        }
        //        catch (Exception the_error1)
        //        {
        //          //  label_info_Edit.Text = "An error occurred.";
        //            string sadf = the_error1.ToString(); ;
        //            //string guid_script_coded_a1 = Guid.NewGuid().ToString();
        //            //StringBuilder jerscripta1 = new StringBuilder();
        //            //jerscripta1.Append("$(document).ready(function(){");
        //            //jerscripta1.Append("alert('" + sadf + "');");
        //            //jerscripta1.Append("});");
        //            //ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
        //            //jerscripta1.ToString(), true);
        //            /////end
        //            //return;


        //        }

        //        #endregion




        //    }
        //    catch (Exception dddd)
        //    {
        //       // label_info1.Text = "Error while updating.";
        //        string sadf = dddd.ToString();
        //        //string guid_script_coded_a1 = Guid.NewGuid().ToString();
        //        //StringBuilder jerscripta1 = new StringBuilder();
        //        //jerscripta1.Append("$(document).ready(function(){");
        //        //jerscripta1.Append("alert('" + sadf + "');");
        //        //jerscripta1.Append("});");
        //        //ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
        //        //jerscripta1.ToString(), true);
        //        ///end
        //        return;

        //    }

        //}






        private  string Update_User_Information(string conn_string, Nullable<int> app_u_ral, string ad_group_sid, string ad_group_name, string permissions)
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



        //private void update_listboxes()
        //{
        //    try
        //    {




                


        //            MySql.Data.MySqlClient.MySqlConnection connection7 = new MySql.Data.MySqlClient.MySqlConnection(cs);
        //            Read_Data_Previously_Inserted_application_User_relation(connection7);
                    

        //    }
        //    catch (Exception the_error1)
        //    {
        //        string sadf = the_error1.Message.ToString();
        //        string guid_script_coded_a1 = Guid.NewGuid().ToString();
        //        StringBuilder jerscripta1 = new StringBuilder();
        //        jerscripta1.Append("$(document).ready(function(){");
        //        jerscripta1.Append("alert('" + sadf + "');");
        //        jerscripta1.Append("});");
        //        ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
        //        jerscripta1.ToString(), true);
        //        ///end


        //    }
        //}





        //private void Read_Data_Previously_Inserted_application_User_relation(MySql.Data.MySqlClient.MySqlConnection connection)
        //{
        //   Load_view();




        //}

        protected void GridView2_DataBound(object sender, EventArgs e)
        {
         
        }


        //private void Load_view()
        //{
        //    try
        //    {
        //        // label_info1.Text = "";
        //        string selectQueryString = "Select  Id   , Name   , Email  , Comment  , ts  from tbl_Comments4 Order by ts desc limit 1000";
        //      //  string selectQueryString = "SELECT  Id   , Name   , Email  , Comment  , ts FROM tbl_Comments4    WHERE        ( Id = '" + Session["Edit_App_ID"].ToString() + "' )";

        //     //   string selectQueryString = "SELECT  Id   , Name   , Email  , Comment  , ts FROM tbl_Comments4    WHERE        ( Id = '" + Session["Edit_App_ID"].ToString() + "' )";
        //        MySql.Data.MySqlClient.MySqlConnection connection2 = new MySql.Data.MySqlClient.MySqlConnection(cs);

        //        MySql.Data.MySqlClient.MySqlDataAdapter sqlDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(selectQueryString, connection2);
        //        MySql.Data.MySqlClient.MySqlCommandBuilder sqlCommandBuilder = new MySql.Data.MySqlClient.MySqlCommandBuilder(sqlDataAdapter);
        //            sqlDataAdapter.SelectCommand.CommandTimeout = 0;
        //            System.Data.DataTable dataTable = new System.Data.DataTable();
        //            sqlDataAdapter.Fill(dataTable);
        //            BindingSource bindingSource = new BindingSource();
        //            bindingSource.DataSource = dataTable;
        //            GridView2.DataSourceID = null;

        //            GridView2.DataSource = bindingSource;
        //            GridView2.DataBind();

        //            int c = 0;

        //            try
        //            {

        //                c = dataTable.Rows.Count;
        //                if (c == 0)
        //                {

        //                }
        //                else
        //                {

        //                }

        //            }
        //            catch (Exception dddd)
        //            {
        //                string the_e = dddd.Message.ToString();

        //            }


        //            try
        //            {
        //                connection2.Close();
        //            }
        //            catch (Exception dddd)
        //            {
        //                string sadf = dddd.ToString();
        //            }

        //            try
        //            {
        //                sqlDataAdapter.Dispose();
        //            }
        //            catch (Exception dddd)
        //            {
        //                string sadf = dddd.ToString();
        //            }

        //            try
        //            {
        //                dataTable.Dispose();
        //            }
        //            catch (Exception dddd)
        //            {
        //                string sadf = dddd.ToString();
        //            }

        //            try
        //            {
        //                connection2.Dispose();
        //            }
        //            catch (Exception dddd)
        //            {
        //                string sadf = dddd.ToString();
        //            }
        //            //  linkcancelfocus.Focus();
               

        //    }
        //    catch (Exception dddd)
        //    {
        //        string sadf = dddd.ToString(); ;
        //        string guid_script_coded_a1 = Guid.NewGuid().ToString();
        //        StringBuilder jerscripta1 = new StringBuilder();
        //        jerscripta1.Append("$(document).ready(function(){");
        //        jerscripta1.Append("alert('" + sadf + "');");
        //        jerscripta1.Append("});");
        //        ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
        //        jerscripta1.ToString(), true);
        //        ///end
        //        return;

        //    }

        //}






        //private void Search_Data_2()
        //{
        //    try
        //    {

               
        //            //Anything in here will run as user

        //         //   string selectQueryString = "SELECT  [dbo].[ad_groups_relation].[ad_group_relation_id]  ,[dbo].[ad_groups_relation].[application_id]  ,[dbo].[ad_groups_relation].[ad_group_sid]  ,[dbo].[ad_groups_relation].[ad_group_name]  ,[dbo].[ad_groups_relation].[permissions] FROM [dbo].[ad_groups_relation]    WHERE (       (       ([dbo].[ad_groups_relation].[ad_group_sid]  like '%" + Txtsearch.Text + "%') or ([dbo].[ad_groups_relation].[ad_group_name]  like '%" + Txtsearch.Text + "%')    )            and ([dbo].[ad_groups_relation].[application_id] = '" + Session["Edit_App_ID"].ToString() + "') )";
        //        string selectQueryString = "Select * from tbl_Comments4 Order by ts desc limit 1000";

        //        MySql.Data.MySqlClient.MySqlConnection connection2 = new MySql.Data.MySqlClient.MySqlConnection(cs);

        //        MySql.Data.MySqlClient.MySqlDataAdapter sqlDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(selectQueryString, connection2);
        //        MySql.Data.MySqlClient.MySqlCommandBuilder sqlCommandBuilder = new MySql.Data.MySqlClient.MySqlCommandBuilder(sqlDataAdapter);
        //            sqlDataAdapter.SelectCommand.CommandTimeout = 0;
        //            System.Data.DataTable dataTable = new System.Data.DataTable();
        //            sqlDataAdapter.Fill(dataTable);
        //            BindingSource bindingSource = new BindingSource();
        //            bindingSource.DataSource = dataTable;
        //            GridView2.DataSourceID = null;

        //            GridView2.DataSource = bindingSource;
        //            GridView2.DataBind();

        //            try
        //            {
        //                connection2.Close();
        //            }
        //            catch (Exception dddd)
        //            {
        //                string sadf = dddd.ToString();
        //            }

        //            try
        //            {
        //                sqlDataAdapter.Dispose();
        //            }
        //            catch (Exception dddd)
        //            {
        //                string sadf = dddd.ToString();
        //            }

        //            try
        //            {
        //                dataTable.Dispose();
        //            }
        //            catch (Exception dddd)
        //            {
        //                string sadf = dddd.ToString();
        //            }

        //            try
        //            {
        //                connection2.Dispose();
        //            }
        //            catch (Exception dddd)
        //            {
        //                string sadf = dddd.ToString();
        //            }
        //          //  linkcancelfocus.Focus();
               


        //    }
        //    catch (Exception dddd)
        //    {
        //        string sadf = dddd.ToString(); ;
        //        string guid_script_coded_a1 = Guid.NewGuid().ToString();
        //        StringBuilder jerscripta1 = new StringBuilder();
        //        jerscripta1.Append("$(document).ready(function(){");
        //        jerscripta1.Append("alert('" + sadf + "');");
        //        jerscripta1.Append("});");
        //        ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
        //        jerscripta1.ToString(), true);
        //        ///end
        //        return;

        //    }

        //}


        //protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        //{



        //  //  label_info1.Text = "";
        //   // label_info_Edit.Text = "";

        //    #region Check_Delete Permissions 
        //    try
        //    {

        //      //  label_info1.Text = "You do not have permissions to delete.";
        //        if (Session["View_Edit_Permissions"].ToString() == "cognitio_view_ls")
        //        {
        //          //  label_info1.Text = "You do not have permissions to delete.";
        //            string sadf = "You do not have permissions to delete.";
        //            string guid_script_coded_a1 = Guid.NewGuid().ToString();
        //            StringBuilder jerscripta1 = new StringBuilder();
        //            jerscripta1.Append("$(document).ready(function(){");
        //            jerscripta1.Append("alert('" + sadf + "');");
        //            jerscripta1.Append("});");
        //            ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
        //            jerscripta1.ToString(), true);
        //            ///end

        //            return;
        //        }
        //        else
        //        {


        //        }
        //    }
        //    catch (Exception err)
        //    {
        //        ///catch if null
        //        string erre = err.ToString();
        //      //  label_info1.Text = "You do not have permissions to delete.";

        //        string sadf = "You do not have permissions to delete.";
        //        string guid_script_coded_a1 = Guid.NewGuid().ToString();
        //        StringBuilder jerscripta1 = new StringBuilder();
        //        jerscripta1.Append("$(document).ready(function(){");
        //        jerscripta1.Append("alert('" + sadf + "');");
        //        jerscripta1.Append("});");
        //        ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
        //        jerscripta1.ToString(), true);
        //        return;
        //    }



        //    #endregion

        //    try
        //    {

                



        //            #region Get_ID From_Grid_View 

        //            System.Web.UI.WebControls.Label id = GridView2.Rows[e.RowIndex].FindControl("lbl_app_group_relation_id") as System.Web.UI.WebControls.Label;
        //            System.Web.UI.WebControls.TextBox name = GridView2.Rows[e.RowIndex].FindControl("txt_app_group_relation_id") as System.Web.UI.WebControls.TextBox;

        //            string string_namme = name.Text;
        //            int id_to_delete_by = -99;

        //            id_to_delete_by = Convert.ToInt32(string_namme);

        //            #endregion


        //            #region Delete Item_From_Database 

        //            if (id_to_delete_by != 99)
        //            {

        //            MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection(cs);
        //                con.Open();
        //            //updating the record  
        //           MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand("DELETE FROM [dbo].[ad_groups_relation]  WHERE   [dbo].[ad_groups_relation].[ad_group_relation_id] =" + id_to_delete_by, con);
        //                cmd.ExecuteNonQuery();
        //               // label_info1.Text = "Item deleted.";
        //                string sadf333 = "Item deleted.";
        //                string guid_script_coded_a1 = Guid.NewGuid().ToString();
        //                StringBuilder jerscripta1 = new StringBuilder();
        //                jerscripta1.Append("$(document).ready(function(){");
        //                jerscripta1.Append("alert('" + sadf333 + "');");
        //                jerscripta1.Append("});");
        //                ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
        //                jerscripta1.ToString(), true);

        //                try
        //                {
        //                    con.Close();
        //                }
        //                catch (Exception dddd)
        //                {
        //                    string sadf = dddd.ToString();
        //                }

        //                try
        //                {
        //                    cmd.Dispose();
        //                }
        //                catch (Exception dddd)
        //                {
        //                    string sadf = dddd.ToString();
        //                }

        //                try
        //                {
        //                    con.Dispose();
        //                }
        //                catch (Exception dddd)
        //                {
        //                    string sadf = dddd.ToString();
        //                }

        //            }
        //            else
        //            {

        //                string sadf = "Unable to read ID.";
        //              //  label_info1.Text = "Unable to read ID.";
        //                string guid_script_coded_a1 = Guid.NewGuid().ToString();
        //                StringBuilder jerscripta1 = new StringBuilder();
        //                jerscripta1.Append("$(document).ready(function(){");
        //                jerscripta1.Append("alert('" + sadf + "');");
        //                jerscripta1.Append("});");
        //                ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
        //                jerscripta1.ToString(), true);
        //                ///end
        //                return;
        //            }
        //            #endregion





        //            //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
        //            GridView2.EditIndex = -2;


        //            update_listboxes();

        //            /// Searching data again to clear form
        //            Search_Data_2();

        //            /// Set focus on bottom so we can see
        //           // linkcancelfocus.Focus();
              


        //    }
        //    catch (Exception dddd)
        //    {
        //       // label_info1.Text = "An error occurred.";
        //        string sadf = dddd.ToString();
        //        string guid_script_coded_a1 = Guid.NewGuid().ToString();
        //        StringBuilder jerscripta1 = new StringBuilder();
        //        jerscripta1.Append("$(document).ready(function(){");
        //        jerscripta1.Append("alert('" + sadf + "');");
        //        jerscripta1.Append("});");
        //        ScriptManager.RegisterStartupScript(updPnl, updPnl.GetType(), guid_script_coded_a1,
        //        jerscripta1.ToString(), true);
        //        ///end
        //        return;

        //    }

        //}

        //protected void PageIndexChanging(object sender, GridViewPageEventArgs e)

        //{

        //    GridView2.PageIndex = e.NewPageIndex;

        //    Load_view();

        //}

        protected void rowbound(object sender, EventArgs e)
        {

        }

        protected void Gridview2DataRowBound(object sender, EventArgs e)
        {
             
        }

        protected void runcode(object sender, EventArgs e)
        {
           
        }

        protected void Insert(object sender, EventArgs e)
        {

        }
       
        protected void Runapp(object sender, EventArgs e)
        {
            string decrypted_usernameq = "";
            string decrypted_passwordq = "";
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
                    Response.Redirect("/PCI_Data");

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

        protected void Runapp1(object sender, EventArgs e)
        {
            //string decrypted_usernameq = "";
            //string decrypted_passwordq = "";
            try
            {
                if ((Session["Logged_in"] == null) || (Session["Username_to_use"] == null) || (Session["Password_to_use"] == null))
                {
                    Response.Redirect("/Account/App_Logout");
                }
                else
                {
                    Response.Redirect("/Record_MP4");
                }
            }
            catch (Exception ex)
            {

            }












            //try
            //{



            //    cn.connection_to_use = cs;


            //    string md = "";


            //    MySql.Data.MySqlClient.MySqlConnection connection6 = new MySql.Data.MySqlClient.MySqlConnection(cn.connection_to_use);

            //    decrypted_usernameq = Decrypt(Session["Username_to_use"].ToString());

            //    decrypted_passwordq = Decryptpassword(Session["Password_to_use"].ToString());


            //    md = Does_User_Have_Access_To_Project_1(connection6, decrypted_usernameq, decrypted_passwordq);

            //    if (md == "user has access")
            //    {
            //        Response.Redirect("/Record_MP4");

            //    }
            //    else
            //    {
            //        Response.Redirect("/AccessDenied");
            //    }
            //}
            //catch (Exception ex)
            //{

            //}
        }

        protected void Button3_Click(object sender, EventArgs e)
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

        protected void Runapp3(object sender, EventArgs e)
        {
            try
            {


                Response.Redirect("/MyVideos");
            }
            catch (Exception ex)
            {

            }
        }

        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            this.BindGrid();
        }

        protected void OnPaging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            this.BindGrid();
        }


        private string Read_Name_In_Database(MySql.Data.MySqlClient.MySqlConnection The_connection, string The_Username )
        {

            string modifiedstring = "";
            string first_name = "";
            string middle_name = "";
            string last_name = "";

            try
            {

                using (The_connection)
                {

                    Guid id = Guid.NewGuid();
                    //"create table getsoftware_users3( id INT NOT NULL AUTO_INCREMENT PRIMARY KEY , email VARCHAR(255) NOT NULL , password VARCHAR(255) NOT NULL , password_temp VARCHAR(255)  NULL , password_send INT  NULL , first_name VARCHAR(255) NOT NULL , middle_name VARCHAR(255) NOT NULL , last_name VARCHAR(255) NOT NULL , phone_number VARCHAR(255), Security_Question MEDIUMTEXT NOT NULL , Security_Answer MEDIUMTEXT NOT NULL , last_Login_date TIMESTAMP NOT NULL, the_date TIMESTAMP NOT NULL )"

                    //  string selectQueryString = "SELECT  email , password , password_temp , password_send  FROM   getsoftware_users3 where    email =  '" + The_Username + "' and  Password =  '" + The_Password + "' Limit 1;";
                    // string selectQueryString = "SELECT  email , password , password_temp , password_send  FROM   getsoftware_users3 where    email =  '" + The_Username + "'  Limit 1;";
                    string selectQueryString = "SELECT  first_name , middle_name , last_name  FROM   getsoftware_users3 where    (email =  '" + The_Username + "' )";
                    //"SELECT pi.The_Image , tc.Email , tc.Comment , tc.Comment_Date FROM profile_images as pi left outer JOIN tbl_Comment5 tc ON pi.email = tc.Email ORDER by pi.the_date desc , tc.Comment_Date DESC;"
                    //  string selectQueryString = "SELECT tc.Name  pi.The_Image , tc.Email , tc.Comment , tc.Comment_Date FROM profile_images as pi left outer JOIN tbl_Comment5 tc ON pi.email = tc.Email where    (email =  '" + The_Username + "' ) " + "ORDER by pi.the_date desc , tc.Comment_Date DESC;";
                   // Guid id = Guid.NewGuid();
                    
                  //  string selectQueryString = "CREATE TEMPORARY TABLE imagetable_" + id.ToString() + "' SELECT The_Image FROM profile_images WHERE Block = 0 order by the_date limit 1 ; CREATE TEMPORARY TABLE Alldata_" + id.ToString() + " SELECT Name , Email , Comment , Comment_Date FROM 'tbl_Comment5' WHERE    email =  '" + The_Username + "'   order by Comment_Date desc ; select it.*, ad.* from imagetable it cross join Alldata ad ;  DROP  TEMPORARY TABLE imagetable_" + id.ToString() + " ; DROP  TEMPORARY TABLE Alldata_" + id.ToString() + "; ";


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
                             first_name = reader.GetString(0);
                             middle_name = reader.GetString(1);
                             last_name = reader.GetString(2);
                       txtName.Text = first_name + " " + middle_name + " " + last_name;

                            modifiedstring = "gotit";

                            break;
                        }

                    }
                    else
                    {
                        txtName.Text = first_name + " " + middle_name + " " + last_name;
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

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DataRowView dr = (DataRowView)e.Row.DataItem;
                string imageUrl = "data:image/jpg;base64," + Convert.ToBase64String((byte[])dr["The_Image"]);
                (e.Row.FindControl("Image1") as Image).ImageUrl = imageUrl;
            }

          
        }
    }
}


//    <asp:AsyncPostBackTrigger ControlID="btnLinkButtonrunit" EventName="Click"/> 