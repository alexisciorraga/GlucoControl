using GlucoControl.Repository.Repositories.Base;
using System;

namespace GlucoControl.Repository.Repositories.Control
{
    public interface IControlRepository : IBaseRepositoryCrud<Model.Control, Guid>
    {
    }
}