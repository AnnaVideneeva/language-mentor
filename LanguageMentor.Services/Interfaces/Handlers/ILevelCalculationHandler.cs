using LanguageMentor.Services.Models;

namespace LanguageMentor.Services.Interfaces.Handlers
{
    public interface ILevelCalculationHandler
    {
        Level CalculateLevel(int correctPointsCount, int allPointsCount);
    }
}
