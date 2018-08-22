using System.Web.Mvc;

namespace DesignWeb_Project.Areas.BillNet.Controllers
{
    //[Authorize(Users = "manhnv83@gmail.com")]
    //public class HomeController : Controller
    public class HomeController : AuthorizeBaseController
    {
        // GET: BillNet/Home
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Test()
        {
            return View();
        }
    }
}