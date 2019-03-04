using System.Web.Http;
using LanguageMentor.Services.Interfaces;

namespace LanguageMentor.Web.Api.Controllers
{
    /// <summary>
    /// Represents a controller for work with tests.
    /// </summary>
    public class TestsController : ApiController
    {
        private readonly ITestsService _testsService;

        /// <summary>
        /// Initializes a new instance of the <see cref="TestsController"/> class.
        /// </summary>
        /// <param name="testsService">The tests service.</param>
        public TestsController(ITestsService testsService)
        {
            _testsService = testsService;
        }

        /// <summary>
        /// Gets a trial test.
        /// </summary>
        /// <returns>A trial test.</returns>
        public IHttpActionResult GetTrialTest()
        {
            var test = _testsService.GetTrialTest();

            return Ok(test);
        }
    }
}
