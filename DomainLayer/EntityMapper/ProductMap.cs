using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.EntityMapper
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id).HasName("ProductId");
            builder.Property(x => x.Id).UseIdentityColumn()
                .HasColumnName("id")
                .HasColumnType("INT");
            builder.Property(x => x.ProductName)
                .HasColumnName("ProDuctName")
                .HasColumnType("NVARCHAR(100)");
            builder.Property(x => x.Price)
                .HasColumnName("Price")
                .HasColumnType("FLOAT");
            builder.Property(x => x.Description)
                .HasColumnName("Description")
                .HasColumnType("NVARCHAR(MAX)");
            builder.Property(x => x.Image)
               .HasColumnName("Image")
               .HasColumnType("VARCHAR");
            builder.Property(x => x.Discount)
                .HasColumnName("Discount")
                .HasColumnType("NVARCHAR(MAX)");
            builder.Property(x => x.Discount)
                .HasColumnName("Discount")
                .HasColumnType("NVARCHAR(MAX)");
            builder.Property(x => x.Viewcount)
                .HasColumnName("Viewcount")
                .HasColumnType("INT");


            builder.HasOne(x => x.Category)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.Id);
            builder.HasOne(x => x.Supplier)
                .WithMany(x => x.Products)
                .HasForeignKey(x => x.Id);
        }
    }
}