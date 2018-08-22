using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesignWeb_Project.Areas.Admin.Models.DataModel
{
    [Table("RegisterUse")]
    public class RegisterUse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RegisterUseID { get; set; }

        public int ProductID { get; set; }

        [Display(Name = "Họ Và Tên")]
        [Required(ErrorMessage = "Họ Tên Không Được Bỏ Trống")]
        [MaxLength(250, ErrorMessage = "Họ Tên Không Được Vượt Quá 250 Kí Tự")]
        public string FullName { get; set; }

        [Display(Name = "Email")]
        [Column(TypeName = "varchar")]
        [Required(ErrorMessage = "Email Không Được Bỏ Trống")]
        [MaxLength(250, ErrorMessage = "Email Không Được Vượt Quá 250 Kí Tự")]
        public string Email { get; set; }

        [Display(Name = "Số Điện Thoại")]
        [Column(TypeName = "varchar")]
        [Required(ErrorMessage = "Số Điện Thoại Không Được Bỏ Trống")]
        [MaxLength(11, ErrorMessage = "Số Điện Thoại Vượt Quá 11 Kí Tự")]
        public string Phone { get; set; }

        public bool ViewStatus { get; set; }

        [Display(Name = "Ngày nhận")]
        public DateTime? CreatedAt { get; set; }
    }
}