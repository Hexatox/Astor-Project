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
    public class UserReviewConfig : IEntityTypeConfiguration<UserReview>
    {
        public void Configure(EntityTypeBuilder<UserReview> builder)
        {
            builder.HasKey(ur => ur.UserReviewId);
            builder.Property(ur => ur.Rate)
                .IsRequired(true);
            builder.Property(ur => ur.Messege)
                .HasColumnType ("NVARCHAR(MAX)")
                .IsRequired(false);
            builder.ToTable("UserReviews");
        }
    }
}
