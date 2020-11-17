using System;

namespace GlucoControl.DotNetApi.Models
{
    public class Control
    {
        public int ControlId { get; set; }
        public DateTime ControlDate { get; set; }
        public int GlucoseLevel { get; set; }
        public bool? ProvideInsulin { get; set; }
        public int? InsulinId { get; set; }
        public int? InsulinAmount { get; set; }
        public int UserId { get; set; }
    }
}