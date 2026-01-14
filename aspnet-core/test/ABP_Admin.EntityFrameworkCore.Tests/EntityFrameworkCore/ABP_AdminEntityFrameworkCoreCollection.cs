using Xunit;

namespace ABP_Admin.EntityFrameworkCore;

[CollectionDefinition(ABP_AdminTestConsts.CollectionDefinitionName)]
public class ABP_AdminEntityFrameworkCoreCollection : ICollectionFixture<ABP_AdminEntityFrameworkCoreFixture>
{

}
