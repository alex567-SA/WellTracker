namespace WellTracker.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserActivityLog")]
    public partial class UserActivityLog
    {
        [Key]
        public int LogID { get; set; }

        public int UserID { get; set; }

        public int ActivityTypeID { get; set; }

        public int DurationMinutes { get; set; }

        public int CaloriesBurned { get; set; }

        [Column(TypeName = "date")]
        public DateTime ActivityDate { get; set; }

        [StringLength(255)]
        public string Notes { get; set; }

        public virtual ActivityType ActivityType { get; set; }

        public virtual User User { get; set; }
    }
}
