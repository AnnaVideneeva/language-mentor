using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using LanguageMentor.Data.Entities;

namespace LanguageMentor.Data.EF6.Configurations.EntityConfigurations
{
    public sealed class AnswerEntityConfig : EntityTypeConfiguration<AnswerEntity>
    {
        public AnswerEntityConfig()
        {
            ToTable("answers");

            Property(c => c.AnswerId).HasColumnName("answer_id").IsRequired();
            Property(c => c.AnswerText).HasColumnName("answer_text").IsRequired().HasMaxLength(256);

            HasKey(c => c.AnswerId);
            Property(c => c.AnswerId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
