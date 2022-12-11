using ExeGuide.DataBase.Data.Configurations;
using ExeGuide.DataBase.Data.Entities;
using static ExeGuide.DataBase.Data.Constants.EditorConstants;
using static ExeGuide.DataBase.Data.Constants.WriterConstants;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ExeGuide.DataBase.Data
{
    public class ExeGuideDbContext : IdentityDbContext
    {
        private IdentityUser Editor { get; set; }
        private IdentityUser Writer { get; set; }

        
        public ExeGuideDbContext(DbContextOptions<ExeGuideDbContext> options)
            : base(options)
        {
            //this.Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ExercisesConfiguration());
            builder.ApplyConfiguration(new EquipmentConfiguration());
            builder.ApplyConfiguration(new MainCategoryConfiguration());
            builder.ApplyConfiguration(new SubCategoryConfiguration());
            builder.ApplyConfiguration(new ArticleCategoryConfiguration());
            builder.ApplyConfiguration(new ArticleConfiguration());
            
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

            builder.Entity<Article>()
                .HasOne(a => a.ArticleCategory)
                .WithMany(a => a.Article)
                .HasForeignKey(a => a.CategoryId)
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

            //The EDITOR role password is = admin123
            SeedEditor();
            SeedWriter();
            builder.Entity<IdentityUser>()
                .HasData(this.Editor);
            //the WRITER role password is = writer123
            builder.Entity<IdentityUser>()
                .HasData(this.Writer);

            base.OnModelCreating(builder);
        }

        private void SeedEditor()
        {
            var guid = Guid.NewGuid().ToString("D");
            var hasher = new PasswordHasher<IdentityUser>();
            this.Editor = new IdentityUser() { Id = "bcb4f072-ecca-43c9-ab26-c060c6f364e4", Email = EditorEmail, NormalizedEmail = EditorEmail, UserName = EditorEmail, NormalizedUserName = EditorEmail, SecurityStamp = guid };
            this.Editor.PasswordHash = hasher.HashPassword(this.Editor, "admin123");
        }
        private void SeedWriter()
        {
            var guid = Guid.NewGuid().ToString("D");
            var hasher = new PasswordHasher<IdentityUser>();
            this.Writer = new IdentityUser() { Id = "e4885526-b62d-4ba4-9b84-1ae80535863a", Email = WriterEmail, NormalizedEmail = WriterEmail, UserName = WriterEmail, NormalizedUserName = WriterEmail, SecurityStamp = guid };
            this.Writer.PasswordHash = hasher.HashPassword(this.Writer, "writer123");
        }

        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<MainCategory> MainCategories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Exercise> Exercises { get; set; }

        public DbSet<TrainingUser> TrainingUsers { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleCategory> ArticleCategories { get; set; }
         public DbSet<TrainingUsersExercise> TrainingUsersExercises { get; set; }
    }
}