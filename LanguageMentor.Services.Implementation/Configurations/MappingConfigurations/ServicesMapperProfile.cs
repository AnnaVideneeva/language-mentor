using AutoMapper;

namespace LanguageMentor.Services.Implementation.Configurations.MappingConfigurations
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