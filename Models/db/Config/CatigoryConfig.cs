using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL.db.Config
{
    public class CatigoryConfig : IEntityTypeConfiguration<Catigory>
    {
        public void Configure(EntityTypeBuilder<Catigory> builder)
        {
            builder.HasKey(c => c.CatigoryId);
            builder.Property(c => c.CatigoryName)
                .HasColumnType("NVARCHAR(255)")
                .IsRequired(true);
            builder.HasIndex (c => c.CatigoryName)
                .IsUnique(true);

            builder.ToTable("Categories");
            builder.HasData(LoadCategories());
        }

        public Catigory[] LoadCategories()
        {
            // Initialize your categories here
            Catigory[] categories =
            {
                new Catigory { CatigoryId = 1,  CatigoryName = "Distributed Systems"},
                new Catigory { CatigoryId = 2,  CatigoryName = "Backend"},
                new Catigory { CatigoryId = 3,  CatigoryName = "System Design"},
                new Catigory { CatigoryId = 4,  CatigoryName = "Databases"},
                new Catigory { CatigoryId = 5,  CatigoryName = "Frontend" },
                new Catigory { CatigoryId = 6,  CatigoryName = "Web Development" },
                new Catigory { CatigoryId = 7,  CatigoryName = "Technologies & Frameworks"},
                new Catigory { CatigoryId = 8,  CatigoryName = "Clean Code" },
                new Catigory { CatigoryId = 9,  CatigoryName = "Programming Language" },
                new Catigory { CatigoryId = 10, CatigoryName = "Data Structures and Algorithms" },
                new Catigory { CatigoryId = 11, CatigoryName = "Artificial Intelligence" },
                new Catigory { CatigoryId = 12, CatigoryName = "Object Oriented Programming" },
                new Catigory { CatigoryId = 13, CatigoryName = "Refactoring" },
                new Catigory { CatigoryId = 14, CatigoryName = "Networks" },
                new Catigory { CatigoryId = 15, CatigoryName = "DevOps" },
                new Catigory { CatigoryId = 16, CatigoryName = "Version Control" },
                new Catigory { CatigoryId = 17, CatigoryName = "Software Architecture" },
                new Catigory { CatigoryId = 18, CatigoryName = "Microservices" },
                new Catigory { CatigoryId = 19, CatigoryName = "Containerization" },
                new Catigory { CatigoryId = 20, CatigoryName = "Security" },
                new Catigory { CatigoryId = 21, CatigoryName = "Cloud Computing" },
                new Catigory { CatigoryId = 22, CatigoryName = "Agile" },
                new Catigory { CatigoryId = 23, CatigoryName = "Data Science" },
                new Catigory { CatigoryId = 24, CatigoryName = "Computer Science" },
                new Catigory { CatigoryId = 25, CatigoryName = "Operating Systems" },
                new Catigory { CatigoryId = 26, CatigoryName = "Mobile Development" },
                new Catigory { CatigoryId = 27, CatigoryName = "Infrastructure as a Code" },
                new Catigory { CatigoryId = 28, CatigoryName = "Design Patterns" }
            };

            return categories;
        }
    }
}
