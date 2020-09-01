using AutoMapper;
using GlucoControl.Domain.Logic.Services.Base;
using GlucoControl.Domain.Model.Data.Control;
using GlucoControl.Domain.Services;
using GlucoControl.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace GlucoControl.Domain.Logic.Services
{
    public class ControlLogic : BaseServiceLogic<Control, Repository.Models.Control>, IControlLogic
    {
        private IControlRepository _controlRepository;
        private IMapper _mapper;

        public ControlLogic(IMapper mapper, IControlRepository controlRepository) : base(mapper)
        {
            _controlRepository = controlRepository;
            _mapper = mapper;
        }

        public Control Add(Control entity)
        {
            var controlRepository = _controlRepository.Insert(GetRepositoryEntityFromDomainEntity(entity));

            return GetDomainEntityFromRepositoryEntity(controlRepository);
        }

        public void Delete(Guid entityId)
        {
            var controlToDelete = _controlRepository.GetById(entityId);
            _controlRepository.Delete(controlToDelete);
        }

        public IEnumerable<Control> GetAll()
        {
            var repositoryEntities = _controlRepository.GetAll();
            return GetDomainEntitiesFromRepositoryEntities(repositoryEntities);
        }

        public Control GetById(Guid entityId)
        {
            var repositoryEntity = _controlRepository.GetById(entityId);
            return GetDomainEntityFromRepositoryEntity(repositoryEntity);
        }

        public void Update(Control entity)
        {
            var repositoryEntity = GetRepositoryEntityFromDomainEntity(entity);
            _controlRepository.Update(repositoryEntity);
        }
    }
}