using GlucoControl.Domain.Configuration;
using GlucoControl.Repository.Interfaces;
using GlucoControl.Repository.Repositories;
using Unity;

namespace GlucoControl.Domain.Logic.Configuration
{
    public class DomainConfig : IDomainConfig
    {
        public void Configure(IUnityContainer container)
        {
            container.RegisterType<IAutoMapperDomainContainer, AutoMapperDomainContainer>();

            RegisterRepository(container);
        }

        private void RegisterRepository(IUnityContainer container)
        {
            container.RegisterType<IControlRepository, ControlRepository>();
            container.RegisterType<IInsulinRepository, InsulinRepository>();
            container.RegisterType<IInsulinTypeRepository, InsulinTypeRepository>();
            container.RegisterType<IRoleRepository, RoleRepository>();
            container.RegisterType<IUserRepository, UserRepository>();
        }
    }
}