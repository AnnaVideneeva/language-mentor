using System.Linq;
using LanguageMentor.Data.Entities;

namespace LanguageMentor.Data.Providers
{
    public interface IPointProvider
    {
        IQueryable<PointEntity> GetByExerciseId(int exerciseId);
    }
}