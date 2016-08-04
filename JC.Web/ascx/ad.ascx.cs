using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JC.Web.ascx
{
    public partial class ad : System.Web.UI.UserControl
    {
        public BLL.posts bpost = new BLL.posts();
        public Model.posts mpost = new Model.posts();
        protected void Page_Load(object sender, EventArgs e)
        {
            mpost = bpost.GetList("ext='widgets' and enable=1 and ext1 = '文章详情页' ")[0];
        }
    }
}