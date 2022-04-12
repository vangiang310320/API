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
    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_orderid");
            builder.Property(x => x.Id).UseIdentityColumn()
                .HasColumnName("id")
                .HasColumnName("INT");

            builder.HasOne(x => x.Customer)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.Id);

            builder.Property(x => x.TotalMoney)
                .HasColumnName("TotalMonet")
                .HasColumnType("Float");

            builder.Property(x => x.Payment)
                .HasColumnName("Payment")
                .HasColumnType("Float");

            builder.Property(x => x.BookingDate)
                .HasColumnName("BookingDate")
                .HasColumnType("Date");

            builder.Property(x => x.DeliveryData)
                .HasColumnName("DeliveryData")
                .HasColumnType("NVARCHAR(100)");

            builder.Property(x => x.ShippingWay)
                .HasColumnName("ShippingWay")
                .HasColumnType("NVARCHAR(100)");

            builder.Property(x => x.Sate)
                .HasColumnName("Sate")
                .HasColumnType("NVARCHAR(100)");

            builder.Property(x => x.Note)
                .HasColumnName("Note")
                .HasColumnType("NVARCHAR(MAX)");

            builder.Property(X => X.TransportFee)
                .HasColumnName("TransportFee")
                .HasColumnType("FLOAT");
        }
    }
}
