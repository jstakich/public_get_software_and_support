using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GetSoftwareAndSupport
{
    public partial class Site_Mobile : System.Web.UI.MasterPage
    {
      //  HttpContext context = HttpContext.Current;
        protected void Page_Init(object sender, EventArgs e)
        {
           
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            //try
            //{
            //    //  LinkButton_editaccountbutton.Visible = false;
            //    //  LinkButton_logoutbutton.Visible = false;
            //    LinkButton_loginbutton.Visible = true;

            //    if (Session["Logged_in"] != null)
            //    {
            //        string str_read_login_var = Convert.ToString(Session["Logged_in"]);

            //        //////////////////////////////// If User is logged in 
            //        if (str_read_login_var == "True")
            //        {

            //            //    LinkButton_editaccountbutton.Visible = true;
            //            // LinkButton_logoutbutton.Visible = true;
            //            LinkButton_loginbutton.Visible = false;


            //        }
            //    }


            //}
            //catch (Exception ex)
            //{
            //    string aa = ex.ToString();

            //}
            //try
            //{
            //    if (Session["Logged_in"] != null)
            //    {
            //        string str_read_login_var = Convert.ToString(Session["Logged_in"]);

            //        //////////////////////////////// If User is logged in 
            //        if (str_read_login_var == "True")
            //        {

            //            btn_login.Visible = false;
            //            LinkButton_EditAccount.Visible = true;
            //        }
            //    }
            //    else
            //    {
            //        //////////////////////////////// If User is NOT logged in 
            //        btn_login.Visible = true;
            //        LinkButton_EditAccount.Visible = false;
            //    }

            //}
            //catch (Exception ex)
            //{
            //    //////////////////////////////// If User is NOT logged in 
            //    btn_login.Visible = false;
            //    LinkButton_EditAccount.Visible = false;
            //}
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

        //protected void Logout_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        context.Session["Username_to_use"] = null;
        //        Session["Username_to_use"] = null;

        //        context.Session["Password_to_use"] = null;
        //        Session["Password_to_use"] = null;

        //        context.Session["Logged_in"] = "True";
        //        Session["Logged_in"] = null;
        //        Response.Redirect("~/Account/App_Logout");
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //}

        protected void Logout_Click(object sender, EventArgs e)
        {
            #region kILL Session 

            //try
            //{
            //  //  context.Session["Username_to_use"] = null;
            //    Session["Username_to_use"] = null;

            //  //  context.Session["Password_to_use"] = null;
            //    Session["Password_to_use"] = null;

            //   // context.Session["Logged_in"] = null;
            //    Session["Logged_in"] = null;


            //}
            //catch (Exception the_error1)
            //{
            //    string sadf = the_error1.Message.ToString();

            //}

           

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
    }
}