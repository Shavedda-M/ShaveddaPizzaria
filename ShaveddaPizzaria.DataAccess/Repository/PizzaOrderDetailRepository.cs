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
	public class PizzaOrderDetailRepository : Repository<PizzaOrderDetails>, IPizzaOrderDetailRepository
	{
		private readonly ApplicationDbContext _dbContext;

        public PizzaOrderDetailRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

		public void Update(PizzaOrderDetails obj)
		{
			_dbContext.PizzaOrderDetails.Update(obj);
		}

		public void Save()
		{
			_dbContext.SaveChanges();
		}
	}
}
