using System.Web.Mvc;
using System.Web.Routing;

namespace DesignWeb_Project
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.LowercaseUrls = true;
            routes.AppendTrailingSlash = true;
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Blog ID",
                url: "blogs/{Alias}-{BlogID}.html",
                defaults: new { controller = "blogs", action = "GetBlogs", id = UrlParameter.Optional },
                namespaces: new string[] { "DesignWeb_Project.Controllers" }
            );

            routes.MapRoute(
                name: "Article",
                url: "blogs/{Alias_Blog}/{Alias_Article}-{BlogID}-{ArticleID}.html",
                defaults: new { controller = "article", action = "getArticle", id = UrlParameter.Optional },
                namespaces: new string[] { "DesignWeb_Project.Controllers" }
            );

            routes.MapRoute(
                name: "Category",
                url: "categories/{Alias}-{CategoryID}.html",
                defaults: new { controller = "category", action = "getCategory", id = UrlParameter.Optional },
                namespaces: new string[] { "DesignWeb_Project.Controllers" }
            );

            routes.MapRoute(
                name: "Product",
                url: "products/{Alias_Product}-{CategoryID}-{ProductID}.html",
                defaults: new { controller = "products", action = "getProducts", id = UrlParameter.Optional },
                namespaces: new string[] { "DesignWeb_Project.Controllers" }
            );

            routes.MapRoute(
                name: "Liên Hệ",
                url: "pages/lien-he.html",
                defaults: new { controller = "home", action = "getDataContact", id = UrlParameter.Optional },
                namespaces: new string[] { "DesignWeb_Project.Controllers" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "home", action = "Index", id = UrlParameter.Optional },

                namespaces: new string[] { "DesignWeb_Project.Controllers" }
            );
        }
    }
}