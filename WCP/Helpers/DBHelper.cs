﻿using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using WCP.Context;
using WCP.Seeds;

namespace WCP.Helpers
{
    public static class DBHelper
    {

        public static IServiceCollection AddSqliteDB(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CompanyContext>(opts => opts.UseSqlite(configuration.GetConnectionString("LocalDB")));

            return services;
        }

        public static void SeedData(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                CompanyContext dbContext = scope.ServiceProvider.GetRequiredService<CompanyContext>();

                dbContext.Seed();
            }
        }
    }
}
