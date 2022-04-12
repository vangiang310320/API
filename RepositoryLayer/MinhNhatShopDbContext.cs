using DomainLayer.IdentityAuth;
using DomainLayer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer
{
    public class MinhNhatShopDbContext : IdentityDbContext<ApplicationUser>
    {
        public MinhNhatShopDbContext(DbContextOptions<MinhNhatShopDbContext> options) :base(options)
        { }
        public DbSet<Category> Category { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductColor> ProductColor { get; set; }
        public DbSet<ProductImage> ProductImage { get; set; }
        public DbSet<ProductSize> ProductSize { get; set; }
        public DbSet<Slide> Slide { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<User> User { get; set; }
    }
}
