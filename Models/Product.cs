using System.ComponentModel.DataAnnotations;

namespace GrassyWomen.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        
        public string Name { get; set; }
        [Required]
        [StringLength(50)]

        public string ShortDescription { get; set; }

        [Required]
        [StringLength(255)]
        public string LongDescription { get; set; }
        [Required]
        [StringLength(255)]
        public decimal Price { get; set; }

        [Required]
        [StringLength(255)]
        public string ImageUrl { get; set; }

        [Required]
        [StringLength(255)]

        public bool IsProductOfTheWeek { get; set; }

       
    }
}

