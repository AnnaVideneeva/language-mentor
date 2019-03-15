using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using LanguageMentor.Data.Entities;

namespace LanguageMentor.Data.EF6.Configurations.EntityConfigurations
{
    public sealed class ExaminationEntityConfiguration : EntityTypeConfiguration<ExaminationEntity>
    {
        public ExaminationEntityConfiguration()
        {
            ToTable("examinations");

            Property(c => c.ExaminationId).HasColumnName("examination_id").IsRequired();
            Property(c => c.Description).HasColumnName("description").IsRequired().HasMaxLength(256);
            Property(c => c.ExaminationTypeId).HasColumnName("examination_type_id").IsRequired();

            HasKey(c => c.ExaminationId);
            Property(c => c.ExaminationId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(examination => examination.ExaminationType)
                .WithMany(examinationType => examinationType.Examinations)
                .HasForeignKey(examination => examination.ExaminationTypeId)
                .WillCascadeOnDelete();
        }
    }
}
