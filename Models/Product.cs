using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace Mart.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        public string ProductTitle { get; set; } = null;
        public byte[] Image { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
        public int Stocks { get; set; } 

    }
}