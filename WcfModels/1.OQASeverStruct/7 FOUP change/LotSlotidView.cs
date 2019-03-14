using System.Collections.Generic;
using System.Runtime.Serialization;
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
            OQA_CHKMESSLOTID_list = new List<OQA_CHKMESSLOTID>();
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


        [DataMember]
        public decimal D_TRANSSEQ
        {
            get
            {
                return d_transseq;
            }
            set
            {
                d_transseq = value;
            }
        }

        private decimal d_transseq;


        //服务传出数据结构
        [DataMember]
        public List<ISPLOTSTS> ISPLOTSTS_list { get; set; }

        [DataMember]
        public List<ISPWAFST> ISPWAFST_list { get; set; }

        [DataMember]
        public List<OQA_CHKMESSLOTID> OQA_CHKMESSLOTID_list { get; set; }
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