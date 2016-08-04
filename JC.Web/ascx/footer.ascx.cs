using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JC.Web.ascx
{
    public partial class footer : System.Web.UI.UserControl
    {
        private JC.Model.sites _msite;
        public JC.Model.sites msite
        {
            get { return _msite; }
            set { _msite = value; }
        }

        Model.menus productParentmenu = new Model.menus();
        public List<Model.menus> productMenulist = new List<Model.menus>();

        Model.menus colorParentmenu = new Model.menus();
        public List<Model.menus> colorMenulist = new List<Model.menus>();

        protected void Page_Load(object sender, EventArgs e)
        {
            BLL.menus bmenus = new BLL.menus();

            productParentmenu = bmenus.GetList().Find(c => c.linktag == "product");
            productMenulist = bmenus.GetList().FindAll(c => c.parentid == productParentmenu.id);//只取一层级

            colorParentmenu = bmenus.GetList().Find(c => c.linktag == "color");
            colorMenulist = bmenus.GetList().FindAll(c => c.parentid == colorParentmenu.id);//只取一层级

        }
    }
}