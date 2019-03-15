using System.Collections.Generic;

namespace LanguageMentor.Services.Models
{
    public class Examination
    {
        public int ExaminationId { get; set; }

        public string Description { get; set; }

        public int ExaminationTypeId { get; set; }

        public IList<Exercise> Exercises { get; set; }
    }
}