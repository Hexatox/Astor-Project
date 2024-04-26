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
    public class PostConfig : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(p => p.PostId);

            builder.Property(p => p.PostType)
                .HasConversion<string>().HasMaxLength(32);

            builder.Property(p => p.Image)
                .HasColumnType("NVARCHAR(MAX)")
                .IsRequired(false);

            builder.Property (p =>p.Title)
                .HasColumnType("NVARCHAR(255)")
                .IsRequired(true);
            builder.Property(p => p.Samary)
                .HasColumnType("NVARCHAR(MAX)")
                .IsRequired(true);
            builder.Property(p => p.Content)
                .HasColumnType("NVARCHAR(MAX)")
                .IsRequired(true);
            builder.Property(u => u.TotalLikes)
                .HasDefaultValue(0);
            builder.Property(u => u.IsAviable)
                .HasDefaultValue(true);

            builder.HasMany (p => p.Likes)
                .WithOne (l => l.Post)
                .HasForeignKey (l => l.PostId);

            builder.HasMany(p => p.Comments)
                .WithOne(l => l.Post)
                .HasForeignKey(l => l.PostId);

            builder.HasMany(p => p.Catigories)
                .WithMany(i => i.Posts)
                .UsingEntity<PostCatigory>();
        }
    }
}
