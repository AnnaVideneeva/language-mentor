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
        /// Gets a diagnostic test.
        /// </summary>
        /// <returns> A list of tasks of diagnostic test.</returns>
        IEnumerable<Task> GetDiagnosticTest();

        /// <summary>
        /// Get a language level of passed diagnostic test.
        /// </summary>
        /// <param name="passedTest">A tasks with selected answers.</param>
        /// <returns>A language level.</returns>
        LanguageLevel GetLanguageLevelFromResultOfDiagnosticTest(IEnumerable<Task> passedTest);
    }
}
