using System.ComponentModel.DataAnnotations;

namespace ProductsMarket.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        public decimal price { get; set; }

        public int quantity { get; set; }

        public int weight { get; set; }

        public DateTime manufacture_date { get; set; }

    }
}

