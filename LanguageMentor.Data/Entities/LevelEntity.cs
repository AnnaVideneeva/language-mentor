using System.Collections.Generic;

namespace LanguageMentor.Data.Entities
{
    public class LevelEntity
    {
        public int LevelId { get; set; }

        public string LevelName { get; set; }

        public virtual ICollection<ExerciseEntity> Exercises { get; set; }
    }
}