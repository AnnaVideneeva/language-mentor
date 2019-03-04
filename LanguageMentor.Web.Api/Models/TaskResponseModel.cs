using System.Collections.Generic;

namespace LanguageMentor.Web.Api.Models
{
    public class TaskResponseModel
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
        /// Gets or sets a list of answer choices.
        /// </summary>
        public IList<AnswerModel> AnswerChoices { get; set; }
    }
}