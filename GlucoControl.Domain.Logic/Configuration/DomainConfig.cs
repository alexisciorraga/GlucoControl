using GlucoControl.Domain.Configuration;
using GlucoControl.Repository;
using GlucoControl.Repository.Logic.Repositories.Control;
using GlucoControl.Repository.Logic.Repositories.Insulin;
using GlucoControl.Repository.Logic.Repositories.InsulinType;
using GlucoControl.Repository.Logic.Repositories.Role;
using GlucoControl.Repository.Logic.Repositories.User;
using GlucoControl.Repository.Repositories.Control;
using GlucoControl.Repository.Repositories.Insulin;
using GlucoControl.Repository.Repositories.InsulinType;
using GlucoControl.Repository.Repositories.Role;
using GlucoControl.Repository.Repositories.User;
using Unity;
using Unity.Injection;
using GlucoControlEntities = GlucoControl.Repository.Logic.GlucoControlEntities;

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
            var glucoControlUnitOfWorkName = typeof(GlucoControlEntities).Name;
            container.RegisterType<IUnitOfWork, GlucoControlEntities>(glucoControlUnitOfWorkName);

            container.RegisterType<IUserRepository, UserRepository>
                (new InjectionConstructor(new ResolvedParameter<IUnitOfWork>(glucoControlUnitOfWorkName)));

            container.RegisterType<IRoleRepository, RoleRepository>
                (new InjectionConstructor(new ResolvedParameter<IUnitOfWork>(glucoControlUnitOfWorkName)));

            container.RegisterType<IInsulinTypeRepository, InsulinTypeRepository>
                (new InjectionConstructor(new ResolvedParameter<IUnitOfWork>(glucoControlUnitOfWorkName)));

            container.RegisterType<IInsulinRepository, InsulinRepository>
                (new InjectionConstructor(new ResolvedParameter<IUnitOfWork>(glucoControlUnitOfWorkName)));

            container.RegisterType<IControlRepository, ControlRepository>
                (new InjectionConstructor(new ResolvedParameter<IUnitOfWork>(glucoControlUnitOfWorkName)));
        }
    }
}