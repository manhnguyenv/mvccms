﻿using DesignWeb_Project.Areas.Admin.Models.BusinessModel;
using System.Linq;
using System.Web.Mvc;

namespace DesignWeb_Project.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        private ConnectionDBContext db = new ConnectionDBContext();

        // GET: Admin/Home
        public ActionResult Index()
        {
            var count_user = (from pro in db.User select pro.UserID).Count();

            ViewBag.count_user = count_user;

            var count_product = (from pro in db.Products select pro.ProductID).Count();

            ViewBag.count_product = count_product;

            var count_baiviet = (from bv in db.Articles select bv.ArticleID).Count();

            ViewBag.count_baiviet = count_baiviet;

            var model = db.Articles.Where(x => x.Status == true).OrderByDescending(x => x.CreatedAt).Take(10);
            ViewBag.newblog = model.ToList();

            var newproduct = db.Products.Where(x => x.Status == true).OrderByDescending(x => x.CreatedAt).Take(10);
            ViewBag.newproduct = newproduct.ToList();

            return View();
        }

        public ActionResult LogoutUser()
        {
            Session["UserID"] = null;
            Session["Username"] = null;
            Session["Password"] = null;
            Session["Image"] = null;
            return Redirect("~/admin/account/login");
        }

        public ActionResult PermissionDenied()
        {
            return View();
        }
    }
}