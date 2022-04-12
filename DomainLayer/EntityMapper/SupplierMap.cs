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
    public class SupplierMap : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_companyid");
            builder.Property(x => x.Id).UseIdentityColumn()
                .HasColumnName("id")
                .HasColumnName("INT");
            builder.Property(x => x.CompanyName)
                .HasColumnName("CompanyName")
                .HasColumnType("NVARCHAR(100)");
            builder.Property(x => x.Address)
                .HasColumnName("Address")
                .HasColumnType("NVARCHAR(MAX)");
            builder.Property(x => x.Email)
                .HasColumnName("Email")
                .HasColumnType("NVARCHAR(100)");
            builder.Property(x => x.Phone)
                .HasColumnName("Phone")
                .HasColumnType("NVARCHAR(100)");
        }
    }
}
