using GlucoControl.Repository.Context;
using GlucoControl.Repository.Interfaces;
using GlucoControl.Repository.Models;
using System.Collections.Generic;

namespace GlucoControl.Repository.Repositories
{
    public class ControlRepository : GenericCrudRepository<Control>, IControlRepository
    {
        readonly GlucoControlDbContext _dbContext;
        readonly IControlRepository _controlRepository;
        public ControlRepository(GlucoControlDbContext dbContext, IControlRepository controlRepository) : base(dbContext)
        {
            _dbContext = dbContext;
            _controlRepository = controlRepository;
        }

        public IEnumerable<Control> GetAll()
        {
            return _controlRepository.GetAll();
        }

        public Control GetById(object id)
        {
            return _controlRepository.GetById(id);
        }
    }
}
