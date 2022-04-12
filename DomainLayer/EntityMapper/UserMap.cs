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
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_userid");
            builder.Property(x => x.Id).UseIdentityColumn()
                .HasColumnName("id")
                .HasColumnName("INT");

            builder.Property(x => x.UserName)
                .HasColumnName("UserName")
                .HasColumnType("NVARCHAR(100)");

            builder.Property(x => x.Password)
                .HasColumnName("Password")
                .HasColumnType("NVARCHAR(100)");

            builder.Property(x => x.FullName)
                .HasColumnName("FullName")
                .HasColumnType("NVARCHAR(100)");

            builder.Property(x => x.Email)
                .HasColumnName("Email")
                .HasColumnType("NVARCHAR(100)");

            builder.Property(x => x.Active)
                .HasColumnName("Active")
                .HasColumnType("BIT");
        }
    }
}
