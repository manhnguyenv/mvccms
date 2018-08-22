using DesignWeb_Project.Areas.Admin.Models.BusinessModel;
using System.Linq;
using System.Web.Mvc;

namespace DesignWeb_Project.Areas.Admin.Controllers
{
    public class AccountController : Controller
    {
        // GET: Admin/Account/Login
        private ConnectionDBContext db = new ConnectionDBContext();

        public ActionResult Login()
        {
            return View();
        }

        // POST: Admin/Account/Login
        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            Md5Encode md5 = new Md5Encode();
            var passmd5 = md5.EncodeMd5Encrypt(password);
            var login = db.User.SingleOrDefault(x => x.Email == email && x.Password == passmd5 && x.Status == true);

            if (login != null)
            {
                Session["UserID"] = login.UserID;
                Session["Username"] = login.Username;
                Session["Email"] = login.Email;
                Session["Password"] = login.Password;
                Session["Image"] = login.Image;
                return Redirect("~/admin/home");
            }
            else
            {
                ViewBag.error = "Tên Tài Khoản Hoặc Mật Khẩu Không Đúng";
            }
            return View();
        }
    }
}