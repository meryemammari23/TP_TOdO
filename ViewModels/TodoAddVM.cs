// ViewModels/TodoAddVM.cs
using System.ComponentModel.DataAnnotations;

namespace form_TP.ViewModels
{
    public class TodoAddVM
    {
        [Required]
        public string Label { get; set; } = string.Empty;
    }
}
