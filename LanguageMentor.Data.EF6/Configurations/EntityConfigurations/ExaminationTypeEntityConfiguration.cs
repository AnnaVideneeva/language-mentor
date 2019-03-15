using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using LanguageMentor.Data.Entities;

namespace LanguageMentor.Data.EF6.Configurations.EntityConfigurations
{
    public sealed class ExaminationTypeEntityConfiguration : EntityTypeConfiguration<ExaminationTypeEntity>
    {
        public ExaminationTypeEntityConfiguration()
        {
            ToTable("examination_types");

            Property(c => c.ExaminationTypeId).HasColumnName("examination_type_id").IsRequired();
            Property(c => c.Type).HasColumnName("type").IsRequired().HasMaxLength(256);

            HasKey(c => c.ExaminationTypeId);
            Property(c => c.ExaminationTypeId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
