using System;
using System.Configuration;
using Newtonsoft.Json;

namespace JC.DBUtility
{
    
    public class PubConstant
    {

        /// <summary>
        /// 获取连接字符串
        /// </summary>
        public static string ConnectionString
        {           
            get 
            {
                var obj = JC.Common.JsonHelper.GetJsonSiteObject();
                var con = obj["db"]["con"].ToString();
                var encrypt = bool.Parse(obj["db"]["encrypt"].ToString());
                if (encrypt)
                {
                    con = DESEncrypt.Decrypt(con);
                }
                return con; 
            }
        }

        /// <summary>
        /// 得到web.config里配置项的数据库连接字符串。
        /// </summary>
        /// <param name="configName"></param>
        /// <returns></returns>
        public static string GetConnectionString(string configName)
        {
            var obj = JC.Common.JsonHelper.GetJsonSiteObject();
            var con = obj["db"]["con"].ToString();
            var encrypt = bool.Parse(obj["db"]["encrypt"].ToString());
            if (encrypt)
            {
                con = DESEncrypt.Decrypt(con);
            }
            return con;
        }


    }
}
