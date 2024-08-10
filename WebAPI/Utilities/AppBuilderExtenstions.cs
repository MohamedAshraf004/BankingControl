using Application.Contracts.Seeding;

namespace WebAPI.Utilities
{
    public static class AppBuilderExtenstions
    {
        public static async Task SeedDatabaseAsync(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var dbInitializer = scope.ServiceProvider.GetService<IDbInitializer>();
            if (dbInitializer != null)
                await dbInitializer.Initialize();
            await Task.CompletedTask;

        }
    }
}
