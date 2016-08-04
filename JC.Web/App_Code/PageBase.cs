using System;
using System.Web;
using System.Web.UI;
using System.Collections.Generic;
using JC.Common;
using Newtonsoft.Json;

namespace JC.Web.App_Code
{
    /// <summary>
    /// 页面层(表示层)基类,所有页面继承该页面
    /// </summary>
    public class PageBase : System.Web.UI.Page
    {
        public static string userKey = "JCUser";
        
        public static BLL.sites bsites = new BLL.sites();
        public static BLL.posts bposts = new BLL.posts();
        public static BLL.menus bmenus = new BLL.menus();
        public static BLL.modules bmodules = new BLL.modules();
        public static BLL.users busers = new BLL.users();
        public static BLL.logs blogs = new BLL.logs();

        public static Model.sites msite = new Model.sites();
        public static Model.users muser = new Model.users();

        /// <summary>
        /// 数据信息工整
        /// </summary>
        public static void FixModules() {
            BLL.modules bmodules = new BLL.modules();
            var list = bmodules.GetList();
            for (int i = 0; i < list.Count; i++)
            {
                var item = list[i];
                var itempath = item.path;
                var itempathArr = itempath.Trim('-').Split('-');
                var pathdeep = itempathArr.Length;

                var innerList = bmodules.GetList().FindAll(c => c.path.IndexOf(itempath) > -1);
                var realModule = bmodules.GetList().Find(c => c.path == itempath);//绝对存在

                if (realModule != null)
                {
                    if (innerList.Count > 1)
                    {
                        realModule.stem = 1;
                        realModule.haschild = 1;
                    }
                    else
                    {
                        realModule.stem = 0;
                        realModule.haschild = 0;
                    }

                    bmodules.Update(realModule);
                }
            }
        }

        /// <summary>
        /// 删除外键数据相关
        /// </summary>
        /// <param name="ids"></param>
        public static void FixModulesExt(string ids)
        {
            BLL.modules bmodules = new BLL.modules();
            var arr = ids.Split(',');
            for (int i = 0; i < arr.Length; i++)
            {
                var id = arr[i];
                var module = bmodules.Get(Int32.Parse(id));

                if (module != null)
                {
                    var list = bmodules.GetList().FindAll(c => c.path.IndexOf(module.path) > -1);
                    for (int j = 0; j < list.Count; j++)
                    {
                        var sub = list[j];
                        bmodules.Del(sub.id);
                    }
                }
            }
        }


        /// <summary>
        /// 数据信息工整
        /// </summary>
        public static void FixMenus()
        {
            BLL.menus bmenus = new BLL.menus();
            var list = bmenus.GetList();
            for (int i = 0; i < list.Count; i++)
            {
                var item = list[i];
                var itempath = item.path;
                var itempathArr = itempath.Trim('-').Split('-');
                var pathdeep = itempathArr.Length;

                var innerList = bmenus.GetList().FindAll(c => c.path.IndexOf(itempath) > -1);
                var realMenu = bmenus.GetList().Find(c => c.path == itempath);//绝对存在

                if (realMenu != null)
                {
                    if (innerList.Count > 1)
                    {
                        realMenu.stem = 1;
                        realMenu.haschild = 1;
                    }
                    else
                    {
                        realMenu.stem = 0;
                        realMenu.haschild = 0;
                    }

                    bmenus.Update(realMenu);
                }
            }
        }

        /// <summary>
        /// 删除外键数据相关
        /// </summary>
        /// <param name="ids"></param>
        public static void FixMenusExt(string ids)
        {

            BLL.menus bmenus = new BLL.menus();
            BLL.posts bposts = new BLL.posts();

            var arr = ids.Split(',');
            for (int i = 0; i < arr.Length; i++)
            {
                var id = arr[i];
                var menu = bmenus.Get(Int32.Parse(id));
                 
                if (menu != null)
                {
                    var list = bmenus.GetList().FindAll(c => c.path.IndexOf(menu.path) > -1);
                    for (int j = 0; j < list.Count; j++)
                    {
                        var sub = list[j];
                        bmenus.Del(sub.id);//删除关联menus

                        //删除关联子posts，并非typeid in ids
                        var postList = bposts.GetList("typeid=" + sub.id);
                        for (int m = 0; m < postList.Count; m++)
                        {
                            var item = postList[m];
                            bposts.Del(item.id);
                        }


                    }
                }
            }
        }

         
        protected override void OnInit(EventArgs e)
        {
            if (bsites.GetList().Count > 0)
            {
                msite = bsites.GetList()[0];
                muser = (Model.users)Session[userKey];
            }

            if (!Page.IsPostBack)
            {
                var inm = Request.Url.ToString().ToLower().IndexOf("/manager/");
                if (inm > -1)
                {
                    //权限验证
                    if (Session[userKey] == null)
                    {
                        if (Request.Url.ToString().ToLower().IndexOf("/manager/login") == -1)
                        {
                            Response.Write("<script>if(window.opener){window.opener.document.location='/manager/login';}else{document.location='/manager/login';};</script>");
                        }
                    }
                }
                else
                {
                    //前台页面
                }
            }

            base.OnInit(e);
            this.Load += new System.EventHandler(PageBase_Load);
            this.Error += new System.EventHandler(PageBase_Error);
        }

        //错误处理
        protected void PageBase_Error(object sender, System.EventArgs e)
        {
            string errMsg;
            Exception currentError = Server.GetLastError();
            errMsg = "<link rel=\"stylesheet\" href=\"/style.css\">";
            errMsg += "<h1>系统错误：</h1><hr/>系统发生错误， " +
                "该信息已被系统记录，请稍后重试或与管理员联系。<br/>" +
                "错误地址： " + Request.Url.ToString() + "<br/>" +
                "错误信息： <font class=\"ErrorMessage\">" + currentError.Message.ToString() + "</font><hr/>" +
                "<b>Stack Trace:</b><br/>" + currentError.ToString();
            Response.Write(errMsg);
            Server.ClearError();

        }

        private void PageBase_Load(object sender, EventArgs e)
        {
            
        }

        public static void UserLog(string tag, Model.logs lg)
        {
            var obj = Common.JsonHelper.GetJsonSiteObject();
            var logname = (List<string>)obj["manager"]["logs"]["name"].ToObject(typeof(List<string>));
            var logcode = (List<string>)obj["manager"]["logs"]["code"].ToObject(typeof(List<string>));
            var tagcode = logcode[logname.IndexOf(tag)];

            var my = (Model.users)HttpContext.Current.Session[userKey];
            if (my != null)
            {
                //保存日志
                lg.postdate = DateTime.Now;
                lg.username = my.username;
                lg.logtype = tag + ":" + tagcode;
                lg.loginfo = tag + (lg.loginfo ?? "");
                blogs.Add(lg);
            }
        }

        //清楚日志
        public static void UserLogRemove() {
            var logday = msite.logday;
            var boo= blogs.DelWhere(" postdate <  date('now','start of day','-" + logday + " days') ");

            if (boo)
            {
                //记录日志
                Model.logs lg = new Model.logs();
                lg.loginfo = "表：" + "logs" + ",范围：前" + logday + "天日志";
                UserLog("删除", lg);
            }
        }
         
       
    }
}
