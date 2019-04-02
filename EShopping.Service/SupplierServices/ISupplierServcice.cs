using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShopping.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EShopping.Service.SupplierServices
{
    public interface ISupplierServcice
    {
        IEnumerable<Supplier> AllSuppliers();

        Supplier GetSuplierbyId(int id);

        Task<bool> AddSupplier(Supplier sup);
    }
}
