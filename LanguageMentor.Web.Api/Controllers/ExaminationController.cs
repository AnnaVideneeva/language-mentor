using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using AutoMapper;
using LanguageMentor.Services.Constants;
using LanguageMentor.Services.Interfaces;
using LanguageMentor.Services.Models;
using LanguageMentor.Web.Api.Filters;
using LanguageMentor.Web.Api.Models;

namespace LanguageMentor.Web.Api.Controllers
{
    [ExaminationExceptionFilter]
    [RoutePrefix("api/examinations")]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
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
        [Route("{examinationType:int:min(0)}")]
        public IHttpActionResult GetExamination(int examinationType)
        {
            var examination = _examinationService.Get((ExaminationTypes)examinationType);

            return Ok(_mapper.Map<ExaminationModel>(examination));
        }

        [HttpPost]
        public IHttpActionResult CheckTest(ExaminationModel examination)
        {
            var level = _examinationService.CheckTest(_mapper.Map<Examination>(examination));

            return Ok(level);
        }

        [HttpGet]
        [Route("converting/{examinationId:int:min(0)}")]
        public async Task<IHttpActionResult> ConvertToFile(int examinationId)
        {
            _examinationService.ConvertToFile(examinationId);
            return Ok();
        }
    }
}
