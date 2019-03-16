using System.Linq;
using LanguageMentor.Data.Entities;

namespace LanguageMentor.Data.Providers
{
    public interface IExerciseProvider
    {
        IQueryable<ExerciseEntity> GetByExamination(int examinationId);
    }
}