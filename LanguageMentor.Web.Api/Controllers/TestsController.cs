using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using AutoMapper;
using LanguageMentor.Services.Interfaces;
using LanguageMentor.Services.Models;
using LanguageMentor.Web.Api.Models;

namespace LanguageMentor.Web.Api.Controllers
{
    /// <summary>
    /// Represents a controller for work with tests.
    /// </summary>
    public class TestsController : ApiController
    {
        private readonly ITestsService _testsService;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="TestsController"/> class.
        /// </summary>
        /// <param name="testsService">The tests service.</param>
        public TestsController(
            ITestsService testsService, 
            IMapper mapper
            )
        {
            _testsService = testsService;
            _mapper = mapper;
        }

        /// <summary>
        /// Gets a diagnostic test.
        /// </summary>
        /// <returns>A diagnostic test.</returns>
        [HttpGet]
        public IHttpActionResult GetDiagnosticTest()
        {
            var tasks = _testsService.GetDiagnosticTest();

            return Ok(tasks.Select(task => _mapper.Map<TaskResponseModel>(task)));
        }

        /// <summary>
        /// Gets a language level from result of a diagnostic test.
        /// </summary>
        /// <returns>A language level.</returns>
        [HttpPost]
        public IHttpActionResult GetLanguageLevelFromResultOfDiagnosticTest(List<TaskRequestModel> passedTasks)
        {
            var languageLevel = _testsService.GetLanguageLevelFromResultOfDiagnosticTest(
                passedTasks.Select(passedtask => _mapper.Map<Task>(passedtask)));

            return Ok(languageLevel);
        }
    }
}
