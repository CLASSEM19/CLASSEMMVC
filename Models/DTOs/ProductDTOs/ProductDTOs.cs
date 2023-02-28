using System.ComponentModel.DataAnnotations;

namespace CLASSEM_MVC_PRO.Models.DTOs.ProductDTOs
{
    public class ProductDTOs
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public double SellingPrice { get; set; }
        public string ProductId { get; set; }
        public string Color { get; set; }
        public string Engine { get; set; }
        public bool IsAvailable { get; set; }
    }
}