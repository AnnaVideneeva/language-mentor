using System;
using System.Collections.Generic;
using AutoMapper;
using LanguageMentor.Data.Providers;
using LanguageMentor.Services.Constants;
using LanguageMentor.Services.Interfaces;
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

        public ExaminationService(
            IMapper mapper,
            IExaminationProvider examinationProvider,
            IExerciseProvider exerciseProvider,
            IPointProvider pointProvider,
            IAnswerProvider answerProvider,
            ILevelProvider levelProvider)
        {
            _mapper = mapper;
            _examinationProvider = examinationProvider;
            _exerciseProvider = exerciseProvider;
            _pointProvider = pointProvider;
            _answerProvider = answerProvider;
            _levelProvider = levelProvider;
        }

        public Level CheckTest(Examination examination)
        {
            int allPointCount = 0;
            int correctPointCount = 0;
            int level = (int)Levels.A1;

            foreach (var exercise in examination.Exercises)
            {
                foreach (var point in exercise.Points)
                {
                    var correctAnswersEntities = _answerProvider.GetCorrectAnswers(point.PointId);
                    point.CorrectAnswers = _mapper.Map<IList<Answer>>(correctAnswersEntities);

                    if (point.SelectedAnswers == point.CorrectAnswers)
                    {
                        correctPointCount++;
                    }

                    allPointCount++;
                }

                level = correctPointCount <= allPointCount * 0.2 ?
                    (int)Levels.A1 :
                    (correctPointCount <= allPointCount * 0.4 ?
                    (int)Levels.A2 :
                    (correctPointCount <= allPointCount * 0.6 ?
                    (int)Levels.B1 :
                    (correctPointCount <= allPointCount * 0.8 ?
                    (int)Levels.B2 :
                    (int)Levels.C1)));
            }

            return _mapper.Map<Level>(_levelProvider.Get(level));
        }

        public Examination Get(ExaminationTypes examinationType)
        {
            throw new Exception();

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