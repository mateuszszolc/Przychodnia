using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class Doctor
    {
        [Key]
        public int DoctorId { get; set; }


        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        public enum SpecializationType {Kardiolog, Chirurg, Stomatolog, Ortopeda, Pediatra}

        [Required] public Hospital Hospital { get; set; }

        [Required]
        public SpecializationType Specialization { get; set; }

        public ICollection<Diagnosis> Diagnoses { get; set; }

        public ICollection<Reservation> Users { get; set; }
    }
}
