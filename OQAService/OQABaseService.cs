using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFModels;
using WCFModels.Message;
using WcfService;

namespace OQAService.Services
{
    public class OQABaseService: BaseService
    {
        public OQABaseService():base("OQADB")
        {

        }
        /// <summary>
        /// 查询条件添加.
        /// </summary>
        /// <param name="PageQueryReq">分页结构</param>
        /// <param name="colName">字段名称</param>
        /// <param name="Value">字段内容</param>
        /// <param name="LogicType">条件逻辑</param>
        public static void AddCondition(PageQueryReq PageQueryReq, string colName, string Value, LogicCondition LogicType)
        {
            QueryCondition queryCon = new QueryCondition()
            {
                paramName = colName,
                compareType = CompareType.Equal,
                conditionType = LogicType,
                value = Value
            };
            PageQueryReq.queryConditionList.Add(queryCon);
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
