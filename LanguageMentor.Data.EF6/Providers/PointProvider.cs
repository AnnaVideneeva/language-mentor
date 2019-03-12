using LanguageMentor.Core.Data;
using LanguageMentor.Data.Entities;
using LanguageMentor.Data.Providers;
using System.Collections.Generic;

namespace LanguageMentor.Data.EF6.Providers
{
    public class PointProvider : IPointProvider
    {
        private readonly IUnitOfWork _unitOfWork;

        public PointProvider(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<PointEntity> GetByExerciseId(int exerciseId)
        {
            return _unitOfWork.Repository<PointEntity>().Search(point => point.ExerciseId == exerciseId);
        }
    }
}
