using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using LanguageMentor.Data.Entities;

namespace LanguageMentor.Data.EF6.Configurations.EntityConfigurations
{
    public sealed class PointAnswerPoolEntityConfig : EntityTypeConfiguration<PointAnswerPoolEntity>
    {
        public PointAnswerPoolEntityConfig()
        {
            ToTable("point_answer_pool");

            Property(c => c.PointAnswerPoolId).HasColumnName("point_answer_pool_id").IsRequired();
            Property(c => c.PointId).HasColumnName("point_id").IsRequired();
            Property(c => c.AnswerId).HasColumnName("answer_id").IsRequired();
            Property(c => c.IsCorrectAnswer).HasColumnName("is_correct_answer").IsRequired();

            HasKey(c => c.PointAnswerPoolId);
            Property(c => c.PointAnswerPoolId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(pointAnswerPool => pointAnswerPool.Answer)
                .WithMany(answer => answer.PointAnswerPool)
                .HasForeignKey(pointAnswerPool => pointAnswerPool.AnswerId)
                .WillCascadeOnDelete();

            HasRequired(pointAnswerPool => pointAnswerPool.Point)
                .WithMany(point => point.PointAnswerPool)
                .HasForeignKey(pointAnswerPool => pointAnswerPool.PointId)
                .WillCascadeOnDelete();
        }
    }
}
