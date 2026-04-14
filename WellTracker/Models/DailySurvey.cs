namespace WellTracker.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DailySurvey")]
    public partial class DailySurvey
    {
        [Key]
        public int SurveyID { get; set; }

        public int UserID { get; set; }

        [Column(TypeName = "date")]
        public DateTime SurveyDate { get; set; }

        public decimal? SleepHours { get; set; }

        public int? SleepQuality { get; set; }

        public int? StressLevel { get; set; }

        public int? WaterGlasses { get; set; }

        public bool? Headache { get; set; }

        public int? FatigueLevel { get; set; }

        public int? EnergyLevel { get; set; }

        public virtual User User { get; set; }
    }
}
