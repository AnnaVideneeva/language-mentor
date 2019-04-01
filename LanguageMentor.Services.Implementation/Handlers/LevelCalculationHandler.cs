using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using LanguageMentor.Data.Providers;
using LanguageMentor.Services.Constants;
using LanguageMentor.Services.Interfaces.Handlers;
using LanguageMentor.Services.Models;

namespace LanguageMentor.Services.Implementation.Handlers
{
    public class LevelCalculationHandler : ILevelCalculationHandler
    {
        private const double DivisionValue = 0.166;

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
            var division = allPointsCount * DivisionValue;

            var resultsTable = new Dictionary<Func<double, bool>, Func<Levels>> {
                { x => x <= division, () => Levels.A1 },
                { x => x > division && x <= division * 2, () => Levels.A2 },
                { x => x > division * 2 && x <= division * 3, () => Levels.B1 },
                { x => x > division * 3 && x <= division * 4, () => Levels.B2 },
                { x => x > division * 4 && x <= division * 5, () => Levels.C1 },
                { x => x > division * 5 && x <= division * 6, () => Levels.C2 }
            };

            var level = resultsTable.First(result 
                => result.Key((double)correctPointsCount / allPointsCount)).Value();

            return _mapper.Map<Level>(_levelProvider.Get((int)level));
        }
    }
}
