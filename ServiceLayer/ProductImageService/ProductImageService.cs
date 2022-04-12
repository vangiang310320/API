using DomainLayer.Models;
using RepositoryLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ProductImageService
{
    public class ProductImageService : IProductImageService
    {
        private IRepository<ProductImage> repo;
        public ProductImageService(IRepository<ProductImage> repo)
        {
            this.repo = repo;
        }
        public void DeleteProductImage(int id)
        {
            ProductImage productImage = repo.Get(id);
            repo.Remove(productImage);
            repo.SaveChanges();
        }

        public object GetAllProductImage()
        {
            return repo.GetAll();
        }

        public ProductImage GetProductImage(int id)
        {
            return repo.Get(id);
        }

        public IEnumerable<ProductImage> GetProductImages()
        {
            return repo.GetAll();
        }

        public void InsertproductImage(ProductImage productImage)
        {
            repo.Insert(productImage);
        }

        public void UpdateProductImage(ProductImage productImage)
        {
            repo.Update(productImage);
        }
    }
}
