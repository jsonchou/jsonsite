using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JC.Web.ashx
{
    /// <summary>
    /// update 的摘要说明
    /// </summary>
    public class update : IHttpHandler, System.Web.SessionState.IReadOnlySessionState
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
                var flag = context.Request.Form["flag"];
                var flagcn = context.Request.Form["flagcn"];
                var v = Int32.Parse(context.Request.Form["v"]);

                if (!string.IsNullOrEmpty(id))
                {
                    if (tb == "users")
                    {
                        BLL.users bl = new BLL.users();
                        Model.users mod = bl.Get(Int32.Parse(id));
                        if (flag == "isadmin")
                        {
                            mod.isadmin = v;
                            mod.modifydate = DateTime.Now;
                            bl.Update(mod);
                        }
                    }
                    else if (tb == "posts")
                    {
                        BLL.posts bl = new BLL.posts();
                        Model.posts mod = bl.Get(Int32.Parse(id));
                        switch (flag)
                        {
                            case "top":
                                mod.top = v;
                                break;
                            case "hot":
                                mod.hot = v;
                                break;
                            case "intro":
                                mod.intro = v;
                                break;
                            case "read":
                                mod.read = v;
                                break;
                            case "blank":
                                mod.blank = v;
                                break;
                            case "enable":
                                mod.enable = v;
                                break;
                        }
                        mod.modifydate = DateTime.Now;
                        bl.Update(mod);
                    }
                    else if (tb == "modules")
                    {
                        BLL.modules bl = new BLL.modules();
                        Model.modules mod = bl.Get(Int32.Parse(id));
                        switch (flag)
                        {
                            case "blank":
                                mod.blank = v;
                                break;
                        }
                        bl.Update(mod);
                    }

                    //保存日志
                    Model.logs lg = new Model.logs();
                    lg.loginfo = "表：" + tb + ",ID：" + id + "设置" + flagcn;
                    App_Code.PageBase.UserLog("修改", lg);

                    str = "{\"code\":1,\"msg\":\"" + id + "修改成功\"}";
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