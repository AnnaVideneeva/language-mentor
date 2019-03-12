using LanguageMentor.Data.Entities;

namespace LanguageMentor.Data.Providers
{
    public interface IExaminationProvider
    {
        ExaminationEntity Find(int id);

        ExaminationEntity GetByExaminationType(int examinationTypeId);
    }
}