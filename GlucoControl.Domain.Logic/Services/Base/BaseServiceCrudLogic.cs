using AutoMapper;
using GlucoControl.Domain.Services.Base;
using GlucoControl.Repository.Repositories.Base;

namespace GlucoControl.Domain.Logic.Services.Base
{
    public class BaseServiceCrudLogic<TDomainEntity, TRepositoryEntity> :
        BaseServiceLogic<TDomainEntity, TRepositoryEntity>
        , IBaseServiceCrudLogic<TDomainEntity, int>
        where TDomainEntity : class
        where TRepositoryEntity : class
    {
        private readonly IBaseRepositoryCrud<TRepositoryEntity, int> _baseRepositoryCrud;

        public BaseServiceCrudLogic(IMapper mapper
            , IBaseRepositoryCrud<TRepositoryEntity, int> baseRepositoryCrud)
            : base(mapper)
        {
            _baseRepositoryCrud = baseRepositoryCrud;
        }

        public TDomainEntity Add(TDomainEntity entity)
        {
            var entityRepository = GetValidRepositoryEntityFormDomainEntity(entity);

            SpecificEntityAddOperations(entityRepository, entity);

            _baseRepositoryCrud.Add(entityRepository);
            return GetDomainEntityFromRepositoryEntity(entityRepository);
        }

        public void Delete(int entityId)
        {
            _baseRepositoryCrud.Delete(_baseRepositoryCrud.GetById(entityId));
        }

        public void Update(TDomainEntity entity)
        {
            var entityRepository = GetValidRepositoryEntityFormDomainEntity(entity);
            _baseRepositoryCrud.Update(entityRepository);
            entity = GetDomainEntityFromRepositoryEntity(entityRepository);
        }

        protected TRepositoryEntity GetValidRepositoryEntityFormDomainEntity(TDomainEntity domainEntity)
        {
            return GetRepositoryEntityFromDomainEntity(domainEntity);
        }

        protected virtual void SpecificEntityAddOperations(TRepositoryEntity repositoryEntity, TDomainEntity domainEntity)
        {
        }
    }
}