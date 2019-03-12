using System.Collections.Generic;
using LanguageMentor.Data.Entities;

namespace LanguageMentor.Data.Providers
{
    public interface IPointProvider
    {
        IEnumerable<PointEntity> GetByExerciseId(int exerciseId);
    }
}