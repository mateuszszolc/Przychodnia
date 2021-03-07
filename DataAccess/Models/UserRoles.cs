using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccess.Models
{
    public class UserRoles
    {
        [Key]
        public int UserRoleId { get; set; }


        [ForeignKey("UserId")]
        [Required]
        public User User { get; set; }


        [ForeignKey("RoleId")]
        [Required]
        public Role Role { get; set; }
    }
}
