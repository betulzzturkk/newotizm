using System.ComponentModel.DataAnnotations;

namespace AutismEducationPlatform.Web.Models;

public class LoginViewModel
{
    [Required(ErrorMessage = "E-posta adresi gereklidir")]
    [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz")]
    [Display(Name = "E-posta")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Şifre gereklidir")]
    [DataType(DataType.Password)]
    [Display(Name = "Şifre")]
    public string Password { get; set; }

    [Display(Name = "Beni Hatırla")]
    public bool RememberMe { get; set; }
} 