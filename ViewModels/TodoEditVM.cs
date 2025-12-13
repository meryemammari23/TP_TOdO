// ViewModels/TodoEditVM.cs
namespace form_TP.ViewModels
{
    public class TodoEditVM
    {
        public int Id { get; set; }
        public string Label { get; set; } = string.Empty;
        public bool IsDone { get; set; }
    }
}
