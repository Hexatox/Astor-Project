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
    public class CommentConfig : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(c => c.CommentId);
            builder.Property(c => c.Content)
                .HasColumnType("NVARCHAR(MAX)")
                .IsRequired(true);
            builder.Property(c => c.UserId)
                .IsRequired();
            builder.Property(c => c.PostId)
                .IsRequired();
        }
    }
}
