using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JC.Web.news
{
    public partial class show : App_Code.PageBase
    {
        public JC.Model.posts mpost = new JC.Model.posts();
        public static string tbs = "news";

        protected void Page_Load(object sender, EventArgs e)
        {
            header1.msite = footer1.msite = msite;
            var id = Request.QueryString["id"];
            mpost = bposts.Get(int.Parse(id));

            mpost.hit += 1;
            //更新点击了
            bposts.Update(mpost);
        }
    }
}