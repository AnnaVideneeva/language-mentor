using System.Collections.Generic;

namespace LanguageMentor.Web.Api.Models
{
    public class PointModel
    {
        public int PointId { get; set; }

        public string PointText { get; set; }

        public int ExerciseId { get; set; }

        public IList<AnswerModel> AnswerChoices { get; set; }

        public IList<AnswerModel> SelectedAnswers { get; set; }

        public bool IsMultipleChoices { get; set; }
    }
}