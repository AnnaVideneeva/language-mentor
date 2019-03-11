﻿using System.Collections.Generic;
using LanguageMentor.Services.Interfaces;
using LanguageMentor.Services.Models;

namespace LanguageMentor.Services.Logic.Services
{
    public class TestsService : ITestsService
    {
        public IEnumerable<Task> GetDiagnosticTest()
        {
            return new List<Task>()
            {
                new Task()
                {
                    TaskId = 1,
                    TaskText = "We use the present simple tense when ...",
                    CorrectAnswerId = 1,
                    AnswerChoices = new List<Answer>()
                    {
                        new Answer()
                        {
                            AnswerId = 1,
                            AnswerText = "... we want to talk about fixed habits or routines – things that don’t change."
                        },
                        new Answer()
                        {
                            AnswerId = 2,
                            AnswerText = "... we want to talk about actions which are happening at the present moment, but will soon finish."
                        }
                    }
                },
                new Task()
                {
                    TaskId = 2,
                    TaskText = "We use the present continuous tense when ...",
                    CorrectAnswerId = 2,
                    AnswerChoices = new List<Answer>()
                    {
                        new Answer()
                        {
                            AnswerId = 1,
                            AnswerText = "... we want to talk about fixed habits or routines – things that don’t change."
                        },
                        new Answer()
                        {
                            AnswerId = 2,
                            AnswerText = "... we want to talk about actions which are happening at the present moment, but will soon finish."
                        }
                    }
                }
            };
        }

        public LanguageLevel GetLanguageLevelFromResultOfDiagnosticTest(IEnumerable<Task> passedTest)
        {
            return new LanguageLevel()
            {
                LanguageLevelId = 1,
                LevelTitle = "B1",
            };
        }
    }
}