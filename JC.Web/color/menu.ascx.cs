using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JC.Web.color
{
    public partial class menu : System.Web.UI.UserControl
    {
        Model.menus parentmenu = new Model.menus();
        public List<Model.menus> menulist = new List<Model.menus>();
        public string linktag = "color";

        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.menus bmenus = new BLL.menus();
            parentmenu = bmenus.GetList().Find(c => c.linktag == linktag);
            menulist = bmenus.GetList().FindAll(c => c.parentid == parentmenu.id);//只取一层级
        }
    }
}