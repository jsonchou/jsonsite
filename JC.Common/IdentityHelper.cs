using System;
using System.Web;
using System.Web.Security;

namespace JC.Common
{
    public class IdentityHelper
    {
        #region 管理员退出
        public static void AdminLoginOut()
        {
            FormsAuthentication.SignOut();
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName);
            cookie.Expires = System.DateTime.Now.AddDays(-1);
            HttpContext.Current.Response.Cookies.Add(cookie);//过期后,还有把'Cookie'发到客户端,让他过期,页面必须跳转
            HttpContext.Current.Response.Redirect("http://admin.bang.52wuhan.com/login.aspx");
        }
        #endregion

        #region 添加FormsCookie
        /// <summary>
        /// 添加formscookie
        /// </summary>
        /// <param name="UserID">登陆名</param>
        /// <param name="UserData">用户数据</param>
        public static void AddFormsCookie(string adminName, string adminData)
        {
            FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, adminName, DateTime.Now, DateTime.Now.AddMonths(1), false, adminData, FormsAuthentication.FormsCookiePath);
            string hash = FormsAuthentication.Encrypt(ticket);
            HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, hash);
            if (ticket.IsPersistent)
            {
                cookie.Expires = ticket.Expiration;
            }
            HttpContext.Current.Response.Cookies.Add(cookie);
        }
        #endregion

        #region 获取管理员角色ID
        public static int GetAdminRoleID()
        {
            int Result = 0;
            string formCookieName = FormsAuthentication.FormsCookieName;
            if (!string.IsNullOrEmpty(formCookieName))
            {
                HttpCookie hc = HttpContext.Current.Request.Cookies[formCookieName];
                if (null != hc)
                {
                    FormsAuthenticationTicket formTicket = FormsAuthentication.Decrypt(hc.Value);
                    if (formTicket != null)
                    {
                        Result = int.Parse(formTicket.UserData.Split('|')[0]);
                    }
                }
            }
            return Result;
        }
        #endregion

        #region 获取角管理员权限模块列表
        public static string GetAdminModule()
        {
            string Result = "";
            string formCookieName = FormsAuthentication.FormsCookieName;
            if (!string.IsNullOrEmpty(formCookieName))
            {
                HttpCookie hc = HttpContext.Current.Request.Cookies[formCookieName];
                if (null != hc)
                {
                    FormsAuthenticationTicket formTicket = FormsAuthentication.Decrypt(hc.Value);
                    if (formTicket != null)
                    {
                        Result = formTicket.UserData.Split('|')[1];
                    }
                }
            }
            return Result;
        }
        #endregion

        #region 获取管理员名
        public static string GetAdminName()
        {
            string Result = string.Empty;
            string formCookieName = FormsAuthentication.FormsCookieName;
            HttpCookie hc = HttpContext.Current.Request.Cookies[formCookieName];
            if (null != hc)
            {
                FormsAuthenticationTicket formTicket = FormsAuthentication.Decrypt(hc.Value);
                if (formTicket != null)
                {
                    Result = formTicket.Name;
                }
            }
            else
            {
                HttpContext.Current.Response.Redirect("http://admin.bang.52wuhan.com/login.aspx");
                return "";
            }

            return Result;
        }
        #endregion

    }
}
