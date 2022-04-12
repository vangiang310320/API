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
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_customerid");
            builder.Property(x => x.Id).ValueGeneratedOnAdd()
                .HasColumnName("id")
                .HasColumnType("INT");
            builder.Property(x => x.CustomerName)
                .HasColumnName("CustomerName")
                .HasColumnType("NVARCHAR(100)");
            builder.Property(x => x.Gender)
                .HasColumnName("Gender")
                .HasColumnType("NVARCHAR(100)");
            builder.Property(x => x.Address)
                .HasColumnName("Address")
                .HasColumnType("NVARCHAR(Max)");
            builder.Property(x => x.Email)
                .HasColumnName("Email")
                .HasColumnType("NVARCHAR(100)");
            builder.Property(x => x.Phone)
                .HasColumnName("Phone")
                .HasColumnType("NVARCHAR(20)");
            builder.Property(x => x.Avatar)
                .HasColumnName("Avatar")
                .HasColumnType("NVARCHAR(Max)");
            builder.Property(x => x.UserName)
                .HasColumnName("UserName")
                .HasColumnType("NVARCHAR(100)");
            builder.Property(x => x.PassWord)
                .HasColumnName("PassWord")
                .HasColumnType("NVARCHAR(100)");
        }
    }
}