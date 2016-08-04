using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace JC.Web.manager.modules
{
    public partial class edit : App_Code.PageBase
    {

        public List<Model.modules> modules = new List<Model.modules>();
        public Model.modules module = new Model.modules();

        public string mymodule = "modules";
        public string myid = string.Empty;
        public string myparentid = string.Empty;
        public string mypath = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            myid = Request.QueryString["id"];
            modules = bmodules.GetListByPage("", "path asc", 0, 100);
            if (!string.IsNullOrEmpty(myid))
            {
                module = modules.Find(c => c.id == Int32.Parse(myid));
                if (module != null)
                {
                    myparentid = module.parentid.ToString();
                    mypath = module.path;
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            //Response.Write(JsonConvert.SerializeObject(Request.Form));
            //Response.Write(JsonConvert.SerializeObject(module));

            module.path = string.IsNullOrEmpty(Request.Form["path"]) ? "-" : Request.Form["path"];
            module.parentid = int.Parse(string.IsNullOrEmpty(Request.Form["parentid"]) ? "0" : Request.Form["parentid"]);

            module.title = Request.Form["title"];
            module.url = Request.Form["url"];

            module.content = Server.HtmlEncode(Request.Form["content"]);
            module.blank = int.Parse(Request.Form["ckBlankHid"]);//是否新窗口打开

            module.pic = Request.Form["pic"];
            module.orderby = int.Parse(Request.Form["orderby"]);

            Model.logs lg = new Model.logs();
            if (module != null && module.id != 0)
            {
                bmodules.Update(module);

                lg.loginfo = "表：" + mymodule + ",ID：" + module.id;
                UserLog("修改", lg);
            }
            else
            {
                var pathArr = module.path.Trim('-').Split('-');
                if (pathArr.Length == 1 && string.IsNullOrEmpty(pathArr[0]))
                {
                    pathArr[0] = "0";
                }
                module.parentid = (Int32.Parse(pathArr[pathArr.Length - 1]));//倒数第二个

                var latestid = bmodules.Add(module);

                //新增之后，更新细节
                module = bmodules.Get(latestid);
                
                if (string.IsNullOrEmpty(module.path))
                {
                    module.path = "-";
                }

                module.path = module.path + latestid + '-';
                bmodules.Update(module);

                lg.loginfo = "表：" + mymodule + ",ID：" + latestid;
                UserLog("增加", lg);
            }

            JC.Common.CookieHelper.Del("gUzaiManagerMenu-EndTime");

            //更新扩展信息
            FixModules();

            txtMsg.Style["display"] = "block";

            txtMsg.Attributes["class"] = "callout callout-info";

        }

        public List<Model.modules> singleModules(int parentid = 0)
        {
            return modules.FindAll(c => c.parentid == parentid);
        }
    }
}