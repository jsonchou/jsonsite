using System;

namespace JC.Web.manager.qa
{
    public partial class edit : App_Code.PageBase
    {
        public Model.posts post = new Model.posts();
        public string mymodule = "qa";

        protected void Page_Load(object sender, EventArgs e)
        {
            var id = Request.QueryString["id"];
            if (!string.IsNullOrEmpty(id))
            {
                post = bposts.Get(int.Parse(id));
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            //Response.Write(JsonConvert.SerializeObject(Request.Form));
            //Response.Write(JsonConvert.SerializeObject(post));

            post.postby = Request.Form["postby"];

            post.title = Request.Form["title"];//咨询内容
            post.content = Server.HtmlEncode(Request.Form["content"]);//回复内容
            
            post.top = Int32.Parse(Request.Form["ckTopHid"]);//置顶？
            post.enable = Int32.Parse(Request.Form["ckEnableHid"]);//有效？

            post.modifydate = DateTime.Now;
            post.postby = !string.IsNullOrEmpty(post.postby) ? post.postby : muser.username;

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
    }
}