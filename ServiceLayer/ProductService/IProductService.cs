using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ProductService
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProduct();
        Product GetProduct(int id);
        void InsertProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
