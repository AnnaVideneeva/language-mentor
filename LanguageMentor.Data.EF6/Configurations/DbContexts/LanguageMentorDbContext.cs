using System;
using System.Data.Entity;
using LanguageMentor.Data.EF6.Configurations.EntityConfigurations;
using LanguageMentor.Data.Entities;

namespace LanguageMentor.Data.EF6.Configurations.DbContexts
{
    public class LanguageMentorDbContext : DbContext
    {
        static LanguageMentorDbContext()
        {
            var type = typeof(System.Data.Entity.SqlServer.SqlProviderServices);
            if (type == null)
            {
                throw new InvalidOperationException("Entity Framework provider is not configured.");
            }
        }

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

            modelBuilder.Configurations.Add(new AnswerEntityConfiguration());
            modelBuilder.Configurations.Add(new ExaminationEntityConfiguration());
            modelBuilder.Configurations.Add(new ExaminationTypeEntityConfiguration());
            modelBuilder.Configurations.Add(new ExerciseEntityConfiguration());
            modelBuilder.Configurations.Add(new ExerciseExaminationPoolEntityConfiguration());
            modelBuilder.Configurations.Add(new LevelEntityConfiguration());
            modelBuilder.Configurations.Add(new PointEntityConfiguration());
            modelBuilder.Configurations.Add(new PointAnswerPoolEntityConfiguration());
        }
    }
}