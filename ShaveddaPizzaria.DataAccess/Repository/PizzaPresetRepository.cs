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
			var objFromDb = _dbContext.PizzaPresets.FirstOrDefault(u => u.PizzaId == obj.PizzaId);
			if(objFromDb != null)
			{
				objFromDb.PizzaName = obj.PizzaName;
				objFromDb.PizzaSauce = obj.PizzaSauce;
				objFromDb.HasCheese = obj.HasCheese;
				objFromDb.HasPepperoni = obj.HasPepperoni;
				objFromDb.HasMushroom = obj.HasMushroom;
				objFromDb.HasPineapple= obj.HasPineapple;
				objFromDb.HasTuna = obj.HasTuna;
				objFromDb.HasPrawn = obj.HasPrawn;
				objFromDb.HasHam = obj.HasHam;
				objFromDb.HasBeef = obj.HasBeef;

				if(obj.ImagePath != null)
				{
					objFromDb.ImagePath = obj.ImagePath; 
				}
			}
		}

        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
