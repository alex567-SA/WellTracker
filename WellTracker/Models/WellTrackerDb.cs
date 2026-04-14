using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WellTracker.Models
{
    public partial class WellTrackerDb : DbContext
    {
        public WellTrackerDb()
            : base("name=WellTrackerDb")
        {
        }

        public virtual DbSet<ActivityType> ActivityType { get; set; }
        public virtual DbSet<AdviceTemplate> AdviceTemplate { get; set; }
        public virtual DbSet<AdviceUser> AdviceUser { get; set; }
        public virtual DbSet<DailySurvey> DailySurvey { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<GoalType> GoalType { get; set; }
        public virtual DbSet<MealType> MealType { get; set; }
        public virtual DbSet<Recipe> Recipe { get; set; }
        public virtual DbSet<RecipeCategory> RecipeCategory { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserActivityLog> UserActivityLog { get; set; }
        public virtual DbSet<UserMealLog> UserMealLog { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActivityType>()
                .Property(e => e.MetValue)
                .HasPrecision(3, 1);

            modelBuilder.Entity<ActivityType>()
                .HasMany(e => e.UserActivityLog)
                .WithRequired(e => e.ActivityType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AdviceTemplate>()
                .HasMany(e => e.AdviceUser)
                .WithRequired(e => e.AdviceTemplate)
                .HasForeignKey(e => e.TempID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DailySurvey>()
                .Property(e => e.SleepHours)
                .HasPrecision(3, 1);

            modelBuilder.Entity<Gender>()
                .Property(e => e.GenderCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Gender>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Gender)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MealType>()
                .HasMany(e => e.UserMealLog)
                .WithRequired(e => e.MealType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Recipe>()
                .Property(e => e.Protein)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Recipe>()
                .Property(e => e.Fat)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Recipe>()
                .Property(e => e.Carbs)
                .HasPrecision(5, 2);

            modelBuilder.Entity<RecipeCategory>()
                .HasMany(e => e.Recipe)
                .WithRequired(e => e.RecipeCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.HeightCm)
                .HasPrecision(5, 2);

            modelBuilder.Entity<User>()
                .Property(e => e.WeightKg)
                .HasPrecision(5, 2);

            modelBuilder.Entity<User>()
                .HasMany(e => e.AdviceUser)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.DailySurvey)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Recipe)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.CreatedByUserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UserMealLog>()
                .Property(e => e.Amount)
                .HasPrecision(5, 2);

            modelBuilder.Entity<UserMealLog>()
                .Property(e => e.Protein)
                .HasPrecision(5, 2);

            modelBuilder.Entity<UserMealLog>()
                .Property(e => e.Fat)
                .HasPrecision(5, 2);

            modelBuilder.Entity<UserMealLog>()
                .Property(e => e.Carbs)
                .HasPrecision(5, 2);

            modelBuilder.Entity<UserRole>()
                .HasMany(e => e.User)
                .WithRequired(e => e.UserRole)
                .WillCascadeOnDelete(false);
        }
    }
}
