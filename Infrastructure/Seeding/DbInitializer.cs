using Application.Contracts.Seeding;
using Application.Features.User.Command.Register;
using Infrastructure.Data;
using Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Seeding
{
    public class DbInitializer : IDbInitializer
    {
        private readonly AppDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public DbInitializer(AppDbContext db, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public async Task Initialize()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (_db.Roles.Any(r => r.Name == UserRole.Admin.ToString()))
                await Task.CompletedTask;

            await _roleManager.CreateAsync(new IdentityRole(UserRole.Admin.ToString()));
            await _roleManager.CreateAsync(new IdentityRole(UserRole.User.ToString()));

            await _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "admin@panel.com",
                Email = "admin@panel.com",
                NormalizedEmail = "admin@panel.com".ToUpper(),
                NormalizedUserName = "admin@panel.com".ToUpper(),
                EmailConfirmed = true,
                PhoneNumber = "01018332323",
            }, "3QwAs_18_12");

            ApplicationUser user = await _userManager.FindByEmailAsync("admin@panel.com");
            await _userManager.AddToRoleAsync(user, UserRole.Admin.ToString());
        }
    }
}