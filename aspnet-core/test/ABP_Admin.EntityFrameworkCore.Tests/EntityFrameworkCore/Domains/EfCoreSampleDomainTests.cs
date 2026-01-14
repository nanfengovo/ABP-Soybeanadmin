using ABP_Admin.Samples;
using Xunit;

namespace ABP_Admin.EntityFrameworkCore.Domains;

[Collection(ABP_AdminTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ABP_AdminEntityFrameworkCoreTestModule>
{

}
