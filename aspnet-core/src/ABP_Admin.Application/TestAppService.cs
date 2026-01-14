using System;
using Volo.Abp.Application.Services;

namespace ABP_Admin
{
    /// <summary>
    /// 测试应用服务实现
    /// </summary>
    public class TestAppService : ApplicationService, ITestAppService
    {
        /// <summary>
        /// 获取测试数据的实现
        /// </summary>
        /// <returns>返回测试字符串</returns>
        public string GetTest()
        {
            return "This is a test app service.";
        }

        /// <summary>
        /// 新增测试的实现
        /// </summary>
        /// <param name="input">输入参数</param>
        /// <returns>返回生成的ID</returns>
        public string CreateTest(string input)
        {
            return Guid.NewGuid().ToString();
        }
    }
}
