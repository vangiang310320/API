using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ProductSizeService
{
    public class ProductSizeService : IProductSizeService
    {
        private IRepository<ProductSize> repo;
        public ProductSizeService(IRepository<ProductSize> repo)
        {
            this.repo = repo;
        }
        public void DeleteProductSize(int id)
        {
            ProductSize productSize = repo.Get(id);
            repo.Remove(productSize);
            repo.SaveChanges();
        }

        public IEnumerable<ProductSize> GetAllProductSize()
        {
            return repo.GetAll();
        }

        public ProductSize GetProductSize(int id)
        {
            return repo.Get(id);
        }

        public void InsertProductSize(ProductSize productSize)
        {
            repo.Insert(productSize);
        }

        public void UpdateProductSize(ProductSize productSize)
        {
            repo.Update(productSize);
        }
    }
}
