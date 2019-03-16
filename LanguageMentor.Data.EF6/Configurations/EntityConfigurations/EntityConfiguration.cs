using System.Data.Entity;

namespace LanguageMentor.Data.EF6.Configurations.EntityConfigurations
{
    public static class EntityConfiguration
    {
        public static void ConfigureEntities(this DbModelBuilder modelBuilder)
        {
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
