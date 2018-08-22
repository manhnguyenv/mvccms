using DesignWeb_Project.Areas.Admin.Models.DataModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DesignWeb_Project.Areas.Admin.Models.BusinessModel
{
    public class ConnectionDBContext : DbContext
    {
        public ConnectionDBContext() : base("name=ConnectionStringDBContext")
        {
        }
        public DbSet<User> User { get; set; }
        public DbSet<UserBusiness> UserBusiness { get; set; }
        public DbSet<UserPermission> UserPermission { get; set; }
        public DbSet<UserGrantPermission> UserGrantPermission { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<RegisterUse> RegisterUses { get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<MenuNavigation> MenuNavigations { get; set; }
        public DbSet<Configure> Configures { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}