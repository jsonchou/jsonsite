using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;
using Microsoft.AspNet.FriendlyUrls.Resolvers;

namespace JC.Web
{

    //ckfinder has some bug with FriendlyUrls

    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.Canonicalize().Lowercase();
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings, new IFriendlyUrlResolver[] { new MyWebFormsFriendlyUrlResolver() });

        }
        public class MyWebFormsFriendlyUrlResolver : WebFormsFriendlyUrlResolver
        {
            public MyWebFormsFriendlyUrlResolver() { }

            public override string ConvertToFriendlyUrl(string path)
            {
                if (!string.IsNullOrEmpty(path) && path.ToLower().Contains("/ckfinder/"))
                {
                    return path;
                }
                return base.ConvertToFriendlyUrl(path);
            }
        }
    }
}

