using AutoMapper;
using GlucoControl.Domain.Model.Data.InsulinType;
using GlucoControl.Domain.Services;
using GlucoControl.Repository.Repositories.InsulinType;
using System;
using System.Collections.Generic;

namespace GlucoControl.Domain.Logic.Services
{
    public class InsulinTypeLogic : BaseServiceLogic<InsulinType, Repository.Model.InsulinType>, IInsulinTypeLogic
    {
        IInsulinTypeRepository _insulinTypeRepository;

        public InsulinTypeLogic(IMapper mapper, IInsulinTypeRepository insulinTypeRepository) : base(mapper)
        {
            _insulinTypeRepository = insulinTypeRepository;
        }

        public IEnumerable<InsulinType> GetAll()
        {
            throw new NotImplementedException();
        }

        public InsulinType GetById(Guid entityId)
        {
            throw new NotImplementedException();
        }
    }
}