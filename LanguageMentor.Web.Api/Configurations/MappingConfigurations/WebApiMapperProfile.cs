using AutoMapper;
using LanguageMentor.Web.Api.Configurations.MappingConfigurations;

namespace LanguageMentor.Web.Api.Mapping
{
    public class WebApiMapperProfile : Profile
    {
        public WebApiMapperProfile()
        {
            ExaminationModelMapping.CreateMap(this);
            ExerciseModelMapping.CreateMap(this);
            PointModelMapping.CreateMap(this);
            AnswerModelMapping.CreateMap(this);
        }
    }
}