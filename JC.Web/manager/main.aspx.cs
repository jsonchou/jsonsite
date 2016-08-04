using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JC.Web.manager
{
    public partial class main : App_Code.PageBase
    {
        public int msgsAll = 0;
        public int msgsUnread = 0;
        public int newsAll = 0;
        public int casesAll = 0;
        public int huifangAll = 0;
        public int usersAll = 0;
        public int usersAdmin = 0;
        public int friendlinksAll = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            msgsAll = bposts.Count(" ext='msgs' ");
            msgsUnread = bposts.Count("ext='msgs' and read=0 ");

            newsAll = bposts.Count(" ext='news' ");

            casesAll = bposts.Count(" ext='cases' ");

            huifangAll = bposts.Count(" ext='huifang' ");

            usersAll = busers.Count();
            usersAdmin = busers.Count(" isadmin='1' ");

            friendlinksAll = bposts.Count(" ext='friendlinks' ");

        }
    }
}