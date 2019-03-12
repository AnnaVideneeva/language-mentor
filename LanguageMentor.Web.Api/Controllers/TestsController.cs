﻿using System.Web.Http;
using AutoMapper;
using LanguageMentor.Services.Constants.Enums;
using LanguageMentor.Services.Interfaces;


namespace LanguageMentor.Web.Api.Controllers
{
    public class TestsController : ApiController
    {
        private readonly IExaminationService _examinationService;
        private readonly IMapper _mapper;

        public TestsController(
            IExaminationService examinationService, 
            IMapper mapper
            )
        {
            _examinationService = examinationService;
            _mapper = mapper;
        }

        [HttpGet]
        public IHttpActionResult GetDiagnosticExamination()
        {
            var examination = _examinationService.Get(ExaminationTypes.DiagnosticTest);

            return Ok(examination);
        }
    }
}
