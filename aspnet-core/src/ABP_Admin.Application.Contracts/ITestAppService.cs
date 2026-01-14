using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABP_Admin
{
    /// <summary>
    /// 测试应用服务接口
    /// </summary>
    public interface ITestAppService
    {
        /// <summary>
        /// 获取测试数据
        /// </summary>
        /// <returns>返回测试字符串</returns>
        public string GetTest();

        /// <summary>
        /// 新增测试
        /// </summary>
        /// <param name="input">输入参数</param>
        /// <returns>返回ID</returns>
        public string CreateTest(string input);
    }
}
