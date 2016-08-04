using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Wuqi.Webdiyer;

namespace JC.Web.news
{
    public partial class index : App_Code.PageBase
    {
        public List<Model.menus> menuLevel2List = new List<Model.menus>();
        public Model.menus mmenu = new Model.menus();
        public List<JC.Model.posts> mposts = new List<Model.posts>();
        public List<JC.Model.posts> postfocus = new List<Model.posts>();

        public string typeid = string.Empty;
        public static string tbs = "news";
        public string enable = " and enable=1 ";
        public string ext = " ext ='" + tbs + "' ";
        public string fix = " and top=1 ";//置顶

        protected void Page_Load(object sender, EventArgs e)
        {
            header1.msite = footer1.msite = msite;
            mmenu = bmenus.GetList("linktag='" + tbs + "'")[0];
            postfocus = bposts.GetList(ext + enable + fix);

            typeid = Request.QueryString["typeid"];

            if (!string.IsNullOrEmpty(typeid))
            {
                typeid = "and typeid='" + typeid + "'";//ext1属性分类字段
            }

            if (!IsPostBack)
            {
                pager1.RecordCount = bposts.Count(ext + typeid + enable);
            }

            Pager(ext + typeid + enable);

            //仅取二级菜单数据
            menuLevel2List = bmenus.GetList(" parentid= " + mmenu.id);

        }

        protected void PageChanged(object sender, EventArgs e)
        {
            Pager(ext + typeid + enable);
        }

        private void Pager(string cond)
        {
            mposts = bposts.GetListByPage(cond, "id desc", ((pager1.CurrentPageIndex - 1) * pager1.PageSize), pager1.PageSize);
        }

    }
}