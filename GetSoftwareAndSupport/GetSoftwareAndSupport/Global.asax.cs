using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using Microsoft.Owin.Security.Google;
namespace GetSoftwareAndSupport
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

           // GetSoftwareAndSupport.App_Start.Startup1 aa = new GetSoftwareAndSupport.App_Start.Startup1();
            
        }
    }
}