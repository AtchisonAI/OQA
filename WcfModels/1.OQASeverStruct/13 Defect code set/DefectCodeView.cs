﻿using System.Collections.Generic;
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

        public DefectCodeView()
        {
            ISPDFTDEF_list = new List<ISPDFTDEF>();
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