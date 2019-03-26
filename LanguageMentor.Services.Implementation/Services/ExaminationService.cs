using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using LanguageMentor.Data.Providers;
using LanguageMentor.Services.Constants;
using LanguageMentor.Services.Interfaces;
using LanguageMentor.Services.Interfaces.Converters;
using LanguageMentor.Services.Interfaces.Handlers;
using LanguageMentor.Services.Models;

namespace LanguageMentor.Services.Implementation.Services
{
    public class ExaminationService : IExaminationService
    {
        private readonly IMapper _mapper;
        private readonly IExaminationProvider _examinationProvider;
        private readonly IExerciseProvider _exerciseProvider;
        private readonly IPointProvider _pointProvider;
        private readonly IAnswerProvider _answerProvider;
        private readonly ILevelProvider _levelProvider;
        private readonly IExaminationFileSerializer _examinationFileSerializer;
        private readonly ILevelCalculationHandler _levelCalculationHandler;

        public ExaminationService(
            IMapper mapper,
            IExaminationProvider examinationProvider,
            IExerciseProvider exerciseProvider,
            IPointProvider pointProvider,
            IAnswerProvider answerProvider,
            ILevelProvider levelProvider,
            IExaminationFileSerializer examinationFileSerializer,
            ILevelCalculationHandler levelCalculationHandler)
        {
            _mapper = mapper;
            _examinationProvider = examinationProvider;
            _exerciseProvider = exerciseProvider;
            _pointProvider = pointProvider;
            _answerProvider = answerProvider;
            _levelProvider = levelProvider;
            _examinationFileSerializer = examinationFileSerializer;
            _levelCalculationHandler = levelCalculationHandler;
        }

        public Level CheckTest(Examination examination)
        {
            int allPointsCount = 0;
            int correctPointsCount = 0;

            foreach (var exercise in examination.Exercises)
            {
                foreach (var point in exercise.Points)
                {
                    var correctAnswersEntities = _answerProvider.GetCorrectAnswers(point.PointId);
                    point.CorrectAnswers = _mapper.Map<IList<Answer>>(correctAnswersEntities);

                    if (point.SelectedAnswers == point.CorrectAnswers)
                    {
                        correctPointsCount++;
                    }

                    allPointsCount++;
                }
            }

            return _levelCalculationHandler.CalculateLevel(correctPointsCount, allPointsCount);
        }

        public void ConvertFromFile()
        {
            var examination = _examinationFileSerializer.Deserialize();
            Add(examination);
        }

        public void ConvertToFile(int examinationId)
        {
            var examination = Get(examinationId);
            _examinationFileSerializer.Serialize(examination);
        }

        public void Add(Examination examination)
        {
            
        }

        public Examination Get(ExaminationTypes examinationType)
        {
            var examinationEntity = _examinationProvider.GetByExaminationType((int)examinationType);
            var examination = _mapper.Map<Examination>(examinationEntity);

            AddExaminationInfo(examination);

            return examination;
        }

        public Examination Get(int examinationId)
        {
            var examinationEntity = _examinationProvider.Find(examinationId);
            var examination = _mapper.Map<Examination>(examinationEntity);

            AddExaminationInfo(examination);

            return examination;
        }

        private void AddExaminationInfo(Examination examination)
        {
            var exerciseEntities = _exerciseProvider.GetByExamination(examination.ExaminationId);
            examination.Exercises = _mapper.Map<IList<Exercise>>(exerciseEntities).ToList();

            foreach (var exercise in examination.Exercises)
            {
                var pointEntities = _pointProvider.GetByExerciseId(exercise.ExerciseId);
                exercise.Points = _mapper.Map<IList<Point>>(pointEntities).ToList();

                foreach (var point in exercise.Points)
                {
                    var answerChoicesEntities = _answerProvider.GetAnswerChoices(point.PointId);
                    point.AnswerChoices = _mapper.Map<IList<Answer>>(answerChoicesEntities).ToList();
                }
            }
        }
    }
}