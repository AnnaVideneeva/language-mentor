namespace LanguageMentor.Web.Api.Models
{
    /// <summary>
    /// Represents a request model for task.
    /// </summary>
    public class TaskRequestModel
    {
        /// <summary>
        /// Gets or sets task ID.
        /// </summary>
        public int TaskId { get; set; }

        /// <summary>
        /// Gets or sets selected answer ID.
        /// </summary>
        public int SelectedAnswerId { get; set; }
    }
}