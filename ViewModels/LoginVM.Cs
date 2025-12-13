// ViewModels/LoginVM.cs
using System.ComponentModel.DataAnnotations;

namespace form_TP.ViewModels
{
    public class LoginVM
    {
        [Required]
        public string Username { get; set; } = string.Empty;
    }
}
