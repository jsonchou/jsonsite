using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JC.Web.qa
{
    public partial class index : App_Code.PageBase
    {
        public Model.menus mmenu = new Model.menus();
        public string tbs = "qa";
        public List<JC.Model.posts> mposts = new List<Model.posts>();
        protected void Page_Load(object sender, EventArgs e)
        {
            header1.msite = footer1.msite = msite;
            mposts = bposts.GetList("ext='"+ tbs + "' and enable=1 and top=1 ");
            mmenu = bmenus.GetList(" linktag='" + tbs + "'")[0];
        }
    }
}