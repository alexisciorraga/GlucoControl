namespace GlucoControl.Repository.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class InsulinType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid InsulinTypeId { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<Insulin> Insulin { get; set; }
    }
}
