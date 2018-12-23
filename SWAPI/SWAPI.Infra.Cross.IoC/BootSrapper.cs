using SimpleInjector;
using SWAPI.Application.Services;
using SWAPI.Domain.Interfaces.Service;
using SWAPI.Domain.Services;

namespace SWAPI.Infra.Cross.IoC
{
    public class BootSrapper
    {
        public static void RegisterServices(Container container)
        {
            //Application Layer

            container.Register<IPeopleAppService, PeopleAppService>(Lifestyle.Scoped);

            //Services Layer
            container.Register<IPeopleService, PeopleService>(Lifestyle.Scoped);
        }
    }
}
