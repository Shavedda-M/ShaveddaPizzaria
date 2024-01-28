using Microsoft.EntityFrameworkCore;
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
	public class PizzaOrderRepository : Repository<PizzaOrder>, IPizzaOrderRepository
	{
		private readonly ApplicationDbContext _dbContext;

		public PizzaOrderRepository(ApplicationDbContext dbContext) : base(dbContext)
		{
			_dbContext = dbContext;
		}

		public PizzaOrder Get(Expression<Func<PizzaOrder, bool>> filter)
		{
			IQueryable<PizzaOrder> query = dbSet;
			query = query.Where(filter);
			return query.Include(x => x.OrderDetails).FirstOrDefault();
		}

		public IEnumerable<PizzaOrder> GetAll()
		{
			IQueryable<PizzaOrder> query = dbSet;
			return query.Include(x => x.OrderDetails).ToList();
		}

		public void Update(PizzaOrder obj)
		{
			_dbContext.PizzaOrders.Update(obj);
		}

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
