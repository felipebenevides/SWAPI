using SimpleInjector;
using SWAPI.Application.Services;
using SWAPI.Data.Repository;
using SWAPI.Domain.Interfaces.Interface;
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

            //domain layer
            container.Register<IPeopleRepository, PeopleRepository>(Lifestyle.Scoped);
        }
    }
}
