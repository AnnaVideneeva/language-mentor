using System.Linq;
using LanguageMentor.Core.Data;
using LanguageMentor.Data.Entities;
using LanguageMentor.Data.Providers;

namespace LanguageMentor.Data.EF6.Providers
{
    public class ExaminationProvider : IExaminationProvider
    {
        private readonly IUnitOfWork _unitOfWork;

        public ExaminationProvider(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ExaminationEntity Find(int id)
        {
            return _unitOfWork.Repository<ExaminationEntity>().Find(id);
        }

        public ExaminationEntity GetByExaminationType(int examinationTypeId)
        {
            return _unitOfWork.Repository<ExaminationEntity>()
                .Search(ex => ex.ExaminationTypeId == examinationTypeId).FirstOrDefault();
        }
    }
}