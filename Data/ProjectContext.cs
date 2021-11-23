using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using firstApplication.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

public class ProjectContext : IdentityDbContext
    {
        public ProjectContext (DbContextOptions<ProjectContext> options)
            : base(options)
        {
        }

        public DbSet<firstApplication.Models.Projects> Projects { get; set; }

        public DbSet<firstApplication.Models.Leaders> Leaders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityUser>(entity=>
            {
                entity.ToTable(name: "User");
            });
              builder.Entity<IdentityRole>(entity=>
            {
                entity.ToTable(name: "Role");
            });
              builder.Entity<IdentityUserRole <string>>(entity=>
            {
                entity.ToTable(name: "UserRoles");
            });
              builder.Entity<IdentityUserClaim<string>>(entity=>
            {
                entity.ToTable(name: "UserClaims");
            });
              builder.Entity<IdentityUserLogin<string>>(entity=>
            {
                entity.ToTable(name: "UserLogins");
            });
               builder.Entity<IdentityRoleClaim<string>>(entity=>
            {
                entity.ToTable(name: "RoleClaims");
            });
              builder.Entity<IdentityUserToken<string>>(entity=>
            {
                entity.ToTable(name: "UserTokens");
            });
        }
    }
