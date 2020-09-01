using AutoMapper;
using GlucoControl.Application.Configuration;
using GlucoControl.Application.Logic.Configuration;
using GlucoControl.Application.Logic.Services;
using GlucoControl.Application.Services;
using System;
using Unity;

namespace GlucoControl.WebApi
{
    public class UnityConfig
    {
        #region Unity Container

        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }

        #endregion Unity Container

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            RegisterServiceTypes(container);
            RegisterLayerTypes(container);
            RegisterAutoMapper(container);
        }

        private static void RegisterServiceTypes(IUnityContainer container)
        {
            container.RegisterType<IApplicationConfig, ApplicationConfig>();

            container.RegisterType<IControlApplication, ControlApplication>();
            container.RegisterType<IInsulinApplication, InsulinApplication>();
            container.RegisterType<IInsulinTypeApplication, InsulinTypeApplication>();
            container.RegisterType<IRoleApplication, RoleApplication>();
            container.RegisterType<IUserApplication, UserApplication>();
        }

        public static void RegisterLayerTypes(IUnityContainer container)
        {
            var applicationConfig = container.Resolve<IApplicationConfig>();
            applicationConfig.Configure(container);
        }

        public static void RegisterAutoMapper(IUnityContainer container)
        {
            container.RegisterType<IAutomapperProfileApplication, AutomapperProfileApplication>();

            var automapperProfilesService = container.Resolve<IAutomapperProfileApplication>();

            var mapperConfiguration = new MapperConfiguration(configuration =>
            {
                automapperProfilesService.GetProfiles()
                    .ForEach(profileContainer => configuration.AddProfile(profileContainer.GetProfile()));
                configuration.AddProfile(new AutomapperWebApiProfile());
            });

            container.RegisterInstance<IMapper>(mapperConfiguration.CreateMapper());
        }
    }
}