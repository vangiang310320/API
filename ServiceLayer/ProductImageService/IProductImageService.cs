using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public interface IProductImageService
    {
        IEnumerable<ProductImage> GetProductImages();
        ProductImage GetProductImage(int id);
        void InsertproductImage(ProductImage productImage);
        void UpdateProductImage(ProductImage productImage);
        void DeleteProductImage(int id);
        object GetAllProductImage();
    }
}
