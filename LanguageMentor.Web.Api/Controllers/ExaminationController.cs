using System.Web.Http;
using AutoMapper;
using LanguageMentor.Services.Constants;
using LanguageMentor.Services.Interfaces;
using LanguageMentor.Web.Api.Models;

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

            return Ok(_mapper.Map<ExaminationModel>(examination));
        }

        [HttpPost]
        public IHttpActionResult CheckTest(ExaminationModel examination)
        {
            return Ok(examination);
        }
    }
}
