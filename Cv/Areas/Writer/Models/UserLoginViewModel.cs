using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Cv.UI.Areas.Writer.Models
{
	public class UserLoginViewModel
	{
        [Display (Name ="Kullanıcı Adı")]
		[Required(ErrorMessage = "Kullanıcı Adını giriniz...!")]
		public string UserName { get; set; }

		[DisplayName("Şifre")]
		[Required(ErrorMessage = "Şifreyi giriniz...!")]
		public string Password { get; set; }
    }
}
