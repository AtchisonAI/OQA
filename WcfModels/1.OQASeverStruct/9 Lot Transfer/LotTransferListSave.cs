using System.Collections.Generic;
using System.Runtime.Serialization;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;

namespace WCFModels.OQA
{
    [DataContract]
    public class LotTransferListSave : BaseRsp
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

        //服务传入参数
        [DataMember]
        public string IN_PART_ID
        {
            get
            {
                return in_part_id;
            }
            set
            {
                in_part_id = value;
            }
        }
        private string in_part_id;
        [DataMember]
        public string IN_LOTID
        {
            get
            {
                return in_lotid;
            }
            set
            {
                in_lotid = value;
            }
        }
        private string in_lotid;
        [DataMember]
        public string IN_QTY
        {
            get
            {
                return in_qty;
            }
            set
            {
                in_qty = value;
            }
        }
        private string in_qty;
        [DataMember]
        public string IN_ISP_RESULT
        {
            get
            {
                return in_isp_result;
            }
            set
            {
                in_isp_result = value;
            }
        }
        private string in_isp_result;
        [DataMember]
        public string IN_SHIPID
        {
            get
            {
                return in_shipid;
            }
            set
            {
                in_shipid = value;
            }
        }
        private string in_shipid;

    }
}