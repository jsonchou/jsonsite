using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Newtonsoft.Json;

namespace JC.Web.ashx
{
    /// <summary>
    /// cascadingmenu 的摘要说明
    /// </summary>
    public class cascadingmenu : IHttpHandler, System.Web.SessionState.IReadOnlySessionState
    {
        public string userKey = "JCUser";

        public void ProcessRequest(HttpContext context)
        {
            var str = "";
            if (HttpContext.Current.Session[userKey] != null)
            {
                context.Response.ContentType = "text/plain";
                var postType = context.Request.Form["module"];
                var parentid = context.Request.Form["id"];

                try
                {
                    if (postType == "modules")
                    {
                        BLL.modules bmodules = new BLL.modules();
                        var lst = bmodules.GetListByPage("parentid="+ parentid, " path asc", 0, 100);
                        str = "{\"code\":1,\"data\":" + JsonConvert.SerializeObject(lst) + "}";
                    }
                    else if (postType == "menus")
                    {
                        BLL.menus bmenus = new BLL.menus();
                        var lst = bmenus.GetListByPage("parentid=" + parentid, " path asc", 0, 100);
                        str = "{\"code\":1,\"data\":" + JsonConvert.SerializeObject(lst) + "}";
                    }
                }
                catch (System.Exception)
                {
                    str = "{\"code\":-2,\"msg\":\"位置错误\"}";
                    throw;
                }
            }
            else
            {
                str = "{\"code\":-1,\"msg\":\"权限错误\"}";
            }
            context.Response.Write(str);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }


    }
}