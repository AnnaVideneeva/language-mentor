using System.Data.Entity;
using LanguageMentor.Data.EF6.Configurations.EntityConfigurations;
using LanguageMentor.Data.Entities;

namespace LanguageMentor.Data.EF6.Configurations.DbContexts
{
    public class LanguageMentorDbContext : DbContext
    {
        public LanguageMentorDbContext(string connectionString)
            : base(connectionString)
        {
        }

        public DbSet<AnswerEntity> Answers { get; set; }

        public DbSet<ExaminationEntity> Examinations { get; set; }

        public DbSet<ExaminationTypeEntity> ExaminationType { get; set; }

        public DbSet<ExerciseEntity> Exercises { get; set; }

        public DbSet<ExerciseExaminationPoolEntity> ExerciseExaminationPool { get; set; }

        public DbSet<LevelEntity> Levels { get; set; }

        public DbSet<PointAnswerPoolEntity> PointAnswerPool { get; set; }

        public DbSet<PointEntity> Points { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("LanguageMentorDb");
            modelBuilder.ConfigureEntities();
       }
    }
}