using System.Collections.Generic;

namespace LanguageMentor.Services.Models
{
    public class Point
    {
        public int PointId { get; set; }

        public string PointText { get; set; }

        public int ExerciseId { get; set; }

        public IList<Answer> AnswerChoices { get; set; }

        public IList<Answer> CorrectAnswers { get; set; }

        public IList<Answer> SelectedAnswers { get; set; }
    }
}