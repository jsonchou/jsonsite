using System;

namespace JC.Web.manager.users
{
    public partial class edit : App_Code.PageBase
    {
        public Model.users user = new Model.users();

        protected void Page_Load(object sender, EventArgs e)
        {
            var isadmin = Request.QueryString["isadmin"];
            var id = Request.QueryString["id"];
            if (!string.IsNullOrEmpty(id))
            {
                user = busers.Get(int.Parse(id));
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            //Response.Write(JsonConvert.SerializeObject(Request.Form));
            //Response.Write(JsonConvert.SerializeObject(musers));

            user.username = Request.Form["username"] ;
            user.nickname = Request.Form["nickname"];
            user.email = Request.Form["email"] ;
            user.avator = Request.Form["avator"] ;

            user.isadmin = int.Parse(Request.Form["isadminHid"]);

            //set pwd
            var pwd = Request.Form["pwd"];
            var pwdHide = Request.Form["pwdHide"];

            if (pwd != pwdHide)
            {
                //密码已修改
                user.pwd = JC.Common.DESEncrypt.MD5Encrypt(pwd).ToUpper();
            }

            user.ext1 = Request.Form["ext1"] ;
            user.ext2 = Request.Form["ext2"] ;
            user.ext3 = Request.Form["ext3"] ;
            user.ext4 = Request.Form["ext4"] ;
            user.ext5 = Request.Form["ext5"] ;
            user.ext6 = Request.Form["ext6"] ;
            user.ext7 = Request.Form["ext7"] ;
            user.ext8 = Request.Form["ext8"] ;
            user.ext9 = Request.Form["ext9"] ;
            user.ext10 = Request.Form["ext10"] ;

            Model.logs lg = new Model.logs();
            if (user != null && user.id != 0)
            {

                user.modifydate = DateTime.Now;
                busers.Update(user);

                var ck = Session[userKey];

                if (ck != null)
                {
                    var my = (Model.users)ck;

                    if (my.id == user.id)
                    {
                        //修改当前用户的密码
                        JC.Common.CookieHelper.Del("JCUser");
                        Session.Remove("JCUser");
                        Session.Abandon();
                        Response.Redirect("/manager/login");
                    }
                }

                lg.loginfo = "表：" + "sites" + ",ID：" + msite.id;
                UserLog("修改", lg);

            }
            else
            {
                user.postdate = DateTime.Now;
                user.modifydate = DateTime.Now;
                int newid = busers.Add(user);

                lg.loginfo = "表：" + "sites" + ",ID：" + newid;
                UserLog("增加", lg);
            }

            txtMsg.Style["display"] = "block";

            txtMsg.Attributes["class"] = "callout callout-info";

        }
    }
}