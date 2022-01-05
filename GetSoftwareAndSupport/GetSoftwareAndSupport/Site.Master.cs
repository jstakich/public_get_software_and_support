using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
 
using System.Security.Claims;
using System.Security.Principal;
 
using System.Web.Security;
 
using Microsoft.AspNet.Identity;
using System.Web.Configuration;

namespace GetSoftwareAndSupport
{
 
    public partial class SiteMaster : MasterPage
    {

       // HttpContext context = HttpContext.Current;
        protected void Page_Init(object sender, EventArgs e)
        {
            
        }
        //protected void master_Page_PreLoad(object sender, EventArgs e)
        //{
        //    if (!IsPostBack)
        //    {
        //        // Set Anti-XSRF token
        //        ViewState[AntiXsrfTokenKey] = Page.ViewStateUserKey;
        //        ViewState[AntiXsrfUserNameKey] = Context.User.Identity.Name ?? String.Empty;
        //    }
        //    else
        //    {
        //        // Validate the Anti-XSRF token
        //        if ((string)ViewState[AntiXsrfTokenKey] != _antiXsrfTokenValue
        //            || (string)ViewState[AntiXsrfUserNameKey] != (Context.User.Identity.Name ?? String.Empty))
        //        {
        //            throw new InvalidOperationException("Validation of Anti-XSRF token failed.");
        //        }
        //    }
        //}

        
         

        protected void UpdateTime(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString("hh:mm:ss tt");
            string script = "window.onload = function() { UpdateTime('" + time + "'); };";
           // ClientScript.RegisterStartupScript(this.GetType(), "UpdateTime", script, true);
            ScriptManager.RegisterStartupScript(Page, Page.GetType(), "UpdateTime", script, true);
        }


       
        protected void runcode(object sender, EventArgs e)
        {

          
            string time = DateTime.Now.ToString("hh:mm:ss tt");
       //    string script = "window.onload = function() { rccode('" + time + "'); };";
          //  string script = "window.onload = function() {checkIfLoggedIn ;};";
            // ClientScript.RegisterStartupScript(this.GetType(), "UpdateTime", script, true);
        //    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "rccode", script, true);
           // System.Threading.Thread.Sleep(5000);
            //string jj = hdntxtbxTaksit.Value.ToString();
            //string jdj = hdn.Value;
            //string jdjd = hdn.Value;
            //string jjs = lblTime.Text.ToString();
            //string jjsdss = lblTime.Text.ToString();

        }

        protected void Button9_Click(object sender, EventArgs e)
        {

        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            // Label1.Text = "jeremy Panel refreshed at " + DateTime.Now.ToString();
            //  string time = DateTime.Now.ToString("hh:mm:ss tt");
            //  string script = "window.onload = function() { rccode('" + time + "'); };";
            //  string script = "window.onload = function() {checkIfLoggedIn ;};";
            // ClientScript.RegisterStartupScript(this.GetType(), "UpdateTime", script, true);
            // ScriptManager.RegisterStartupScript(Page, Page.GetType(), "rccode", script, true);
            // OnClientClick = "return asdf();" OnClick = "Button10_Click"
            //string jjjasdfasdf = Label11.Text;
            //string jj = hdntxtbxTaksit.Value.ToString();
            //string jdj = hdn.Value;
            //string jdjd = hdn.Value;
            //string jjs = lblTime.Text.ToString();
            //string jjsdss = lblTime.Text.ToString();
        }

        protected void Clickme(object sender, EventArgs e)
        {
          //  Response.Redirect("/About.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

                protected void btnRun1_Click(object sender, EventArgs e)
        {

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