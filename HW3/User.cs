
namespace HW3
{
    public class User
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Login { get; set; }
        public List<Cart> Carts { get; set; } = new();
    }
}
