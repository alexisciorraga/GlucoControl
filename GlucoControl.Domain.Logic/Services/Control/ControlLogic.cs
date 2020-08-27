using AutoMapper;
using GlucoControl.Domain.Model.Data.Control;
using GlucoControl.Domain.Services;
using GlucoControl.Repository.Repositories.Control;
using System;

namespace GlucoControl.Domain.Logic.Services
{
    public class ControlLogic : BaseServiceLogic<Control, Repository.Model.Control>, IControlLogic
    {
        private IControlRepository _controlRepository;

        public ControlLogic(IMapper mapper, IControlRepository controlRepository) : base(mapper)
        {
            _controlRepository = controlRepository;
        }

        public Control Add(Control entity)
        {
            return GetDomainEntityFromRepositoryEntity(_controlRepository.Add(GetRepositoryEntityFromDomainEntity(entity)));
        }

        public void Delete(Guid entityId)
        {
            var controlToDelete = _controlRepository.GetById(entityId);
            _controlRepository.Delete(controlToDelete);
        }

        public void Update(Control entity)
        {
            _controlRepository.Update(GetRepositoryEntityFromDomainEntity(entity));
        }
    }
}