using GlucoControl.Transversal.Automapper;
using System.Collections.Generic;

namespace GlucoControl.Application.Configuration
{
    public interface IAutomapperProfileApplication
    {
        List<IAutomapperProfileContainer> GetProfiles();
    }
}