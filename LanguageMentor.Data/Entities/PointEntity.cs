using System.Collections.Generic;

namespace LanguageMentor.Data.Entities
{
    public class PointEntity
    {
        public int PointId { get; set; }

        public string PointText { get; set; }

        public int ExerciseId { get; set; }

        public bool IsMultipleChoices { get; set; }

        public virtual ExerciseEntity Exercise { get; set; }

        public virtual ICollection<PointAnswerPoolEntity> PointAnswerPool { get; set; }
    }
}