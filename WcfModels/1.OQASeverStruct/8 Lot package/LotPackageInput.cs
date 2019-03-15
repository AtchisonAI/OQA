using System.Collections.Generic;
using System.Runtime.Serialization;
using WCFModels.Message;

namespace WCFModels.OQA
{
    [DataContract]
    public class LotPackageInput
    {
        //服务传入执行动作,事务标记必须输入
        [DataMember]
        public string lotId { get; set; }
    }

    public class DeletePackageImgReq :UpdateReq
    {
        public DeletePackageImgReq()
        {
            operateType = OperateType.Delete;
        }

        //服务传入执行动作,事务标记必须输入
        [DataMember]
        public string lotId { get; set; }
    }
}