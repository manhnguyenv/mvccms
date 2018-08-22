using DesignWeb_Project.Areas.Admin.Models.BusinessModel;
using DesignWeb_Project.Helpers;
using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace DesignWeb_Project
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            log4net.Config.XmlConfigurator.Configure();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        protected void Session_Start()
        {
            Session["UserID"] = null;
            Session["Username"] = null;
            Session["Email"] = null;
            Session["Password"] = null;
            Session["Image"] = null;
            Session["CartItem"] = null;

            Session["countnewcart"] = null;
        }

        protected void Application_Error()
        {
            var ex = Server.GetLastError();
            MyLogger.Log.Error(ex.ToString());
        }
    }
}