using System.Collections.Generic;

namespace LanguageMentor.Data.Entities
{
    public class ExaminationEntity
    {
        public int ExaminationId { get; set; }

        public string Description { get; set; }

        public int ExaminationTypeId { get; set; }

        public ExaminationTypeEntity ExaminationType { get; set; }

        public virtual ICollection<ExerciseExaminationPoolEntity> ExerciseExaminationPool { get; set; }
    }
}