using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Firstname = table.Column<string>(type: "NVARCHAR(64)", nullable: false),
                    Lastname = table.Column<string>(type: "NVARCHAR(64)", nullable: false),
                    Bio = table.Column<string>(type: "NVARCHAR(MAX)", nullable: true),
                    ImageName = table.Column<string>(type: "NVARCHAR(max)", nullable: true),
                    URL = table.Column<string>(type: "NVARCHAR(MAX)", nullable: true),
                    isBlocked = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CatigoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatigoryName = table.Column<string>(type: "NVARCHAR(255)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CatigoryId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(64)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(64)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(64)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(64)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messeges",
                columns: table => new
                {
                    MessegeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<string>(type: "nvarchar(64)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fullname = table.Column<string>(type: "NVARCHAR(126)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(255)", nullable: false),
                    Subject = table.Column<string>(type: "VARCHAR(MAX)", nullable: false),
                    Content = table.Column<string>(type: "VARCHAR(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messeges", x => x.MessegeID);
                    table.ForeignKey(
                        name: "FK_Messeges_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostType = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Image = table.Column<string>(type: "NVARCHAR(MAX)", nullable: true),
                    Title = table.Column<string>(type: "NVARCHAR(255)", nullable: false),
                    Samary = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    Content = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(64)", nullable: true),
                    PostDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalLikes = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    IsAviable = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Posts_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    RequestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(64)", nullable: true),
                    AdminId = table.Column<string>(type: "nvarchar(64)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    AcceptDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "NVARCHAR(MAX)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.RequestId);
                    table.ForeignKey(
                        name: "FK_Requests_AspNetUsers_AdminId",
                        column: x => x.AdminId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Requests_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SocielMediaUsers",
                columns: table => new
                {
                    SocielMediaUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(64)", nullable: false),
                    SocielMediaType = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    URL = table.Column<string>(type: "NVARCHAR(512)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocielMediaUsers", x => x.SocielMediaUserId);
                    table.ForeignKey(
                        name: "FK_SocielMediaUsers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserReviews",
                columns: table => new
                {
                    UserReviewId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(64)", nullable: true),
                    ReviewToId = table.Column<string>(type: "nvarchar(64)", nullable: true),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rate = table.Column<byte>(type: "tinyint", nullable: false),
                    Messege = table.Column<string>(type: "NVARCHAR(MAX)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserReviews", x => x.UserReviewId);
                    table.ForeignKey(
                        name: "FK_UserReviews_AspNetUsers_ReviewToId",
                        column: x => x.ReviewToId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserReviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(64)", nullable: false),
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Content = table.Column<string>(type: "NVARCHAR(MAX)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(64)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => new { x.UserId, x.PostId });
                    table.ForeignKey(
                        name: "FK_Likes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Likes_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostCatigories",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false),
                    CatigoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostCatigories", x => new { x.PostId, x.CatigoryId });
                    table.ForeignKey(
                        name: "FK_PostCatigories_Categories_CatigoryId",
                        column: x => x.CatigoryId,
                        principalTable: "Categories",
                        principalColumn: "CatigoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostCatigories_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "PostId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1a3a4b39-4cb9-432b-8e2b-8eba3ce78bad", null, "Admin", "ADMIN" },
                    { "287321f4-5bda-4ae6-ad53-109878376a14", null, "Auther", "AUTHER" },
                    { "df11c404-c205-448a-97fb-a8f81f4904aa", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "isBlocked" },
                values: new object[,]
                {
                    { "1121e9a5-f1f1-434b-a55d-bbe9d7a6b590", 0, "I am Defult Auther", "5c486c25-c826-4f0a-ace6-2bd968a49181", "Auther@gmil.com", true, "Astor", "Auther", false, null, "AUTHER@GMIL.COM", "AUTHER@GMIL.COM", "AQAAAAIAAYagAAAAEOVWR398gTrKmQQsluEDsg0W7hW+oZAICS0DBdC4e3mzmAJ9d7VTIR4i6xPYLKryJA==", null, false, "a6e11ec6-9136-496e-aa65-33a446501924", false, "Auther@gmil.com", true },
                    { "1d35e3ea-fb63-482f-b7f7-daf830fc6285", 0, "I am Defult Admin", "09235e30-f7fb-464b-a6ca-b863514fd9a0", "Admin@gmail.com", true, "Astor", "Admin", false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEP+YpuztpBzFzuEGe6Of7urqmG/FqJI6bsciPQYGalytC1txRYYei2niwUj5UfgE8w==", null, false, "7a8eba57-2b28-4eff-8760-4e101b961c15", false, "Admin@gmail.com", true },
                    { "b178fae6-61f1-4b54-9480-021cf483faf8", 0, "I am Defult User", "614135b2-92eb-4619-a1f0-ccf03420ecad", "User@gmil.com", true, "Astor", "User", false, null, "USER@GMIL.COM", "USER@GMIL.COM", "AQAAAAIAAYagAAAAELHFdpmpCFqBd1wAUaHHS1m2Mq31mF1LIKwrbkkzjqyAd7jKvVlI4wMwY+vt2xkNKQ==", null, false, "282bfb93-2b8d-4e13-8e35-316861e880b3", false, "User@gmil.com", true }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CatigoryId", "CatigoryName" },
                values: new object[,]
                {
                    { 1, "Distributed Systems" },
                    { 2, "Backend" },
                    { 3, "System Design" },
                    { 4, "Databases" },
                    { 5, "Frontend" },
                    { 6, "Web Development" },
                    { 7, "Technologies & Frameworks" },
                    { 8, "Clean Code" },
                    { 9, "Programming Language" },
                    { 10, "Data Structures and Algorithms" },
                    { 11, "Artificial Intelligence" },
                    { 12, "Object Oriented Programming" },
                    { 13, "Refactoring" },
                    { 14, "Networks" },
                    { 15, "DevOps" },
                    { 16, "Version Control" },
                    { 17, "Software Architecture" },
                    { 18, "Microservices" },
                    { 19, "Containerization" },
                    { 20, "Security" },
                    { 21, "Cloud Computing" },
                    { 22, "Agile" },
                    { 23, "Data Science" },
                    { 24, "Computer Science" },
                    { 25, "Operating Systems" },
                    { 26, "Mobile Development" },
                    { 27, "Infrastructure as a Code" },
                    { 28, "Design Patterns" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CatigoryName",
                table: "Categories",
                column: "CatigoryName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Likes_PostId",
                table: "Likes",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Messeges_UserID",
                table: "Messeges",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_PostCatigories_CatigoryId",
                table: "PostCatigories",
                column: "CatigoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_AdminId",
                table: "Requests",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Requests_UserId",
                table: "Requests",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SocielMediaUsers_UserId",
                table: "SocielMediaUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserReviews_ReviewToId",
                table: "UserReviews",
                column: "ReviewToId");

            migrationBuilder.CreateIndex(
                name: "IX_UserReviews_UserId",
                table: "UserReviews",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropTable(
                name: "Messeges");

            migrationBuilder.DropTable(
                name: "PostCatigories");

            migrationBuilder.DropTable(
                name: "Requests");

            migrationBuilder.DropTable(
                name: "SocielMediaUsers");

            migrationBuilder.DropTable(
                name: "UserReviews");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
