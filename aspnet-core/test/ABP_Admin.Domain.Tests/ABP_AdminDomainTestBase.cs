using Volo.Abp.Modularity;

namespace ABP_Admin;

/* Inherit from this class for your domain layer tests. */
public abstract class ABP_AdminDomainTestBase<TStartupModule> : ABP_AdminTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
