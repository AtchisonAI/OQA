using System.Collections.Generic;
using System.Runtime.Serialization;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;

namespace WCFModels.OQA
{
    [DataContract]
    public class ShipIDListView : BaseRsp
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

        public ShipIDListView()
        {
            SHIPIDLIST_list = new List<PKGSHPSTS>();
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
        public string IN_SEARCHSHIP_NO
        {
            get
            {
                return in_searchship_no;
            }
            set
            {
                in_searchship_no = value;
            }
        }
        private string in_searchship_no;
        [DataMember]
        public string IN_SEARCHBYDATE_NO
        {
            get
            {
                return in_searchbydate_no;
            }
            set
            {
                in_searchbydate_no = value;
            }
        }
        private string in_searchbydate_no;

        //服务传出数据结构
        [DataMember]
        public List<PKGSHPSTS> SHIPIDLIST_list { get; set; }
        //服务传出结果在BaseRsq:_success  _ErrorMsg
        [DataMember]
        public List<object[]> SEARCHshipID_list { get; set; }//select like

    }
}