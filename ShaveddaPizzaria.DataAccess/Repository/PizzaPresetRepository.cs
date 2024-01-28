using ShaveddaPizzaria.DataAccess.Data;
using ShaveddaPizzaria.DataAccess.Repository.IRepository;
using ShaveddaPizzaria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShaveddaPizzaria.DataAccess.Repository
{
	public class PizzaPresetRepository : Repository<PizzaPreset>, IPizzaPresetRepository
	{
		private readonly ApplicationDbContext _dbContext;

        public PizzaPresetRepository(ApplicationDbContext dbContext) : base(dbContext)
		{
			_dbContext = dbContext;
        }

		public void Update(PizzaPreset obj)
		{
			_dbContext.PizzaPresets.Update(obj);
		}

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
