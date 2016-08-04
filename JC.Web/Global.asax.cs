using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;

using JC.BLL;
using JC.Model;

namespace JC.Web
{
    public class Global : HttpApplication
    {
        public BLL.menus bmenus = new BLL.menus();
        public BLL.modules bmodules = new BLL.modules();
        public BLL.sites bsites = new BLL.sites();
        public BLL.users busers = new BLL.users();
        public BLL.posts bposts = new BLL.posts();
        public BLL.logs blogs = new BLL.logs();

        public Model.sites msite = new Model.sites();

        void Application_Start(object sender, EventArgs e)
        {

            //初始化缓存
            bmenus.initCache();
            bmodules.initCache();
            bsites.initCache();
            busers.initCache();
            bposts.initCache();
            blogs.initCache();

            // 在应用程序启动时运行的代码
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}