using DesignWeb_Project.Areas.Admin.Models.BusinessModel;
using DesignWeb_Project.Models;
using PagedList;
using System.Linq;
using System.Web.Mvc;

namespace DesignWeb_Project.Controllers
{
    public class CategoryController : Controller
    {
        private ConnectionDBContext db = new ConnectionDBContext();

        public ActionResult getCategory(int? page, int CategoryID, string Alias)
        {
            var listmol = from p in db.Products
                          where p.CategoryID == CategoryID && p.Status == true
                          orderby p.CreatedAt descending
                          select new ProductModel
                          {
                              ProductID = p.ProductID,
                              ProductName = p.ProductName,
                              Alias_Product = p.Alias,
                              CategoryID = p.CategoryID,
                              MetaDescription = p.MetaDescription,
                              MetaKeyword = p.MetaKeyword,
                              DescriptShort = p.DescriptShort,
                              Images = p.Images,
                              Content = p.Content,
                              Content2 = p.Content2,
                              Content3 = p.Content3
                          };

            int pagesize = 20;
            int pageNumber = (page ?? 1);

            ViewBag.count_product = listmol.Count();

            var getCate = from d in db.Categories
                          where d.CategoryID == CategoryID
                          select new ProductModel
                          {
                              Category_Name = d.CategoryName,
                              MetaDescription = d.MetaDescription,
                              MetaKeyword = d.MetaKeyword,
                              MetaTitle = d.MetaTitle
                          };

            ViewBag.getCate = getCate;

            var getBlogNew = (from ar in db.Articles
                              join bl in db.Blogs
                              on ar.BlogID equals bl.BlogID
                              where ar.Status == true
                              orderby ar.CreatedAt descending
                              select new BlogModel
                              {
                                  Alias_Article = ar.Alias,
                                  Content = ar.Content,
                                  Alias_Blog = bl.Alias,
                                  BlogID = bl.BlogID,
                                  DescriptShort = ar.DescriptShort,
                                  CreatedAt = ar.CreatedAt,
                                  ArticleID = ar.ArticleID,
                                  Author = ar.Author,
                                  Images = ar.Images,
                                  ArticleName = ar.ArticleName
                              }).Take(5);
            ViewBag.getBlogNew = getBlogNew.ToList();

            var all_danhmuc = db.Blogs.Where(x => x.Status == true).Take(15).ToList();
            ViewBag.all_danhmuc = all_danhmuc;

            var config_meta = db.Configures.Take(1).ToList();
            ViewBag.config_meta = config_meta;

            return View(listmol.ToPagedList(pageNumber, pagesize));
        }
    }
}