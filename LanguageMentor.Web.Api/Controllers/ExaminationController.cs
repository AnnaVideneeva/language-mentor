using System.Web.Http;
using AutoMapper;
using LanguageMentor.Services.Constants.Enums;
using LanguageMentor.Services.Interfaces;


namespace LanguageMentor.Web.Api.Controllers
{
    public class ExaminationController : ApiController
    {
        private readonly IExaminationService _examinationService;
        private readonly IMapper _mapper;

        public ExaminationController(
            IExaminationService examinationService, 
            IMapper mapper)
        {
            _examinationService = examinationService;
            _mapper = mapper;
        }

        [HttpGet]
        public IHttpActionResult GetDiagnosticExamination()
        {
            var examination = _examinationService.Get(ExaminationTypes.DiagnosticExamination);

            return Ok(examination);
        }

        [HttpPost]
        public IHttpActionResult CheckTest()
        {
            var examination = _examinationService.Get(ExaminationTypes.DiagnosticExamination);

            return Ok(examination);
        }
    }
}
