using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WCFModels.Message
{
    public enum OperateType
    {
        Insert,//表中无记录，需要新建
        Update,//表中有记录，需要更新
        Delete //删除表中记录
    }

    #region 请求消息
    [DataContract]
    public class BaseReq
    {
        public BaseReq()
        {
            
        }
    }

    #region 查询请求
    [DataContract]
    public class QueryReq : BaseReq
    {
        public QueryReq() : base()
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
        public UpdateReq() : base()
        {
            partialUpdate = true;
        }

        [DataMember]
        public OperateType operateType { get; set; }

        [DataMember]
        public string userId { get; set; }

        [DataMember]
        public bool partialUpdate { get; set; }
    }

    [DataContract]
    public class UpdateModelReq<T> : UpdateReq where T:new()
    {
        public UpdateModelReq() : base()
        {
            model = new T();
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
    }
    #endregion

    #endregion

    #region 响应消息

    [DataContract]
    public class BaseRsp
    {
        public BaseRsp()
        {
            __ByPass = false;
            _MsgCode = " ";
            _ErrorMsg = " ";
            _StackTrace = " ";
            _success = false;
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
    public class ModelRsp<T> : BaseRsp where T:new()
    {
        public ModelRsp()
        {
            model = new T();
        }
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