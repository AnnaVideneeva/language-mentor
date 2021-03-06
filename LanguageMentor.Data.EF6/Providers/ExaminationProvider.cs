﻿using System.Linq;
using LanguageMentor.Core.Data;
using LanguageMentor.Data.Entities;
using LanguageMentor.Data.Providers;

namespace LanguageMentor.Data.EF6.Providers
{
    public class ExaminationProvider : IExaminationProvider
    {
        private readonly IUnitOfWork _unitOfWork;

        public ExaminationProvider(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ExaminationEntity Find(int id)
        {
            return _unitOfWork.Repository<ExaminationEntity>()
                .GetAsNoTracking()
                .FirstOrDefault(examination => examination.ExaminationId == id);
        }

        public ExaminationEntity GetByExaminationType(int examinationTypeId)
        {
            return _unitOfWork.Repository<ExaminationEntity>()
                .GetAsNoTracking()
                .FirstOrDefault(examination => examination.ExaminationTypeId == examinationTypeId);
        }
    }
}