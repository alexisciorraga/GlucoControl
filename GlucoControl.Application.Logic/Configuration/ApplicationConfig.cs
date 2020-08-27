using GlucoControl.Application.Configuration;
using GlucoControl.Domain.Configuration;
using GlucoControl.Domain.Logic.Configuration;
using GlucoControl.Domain.Logic.Services;
using GlucoControl.Domain.Services;
using Unity;

namespace GlucoControl.Application.Logic.Configuration
{
    public class ApplicationConfig : IApplicationConfig
    {
        public void Configure(IUnityContainer container)
        {
            RegisterDomain(container);

            ConfigureDomain(container);
        }

        private static void RegisterDomain(IUnityContainer container)
        {
            container.RegisterType<IDomainConfig, DomainConfig>();
            container.RegisterType<IAutoMapperDomainContainer, AutoMapperDomainContainer>();
            container.RegisterType<IUserLogic, UserLogic>();
            container.RegisterType<IRoleLogic, RoleLogic>();
            container.RegisterType<IInsulinTypeLogic, InsulinTypeLogic>();
            container.RegisterType<IInsulinLogic, InsulinLogic>();
            container.RegisterType<IControlLogic, ControlLogic>();
        }

        private static void ConfigureDomain(IUnityContainer container)
        {
            IDomainConfig domainConfig = container.Resolve<IDomainConfig>();
            domainConfig.Configure(container);
        }
    }
}