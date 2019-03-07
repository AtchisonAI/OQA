using System.Collections.Generic;
using System.Runtime.Serialization;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;

namespace WCFModels.OQA
{
    [DataContract]
    public class DefectCodeSave : BaseRsp
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
        public string IN_ISP_TYPE {
            get
            {
                return in_isp_type;
            }
            set
            {
                in_isp_type = value;
            }
        }
        private string in_isp_type;
        [DataMember]
        public string IN_ISP_CODE {
            get
            {
                return in_isp_code;
            }
            set
            {
                in_isp_code = value;
            }
        }
        private string in_isp_code;
        [DataMember]
        public string IN_CODE_DESC
        {
            get
            {
                return in_code_desc;
            }
            set
            {
                in_code_desc = value;
            }
        }
        private string in_code_desc;


    }
}