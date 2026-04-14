namespace WellTracker.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdviceTemplate")]
    public partial class AdviceTemplate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AdviceTemplate()
        {
            AdviceUser = new HashSet<AdviceUser>();
        }

        [Key]
        public int TemplateID { get; set; }

        [Required]
        public string TriggerCondition { get; set; }

        [Required]
        [StringLength(500)]
        public string AdviceText { get; set; }

        [StringLength(50)]
        public string Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AdviceUser> AdviceUser { get; set; }
    }
}
