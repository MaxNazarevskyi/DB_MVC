using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsMarket.Models
{
    [Table("order_details")]
    public class OrderDetails
    {
        [Key]
        public int order_id { get; set; }

        [Required]
        public int product_id { get; set; }

        public int quantity { get; set; }

        public decimal price { get; set; }

    }
}

