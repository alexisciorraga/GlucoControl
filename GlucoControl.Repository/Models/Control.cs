namespace GlucoControl.Repository.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Control
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ControlId { get; set; }
        public DateTime ControlDate { get; set; }
        public int GlucoseLevel { get; set; }
        public bool? ProvideInsulin { get; set; }
        public Guid? InsulinId { get; set; }
        public int? InsulinAmount { get; set; }
        public Insulin Insulin { get; set; }

        public Guid UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
