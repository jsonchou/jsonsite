using System;
using System.Collections.Generic;
using System.Web;
using System.Linq;
using System.Text;

using JC.Common;

namespace JC.Web.manager
{
    public partial class login : App_Code.PageBase
    {


        protected void Page_Load(object sender, EventArgs e)
        {

            msite = bsites.GetList()[0];

            if (!IsPostBack)
            {
                var ck = CookieHelper.Get("JCRemberMe");
                if (!string.IsNullOrEmpty(ck))
                {
                    txtName.Value = ck;
                }
            }
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var name = txtName.Value;
            var pwd = txtPwd.Value;
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(pwd))
            {
                //Common.LogHelper.Info(name + ":" + pwd);

                //读取用户帐号
                JC.Model.users my = busers.GetList().Where(c => ((c.email == name || c.username == name) && c.pwd.ToUpper() == DESEncrypt.MD5Encrypt(pwd).ToUpper())).FirstOrDefault();

                if (my != null)
                {
                    if (my.isadmin == 1)
                    {
                        if (ckRember.Checked == true)
                        {
                            CookieHelper.Set("JCRemberMe", my.username ?? my.email);
                        }else
                        {
                            CookieHelper.Del("JCRemberMe");
                        }
                        Session[userKey] = my;
                        CookieHelper.Set(userKey, my.id + "|" + my.username + '|' + my.email + '|' + my.avator + '|' + my.isadmin);

                        //更新登录次数
                        my.logtime += 1;
                        busers.Update(my);

                        var lg = new Model.logs();
                        UserLog("登录", lg);

                        UserLogRemove();

                        Response.Redirect("/manager/index");
                    }
                    else
                    {
                        lblMsg.InnerText = "网站管理员才可以登录后台！";
                    }
                }
                else
                {
                    lblMsg.InnerText = "登录密码错误！";
                }
            }
            else
            {
                lblMsg.InnerText = "邮箱和密码必须填写！";
            }
        }

       
    }
}