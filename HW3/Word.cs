
namespace HW3
{
    public class Word
    {
        public Guid Id { get; set; }
        public string? Header { get; set; }
        public string? KeyWord { get; set; }
        public List<KeyParams> ProductLink { get; set; } = new();
    }
}
