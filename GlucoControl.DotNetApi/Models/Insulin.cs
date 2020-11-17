using System;

namespace GlucoControl.DotNetApi.Models
{
    public class Insulin
    {
        public int InsulinId { get; set; }
        public int InsulinTypeId { get; set; }
        public string Brand { get; set; }
        public string GenericName { get; set; }
        public string StartTime { get; set; }
        public string Peak { get; set; }
        public string Duration { get; set; }
    }
}