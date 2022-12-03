using ExeGuide.DataBase.Data.Configurations;
using ExeGuide.DataBase.Data.Entities;
using static ExeGuide.DataBase.Data.Constants.EditorConstants;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ExeGuide.DataBase.Data
{
    public class ExeGuideDbContext : IdentityDbContext<IdentityUser, IdentityRole, string>
    {
        private TrainingUser Editor { get; set; }

        
        public ExeGuideDbContext(DbContextOptions<ExeGuideDbContext> options)
            : base(options)
        {
            this.Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ExercisesConfiguration());
            builder.ApplyConfiguration(new EquipmentConfiguration());
            builder.ApplyConfiguration(new MainCategoryConfiguration());
            builder.ApplyConfiguration(new SubCategoryConfiguration());
            
            builder.Entity<Exercise>()
                 .HasOne(e => e.Equipment)
                 .WithMany(e => e.Exercises)
                 .HasForeignKey(e => e.EquipmentId)
                 .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Exercise>()
                .HasOne(e => e.MainCategory)
                .WithMany(e => e.Exercises)
                .HasForeignKey(e => e.MainCategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Exercise>()
                .HasOne(e => e.SubCategory)
                .WithMany(e => e.Exercises)
                .HasForeignKey(e => e.SubCategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<TrainingUsersExercise>()
                 .HasKey(e => new { e.ExerciseId, e.UserId });
            builder.Entity<TrainingUsersExercise>()
                .HasOne<Exercise>(e => e.Exercise)
                .WithMany(e => e.TrainingUsersExercises)
                .HasForeignKey(e => e.ExerciseId);
            builder.Entity<TrainingUsersExercise>()
               .HasOne<TrainingUser>(e => e.TrainingUser)
               .WithMany(e => e.TrainingUsersExercises)
               .HasForeignKey(e => e.UserId);

            //The EDITOR rolle password is = admin123
            SeedEditor();
            builder.Entity<TrainingUser>()
                .HasData(this.Editor);
           

            base.OnModelCreating(builder);
        }

        private void SeedEditor()
        {
            var guid = Guid.NewGuid().ToString("D");
            var hasher = new PasswordHasher<TrainingUser>();
            this.Editor = new TrainingUser() { Id = "bcb4f072-ecca-43c9-ab26-c060c6f364e4", Email = EditorEmail, NormalizedEmail = EditorEmail, UserName = EditorEmail, NormalizedUserName = EditorEmail, FirstName = "Great", LastName = "Editor",SecurityStamp = guid };
            this.Editor.PasswordHash = hasher.HashPassword(this.Editor, "admin123");
        }

        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<MainCategory> MainCategories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Exercise> Exercises { get; set; }

        public DbSet<TrainingUsersExercise> TrainingUsersExercises { get; set; }
    }
}