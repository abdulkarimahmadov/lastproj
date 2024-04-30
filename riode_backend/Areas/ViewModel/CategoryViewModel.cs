using System.ComponentModel.DataAnnotations;

namespace riode_backend.Areas.ViewModel
{
    public class CategoryViewModel
    {
        [Required]
        public string CategoryName { get; set; }
    }
}
