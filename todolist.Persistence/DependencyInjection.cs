using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TodoList.Persistence.DBContext;

namespace TodoList.Persistence
{
    public static class DependencyInjection
    {
        public static void AddPersistence(this WebApplicationBuilder webAppBuilder)
        {
            webAppBuilder.AddDatabases();
        }

        internal static void AddDatabases(this WebApplicationBuilder webAppBuilder)
        {
            // Register Database Context - Different patterns supported at design time, https://learn.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli
            webAppBuilder.Services.AddDbContextFactory<TodoContext>(opt => opt.UseSqlServer(webAppBuilder.Configuration.GetConnectionString("TodoList")), ServiceLifetime.Singleton);
        }
    }
}
