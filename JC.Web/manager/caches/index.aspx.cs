using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JC.Web.manager.caches
{
    public partial class index : App_Code.PageBase
    {
        public string key = "site.json";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSite_Click(object sender, EventArgs e)
        {
            JC.Model.logs lg = new Model.logs();
            lg.loginfo = "站点缓存";
            UserLog("删除", lg);
            
            JC.Common.DataCache.Del(key);

            txtMsg.Style["display"] = "block";
            txtMsg.Attributes["class"] = "callout callout-info";
        }

        protected void btnSession_Click(object sender, EventArgs e)
        {
            JC.Model.logs lg = new Model.logs();
            lg.loginfo = "站点Session";
            UserLog("删除", lg);

            Session.Clear();//删除全站session

            txtMsg.Style["display"] = "block";
            txtMsg.Attributes["class"] = "callout callout-info";
        }

        protected void btnCookie_Click(object sender, EventArgs e)
        {
            JC.Model.logs lg = new Model.logs();
            lg.loginfo = "本地Cookie";
            UserLog("删除", lg);

            JC.Common.CookieHelper.Clear();//本地Cookie

            txtMsg.Style["display"] = "block";
            txtMsg.Attributes["class"] = "callout callout-info";
        }

        protected void btnCache_Click(object sender, EventArgs e)
        {
            JC.Model.logs lg = new Model.logs();
            lg.loginfo = "站点缓存";
            UserLog("删除", lg);

            JC.Common.DataCache.Clear();

            txtMsg.Style["display"] = "block";
            txtMsg.Attributes["class"] = "callout callout-info";
        }

        protected void btnAll_Click(object sender, EventArgs e)
        {
            JC.Model.logs lg = new Model.logs();
            lg.loginfo = "全站缓存";
            UserLog("删除", lg);

            JC.Common.CookieHelper.Clear();
            JC.Common.DataCache.Clear();
            Session.Clear();

            txtMsg.Style["display"] = "block";
            txtMsg.Attributes["class"] = "callout callout-info";

        }
    }
}