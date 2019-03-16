using System.Collections.Generic;

namespace LanguageMentor.Data.Entities
{
    public class AnswerEntity
    {
        public int AnswerId { get; set; }

        public string AnswerText { get; set; }

        public virtual ICollection<PointAnswerPoolEntity> PointAnswerPool { get; set; }
    }
}