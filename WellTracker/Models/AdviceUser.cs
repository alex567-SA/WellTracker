namespace WellTracker.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdviceUser")]
    public partial class AdviceUser
    {
        public int AdviceUserID { get; set; }

        public int UserID { get; set; }

        public int TempID { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public virtual AdviceTemplate AdviceTemplate { get; set; }

        public virtual User User { get; set; }
    }
}
