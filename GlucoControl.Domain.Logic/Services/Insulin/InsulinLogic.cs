using AutoMapper;
using GlucoControl.Domain.Model.Data.Insulin;
using GlucoControl.Domain.Services;
using GlucoControl.Repository.Repositories.Insulin;
using System;
using System.Collections.Generic;

namespace GlucoControl.Domain.Logic.Services
{
    public class InsulinLogic : BaseServiceLogic<Insulin, Repository.Model.Insulin>, IInsulinLogic
    {
        private IInsulinRepository _insulinRepository;

        public InsulinLogic(IMapper mapper, IInsulinRepository insulinRepository) : base(mapper)
        {
            _insulinRepository = insulinRepository;
        }

        public IEnumerable<Insulin> GetAll()
        {
            throw new NotImplementedException();
        }

        public Insulin GetById(Guid entityId)
        {
            throw new NotImplementedException();
        }
    }
}