using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ProductSizeService
{
    public interface IProductSizeService
    {
        IEnumerable<ProductSize> GetAllProductSize();
        ProductSize GetProductSize(int id);
        void InsertProductSize(ProductSize productSize);
        void UpdateProductSize(ProductSize productSize);
        void DeleteProductSize(int id);
    }
}
