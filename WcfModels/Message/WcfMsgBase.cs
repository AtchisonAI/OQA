using System.Collections.Generic;
using System.Runtime.Serialization;
using Utils;

namespace WCFModels.Message
{
    public enum OperateType
    {
        Insert,//表中无记录，需要新建
        Update,//表中有记录，需要更新
        Delete //删除表中记录
    }

    public enum MsgSite
    {
        CLIENT,
        SERVER
    }

    #region 请求消息
    [DataContract]
    public class BaseReq
    {
        public BaseReq()
        {
            msgFrom = MsgSite.CLIENT;
        }

        public BaseReq(MsgSite msgSite)
        {
            msgFrom = msgSite;
        }

        //client升级需要改动相应的版本号，并在服务端增加与服务器版本的对应关系（路径WcfService/Util/VersionCtrl）
        //server端升版不需要改动该版本号，只需在服务端增加与服务器版本的对应关系（路径WcfService/Util/VersionCtrl）
 //       [DataMember]
        public string clientActiveVer = "1.0.1";


        [DataMember]
        public MsgSite msgFrom { get; set; }
    }

    #region 查询请求
    [DataContract]
    public class QueryReq : BaseReq
    {
        public QueryReq() : base()
        {
            queryConditionList = new List<QueryCondition>();
        }

        public QueryReq(MsgSite msgSite):base(msgSite)
        {
            queryConditionList = new List<QueryCondition>();
        }

        [DataMember]
        public List<QueryCondition> queryConditionList { get; set; }
    }

    [DataContract]
    public class PageQueryReq : QueryReq
    {
        public PageQueryReq ():base()
        {
            ItemsPerPage = 20;
            CurrentPage = 1;
            sortCondittionList = new List<SortCondition>();
        }

        public PageQueryReq(MsgSite msgSite) : base(msgSite)
        {
            ItemsPerPage = 20;
            CurrentPage = 1;
            sortCondittionList = new List<SortCondition>();
        }

        [DataMember]
        public List<SortCondition> sortCondittionList { get; set; }

        [DataMember]
        public int ItemsPerPage { get; set; }
        [DataMember]
        public int CurrentPage { get; set; }
    }
    #endregion

    #region 更新请求
    [DataContract]
    public class UpdateReq: BaseReq
    {
        public UpdateReq(MsgSite msgSite) : base(msgSite)
        {

        }

        public UpdateReq() : base()
        {

        }

        [DataMember]
        public OperateType operateType { get; set; }

        [DataMember]
        public string userId { get; set; }

    }

    [DataContract]
    public class UpdateModelReq<T> : UpdateReq
    {
        public UpdateModelReq(MsgSite msgSite) : base(msgSite)
        {

        }
        public UpdateModelReq() : base()
        {

        }
        [DataMember]
        public T model { get; set; }
    }

    [DataContract]
    public class UpdateModelListReq<T> : UpdateReq
    {
        [DataMember]
        public List<T> models { get; set; }

        public UpdateModelListReq() : base()
        {
            models = new List<T>();
        }

        public UpdateModelListReq(MsgSite msgSite) : base(msgSite)
        {
            models = new List<T>();
        }
    }
    #endregion

    #endregion

    #region 响应消息

    [DataContract]
    public class BaseRsp
    {
        public BaseRsp()
        {
            this.InitProperties();
        }

        [DataMember]
        public bool __ByPass { get; set; }
        [DataMember]
        public string _MsgCode { get; set; }
        [DataMember]
        public string _ErrorMsg { get; set; }
        [DataMember]
        public string _StackTrace { get; set; }
        [DataMember]
        public bool _success { get; set; }
    }


    [DataContract]
    public class PageRsp : BaseRsp
    {
        [DataMember]
        public int TotalItems { get; set; }
        [DataMember]
        public int ItemsPerPage { get; set; }
        [DataMember]
        public int CurrentPage { get; set; }
        [DataMember]
        public int TotalPage { get; set; }
        [DataMember]
        public bool IsMorePage { get; set; }
    }

    [DataContract]
    public class ModelRsp<T> : BaseRsp
    {
        [DataMember]
        public T model { get; set; }
    }

    [DataContract]
    public class PageModelRsp<T> : PageRsp
    {
        [DataMember]
        public List<T> models { get; set; }

        public PageModelRsp()
        {
            models = new List<T>();
        }
    }

    [DataContract]
    public class ModelListRsp<T> : BaseRsp
    {
        [DataMember]
        public List<T> models { get; set; }

        public ModelListRsp()
        {
            models = new List<T>();
        }
    }
    #endregion
}