using ShaveddaPizzaria.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaveddaPizzaria.DataAccess.Repository.IRepository
{
	public interface IPizzaOrderDetailRepository : IRepository<PizzaOrderDetails>
	{
		void Update(PizzaOrderDetails obj);
        void Save();
    }
}
