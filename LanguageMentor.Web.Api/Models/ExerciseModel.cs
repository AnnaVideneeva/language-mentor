using System.Collections.Generic;

namespace LanguageMentor.Web.Api.Models
{
    public class ExerciseModel
    {
        public int ExerciseId { get; set; }

        public string ExerciseText { get; set; }

        public virtual IList<PointModel> Points { get; set; }
    }
}