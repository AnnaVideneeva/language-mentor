using System.Collections.Generic;

namespace LanguageMentor.Data.Entities
{
    public class ExaminationTypeEntity
    {
        public int ExaminationTypeId { get; set; }

        public string Type { get; set; }

        public virtual ICollection<ExaminationEntity> Examinations { get; set; }
    }
}
