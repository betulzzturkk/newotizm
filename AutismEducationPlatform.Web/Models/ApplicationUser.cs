using Microsoft.AspNetCore.Identity;
using AutismEducationPlatform.Web.Models.ViewModels;

namespace AutismEducationPlatform.Web.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Role { get; set; } = string.Empty;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? AdditionalInfo { get; set; } // JSON formatında ek bilgiler için
        public string Name { get; set; } = string.Empty;
    }
} 