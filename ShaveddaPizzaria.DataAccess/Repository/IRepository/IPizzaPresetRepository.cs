using ShaveddaPizzaria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaveddaPizzaria.DataAccess.Repository.IRepository
{
	public interface IPizzaPresetRepository : IRepository<PizzaPreset>
	{
		void Update(PizzaPreset obj);
        void Save();
    }
}
