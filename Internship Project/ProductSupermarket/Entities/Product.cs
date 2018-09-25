using ProductSupermarket.Enums;

namespace ProductSupermarket.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public CategoryEnum Category { get; set; }
    }
}
