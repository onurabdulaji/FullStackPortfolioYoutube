﻿using FullStackPortfolio.Persistence.Context.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FullStackPortfolio.Persistence.Extensions;

public static class DatabaseExtension
{
    public static void AddDatabaseExtension(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
        });
    }
}
