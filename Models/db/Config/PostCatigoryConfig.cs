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
    public class PostCatigoryConfig : IEntityTypeConfiguration<PostCatigory>
    {
        public void Configure(EntityTypeBuilder<PostCatigory> builder)
        {
            builder.HasKey(pc => new { pc.PostId, pc.CatigoryId });
           
        }
    }
}
