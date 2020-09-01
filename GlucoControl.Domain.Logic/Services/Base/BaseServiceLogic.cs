using AutoMapper;
using System.Collections.Generic;
using System.Linq;

namespace GlucoControl.Domain.Logic.Services.Base
{
    public class BaseServiceLogic<TDomainEntity, TRepositoryEntity>
        where TDomainEntity : class
        where TRepositoryEntity : class
    {
        public readonly IMapper _mapper;

        public BaseServiceLogic(IMapper mapper)
        {
            _mapper = mapper;
        }

        protected TRepositoryEntity GetRepositoryEntityFromDomainEntity(TDomainEntity domainEntity)
        {
            return _mapper.Map<TRepositoryEntity>(domainEntity);
        }

        protected t1 GetRepositoryEntityFromDomainEntity<t1, t2>(t2 domainEntity)
        {
            return _mapper.Map<t1>(domainEntity);
        }

        protected TDomainEntity GetDomainEntityFromRepositoryEntity(TRepositoryEntity repositoryEntity)
        {
            return _mapper.Map<TDomainEntity>(repositoryEntity);
        }

        protected IEnumerable<TDomainEntity> GetDomainEntitiesFromRepositoryEntities(IEnumerable<TRepositoryEntity> repositoryEntities)
        {
            return repositoryEntities.Select(GetDomainEntityFromRepositoryEntity).ToList();
        }
    }
}