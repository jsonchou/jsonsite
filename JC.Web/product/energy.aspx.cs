using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JC.Web.product
{
    public partial class energy : App_Code.PageBase
    {
        public Model.menus mmenu = new Model.menus();
        public string linktag = "energy";
        protected void Page_Load(object sender, EventArgs e)
        {
            header1.msite = footer1.msite = msite;
            mmenu = bmenus.GetList("linktag='" + linktag + "'")[0];
        }
    }
}