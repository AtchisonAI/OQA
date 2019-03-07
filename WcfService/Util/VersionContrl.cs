using System.Collections.Generic;

namespace WcfService
{
    public class VersionContrl
    {
        //服务端与客户端版本映射表，key为服务端version，value为对应的服务端版本号列表
        public static readonly List<string> allowCVersionList = new List<string>
        {
            { "1.0.0" } 
        };

        public static bool MatchVersion(string clientVer)
        {
            return allowCVersionList.Contains(clientVer);
        }
    }
}
