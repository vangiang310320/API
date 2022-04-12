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
    public class MenuMap : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_menuid");
            builder.Property(x => x.Id).UseIdentityColumn()
                .HasColumnName("id")
                .HasColumnName("INT");

            builder.Property(x => x.MenuName)
                .HasColumnName("MenuName")
                .HasColumnType("NVARCHAR(100)");

            builder.Property(x => x.Url)
                .HasColumnName("Url")
                .HasColumnType("NVARCHAR(100)");

            builder.Property(x => x.SortOrder)
                .HasColumnName("SortOrder")
                .HasColumnType("NVARCHAR(100)");

            builder.Property(x => x.ParentId)
                .HasColumnName("ParentId")
                .HasColumnType("INT");
        }
    }
}
