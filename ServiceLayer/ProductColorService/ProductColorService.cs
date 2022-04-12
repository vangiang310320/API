using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ProductColorService
{
    public class ProductColorService : IProductColorService
    {
        private IRepository<ProductColor> repo;
        public ProductColorService(IRepository<ProductColor> repo)
        {
            this.repo = repo;
        }
        public void DeleteProductColor(int id)
        {
            ProductColor productColor = repo.Get(id);
            repo.Remove(productColor);
            repo.SaveChanges();
        }

        public IEnumerable<ProductColor> GetAllProductColor()
        {
            return repo.GetAll();
        }

        public ProductColor GetProductColor(int id)
        {
            return repo.Get(id);
        }

        public void InsertProductColor(ProductColor productColor)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductColor(ProductColor productColor)
        {
            repo.Update(productColor);
        }
    }
}