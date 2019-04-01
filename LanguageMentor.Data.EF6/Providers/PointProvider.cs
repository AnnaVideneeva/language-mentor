using System.Linq;
using LanguageMentor.Core.Data;
using LanguageMentor.Data.Entities;
using LanguageMentor.Data.Providers;

namespace LanguageMentor.Data.EF6.Providers
{
    public class PointProvider : IPointProvider
    {
        private readonly IUnitOfWork _unitOfWork;

        public PointProvider(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IQueryable<PointEntity> GetByExerciseId(int exerciseId)
        {
            return _unitOfWork.Repository<PointEntity>()
                .GetAsNoTracking()
                .Where(point => point.ExerciseId == exerciseId);
        }
    }
}
