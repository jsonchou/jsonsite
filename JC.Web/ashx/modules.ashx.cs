using System;
using System.Collections.Generic;
using System.Web;
using System.Text;

using Newtonsoft.Json;

namespace JC.Web.ashx
{
    /// <summary>
    /// menu 的摘要说明
    /// </summary>
    public class modules : IHttpHandler, System.Web.SessionState.IReadOnlySessionState
    {
        public string userKey = "JCUser";
        BLL.modules bmodules = new BLL.modules();
        List<Model.modules> list = new List<Model.modules>();
        public StringBuilder nodeTable = new StringBuilder();
        string str = "";
        public void ProcessRequest(HttpContext context)
        {
             
            context.Response.ContentType = "text/plain";
            if (HttpContext.Current.Session[userKey] != null)
            {
                #region code
                list = bmodules.GetList();
                nodeTable.Append("[");
                MyLoop(0, 0);
                nodeTable.Append("]");
                str = "{\"code\":1,\"data\":" + JsonConvert.SerializeObject(nodeTable.Replace("]},]", "]}]")).Replace("]},]", "]}]") + "}";
                #endregion
            }
            else
            {
                str = "{\"code\":-1,\"msg\":\"权限错误\"}";
            }

            context.Response.Write(str);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        //树形菜单  
        private void MyLoop(int parentid, int level)
        {
             
            try
            {
                var models = list.FindAll(c => c.parentid == parentid);

                if (models.Count > 0)
                {
                    List<string> temp = new List<string>();
                    for (int i = 0; i < models.Count; i++)
                    {
                        var item = models[i];
                        var id = Convert.ToInt32(item.id);

                        nodeTable.Append("{");
                        nodeTable.Append("\"id\":" + id + ",");
                        nodeTable.Append("\"parentid\":" + item.parentid + ",");
                        nodeTable.Append("\"orderby\":" + item.orderby + ",");
                        nodeTable.Append("\"text\":\"" + item.title + "\",");
                        nodeTable.Append("\"target\":" + (item.blank == 1 ? "\"_blank\"" : "\"_parent\"") + ",");
                        nodeTable.Append("\"url\":\"" + (!string.IsNullOrEmpty(item.url) ? item.url : "") + "\",");
                        nodeTable.Append("\"leaf\":" + (level == 0 ? "\"false\"" : "\"true\"") + ",");

                        nodeTable.Append("\"children\":[");


                        MyLoop(id, level + 1);


                        var coma = "";
                        nodeTable.Append("]},");

                        //JC.Common.LogHelper.Info(JsonConvert.SerializeObject(item));

                        nodeTable.Append(coma);


                    }
                }
            }
            catch (Exception ee)
            {
                throw ee;
            }
        }
    }
}