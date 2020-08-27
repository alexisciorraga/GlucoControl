using AutoMapper;
using GlucoControl.Domain.Configuration;

namespace GlucoControl.Domain.Logic.Configuration
{
    public class AutoMapperDomainContainer : IAutoMapperDomainContainer
    {
        private static readonly AutomapperDomainProfile _domainProfile = new AutomapperDomainProfile();

        public Profile GetProfile()
        {
            return _domainProfile;
        }
    }
}