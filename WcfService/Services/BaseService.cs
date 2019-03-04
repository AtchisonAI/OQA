using log4net;
using NPoco;
using NPoco.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using WCFModels;
using WCFModels.Message;

namespace WcfService
{
    public class BaseService
    {
        public static ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public string connectStringName = "WCFFrameDB";
        public IDatabase db;
        //private Dictionary<string, IDatabase> dbSet = new Dictionary<string, IDatabase>();

        public BaseService()
        {
            db = new MyDB(connectStringName);
        }

        public BaseService( string connectStr)
        {
            connectStringName = connectStr;
            db = new MyDB(connectStringName);
        }

        //private IDatabase GetDb()
        //{
        //    IDatabase db = null;
        //    if (!dbSet.TryGetValue(connectStringName, out db))
        //    {
        //        db = new MyDB(connectStringName);
        //        dbSet.Add(connectStringName, db);
        //    } 

        //    return db;
        //}

        private IDatabase GetDb()
        {
            return db;
        }

        public void BeginTrans()
        {
            GetDb().BeginTransaction();
        }

        public void EndTrans()
        {
            GetDb().CompleteTransaction();
        }

        public string GetSystemDateTime()
        {
            string sql = "";

            if (GetDb().DatabaseType == DatabaseType.SqlServer2005 ||
                GetDb().DatabaseType == DatabaseType.SqlServer2008 ||
                GetDb().DatabaseType == DatabaseType.SqlServer2012)
            {
                sql = sql = "select replace(convert(varchar(100),getdate(),112)+convert(varchar(100),getdate(),8),':','') as sysdate";
            }

            else if (GetDb().DatabaseType == DatabaseType.Oracle ||
                GetDb().DatabaseType == DatabaseType.OracleManaged)
            {
                //有错误
                sql = "select strftime('%Y%m%d%H%M%S','now','localtime') as sysdate";
            }
            else
            {
                throw new Exception(string.Format("Database Type {0} Not Supported!", GetDb().DatabaseType.ToString()));
            }

            return GetDb().Fetch<string[]>(sql).Single()[0];
        }

        /// <summary>
        /// 更新建模对象，根据对象的_ProStep属性判断是新增/修改，还是删除操作
        /// </summary>
        /// <typeparam name="T">具有ITrackModelObject接口的建模对象类型</typeparam>
        /// <param name="inMsg">需要更新的建模对象</param>
        public void UpdateTrackModel<T>(UpdateModelReq<T> updateReq) where T : ITrackModelObject, new()
        {
            var sysdate = GetSystemDateTime();
            switch (updateReq.opreateType)
            {
                case OperateType.Insert:
                    updateReq.model.CreateTime = sysdate;
                    updateReq.model.CreateUserId = updateReq.userId;

                    GetDb().Insert(updateReq.model);
                    break;

                case OperateType.Update:
                    var oldModel = GetDb().SingleOrDefaultById<T>(updateReq.model);
                    if (oldModel == null)
                    {
                        updateReq.model.UpdateTime = sysdate;
                        updateReq.model.UpdateUserId = updateReq.userId;

                        GetDb().Insert(updateReq.model);
                    }
                    else
                    {
                        updateReq.model.CreateTime = oldModel.CreateTime;
                        updateReq.model.CreateUserId = oldModel.CreateUserId;
                        updateReq.model.UpdateTime = sysdate;
                        updateReq.model.UpdateUserId = updateReq.userId;

                        GetDb().Update(updateReq.model);
                    }
                    break;

                case OperateType.Delete:
                    GetDb().Delete(updateReq.model);
                    break;
            }
        }


        /// <summary>
        /// 更新建模对象，根据对象的_ProStep属性判断是新增/修改，还是删除操作
        /// </summary>
        /// <typeparam name="T">GetDb()建模对象类型</typeparam>
        /// <param name="inMsg">需要更新的建模对象</param>
        public void UpdateModel<T>(UpdateModelReq<T> updateReq)
        {
          //  var sysdate = GetSystemDateTime();
            switch (updateReq.opreateType)
            {
                case OperateType.Insert:
                    GetDb().Insert(updateReq.model);
                    break;

                case OperateType.Update:
                    var oldModel = GetDb().SingleOrDefaultById<T>(updateReq.model);
                    if (oldModel == null)
                    {
                        GetDb().Insert(updateReq.model);
                    }
                    else
                    {
                        GetDb().Update(updateReq.model);
                    }
                    break;

                case OperateType.Delete:
                    GetDb().Delete(updateReq.model);
                    break;
            }
        }

        ///// <summary>
        ///// 更新建模对象，根据对象的_ProStep属性判断是新增/修改，还是删除操作。
        ///// 将持久化之后的对象返回
        ///// </summary>
        ///// <typeparam name="T">具有IModelingObject接口的建模对象类型</typeparam>
        ///// <param name="inMsg">需要更新的建模对象</param>
        ///// <param name="outMsg">返回的建模对象</param>
        ///// <param name="refreshModel">是否从数据库刷新建模对象</param>
        //public void UpdateModelingObject<T>(UpdateModelReq<T> inMsg, ModelRsp<T> outMsg, bool refreshModel = false)
        //    where T : IModelingObject, new()
        //{
        //    UpdateModelingObject(inMsg);

        //    if (!refreshModel)
        //        outMsg.model = inMsg.model;
        //    else
        //    {
        //        outMsg.model = GetDb().SingleOrDefaultById<T>(inMsg.model);
        //    }
        //}

        /// <summary>
        /// 更新建模对象，根据对象的_ProStep属性判断是新增/修改，还是删除操作。
        /// 将持久化之后的对象返回
        /// </summary>
        /// <typeparam name="T">具有IModelingObject接口的建模对象类型</typeparam>
        /// <param name="inMsg">需要更新的建模对象</param>
        /// <param name="outMsg">返回的建模对象</param>
        /// <param name="refreshModel">是否从数据库刷新建模对象</param>
        public void UpdateModel<T>(UpdateModelReq<T> inMsg, ModelRsp<T> outMsg, bool refreshModel = false)
        {
            UpdateModel(inMsg);

            if (!refreshModel)
                outMsg.model = inMsg.model;
            else
            {
                outMsg.model = GetDb().SingleOrDefaultById<T>(inMsg.model);
            }
            outMsg._success = true;
        }

        ///// <summary>
        ///// 批量更新建模对象，根据对象的_ProStep属性判断是新增/修改，还是删除操作。
        ///// </summary>
        ///// <typeparam name="T">具有IModelingObject接口的建模对象类型</typeparam>
        ///// <param name="inMsg">需要更新的建模对象列表</param>
        //public void UpdateModelingObjects<T>(UpdateModelListReq<T> updateReq) where T : IModelingObject, new()
        //{
        //    switch (updateReq.opreateType)
        //    {
        //        case OpreateType.Update:
        //            var sysdate = GetSystemDateTime();

        //            foreach (var model in updateReq.Models)
        //            {
        //                //get the old modeling object for create user/create time
        //                var oldModel = GetDb().SingleOrDefaultById<T>(model);
        //                if (oldModel == null)
        //                {
        //                    model.CreateTime = sysdate;
        //                    model.CreateUserId = updateReq.userId;

        //                    GetDb().Insert(model);
        //                }
        //                else
        //                {
        //                    model.CreateTime = oldModel.CreateTime;
        //                    model.CreateUserId = oldModel.CreateUserId;
        //                    model.UpdateTime = sysdate;
        //                    model.UpdateUserId = updateReq.userId;

        //                    GetDb().Update(model);
        //                }
        //            }
        //            break;

        //        case OpreateType.Delete:
        //            foreach (var model in updateReq.Models)
        //                GetDb().Delete(model);
        //            break;
        //    }
        //}

        /// <summary>
        /// 批量更新建模对象，根据对象的_ProStep属性判断是新增/修改，还是删除操作。
        /// </summary>
        /// <param name="inMsg">需要更新的建模对象列表</param>
        public void UpdateModelObjects<T>(UpdateModelListReq<T> updateReq)
        {
            switch (updateReq.opreateType)
            {
                case OperateType.Insert:
                    foreach (var model in updateReq.models)
                    {
                        //var tableInfo = GetDb().PocoDataFactory.TableInfoForType(model.GetType());
                        //var pd = GetDb().PocoDataFactory.ForObject(model, tableInfo.PrimaryKey, tableInfo.AutoIncrement);
                        GetDb().Insert(model);
                    }
                    break;

                case OperateType.Update:
                    foreach (var model in updateReq.models)
                    {
                        //get the old modeling object for create user/create time
                        var oldModel = GetDb().SingleOrDefaultById<T>(model);
                        if (oldModel == null)
                        {
                            GetDb().Insert(model);
                        }
                        else
                        {
                            GetDb().Update(model);
                        }
                    }
                    break;

                case OperateType.Delete:
                    foreach (var model in updateReq.models)
                        GetDb().Delete(model);
                    break;
            }
        }

        ///// <summary>
        ///// 批量更新建模对象，根据对象的_ProStep属性判断是新增/修改，还是删除操作。
        ///// 可返回更新后的对象清单。
        ///// </summary>
        ///// <typeparam name="T">具有IModelingObject接口的建模对象类型</typeparam>
        ///// <param name="inMsg">需要更新的建模对象列表</param>
        ///// <param name="outMsg">更新后的建模对象列表</param>
        ///// <param name="refreshModel">是否从数据库刷新模对象列表</param>
        //public void UpdateModelingObjects<T>(UpdateModelListReq<T> inMsg, ModelListRsp<T> outMsg, bool refreshModel = false)
        //    where T : IModelingObject, new()
        //{
        //    UpdateModelingObjects(inMsg);

        //    if (!refreshModel)
        //        outMsg.Models = inMsg.Models;
        //    else
        //    {
        //        outMsg.Models = new List<T>();
        //        foreach (var model in inMsg.Models)
        //            outMsg.Models.Add(GetDb().SingleOrDefaultById<T>(model));
        //    }
        //    outMsg.Models = inMsg.Models;
        //}

        /// <summary>
        /// 批量更新建模对象，根据对象的_ProStep属性判断是新增/修改，还是删除操作。
        /// 可返回更新后的对象清单。
        /// </summary>
        /// <typeparam name="T">具有IModelingObject接口的建模对象类型</typeparam>
        /// <param name="inMsg">需要更新的建模对象列表</param>
        /// <param name="outMsg">更新后的建模对象列表</param>
        /// <param name="refreshModel">是否从数据库刷新模对象列表</param>
        public void UpdateModelingObjects<T>(UpdateModelListReq<T> inMsg, ModelListRsp<T> outMsg, bool refreshModel = false)
        {
            UpdateModelObjects(inMsg);

            if (!refreshModel)
                outMsg.models = inMsg.models;
            else
            {
                outMsg.models = new List<T>();
                foreach (var model in inMsg.models)
                    outMsg.models.Add(GetDb().SingleOrDefaultById<T>(model));
            }
            outMsg._success = true;
        }

        /// <summary>
        /// 带参数查询指定数据库表记录，需指定排序字段，最多支持两个。
        /// 分页返回查询结果。
        /// </summary>
        /// <typeparam name="T">数据库表建模对象类型</typeparam>
        /// <param name="req">分页查询请求</param>
        /// <return value>查询结果列表</return>
        public PageModelRsp<T> PageQuery<T>(PageQueryReq req)
        {
            var res = PageQueryIml<T>(req);

            PageModelRsp<T> rsp = new PageModelRsp<T>();
            rsp.TotalItems = (int)res.TotalItems;
            rsp.TotalPage = (int)res.TotalPages;
            rsp.models = res.Items;
            rsp._success = true;

            return rsp;
        }

        /// <summary>
        /// 带参数查询指定数据库表记录，不排序，不分页。
        /// 返回查询结果，不分页。
        /// </summary>
        /// <typeparam name="T">数据库表建模对象类型</typeparam>
        /// <param name="req">查询请求</param>
        /// <return value>查询结果列表</return>
        public ModelListRsp<T> Query<T>(QueryReq req)
        {
            ModelListRsp<T> rsp = new ModelListRsp<T>();
            rsp.models = QueryIml<T>(req);
            rsp._success = true;
            return rsp;
        }

        private IList<T> QueryIml<T>(QueryReq req)
        {
            if (req.queryConditionList != null && req.queryConditionList.Count > 0)
            {
                return GetDb().Query<T>().Where(LambdaHelper.LambdaBuilder<T>(req.queryConditionList)).ToList();
            }
            else
            {
                return GetDb().Query<T>().ToList();
            }
        }

        private Page<T> PageQueryIml<T>(PageQueryReq req)
        {
            IQueryProvider < T > provider = null;
            if (req.queryConditionList != null && req.queryConditionList.Count > 0)
            {
                provider = GetDb().Query<T>().Where(LambdaHelper.LambdaBuilder<T>(req.queryConditionList));
            } else
            {
                provider = GetDb().Query<T>();
            }

            if (req.sortCondittionList != null && req.sortCondittionList.Count > 0)
            {
                int index = 1;
                foreach (SortCondition sortCon in req.sortCondittionList)
                {
                    switch (sortCon.sortType)
                    {
                        case SortType.ASC:
                            if (index == 1)
                                provider = provider.OrderBy(LambdaHelper.LambdaBuilderByName<T>(sortCon.paramName));
                            else
                                provider = provider.ThenBy(LambdaHelper.LambdaBuilderByName<T>(sortCon.paramName));
                            break;
                        case SortType.DESC:
                            if (index == 1)
                                provider = provider.OrderByDescending(LambdaHelper.LambdaBuilderByName<T>(sortCon.paramName));
                            else
                                provider = provider.ThenByDescending(LambdaHelper.LambdaBuilderByName<T>(sortCon.paramName));
                            break;
                    }
                    index++;
                }
            }
            return provider.ToPage(req.CurrentPage, req.ItemsPerPage);
        }
    }
}