using System.Collections.Generic;

namespace LanguageMentor.Web.Api.Models
{
    public class ExaminationModel
    {
        public int ExaminationId { get; set; }

        public string Description { get; set; }

        public int ExaminationTypeId { get; set; }

        public IList<ExerciseModel> Exercises { get; set; }
    }
}