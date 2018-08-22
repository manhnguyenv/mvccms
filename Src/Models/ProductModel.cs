using System;

namespace DesignWeb_Project.Models
{
    public class ProductModel
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }
        public string Category_Name { get; set; }

        public string Alias_Product { get; set; }

        public string Alias_Category { get; set; }

        public string Images { get; set; }

        public int CategoryID { get; set; }

        public string DescriptShort { get; set; }

        public string Content { get; set; }

        public string Content2 { get; set; }

        public string Content3 { get; set; }

        public string MetaTitle { get; set; }

        public string MetaKeyword { get; set; }

        public string MetaDescription { get; set; }

        public DateTime? CreatedAt { get; set; }

        public bool Status { get; set; }
    }
}