using DesignWeb_Project.Areas.Admin.Models.BusinessModel;
using DesignWeb_Project.Models;
using PagedList;
using System.Linq;
using System.Web.Mvc;

namespace DesignWeb_Project.Controllers
{
    public class blogsController : Controller
    {
        private ConnectionDBContext db = new ConnectionDBContext();

        public ActionResult GetBlogs(int BlogID, string Alias, int? page)
        {
            var model = from bl in db.Blogs
                        join ar in db.Articles
                        on bl.BlogID equals ar.BlogID
                        where bl.BlogID == BlogID && bl.Status == true && ar.Status == true
                        orderby ar.CreatedAt descending
                        select new BlogModel
                        {
                            BlogName = bl.BlogName,
                            Alias_Blog = bl.Alias,
                            ArticleName = ar.ArticleName,
                            Alias_Article = ar.Alias,
                            Content = ar.Content,
                            DescriptShort = ar.DescriptShort,
                            CreatedAt = ar.CreatedAt,
                            BlogID = bl.BlogID,
                            ArticleID = ar.ArticleID,
                            Author = ar.Author,
                            Images = ar.Images,
                            MetaDescription = bl.MetaDescription,
                            MetaKeyword = bl.MetaKeyword,
                            MetaTitle = bl.MetaTitle
                        };
            int pagesize = 4;
            int pageNumber = (page ?? 1);

            ViewBag.count_article = model.Count();

            var getNameBlog = from a in db.Blogs
                              where a.BlogID == BlogID
                              select new BlogModel { BlogName = a.BlogName, MetaDescription = a.MetaDescription, MetaTitle = a.MetaTitle, MetaKeyword = a.MetaKeyword };
            ViewBag.getNameBlog = getNameBlog.ToList();

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

            var config_meta = db.Configures.Take(1).ToList();
            ViewBag.config_meta = config_meta;

            return View(model.ToPagedList(pageNumber, pagesize));
        }
    }
}