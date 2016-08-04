using System;
using Newtonsoft.Json;

namespace JC.Web.manager.sites
{
    public partial class ext : App_Code.PageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {



            msite.ext1 = Request.Form["ext1"] ;
            msite.ext2 = Request.Form["ext2"] ;
            msite.ext3 = Request.Form["ext3"] ;
            msite.ext4 = Request.Form["ext4"] ;
            msite.ext5 = Request.Form["ext5"] ;
            msite.ext6 = Request.Form["ext6"] ;
            msite.ext7 = Request.Form["ext7"] ;
            msite.ext8 = Request.Form["ext8"] ;
            msite.ext9 = Request.Form["ext9"] ;
            msite.ext10 = Request.Form["ext10"] ;


            Model.logs lg = new Model.logs();
            if (msite != null && msite.id != 0)
            {
                bsites.Update(msite);

                lg.loginfo = "表：" + "sites" + ",ID：" + msite.id;
                UserLog("修改", lg);
            }
            else
            {
                var newid = bsites.Add(msite);

                lg.loginfo = "表：" + "sites" + ",ID：" + newid;
                UserLog("增加", lg);
            }

            txtMsg.Attributes["class"] = "callout callout-info";

        }
    }
}