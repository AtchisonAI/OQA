using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using WCFModels.MESDB.FWTST1;

namespace WCFModels.View
{
    [DataContract]
    public class DemoClass
    {
        [DataMember]
        List<Emp> ulist;

        [DataMember]
        List<RmsUser> rList;
    }
}
