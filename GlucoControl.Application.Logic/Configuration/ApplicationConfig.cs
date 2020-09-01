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
            container.RegisterType<IControlLogic, ControlLogic>();
            container.RegisterType<IInsulinLogic, InsulinLogic>();
            container.RegisterType<IInsulinTypeLogic, InsulinTypeLogic>();
            container.RegisterType<IRoleLogic, RoleLogic>();
            container.RegisterType<IUserLogic, UserLogic>();
        }

        private static void ConfigureDomain(IUnityContainer container)
        {
            IDomainConfig domainConfig = container.Resolve<IDomainConfig>();
            domainConfig.Configure(container);
        }
    }
}