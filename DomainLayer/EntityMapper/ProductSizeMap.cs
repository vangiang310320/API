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
    public class ProductSizeMap : IEntityTypeConfiguration<ProductSize>
    {
        public void Configure(EntityTypeBuilder<ProductSize> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_productsizeid");
            builder.Property(x => x.Id).UseIdentityColumn()
                .HasColumnName("id")
                .HasColumnName("INT");

            builder.Property(x => x.Size)
                .HasColumnName("Size")
                .HasColumnType("NVARCHAR(100)");

            builder.Property(x => x.Active)
                .HasColumnName("Active")
                .HasColumnType("BIT");

            builder.HasOne(x => x.Product)
                .WithMany(x => x.ProductSizes)
                .HasForeignKey(x => x.Id);
        }
    }
}
