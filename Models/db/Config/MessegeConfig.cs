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
    public class MessegeConfig : IEntityTypeConfiguration<Messege>
    {
        public void Configure(EntityTypeBuilder<Messege> builder)
        {
            builder.HasKey(m => m.MessegeID);
            builder.Property(m => m.Fullname)
                .HasColumnType("NVARCHAR(126)")
                .IsRequired(true);
            builder.Property(m => m.UserID)
                .IsRequired(true);
            builder.Property (m => m.Email)
                .HasColumnType("VARCHAR(255)")
                .IsRequired(true);
            builder.Property(m => m.Subject)
               .HasColumnType("VARCHAR(MAX)")
               .IsRequired(true);
            builder.Property(m => m.Content)
               .HasColumnType("VARCHAR(MAX)")
               .IsRequired(true);
            builder.ToTable("Messeges");
        }
    }
}
