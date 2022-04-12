using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.SupplierService
{
    public interface ISupplierService
    {
        IEnumerable<Supplier> GetAllSuppliers();
        Supplier GetSupplier(int id);
        void InsertSupplier(Supplier supplier);
        void UpdateSupplier(Supplier supplier);
        void DeleteSupplier(int id);
    }
}
