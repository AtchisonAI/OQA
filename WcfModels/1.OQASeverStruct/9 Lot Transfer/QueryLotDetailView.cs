using System.Collections.Generic;
using System.Runtime.Serialization;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;

namespace WCFModels.OQA
{
    [DataContract]
    public class QueryLotDetailView : BaseRsp
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

       // public QueryLotDetailView()
        //{
         //   PKGSHPDAT_list = new List<PKGSHPDAT>();
       // }

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
        public string IN_MASTERLOT_NO
        {
            get
            {
                return in_masterlot_no;
            }
            set
            {
                in_masterlot_no= value;
            }
        }
        private string in_masterlot_no;

        [DataMember]
        public string IN_SEARCHLOTID_NO
        {
            get
            {
                return in_msearchlot_no;
            }
            set
            {
                in_msearchlot_no = value;
            }
        }
        private string in_msearchlot_no;
        // 服务传出数据结构
        [DataMember]
       // public List<ISPLOTSTS> PKGSHPDAT_list { get; set; }
         public List<object[]> PKGSHPDAT_list { get; set; }
        [DataMember]
        public List<object[]> SEARCHLOTID_list { get; set; }//select like


        //服务传出结果在BaseRsq:_success  _ErrorMsg
    }
}