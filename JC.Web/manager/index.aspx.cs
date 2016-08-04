using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JC.Web.manager
{
    public partial class index : App_Code.PageBase
    {
        public List<Model.logs> loglist = new List<Model.logs>();
        public int msgUnRead = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            //判断是否存在站点配置信息，否则跳转
            if (bsites.GetList().Count == 0)
            {
                Response.Redirect("/manager/site/index");
            }
             
            //日志列表
            loglist = blogs.GetListByPage("", "id desc", 0, 8);

            //最多一万
            msgUnRead = bposts.Count(" ext='msgs' and read=0 ");

        }

    }
}