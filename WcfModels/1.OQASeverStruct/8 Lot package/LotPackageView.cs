using System.Collections.Generic;
using System.Runtime.Serialization;
using WCFModels.Message;

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

        public LotPackageView()
        {
            packageImgList = new List<ISPIMGDEF>();
        }
    }
}