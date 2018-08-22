using DesignWeb_Project.Areas.Admin.Models.BusinessModel;
using DesignWeb_Project.Models;
using System.Linq;
using System.Web.Mvc;

namespace DesignWeb_Project.Controllers
{
    public class articleController : Controller
    {
        // GET: article
        private ConnectionDBContext db = new ConnectionDBContext();

        public ActionResult getArticle(int ArticleID, string Alias_Article, int BlogID, string Alias_Blog)
        {
            var model = from ar in db.Articles
                        where ar.ArticleID == ArticleID
                        select new BlogModel
                        {
                            Alias_Blog = ar.Alias,
                            Alias_Article = ar.Alias,
                            Content = ar.Content,
                            DescriptShort = ar.DescriptShort,
                            CreatedAt = ar.CreatedAt,
                            ArticleID = ar.ArticleID,
                            Author = ar.Author,
                            Images = ar.Images,
                            ArticleName = ar.ArticleName,
                            MetaDescription_ar = ar.MetaDescription,
                            MetaKeyword_ar = ar.MetaKeyword,
                            MetaTitle_ar = ar.MetaTitle
                        };

            var getNameBlog = from b in db.Blogs
                              where b.BlogID == BlogID
                              select new BlogModel
                              {
                                  BlogName = b.BlogName,
                                  BlogID = b.BlogID,
                                  Alias_Blog = b.Alias
                              };
            ViewBag.getNameBlog = getNameBlog;

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

            var all_danhmuc = db.Blogs.Where(x => x.Status == true).Take(15).ToList();
            ViewBag.all_danhmuc = all_danhmuc;

            var article_related = (from bl in db.Blogs
                                   join ar in db.Articles
                                   on bl.BlogID equals BlogID
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
                                   }).Take(6);
            ViewBag.article_related = article_related;

            var config_meta = db.Configures.Take(1).ToList();
            ViewBag.config_meta = config_meta;

            return View(model.ToList());
        }
    }
}