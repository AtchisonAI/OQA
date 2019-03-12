using System.Collections.Generic;
using System.Runtime.Serialization;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;

namespace WCFModels.OQA
{
    [DataContract]
    public class LotSlotidView: BaseRsp
    {

        //服务传入执行动作,事务标记必须输入
        [DataMember]
        public char C_PROC_STEP
        {
            get
            {
                return c_proc_step;
            }
            set
            {
                c_proc_step = value;
            }
        }
        private char c_proc_step;

        public LotSlotidView()
        {
            PKGSLTDEF_list = new List<PKGSLTDEF>();
        }

        [DataMember]
        public char C_TRAN_FLAG
        {
            get
            {
                return c_tran_flag;
            }
            set
            {
                c_tran_flag = value;
            }
        }

        private char c_tran_flag;
        //服务传入参数
        [DataMember]
        public string IN_LOT_ID {
            get
            {
                return in_lot_id;
            }
            set
            {
                in_lot_id = value;
            }
        }
        private string in_lot_id;


        //服务传出数据结构
        [DataMember]
        public List<ISPLOTST> ISPLOTST_list { get; set; }

        [DataMember]
        public List<ISPWAFST> ISPWAFST_list { get; set; }

        [DataMember]
        public List<PKGSLTDEF> PKGSLTDEF_list { get; set; }
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