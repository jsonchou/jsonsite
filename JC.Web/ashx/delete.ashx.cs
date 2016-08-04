using System;
using System.Web;

namespace JC.Web.ashx
{
    /// <summary>
    /// delete 的摘要说明
    /// </summary>
    public class delete : IHttpHandler, System.Web.SessionState.IReadOnlySessionState
    {
        public string userKey = "JCUser";

        public void ProcessRequest(HttpContext context)
        {
            var str = "";
            var user = (Model.users)HttpContext.Current.Session[userKey];
            BLL.logs blogs = new BLL.logs();
            if (user != null)
            {
                context.Response.ContentType = "text/plain";
                var id = context.Request.Form["id"];//ids:2,4,6
                var tb = context.Request.Form["model"];
                 
                if (!string.IsNullOrEmpty(id))
                {
                    if (tb == "users")
                    {
                        BLL.users bl = new BLL.users();
                        bl.Del(id);
                    }
                    else if (tb == "logs")
                    {
                        BLL.logs bl = new BLL.logs();
                        bl.Del(id);
                    }
                    else if (tb == "posts")
                    {
                        BLL.posts bl = new BLL.posts();
                        bl.Del(id);
                    }
                    else if (tb == "menus")
                    {
                        BLL.menus bl = new BLL.menus();

                        //先删除删除扩展信息
                        App_Code.PageBase.FixMenusExt(id);

                        //更新扩展信息
                        App_Code.PageBase.FixMenus();
                    }
                    else if (tb == "modules")
                    {
                        BLL.modules bl = new BLL.modules();

                        //先删除删除扩展信息
                        App_Code.PageBase.FixModulesExt(id);

                        //更新扩展信息
                        App_Code.PageBase.FixModules();

                    }

                    //保存日志
                    Model.logs lg = new Model.logs();
                    lg.loginfo = "表：" + tb + ",ID：" + id;
                    App_Code.PageBase.UserLog("删除", lg);

                    str = "{\"code\":1,\"msg\":\"" + id + "删除成功\"}";
                }
                else
                {
                    str = "{\"code\":0,\"msg\":\"ID传值错误\"}";
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