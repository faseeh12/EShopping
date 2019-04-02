using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EShopping.Data.Models;
using EShopping.Data;

namespace EShopping.Service.SupplierServices
{
    public class SupplierService : ISupplierServcice
    {
        private Repository<Supplier> _SuppRepo;

        public SupplierService(Repository<Supplier> SuppRepo)
        {
            _SuppRepo = SuppRepo;
        }
        public IEnumerable<Supplier> AllSuppliers()
        {
            return _SuppRepo.GetAll();
        }

        public Supplier GetSuplierbyId(int id)
        {
            return _SuppRepo.GetById(id);
        }

        public async Task<bool> AddSupplier(Supplier sup)
        {
            _SuppRepo.Insert(sup);
            return await _SuppRepo.SaveChangesAsync();
        }
    }
}
