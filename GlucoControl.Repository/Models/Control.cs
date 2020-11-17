namespace GlucoControl.Repository.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Control
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ControlId { get; set; }

        public DateTime ControlDate { get; set; }
        public int GlucoseLevel { get; set; }
        public bool? ProvideInsulin { get; set; }
        public int? InsulinId { get; set; }
        public int? InsulinAmount { get; set; }
        public Insulin Insulin { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}