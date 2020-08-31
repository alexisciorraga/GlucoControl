using System.Collections.Generic;
using GlucoControl.Domain.Services.Base;
using AutoMapper;
using GlucoControl.Repository.Interfaces;

namespace GlucoControl.Domain.Logic.Services.Base
{
    public class BaseServiceCrudLogic<TDomainEntity, TRepositoryEntity>:
        BaseServiceLogic<TDomainEntity, TRepositoryEntity>
        , IBaseServiceCrudLogic<TDomainEntity, int>
        where TDomainEntity : class
        where TRepositoryEntity : class
    {
        readonly IGenericRepository<TRepositoryEntity> _genericRepository;

        public BaseServiceCrudLogic(IMapper mapper,
            IGenericRepository<TRepositoryEntity> genericRepository)
            : base(mapper)
        {
            _genericRepository = genericRepository;
        }

        public TDomainEntity Add(TDomainEntity entity)
        {
            var entityRepository = GetValidRepositoryEntityFormDomainEntity(entity);

            SpecificEntityAddOperations(entityRepository, entity);

            _genericRepository.Insert(entityRepository);
            return GetDomainEntityFromRepositoryEntity(entityRepository);
        }

        public void Delete(int entityId)
        {
            _genericRepository.Delete(_genericRepository.GetById(entityId));
        }

        public void Update(TDomainEntity entity)
        {
            var entityRepository = GetValidRepositoryEntityFormDomainEntity(entity);
            _genericRepository.Update(entityRepository);
            entity = GetDomainEntityFromRepositoryEntity(entityRepository);
        }

        protected TRepositoryEntity GetValidRepositoryEntityFormDomainEntity(TDomainEntity domainEntity)
        {
            return GetRepositoryEntityFromDomainEntity(domainEntity);
        }

        protected virtual void SpecificEntityAddOperations(TRepositoryEntity repositoryEntity, TDomainEntity domainEntity)
        {

        }

        public IEnumerable<TDomainEntity> GetAll()
        {
            return GetDomainEntitiesFromRepositoryEntities(_genericRepository.GetAll());
        }

        public TDomainEntity GetById(int entityId)
        {
            return GetDomainEntityFromRepositoryEntity(_genericRepository.GetById(entityId));
        }
    }
}
