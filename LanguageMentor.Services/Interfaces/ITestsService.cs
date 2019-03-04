using System.Collections.Generic;
using LanguageMentor.Services.Models;

namespace LanguageMentor.Services.Interfaces
{
    /// <summary>
    /// Represents a service for work with tests.
    /// </summary>
    public interface ITestsService
    {
        /// <summary>
        /// Gets a trial test.
        /// </summary>
        /// <returns>A list of tasks.</returns>
        IEnumerable<Task> GetTrialTest();
    }
}
