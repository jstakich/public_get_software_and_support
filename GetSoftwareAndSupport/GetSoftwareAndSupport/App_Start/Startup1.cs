using Microsoft.Owin;
using Owin;
using System;
using System.Threading.Tasks;
using Microsoft.Owin.Security.Google;
using Microsoft.Owin.Security.Cookies;

[assembly: OwinStartup(typeof(GetSoftwareAndSupport.App_Start.Startup1))]

namespace GetSoftwareAndSupport.App_Start
{
    public class Startup1
    {
        public void Configuration(IAppBuilder app)
        {
          
          
        }

        internal void Configuration(object jaa)
        {
            throw new NotImplementedException();
        }
    }
}
