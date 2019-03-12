using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;

namespace WCFModels.OQA
{
    [DataContract]
    public class ImageSave : BaseRsp
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
        public ImageSave()
        {
            ISPIMGDEF_List = new List<ISPIMGDEF>();
        }
        [DataMember]
        public List<ISPIMGDEF> ISPIMGDEF_List { get; set; }
        [DataMember]
        public string PicStreamBase64
        {
            get
            {
                return sm;
            }
            set
            {
                sm = value;
            }
        }
        private string sm;

    }
}