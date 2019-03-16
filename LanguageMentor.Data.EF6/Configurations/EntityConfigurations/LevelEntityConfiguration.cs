using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using LanguageMentor.Data.Entities;

namespace LanguageMentor.Data.EF6.Configurations.EntityConfigurations
{
    public sealed class LevelEntityConfiguration : EntityTypeConfiguration<LevelEntity>
    {
        public LevelEntityConfiguration()
        {
            ToTable("levels");

            Property(c => c.LevelId).HasColumnName("level_id").IsRequired();
            Property(c => c.LevelName).HasColumnName("level_name").IsRequired();

            HasKey(c => c.LevelId);
            Property(c => c.LevelId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
        }
    }
}
