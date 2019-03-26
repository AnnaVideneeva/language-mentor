using LanguageMentor.Services.Models;

namespace LanguageMentor.Services.Interfaces.Converters
{
    public interface IExaminationFileSerializer
    {
        void Serialize(Examination examination);

        Examination Deserialize();
    }
}
