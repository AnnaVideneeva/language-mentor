using System.Linq;
using LanguageMentor.Core.Data;
using LanguageMentor.Data.Entities;
using LanguageMentor.Data.Providers;

namespace LanguageMentor.Data.EF6.Providers
{
    public class AnswerProvider : IAnswerProvider
    {
        private readonly IUnitOfWork _unitOfWork;

        public AnswerProvider(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddRange(IQueryable<AnswerEntity> entities)
        {
            _unitOfWork.Repository<AnswerEntity>()
                .AddRange(entities);

            _unitOfWork.SaveChanges();
        }

        public IQueryable<AnswerEntity> GetAnswerChoices(int pointId)
        {
            return _unitOfWork.Repository<PointAnswerPoolEntity>()
                .GetAsNoTracking()
                .Join(
                    _unitOfWork.Repository<AnswerEntity>().GetAsNoTracking(),
                    pointAnswerPool => pointAnswerPool.AnswerId,
                    answer => answer.AnswerId,
                    (pointAnswerPool, answer) => new
                    {
                        pointAnswerPool,
                        answer
                    })
                .Where(join => join.pointAnswerPool.PointId == pointId)
                .Select(join => join.answer);
        }
        
        public IQueryable<AnswerEntity> GetCorrectAnswers(int pointId)
        {
            return _unitOfWork.Repository<PointAnswerPoolEntity>()
                .GetAsNoTracking()
                .Join(
                    _unitOfWork.Repository<AnswerEntity>().GetAsNoTracking(),
                    pointAnswerPool => pointAnswerPool.AnswerId,
                    answer => answer.AnswerId,
                    (pointAnswerPool, answer) => new
                    {
                        pointAnswerPool,
                        answer
                    })
                .Where(join => join.pointAnswerPool.PointId == pointId
                    && join.pointAnswerPool.IsCorrectAnswer)
                .Select(join => join.answer);
        }
    }
}