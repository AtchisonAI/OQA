using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;

namespace WCFModels.OQA
{
    [DataContract]
    public class ISPLotSave : BaseRsp
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


        //服务传入参数
        [DataMember]
        public decimal D_TRAN_SEQ
        {
            get
            {
                return d_tran_seq;
            }
            set
            {
                d_tran_seq = value;
            }
        }
        private decimal d_tran_seq;
        [DataMember]
        public string S_LOT_ID
        {
            get
            {
                return s_lot_id;
            }
            set
            {
                s_lot_id = value;
            }
        }
        private string s_lot_id;
        [DataMember]
        public string S_USER_ID
        {
            get
            {
                return s_user_id;
            }
            set
            {
                s_user_id = value;
            }
        }
        private string s_user_id;
        [DataMember]
        public string S_USER_NAME
        {
            get
            {
                return s_user_name;
            }
            set
            {
                s_user_name = value;
            }
        }
        private string s_user_name;
        [DataMember]
        public string S_REC_SHIFT
        {
            get
            {
                return s_rec_shift;
            }
            set
            {
                s_rec_shift = value;
            }
        }
        private string s_rec_shift;
        [DataMember]
        public string S_PHONE
        {
            get
            {
                return s_phone;
            }
            set
            {
                s_phone = value;
            }
        }
        private string s_phone;
        [DataMember]
        public string S_DEPT
        {
            get
            {
                return s_dept;
            }
            set
            {
                s_dept = value;
            }
        }
        private string s_dept;

        public ISPLotSave()
        {
            ISPMESLOT_List = new List<OqaMeslot>();
            ISPMESWAFER_List = new List<OqaMeswafer>();
        }
        [DataMember]
        public List<OqaMeslot> ISPMESLOT_List { get; set; }
        [DataMember]
        public List<OqaMeswafer> ISPMESWAFER_List { get; set; }


    }
}