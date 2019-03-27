using log4net;
using NPoco;
using NPoco.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using Utils;
using WCFModels;
using WCFModels.Message;

namespace WcfService
{
    public class BaseService
    {
        public static ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public string connectStringName = "WCFFrameDB";
        public IDatabase db;

        public BaseService()
        {
            db = new MyDB(connectStringName);
        }

        public BaseService( string connectStr)
        {
            connectStringName = connectStr;
            db = new MyDB(connectStringName);
        }

        public void BeginTrans()
        {
            db.BeginTransaction();
        }

        public void EndTrans()
        {
            db.CompleteTransaction();
        }

        public string GetSystemDateTime()
        {
            string sql = "";

            if (db.DatabaseType == DatabaseType.SqlServer2005 ||
                db.DatabaseType == DatabaseType.SqlServer2008 ||
                db.DatabaseType == DatabaseType.SqlServer2012)
            {
                sql = sql = "select replace(convert(varchar(100),getdate(),112)+convert(varchar(100),getdate(),8),':','') as sysdate";
            }

            else if (db.DatabaseType == DatabaseType.Oracle ||
                db.DatabaseType == DatabaseType.OracleManaged)
            {
                //有错误
                sql = "select TO_CHAR(sysdate,'YYYYMMDDHH24MISS') from dual";
            }
            else
            {
                throw new Exception(string.Format("Database Type {0} Not Supported!", db.DatabaseType.ToString()));
            }

            return db.Fetch<string[]>(sql).Single()[0];
        }

        #region RawSql
        public List<Object[]> QueryRawSql(string sql)
        {
            return db.Fetch<object[]>(sql);
        }

        //public int UpdateRawSql(string sql)
        //{
        //    return db.Execute(sql);
        //}

        #endregion

        #region TrackModel
        /// <summary>
        /// 更新建模对象，根据对象的_ProStep属性判断是新增/修改，还是删除操作。
        /// 将持久化之后的对象返回
        /// </summary>
        /// <typeparam name="T">具有IModelingObject接口的建模对象类型</typeparam>
        /// <param name="inMsg">需要更新的建模对象</param>
        /// <param name="outMsg">返回的建模对象</param>
        /// <param name="refreshModel">是否从数据库刷新建模对象</param>
        public void UpdateTrackModel<T>(UpdateModelReq<T> inMsg, ModelRsp<T> outMsg, bool refreshModel = false)
            where T : ITrackModelObject, new()
        {
            UpdateTrackModel(inMsg);

            if (!refreshModel)
                outMsg.model = inMsg.model;
            else
            {
                outMsg.model = db.SingleOrDefaultById<T>(inMsg.model);
            }

            outMsg._success = true;
        }

        /// <summary>
        /// 更新建模对象，根据对象的_ProStep属性判断是新增/修改，还是删除操作
        /// </summary>
        /// <typeparam name="T">具有ITrackModelObject接口的建模对象类型</typeparam>
        /// <param name="inMsg">需要更新的建模对象</param>
        public void UpdateTrackModel<T>(UpdateModelReq<T> updateReq) where T : ITrackModelObject, new()
        {
            UpdateTrackModelImp(updateReq.model, updateReq.operateType, updateReq.userId,updateReq.partialUpdate);
        }

        /// <summary>
        /// 批量更新建模对象，根据对象的_ProStep属性判断是新增/修改，还是删除操作。
        /// 可返回更新后的对象清单。
        /// </summary>
        /// <typeparam name="T">具有IModelingObject接口的建模对象类型</typeparam>
        /// <param name="inMsg">需要更新的建模对象列表</param>
        /// <param name="outMsg">更新后的建模对象列表</param>
        /// <param name="refreshModel">是否从数据库刷新模对象列表</param>
        public void UpdateTrackModels<T>(UpdateModelListReq<T> inMsg, ModelListRsp<T> outMsg, bool refreshModel = false)
            where T : ITrackModelObject, new()
        {
            UpdateTrackModels(inMsg);

            if (!refreshModel)
                outMsg.models = inMsg.models;
            else
            {
                foreach (var model in inMsg.models)
                    outMsg.models.Add(db.SingleOrDefaultById<T>(model));
            }
            outMsg._success = true;
        }

        /// <summary>
        /// 批量更新建模对象，根据对象的_ProStep属性判断是新增/修改，还是删除操作。
        /// </summary>
        /// <typeparam name="T">具有IModelingObject接口的建模对象类型</typeparam>
        /// <param name="inMsg">需要更新的建模对象列表</param>
        public void UpdateTrackModels<T>(UpdateModelListReq<T> updateReq) where T : ITrackModelObject, new()
        {
            foreach(T model in updateReq.models)
            {
                UpdateTrackModelImp(model, updateReq.operateType, updateReq.userId, updateReq.partialUpdate);
            }
        }

        private void UpdateTrackModelImp<T>(T model, OperateType operateType,string userId,bool partialUpdate) where T : ITrackModelObject, new()
        {
            var sysdate = GetSystemDateTime();
            switch (operateType)
            {
                case OperateType.Insert:
                    model.CreateTime = sysdate;
                    model.CreateUserId = userId;

                    db.Insert(model);
                    break;

                case OperateType.Update:
                    model.UpdateTime = sysdate;
                    model.UpdateUserId = userId;

                    if (partialUpdate)
                    {
                        var oldModel = db.SingleOrDefaultById<T>(model);
                        var sanpShot = db.StartSnapshot(oldModel);
                        ObjectEx.InitialObj(oldModel, model);
                        db.Update(oldModel, sanpShot.UpdatedColumns());
                    }
                    else
                    {
                        db.Update(model);
                    }
                    break;

                case OperateType.Delete:
                    db.Delete(model);
                    break;
            }
        }
        #endregion

        #region Normal DB Model
        /// <summary>
        /// 更新建模对象，根据对象的_ProStep属性判断是新增/修改，还是删除操作。
        /// 将持久化之后的对象返回
        /// </summary>
        /// <typeparam name="T">具有IModelingObject接口的建模对象类型</typeparam>
        /// <param name="inMsg">需要更新的建模对象</param>
        /// <param name="outMsg">返回的建模对象</param>
        /// <param name="refreshModel">是否从数据库刷新建模对象</param>
        public void UpdateModel<T>(UpdateModelReq<T> inMsg, ModelRsp<T> outMsg, bool refreshModel = false) where T : new()
        {
            UpdateModel(inMsg);

            if (!refreshModel)
                outMsg.model = inMsg.model;
            else
            {
                outMsg.model = db.SingleOrDefaultById<T>(inMsg.model);
            }
            outMsg._success = true;
        }

        /// <summary>
        /// 更新建模对象，根据对象的_ProStep属性判断是新增/修改，还是删除操作
        /// </summary>
        /// <typeparam name="T">db建模对象类型</typeparam>
        /// <param name="inMsg">需要更新的建模对象</param>
        public void UpdateModel<T>(UpdateModelReq<T> updateReq) where T : new()
        {
            UpdateModelImp(updateReq.model, updateReq.operateType, updateReq.partialUpdate);
        }

        /// <summary>
        /// 批量更新建模对象，根据对象的_ProStep属性判断是新增/修改，还是删除操作。
        /// 可返回更新后的对象清单。
        /// </summary>  
        /// <typeparam name="T">具有IModelingObject接口的建模对象类型</typeparam>
        /// <param name="inMsg">需要更新的建模对象列表</param>
        /// <param name="outMsg">更新后的建模对象列表</param>
        /// <param name="refreshModel">是否从数据库刷新模对象列表</param>
        public void UpdateModels<T>(UpdateModelListReq<T> inMsg, ModelListRsp<T> outMsg, bool refreshModel = false)
        {
            UpdateModels(inMsg);

            if (!refreshModel)
                outMsg.models = inMsg.models;
            else
            {
                foreach (var model in inMsg.models)
                    outMsg.models.Add(db.SingleOrDefaultById<T>(model));
            }
            outMsg._success = true;
        }

        /// <summary>
        /// 批量更新建模对象，根据对象的_ProStep属性判断是新增/修改，还是删除操作。
        /// </summary>
        /// <param name="inMsg">需要更新的建模对象列表</param>
        public void UpdateModels<T>(UpdateModelListReq<T> updateReq)
        {
            foreach(var model in updateReq.models)
            {
                UpdateModelImp(model, updateReq.operateType, updateReq.partialUpdate);
            }
        }

        private void UpdateModelImp<T>(T model, OperateType operateType,bool partialUpdate)
        {
            switch (operateType)
            {
                case OperateType.Insert:
                    db.Insert(model);
                    break;

                case OperateType.Update:
                    if(partialUpdate)
                    {
                        var oldModel = db.SingleOrDefaultById<T>(model);
                        var sanpShot = db.StartSnapshot(oldModel);
                        ObjectEx.InitialObj(oldModel, model);
                        db.Update(oldModel, sanpShot.UpdatedColumns());
                    } else
                    {
                        db.Update(model);
                    }
                    break;

                case OperateType.Delete:
                    db.Delete(model);
                    break;
            }
        }
        #endregion

        public int DeleteByPrimaryKey<T>(object primayKeyValue)
        {
            return db.Delete(primayKeyValue);
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
            PageModelRsp<T> rsp = new PageModelRsp<T>();
            var res = PageQueryIml<T>(req);
            if(null != res)
            {
                rsp.TotalItems = (int)res.TotalItems;
                rsp.TotalPage = (int)res.TotalPages;
                rsp.models = res.Items;
                rsp._success = true;
            } else
            {
                rsp._success = false;
            }
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
            var res = QueryIml<T>(req);
            if (null!= res)
            {
                rsp.models = res;
                rsp._success = true;
            } else
            {
                rsp._success = false;
            }
            return rsp;
        }

        public ModelRsp<T> SingleQuery<T>(object primayKeyValue) where T:new()
        {
            ModelRsp<T> rsp = new ModelRsp<T>();
            try
            {
                rsp.model = db.SingleById<T>(primayKeyValue);
                rsp._success = true;
            } catch (Exception e)
            {
                rsp._success = false;
                rsp._ErrorMsg = e.Message;
            }

            return rsp;
        }

        private List<T> QueryIml<T>(QueryReq req)
        {
            try
            {
                if (req.queryConditionList != null && req.queryConditionList.Count > 0)
                {
                    return db.Query<T>().Where(LambdaHelper.LambdaBuilder<T>(req.queryConditionList)).ToList();
                }
                else
                {
                    return db.Query<T>().ToList();
                }
            } catch (Exception ex)
            {
                log.Error(ex.Message);
                return null;
            }
        }

        private Page<T> PageQueryIml<T>(PageQueryReq req)
        {
            IQueryProvider < T > provider = null;
            if (req.queryConditionList != null && req.queryConditionList.Count > 0)
            {
                provider = db.Query<T>().Where(LambdaHelper.LambdaBuilder<T>(req.queryConditionList));
            } else
            {
                provider = db.Query<T>();
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

            try
            {
                return provider.ToPage(req.CurrentPage, req.ItemsPerPage);
            } catch (Exception e)
            {
                log.Error(e.Message);
                return null;
            }
        }

        public static string GetParaName<T>(System.Linq.Expressions.Expression<Func<T, object>> exp)
        {
            return LambdaHelper.GetParaName(exp);
        }

        /// <summary>
        /// 查询条件添加.
        /// </summary>
        /// <param name="PageQueryReq">分页结构</param>
        /// <param name="colName">字段名称</param>
        /// <param name="Value">字段内容</param>
        /// <param name="LogicType">条件逻辑</param>
        public static void AddCondition(QueryReq queryReq, string colName, string Value, LogicCondition LogicType,CompareType compare)
        {
            QueryCondition queryCon = new QueryCondition()
            {
                paramName = colName,
                compareType = compare,
                conditionType = LogicType,
                value = Value
            };
            queryReq.queryConditionList.Add(queryCon);
        }
        public static void AddSortCondition(PageQueryReq PageQueryReq, string colName, SortType SortType)
        {
            SortCondition sortCon = new SortCondition()
            {
                paramName = colName,
                sortType = SortType
            };

            PageQueryReq.sortCondittionList.Add(sortCon);
        }
    }
}