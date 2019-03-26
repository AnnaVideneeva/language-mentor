using LanguageMentor.Services.Constants;
using LanguageMentor.Services.Models;

namespace LanguageMentor.Services.Interfaces
{
    public interface IExaminationService
    {
        Examination Get(int examinationId);

        Examination Get(ExaminationTypes examinationType);

        Level CheckTest(Examination examination);

        void ConvertToFile(int examinationId);

        void ConvertFromFile();
    }
}