using DesignWeb_Project.Areas.Admin.Models.BusinessModel;
using DesignWeb_Project.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace DesignWeb_Project.Controllers
{
    public class productsController : Controller
    {
        // GET: products
        private ConnectionDBContext db = new ConnectionDBContext();

        public ActionResult getProducts(string Alias_Product, int ProductID, int CategoryID)
        {
            var model = from p in db.Products
                        where p.Alias == Alias_Product && p.Status == true
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
                            MetaTitle = p.MetaTitle,
                            Content2 = p.Content2,
                            Content3 = p.Content3
                        };

            var product_related = from p in db.Products
                                  join c in db.Categories
                                  on p.CategoryID equals c.CategoryID
                                  where p.CategoryID == CategoryID
                                  orderby Guid.NewGuid()
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
                                      MetaTitle = p.MetaTitle
                                  };

            ViewBag.product_related = product_related.ToList();

            var getbread = from p in db.Categories
                           where p.CategoryID == CategoryID
                           select new ProductModel
                           {
                               CategoryID = p.CategoryID,
                               Category_Name = p.CategoryName,
                               Alias_Category = p.Alias
                           };

            ViewBag.getbread = getbread.ToList();

            var all_danhmuc = db.Blogs.Where(x => x.Status == true).Take(15).ToList();
            ViewBag.all_danhmuc = all_danhmuc;

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

            var product_blog = (from a in db.Products
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
            ViewBag.product_blog = product_blog;

            var config_meta = db.Configures.Take(1).ToList();
            ViewBag.config_meta = config_meta;

            return View(model.ToList());
        }
    }
}