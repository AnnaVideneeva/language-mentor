using System.Collections.Generic;

namespace LanguageMentor.Services.Models
{
    public class Task
    {
        public int TaskId { get; set; }

        public string TaskText { get; set; }

        public int CorrectAnswerId { get; set; }

        public IList<Answer> AnswerChoices { get; set; }
    }
}
