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
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_categoryid");
            builder.Property(x => x.Id)
            .HasColumnName("id")
            .HasColumnType("INT");

            builder.Property(x => x.CategoryName)
            .HasColumnName("CategoryName")
            .HasColumnType("NVARCHAR(100)")
            .IsRequired();

            builder.Property(x => x.Description)
            .HasColumnName("Description")
            .HasColumnType("NVARCHAR(MAX)");

            builder.Property(x => x.CreateDate)
            .HasColumnName("CreateDate")
            .HasColumnType("DATE");

            builder.Property(x => x.ModifiedData)
            .HasColumnName("ModifiedData")
            .HasColumnType("DATE");

            builder.Property(x => x.IsActive)
            .HasColumnName("IsActive")
            .HasColumnType("BIT");
        }
    }
}