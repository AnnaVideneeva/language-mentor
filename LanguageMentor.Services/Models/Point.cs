using System.Collections.Generic;

namespace LanguageMentor.Services.Models
{
    public class Point
    {
        public int PointId { get; set; }

        public string PointText { get; set; }

        public int ExerciseId { get; set; }

        public IEnumerable<Answer> AnswerChoices { get; set; }

        public IEnumerable<Answer> CorrectAnswers { get; set; }

        public IEnumerable<Answer> SelectedAnswers { get; set; }
    }
}