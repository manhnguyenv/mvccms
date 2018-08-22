using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace DesignWeb_Project.Areas.Admin.Models.DataModel
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }

        [Display(Name = "Tên Sản Phẩm")]
        [Required(ErrorMessage = "Tên Sản Phẩm Không Được Bỏ Trống")]
        [MaxLength(250, ErrorMessage = "Tên Sản Phẩm Không Được Vượt Quá 250 Kí Tự")]
        public string ProductName { get; set; }

        [Display(Name = "Đường Dẫn URL")]
        [Required(ErrorMessage = "URL Không Được Bỏ Trống")]
        [MaxLength(250, ErrorMessage = "URL Không Được Vượt Quá 250 Kí Tự")]
        [Index(IsUnique = true)]
        [Column(TypeName = "varchar")]
        public string Alias { get; set; }

        [Display(Name = "Ảnh sản phẩm")]
        public string Images { get; set; }

        [Display(Name = "Nhóm Sản Phẩm")]
        [ForeignKey("Categories")]
        public int CategoryID { get; set; }

        [Display(Name = "Mô tả ngắn")]
        [AllowHtml]
        public string DescriptShort { get; set; }

        [AllowHtml]
        [Column(TypeName = "ntext")]
        [Display(Name = "Nội Dung")]
        public string Content { get; set; }

        [AllowHtml]
        [Column(TypeName = "ntext")]
        [Display(Name = "Nội Dung 2")]
        public string Content2 { get; set; }

        [AllowHtml]
        [Column(TypeName = "ntext")]
        [Display(Name = "Nội Dung 3")]
        public string Content3 { get; set; }

        [Display(Name = "Tiêu đề trang")]
        [MaxLength(250, ErrorMessage = "MetaTitle Không Được Quá 250 Kí Tự")]
        public string MetaTitle { get; set; }

        [Display(Name = "Từ Khóa SEO")]
        [MaxLength(250, ErrorMessage = "MetaKeyWord Không Được Quá 250 Kí Tự")]
        public string MetaKeyword { get; set; }

        public string Author { get; set; }

        [Display(Name = "Mô tả SEO")]
        public string MetaDescription { get; set; }

        [Display(Name = "Ngày đăng")]
        public DateTime? CreatedAt { get; set; }

        [Display(Name = "Trạng Thái")]
        public bool Status { get; set; }

        public virtual Category Categories { get; set; }
    }
}