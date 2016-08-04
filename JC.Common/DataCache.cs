using System;
using System.Collections;
using System.Web;

namespace JC.Common
{
    /// <summary>
    /// 缓存相关的操作类
    /// Copyright (C) Maticsoft
    /// </summary>
    public class DataCache
    {


        private static int CacheTime = Int32.Parse(JC.Common.JsonHelper.GetJsonSiteObject()["ModelCache"].ToString());
        //5小时

        /// <summary>
        /// 获取当前应用程序指定CacheKey的Cache值
        /// </summary>
        /// <param name="CacheKey"></param>
        /// <returns></returns>
        public static object Get(string CacheKey)
        {
            System.Web.Caching.Cache objCache = HttpRuntime.Cache;
            return objCache[CacheKey];
        }

        /// <summary>
        /// 设置当前应用程序指定CacheKey的Cache值
        /// </summary>
        /// <param name="CacheKey"></param>
        /// <param name="objObject"></param>
        public static void Set(string CacheKey, object objObject)
        {
            System.Web.Caching.Cache objCache = HttpRuntime.Cache;
            if (objObject != null)
            {
                objCache.Insert(CacheKey, objObject, null, DateTime.Now.AddMinutes(CacheTime), TimeSpan.Zero);
            }
        }

        /// <summary>
        /// 删除cache
        /// </summary>
        /// <param name="CacheKey"></param>
        /// <returns></returns>
        public static void Del(string CacheKey)
        {
            System.Web.Caching.Cache objCache = HttpRuntime.Cache;
            if (Get(CacheKey) != null)
            {
                objCache.Remove(CacheKey);
            }
        }

        /// <summary>
        /// 移除全部缓存
        /// </summary>
        public static void Clear()
        {
            System.Web.Caching.Cache objCache = HttpRuntime.Cache;
            IDictionaryEnumerator CacheEnum = objCache.GetEnumerator();
            while (CacheEnum.MoveNext())
            {
                objCache.Remove(CacheEnum.Key.ToString());
            }
        }

    }
}