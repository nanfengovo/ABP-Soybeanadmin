using ABP_Admin.Samples;
using Xunit;

namespace ABP_Admin.EntityFrameworkCore.Applications;

[Collection(ABP_AdminTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ABP_AdminEntityFrameworkCoreTestModule>
{

}
