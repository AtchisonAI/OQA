﻿using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;

namespace WCFModels.OQA
{
    [DataContract]
    public class IspMesLot : BaseRsp
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
        public string C_LOT_ID
        {
            get
            {
                return c_lot_id;
            }
            set
            {
                c_lot_id = value;
            }
        }

        private string c_lot_id;


        [DataMember]
        public string C_FOUP_ID
        {
            get
            {
                return c_foup_id;
            }
            set
            {
                c_foup_id = value;
            }
        }

        private string c_foup_id;
        [DataMember]
        public string S_PNDN_NO
        {
            get
            {
                return s_pndn_no;
            }
            set
            {
                s_pndn_no = value;
            }
        }

        private string s_pndn_no;
        public IspMesLot()
        {
            OQAMESLOT_LIST = new List<OqaMeslot>();
            OQAMESWAFER_LIST = new List<OqaMeswafer>();
        }
        [DataMember]
        public List<OqaMeslot> OQAMESLOT_LIST { get; set; }           
        
        [DataMember]
        public List<OqaMeswafer> OQAMESWAFER_LIST { get; set; }

    }
}