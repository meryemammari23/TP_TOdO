// ViewModels/SetThemeVM.cs
using System.ComponentModel.DataAnnotations;

namespace form_TP.ViewModels
{
    public class SetThemeVM
    {
        [Required]
        public string Theme { get; set; } = string.Empty;
    }
}
