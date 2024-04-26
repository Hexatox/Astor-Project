using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.db.Config
{
    public class SocielMediaUserConfig : IEntityTypeConfiguration<SocielMediaUser>
    {
        public void Configure(EntityTypeBuilder<SocielMediaUser> builder)
        {
            builder.HasKey(s => s.SocielMediaUserId);
            builder.Property(s => s.SocielMediaType)
                .HasConversion<string>()
                .HasMaxLength (32)
                .IsRequired (true);
            builder.Property(s => s.UserId)
                .IsRequired(true);
            builder.Property(s => s.URL)
                .HasColumnType("NVARCHAR(512)")
                .IsRequired(true);
            builder.ToTable("SocielMediaUsers");
        }
    }
}
