
using System.ComponentModel;

namespace HW3
{
    public class Product
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public double ActionPrice { get; set; }
        public string? Description { get; set; }
        public string? DescriptionField1 { get; set; }
        public string? DescriptionField2 { get; set; }
        public string? ImageUrl { get; set; }
        public Category? Category { get; set; }
        public List<Cart> Carts { get; set; } = new();
        public List<KeyParams> KeyWords { get; set; } = new();
    }
}
