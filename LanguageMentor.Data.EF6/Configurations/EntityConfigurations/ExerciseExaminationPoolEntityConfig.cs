using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using LanguageMentor.Data.Entities;

namespace LanguageMentor.Data.EF6.Configurations.EntityConfigurations
{
    public sealed class ExerciseExaminationPoolEntityConfig : EntityTypeConfiguration<ExerciseExaminationPoolEntity>
    {
        public ExerciseExaminationPoolEntityConfig()
        {
            ToTable("exercise_examination_pool");

            Property(c => c.ExerciseExaminationPoolId).HasColumnName("exercise_examination_pool_id").IsRequired();
            Property(c => c.ExerciseId).HasColumnName("exercise_id").IsRequired();
            Property(c => c.ExaminationId).HasColumnName("examination_id").IsRequired();

            HasKey(c => c.ExerciseExaminationPoolId);
            Property(c => c.ExerciseExaminationPoolId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(exerciseExaminationPool => exerciseExaminationPool.Exercise)
                .WithMany(exercise => exercise.ExerciseExaminationPool)
                .HasForeignKey(exerciseExaminationPool => exerciseExaminationPool.ExerciseId)
                .WillCascadeOnDelete();

            HasRequired(exerciseExaminationPool => exerciseExaminationPool.Examination)
                .WithMany(examination => examination.ExerciseExaminationPool)
                .HasForeignKey(exerciseExaminationPool => exerciseExaminationPool.Examination)
                .WillCascadeOnDelete();
        }
    }
}
