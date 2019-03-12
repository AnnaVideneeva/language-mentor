using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using LanguageMentor.Data.Entities;

namespace LanguageMentor.Data.EF6.Configurations.EntityConfigurations
{
    public sealed class ExerciseEntityConfig : EntityTypeConfiguration<ExerciseEntity>
    {
        public ExerciseEntityConfig()
        {
            ToTable("exercises");

            Property(c => c.ExerciseId).HasColumnName("exercise_id").IsRequired();
            Property(c => c.ExerciseText).HasColumnName("exercise_text").IsRequired().HasMaxLength(256);
            Property(c => c.LevelId).HasColumnName("level_id").IsRequired();

            HasKey(c => c.ExerciseId);
            Property(c => c.ExerciseId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(exercise => exercise.Level)
                .WithMany(level => level.Exercises)
                .HasForeignKey(exercise => exercise.LevelId)
                .WillCascadeOnDelete();
        }
    }
}
