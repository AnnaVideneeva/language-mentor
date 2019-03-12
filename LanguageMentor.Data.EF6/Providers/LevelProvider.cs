using System.Collections.Generic;
using LanguageMentor.Core.Data;
using LanguageMentor.Data.Entities;
using LanguageMentor.Data.Providers;

namespace LanguageMentor.Data.EF6.Providers
{
    public class LevelProvider : ILevelProvider
    {
        private readonly IUnitOfWork _unitOfWork;

        public LevelProvider(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public LevelEntity Get(int id)
        {
            return _unitOfWork.Repository<LevelEntity>().Find(id);
        }
    }
}