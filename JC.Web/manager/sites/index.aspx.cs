using System;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace JC.Web.manager.sites
{
    public partial class index : App_Code.PageBase
    {
        public List<string> langs = new List<string>();
        public List<string> langcodes = new List<string>();
        public Newtonsoft.Json.Linq.JObject obj = Common.JsonHelper.GetJsonSiteObject();
        public string key = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            key = obj["siteKey"].ToString();
            langs = (List<string>)obj["site"]["language"]["name"].ToObject(typeof(List<string>)); 
            langcodes = (List<string>)obj["site"]["language"]["code"].ToObject(typeof(List<string>));
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            
            //Response.Write(JsonConvert.SerializeObject(Request.Form));
            //Response.Write(JsonConvert.SerializeObject(msite));

            msite.url = Request.Form["url"];
            msite.logo = Request.Form["logo"] ;
            msite.title = Request.Form["title"] ;

            msite.company = Request.Form["company"];
            msite.freetele = Request.Form["freetele"];

            msite.lang = Request.Form["lang"];
            msite.langcode = Request.Form["langcode"];

            if (string.IsNullOrEmpty(msite.lang))
            {
                msite.lang = langs[0];
                msite.langcode = langcodes[0];
            }

            msite.keywords = JC.Common.StringPlus.ToDBC(Request.Form["keywords"]) ;
            msite.description = Request.Form["description"] ;

            msite.titleen = Request.Form["titleen"] ;
            msite.keywordsen = JC.Common.StringPlus.ToDBC(Request.Form["keywordsen"]) ;
            msite.descriptionen = Request.Form["descriptionen"] ;

            msite.mail = Request.Form["mail"];

            //set pwd
            var mailpwd = Request.Form["mailpwd"];
            var mailpwdHide = Request.Form["mailpwdHide"];

            if (mailpwd != mailpwdHide)
            {
                //密码已修改
                msite.mailpwd = JC.Common.DESEncrypt.Encrypt(mailpwd, key);
            }

            if (string.IsNullOrEmpty(Request.Form["mailsmtp"]) && !string.IsNullOrEmpty(Request.Form["mail"]))
            {
                var mysmtp = Request.Form["mail"].Split('@')[1];
                msite.mailsmtp = "smtp." + mysmtp;
            }
            else {
                msite.mailsmtp = Request.Form["mailsmtp"];
            }
            
            msite.mailport = int.Parse(Request.Form["mailport"]);
            msite.picmaxlength = int.Parse(Request.Form["picmaxlength"]);
            msite.nopic = Request.Form["nopic"];
            msite.beiancode = Request.Form["beiancode"] ;
            msite.sitetrack = Request.Form["sitetrack"] ;
            msite.logday = int.Parse(Request.Form["logday"]);
            msite.contact = JC.Common.StringPlus.ToSBC(Request.Form["contact"]) ;

            if (msite != null && msite.id != 0)
            {
                //Response.Write(JsonConvert.SerializeObject(msite));
                bsites.Update(msite);
            }
            else
            {
                bsites.Add(msite);
            }

            txtMsg.Attributes["class"] = "callout callout-info";

        }

        

    }
}