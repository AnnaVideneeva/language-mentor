using LanguageMentor.Data.Entities;

namespace LanguageMentor.Data.Providers
{
    public interface ILevelProvider
    {
        LevelEntity Get(int id);
    }
}