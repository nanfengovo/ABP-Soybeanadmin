using System.Threading.Tasks;

namespace ABP_Admin.Data;

public interface IABP_AdminDbSchemaMigrator
{
    Task MigrateAsync();
}
