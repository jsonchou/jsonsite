using System;
using System.Collections.Generic;

namespace JC.Web
{
    public partial class index :App_Code.PageBase
    {
        public List<JC.Model.posts> mposts = new List<Model.posts>();
        public JC.Model.posts mpost = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            header1.msite = footer1.msite = msite;
            mposts = bposts.GetListByPage("ext='news'", "id desc", 0, 9);
            var temp = bposts.GetList("ext='widgets' and ext1 = '首页' ");
            if (temp != null && temp.Count > 0) {
                mpost = temp[0];
            }
        }
    }
}