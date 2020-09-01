using AutoMapper;
using GlucoControl.Domain.Logic.Services.Base;
using GlucoControl.Domain.Model.Data.Insulin;
using GlucoControl.Domain.Services;
using GlucoControl.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace GlucoControl.Domain.Logic.Services
{
    public class InsulinLogic : BaseServiceLogic<Insulin, Repository.Models.Insulin>, IInsulinLogic
    {
        private IInsulinRepository _insulinRepository;

        public InsulinLogic(IMapper mapper, IInsulinRepository insulinRepository) : base(mapper)
        {
            _insulinRepository = insulinRepository;
        }

        public IEnumerable<Insulin> GetAll()
        {
            return GetDomainEntitiesFromRepositoryEntities(_insulinRepository.GetAll());
        }

        public Insulin GetById(Guid entityId)
        {
            var repositoryEntity = _insulinRepository.GetById(entityId);
            return GetDomainEntityFromRepositoryEntity(repositoryEntity);
        }
    }
}