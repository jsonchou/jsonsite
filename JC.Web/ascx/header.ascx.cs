using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JC.Web.ascx
{
    public partial class header : System.Web.UI.UserControl
    {
        private JC.Model.sites _msite;
        public JC.Model.sites msite
        {
            get { return _msite; }
            set { _msite = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}