using Models.Message;
using System.Collections.Generic;
using System.Runtime.Serialization;
using WCFModels.MESDB.FWTST1;

namespace WCFModels.Message
{
    [DataContract]
    public class DemoView
    {
        public DemoView()
        {
            empList = new List<Emp>();
            rmsList = new List<RmsUser>();
        }

        [DataMember]
        public List<Emp> empList { get; set; }

        [DataMember]
        public List<RmsUser> rmsList { get; set; }
    }
}