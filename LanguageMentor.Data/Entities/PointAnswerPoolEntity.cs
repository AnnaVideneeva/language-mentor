namespace LanguageMentor.Data.Entities
{
    public class PointAnswerPoolEntity
    {
        public int PointAnswerPoolId { get; set; }

        public int PointId { get; set; }

        public int AnswerId { get; set; }

        public bool IsCorrectAnswer { get; set; }

        public virtual PointEntity Point { get; set; }

        public virtual AnswerEntity Answer { get; set; }
    }
}