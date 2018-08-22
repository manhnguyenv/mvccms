using System.Web.Mvc;

namespace DesignWeb_Project.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.Routes.LowercaseUrls = true;

            context.MapRoute(
                "config",
                "Admin/Configures",
                new { action = "Edit", Controller = "Configures", id = 1 },
                new string[] { "DesignWeb_Project.Areas.Admin.Controllers" }
            );

            context.MapRoute(
                "home",
                "Admin/cau-hinh-trang-chu",
                new { action = "Edit", Controller = "Homes", id = 1 },
                new string[] { "DesignWeb_Project.Areas.Admin.Controllers" }
            );

            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { action = "Index", Controller = "Home", id = UrlParameter.Optional },
                new string[] { "DesignWeb_Project.Areas.Admin.Controllers" }
            );
        }
    }
}