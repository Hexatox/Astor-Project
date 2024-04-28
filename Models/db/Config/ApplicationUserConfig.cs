using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DAL.db.Config
{
    public class ApplicationUserConfig : IEntityTypeConfiguration <ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasKey (u => u.Id);
            builder.Property(u => u.Id)
                .HasMaxLength(64);
           
            builder.Property(u => u.Firstname)
                .HasColumnType("NVARCHAR(64)")
                .IsRequired(true);
            builder.Property(u => u.Lastname)
                .HasColumnType("NVARCHAR(64)")
                .IsRequired(true);
            builder.Property(u => u.Bio)
                .HasColumnType("NVARCHAR(MAX)")
                .IsRequired(false);
            builder.Property (u => u.isBlocked)
                .HasDefaultValue(false);

            //builder.HasIndex(u => u.Email)
            //    .IsUnique();
            //builder.HasIndex (u => u.UserName)
            //    .IsUnique ();
            


            builder.OwnsOne(u => u.ProfilePhoto,
                    pp =>
                    {
                        pp.Property(o => o.URL).HasColumnType("NVARCHAR(MAX)")
                            .HasColumnName("URL").IsRequired(false);
                        pp.Property(o => o.ImageName).HasColumnType("NVARCHAR (MAX)")
                            .HasColumnName("ImageName").IsRequired(false);
                    }
            );
                

            builder.HasMany(u => u.Links)
                .WithOne(l => l.User)
                .HasForeignKey(l => l.UserId);// User has many Links 

            builder.HasMany(u => u.Messeges)
                .WithOne(m => m.User)
                .HasForeignKey(m => m.UserID); // user has many messeges

            builder.HasMany(u => u.Reviews)
                .WithOne(r => r.ReviewTo)
                .HasForeignKey(r => r.ReviewToId); // user has many Review `I mean the user can see the his Reviews Only`

            builder.HasMany<UserReview>()
                .WithOne(r => r.User)
                .HasForeignKey(r => r.UserId);

            builder.HasMany(u => u.Posts)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId); // User Postes

            builder.HasMany (u => u.Likes)
                .WithOne (l => l.User)
                .HasForeignKey(l => l.UserId);
            
            builder.HasMany (u => u.Comments)
                .WithOne(m => m.User)
                .HasForeignKey(m => m.UserId);

            builder.HasMany<Request>()
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId); // this relation for User Requests

            builder.HasMany<Request>()
                .WithOne(p => p.Admin)
                .HasForeignKey (a => a.AdminId);

        }
    }
}
