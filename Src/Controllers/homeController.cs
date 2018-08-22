using DesignWeb_Project.Areas.Admin.Models.BusinessModel;
using DesignWeb_Project.Areas.Admin.Models.DataModel;
using DesignWeb_Project.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace DesignWeb_Project.Controllers
{
    public class homeController : Controller
    {
        private ConnectionDBContext db = new ConnectionDBContext();

        // GET: home
        [AllowAnonymous]
        public ActionResult Index()
        {
            var all_data_config = db.Homes.Take(1).ToList();

            ViewBag.all_data_config = all_data_config;

            var bloghome = (from a in db.Articles
                            join b in db.Homes on a.BlogID equals b.blog_news_chosse
                            join l in db.Blogs on a.BlogID equals l.BlogID
                            where a.Status == true
                            orderby a.News_hot descending, a.CreatedAt descending
                            select new BlogModel
                            {
                                BlogID = a.BlogID,
                                ArticleID = a.ArticleID,
                                ArticleName = a.ArticleName,
                                Author = a.Author,
                                Status = a.Status,
                                Alias_Blog = l.Alias,
                                Content = a.Content,
                                CreatedAt = a.CreatedAt,
                                Images = a.Images,
                                Alias_Article = a.Alias,
                                DescriptShort = a.DescriptShort
                            }).Take(7);

            ViewBag.bloghome = bloghome.ToList();

            var all_product_home = (from a in db.Products
                                    join l in db.Categories on a.CategoryID equals l.CategoryID
                                    where a.Status == true
                                    orderby a.CreatedAt descending
                                    select new ProductModel
                                    {
                                        ProductID = a.ProductID,
                                        ProductName = a.ProductName,
                                        Content2 = a.Content2,
                                        Content3 = a.Content3,
                                        Content = a.Content,
                                        CategoryID = l.CategoryID,
                                        CreatedAt = a.CreatedAt,
                                        Images = a.Images,
                                        Category_Name = l.CategoryName,
                                        Alias_Product = a.Alias,
                                        Alias_Category = l.Alias,
                                        DescriptShort = a.DescriptShort,
                                        Status = a.Status
                                    });
            ViewBag.all_product_home = all_product_home;

            var product_home = (from a in db.Products
                                join b in db.Homes on a.CategoryID equals b.collection_product_home
                                join l in db.Categories on a.CategoryID equals l.CategoryID
                                where a.Status == true
                                orderby a.CreatedAt descending
                                select new ProductModel
                                {
                                    ProductID = a.ProductID,
                                    ProductName = a.ProductName,
                                    Content2 = a.Content2,
                                    Content3 = a.Content3,
                                    Content = a.Content,
                                    CategoryID = l.CategoryID,
                                    CreatedAt = a.CreatedAt,
                                    Images = a.Images,
                                    Category_Name = l.CategoryName,
                                    Alias_Product = a.Alias,
                                    Alias_Category = l.Alias,
                                    DescriptShort = a.DescriptShort,
                                    Status = a.Status
                                });
            ViewBag.product_home = product_home;

            var config_home = db.Configures.Take(1).ToList();

            ViewBag.config_home = config_home;

            return View();
        }

        public PartialViewResult Header()
        {
            var getglobal = db.Configures.Take(1).ToList();
            return PartialView(getglobal);
        }

        public PartialViewResult Footer()
        {
            var footer = db.Configures.Take(1).ToList();
            return PartialView(footer);
        }

        public PartialViewResult Slider()
        {
            var model = db.Slides.Where(x => x.Status == true && x.OptionSelect == 1).OrderBy(x => x.SortID).ToList();
            return PartialView(model);
        }

        public PartialViewResult Partner()
        {
            var model = db.Slides.Where(x => x.Status == true && x.OptionSelect == 2).OrderBy(x => x.SortID).ToList();
            return PartialView(model);
        }

        public PartialViewResult MainMenu()
        {
            var model = db.MenuNavigations.Where(x => x.MenuParents == 0 && x.Status == true).OrderBy(x => x.Sequence).ToList();
            var get_category = from m in db.MenuNavigations
                               join c in db.Categories
                               on m.GroupLink equals c.CategoryID
                               where m.Status == true
                               select new Navigation
                               {
                                   MenuID = m.MenuID,
                                   MenuName = m.MenuName,
                                   Sequence = m.Sequence,
                                   IconMenu = m.IconMenu,
                                   MenuParents = m.MenuParents,
                                   PageStyle = m.PageStyle,
                                   CategoryID = c.CategoryID,
                                   CategoryName = c.CategoryName,
                                   CreatedAt = m.CreatedAt,
                                   FormatPage = m.FormatPage,
                                   GroupLink = m.GroupLink,
                                   MetaDescription = m.MetaDescription,
                                   MetaKeyword = m.MetaKeyword,
                                   MetaTitle = m.MetaTitle,
                                   PageContent = m.PageContent,
                                   PageLink = m.PageLink,
                                   Status = m.Status,
                                   Alias_Cate = c.Alias
                               };
            ViewBag.get_category = get_category.ToList();

            var get_blog = from m in db.MenuNavigations
                           join b in db.Blogs
                           on m.GroupLink equals b.BlogID
                           where m.Status == true
                           select new Navigation
                           {
                               MenuID = m.MenuID,
                               MenuName = m.MenuName,
                               Sequence = m.Sequence,
                               IconMenu = m.IconMenu,
                               MenuParents = m.MenuParents,
                               PageStyle = m.PageStyle,
                               BlogID = b.BlogID,
                               BlogName = b.BlogName,
                               CreatedAt = m.CreatedAt,
                               FormatPage = m.FormatPage,
                               GroupLink = m.GroupLink,
                               MetaDescription = m.MetaDescription,
                               MetaKeyword = m.MetaKeyword,
                               MetaTitle = m.MetaTitle,
                               PageContent = m.PageContent,
                               PageLink = m.PageLink,
                               Status = m.Status,
                               Alias_Blog = b.Alias
                           };
            ViewBag.get_blog = get_blog.ToList();

            return PartialView(model);
        }

        public PartialViewResult LoadParent(int id)
        {
            var model = db.MenuNavigations.Where(x => x.MenuParents == id && x.Status == true).OrderBy(x => x.Sequence).ToList();
            ViewBag.count = model.Count();

            var get_category = from m in db.MenuNavigations
                               join c in db.Categories
                               on m.GroupLink equals c.CategoryID
                               where m.Status == true
                               select new Navigation
                               {
                                   MenuID = m.MenuID,
                                   MenuName = m.MenuName,
                                   Sequence = m.Sequence,
                                   IconMenu = m.IconMenu,
                                   MenuParents = m.MenuParents,
                                   PageStyle = m.PageStyle,
                                   CategoryID = c.CategoryID,
                                   CategoryName = c.CategoryName,
                                   CreatedAt = m.CreatedAt,
                                   FormatPage = m.FormatPage,
                                   GroupLink = m.GroupLink,
                                   MetaDescription = m.MetaDescription,
                                   MetaKeyword = m.MetaKeyword,
                                   MetaTitle = m.MetaTitle,
                                   PageContent = m.PageContent,
                                   PageLink = m.PageLink,
                                   Status = m.Status,
                                   Alias_Cate = c.Alias
                               };
            ViewBag.get_category = get_category.ToList();

            var get_blog = from m in db.MenuNavigations
                           join b in db.Blogs
                           on m.GroupLink equals b.BlogID
                           where m.Status == true
                           select new Navigation
                           {
                               MenuID = m.MenuID,
                               MenuName = m.MenuName,
                               Sequence = m.Sequence,
                               IconMenu = m.IconMenu,
                               MenuParents = m.MenuParents,
                               PageStyle = m.PageStyle,
                               BlogID = b.BlogID,
                               BlogName = b.BlogName,
                               CreatedAt = m.CreatedAt,
                               FormatPage = m.FormatPage,
                               GroupLink = m.GroupLink,
                               MetaDescription = m.MetaDescription,
                               MetaKeyword = m.MetaKeyword,
                               MetaTitle = m.MetaTitle,
                               PageContent = m.PageContent,
                               PageLink = m.PageLink,
                               Status = m.Status,
                               Alias_Blog = b.Alias
                           };
            ViewBag.get_blog = get_blog.ToList();

            return PartialView("LoadParent", model);
        }

        public PartialViewResult PopupRegister()
        {
            var product = db.Products.Where(x => x.Status == true).ToList();
            ViewBag.product = product;
            return PartialView();
        }

        public ActionResult RegisterUse(string fullname, string phone, int productid, string email)
        {
            RegisterUse reg = new RegisterUse();

            reg.FullName = fullname;
            reg.Phone = phone;
            reg.Email = email;
            reg.ViewStatus = false;
            reg.CreatedAt = DateTime.Now;
            reg.ProductID = productid;
            db.RegisterUses.Add(reg);
            db.SaveChanges();
            return Json(new { Result = "Success", Message = "Saved Successfully" }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult getDataContact()
        {
            var config = db.Configures.ToList();
            return View(config);
        }

        public PartialViewResult Master_Include()
        {
            var config = db.Configures.ToList();
            return PartialView(config);
        }

        public ActionResult AddContact(string fullname, string phone, string email, string content_comment)
        {
            Contact contact = new Contact();

            contact.FullName = fullname;
            contact.Phone = phone;
            contact.Email = email;
            contact.Content = content_comment;
            contact.ViewStatus = false;
            contact.CreatedAt = DateTime.Now;

            db.Contacts.Add(contact);
            db.SaveChanges();

            TempData["displaycontact"] = "display:block!important";
            TempData["thankyou"] = " Cảm ơn Bạn Đã Liên Hệ Chúng Tôi Sẽ Liên Lạc Với Bạn Sớm Nhất...";
            return RedirectToAction("getDataContact");
        }
    }
}