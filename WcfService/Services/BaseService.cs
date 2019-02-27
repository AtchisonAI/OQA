using Models.Message;
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using Utils.Log;
using WCFModels;

namespace WcfService
{
    public class BaseService
    {
        public string connectStringName = "WCFFrameDB";
        private Dictionary<string, IDatabase> dbSet = new Dictionary<string, IDatabase>();

        private IDatabase GetDb()
        {
            IDatabase db = null;
            if (!dbSet.TryGetValue(connectStringName, out db))
            {
                db = new MyDB(connectStringName);
                dbSet.Add(connectStringName, db);
            } 

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

        ///// <summary>
        ///// 更新建模对象，根据对象的_ProStep属性判断是新增/修改，还是删除操作
        ///// </summary>
        ///// <typeparam name="T">具有IModelingObject接口的建模对象类型</typeparam>
        ///// <param name="inMsg">需要更新的建模对象</param>
        //public void UpdateModelingObject<T>(UpdateModelReq<T> updateReq) where T : IModelingObject, new()
        //{
        //    var sysdate = GetSystemDateTime();
        //    switch(updateReq.opreateType)
        //    {
        //        case OpreateType.Insert:
        //            updateReq.model.CreateTime = sysdate;
        //            updateReq.model.CreateUserId = updateReq.userId;

        //            GetDb().Insert(updateReq.model);
        //            break;

        //        case OpreateType.Update:
        //            var oldModel = GetDb().SingleOrDefaultById<T>(updateReq.model);
        //            if (oldModel == null)
        //            {
        //                updateReq.model.UpdateTime = sysdate;
        //                updateReq.model.UpdateUserId = updateReq.userId;

        //                GetDb().Insert(updateReq.model);
        //            }
        //            else
        //            {
        //                updateReq.model.CreateTime = oldModel.CreateTime;
        //                updateReq.model.CreateUserId = oldModel.CreateUserId;
        //                updateReq.model.UpdateTime = sysdate;
        //                updateReq.model.UpdateUserId = updateReq.userId;

        //                GetDb().Update(updateReq.model);
        //            }
        //            break;

        //        case OpreateType.Delete:
        //            GetDb().Delete(updateReq.model);
        //            break;
        //    }
        //}


        /// <summary>
        /// 更新建模对象，根据对象的_ProStep属性判断是新增/修改，还是删除操作
        /// </summary>
        /// <typeparam name="T">GetDb()建模对象类型</typeparam>
        /// <param name="inMsg">需要更新的建模对象</param>
        public void UpdateModelingObject<T>(UpdateModelReq<T> updateReq)
        {
          //  var sysdate = GetSystemDateTime();
            switch (updateReq.opreateType)
            {
                case OpreateType.Insert:
                    GetDb().Insert(updateReq.model);
                    break;

                case OpreateType.Update:
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

                case OpreateType.Delete:
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
        public void UpdateModelingObject<T>(UpdateModelReq<T> inMsg, ModelRsp<T> outMsg, bool refreshModel = false)
        {
            UpdateModelingObject(inMsg);

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
        public void UpdateModelingObjects<T>(UpdateModelListReq<T> updateReq)
        {
            switch (updateReq.opreateType)
            {
                case OpreateType.Insert:
                    foreach (var model in updateReq.models)
                    {
                        //var tableInfo = GetDb().PocoDataFactory.TableInfoForType(model.GetType());
                        //var pd = GetDb().PocoDataFactory.ForObject(model, tableInfo.PrimaryKey, tableInfo.AutoIncrement);
                        GetDb().Insert(model);
                    }
                    break;

                case OpreateType.Update:
              //      var sysdate = GetSystemDateTime();
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

                case OpreateType.Delete:
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
            UpdateModelingObjects(inMsg);

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

        private Page<T> PageQueryIml<T>(PageQueryReq req)
        {
            if (req.queryConditionList != null && req.queryConditionList.Count > 0)
            {
                return PageQueryByConditionWithSort<T>(req.queryConditionList, req.sortCondittionList, req.CurrentPage, req.ItemsPerPage);
            }
            else
            {
                return PageQueryNoConditionWithSort<T>(req.sortCondittionList, req.CurrentPage, req.ItemsPerPage);
            }
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

        private void Assert(bool v)
        {
            if (!v)
            {
                throw new NotImplementedException();
            }
        }

        private Page<T> PageQueryByConditionWithSort<T>(IList<QueryCondition> queryConditionList, IList<SortCondition> sortConditionList, int pageIndex, int pageSize)
        {
            if (sortConditionList.Count == 1)
            {
                return PageQueryByConditionWithSort<T>(queryConditionList, sortConditionList[0], pageIndex, pageSize);
            }
            else if (sortConditionList.Count == 2)
            {
                return PageQueryByConditionWithSort<T>(queryConditionList, sortConditionList[0], sortConditionList[1], pageIndex, pageSize);
            }
            else
            {
                Exception ex = new Exception("必须指定排序字段，最多支持两个排序字段");
                LogHelper.WriteLog("必须指定排序字段，最多支持两个排序字段", ex);
                return null;
            }
        }

        //一个排序条件
        private Page<T> PageQueryByConditionWithSort<T>(IList<QueryCondition> queryConditionList, SortCondition sortCondition, int pageIndex, int pageSize)
        {
            if (SortType.ASC == sortCondition.sortType)
            {
                return GetDb().Query<T>().Where(LambdaHelper.LambdaBuilder<T>(queryConditionList)).OrderBy(LambdaHelper.LambdaBuilderByName<T>(sortCondition.paramName)).ToPage(pageIndex, pageSize);
            }
            else
            {
                return GetDb().Query<T>().Where(LambdaHelper.LambdaBuilder<T>(queryConditionList)).OrderByDescending(LambdaHelper.LambdaBuilderByName<T>(sortCondition.paramName)).ToPage(pageIndex, pageSize);
            }
        }

        //两个排序条件
        private Page<T> PageQueryByConditionWithSort<T>(IList<QueryCondition> queryConditionList, SortCondition sortCondition0, SortCondition sortCondition1, int pageIndex, int pageSize)
        {
            if (SortType.ASC == sortCondition0.sortType)
            {
                if (SortType.ASC == sortCondition1.sortType)
                {
                    return GetDb().Query<T>().Where(LambdaHelper.LambdaBuilder<T>(queryConditionList)).OrderBy(LambdaHelper.LambdaBuilderByName<T>(sortCondition0.paramName)).ThenBy(LambdaHelper.LambdaBuilderByName<T>(sortCondition1.paramName)).ToPage(pageIndex, pageSize);
                }
                else
                {
                    return GetDb().Query<T>().Where(LambdaHelper.LambdaBuilder<T>(queryConditionList)).OrderBy(LambdaHelper.LambdaBuilderByName<T>(sortCondition0.paramName)).ThenByDescending(LambdaHelper.LambdaBuilderByName<T>(sortCondition1.paramName)).ToPage(pageIndex, pageSize);
                }
            }
            else
            {
                if (SortType.ASC == sortCondition1.sortType)
                {
                    return GetDb().Query<T>().Where(LambdaHelper.LambdaBuilder<T>(queryConditionList)).OrderByDescending(LambdaHelper.LambdaBuilderByName<T>(sortCondition0.paramName)).ThenBy(LambdaHelper.LambdaBuilderByName<T>(sortCondition1.paramName)).ToPage(pageIndex, pageSize);
                }
                else
                {
                    return GetDb().Query<T>().Where(LambdaHelper.LambdaBuilder<T>(queryConditionList)).OrderByDescending(LambdaHelper.LambdaBuilderByName<T>(sortCondition0.paramName)).ThenByDescending(LambdaHelper.LambdaBuilderByName<T>(sortCondition1.paramName)).ToPage(pageIndex, pageSize);
                }
            }
        }

        private Page<T> PageQueryNoConditionWithSort<T>(IList<SortCondition> sortConditionList, int offset, int itemNum)
        {
            if (sortConditionList.Count == 1)
            {
                return PageQueryNoConditionWithSort<T>(sortConditionList[0], offset, itemNum);
            }
            else if (sortConditionList.Count == 2)
            {
                return PageQueryNoConditionWithSort<T>(sortConditionList[0], sortConditionList[1], offset, itemNum);
            }
            else
            {
                Exception ex = new Exception("必须指定排序字段，最多支持两个排序字段");
                LogHelper.WriteLog("必须指定排序字段，最多支持两个排序字段", ex);
                return null;
            }
        }

        //一个排序条件
        private Page<T> PageQueryNoConditionWithSort<T>(SortCondition sortCondition, int pageIndex, int pageSize)
        {
            if (SortType.ASC == sortCondition.sortType)
            {
                return GetDb().Query<T>().Where("1=1").OrderBy(LambdaHelper.LambdaBuilderByName<T>(sortCondition.paramName)).ToPage(pageIndex, pageSize);
            }
            else
            {
                return GetDb().Query<T>().OrderByDescending(LambdaHelper.LambdaBuilderByName<T>(sortCondition.paramName)).ToPage(pageIndex, pageSize);
            }
        }

        //两个排序条件
        private Page<T> PageQueryNoConditionWithSort<T>(SortCondition sortCondition0, SortCondition sortCondition1, int pageIndex, int pageSize)
        {
            if (SortType.ASC == sortCondition0.sortType)
            {
                if (SortType.ASC == sortCondition1.sortType)
                {
                    return GetDb().Query<T>().OrderBy(LambdaHelper.LambdaBuilderByName<T>(sortCondition0.paramName)).ThenBy(LambdaHelper.LambdaBuilderByName<T>(sortCondition1.paramName)).ToPage(pageIndex, pageSize);
                }
                else
                {
                    return GetDb().Query<T>().OrderBy(LambdaHelper.LambdaBuilderByName<T>(sortCondition0.paramName)).ThenByDescending(LambdaHelper.LambdaBuilderByName<T>(sortCondition1.paramName)).ToPage(pageIndex, pageSize);
                }
            }
            else
            {
                if (SortType.ASC == sortCondition1.sortType)
                {
                    return GetDb().Query<T>().OrderByDescending(LambdaHelper.LambdaBuilderByName<T>(sortCondition0.paramName)).ThenBy(LambdaHelper.LambdaBuilderByName<T>(sortCondition1.paramName)).ToPage(pageIndex, pageSize);
                }
                else
                {
                    return GetDb().Query<T>().OrderByDescending(LambdaHelper.LambdaBuilderByName<T>(sortCondition0.paramName)).ThenByDescending(LambdaHelper.LambdaBuilderByName<T>(sortCondition1.paramName)).ToPage(pageIndex, pageSize);
                }
            }
        }
    }
}