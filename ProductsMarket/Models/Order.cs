using System.ComponentModel.DataAnnotations;

namespace ProductsMarket.Models
{
    public class Order
    {
        [Key]
        public int id { get; set; }

        [Required]
        public int customer_id { get; set; }

        public DateTime order_date { get; set; }

    }
}

