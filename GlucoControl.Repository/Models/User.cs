namespace GlucoControl.Repository.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        public string Name { get; set; }
        public string Lastname1 { get; set; }
        public string Lastname2 { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }
        public decimal Weight { get; set; }
        public int RoleId { get; set; }

        [ForeignKey("RoleId")]
        public Role Role { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Control> Control { get; set; }
    }
}