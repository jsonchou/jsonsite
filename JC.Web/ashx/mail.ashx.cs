using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JC.Web.ashx
{
    /// <summary>
    /// mail 的摘要说明
    /// </summary>
    public class mail : IHttpHandler
    {
        public Newtonsoft.Json.Linq.JObject obj = JC.Common.JsonHelper.GetJsonSiteObject();
        public static string key = string.Empty;

        public void ProcessRequest(HttpContext context)
        {
            JC.Model.sites msite = new Model.sites();
            JC.Model.posts mpost = new Model.posts();
            JC.BLL.sites bsites = new BLL.sites();
            JC.BLL.posts bposts = new BLL.posts();

            var tbs = "msgs";

            key = obj["siteKey"].ToString();

            context.Response.ContentType = "text/plain";
            var name = context.Request.Form["name"];
            var mobile = context.Request.Form["mobile"];
            var info = context.Request.Form["info"];
            var ua = context.Request.Form["ua"];
            var date = DateTime.Now.ToString();
            var res = "";

            msite = bsites.GetList()[0];

            try
            {
                var mailFrom = msite.mail;
                var mailPwd = JC.Common.DESEncrypt.Decrypt(msite.mailpwd, key);//破解密码
                var smtpServer = msite.mailsmtp;
                var smtpPort = msite.mailport;
                var mailToList = new List<string>();
                var tit = "客户" + name + "，手机" + mobile + "，发过来的咨询邮件--" + msite.title;
                var bod = @"<p>用户名称：<b>" + name + "</b></p>";
                bod += "<p>用户手机：<b>" + mobile + "：</b></p>";
                bod += "<p>UA：<b>" + ua + "：</b></p>";
                bod += @"<hr />";
                bod += @"<p>咨询内容：<b>" + info + "</b></p>";
                bod += @"<p style='text-align:right'>" + date + "</p>";

                JC.Common.Common.MultiSendEmail(smtpServer, smtpPort, mailFrom, mailPwd, mailToList, null, null, tit, bod, null, true);

                //插入数据库
                mpost.postby = name;
                mpost.postdate = DateTime.Now;
                mpost.modifydate = DateTime.Now;
                mpost.content = info;
                mpost.ext1 = mobile;
                mpost.enable = 0;
                mpost.read = 0;
                mpost.ext = tbs;//VIP code

                bposts.Add(mpost);

                res = "{status:\"1\",msg:\"邮件发送成功!\"}";
            }
            catch (Exception)
            {
                res = "{status:\"0\",msg:\"邮件发送失败!\"}";
                throw;
            }
            context.Response.Write(res);

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}



