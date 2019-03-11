using System.Collections.Generic;
using System.Runtime.Serialization;
using WCFModels.MESDB.FWTST1;
using WCFModels.Message;

namespace WCFModels.OQA
{
    //public class AOIInputView : BaseRsp
    //{

    //    //服务传入执行动作,事务标记必须输入
    //    [DataMember]
    //    public char c_proc_step { get; set; }
    //    [DataMember]
    //    public char c_tran_flag { get; set; }
    //    //服务传入参数
    //    [DataMember]
    //    public string in_isp_type { get; set; }
    //    [DataMember]
    //    public string in_isp_code { get; set; }
    //    //服务传出数据结构

    //    [DataMember]
    //    public string LotId { get; set; }
    //    [DataMember]
    //    public string SlotId { get; set; }
    //    [DataMember]
    //    public string WaferId { get; set; }
    //    [DataMember]
    //    public string SideType { get; set; }
    //    [DataMember]
    //    public string InspectType { get; set; }
    //    [DataMember]
    //    public string IsInspect { get; set; }
    //    [DataMember]
    //    public string InspectPoint { get; set; }
    //    [DataMember]
    //    public string InspectResult { get; set; }
    //    [DataMember]
    //    public string Magnification { get; set; }
    //    [DataMember]
    //    public decimal DieQty { get; set; }
    //    [DataMember]
    //    public decimal DefectRate { get; set; }
    //    [DataMember]
    //    public string ReviewUser { get; set; }
    //    [DataMember]
    //    public string DefectDesc { get; set; }
    //    [DataMember]
    //    public string Cmt { get; set; }
    //    [DataMember]
    //    public List<ISPWAFDFT> ISPWAFDFT_list { get; set; }

    //    [DataMember]
    //    public string ImageId { get; set; }
    //    [DataMember]
    //    public string ImagePath { get; set; }
    //    [DataMember]
    //    public string ImageName { get; set; }
    //    [DataMember]
    //    public string ImageType { get; set; }
    //}

    public class AOIShowView : BaseRsp
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
        public string IN_ISP_TYPE
        {
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
        public string IN_ISP_CODE
        {
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
        public ISPWAFITM ISPWAFITM { get; set; }
        // public ModelListRsp<ISPWAFITM> ISPWAFITM_list { get; set; }
        [DataMember]
       // public ModelListRsp<ISPWAFDFT> ISPWAFDFT_list { get; set; }
         public List<ISPWAFDFT> ISPWAFDFT_list { get; set; }
        [DataMember]
      //  public ModelListRsp<ISPIMGDEF> ISPIMGDEF_list { get; set; }
         public List<ISPIMGDEF> ISPIMGDEF_list { get; set; }


    }
}
