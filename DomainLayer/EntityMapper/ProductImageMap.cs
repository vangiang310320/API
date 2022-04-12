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
    public class ProductImageMap : IEntityTypeConfiguration<ProductImage>
    {
        public void Configure(EntityTypeBuilder<ProductImage> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_productimageid");
            builder.Property(x => x.Id).UseIdentityColumn()
                .HasColumnName("id")
                .HasColumnName("INT");
            builder.Property(x => x.ImagePath)
                .HasColumnName("ImagePath")
                .HasColumnType("NVARCHAR(100)");
            builder.Property(x => x.IsDefault)
                .HasColumnName("IsDefault")
                .HasColumnType("NVARCHAR(100)");
            builder.Property(x => x.Active)
                .HasColumnName("Active")
                .HasColumnType("BIT");
            builder.HasOne(x => x.Product)
                .WithMany(x => x.ProductImages)
                .HasForeignKey(x => x.Id);
        }
    }
}
