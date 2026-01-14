using Volo.Abp.Modularity;

namespace ABP_Admin;

[DependsOn(
    typeof(ABP_AdminApplicationModule),
    typeof(ABP_AdminDomainTestModule)
)]
public class ABP_AdminApplicationTestModule : AbpModule
{

}
