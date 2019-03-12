using System.Collections.Generic;
using AutoMapper;
using LanguageMentor.Data.Providers;
using LanguageMentor.Services.Constants.Enums;
using LanguageMentor.Services.Interfaces;
using LanguageMentor.Services.Models;

namespace LanguageMentor.Services.Logic.Services
{
    public class ExaminationService : IExaminationService
    {
        private readonly IMapper _mapper;
        private readonly IExaminationProvider _examinationProvider;
        private readonly IExerciseProvider _exerciseProvider;
        private readonly IPointProvider _pointProvider;
        private readonly IAnswerProvider _answerProvider;

        public ExaminationService(
            IMapper mapper,
            IExaminationProvider examinationProvider,
            IExerciseProvider exerciseProvider,
            IPointProvider pointProvider,
            IAnswerProvider answerProvider)
        {
            _mapper = mapper;
            _examinationProvider = examinationProvider;
            _exerciseProvider = exerciseProvider;
            _pointProvider = pointProvider;
            _answerProvider = answerProvider;
        }

        public Examination Get(ExaminationTypes examinationType)
        {
            var examinationEntity = _examinationProvider.GetByExaminationType((int)examinationType);
            var examination = _mapper.Map<Examination>(examinationEntity);

            var exerciseEntities = _exerciseProvider.GetByExamination(examination.ExaminationId);
            examination.Exercises = _mapper.Map<IList<Exercise>>(exerciseEntities);

            foreach(var exercise in examination.Exercises)
            {
                var pointEntities = _pointProvider.GetByExerciseId(exercise.ExerciseId);
                exercise.Points = _mapper.Map<IList<Point>>(pointEntities);

                foreach (var point in exercise.Points)
                {
                    var answerChoicesEntities = _answerProvider.GetAnswerChoices(point.PointId);
                    point.AnswerChoices = _mapper.Map<IList<Answer>>(answerChoicesEntities);
                }
            }

            return examination;
        }
    }
}