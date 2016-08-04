using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JC.Web.manager.friendlinks
{
    public partial class edit : App_Code.PageBase
    {
        public Model.posts post = new Model.posts();
        public string mymodule = "friendlinks";
        public List<string> pos = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            var id = Request.QueryString["id"];
            if (!string.IsNullOrEmpty(id))
            {
                post = bposts.Get(int.Parse(id));
            }
            var obj = Common.JsonHelper.GetJsonSiteObject();
            pos = (List<string>)obj["site"]["friendlinkposition"].ToObject(typeof(List<string>));
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            //Response.Write(JsonConvert.SerializeObject(Request.Form));
            //Response.Write(JsonConvert.SerializeObject(post));

            post.keywords = Request.Form["keywords"];
            post.pic = Request.Form["pic"];

            post.enable = int.Parse(Request.Form["enableHid"]);

            post.ext1 = Request.Form["ext1"];//链接地址
            post.ext2 = Request.Form["ext2"];//联系人信息（QQ，邮箱）
            post.ext3 = Request.Form["ext3"];//链接位置(下拉菜单)

            post.blank = int.Parse(Request.Form["blankHid"]);//新窗口打开
            post.orderby = int.Parse(Request.Form["orderby"]);//排序

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