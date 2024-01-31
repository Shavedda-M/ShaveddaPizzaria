using ShaveddaPizzaria.DataAccess.Data;
using ShaveddaPizzaria.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaveddaPizzaria.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public IPizzaOrderRepository orderRepo { get; private set; }
        public IPizzaOrderDetailRepository orderDetailRepo { get; private set; }
        public IPizzaPresetRepository presetRepo { get; private set; }

        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            orderRepo = new PizzaOrderRepository(_dbContext);
            orderDetailRepo = new PizzaOrderDetailRepository(_dbContext);
            presetRepo = new PizzaPresetRepository(_dbContext);
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
