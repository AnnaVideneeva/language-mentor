using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using LanguageMentor.Data.Entities;

namespace LanguageMentor.Data.EF6.Configurations.EntityConfigurations
{
    public sealed class AnswerEntityConfiguration : EntityTypeConfiguration<AnswerEntity>
    {
        public AnswerEntityConfiguration()
        {
            ToTable("answers");

            Property(c => c.AnswerId).HasColumnName("answer_id").IsRequired();
            Property(c => c.AnswerText).HasColumnName("answer_text").IsRequired().HasMaxLength(256);

            HasKey(c => c.AnswerId);
            Property(c => c.AnswerId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
