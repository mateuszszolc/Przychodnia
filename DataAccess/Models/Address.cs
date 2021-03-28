using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public string PostalCode { get; set; }

        [Required]
        public string HouseNumber { get; set; }

        public string FlatNumber { get; set; }

        public virtual User User { get; set; }
        [Required]
        public virtual Hospital Hospital { get; set; }
    }
}
