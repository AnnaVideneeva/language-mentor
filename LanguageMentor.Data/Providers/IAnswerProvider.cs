using System.Linq;
using LanguageMentor.Data.Entities;

namespace LanguageMentor.Data.Providers
{
    public interface IAnswerProvider
    {
        IQueryable<AnswerEntity> GetAnswerChoices(int pointId);

        IQueryable<AnswerEntity> GetCorrectAnswers(int pointId);
    }
}
