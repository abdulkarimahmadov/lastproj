using riode_backend.ViewModels;

namespace riode_backend.Areas.ViewModel
{
    public class ProductAddViewModel
    {
        public ProductViewModel Model { get; set; }
        public IFormFile MainImage { get; set; }
        public List<IFormFile> AllImages { get; set; }
    }
}
