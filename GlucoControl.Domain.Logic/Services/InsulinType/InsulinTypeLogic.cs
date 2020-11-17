using AutoMapper;
using GlucoControl.Domain.Logic.Services.Base;
using GlucoControl.Domain.Model.Data.InsulinType;
using GlucoControl.Domain.Services;
using GlucoControl.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace GlucoControl.Domain.Logic.Services
{
    public class InsulinTypeLogic : BaseServiceLogic<InsulinType, Repository.Models.InsulinType>, IInsulinTypeLogic
    {
        private IInsulinTypeRepository _insulinTypeRepository;

        public InsulinTypeLogic(IMapper mapper, IInsulinTypeRepository insulinTypeRepository) : base(mapper)
        {
            _insulinTypeRepository = insulinTypeRepository;
        }

        public IEnumerable<InsulinType> GetAll()
        {
            return GetDomainEntitiesFromRepositoryEntities(_insulinTypeRepository.GetAll());
        }

        public InsulinType GetById(int entityId)
        {
            var repositoryEntity = _insulinTypeRepository.GetById(entityId);
            return GetDomainEntityFromRepositoryEntity(repositoryEntity);
        }
    }
}