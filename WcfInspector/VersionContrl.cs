using System.Collections.Generic;

namespace WcfInspector
{
    public class VersionContrl
    {
        public static string clientVersion { get; set; }
        public static string serverVersion { get; set; }


        public static bool MatchVersion(string clientVer)
        {
            return serverVersion.Equals(clientVer);
        }
    }
}
