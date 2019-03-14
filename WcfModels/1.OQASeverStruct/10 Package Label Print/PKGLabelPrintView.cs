using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;

namespace WCFModels.OQA
{
    [DataContract]
    public class PKGLabelPrintView : BaseRsp
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
       

        //服务传出数据结构
        [DataMember]
        public  List<object[]> PKGLabel_list { get; set; }

        //public partial class PKGLabel
        //{
        //    [DataMember]
        //    [Column("PartName")] public string PartName { get; set; }
        //    [DataMember]
        //    [Column("PartNo")] public string PartNo { get; set; }
        //    [DataMember]
        //    [Column("CustomerId")] public string CustomerId { get; set; }
        //    //[DataMember]
        //    //[Column("PartNameBarcode")] public string PartNameBarcode { get; set; }
        //    //[DataMember]
        //    //[Column("PartNoBarcode")] public string PartNoBarcode { get; set; }
        //    [DataMember]
        //    [Column("LotId")] public string LotId { get; set; }
        //    //[DataMember]
        //    //[Column("LotIdBarcode")] public string LotIdBarcode { get; set; }
        //    [DataMember]
        //    [Column("Slot")] public string Slot { get; set; }
        //    [DataMember]
        //    [Column("Quanitity")] public string Quanitity { get; set; }
        //    //[DataMember]
        //    //[Column("QuanitityBarcode")] public string QuanitityBarcode { get; set; }
        //    [DataMember]
        //    [Column("CustLotid")] public string CustLotid { get; set; }
        //    [DataMember]
        //    [Column("CustPartid")] public string CustPartid { get; set; }
        //    [DataMember]
        //    [Column("OrignalCountry")] public string OrignalCountry { get; set; }
        //    [DataMember]
        //    [Column("QAstamp")] public string QAstamp { get; set; }
           

        //}


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