﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using WCFModels.Message;

namespace WCFModels.OQA
{
    [DataContract]
    public class LotSlotidSave: BaseRsp
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

        public LotSlotidSave()
        {
            PkgsltdefList = new List<PKGSLTDEF>();
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

        //[DataMember]
        //public string IN_WAFER_ID
        //{
        //    get
        //    {
        //        return in_wafer_id;
        //    }
        //    set
        //    {
        //        in_wafer_id = value;
        //    }
        //}
        //private string in_wafer_id;

        //[DataMember]
        //public string IN_SLOT_ID
        //{
        //    get
        //    {
        //        return in_slot_id;
        //    }
        //    set
        //    {
        //        in_slot_id = value;
        //    }
        //}
        //private string in_slot_id;


        //服务传出数据结构
        [DataMember]
        public List<PKGSLTDEF> PkgsltdefList { get; set; }
       
    }
}