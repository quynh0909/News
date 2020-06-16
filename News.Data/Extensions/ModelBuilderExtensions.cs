using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using News.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace News.Data.Extensions
{
    public  static class ModelBuilderExtensions
    {

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChuyenMuc>().HasData(
                new ChuyenMuc() { CateID = 1, CateName = "Sao", CateTT = 1, CateHide = CateHide.Hide },
                new ChuyenMuc() { CateID = 2, CateName = "Âm nhạc", CateTT = 2, CateHide = CateHide.Hide },
                new ChuyenMuc() { CateID = 3, CateName = "Cộng đồng mạng", CateTT = 3, CateHide = CateHide.Hide },
                new ChuyenMuc() { CateID = 4, CateName = "Cine", CateTT = 4, CateHide = CateHide.Hide },
                new ChuyenMuc() { CateID = 5, CateName = "Đời sống", CateTT = 5, CateHide = CateHide.Hide },
                new ChuyenMuc() { CateID = 6, CateName = "Check-in", CateTT = 6, CateHide = CateHide.Hide },
                new ChuyenMuc() { CateID = 7, CateName = "Đẹp", CateTT = 7, CateHide = CateHide.Hide },
                new ChuyenMuc() { CateID = 8, CateName = "mega", CateTT = 8, CateHide = CateHide.Hide },
                new ChuyenMuc() { CateID = 9, CateName = "Thể thao", CateTT = 9, CateHide = CateHide.Hide }
            );
            // any guid
            var roleId = new Guid("50C061EA-85BA-4EA8-B70C-BB8FB074BFF0");
            var adminId = new Guid("76314C61-6CC3-49AF-BB21-C6736A3E6C47");
            // any guid, but nothing is against to use the same one
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            });

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "1754052064Quynh@ou.edu.vn",
                NormalizedEmail = "some-admin-email@nonce.fake",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "090999"),
                SecurityStamp = string.Empty,
                FirstName = "Quynh",
                LastName = "Tran"
            });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>
            {
                RoleId = roleId,
                UserId = adminId
            });
        }
        
            
    }
}
