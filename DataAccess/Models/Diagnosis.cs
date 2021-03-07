using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    //xD
    public class Diagnosis
    {
        [Key]
        public int DiagnosisId { get; set; }

        [Required]
        public string Description { get; set; }

        [ForeignKey("Reservation")]
        public int ReservationId { get; set; }

        public virtual Reservation Reservation { get; set; }
    }
}
