using Azure.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.db.Config
{
    public class RequestConfig : IEntityTypeConfiguration<Entities.Request>
    {
        public void Configure(EntityTypeBuilder<Entities.Request> builder)
        {
            builder.HasKey(r => r.RequestId);
            builder.Property(r => r.Status)
                .HasDefaultValue(null);
            builder.Property (r => r.AcceptDate) .HasDefaultValue(null);
            builder.Property(r => r.Notes).HasColumnType("NVARCHAR(MAX)")
                .HasDefaultValue(null)
                .IsRequired(false);
            builder.ToTable("Requests");
        }
    }
}
