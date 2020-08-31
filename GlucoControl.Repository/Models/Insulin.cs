using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GlucoControl.Repository.Models
{
    public partial class Insulin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid InsulinId { get; set; }
        public Guid InsulinTypeId { get; set; }
        public string Brand { get; set; }
        public string GenericName { get; set; }
        public string StartTime { get; set; }
        public string Peak { get; set; }
        public string Duration { get; set; }
    
        public InsulinType InsulinType { get; set; }
    }
}
