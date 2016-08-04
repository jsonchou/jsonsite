using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
namespace JC.Web.manager.widgets
{
    public partial class edit : App_Code.PageBase
    {
        public Model.posts post = new Model.posts();
        public string mymodule = "widgets";
        public List<string> pos = new List<string>();

        protected void Page_Load(object sender, EventArgs e)
        {
            var id = Request.QueryString["id"];
            if (!string.IsNullOrEmpty(id))
            {
                post = bposts.Get(int.Parse(id));
            }

            var obj = Common.JsonHelper.GetJsonSiteObject();
            pos = (List<string>)obj["site"]["adposition"].ToObject(typeof(List<string>));
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            //Response.Write(JsonConvert.SerializeObject(Request.Form));
            //Response.Write(JsonConvert.SerializeObject(post));

            post.title = Request.Form["title"];
            post.content = Request.Form["content"];

            post.enable = int.Parse(Request.Form["enableHid"]);//是否有效

            post.blank = int.Parse(Request.Form["blankHid"]);//新窗口打开
            //post.orderby = int.Parse(Request.Form["orderby"]);//排序

            post.ext1 = Request.Form["ext1"];//链接位置(下拉菜单)

            //piclist

            SortedDictionary<int, string> picsb = new SortedDictionary<int, string>();//排序字典，实现默认排序

            for (int i = 0; i < msite.picmaxlength; i++)
            {

                //处理排序
                var orderby = Request.Form["piclist" + (i + 1) + "orderby"];

                //txt，link，picsrc，target，orderby
                var txt = Request.Form["piclist" + (i + 1) + "txt"];
                if (!string.IsNullOrEmpty(txt))
                {
                    txt = txt.Replace(",", "，");
                }
                var link = Request.Form["piclist" + (i + 1) + "link"];
                var picsrc = Request.Form["piclist" + (i + 1)];
                var target = Request.Form["piclist" + (i + 1) + "targetHid"];

                target = target == "1" ? "_blank" : "_self";

                if (!string.IsNullOrEmpty(picsrc) && !string.IsNullOrEmpty(link) && picsrc != msite.nopic)
                {
                    picsb.Add(Int32.Parse(orderby), txt + "," + link + "," + picsrc + "," + target + "," + orderby + "|");
                }

            }
             
            var sb = new StringBuilder();
            foreach (var item in picsb)
            {
                sb.Append(item.Value);
            }
            post.piclist = sb.ToString().Trim('|');

            post.modifydate = DateTime.Now;
            post.postby = !string.IsNullOrEmpty(post.postby) ? post.postby : muser.username;

            Model.logs lg = new Model.logs();
            if (post != null && post.id != 0)
            {
                bposts.Update(post);

                lg.loginfo = "表：" + "sites" + ",ID：" + msite.id;
                UserLog("修改", lg);
            }
            else
            {

                post.postdate = DateTime.Now;
                post.ext = mymodule;//VIP code,for extend fields

                //JC.Common.LogHelper.Info(JsonConvert.SerializeObject(post));

                int newid = bposts.Add(post);

                lg.loginfo = "表：" + "sites" + ",ID：" + newid;
                UserLog("增加", lg);
            }

            txtMsg.Style["display"] = "block";

            txtMsg.Attributes["class"] = "callout callout-info";

        }
    }
}