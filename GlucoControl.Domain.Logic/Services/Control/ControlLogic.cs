using AutoMapper;
using GlucoControl.Domain.Logic.Services.Base;
using GlucoControl.Domain.Model.Data.Control;
using GlucoControl.Domain.Services;
using GlucoControl.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;

namespace GlucoControl.Domain.Logic.Services
{
    public class ControlLogic : BaseServiceLogic<Control, Repository.Models.Control>, IControlLogic
    {
        IControlRepository _controlRepository;

        public ControlLogic(IMapper mapper, IControlRepository controlRepository) : base(mapper)
        {
            _controlRepository = controlRepository;
        }

        public Control Add(Control entity)
        {
            var repositoryEntity = GetRepositoryEntityFromDomainEntity(entity);
            var domainEntity = _controlRepository.Insert(repositoryEntity);
            return GetDomainEntityFromRepositoryEntity(domainEntity);
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