using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JC.Common
{
    public class JsonHelper
    {
        public JsonHelper() {
        
        }

        //将表转化成Json字符串 存在表名
        public static string DataTable2Json(DataTable dt, string dtName)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            using (JsonWriter jw = new JsonTextWriter(sw))
            {
                JsonSerializer ser = new JsonSerializer();
                jw.WriteStartObject();
                jw.WritePropertyName(dtName);
                jw.WriteStartArray();
                foreach (DataRow dr in dt.Rows)
                {
                    jw.WriteStartObject();

                    foreach (DataColumn dc in dt.Columns)
                    {
                        jw.WritePropertyName(dc.ColumnName);
                        ser.Serialize(jw, dr[dc].ToString());
                    }
                    jw.WriteEndObject();
                }
                jw.WriteEndArray();
                jw.WriteEndObject();

                sw.Close();
                jw.Close();
            }
            return sb.ToString();
        }

        //将表转化成Json字符串  
        public static string DataTable2Json(DataTable dt)
        {
            StringBuilder jsonBuilder = new StringBuilder();
            jsonBuilder.Append("{\"");
            jsonBuilder.Append(dt.TableName);
            jsonBuilder.Append("\":[");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                jsonBuilder.Append("{");
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    jsonBuilder.Append("\"");
                    jsonBuilder.Append(dt.Columns[j].ColumnName);
                    jsonBuilder.Append("\":\"");
                    jsonBuilder.Append(dt.Rows[i][j].ToString());
                    jsonBuilder.Append("\",");
                }
                jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
                jsonBuilder.Append("},");
            }
            jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
            jsonBuilder.Append("]");
            jsonBuilder.Append("}");
            return jsonBuilder.ToString();
        }

        public static string DataTable2Json(DataTable dt, bool withTableName)
        {
            StringBuilder jsonBuilder = new StringBuilder();
            if (withTableName)
            {
                jsonBuilder.Append("{\"");
                jsonBuilder.Append(dt.TableName);
                jsonBuilder.Append("\":");
            }
            jsonBuilder.Append("[");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                jsonBuilder.Append("{");
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    jsonBuilder.Append("\"");
                    jsonBuilder.Append(dt.Columns[j].ColumnName);
                    jsonBuilder.Append("\":\"");
                    jsonBuilder.Append(dt.Rows[i][j].ToString());
                    jsonBuilder.Append("\",");
                }
                jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
                jsonBuilder.Append("},");
            }
            jsonBuilder.Remove(jsonBuilder.Length - 1, 1);
            jsonBuilder.Append("]");
            if (withTableName) jsonBuilder.Append("}");
            return jsonBuilder.ToString();
        }

        /// <summary>
        /// 获取/config/site.json配置信息
        /// </summary>
        /// <returns>JObject</returns>
        public static JObject GetJsonSiteObject() {
            var jsonPath = HttpContext.Current.Server.MapPath("~/config/site.json");
            if (!string.IsNullOrEmpty(jsonPath)) {
                JObject obj = new JObject();

                var key = "site.json";
                var cac = DataCache.Get(key);
                if (cac != null)
                {
                    obj = (JObject)cac;
                }
                else
                {
                    StreamReader sr = File.OpenText(jsonPath);
                    StringBuilder sb = new StringBuilder();
                    string input = null;
                    while ((input = sr.ReadLine()) != null)
                    {
                        sb.Append(input);
                    }
                    sr.Close();
                    
                    obj = JObject.Parse(sb.ToString());
                    DataCache.Set(key, obj);
                }
                return obj;
            }
            return null;
        }

    }
}