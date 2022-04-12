using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ProductColorService
{
    public interface IProductColorService
    {
        IEnumerable<ProductColor> GetAllProductColor();
        ProductColor GetProductColor(int id);
        void InsertProductColor(ProductColor product);
        void UpdateProductColor(ProductColor product);
        void DeleteProductColor(int id);
    }
}
