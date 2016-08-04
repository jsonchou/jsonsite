using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JC.Web.manager
{
    public partial class logout : App_Code.PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //保存日志
            JC.Model.logs lg = new Model.logs();
            UserLog("退出", lg);

            JC.Common.CookieHelper.Del("gUzaiManagerMenu-EndTime");
            JC.Common.CookieHelper.Del("JCUser");
            Session.Remove(userKey);
            Session.Abandon();
            Response.Redirect("/manager/login");
        }
    }
}