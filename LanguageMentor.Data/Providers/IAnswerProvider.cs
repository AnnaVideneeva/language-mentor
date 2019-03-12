using System.Collections.Generic;
using LanguageMentor.Data.Entities;

namespace LanguageMentor.Data.Providers
{
    public interface IAnswerProvider
    {
        IEnumerable<AnswerEntity> GetAnswerChoices(int pointId);

        IEnumerable<AnswerEntity> GetCorrectAnswers(int pointId);
    }
}
