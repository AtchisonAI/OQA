using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Utils
{
    public static class JosnFormatUtil
    {/*
        #region Json
        /// <summary>
        ///     一次性加载数据返回Json数据格式,此方法可从后台去除一次性大数据(默认时间格式为"yyyy-MM-dd HH:mm:ss")
        /// </summary>
        /// <typeparam name="T">业务实体</typeparam>
        /// <param name="data">集合数据</param>
        /// <returns>执行结果数据</returns>
        public static ActionResult JsonForGridLoadonce<T>(IList<T> data)
        {
            return new ContentResult
            {
                Content = new JavaScriptSerializer { MaxJsonLength = Int32.MaxValue }.Serialize(data),
                ContentType = "application/json"
            };
        }

        /// <summary>
        ///     返回分页后信息
        /// </summary>
        /// <param name="pagedResults"></param>
        /// <returns></returns>
        public static JsonResult JsonForGridPaging(PagedResults pagedResults)
        {
            return new JsonResultExtension
            {
                Data =
                    new
                    {
                        total = pagedResults.PagerInfo.PageCount,
                        page = pagedResults.PagerInfo.Page,
                        records = pagedResults.PagerInfo.RecordCount,
                        rows = pagedResults.Data,
                        ExtraDatas = pagedResults.ExtraDatas
                    },
                ContentType = "application/json",
                Format = "yyyy-MM-dd HH:mm:ss"
            };
        }

        /// <summary>
        ///     返回分页后信息
        /// </summary>
        /// <param name="pagedResults">数据</param>
        /// <param name="format">自定义的格式</param>
        /// <returns>Json数据</returns>
        public static JsonResult JsonForGridPaging(PagedResults pagedResults,
            string format)
        {
            return new JsonResultExtension
            {
                Data =
                    new
                    {
                        total = pagedResults.PagerInfo.PageCount,
                        page = pagedResults.PagerInfo.Page,
                        records = pagedResults.PagerInfo.RecordCount,
                        rows = pagedResults.Data,
                        ExtraDatas = pagedResults.ExtraDatas
                    },
                ContentType = "application/json",
                Format = format
            };
        }

        /// <summary>
        ///     返回分页后信息
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="pagedResults">数据</param>
        /// <param name="format">自定义的格式</param>
        /// <returns>Json数据</returns>
        public static JsonResult JsonForGridPaging<T>(PagedResults<T> pagedResults,
            string format)
        {
            return new JsonResultExtension
            {
                Data =
                    new
                    {
                        total = pagedResults.PagerInfo.PageCount,
                        page = pagedResults.PagerInfo.Page,
                        records = pagedResults.PagerInfo.RecordCount,
                        rows = pagedResults.Data,
                        ExtraDatas = pagedResults.ExtraDatas
                    },
                ContentType = "application/json",
                Format = format
            };
        }
        #endregion*/
    }
}