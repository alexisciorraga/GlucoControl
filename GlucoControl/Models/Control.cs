using System;

namespace GlucoControl.Models
{
    public class Control
    {
        public Guid ControlId { get; set; }
        public DateTime ControlDate { get; set; }
        public int GlucoseLevel { get; set; }
        public bool? ProvideInsulin { get; set; }
        public Guid? InsulinId { get; set; }
        public int? InsulinAmount { get; set; }
        public Guid UserId { get; set; }
    }
}
