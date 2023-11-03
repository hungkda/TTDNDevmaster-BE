using System.ComponentModel.DataAnnotations;

namespace Lession05.Theory.Models.ViewModels
{
    public class MemberView
    {

        public string MemberId { get; set; }

        [Display(Name = "Tên đăng nhập")]
        [Required(ErrorMessage = "Tên đăng nhập không được để trống")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Độ dài từ 3 đến 20")]
        public string UserName { get; set; }

        [Display(Name = "Họ và tên")]
        [Required(ErrorMessage = "Họ tên không được để trống")]
        public string FullName { get; set; }

        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Nhập lại mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email không được để trống")]
        [RegularExpression(@"[a-zA-Z0-9._+-]+@[a-z0-9._]+\.[a-z]{2,4}$", ErrorMessage = "Email không đúng định dạng")]
        public string Email { get; set; }

        [Display(Name = "Điện thoại")]
        [RegularExpression(@"^0\d{9,12}$", ErrorMessage = " Phải bắt đầu bằng 0 và dài 10-12 số")]
        public string Phone { get; set; }

        [Display(Name = "Ngày sinh")]
        public DateTime? Birthday { get; set; }
    }
}
