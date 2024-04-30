using System.ComponentModel.DataAnnotations.Schema;

namespace riode_backend.Models
{
    public class Category
    {
        public int Id { get; set; }
		public string CategoryName { get; set; }
		[NotMapped]
        public IFormFile Image {  get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
