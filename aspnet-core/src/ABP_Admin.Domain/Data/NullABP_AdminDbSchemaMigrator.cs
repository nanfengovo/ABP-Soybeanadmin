using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ABP_Admin.Data;

/* This is used if database provider does't define
 * IABP_AdminDbSchemaMigrator implementation.
 */
public class NullABP_AdminDbSchemaMigrator : IABP_AdminDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
