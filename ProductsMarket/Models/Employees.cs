using System.ComponentModel.DataAnnotations;

namespace ProductsMarket.Models
{
    public class Employees
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string name { get; set; }

        public string position { get; set; }

        public DateTime hire_date { get; set; }

        public decimal salary { get; set; }
    }
}

