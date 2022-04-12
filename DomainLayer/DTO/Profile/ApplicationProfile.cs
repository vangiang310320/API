using DomainLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.DTO.Profile
{
    public class ApplicationProfile : AutoMapper.Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Category, CategoryDTO>()
                .ReverseMap();
            CreateMap<Customer, CustomerDTO>()
                .ReverseMap();
            CreateMap<Order, OrderDTO>()
                .ReverseMap();
            CreateMap<OrderDetail, OrderDetailDTO>()
                .ReverseMap();
            CreateMap<Product, ProductDTO>()
                .ReverseMap();
            CreateMap<ProductColor, ProductColorDTO>()
                .ReverseMap();
            CreateMap<ProductImage, ProductImageDTO>()
                .ReverseMap();
            CreateMap<ProductSize, ProductSizeDTO>()
                .ReverseMap();
            CreateMap<Supplier, SupplierDTO>()
                .ReverseMap();
        }
    }
}
