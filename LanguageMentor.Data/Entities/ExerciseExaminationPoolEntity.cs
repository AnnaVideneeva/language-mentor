namespace LanguageMentor.Data.Entities
{
    public class ExerciseExaminationPoolEntity
    {
        public int ExerciseExaminationPoolId { get; set; }

        public int ExerciseId { get; set; }

        public int ExaminationId { get; set; }

        public virtual ExerciseEntity Exercise { get; set; }

        public virtual ExaminationEntity Examination { get; set; }
    }
}
