using System.Collections.Generic;
using System.Runtime.Serialization;
using Utils;
using WCFModels;

namespace Models.Message
{
    public enum OpreateType
    {
        Insert,//表中无记录，需要新建
        Update,//表中有记录，需要更新
        Delete //删除表中记录
    }

    #region 请求消息
    [DataContract]
    public class BaseReq
    {

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
        public IList<QueryCondition> queryConditionList { get; set; }
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
        public IList<SortCondition> sortCondittionList { get; set; }

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
        [DataMember]
        public OpreateType opreateType { get; set; }

        [DataMember]
        public string userId { get; set; }

    }

    [DataContract]
    //public class UpdateModelReq<T> : UpdateReq where T : IModelingObject, new()
    //{
    //    [DataMember]
    //    public T Model { get; set; }
    //}

    //[DataContract]
    //public class UpdateModelListReq<T> : UpdateReq where T : IModelingObject, new()
    //{
    //    [DataMember]
    //    public IList<T> Models { get; set; }

    //    public UpdateModelListReq() : base()
    //    {
    //        Models = new List<T>();
    //    }
    //}

    public class UpdateModelReq<T> : UpdateReq
    {
        [DataMember]
        public T model { get; set; }
    }

    [DataContract]
    public class UpdateModelListReq<T> : UpdateReq
    {
        [DataMember]
        public IList<T> models { get; set; }

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
        public IList<T> models { get; set; }

        public PageModelRsp()
        {
            models = new List<T>();
        }
    }

    [DataContract]
    public class ModelListRsp<T> : BaseRsp
    {
        [DataMember]
        public IList<T> models { get; set; }

        public ModelListRsp()
        {
            models = new List<T>();
        }
    }
    #endregion
}