using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCFModels.Message
{
    [DataContract]
    public class UserProfile
    {
        public UserProfile(string id,string password,string prefix)
        {
            userId = id;
            passwd = password;
            systemPrefix = prefix;
        }

        [DataMember]
        public string userId { get; set; }

        [DataMember]
        public string passwd { get; set; }

        [DataMember]
        public string systemPrefix { get; set; }
    }
}
