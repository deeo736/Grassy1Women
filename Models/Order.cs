using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace GrassyWomen.Models
{
    public class Order
    {
        public int Id { get; set; }
        [StringLength(255)]
        [Required]
        public string FirstName { get; set; }

        [StringLength(255)]
        [Required]
        public string LastName { get; set; }

        [StringLength(255)]
        [Required]
        public string AddressLine1 { get; set; }

        [StringLength(255)]
        public string AddressLine2 { get; set; }

        [StringLength(255)]
        [Required]
        public string City { get; set; }

        [StringLength(255)]
        [Required]
        public string Province { get; set; }

        [StringLength(255)]
        [Required]
        public string Country { get; set; }

        [StringLength(6)]
        [Required]
        public string PostalCode { get; set; }

        [StringLength(10)]
        [Required]
        public string PhoneNumber { get; set; }

        [StringLength(255)]
        [Required]
        public string Email { get; set; }

        public decimal OrderTotal { get; set; }
    }
    
    
}
