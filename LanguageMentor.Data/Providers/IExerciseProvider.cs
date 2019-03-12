using System.Collections.Generic;
using LanguageMentor.Data.Entities;

namespace LanguageMentor.Data.Providers
{
    public interface IExerciseProvider
    {
        IEnumerable<ExerciseEntity> GetByExamination(int examinationId);
    }
}