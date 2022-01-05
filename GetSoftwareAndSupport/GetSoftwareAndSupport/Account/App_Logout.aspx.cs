using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;

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
    public partial class App_Logout : System.Web.UI.Page
    {
        HttpContext context = HttpContext.Current;
        protected void Page_Load(object sender, EventArgs e)
        {

            #region kILL Session 

            //try
            //{ 
            //    context.Session["Username_to_use"] = null;
            //    Session["Username_to_use"] = null;

            //    context.Session["Password_to_use"] = null;
            //    Session["Password_to_use"] = null;

            //    context.Session["Logged_in"] = null;
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
                
                //Response.Redirect("/Account/Login");

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
                Response.Redirect("~/Account/Login");
            }
            catch (Exception jerror1FF)
            {
                ///Do nothing
                string jj = jerror1FF.ToString();


            }

            #endregion




            //try
            //{


            //    context.Session["Username_to_use"] = null;
            //    Session["Username_to_use"] = null; 

            //    context.Session["Password_to_use"] = null;
            //    Session["Password_to_use"] = null; 

            //    context.Session["Logged_in"] = null;
            //    Session["Logged_in"] = null;

            //    //  Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(2));
            //    //   Response.Cache.SetCacheability(HttpCacheability.NoCache);
            //    //Response.Cache.SetNoStore();
            //    //   Response.Cache.SetCacheability(HttpCacheability.Public);
            //    //HttpContext.Current.Response.Cache.SetExpires(DateTime.UtcNow.AddDays(-1));
            //    //HttpContext.Current.Response.Cache.SetValidUntilExpires(false);

            //    //HttpContext.Current.Response.Cache.SetRevalidation(HttpCacheRevalidation.AllCaches);
            //    //HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.NoCache);
            //    //HttpContext.Current.Response.Cache.SetNoStore();
            //    //HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
            //}
            //catch (Exception the_error1)
            //{
            //    string sadf = the_error1.Message.ToString();

            //}
            //#region DOnot Cache_Content 
            ///// Keeps menu , links and pages from showing up when user clicks the browser back button.
            ////try
            ////{
            ////    Response.Cache.SetExpires(DateTime.UtcNow.AddMinutes(-1));
            ////    Response.Cache.SetCacheability(HttpCacheability.NoCache);
            ////    Response.Cache.SetNoStore();
            ////}
            ////catch (Exception the_error1)
            ////{
            ////    string sadf = the_error1.Message.ToString();

            ////}
            //#endregion


            //#region Abandon Session 
            //try

            //{
            //    HttpContext.Current.Session.Abandon();
            //}

            //catch (Exception the_err)

            //{

            //    string the_errd = the_err.ToString();

            //}

            //try

            //{
            //    HttpContext.Current.Session.Clear();
            //}

            //catch (Exception the_err)

            //{

            //    string the_errd = the_err.ToString();

            //}

            //try

            //{
            //    HttpContext.Current.Session.RemoveAll();
            //}

            //catch (Exception the_err)

            //{

            //    string the_errd = the_err.ToString();

            //}

            //try

            //{
            //     Session.Abandon();
            //}

            //catch (Exception the_err)

            //{

            //    string the_errd = the_err.ToString();

            //}

            //try

            //{
            //     Session.Clear();
            //}

            //catch (Exception the_err)

            //{

            //    string the_errd = the_err.ToString();

            //}

            //try

            //{
            //   Session.RemoveAll();
            //}

            //catch (Exception the_err)

            //{

            //    string the_errd = the_err.ToString();

            //}




            //try

            //{
            //    //Session.Abandon();
            //    //Session.Clear();
            //    //HttpContext.Current.Session.Clear();
            //    //HttpContext.Current.Session.Abandon();
            //    //Response.Cookies["ASP.NET_SessionId"].Value = string.Empty;
            //    //Response.Cookies["ASP.NET_SessionId"].Expires = DateTime.Now.AddMonths(-10);
            //    //Session.Remove(Session.SessionID);

            //}

            //catch (Exception the_err)

            //{

            //    string the_errd = the_err.ToString();

            //}

            //try
            //{
            //    //Context.GetOwinContext().Authentication.SignOut(Microsoft.AspNet.Identity.DefaultAuthenticationTypes.ApplicationCookie);
            //    Response.Redirect("/Account/Login");

            //}
            //catch (Exception jerror1FF)
            //{
            //    ///Do nothing
            //    string jj = jerror1FF.ToString();


            //}

            //#endregion


        }
    }
}