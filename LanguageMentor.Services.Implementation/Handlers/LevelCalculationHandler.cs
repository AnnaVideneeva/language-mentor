using AutoMapper;
using LanguageMentor.Data.Providers;
using LanguageMentor.Services.Constants;
using LanguageMentor.Services.Interfaces.Handlers;
using LanguageMentor.Services.Models;

namespace LanguageMentor.Services.Implementation.Handlers
{
    public class LevelCalculationHandler : ILevelCalculationHandler
    {
        private readonly IMapper _mapper;
        private readonly ILevelProvider _levelProvider;

        public LevelCalculationHandler(
            IMapper mapper,
            ILevelProvider levelProvider)
        {
            _mapper = mapper;
            _levelProvider = levelProvider;
        }

        public Level CalculateLevel(int correctPointsCount, int allPointsCount)
        {
            var level = correctPointsCount <= allPointsCount * 0.2 ?
                    (int)Levels.A1 :
                    (correctPointsCount <= allPointsCount * 0.4 ?
                    (int)Levels.A2 :
                    (correctPointsCount <= allPointsCount * 0.6 ?
                    (int)Levels.B1 :
                    (correctPointsCount <= allPointsCount * 0.8 ?
                    (int)Levels.B2 :
                    (int)Levels.C1)));

            return _mapper.Map<Level>(_levelProvider.Get(level));
        }
    }
}
