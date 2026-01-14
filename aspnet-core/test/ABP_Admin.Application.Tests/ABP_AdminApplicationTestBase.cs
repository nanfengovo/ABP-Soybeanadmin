using Volo.Abp.Modularity;

namespace ABP_Admin;

public abstract class ABP_AdminApplicationTestBase<TStartupModule> : ABP_AdminTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
