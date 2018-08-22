using DesignWeb_Project.Areas.Admin.Models.BusinessModel;
using DesignWeb_Project.Areas.Admin.Models.DataModel;
using DesignWeb_Project.Areas.Admin.Models.ViewModel;
using PagedList;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace DesignWeb_Project.Areas.Admin.Controllers
{
    [AuthorizeBusiness]
    public class RegisterUsesController : Controller
    {
        private ConnectionDBContext db = new ConnectionDBContext();

        // GET: Admin/RegisterUses1
        public ActionResult Index(int? page, string q)
        {
            var count_reg = (from con in db.RegisterUses select con.RegisterUseID).Count();

            ViewBag.count_reg = count_reg;

            var model = from p in db.RegisterUses orderby p.CreatedAt descending select p;
            int pagesize = 3;
            int pageNumber = (page ?? 1);

            if (!string.IsNullOrEmpty(q))
            {
                model = model.Where(x => x.FullName.Contains(q) || x.Email.Contains(q)).OrderByDescending(x => x.CreatedAt);
            }

            ViewBag.keyword_search = q;

            var get_product_care = from p in db.Products
                                   join u in db.RegisterUses
                                   on p.ProductID equals u.ProductID
                                   select new RegisterModel
                                   {
                                       ProductID = p.ProductID,
                                       ProductName = p.ProductName
                                   };
            ViewBag.get_product_care = get_product_care;

            return View(model.ToPagedList(pageNumber, pagesize));
        }

        // GET: Admin/RegisterUses1/Details/5
        public ActionResult Details(int? id)
        {
            var get_product_care = from p in db.Products
                                   join u in db.RegisterUses
                                   on p.ProductID equals u.ProductID
                                   select new RegisterModel
                                   {
                                       ProductID = p.ProductID,
                                       ProductName = p.ProductName
                                   };
            ViewBag.get_product_care = get_product_care;

            RegisterUse reg = db.RegisterUses.Find(id);
            reg.ViewStatus = true;
            db.Entry(reg).State = EntityState.Modified;
            db.SaveChanges();
            return View(reg);
        }

        public ActionResult Delete(int? id)
        {
            RegisterUse reg = db.RegisterUses.Find(id);

            db.RegisterUses.Remove(reg);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}