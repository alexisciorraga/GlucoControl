using Unity;

namespace GlucoControl.Application.Configuration
{
    public interface IApplicationConfig
    {
        void Configure(IUnityContainer container);
    }
}