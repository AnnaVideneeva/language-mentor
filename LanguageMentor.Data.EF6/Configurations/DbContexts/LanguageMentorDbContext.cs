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

            modelBuilder.Configurations.Add(new AnswerEntityConfig());
            modelBuilder.Configurations.Add(new ExaminationEntityConfig());
            modelBuilder.Configurations.Add(new ExaminationTypeEntityConfig());
            modelBuilder.Configurations.Add(new ExerciseEntityConfig());
            modelBuilder.Configurations.Add(new ExerciseExaminationPoolEntityConfig());
            modelBuilder.Configurations.Add(new LevelEntityConfig());
            modelBuilder.Configurations.Add(new PointEntityConfig());
            modelBuilder.Configurations.Add(new PointAnswerPoolEntityConfig());
        }
    }
}