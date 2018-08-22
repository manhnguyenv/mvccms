using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesignWeb_Project.Areas.Admin.Models.DataModel
{
    [Table("Home")]
    public class Home
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HomeID { get; set; }

        //vi sao ban nen chon chung toi

        [Display(Name = "Hiển thị Slogan dưới Slider")]
        public bool on_block_slogan { get; set; }

        [Display(Name = "Nội dung Slogan dưới Slider")]
        public string title_sologan { get; set; }

        [Display(Name = "Nút xem thêm Slogan dưới Slider")]
        public string button_more_slogan { get; set; }

        //giới thiệu

        [Display(Name = "Hiển thị cụm giới thiệu")]
        public bool on_block_intro { get; set; }

        [Display(Name = "Tiêu đề cụm giới thiệu")]
        public string title_intro { get; set; }

        //giới thiệu
        [Display(Name = "Mô tả thêm dưới tiêu đề")]
        public string des_more_intro { get; set; }

        [Display(Name = "Hình ảnh giới thiệu 1")]
        public string images_intro_1 { get; set; }

        [Display(Name = "Hình ảnh giới thiệu 2")]
        public string images_intro_2 { get; set; }

        [Display(Name = "Nội dung giới thiệu")]
        public string content_intro { get; set; }

        [Display(Name = "Text mô tả thêm 1")]
        public string text_intro1 { get; set; }

        [Display(Name = "Text mô tả thêm 2")]
        public string text_intro2 { get; set; }

        [Display(Name = "Text mô tả thêm 3")]
        public string text_intro3 { get; set; }

        [Display(Name = "Text mô tả thêm 4")]
        public string text_intro4 { get; set; }

        [Display(Name = "Text mô tả thêm 5")]
        public string text_intro5 { get; set; }

        [Display(Name = "Text mô tả thêm 6")]
        public string text_intro6 { get; set; }

        [Display(Name = "Text mô tả thêm 7")]
        public string text_intro7 { get; set; }

        [Display(Name = "Text mô tả thêm 8")]
        public string text_intro8 { get; set; }

        [Display(Name = "Text mô tả thêm 9")]
        public string text_intro9 { get; set; }

        [Display(Name = "Text mô tả thêm 10")]
        public string text_intro10 { get; set; }

        [Display(Name = "Link liên kể nút xem thêm giới thiệu")]
        public string button_more_intro { get; set; }

        //cụm 2 sản phẩm

        [Display(Name = "Hiển thị cụm sản phẩm")]
        public bool on_product_home { get; set; }

        [Display(Name = "Tiêu đề cụm sản phẩm")]
        public string title_product_home { get; set; }

        [Display(Name = "Link liên kể tiêu đề cụm sản phẩm")]
        public string link_title_product_home { get; set; }

        [Display(Name = "Chọn nhóm sản phẩm")]
        public int? collection_product_home { get; set; }

        //cum  3 quy trình

        [Display(Name = "Hiển thị cụm quy trình làm việc")]
        public bool on_work_time { get; set; }

        [Display(Name = "Tiêu đề cụm quy trình làm việc")]
        public string title_work { get; set; }

        [Display(Name = "Icon khối  1")]
        public string icon_work_1 { get; set; }

        [Display(Name = "Tiêu đề khối 1")]
        public string titile_block_work1 { get; set; }

        [Display(Name = "Nội dung khối 1")]
        public string content_block_work1 { get; set; }

        [Display(Name = "Icon khối  2")]
        public string icon_work_2 { get; set; }

        [Display(Name = "Tiêu đề khối 2")]
        public string titile_block_work2 { get; set; }

        [Display(Name = "Nội dung khối 2")]
        public string content_block_work2 { get; set; }

        [Display(Name = "Icon khối  3")]
        public string icon_work_3 { get; set; }

        [Display(Name = "Tiêu đề khối 3")]
        public string titile_block_work3 { get; set; }

        [Display(Name = "Nội dung khối 3")]
        public string content_block_work3 { get; set; }

        [Display(Name = "Icon khối  4")]
        public string icon_work_4 { get; set; }

        [Display(Name = "Tiêu đề khối 4")]
        public string titile_block_work4 { get; set; }

        [Display(Name = "Nội dung khối 4")]
        public string content_block_work4 { get; set; }

        //cụm 4 khối tin tức

        [Display(Name = "Hiển thị cụm tin tức và video")]
        public bool on_new_video { get; set; }

        [Display(Name = "Tiêu đề khối tin tức")]
        public string title_block_news { get; set; }

        [Display(Name = "Chọn nhóm tin tức")]
        public int? blog_news_chosse { get; set; }

        [Display(Name = "Tiêu đề khối video")]
        public string title_block_video { get; set; }

        [Display(Name = "Mã nhúng video( Chèn link youtube )")]
        public string video_iframe1 { get; set; }

        [Display(Name = "Hình ảnh đại diện video 2")]
        public string images_video_2 { get; set; }

        [Display(Name = "Mã nhúng video 2( Chèn link youtube )")]
        public string video_iframe2 { get; set; }

        [Display(Name = "Hình ảnh đại diện video 3")]
        public string images_video_3 { get; set; }

        [Display(Name = "Mã nhúng video 3( Chèn link youtube )")]
        public string video_iframe3 { get; set; }

        [Display(Name = "Hình ảnh đại diện video 4")]
        public string images_video_4 { get; set; }

        [Display(Name = "Mã nhúng video 4( Chèn link youtube )")]
        public string video_iframe4 { get; set; }

        [Display(Name = "Hiển thị cụm khách hàng nói")]
        public bool on_say_customer { get; set; }

        [Display(Name = "Tiêu đề nhận xét khách hàng")]
        public string title_block_comment_customer { get; set; }

        [Display(Name = "Hiển thị khối thứ 1")]
        public bool on_block_say_customer1 { get; set; }

        [Display(Name = "Tên khách hàng 1")]
        public string name_customer_say1 { get; set; }

        [Display(Name = "Ảnh khách hàng")]
        public string images_customer_1 { get; set; }

        [Display(Name = "Tên công ty")]
        public string company_customer_say1 { get; set; }

        [Display(Name = "Nội dung khách hàng nói")]
        public string content_customer_say1 { get; set; }

        [Display(Name = "Hiển thị khối thứ 2")]
        public bool on_block_say_customer2 { get; set; }

        [Display(Name = "Tên khách hàng 2")]
        public string name_customer_say2 { get; set; }

        [Display(Name = "Ảnh khách hàng")]
        public string images_customer_2 { get; set; }

        [Display(Name = "Tên công ty")]
        public string company_customer_say2 { get; set; }

        [Display(Name = "Nội dung khách hàng nói")]
        public string content_customer_say2 { get; set; }

        [Display(Name = "Hiển thị khối thứ 3")]
        public bool on_block_say_customer3 { get; set; }

        [Display(Name = "Tên khách hàng 3")]
        public string name_customer_say3 { get; set; }

        [Display(Name = "Ảnh khách hàng")]
        public string images_customer_3 { get; set; }

        [Display(Name = "Tên công ty")]
        public string company_customer_say3 { get; set; }

        [Display(Name = "Nội dung khách hàng nói")]
        public string content_customer_say3 { get; set; }

        [Display(Name = "Hiển thị khối thứ 4")]
        public bool on_block_say_customer4 { get; set; }

        [Display(Name = "Tên khách hàng 4")]
        public string name_customer_say4 { get; set; }

        [Display(Name = "Ảnh khách hàng")]
        public string images_customer_4 { get; set; }

        [Display(Name = "Tên công ty")]
        public string company_customer_say4 { get; set; }

        [Display(Name = "Nội dung khách hàng nói")]
        public string content_customer_say4 { get; set; }

        [Display(Name = "Hiển thị khối thứ 5")]
        public bool on_block_say_customer5 { get; set; }

        [Display(Name = "Tên khách hàng 5")]
        public string name_customer_say5 { get; set; }

        [Display(Name = "Ảnh khách hàng")]
        public string images_customer_5 { get; set; }

        [Display(Name = "Tên công ty")]
        public string company_customer_say5 { get; set; }

        [Display(Name = "Nội dung khách hàng nói")]
        public string content_customer_say5 { get; set; }

        [Display(Name = "Hiển thị khối thứ 6")]
        public bool on_block_say_customer6 { get; set; }

        [Display(Name = "Tên khách hàng 6")]
        public string name_customer_say6 { get; set; }

        [Display(Name = "Ảnh khách hàng")]
        public string images_customer_6 { get; set; }

        [Display(Name = "Tên công ty")]
        public string company_customer_say6 { get; set; }

        [Display(Name = "Nội dung khách hàng nói")]
        public string content_customer_say6 { get; set; }

        [Display(Name = "Hiển thị cụm đối tác")]
        public bool on_block_partner { get; set; }

        [Display(Name = "Tiêu đề Logo Đối tác")]
        public string title_partners { get; set; }
    }
}