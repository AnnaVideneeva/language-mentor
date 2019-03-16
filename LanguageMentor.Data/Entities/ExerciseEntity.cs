using System.Collections.Generic;

namespace LanguageMentor.Data.Entities
{
    public class ExerciseEntity
    {
        public int ExerciseId { get; set; }

        public string ExerciseText { get; set; }

        public int LevelId { get; set; }

        public virtual LevelEntity Level { get; set; }

        public virtual ICollection<PointEntity> Points { get; set; }

        public virtual ICollection<ExerciseExaminationPoolEntity> ExerciseExaminationPool { get; set; }
    }
}
