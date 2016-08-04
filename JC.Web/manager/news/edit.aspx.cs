using System;
using System.Text;
using System.Collections.Generic;

using Newtonsoft.Json;
using JC.Model;


namespace JC.Web.manager.news
{
    public partial class edit : App_Code.PageBase
    {
        public Model.posts post = new Model.posts();
        public string mymodule = "news";

        public List<Model.menus> menus = new List<Model.menus>();
        public Model.menus menu = new Model.menus();

        public string mytablename = "menus";
        public string mymenuid = string.Empty;
        public string myparentid = string.Empty;
        public string mypath = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            var id = Request.QueryString["id"];
            menus = bmenus.GetListByPage("", "path asc", 0, 100);

            if (!string.IsNullOrEmpty(id))
            {
                post = bposts.Get(int.Parse(id));

                menu = menus.Find(c => c.id == post.typeid);
                if (menu != null)
                {
                    myparentid = menu.parentid.ToString();
                    mypath = menu.path;
                }

                ////无论如何，禁止更多下拉菜单选项
                //menu = menus.FindAll(c => c.linktag == mymodule)[0];
                //myparentid = menu.parentid.ToString();
                //mypath = menu.path;

            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            //Response.Write(JsonConvert.SerializeObject(Request.Form));
            //Response.Write(JsonConvert.SerializeObject(post));

            post.enable = int.Parse(Request.Form["enableHid"]);

            post.title = Request.Form["title"];
            post.keywords = JC.Common.Common.ToDBC(Request.Form["keywords"]);
            post.content = Server.HtmlEncode(Request.Form["content"]);
            post.description = Server.HtmlEncode(string.IsNullOrEmpty(Request.Form["description"]) ? Common.Common.CutString(Common.Common.checkString(Request.Form["content"]).Trim(), 200, false) : Request.Form["description"]);

            if (msite.lang.Contains("英文"))
            {
                post.titleen = Request.Form["titleen"];
                post.keywordsen = JC.Common.StringPlus.ToDBC(Request.Form["keywordsen"]);
                post.contenten = Server.HtmlEncode(Request.Form["contenten"]);
                post.descriptionen = Server.HtmlEncode(string.IsNullOrEmpty(Request.Form["descriptionen"]) ? Common.Common.CutString(Common.Common.checkString(Request.Form["contenten"]).Trim(), 200, false) : Request.Form["descriptionen"]);
            }

            post.pic = Request.Form["pic"];
            post.hit = int.Parse(Request.Form["hit"]);

            post.top = int.Parse(Request.Form["ckTopHid"]);
            post.hot = int.Parse(Request.Form["ckHotHid"]);
            post.intro = int.Parse(Request.Form["ckIntroHid"]);

            post.postby = !string.IsNullOrEmpty(post.postby) ? post.postby : muser.username;
            post.modifydate = DateTime.Now;


            //处理typeid
            var pid = Request.Form["path"];//取最后一个
            var pathArr = pid.Trim('-').Split('-');
            if (pathArr.Length == 1 && string.IsNullOrEmpty(pathArr[0]))
            {
                pathArr[0] = "0";
            }
            var tempid = pathArr[pathArr.Length - 1];
            post.typeid = Int32.Parse(tempid);
            //处理typeid

            Model.logs lg = new Model.logs();
            if (post != null && post.id != 0)
            {
                bposts.Update(post);

                lg.loginfo = "表：" + mymodule + ",ID：" + post.id;
                UserLog("修改", lg);
            }
            else
            {
                post.postdate = DateTime.Now;
                post.ext = mymodule;//VIP code,for extend fields
                var newid = bposts.Add(post);

                lg.loginfo = "表：" + mymodule + ",ID：" + newid;
                UserLog("增加", lg);
            }

            txtMsg.Style["display"] = "block";

            txtMsg.Attributes["class"] = "callout callout-info";

        }

        public List<Model.menus> singleMenus(int parentid = 0)
        {
            return menus.FindAll(c => c.parentid == parentid);
        }

    }
}