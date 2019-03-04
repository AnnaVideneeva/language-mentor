using System.Collections.Generic;

namespace LanguageMentor.Services.Models
{
    /// <summary>
    /// Represents a model for task.
    /// </summary>
    public class Task
    {
        /// <summary>
        /// Gets or sets task ID.
        /// </summary>
        public int TaskId { get; set; }

        /// <summary>
        /// Gets or sets task.
        /// </summary>
        public string TaskText { get; set; }

        /// <summary>
        /// Gets or sets correct answer ID.
        /// </summary>
        public int CorrectAnswerId { get; set; }

        /// <summary>
        /// Gets or sets selected answer ID.
        /// </summary>
        public int SelectedAnswerId { get; set; }

        /// <summary>
        /// Gets or sets a list of answer choices.
        /// </summary>
        public IList<Answer> AnswerChoices { get; set; }
    }
}
