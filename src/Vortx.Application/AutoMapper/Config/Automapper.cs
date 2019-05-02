using AutoMapper;
using Vortx.Application.AutoMapper.Mapping;

namespace Vortx.Application.AutoMapper.Config
{
    public static class Automapper
    {
        public static MapperConfiguration Bootstrap()
        {
            return new MapperConfiguration(config =>
            {
                config.AddProfile(new ViewToDomain());
                config.AddProfile(new DomainToView());
            });
        }
    }
}
