using System.ComponentModel.DataAnnotations;

namespace ProductsMarket.Models
{
    public class Customers
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        public string city { get; set; }

        public string address { get; set; }

        public int discount { get; set; }

    }
}

