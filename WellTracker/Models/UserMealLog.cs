namespace WellTracker.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserMealLog")]
    public partial class UserMealLog
    {
        [Key]
        public int LogID { get; set; }

        public int UserID { get; set; }

        public int MealTypeID { get; set; }

        public int? RecipeID { get; set; }

        [StringLength(200)]
        public string CustomFoodName { get; set; }

        public decimal Amount { get; set; }

        public int Calories { get; set; }

        public decimal Protein { get; set; }

        public decimal Fat { get; set; }

        public decimal Carbs { get; set; }

        [Column(TypeName = "date")]
        public DateTime LogDate { get; set; }

        public virtual MealType MealType { get; set; }

        public virtual Recipe Recipe { get; set; }

        public virtual User User { get; set; }
    }
}
