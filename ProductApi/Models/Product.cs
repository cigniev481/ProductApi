using System;
using System.ComponentModel.DataAnnotations;

namespace ProductApi.Models
{
    public class Product
    {
        [Required]
        public string Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        
        [Required]
        public decimal Price { get; set; }

        [MaxLength(100)]
        public string CreatedDate { get; set; }
        public bool IsDeleted { get; set; }

    }
}
