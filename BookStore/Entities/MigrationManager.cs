using BookStore.Data;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Entities
{
    public static class MigrationManager
    {
        public static WebApplication MigrateDatabase(this WebApplication application) 
        {
            using (var scope = application.Services.CreateScope()) 
            {
                using (var appContext = scope.ServiceProvider.GetRequiredService<Context>()) 
                {
                    try 
                    {
                        appContext.Database.Migrate();
                    }
                    catch(Exception ex) 
                    {
                        throw;
                    }
                }
            }

            return application;
        }
    }
}
