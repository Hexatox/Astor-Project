﻿// <auto-generated />
using System;
using DAL.db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240513085945_sum")]
    partial class sum
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DAL.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Bio")
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(64)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(64)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("isBlocked")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1d35e3ea-fb63-482f-b7f7-daf830fc6285",
                            AccessFailedCount = 0,
                            Bio = "I am Defult Admin",
                            ConcurrencyStamp = "0127c311-349f-4d34-a990-cf8ae9d10f9d",
                            CreateDate = new DateTime(2024, 5, 13, 9, 59, 42, 899, DateTimeKind.Local).AddTicks(8691),
                            Email = "Admin@gmail.com",
                            EmailConfirmed = true,
                            Firstname = "Astor",
                            Lastname = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@GMAIL.COM",
                            NormalizedUserName = "ADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEI3q+/hqcqxyJEUbj7/zfmPFKvBK0Ili8EP15xaPYikzcXZzQM7wCovr2ZXBcDAr3g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "35abf95f-c535-4265-98fd-70ef1b2a33e9",
                            TwoFactorEnabled = false,
                            UserName = "Admin@gmail.com",
                            isBlocked = false
                        },
                        new
                        {
                            Id = "1121e9a5-f1f1-434b-a55d-bbe9d7a6b590",
                            AccessFailedCount = 0,
                            Bio = "I am Defult Auther",
                            ConcurrencyStamp = "a5f7efc1-306d-43c9-b1c6-eb131aad85c5",
                            CreateDate = new DateTime(2024, 5, 13, 9, 59, 43, 49, DateTimeKind.Local).AddTicks(2087),
                            Email = "Auther@gmil.com",
                            EmailConfirmed = true,
                            Firstname = "Astor",
                            Lastname = "Auther",
                            LockoutEnabled = false,
                            NormalizedEmail = "AUTHER@GMIL.COM",
                            NormalizedUserName = "AUTHER@GMIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEKBYKYmTrxqJKwlBIvY0Ir9YmaiUyPNWYCRTzRDGD1tfZsOwZwG/MVAO1iMVQfDc7A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "03b08b8e-320c-49c7-8bd4-a986cd28d4c6",
                            TwoFactorEnabled = false,
                            UserName = "Auther@gmil.com",
                            isBlocked = false
                        },
                        new
                        {
                            Id = "b178fae6-61f1-4b54-9480-021cf483faf8",
                            AccessFailedCount = 0,
                            Bio = "I am Defult User",
                            ConcurrencyStamp = "8de3ef00-f82b-4e59-8859-3218d1942421",
                            CreateDate = new DateTime(2024, 5, 13, 9, 59, 43, 197, DateTimeKind.Local).AddTicks(3832),
                            Email = "User@gmil.com",
                            EmailConfirmed = true,
                            Firstname = "Astor",
                            Lastname = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "USER@GMIL.COM",
                            NormalizedUserName = "USER@GMIL.COM",
                            PasswordHash = "AQAAAAIAAYagAAAAEHNNfb3uyxiCICQTyNdNEd1Cr9LapnBlW17xrQTe/jCUc0Y4t6GmmxsEGjIapVRhEg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c6c4215b-b695-4030-b58a-c09c59a2ab64",
                            TwoFactorEnabled = false,
                            UserName = "User@gmil.com",
                            isBlocked = false
                        });
                });

            modelBuilder.Entity("DAL.Entities.Catigory", b =>
                {
                    b.Property<int>("CatigoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CatigoryId"));

                    b.Property<string>("CatigoryName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)");

                    b.HasKey("CatigoryId");

                    b.HasIndex("CatigoryName")
                        .IsUnique();

                    b.ToTable("Categories", (string)null);

                    b.HasData(
                        new
                        {
                            CatigoryId = 1,
                            CatigoryName = "Distributed Systems"
                        },
                        new
                        {
                            CatigoryId = 2,
                            CatigoryName = "Backend"
                        },
                        new
                        {
                            CatigoryId = 3,
                            CatigoryName = "System Design"
                        },
                        new
                        {
                            CatigoryId = 4,
                            CatigoryName = "Databases"
                        },
                        new
                        {
                            CatigoryId = 5,
                            CatigoryName = "Frontend"
                        },
                        new
                        {
                            CatigoryId = 6,
                            CatigoryName = "Web Development"
                        },
                        new
                        {
                            CatigoryId = 7,
                            CatigoryName = "Technologies & Frameworks"
                        },
                        new
                        {
                            CatigoryId = 8,
                            CatigoryName = "Clean Code"
                        },
                        new
                        {
                            CatigoryId = 9,
                            CatigoryName = "Programming Language"
                        },
                        new
                        {
                            CatigoryId = 10,
                            CatigoryName = "Data Structures and Algorithms"
                        },
                        new
                        {
                            CatigoryId = 11,
                            CatigoryName = "Artificial Intelligence"
                        },
                        new
                        {
                            CatigoryId = 12,
                            CatigoryName = "Object Oriented Programming"
                        },
                        new
                        {
                            CatigoryId = 13,
                            CatigoryName = "Refactoring"
                        },
                        new
                        {
                            CatigoryId = 14,
                            CatigoryName = "Networks"
                        },
                        new
                        {
                            CatigoryId = 15,
                            CatigoryName = "DevOps"
                        },
                        new
                        {
                            CatigoryId = 16,
                            CatigoryName = "Version Control"
                        },
                        new
                        {
                            CatigoryId = 17,
                            CatigoryName = "Software Architecture"
                        },
                        new
                        {
                            CatigoryId = 18,
                            CatigoryName = "Microservices"
                        },
                        new
                        {
                            CatigoryId = 19,
                            CatigoryName = "Containerization"
                        },
                        new
                        {
                            CatigoryId = 20,
                            CatigoryName = "Security"
                        },
                        new
                        {
                            CatigoryId = 21,
                            CatigoryName = "Cloud Computing"
                        },
                        new
                        {
                            CatigoryId = 22,
                            CatigoryName = "Agile"
                        },
                        new
                        {
                            CatigoryId = 23,
                            CatigoryName = "Data Science"
                        },
                        new
                        {
                            CatigoryId = 24,
                            CatigoryName = "Computer Science"
                        },
                        new
                        {
                            CatigoryId = 25,
                            CatigoryName = "Operating Systems"
                        },
                        new
                        {
                            CatigoryId = 26,
                            CatigoryName = "Mobile Development"
                        },
                        new
                        {
                            CatigoryId = 27,
                            CatigoryName = "Infrastructure as a Code"
                        },
                        new
                        {
                            CatigoryId = 28,
                            CatigoryName = "Design Patterns"
                        });
                });

            modelBuilder.Entity("DAL.Entities.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CommentId"));

                    b.Property<DateTime>("CommentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("CommentId");

                    b.HasIndex("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("DAL.Entities.Like", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(64)");

                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "PostId");

                    b.HasIndex("PostId");

                    b.ToTable("Likes");
                });

            modelBuilder.Entity("DAL.Entities.Messege", b =>
                {
                    b.Property<int>("MessegeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MessegeID"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("VARCHAR(MAX)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(126)");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("VARCHAR(MAX)");

                    b.Property<string>("UserID")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("MessegeID");

                    b.HasIndex("UserID");

                    b.ToTable("Messeges", (string)null);
                });

            modelBuilder.Entity("DAL.Entities.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PostId"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<string>("Image")
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<bool>("IsAviable")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<DateTime>("PostDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PostType")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(255)");

                    b.Property<int>("TotalLikes")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("PostId");

                    b.HasIndex("UserId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("DAL.Entities.PostCatigory", b =>
                {
                    b.Property<int>("PostId")
                        .HasColumnType("int");

                    b.Property<int>("CatigoryId")
                        .HasColumnType("int");

                    b.HasKey("PostId", "CatigoryId");

                    b.HasIndex("CatigoryId");

                    b.ToTable("PostCatigories");
                });

            modelBuilder.Entity("DAL.Entities.Request", b =>
                {
                    b.Property<int>("RequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RequestId"));

                    b.Property<DateTime?>("AcceptDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("AdminId")
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Notes")
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("RequestId");

                    b.HasIndex("AdminId");

                    b.HasIndex("UserId");

                    b.ToTable("Requests", (string)null);
                });

            modelBuilder.Entity("DAL.Entities.SocielMediaUser", b =>
                {
                    b.Property<int>("SocielMediaUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SocielMediaUserId"));

                    b.Property<string>("SocielMediaType")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(512)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("SocielMediaUserId");

                    b.HasIndex("UserId");

                    b.ToTable("SocielMediaUsers", (string)null);
                });

            modelBuilder.Entity("DAL.Entities.UserReview", b =>
                {
                    b.Property<int>("UserReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserReviewId"));

                    b.Property<string>("Messege")
                        .HasColumnType("NVARCHAR(MAX)");

                    b.Property<byte>("Rate")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("ReviewDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReviewToId")
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("UserReviewId");

                    b.HasIndex("ReviewToId");

                    b.HasIndex("UserId");

                    b.ToTable("UserReviews", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "1a3a4b39-4cb9-432b-8e2b-8eba3ce78bad",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "287321f4-5bda-4ae6-ad53-109878376a14",
                            Name = "Auther",
                            NormalizedName = "AUTHER"
                        },
                        new
                        {
                            Id = "df11c404-c205-448a-97fb-a8f81f4904aa",
                            Name = "User",
                            NormalizedName = "USER"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("DAL.Entities.ApplicationUser", b =>
                {
                    b.OwnsOne("DAL.Entities.ProfilePhoto", "ProfilePhoto", b1 =>
                        {
                            b1.Property<string>("ApplicationUserId")
                                .HasColumnType("nvarchar(64)");

                            b1.Property<string>("ImageName")
                                .HasColumnType("NVARCHAR (MAX)")
                                .HasColumnName("ImageName");

                            b1.Property<string>("URL")
                                .HasColumnType("NVARCHAR(MAX)")
                                .HasColumnName("URL");

                            b1.HasKey("ApplicationUserId");

                            b1.ToTable("AspNetUsers");

                            b1.WithOwner()
                                .HasForeignKey("ApplicationUserId");
                        });

                    b.Navigation("ProfilePhoto");
                });

            modelBuilder.Entity("DAL.Entities.Comment", b =>
                {
                    b.HasOne("DAL.Entities.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.ApplicationUser", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Entities.Like", b =>
                {
                    b.HasOne("DAL.Entities.Post", "Post")
                        .WithMany("Likes")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.ApplicationUser", "User")
                        .WithMany("Likes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Entities.Messege", b =>
                {
                    b.HasOne("DAL.Entities.ApplicationUser", "User")
                        .WithMany("Messeges")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Entities.Post", b =>
                {
                    b.HasOne("DAL.Entities.ApplicationUser", "User")
                        .WithMany("Posts")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Entities.PostCatigory", b =>
                {
                    b.HasOne("DAL.Entities.Catigory", "Catigory")
                        .WithMany()
                        .HasForeignKey("CatigoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Catigory");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("DAL.Entities.Request", b =>
                {
                    b.HasOne("DAL.Entities.ApplicationUser", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminId");

                    b.HasOne("DAL.Entities.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Admin");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Entities.SocielMediaUser", b =>
                {
                    b.HasOne("DAL.Entities.ApplicationUser", "User")
                        .WithMany("Links")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("DAL.Entities.UserReview", b =>
                {
                    b.HasOne("DAL.Entities.ApplicationUser", "ReviewTo")
                        .WithMany("Reviews")
                        .HasForeignKey("ReviewToId");

                    b.HasOne("DAL.Entities.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("ReviewTo");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("DAL.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("DAL.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("DAL.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Entities.ApplicationUser", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Likes");

                    b.Navigation("Links");

                    b.Navigation("Messeges");

                    b.Navigation("Posts");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("DAL.Entities.Post", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Likes");
                });
#pragma warning restore 612, 618
        }
    }
}
