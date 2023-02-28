using System.ComponentModel.DataAnnotations;

namespace CLASSEM_MVC_PRO.Models.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        [Key]
        public string ProductId { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        public string Engine { get; set; }
        public double SellingPrice { get; set; }
        public bool IsAvailable { get; set; }
    }
}