using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace JC.Web.manager.menus
{
    public partial class edit : App_Code.PageBase
    {

        public List<Model.menus> menus = new List<Model.menus>();
        public Model.menus menu = new Model.menus();

        public string mytablename = "menus";
        public string mymenuid = string.Empty;
        public string myparentid = string.Empty;
        public string mypath = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            mymenuid = Request.QueryString["id"];
            menus = bmenus.GetListByPage("", "path asc", 0, 100);
            if (!string.IsNullOrEmpty(mymenuid))
            {
                menu = menus.Find(c => c.id == Int32.Parse(mymenuid));
                if (menu != null)
                {
                    myparentid = menu.parentid.ToString();
                    mypath = menu.path;
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            //Response.Write(JsonConvert.SerializeObject(Request.Form));
            //Response.Write(JsonConvert.SerializeObject(menu));

            menu.linktag = Request.Form["linktag"];

            menu.path = string.IsNullOrEmpty(Request.Form["path"]) ? "-" : Request.Form["path"];
            menu.parentid = int.Parse(string.IsNullOrEmpty(Request.Form["parentid"]) ? "0" : Request.Form["parentid"]);

            menu.title = Request.Form["title"];
            menu.keywords = JC.Common.Common.ToDBC(Request.Form["keywords"]);
            menu.description = Server.HtmlEncode(Request.Form["description"]);
            menu.content = Server.HtmlEncode(Request.Form["content"]);

            menu.titleen = Request.Form["titleen"];
            menu.keywordsen = JC.Common.StringPlus.ToDBC(Request.Form["keywordsen"]);
            menu.descriptionen = Server.HtmlEncode(Request.Form["descriptionen"]);
            menu.contenten = Server.HtmlEncode(Request.Form["contenten"]);

            menu.pic = Request.Form["pic"];
            menu.orderby = int.Parse(Request.Form["orderby"]);

            //-----------------------------------------

            Model.logs lg = new Model.logs();
            if (menu != null && menu.id != 0)
            {
                bmenus.Update(menu);

                lg.loginfo = "表：" + mytablename + ",ID：" + menu.id;
                UserLog("修改", lg);
            }
            else
            {
                var pathArr = menu.path.Trim('-').Split('-');
                if (pathArr.Length == 1 && string.IsNullOrEmpty(pathArr[0]))
                {
                    pathArr[0] = "0";
                }
                menu.parentid = (Int32.Parse(pathArr[pathArr.Length - 1]));//倒数第二个

                var latestid = bmenus.Add(menu);

                //新增之后，更新细节
                menu = bmenus.Get(latestid);

                if (string.IsNullOrEmpty(menu.path))
                {
                    menu.path = "-";
                }

                menu.path = menu.path + latestid + '-';
                bmenus.Update(menu);

                lg.loginfo = "表：" + mytablename + ",ID：" + latestid;
                UserLog("增加", lg);
            }


            //更新扩展信息
            FixMenus();

            txtMsg.Style["display"] = "block";

            txtMsg.Attributes["class"] = "callout callout-info";

        }

        public List<Model.menus> singleMenus(int parentid = 0)
        {
            return menus.FindAll(c => c.parentid == parentid);
        }
    }
}