using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ProductService
{
    public class ProductService : IProductService
    {
        private IRepository<Product> repo;
        public ProductService(IRepository<Product> repo)
        {
            this.repo = repo;
        }
        public void DeleteProduct(int id)
        {
            Product product = repo.Get(id);
            repo.Remove(product);
            repo.SaveChanges();
        }

        public IEnumerable<Product> GetAllProduct()
        {
            return repo.GetAll();
        }

        public Product GetProduct(int id)
        {
            return repo.Get(id);
        }

        public void InsertProduct(Product product)
        {
            repo.Insert(product);
        }

        public void UpdateProduct(Product product)
        {
            repo.Update(product);
        }
    }
}