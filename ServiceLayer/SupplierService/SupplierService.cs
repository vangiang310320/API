using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.SupplierService
{
    public class SupplierService : ISupplierService
    {
        private IRepository<Supplier> repo;
        public SupplierService(IRepository<Supplier> repo)
        {
            this.repo = repo;
        }
        public void DeleteSupplier(int id)
        {
            Supplier supplier = repo.Get(id);
            repo.Remove(supplier);
            repo.SaveChanges();
        }

        public IEnumerable<Supplier> GetAllSuppliers()
        {
            return repo.GetAll();
        }

        public Supplier GetSupplier(int id)
        {
            return repo.Get(id);
        }

        public void InsertSupplier(Supplier supplier)
        {
            repo.Insert(supplier);
        }

        public void UpdateSupplier(Supplier supplier)
        {
            repo.Update(supplier);
        }
    }
}