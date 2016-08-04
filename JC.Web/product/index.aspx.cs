using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
namespace JC.Web.product
{
    public partial class index : App_Code.PageBase
    {
        public Model.menus mmenu = null;
        public JC.Model.posts mpost = null;
        public string linktag = "product";
        protected void Page_Load(object sender, EventArgs e)
        {
            header1.msite = footer1.msite = msite;
            mmenu = bmenus.GetList("linktag='" + linktag + "'")[0];
            var temp = bposts.GetList("ext='widgets' and ext1 = '产品首页' ");
            JC.Common.LogHelper.Info(Newtonsoft.Json.JsonConvert.SerializeObject(temp));
            if (temp != null && temp.Count > 0)
            {
                mpost = temp[0];
            }

        }
    }
}