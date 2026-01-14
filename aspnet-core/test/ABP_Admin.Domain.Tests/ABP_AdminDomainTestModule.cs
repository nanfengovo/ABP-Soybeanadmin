using Volo.Abp.Modularity;

namespace ABP_Admin;

[DependsOn(
    typeof(ABP_AdminDomainModule),
    typeof(ABP_AdminTestBaseModule)
)]
public class ABP_AdminDomainTestModule : AbpModule
{

}
