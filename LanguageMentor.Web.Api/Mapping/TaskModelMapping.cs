using AutoMapper;
using LanguageMentor.Services.Models;
using LanguageMentor.Web.Api.Models;

namespace LanguageMentor.Web.Api.Mapping
{
    public class TaskModelMapping
    {
        public static void CreateMap(IProfileExpression mapperProfile)
        {
            ToServiceModel(mapperProfile);
            ToWebModel(mapperProfile);
        }

        private static void ToServiceModel(IProfileExpression mapper)
        {
            mapper.CreateMap<TaskRequestModel, Task>();
        }

        private static void ToWebModel(IProfileExpression mapper)
        {
            mapper.CreateMap<Task, TaskResponseModel>();
        }
    }
}