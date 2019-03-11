using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using AutoMapper;
using LanguageMentor.Services.Interfaces;
using LanguageMentor.Services.Models;
using LanguageMentor.Web.Api.Models;

namespace LanguageMentor.Web.Api.Controllers
{
    public class TestsController : ApiController
    {
        private readonly ITestsService _testsService;
        private readonly IMapper _mapper;

        public TestsController(
            ITestsService testsService, 
            IMapper mapper
            )
        {
            _testsService = testsService;
            _mapper = mapper;
        }

        [HttpGet]
        public IHttpActionResult GetDiagnosticTest()
        {
            var tasks = _testsService.GetDiagnosticTest();

            return Ok(tasks.Select(task => _mapper.Map<TaskResponseModel>(task)));
        }

        [HttpPost]
        public IHttpActionResult GetLanguageLevelFromResultOfDiagnosticTest(List<TaskRequestModel> passedTasks)
        {
            var languageLevel = _testsService.GetLanguageLevelFromResultOfDiagnosticTest(
                passedTasks.Select(passedtask => _mapper.Map<Task>(passedtask)));

            return Ok(languageLevel);
        }
    }
}
