using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShaveddaPizzaria.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IPizzaOrderRepository orderRepo { get; }
        IPizzaOrderDetailRepository orderDetailRepo { get; }
        IPizzaPresetRepository presetRepo { get; }

        void Save();
    }
}
