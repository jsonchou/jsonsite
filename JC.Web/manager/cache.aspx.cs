using System;
using System.Collections;
using System.Web;

using Newtonsoft.Json;

namespace JC.Web.manager
{
    public partial class cache : App_Code.PageBase
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("---------------遍历cookies------------------\r\n<br />");
            getCookies(); //遍历cookies
            Response.Write("---------------------------------\r\n<br /><br />");

            Response.Write("--------------遍历session-------------------\r\n<br />");
            getSessions(); //遍历session
            Response.Write("---------------------------------\r\n<br /><br />");

            Response.Write("----------------遍历application-----------------\r\n<br />");
            getApplications(); //遍历application
            Response.Write("---------------------------------\r\n<br /><br />");

            Response.Write("-----------------遍历cache----------------\r\n<br />");
            getCaches(); //遍历cache
            Response.Write("---------------------------------\r\n<br /><br />");

            Response.Write("-----------------6666666666666666666666666666666666----------------\r\n<br /><br />");

            Response.Write(JsonConvert.SerializeObject((JC.Model.users)Session["JCUser"]) + "\r\n<br />");

        }

        private void getCookies()
        {
            for (int i = 0; i < HttpContext.Current.Request.Cookies.Count; i++)
            {
                Response.Write(HttpContext.Current.Request.Cookies.Keys[i] + ":" + HttpContext.Current.Request.Cookies[i].Value.ToString() + "\r\n<br />");
            }
        }

        private void getSessions()
        {
            for (int i = 0; i < HttpContext.Current.Session.Count; i++)
            {
                Response.Write(HttpContext.Current.Session.Keys[i] + ":" + HttpContext.Current.Session[i].ToString() + "<br>");
            }
        }

        private void getApplications()
        {
            for (int i = 0; i < HttpContext.Current.Application.Count; i++)
            {
                Response.Write(HttpContext.Current.Application.Keys[i] + ":" + HttpContext.Current.Application[i].ToString() + "<br>");
            }
        }

        private void getCaches()
        {
            System.Web.Caching.Cache objCache = HttpRuntime.Cache;
            IDictionaryEnumerator CacheEnum = objCache.GetEnumerator();
            while (CacheEnum.MoveNext())
            {
                Response.Write(CacheEnum.Key.ToString() + "：");
                Response.Write(JsonConvert.SerializeObject(CacheEnum.Value) + "\r\n<br />");
            }
        }
    }
}