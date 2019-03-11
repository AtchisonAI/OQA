using System.Collections.Generic;
using System.Runtime.Serialization;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;

namespace WCFModels.OQA
{
    [DataContract]
    public class DefectCodeView: BaseRsp
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
        public List<ISPDFTDEF> ISPDFTDEF_list { get; set; }
        //服务传出结果在BaseRsq:_success  _ErrorMsg


        //public DefectCodeView()
        //{
        //    rmsList = new List<RmsUser>();
        //}
        //    string s_isp_type ;

        //   // rmsList = new List<RmsUser>();
        //

        //[DataMember]
        //public List<RmsUser> rmsList { get; set; }
    }
}