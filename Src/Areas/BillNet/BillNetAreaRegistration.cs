using System.Web.Mvc;

namespace DesignWeb_Project.Areas.BillNet
{
    public class BillNetAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "BillNet";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "BillNet_home",
                "BillNet/Home",
                new { action = "Index", Controller = "Home", id = 1 },
                new string[] { "DesignWeb_Project.Areas.BillNet.Controllers" }
            );

            context.MapRoute(
                "BillNet_default",
                "BillNet/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}