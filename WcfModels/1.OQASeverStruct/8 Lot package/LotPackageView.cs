using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCFModels.OQA
{
    [DataContract]
    public class LotPackageView
    {
        //服务传入执行动作,事务标记必须输入
        [DataMember]
        public ISPLOTSTS lotInfo;

        [DataMember]
        public List<ISPIMGDEF> packageImgList;

        [DataMember]
        public List<PKGCHKRST> packageCheckList;

        public LotPackageView()
        {
            packageImgList = new List<ISPIMGDEF>();
            packageCheckList = new List<PKGCHKRST>();
        }
    }
}