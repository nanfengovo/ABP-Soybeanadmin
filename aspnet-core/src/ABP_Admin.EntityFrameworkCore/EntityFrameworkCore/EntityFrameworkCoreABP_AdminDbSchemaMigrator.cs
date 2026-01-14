using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ABP_Admin.Data;
using Volo.Abp.DependencyInjection;

namespace ABP_Admin.EntityFrameworkCore;

public class EntityFrameworkCoreABP_AdminDbSchemaMigrator
    : IABP_AdminDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreABP_AdminDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the ABP_AdminDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ABP_AdminDbContext>()
            .Database
            .MigrateAsync();
    }
}
