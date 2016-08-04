using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JC.Web.cases
{
    public partial class show : App_Code.PageBase
    {
        public List<string> menuLevel2List = new List<string>();
        public JC.Model.posts mpost = new JC.Model.posts();
        public static string tbs = "cases";

        protected void Page_Load(object sender, EventArgs e)
        {
            header1.msite = footer1.msite = msite;
            var id = Request.QueryString["id"];
            mpost = bposts.Get(int.Parse(id));

            mpost.hit += 1;
            //更新点击了
            bposts.Update(mpost);

            //仅取二级菜单数据
            var obj = Common.JsonHelper.GetJsonSiteObject();
            menuLevel2List = (List<string>)obj["posts"][tbs]["tag"].ToObject(typeof(List<string>));

        }
    }
}