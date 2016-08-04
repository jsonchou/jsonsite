using System;
using System.Web;

using Newtonsoft.Json;

namespace JC.Common
{
    public class CookieHelper
    { /// <summary>
      /// 清除指定Cookie
      /// </summary>
      /// <param name="cookiename">cookiename</param>
        public static void Del(string cookiename)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[cookiename];
            if (cookie != null)
            {
                cookie.Expires = DateTime.Now.AddYears(-3);
                HttpContext.Current.Response.Cookies.Add(cookie);
            }
        }
        /// <summary>
        /// 获取指定Cookie值
        /// </summary>
        /// <param name="cookiename">cookiename</param>
        /// <returns></returns>
        public static string Get(string cookiename)
        {
            HttpCookie cookie = HttpContext.Current.Request.Cookies[cookiename];
            string str = string.Empty;
            if (cookie != null)
            {
                str = cookie.Value;
            }
            return str;
        }

        /// <summary>
        /// 添加一个Cookie
        /// </summary>
        /// <param name="cookiename">cookie名</param>
        /// <param name="cookievalue">cookie值</param>
        /// <param name="expires">过期时间 DateTime</param>
        public static void Set(string cookiename, string cookievalue, int? day = 7)
        {
            var obj = JsonHelper.GetJsonSiteObject();
            var dm = obj["site"]["domain"].ToString();
            HttpCookie cookie = new HttpCookie(cookiename)
            {
                Domain = dm,
                Path = "/",
                Value = cookievalue,
                Expires = DateTime.Now.AddDays((double)day)
            };
            HttpContext.Current.Response.Cookies.Add(cookie);
        }

        //清楚全部cookie
        public static void Clear()
        {
            int limit = HttpContext.Current.Request.Cookies.Count;
            for (int i = 0; i < limit; i++)
            {
                string cookieName = HttpContext.Current.Request.Cookies[i].Name;
                Del(cookieName);
            }
        }

    }
}