using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HW_1._1
{
    //[Table("Product")]
    public class Product
    {
        [Key]
        [Column("ProductId")]
        public Guid Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; } = null!;

        [Required]
        public double Cost { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; } = null!;

        [Required]
        public int Quantity { get; set; }

        [DataType(DataType.Date)]
        public DateTime? CreatedDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ModifiedDate { get; set; }
    }
}
