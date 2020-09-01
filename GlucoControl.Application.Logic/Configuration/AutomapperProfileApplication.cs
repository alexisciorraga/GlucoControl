using GlucoControl.Application.Configuration;
using GlucoControl.Domain.Configuration;
using GlucoControl.Transversal.Automapper;
using System.Collections.Generic;

namespace GlucoControl.Application.Logic.Configuration
{
    public class AutomapperProfileApplication : IAutomapperProfileApplication
    {
        readonly List<IAutomapperProfileContainer> _profiles = new List<IAutomapperProfileContainer>();
        public AutomapperProfileApplication(IAutoMapperDomainContainer domainProfile)
        {
            _profiles.Add(domainProfile);
        }
        public List<IAutomapperProfileContainer> GetProfiles()
        {
            return _profiles;
        }
    }
}
