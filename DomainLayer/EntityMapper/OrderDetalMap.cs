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
    public class OrderDetalMap : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_orderdetailid");
            builder.Property(x => x.Id).UseIdentityColumn()
                .HasColumnName("id")
                .HasColumnName("INT");
            builder.Property(x => x.Quantity)
                .HasColumnName("Quantity")
                .HasColumnType("INT");

            builder.HasOne(x => x.product)
                .WithMany(x => x.OrderDetails)
                .HasForeignKey(x => x.Id);

            builder.HasOne(x => x.order)
                .WithMany(x => x.OrderDetails)
                .HasForeignKey(x => x.Id);
        }
    }
}