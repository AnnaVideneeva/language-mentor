using System.Collections.Generic;

namespace LanguageMentor.Services.Models
{
    public class Exercise
    {
        public int ExerciseId { get; set; }

        public string ExerciseText { get; set; }

        public virtual IList<Point> Points { get; set; }
    }
}