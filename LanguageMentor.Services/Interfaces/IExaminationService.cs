using LanguageMentor.Services.Constants;
using LanguageMentor.Services.Models;

namespace LanguageMentor.Services.Interfaces
{
    public interface IExaminationService
    {
        Examination Get(ExaminationTypes examinationType);

        Level CheckTest(Examination examination);
    }
}