using System.Linq;
using LanguageMentor.Core.Data;
using LanguageMentor.Data.Entities;
using LanguageMentor.Data.Providers;

namespace LanguageMentor.Data.EF6.Providers
{
    public class ExerciseProvider : IExerciseProvider
    {
        private readonly IUnitOfWork _unitOfWork;

        public ExerciseProvider(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IQueryable<ExerciseEntity> GetByExamination(int examinationId)
        {
            return _unitOfWork.Repository<ExerciseEntity>().GetAsNoTracking()
                .Join(
                    _unitOfWork.Repository<ExerciseExaminationPoolEntity>().GetAsNoTracking(),
                    exercise => exercise.ExerciseId,
                    exerciseExaminationPool => exerciseExaminationPool.ExerciseId,
                    (exercise, exerciseExaminationPool) => new
                    {
                        exercise,
                        exerciseExaminationPool
                    })
                .Where(join => join.exerciseExaminationPool.ExaminationId == examinationId)
                .Select(join => join.exercise);
        }
    }
}
