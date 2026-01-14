using ABP_Admin.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ABP_Admin.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ABP_AdminEntityFrameworkCoreModule),
    typeof(ABP_AdminApplicationContractsModule)
    )]
public class ABP_AdminDbMigratorModule : AbpModule
{
}
