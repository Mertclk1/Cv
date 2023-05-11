using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace Cv.UI.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen Adınızı Giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen Soyadınızı Giriniz.")]
        public string Surname { get; set; }

        [Required(ErrorMessage ="Lütfen Kullanıcı Adını Giriniz.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Giriniz.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Tekrar Giriniz.")]
        [Compare("Password",ErrorMessage ="Şifreler uyumlu değil!")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen Mail Adresinizi Giriniz.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen Resim URL Değeri Giriniz.")]
        public string ImgURL { get; set; }
    }
}
