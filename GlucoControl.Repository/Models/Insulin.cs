using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GlucoControl.Repository.Models
{
    public partial class Insulin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int InsulinId { get; set; }

        public string Brand { get; set; }
        public string GenericName { get; set; }
        public string StartTime { get; set; }
        public string Peak { get; set; }
        public string Duration { get; set; }

        public int InsulinTypeId { get; set; }

        [ForeignKey("InsulinTypeId")]
        public InsulinType InsulinType { get; set; }
    }
}