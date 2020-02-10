using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace events_appli
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Code that runs on application startup
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Application["totalapplications"] = 0;
            Application["totalusers"] = 0;
            Application["totalapplications"] = (int)Application["totalapplications"] + 1;
        }
        void Session_Start(object sender, EventArgs e)
        {
            Application["totalusers"] = (int)Application["totalusers"] + 1;
        }
        void Session_End(object sender, EventArgs e)
        {
            Application["totalusers"] = (int)Application["totalusers"] -1;
        }
    }
}