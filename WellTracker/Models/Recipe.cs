namespace WellTracker.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Recipe")]
    public partial class Recipe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Recipe()
        {
            UserMealLog = new HashSet<UserMealLog>();
        }

        public int RecipeID { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public int CategoryID { get; set; }

        public string Description { get; set; }

        [Required]
        public string Ingredients { get; set; }

        public string Instructions { get; set; }

        public int Servings { get; set; }

        public int CaloriesPerServing { get; set; }

        public decimal Protein { get; set; }

        public decimal Fat { get; set; }

        public decimal Carbs { get; set; }

        public int CreatedByUserID { get; set; }

        public DateTime? CreatedAt { get; set; }

        public virtual RecipeCategory RecipeCategory { get; set; }

        public virtual User User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserMealLog> UserMealLog { get; set; }
    }
}
