using System.Web;

using Newtonsoft.Json;

namespace JC.Web.ashx
{
    /// <summary>
    /// get 的摘要说明
    /// </summary>
    public class get : IHttpHandler, System.Web.SessionState.IReadOnlySessionState
    {
        public string userKey = "JCUser";

        public void ProcessRequest(HttpContext context)
        {
            var str = "";
            if (HttpContext.Current.Session[userKey] != null)
            {
                context.Response.ContentType = "text/plain";
                var start = int.Parse(context.Request.Form["start"]);
                var draw = int.Parse(context.Request.Form["draw"]);
                var length = int.Parse(context.Request.Form["length"]);
                var search = context.Request.Form["search[value]"] ?? "";
                var postType = context.Request.QueryString["moduletype"];
                var mid= context.Request.QueryString["id"];

                try
                {

                    if (!string.IsNullOrEmpty(search))
                    {
                        switch (postType)
                        {
                            case "msgs":
                                search = " and " + ("postby like '%" + search + "%' or content like '%" + search + "%' or ext1 like '%" + search + "%' or ext2 like '%" + search + "%'  ");
                                break;
                            case "news":
                                search = " and " + ("postby like '%" + search + "%' or title like '%" + search + "%' or keywords like '%" + search + "%' or contentview like '%" + search + "%'  ");
                                break;
                            case "cases":
                                search = " and " + ("postby like '%" + search + "%' or title like '%" + search + "%' or keywords like '%" + search + "%' or contentview like '%" + search + "%'  ");
                                break;
                            case "friendlinks":
                                search = " and " + ("keywords like '%" + search + "%' or ext1 like '%" + search + "%' or ext2 like '%" + search + "%' ");
                                break;
                            case "widgets":
                                search = " and " + ("title like '%" + search + "%' or content like '%" + search + "%' or ext2 like '%" + search + "%' ");
                                break;
                            case "users":
                                search = ("username like '%" + search + "%' or email like '%" + search + "%'   ");//users 非posts表
                                break;
                            case "logs":
                                search = ("username like '%" + search + "%' or loginfo like '%" + search + "%'   ");//users 非posts表
                                break;
                            case "modules":
                                search = ("(title like '%" + search + "%' or url like '%" + search + "%'   )");//modules 非posts表
                                break;
                            case "menus":
                                search = ("(title like '%" + search + "%' or keywords like '%" + search + "%'  or linktag like '%" + search + "%'   )");//menus 非posts表
                                break;
                        }
                    }

                    if (postType == "users")
                    {
                        BLL.users busers = new BLL.users();
                        var cond =  search;
                        var count = busers.Count(cond);
                        var lst = busers.GetListByPage(cond, " id desc", start, length);
                        str = "{\"code\":1,\"draw\":" + draw + ",\"recordsTotal\":" + count + ",\"recordsFiltered\":" + count + ",\"data\":" + JsonConvert.SerializeObject(lst) + "}";
                    }
                    else if(postType == "logs")
                    {
                        BLL.logs blogs = new BLL.logs();
                        var cond = search;
                        var count = blogs.Count(cond);
                        var lst = blogs.GetListByPage(cond, " id desc", start, length);
                        str = "{\"code\":1,\"draw\":" + draw + ",\"recordsTotal\":" + count + ",\"recordsFiltered\":" + count + ",\"data\":" + JsonConvert.SerializeObject(lst) + "}";
                    }
                    else if (postType == "modules")
                    {
                        BLL.modules bmodules = new BLL.modules();
                        var cond = (!string.IsNullOrEmpty(mid) ? (" path like '%-" + mid + "-%' ") : "") + (!string.IsNullOrEmpty(search) ? " and " + search : "");
                        var count = bmodules.Count(cond);
                        var lst = bmodules.GetListByPage(cond, " path asc", start, length);
                        str = "{\"code\":1,\"draw\":" + draw + ",\"recordsTotal\":" + count + ",\"recordsFiltered\":" + count + ",\"data\":" + JsonConvert.SerializeObject(lst) + "}";
                    }
                    else if (postType == "menus")
                    {
                        BLL.menus bmenus = new BLL.menus();
                        var cond = (!string.IsNullOrEmpty(mid) ? (" path like '%-" + mid + "-%' ") : "") + (!string.IsNullOrEmpty(search) ? " and " + search : "");
                        var count = bmenus.Count(cond);
                        var lst = bmenus.GetListByPage(cond, " path asc", start, length);
                        str = "{\"code\":1,\"draw\":" + draw + ",\"recordsTotal\":" + count + ",\"recordsFiltered\":" + count + ",\"data\":" + JsonConvert.SerializeObject(lst) + "}";
                    }
                    else
                    {
                        BLL.posts bposts = new BLL.posts();
                        var cond = "ext='" + postType + "' " + search;
                        var count = bposts.Count(cond);
                        var lst = bposts.GetListByPage(cond, (postType == "msgs" ? " read=0 and " : "") + " id desc ", start, length);
                        str = "{\"code\":1,\"draw\":" + draw + ",\"recordsTotal\":" + count + ",\"recordsFiltered\":" + count + ",\"data\":" + JsonConvert.SerializeObject(lst) + "}";
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