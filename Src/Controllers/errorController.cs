using System.Web.Mvc;

namespace DesignWeb_Project.Controllers
{
    public class errorController : Controller
    {
        // GET: error
        [HandleError]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult updating()
        {
            return View();
        }
    }
}