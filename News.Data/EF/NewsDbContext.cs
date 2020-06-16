using IdentityServer4.EntityFramework.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using News.Data.Configuarations;
using News.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace News.Data.EF
{
    public class NewsDbContext : IdentityDbContext<AppUser, AppRole, Guid>

    {
        public NewsDbContext(DbContextOptions options) : base(options)
        {
        }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ChuyenMucConfiguration());
            modelBuilder.ApplyConfiguration(new LoaiTinConfiguration());
            modelBuilder.ApplyConfiguration(new TinTucConfiguration());
            modelBuilder.ApplyConfiguration(new DemConfiguration());

            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x=>x.UserId);

            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);
        }
        public DbSet<ChuyenMuc> ChuyenMucs { get; set; }
        public DbSet<Dem> Dems { get; set; }
        public DbSet<LoaiTin> LoaiTins { get; set; }
        public DbSet<TinTuc> TinTucs { get; set; }



    }
}
