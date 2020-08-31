using System;

namespace GlucoControl.Models
{
    public class Insulin
    {
        public Guid InsulinId { get; set; }
        public Guid InsulinTypeId { get; set; }
        public string Brand { get; set; }
        public string GenericName { get; set; }
        public string StartTime { get; set; }
        public string Peak { get; set; }
        public string Duration { get; set; }
    }
}
