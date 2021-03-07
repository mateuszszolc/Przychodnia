using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        [StringLength(50, ErrorMessage = "Hasło musi zawierać od 8 do 50 znaków.", MinimumLength = 8)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Podane hasło nie jest zgodne.")]
        public string ConfirmPassword { get; set; }

        [NotMapped]
        public string Token { get; set; }

        public ICollection<Diagnosis> Diagnoses { get; set; }

        public ICollection<Reservation> Users { get; set; }

        public virtual Address Address { get; set; }

        [ForeignKey("Address")]
        public int AddressId { get; set; }
    }
}
