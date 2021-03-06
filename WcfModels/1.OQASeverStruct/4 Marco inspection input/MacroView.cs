﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;

namespace WCFModels.OQA
{
    public class MacroView : BaseRsp
    {
        //服务传入执行动作,事务标记必须输入
        [DataMember]
        public char c_proc_step { get; set; }
        [DataMember]
        public char c_tran_flag { get; set; }
        //服务传入参数
        [DataMember]
        public string in_isp_type { get; set; }
        [DataMember]
        public string in_isp_code { get; set; }
        //服务传出数据结构

        [DataMember]
        public string LotId { get; set; }
        [DataMember]
        public string SlotId { get; set; }
        [DataMember]
        public string WaferId { get; set; }
        [DataMember]
        public string SideType { get; set; }
        [DataMember]
        public string InspectType { get; set; }
        [DataMember]
        public string IsInspect { get; set; }
        [DataMember]
        public string InspectPoint { get; set; }
        [DataMember]
        public string InspectResult { get; set; }
        public string DefectDesc { get; set; }
        [DataMember]
        public string Cmt { get; set; }
        public List<ISPWAFDFT> ISPWAFDFT_list { get; set; }

        [DataMember]
        public string ImageId { get; set; }
        [DataMember]
        public string ImagePath { get; set; }
        [DataMember]
        public string ImageName { get; set; }
        [DataMember]
        public string ImageType { get; set; }
    }
}
