using AutoMapper;

namespace LanguageMentor.Services.Logic.Configurations.MappingConfigurations
{
    public class ServicesMapperProfile : Profile
    {
        public ServicesMapperProfile()
        {
            ExaminationMapping.CreateMap(this);
            ExerciseMapping.CreateMap(this);
            PointMapping.CreateMap(this);
            AnswerMapping.CreateMap(this);
        }
    }
}