using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JC.Web.huifang
{
    public partial class index : App_Code.PageBase
    {
        public List<string> menuLevel2List = new List<string>();
        public Model.menus mmenu = new Model.menus();
        public List<JC.Model.posts> mposts = new List<Model.posts>();

        public string tag = string.Empty;
        public static string tbs = "huifang";
        public string enable = " and enable=1 ";
        public string ext = " ext ='" + tbs + "' ";

        protected void Page_Load(object sender, EventArgs e)
        {
            header1.msite = footer1.msite = msite;
            mmenu = bmenus.GetList("linktag='" + tbs + "'")[0];

            tag = Request.QueryString["tag"];

            if (!string.IsNullOrEmpty(tag))
            {
                tag = "and tag='" + tag + "'";//ext1属性分类字段
            }

            if (!IsPostBack)
            {
                pager1.RecordCount = bposts.Count(ext + tag + enable);
            }

            Pager(ext + tag + enable);

            //仅取二级菜单数据
            var obj = Common.JsonHelper.GetJsonSiteObject();
            menuLevel2List = (List<string>)obj["posts"][tbs]["tag"].ToObject(typeof(List<string>));

        }

        protected void PageChanged(object sender, EventArgs e)
        {
            Pager(ext + tag + enable);
        }

        private void Pager(string cond)
        {
            mposts = bposts.GetListByPage(cond, "id desc", ((pager1.CurrentPageIndex - 1) * pager1.PageSize), pager1.PageSize);
        }

    }
}