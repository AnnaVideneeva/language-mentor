using System.Collections.Generic;

namespace LanguageMentor.Web.Api.Models
{
    public class TaskResponseModel
    {
        public int TaskId { get; set; }

        public string TaskText { get; set; }

        public IList<AnswerModel> AnswerChoices { get; set; }
    }
}