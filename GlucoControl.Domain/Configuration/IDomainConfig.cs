using Unity;

namespace GlucoControl.Domain.Configuration
{
    public interface IDomainConfig
    {
        void Configure(IUnityContainer container);
    }
}