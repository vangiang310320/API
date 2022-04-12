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
    public class SlideMap : IEntityTypeConfiguration<Slide>
    {
        public void Configure(EntityTypeBuilder<Slide> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_slideid");
            builder.Property(x => x.Id).UseIdentityColumn()
                .HasColumnName("id")
                .HasColumnName("INT");

            builder.Property(x => x.SlideName)
                .HasColumnName("SlideName")
                .HasColumnType("NVARCHAR(100)");

            builder.Property(x => x.Description)
                .HasColumnName("Description")
                .HasColumnType("NVARCHAR(Max)");

            builder.Property(x => x.Image)
                .HasColumnName("Image")
                .HasColumnType("NVARCHAR(100)");

            builder.Property(x => x.Url)
                .HasColumnName("Url")
                .HasColumnType("NVARCHAR(100)");

            builder.Property(x => x.SortOrder)
                .HasColumnName("SortOrder")
                .HasColumnType("NVARCHAR(100)");

            builder.Property(x => x.Status)
                .HasColumnName("Status")
                .HasColumnType("NVARCHAR(100)");
        }
    }
}
