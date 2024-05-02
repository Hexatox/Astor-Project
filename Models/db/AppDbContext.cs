using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility.Enum;

namespace DAL.db
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options) 
        {
                
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfigurationsFromAssembly (typeof (AppDbContext).Assembly); // for Entities Configuration
            SeedUsersRoles seed = new SeedUsersRoles();


            builder.Entity<IdentityRole>()
                .HasData(seed.roles);

            builder.Entity<ApplicationUser>()
                .HasData(seed.users);

            //builder.Entity<IdentityUserRole<string>>()
              //  .HasData(seed.roles);        // this line is not works When run the Migration 
        }
        public DbSet <Catigory> Catigories { get; set; }
        public DbSet <Comment> Comments { get; set; }
        public DbSet <Like> Likes {  get; set; }
        public DbSet <Messege> Messeges { get; set; }
        public DbSet <Post> Posts { get; set; }
        public DbSet <PostCatigory> PostCatigories { get; set; }
        public DbSet <Request> Requests { get; set; }
        public DbSet <SocielMediaUser> SocielMediaUsers { get; set; }
        public DbSet <UserReview> UserReviews { get; set; }
    }
}

// Seeding Defult date Data
public class SeedUsersRoles
{
    private readonly List<IdentityRole> _roles;
    private readonly List<ApplicationUser> _users;
    private readonly List<IdentityUserRole<string>> _userRoles;
    public SeedUsersRoles()
    {
        _roles = GetRoles();
        _users = GetUsers();
        _userRoles = GetUserRoles(_users, _roles);
    }

    public List<IdentityRole> roles { get { return _roles; } }
    public List<ApplicationUser> users { get { return _users; } }
    public List<IdentityUserRole<string>> userRoles { get { return _userRoles; } }

    private List<IdentityRole> GetRoles()
    {

        // Seed Roles
        var adminRole = new IdentityRole(Roles.Admin.ToString());
        adminRole.NormalizedName = adminRole.Name!.ToUpper();
        adminRole.Id = "1a3a4b39-4cb9-432b-8e2b-8eba3ce78bad";

        var AutherRole = new IdentityRole(Roles.Auther.ToString());
        AutherRole.NormalizedName = AutherRole.Name!.ToUpper();
        AutherRole.Id = "287321f4-5bda-4ae6-ad53-109878376a14";

        var UserRole = new IdentityRole(Roles.User.ToString());
        UserRole.NormalizedName = UserRole.Name!.ToUpper();
        UserRole.Id = "df11c404-c205-448a-97fb-a8f81f4904aa";

        List<IdentityRole> roles = new List<IdentityRole>() {
           adminRole,
           AutherRole,
           UserRole
        };

        return roles;
    }

    private List<ApplicationUser> GetUsers()
    {

        string pwd = "DefaultPasword12??";
        var passwordHasher = new PasswordHasher<ApplicationUser>();

        // Seed Users
        var adminUser = new ApplicationUser
        {
            Id = "1d35e3ea-fb63-482f-b7f7-daf830fc6285",
            UserName = "Admin@gmail.com",
            Email = "Admin@gmail.com",
            EmailConfirmed = true,
            Firstname = "Astor",
            Lastname = "Admin",
            Bio = "I am Defult Admin",
            isBlocked = true
        };
        adminUser.NormalizedUserName = adminUser.UserName.ToUpper();
        adminUser.NormalizedEmail = adminUser.Email.ToUpper();
        adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, pwd);

        var AutherUser = new ApplicationUser
        {
            Id = "1121e9a5-f1f1-434b-a55d-bbe9d7a6b590",
            UserName = "Auther@gmil.com",
            Email = "Auther@gmil.com",
            EmailConfirmed = true,
            Firstname = "Astor",
            Lastname = "Auther",
            Bio = "I am Defult Auther",
            isBlocked = true
        };
        AutherUser.NormalizedUserName = AutherUser.UserName.ToUpper();
        AutherUser.NormalizedEmail = AutherUser.Email.ToUpper();
        AutherUser.PasswordHash = passwordHasher.HashPassword(AutherUser, pwd);

        var UserUser = new ApplicationUser
        {
            Id = "b178fae6-61f1-4b54-9480-021cf483faf8",
            UserName = "User@gmil.com",
            Email = "User@gmil.com",
            EmailConfirmed = true,
            Firstname = "Astor",
            Lastname = "User",
            Bio = "I am Defult User",
            isBlocked = true
        };
        UserUser.NormalizedUserName = UserUser.UserName.ToUpper();
        UserUser.NormalizedEmail = UserUser.Email.ToUpper();
        UserUser.PasswordHash = passwordHasher.HashPassword(UserUser, pwd);

        List<ApplicationUser> users = new List<ApplicationUser>() {
           adminUser,
           AutherUser,
           UserUser
        };

        return users;
    }

    private List<IdentityUserRole<string>> GetUserRoles(List<ApplicationUser> users, List<IdentityRole> roles)
    {
        // Seed UserRoles
        List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();

        userRoles.Add(new IdentityUserRole<string>
        {
            UserId = "1d35e3ea-fb63-482f-b7f7-daf830fc6285",
            RoleId = "1a3a4b39-4cb9-432b-8e2b-8eba3ce78bad"
        });

        userRoles.Add(new IdentityUserRole<string>
        {
            UserId = "1121e9a5-f1f1-434b-a55d-bbe9d7a6b590",
            RoleId = "287321f4-5bda-4ae6-ad53-109878376a14"
        });

        userRoles.Add(new IdentityUserRole<string>
        {
            UserId = "b178fae6-61f1-4b54-9480-021cf483faf8",
            RoleId = "df11c404-c205-448a-97fb-a8f81f4904aa"
        });

        return userRoles;
    }
}