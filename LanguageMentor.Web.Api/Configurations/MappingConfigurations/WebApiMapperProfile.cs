using AutoMapper;

namespace LanguageMentor.Web.Api.Mapping
{
    public class WebApiMapperProfile : Profile
    {
        public WebApiMapperProfile()
        {
            TaskModelMapping.CreateMap(this);
            AnswerModelMapping.CreateMap(this);
        }
    }
}