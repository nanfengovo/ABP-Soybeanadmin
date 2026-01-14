using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ABP_Admin.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class ABP_AdminDbContextFactory : IDesignTimeDbContextFactory<ABP_AdminDbContext>
{
    public ABP_AdminDbContext CreateDbContext(string[] args)
    {
        ABP_AdminEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<ABP_AdminDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new ABP_AdminDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ABP_Admin.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
