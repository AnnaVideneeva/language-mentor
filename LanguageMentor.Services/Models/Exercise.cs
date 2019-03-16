using System.Collections.Generic;

namespace LanguageMentor.Services.Models
{
    public class Exercise
    {
        public int ExerciseId { get; set; }

        public string ExerciseText { get; set; }

        public IEnumerable<Point> Points { get; set; }
    }
}