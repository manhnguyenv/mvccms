using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace DesignWeb_Project.Areas.Admin.Models.DataModel
{
    [Table("Configure")]
    public class Configure
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ConfigID { get; set; }

        [Display(Name = "Logo Website")]
        [MaxLength(256, ErrorMessage = "Tên File Logo Quá Dài Vui Lòng Đổi Lại tên")]
        public string Logo { get; set; }

        [Display(Name = "Icon Favicon")]
        [MaxLength(256, ErrorMessage = "Tên File Favicon Quá Dài Vui Lòng Đổi Lại tên")]
        public string Favicon { get; set; }

        [Display(Name = "Tên Công Ty,Doanh Nghiệp")]
        [MaxLength(256, ErrorMessage = "Tên Công Ty,Doanh Nghiệp Không Được Quá 256 Kí Tự")]
        public string NameCompany { get; set; }

        [Display(Name = "Mô tả Công Ty,Doanh Nghiệp")]
        public string Description { get; set; }

        [Display(Name = "Địa chỉ")]
        public string Address { get; set; }

        [Display(Name = "Email")]
        [MaxLength(50, ErrorMessage = "Email Không Được Quá 50 Kí Tự")]
        public string Email { get; set; }

        [Display(Name = "Email Nhận Tin Khách Hàng")]
        [MaxLength(50, ErrorMessage = "Email Nhận Tin Không Được Quá 50 Kí Tự")]
        public string EmailReceive { get; set; }

        [Display(Name = "Số Điện Thoại")]
        [MaxLength(11, ErrorMessage = "Số Điện Thoại Không Hợp Lệ")]
        public string Phone { get; set; }

        [Display(Name = "Hotline")]
        [MaxLength(150, ErrorMessage = "Hotline Tối Đa Là 150 Kí Tự")]
        public string Hotline { get; set; }

        [AllowHtml]
        [Display(Name = "Mã Nhúng Google Map")]
        public string Map { get; set; }

        [AllowHtml]
        [Display(Name = "Mã Nhúng FANPAGE FACEBOOK")]
        public string FanpageFacebook { get; set; }

        [Display(Name = "Link icon Facebook")]
        public string IconFacebook { get; set; }

        [Display(Name = "Link icon Twitter")]
        public string IconTwiiter { get; set; }

        [Display(Name = "Link icon Instagram")]
        public string IconInstagram { get; set; }

        [Display(Name = "Link icon Youtube")]
        public string IconYoutube { get; set; }

        [Display(Name = "Link icon Google")]
        public string IconGoogle { get; set; }

        [Display(Name = "Tiêu đề khối địa chỉ")]
        public string title_block_address { get; set; }

        [Display(Name = "Tiêu đề khối thông tin thêm 1")]
        public string title_block_description_1 { get; set; }

        [Display(Name = "Tên/Nội dung link liên kết 1")]
        public string link_name_des_1 { get; set; }

        [Display(Name = "Link liên kết Tên/Nội dung 1")]
        public string link_href_des_1 { get; set; }

        [Display(Name = "Tên/Nội dung link liên kết 2")]
        public string link_name_des_2 { get; set; }

        [Display(Name = "Link liên kết Tên/Nội dung 2")]
        public string link_href_des_2 { get; set; }

        [Display(Name = "Tên/Nội dung link liên kết 3")]
        public string link_name_des_3 { get; set; }

        [Display(Name = "Link liên kết Tên/Nội dung 3")]
        public string link_href_des_3 { get; set; }

        [Display(Name = "Tên/Nội dung link liên kết 4")]
        public string link_name_des_4 { get; set; }

        [Display(Name = "Link liên kết Tên/Nội dung 4")]
        public string link_href_des_4 { get; set; }

        [Display(Name = "Tên/Nội dung link liên kết 5")]
        public string link_name_des_5 { get; set; }

        [Display(Name = "Link liên kết Tên/Nội dung 5")]
        public string link_href_des_5 { get; set; }

        [Display(Name = "Tên/Nội dung link liên kết 6")]
        public string link_name_des_6 { get; set; }

        [Display(Name = "Link liên kết Tên/Nội dung 6")]
        public string link_href_des_6 { get; set; }

        [Display(Name = "Tiêu đề khối thông tin thêm 2")]
        public string title_block_description2_1 { get; set; }

        [Display(Name = "Tên/Nội dung link liên kết 1")]
        public string link_name_des_2_1 { get; set; }

        [Display(Name = "Link liên kết Tên/Nội dung 1")]
        public string link_href_des_2_1 { get; set; }

        [Display(Name = "Tên/Nội dung link liên kết 2")]
        public string link_name_des_2_2 { get; set; }

        [Display(Name = "Link liên kết Tên/Nội dung 2")]
        public string link_href_des_2_2 { get; set; }

        [Display(Name = "Tên/Nội dung link liên kết 3")]
        public string link_name_des_2_3 { get; set; }

        [Display(Name = "Link liên kết Tên/Nội dung 3")]
        public string link_href_des_2_3 { get; set; }

        [Display(Name = "Tên/Nội dung link liên kết 4")]
        public string link_name_des_2_4 { get; set; }

        [Display(Name = "Link liên kết Tên/Nội dung 4")]
        public string link_href_des_2_4 { get; set; }

        [Display(Name = "Tên/Nội dung link liên kết 5")]
        public string link_name_des_2_5 { get; set; }

        [Display(Name = "Link liên kết Tên/Nội dung 5")]
        public string link_href_des_2_5 { get; set; }

        [Display(Name = "Tên/Nội dung link liên kết 6")]
        public string link_name_des_2_6 { get; set; }

        [Display(Name = "Link liên kết Tên/Nội dung 6")]
        public string link_href_des_2_6 { get; set; }

        [Display(Name = "Tiêu đề đăng kí nhận tin")]
        public string title_dknt { get; set; }

        [Display(Name = "Nội dung mô tả phần đăng kí nhận tin")]
        public string content_dknt { get; set; }

        [Display(Name = "Tiêu đề bản đồ")]
        public string title_map { get; set; }

        [Display(Name = "Tiêu đề trang")]
        [MaxLength(250, ErrorMessage = "MetaTitle Không Được Quá 250 Kí Tự")]
        public string MetaTitle { get; set; }

        [Display(Name = "Từ Khóa SEO")]
        [MaxLength(250, ErrorMessage = "MetaKeyWord Không Được Quá 250 Kí Tự")]
        public string MetaKeyword { get; set; }

        [Display(Name = "Mô tả SEO")]
        public string MetaDescription { get; set; }
    }
}