using System;
using System.Collections.Generic;
using System.Text;

namespace JC.Web.manager.menus
{
    public partial class index : App_Code.PageBase
    {
        public string mymodule = "menus";
        public string mymoduleid = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            mymoduleid = Request.QueryString["id"];
        }
    }
}

