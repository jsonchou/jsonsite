/************************************************************************************
 *      Copyright (C) 2009 zlq.com,All Rights Reserved					
 *      File:																
 *				Common.cs	                                            	
 *      Description:															
 *				 收集通用库											
 *      Author:																
 *				zlq														
 *				onlyone_329@163.com										
 *      Finish DateTime:														
 *				2009年10月3日																										
 ***********************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Globalization;
using System.ComponentModel;
using System.IO;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Drawing;
using System.Web.Caching;
using System.Web.UI.WebControls;
using System.Reflection;

namespace JC.Common
{
    public class Common
    {
        #region 日期处理
        /// <summary>
        /// 获取中文星期[星期日,星期一...]
        /// </summary>
        /// <param name="sDate"></param>
        /// <returns></returns>
        public static string getWeek(DateTime sDate)
        {
            System.Globalization.Calendar myCal = CultureInfo.InvariantCulture.Calendar;


            string rStr = "";
            switch (myCal.GetDayOfWeek(sDate).ToString())
            {
                case "Sunday":
                    rStr = "星期日";
                    break;
                case "Monday":
                    rStr = "星期一";
                    break;
                case "Tuesday":
                    rStr = "星期二";
                    break;
                case "Wednesday":
                    rStr = "星期三";
                    break;
                case "Thursday":
                    rStr = "星期四";
                    break;
                case "Friday":
                    rStr = "星期五";
                    break;
                case "Saturday":
                    rStr = "星期六";
                    break;
            }
            return rStr;
        }
        /// <summary>
        /// 获取用户在线时间(分钟)
        /// </summary>
        /// <param name="strNowDate">现在时间</param>
        /// <param name="strInitDate">登陆时间</param>
        /// <returns></returns>
        public static string getTimeSpan(DateTime NowDate, DateTime InitDate)
        {
            int strHo = NowDate.Hour;
            int strMi = NowDate.Minute;
            int strHo2 = InitDate.Hour;
            int strMi2 = InitDate.Minute;
            int i = (strHo * 60) + strMi;
            int j = (strHo2 * 60) + strMi2;
            return (i - j).ToString() + "分钟";
        }
        #endregion

        #region IP地址
        /// <summary>
        /// 获取用户IP地址
        /// </summary>
        /// <returns></returns>
        public static string GetIPAddress()
        {

            string user_IP = string.Empty;
            if (System.Web.HttpContext.Current.Request.ServerVariables["HTTP_VIA"] != null)
            {
                if (System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null)
                {
                    user_IP = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
                }
                else
                {
                    user_IP = System.Web.HttpContext.Current.Request.UserHostAddress;
                }
            }
            else
            {
                user_IP = System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"].ToString();
            }
            return user_IP;
        }
        /// <summary>
        /// 根据IP获取IP查询Url地址
        /// </summary>
        /// <param name="IP">IP地址</param>
        /// <returns>查询url</returns>
        public static string GetIPLookUrl(string IP)
        {
            string IPLookUrl = "http://www.yahoo.cn/s?p={0}";
            return string.Format("<a href='" + IPLookUrl + "' target='_blank'>{0}</a>", IP);
        }
        /// <summary>
        /// 隐藏IP地址最后一位用*号代替
        /// </summary>
        /// <param name="Ipaddress">IP地址:192.168.34.23</param>
        /// <returns></returns>
        public static string HidenLastIp(string Ipaddress)
        {
            return Ipaddress.Substring(0, Ipaddress.LastIndexOf(".")) + ".*";
        }
        #endregion

        #region 缓存操作
        /// <summary>
        /// 设置页面不被缓存[常常出现在ashx文件头部]
        /// </summary>
        public static void SetPageNoCache()
        {
            HttpContext.Current.Response.Buffer = true;
            HttpContext.Current.Response.ExpiresAbsolute = System.DateTime.Now.AddSeconds(-1);
            HttpContext.Current.Response.Expires = 0;
            HttpContext.Current.Response.CacheControl = "no-cache";
            HttpContext.Current.Response.AddHeader("Pragma", "No-Cache");
        }

        #region Cache操作类
        /// <summary>
        /// 添加缓存
        /// </summary>
        /// <param name="key"></param>
        /// <param name="obj"></param>
        /// <param name="timeOut"></param>
        public static void AddCache<T>(string key, T obj, int timeOut) where T : class
        {
            //if(!CheckCache(key)) 避免二次CheckCache
            HttpRuntime.Cache.Add(key, obj, null, DateTime.Now.AddHours(timeOut), Cache.NoSlidingExpiration, CacheItemPriority.High, null);
        }
        /// <summary>
        /// 检查缓存
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static bool CheckCache(string key)
        {
            return HttpContext.Current.Cache[key] != null;
        }
        /// <summary>
        /// 清空缓存项
        /// </summary>
        /// <param name="key">为null表示清空整个程序所有缓存,可能会引起应用程序重启</param>
        public static void ClearCache(string key)
        {
            if (!string.IsNullOrEmpty(key))
            {
                HttpRuntime.Cache.Remove(key);
            }
        }
        /// <summary>
        /// 获取缓存
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        public static T GetCache<T>(string key) where T : class
        {
            try
            {
                return (T)HttpContext.Current.Cache[key];
            }
            catch
            {
                return null;
            }
        }
        #endregion

        #endregion

        #region 字符串操作
        /// <summary>
        /// 字符串按长度截取
        /// </summary>
        /// <param name="inputString">要截取字符串</param>
        /// <param name="len">字符串截取长度</param>
        /// <param name="bdot">是否添加点点点</param>
        /// <returns></returns>
        public static string CutString(string inputString, int len, bool bdot)
        {
            ASCIIEncoding ascii = new ASCIIEncoding();
            int tempLen = 0;
            string tempString = "";
            byte[] s = ascii.GetBytes(inputString);
            for (int i = 0; i < s.Length; i++)
            {
                if ((int)s[i] == 63)
                {
                    tempLen += 2;
                }
                else
                {
                    tempLen += 1;
                }
                try
                {
                    tempString += inputString.Substring(i, 1);
                }
                catch
                {
                    break;
                }
                if (tempLen > len)
                    break;
            }
            //如果截过则加上半个省略号
            byte[] mybyte = System.Text.Encoding.Default.GetBytes(inputString);
            if (mybyte.Length > len && bdot == false)
                return tempString;
            else if (mybyte.Length > len && bdot == true)
                tempString += "…";
            return tempString;
        }

        /// <summary>
        /// 生成随机数
        /// </summary>
        /// <param name="VcodeNum">要生成随机数几位</param>
        /// <returns></returns>
        public static string RndNum(int VcodeNum)
        {
            string Vchar = "0,1,2,3,4,5,6,7,8,9,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";
            string[] VcArray = Vchar.Split(new Char[] { ',' });
            string VNum = "";
            int temp = -1;
            Random rand = new Random();
            for (int i = 1; i < VcodeNum + 1; i++)
            {
                if (temp != -1)
                {
                    rand = new Random(i * temp * unchecked((int)DateTime.Now.Ticks));
                }
                int t = rand.Next(35);
                if (temp != -1 && temp == t)
                {
                    return RndNum(VcodeNum);
                }
                temp = t;
                VNum += VcArray[t];
            }
            return VNum;
        }
        /// <summary>
        /// 解决URL中文地址[post字符串编码]
        /// </summary>
        /// <param name="strWord">要编码的字符串</param>
        /// <returns></returns>
        public static string URLEncode(string strWord)
        {
            string strChengedWord = string.Empty;
            if (strWord != null)
            {
                strChengedWord = System.Web.HttpContext.Current.Server.UrlEncode(strWord).ToString();
            }
            return strChengedWord;
        }
        /// <summary>
        /// 解决URL中文地址[post字符串解码]
        /// </summary>
        /// <param name="strWord">要解码的字符串</param>
        /// <returns></returns>
        public static string URLDecode(string strWord)
        {
            string strChengedWord = string.Empty;
            if (strWord != null)
            {
                strChengedWord = System.Web.HttpContext.Current.Server.UrlDecode(strWord).ToString();
            }
            return strChengedWord;
        }
        /// <summary>
        /// 转全角的函数(SBC case)
        /// </summary>
        /// <param name="input">任意字符串</param>
        /// <returns>全角字符串</returns>
        ///<remarks>
        ///全角空格为12288，半角空格为32
        ///其他字符半角(33-126)与全角(65281-65374)的对应关系是：均相差65248
        ///</remarks>        
        public static string ToSBC(string input)
        {
            //半角转全角：
            char[] c = input.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 32)
                {
                    c[i] = (char)12288;
                    continue;
                }
                if (c[i] < 127)
                    c[i] = (char)(c[i] + 65248);
            }
            return new string(c);
        }
        /// <summary>
        /// 转半角的函数(DBC case)
        /// </summary>
        /// <param name="input">任意字符串</param>
        /// <returns>半角字符串</returns>
        ///<remarks>
        ///全角空格为12288，半角空格为32
        ///其他字符半角(33-126)与全角(65281-65374)的对应关系是：均相差65248
        ///</remarks>
        public static string ToDBC(string input)
        {
            char[] c = input.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 12288)
                {
                    c[i] = (char)32;
                    continue;
                }
                if (c[i] > 65280 && c[i] < 65375)
                    c[i] = (char)(c[i] - 65248);
            }
            return new string(c);
        }
        /// <summary>
        /// 超强html代码过滤
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        public static string checkString(string html)
        {
            System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex(@"<script[\s\S]+</script *>", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Regex regex2 = new System.Text.RegularExpressions.Regex(@" href *= *[\s\S]*script *:", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Regex regex3 = new System.Text.RegularExpressions.Regex(@" no[\s\S]*=", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Regex regex4 = new System.Text.RegularExpressions.Regex(@"<iframe[\s\S]+</iframe *>", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Regex regex5 = new System.Text.RegularExpressions.Regex(@"<frameset[\s\S]+</frameset *>", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Regex regex6 = new System.Text.RegularExpressions.Regex(@"\<img[^\>]+\>", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Regex regex7 = new System.Text.RegularExpressions.Regex(@"</p>", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Regex regex8 = new System.Text.RegularExpressions.Regex(@"<p>", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            System.Text.RegularExpressions.Regex regex9 = new System.Text.RegularExpressions.Regex(@"<[^>]*>", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
            html = regex1.Replace(html, ""); //过滤<script></script>标记
            html = regex2.Replace(html, ""); //过滤href=javascript: (<A>) 属性
            html = regex3.Replace(html, " _disibledevent="); //过滤其它控件的on...事件
            html = regex4.Replace(html, ""); //过滤iframe
            html = regex5.Replace(html, ""); //过滤frameset
            html = regex6.Replace(html, ""); //过滤frameset
            html = regex7.Replace(html, ""); //过滤frameset
            html = regex8.Replace(html, ""); //过滤frameset
            html = regex9.Replace(html, "");
            html = html.Replace(" ", "");
            html = html.Replace("&nbsp;", "");
            html = html.Replace("&amp;", "");


            return html;
        }
        /// <summary>
        /// sql仿注入--字符过滤
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string NewsFilter(string value)
        {
            if (string.IsNullOrEmpty(value)) return string.Empty;
            value = Regex.Replace(value, @";", string.Empty);
            value = Regex.Replace(value, @"'", string.Empty);
            value = Regex.Replace(value, @"&", string.Empty);
            value = Regex.Replace(value, @"%20", string.Empty);
            value = Regex.Replace(value, @"--", string.Empty);
            value = Regex.Replace(value, @"==", string.Empty);
            value = Regex.Replace(value, @"<", string.Empty);
            value = Regex.Replace(value, @">", string.Empty);
            value = Regex.Replace(value, @"%", string.Empty);
            return value;
        }
        /// <summary>
        /// 获取枚举值的详细文本
        /// </summary>

        /// <returns></returns>
        public static string GetEnumDescription(object e)
        {
            //获取字段信息
            System.Reflection.FieldInfo[] ms = e.GetType().GetFields();
            Type t = e.GetType();
            foreach (System.Reflection.FieldInfo f in ms)
            {
                //判断名称是否相等
                if (f.Name != e.ToString()) continue;
                //反射出自定义属性
                foreach (Attribute attr in f.GetCustomAttributes(true))
                {
                    //类型转换找到一个Description，用Description作为成员名称
                    System.ComponentModel.DescriptionAttribute dscript = attr as System.ComponentModel.DescriptionAttribute;
                    if (dscript != null)
                        return dscript.Description;
                }
            }
            //如果没有检测到合适的注释，则用默认名称
            return e.ToString();
        }
        /// <summary>
        /// 绑定ListItem列表
        /// </summary>
        /// <param name="enumType"></param>
        /// <param name="allAllOption"></param>
        /// <returns></returns>
        public static List<ListItem> GetEnumList(Type enumType, bool allAllOption)
        {
            if (enumType.IsEnum == false)
            {
                return null;
            }
            List<ListItem> list = new List<ListItem>();
            if (allAllOption == true)
            {
                list.Add(new ListItem("--全部--", ""));
            }
            Type typeDescription = typeof(DescriptionAttribute);
            System.Reflection.FieldInfo[] fields = enumType.GetFields();
            string strText = string.Empty;
            string strValue = string.Empty;
            foreach (FieldInfo field in fields)
            {
                if (field.IsSpecialName) continue;
                strValue = field.Name.ToString();
                object[] arr = field.GetCustomAttributes(typeDescription, true);
                if (arr.Length > 0)
                {
                    strText = (arr[0] as DescriptionAttribute).Description;
                }
                else
                {
                    strText = field.Name;
                }
                list.Add(new ListItem(strText, strValue));
            }
            return list;
        }

        #endregion

        #region Style class 操作
        /// <summary>
        /// 当前连接地址包含标识，则显示newstr，否则显示oldstr
        /// </summary>
        /// <param name="para"></param>
        /// <param name="newstr"></param>
        /// <param name="oldstr"></param>
        /// <returns></returns>
        public static string ShowClass(string para, string classname, string oldclassname="")
        {
            string path = System.Web.HttpContext.Current.Request.RawUrl.ToLower();
            if (para.IndexOf(',') > -1)
            {
                foreach (string str in para.Split(','))
                {
                    if (!string.IsNullOrEmpty(para) && path.IndexOf(para.ToLower()) > -1)
                    {
                        return classname;
                    }
                }
            }
            else {
                if (!string.IsNullOrEmpty(para) && path.IndexOf(para.ToLower()) > -1)
                {
                    return classname;
                }
            }
            
            return oldclassname;
        }

        /// <summary>
        /// 当前连接地址绝对包含标识，则显示newstr，否则显示oldclassname
        /// </summary>
        /// <param name="para"></param>
        /// <param name="classname"></param>
        /// <returns></returns>
        public static string ShowClassAbs(string para, string classname, string oldclassname = "")
        {
            string path = System.Web.HttpContext.Current.Request.RawUrl.ToLower();
            if (para.IndexOf(',') > -1)
            {
                foreach (string str in para.Split(','))
                {
                    if (!string.IsNullOrEmpty(str) && path== str.ToLower())
                    {
                        return classname;
                    }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(para) && path== para)
                {
                    return classname;
                }
            }
            return oldclassname;
        }

        #endregion

        #region javascript窗口,跳转
        /// <summary>
        /// 弹出JavaScript小窗口
        /// </summary>
        /// <param name="js">窗口信息</param>
        public static void Alert(System.Web.UI.Page page, string message)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "Bangalert", "alert('" + message + "');", true);
        }


        /// <summary>
        /// 执行页面JS
        /// </summary>
        /// <param name="page"></param>
        /// <param name="jsString"></param>
        public static void ExecuteJS(System.Web.UI.Page page, string jsString)
        {
            page.ClientScript.RegisterStartupScript(page.GetType(), "BangJS", jsString, true);
        }

        /// <summary>
        /// 弹出消息框并且转向到新的URL
        /// </summary>
        /// <param name="message">消息内容</param>
        /// <param name="toURL">连接地址</param>
        public static void AlertAndRedirect(System.Web.UI.Page page, string message, string toURL)
        {
            page.ClientScript.RegisterClientScriptBlock(page.GetType(), "Bangalert_redirect", "alert('" + message + "');widow.location.replace('" + toURL + "');", true);
        }

        /// <summary>
        /// 回到历史页面
        /// </summary>
        /// <param name="value">-1/1</param>
        public static void GoHistory(System.Web.UI.Page page, int value)
        {
            page.ClientScript.RegisterClientScriptBlock(page.GetType(), "Banghistory_go", "history.go('" + value + "')", true);
        }

        /// <summary>
        /// 关闭当前窗口
        /// </summary>
        public static void CloseWindow()
        {
            #region
            string js = @"<Script language='JavaScript'>
                    parent.opener=null;window.close();  
                  </Script>";
            HttpContext.Current.Response.Write(js);
            HttpContext.Current.Response.End();
            #endregion
        }

        /// <summary>
        /// 刷新父窗口
        /// </summary>
        public static void RefreshParent(string url)
        {
            #region
            string js = @"<script>try{top.location=""" + url + @"""}catch(e){location=""" + url + @"""}</script>";
            HttpContext.Current.Response.Write(js);
            #endregion
        }


        /// <summary>
        /// 刷新打开窗口
        /// </summary>
        public static void RefreshOpener()
        {
            #region
            string js = @"<Script language='JavaScript'>
                    opener.location.reload();
                  </Script>";
            HttpContext.Current.Response.Write(js);
            #endregion
        }


        /// <summary>
        /// 打开指定大小的新窗体
        /// </summary>
        /// <param name="url">地址</param>
        /// <param name="width">宽</param>
        /// <param name="heigth">高</param>
        /// <param name="top">头位置</param>
        /// <param name="left">左位置</param>
        public static void OpenWebFormSize(string url, int width, int heigth, int top, int left)
        {
            #region
            string js = @"<Script language='JavaScript'>window.open('" + url + @"','','height=" + heigth + ",width=" + width + ",top=" + top + ",left=" + left + ",location=no,menubar=no,resizable=yes,scrollbars=yes,status=yes,titlebar=no,toolbar=no,directories=no');</Script>";

            HttpContext.Current.Response.Write(js);
            #endregion
        }


        /// <summary>
        /// 转向Url制定的页面
        /// </summary>
        /// <param name="url">连接地址</param>
        public static void JavaScriptLocationHref(string url)
        {
            #region
            string js = @"<Script language='JavaScript'>
                    window.location.replace('{0}');
                  </Script>";
            js = string.Format(js, url);
            HttpContext.Current.Response.Write(js);
            #endregion
        }

        public static void JavaScriptLocationTopHref(string url)
        {
            #region
            string js = @"<Script language='JavaScript'>
                    window.top.location.replace('{0}');
                  </Script>";
            js = string.Format(js, url);
            HttpContext.Current.Response.Write(js);
            #endregion
        }
        /// <summary>
        /// 打开指定大小位置的模式对话框
        /// </summary>
        /// <param name="webFormUrl">连接地址</param>
        /// <param name="width">宽</param>
        /// <param name="height">高</param>
        /// <param name="top">距离上位置</param>
        /// <param name="left">距离左位置</param>
        public static void ShowModalDialogWindow(string webFormUrl, int width, int height, int top, int left)
        {
            #region
            string features = "dialogWidth:" + width.ToString() + "px"
                + ";dialogHeight:" + height.ToString() + "px"
                + ";dialogLeft:" + left.ToString() + "px"
                + ";dialogTop:" + top.ToString() + "px"
                + ";center:yes;help=no;resizable:no;status:no;scroll=yes";
            ShowModalDialogWindow(webFormUrl, features);
            #endregion
        }

        public static void ShowModalDialogWindow(string webFormUrl, string features)
        {
            string js = ShowModalDialogJavascript(webFormUrl, features);
            HttpContext.Current.Response.Write(js);
        }

        public static string ShowModalDialogJavascript(string webFormUrl, string features)
        {
            #region
            string js = @"<script language=javascript>							
							showModalDialog('" + webFormUrl + "','','" + features + "');</script>";
            return js;
            #endregion
        }
        /// <summary>
        /// 弹出窗口[非UpdatePanel版本]
        /// </summary>
        /// <param name="page"></param>
        /// <param name="operation">脚本操作信息</param>
        /// <param name="alertMsg">弹出窗口的信息,无须方法名(Alert),无须Script标记</param>
        /// <param name="addScriptTag"></param>
        public static void PageClientScriptRegister(System.Web.UI.Page page, string operation, string alertMsg)
        {
            #region
            StringBuilder sb = new StringBuilder();
            sb.Append("alert('" + alertMsg + "')");
            page.ClientScript.RegisterClientScriptBlock(page.GetType(), operation, sb.ToString(), true);
            #endregion
        }
        #endregion

        #region 获取服务器相关信息
        /// <summary>
        /// 服务器名称
        /// </summary>
        /// <returns></returns>
        public static string ServerName()
        {
            return System.Web.HttpContext.Current.Server.MachineName;
        }
        /// <summary>
        /// 服务器IP地址
        /// </summary>
        /// <returns></returns>
        public static string ServerIP()
        {
            return System.Web.HttpContext.Current.Request.ServerVariables["LOCAL_ADDR"];
        }
        /// <summary>
        /// 服务器操作系统
        /// </summary>
        /// <returns></returns>
        public static string ServerOS()
        {
            return Environment.OSVersion.ToString();
        }
        /// <summary>
        /// 服务器域名
        /// </summary>
        /// <returns></returns>
        public static string ServerDomainName()
        {
            return System.Web.HttpContext.Current.Request.ServerVariables["SERVER_NAME"];
        }
        /// <summary>
        /// 服务器.net CLR版本
        /// </summary>
        /// <returns></returns>
        public static string DotnetCLRVersion()
        {
            return ".NET CLR " + Environment.Version.ToString();
        }
        /// <summary>
        /// 服务器软件名
        /// </summary>
        /// <returns></returns>
        public static string ServerSoft()
        {
            return System.Web.HttpContext.Current.Request.ServerVariables["SERVER_SOFTWARE"];
        }
        /// <summary>
        /// 服务器CPU类型
        /// </summary>
        public static string CPUType()
        {
            return Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER");
        }
        /// <summary>
        /// CPU个数;
        /// </summary>
        /// <returns></returns>
        public static string CPUSum()
        {
            return Environment.GetEnvironmentVariable("NUMBER_OF_PROCESSORS");
        }
        /// <summary>
        /// 执行文件绝对路径
        /// </summary>
        /// <returns></returns>
        public static string ServerPath()
        {
            return System.Web.HttpContext.Current.Request.ServerVariables["PATH_TRANSLATED"];
        }
        /// <summary>
        /// 服务器地区时区
        /// </summary>
        /// <returns></returns>
        public static string ServerZoneTime()
        {
            return (DateTime.Now - DateTime.UtcNow).TotalHours > 0 ? "+" + (DateTime.Now - DateTime.UtcNow).TotalHours.ToString() : (DateTime.Now - DateTime.UtcNow).TotalHours.ToString();    //服务器时区
        }
        /// <summary>
        /// 脚本超时时间
        /// </summary>
        /// <returns></returns>
        public static string ServerProcessTimeOut()
        {
            return System.Web.HttpContext.Current.Server.ScriptTimeout.ToString() + "毫秒";
        }
        /// <summary>
        /// 开机运行时长
        /// </summary>
        /// <returns></returns>
        public static string ServerStartTime()
        {
            return ((Double)System.Environment.TickCount / 3600000).ToString("N2");   //开机运行时长
        }
        /// <summary>
        /// 进程开始时
        /// </summary>
        /// <returns></returns>
        public static string ProcessStart()
        {
            string temp;
            try
            {
                temp = System.Diagnostics.Process.GetCurrentProcess().StartTime.ToString();
            }
            catch
            {
                temp = "未知";
            }
            return temp;
        }
        /// <summary>
        /// AspNet 内存占用
        /// </summary>
        /// <returns></returns>
        public static string ServerAspNetMemory()
        {
            string temp;
            try
            {
                temp = ((Double)System.Diagnostics.Process.GetCurrentProcess().WorkingSet64 / 1048576).ToString("N2") + "M";
            }
            catch
            {
                temp = "未知";
            }
            return temp;
        }
        /// <summary>
        /// AspNet CPU时间
        /// </summary>
        /// <returns></returns>
        public static string lbAspNetCPUTime()
        {
            string temp;
            try
            {
                temp = ((TimeSpan)System.Diagnostics.Process.GetCurrentProcess().TotalProcessorTime).TotalSeconds.ToString("N0");
            }
            catch
            {
                temp = "未知";
            }
            return temp;
        }
        /// <summary>
        /// Session总数
        /// </summary>
        /// <returns></returns>
        public static string SessionSum()
        {
            return System.Web.HttpContext.Current.Session.Contents.Count.ToString();
        }
        /// <summary>
        /// Application总数
        /// </summary>
        /// <returns></returns>
        public static string ApplicationSum()
        {
            return System.Web.HttpContext.Current.Application.Contents.Count.ToString();
        }
        /// <summary>
        /// 应用程序缓存总数
        /// </summary>
        /// <returns></returns>
        public static string AppCacheCount()
        {
            return System.Web.HttpContext.Current.Cache.Count.ToString();
        }
        /// <summary>
        /// 应用程序占用内存
        /// </summary>
        /// <returns></returns>
        public static string AppMemory()
        {
            string temp;
            try
            {
                temp = ((Double)GC.GetTotalMemory(false) / 1048576).ToString("N2") + "M";
            }
            catch
            {
                temp = "未知";
            }
            return temp;
        }

        /// <summary>
        /// HTTP访问端口
        /// </summary>
        /// <returns></returns>
        public static string ServerHttpPort()
        {
            return System.Web.HttpContext.Current.Request.ServerVariables["HTTPS"];
        }
        /// <summary>
        /// 虚拟服务绝对路径
        /// </summary>
        /// <returns></returns>
        public static string ServerPhysicalPath()
        {
            return System.Web.HttpContext.Current.Request.ServerVariables["APPL_PHYSICAL_PATH"];
        }




        #endregion

        #region 文件操作
        #region 文件删除
        public static void DeleteFile(string strFileURL)
        {
            if (File.Exists(strFileURL))
            {
                File.Delete(strFileURL);
            }
        }
        #endregion

        #region 判断上传文件类型
        /// <summary>
        /// 判断上传文件类型
        /// </summary>
        /// <param name="FileUp"></param>
        /// <returns></returns>
        protected bool IsAllowableFileType(FileUpload FileUp)
        {
            //从web.config读取判断文件类型限制
            string strFileTypeLimit = ConfigurationManager.AppSettings["FileType"].ToString();
            //当前文件扩展名是否包含在这个字符串中
            if (strFileTypeLimit.IndexOf(Path.GetExtension(FileUp.FileName).ToLower()) != -1)
            {
                return true;
            }
            else
                return false;
        }
        #endregion

        #region 判断图片限制
        protected bool IsAllowablePictureType(FileUpload FileUp)
        {
            //从web.config读取判断图片类型限制
            string strFileTypeLimit = ConfigurationManager.AppSettings["PicTureTye"].ToString();
            //当前文件扩展名是否包含在这个字符串中
            if (strFileTypeLimit.IndexOf(Path.GetExtension(FileUp.FileName).ToLower()) != -1)
            {
                return true;
            }
            else
                return false;
        }
        #endregion

        #region 判断文件大小限制
        private bool IsAllowableFileSize(FileUpload FileUp)
        {
            //从web.config读取判断文件大小的限制
            double iFileSizeLimit = Convert.ToInt32(ConfigurationManager.AppSettings["FileSizeLimit"]) * 1024;
            //判断文件是否超出了限制
            if (iFileSizeLimit > FileUp.PostedFile.ContentLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
        #endregion

        #region 文件静态生成
        /// <summary>
        /// 文件静态生成,通过aspx源文件方式
        /// </summary>
        /// <param name="strStaticFileURL">要生成的静态文件路径，包含文件全名</param>
        /// <param name="strResouceFileURL">原动态文件路径</param>
        public static void StaticHtmlGenerate(string strStaticFileURL, string strResouceFileURL)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter(HttpContext.Current.Server.MapPath(strStaticFileURL), false, System.Text.Encoding.GetEncoding("UTF-8"));
            if (sw != null)
            {
                try
                {
                    System.Web.HttpContext.Current.Server.Execute(strResouceFileURL, sw);
                }
                catch (Exception err)
                {
                    throw err;
                }
                finally
                {
                    sw.Flush();
                    sw.Close();
                }
            }
        }
        #endregion

        #region 文件静态生成2
        /// <summary>
        /// 文件静态生成,通过aspx源文件方式
        /// </summary>
        /// <param name="strStaticFileURL">要生成的静态文件路径，包含文件全名</param>
        /// <param name="url">原始动态文件浏览器URL路径</param>
        public static void StaticHtmlGenerate2(string strStaticFileURL, string url)
        {
            try
            {
                System.Net.WebRequest wReq = System.Net.WebRequest.Create(url);
                System.Net.WebResponse wResp = wReq.GetResponse();

                System.IO.Stream respStream = wResp.GetResponseStream();
                System.IO.StreamReader reader = new System.IO.StreamReader(respStream, System.Text.Encoding.GetEncoding("UTF-8"));

                StringBuilder sb = new StringBuilder(reader.ReadToEnd());
                reader.Close();

                //生成cateename文件夹
                string phsicalPath = HttpContext.Current.Server.MapPath(strStaticFileURL);

                if (System.IO.File.Exists(phsicalPath))
                {
                    File.Delete(phsicalPath);
                }

                //HttpContext.Current.Response.Write(phsicalPath + "<br>");

                FileStream rFile = File.Create(phsicalPath);
                StreamWriter writer = new StreamWriter(rFile, Encoding.GetEncoding("UTF-8"));
                writer.Write(sb.ToString());
                writer.Flush();
                writer.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        #endregion

        #region 获取仿问者客户端信息(浏览器,浏览器版本,Spider,客户端OS)

        #endregion

        //#region 获取,设置,删除XML
        ////通过XML获得关于web.config配置文件的信息
        //public static string GetWebconfigAppSettingsValue(string strKey)
        //{
        //    XmlDocument xd = new XmlDocument();
        //    xd.Load(System.Web.HttpContext.Current.Server.MapPath(@"~/web.config"));
        //    XmlNode xn = xd.SelectSingleNode("/configuration/appSettings/add[@key='" + strKey + "']");
        //    return xn.Attributes["value"].Value;
        //}
        ///// <summary>
        ///// 获取指定节点名称的节点对象
        ///// </summary>
        ///// <param name="node">节点对象</param>
        ///// <param name="nodeName">节点名称</param>
        ///// <returns></returns>
        //public static XmlNode GetNode(XmlNode node, string nodeName)
        //{
        //    if (node != null)
        //    {
        //        foreach (XmlNode xn in node)
        //        {
        //            if (xn.Name == nodeName) return xn;
        //            else
        //            {
        //                XmlNode tmp = GetNode(xn, nodeName);
        //                if (tmp != null) return tmp;
        //            }
        //        }
        //    }
        //    return null;
        //}
        ///// <summary>
        ///// 获取指定节点名称的节点对象
        ///// </summary>
        ///// <param name="xDoc">XmlDocument对象</param>
        ///// <param name="Index">节点索引</param>
        ///// <param name="nodeName">节点名称</param>
        //public static XmlNode GetNode(XmlDocument xDoc, int Index, string nodeName)
        //{
        //    XmlNodeList nlst = xDoc.DocumentElement.ChildNodes;
        //    if (nlst.Count <= Index) return null;
        //    if (nlst[Index].Name == nodeName) return (XmlNode)nlst[Index];
        //    foreach (XmlNode xn in nlst[Index])
        //    {
        //        return GetNode(xn, nodeName);
        //    }
        //    return null;
        //}
        ////通过XML索引[index]值,获取配置value值
        //public static string GetAppValue(int index)
        //{
        //    XmlDocument xd = new XmlDocument();
        //    xd.Load(System.Web.HttpContext.Current.Server.MapPath(@"~/xml/config.xml"));
        //    XmlNode xn = Common.GetNode(xd, index, "item");
        //    string strInsteadWord = Common.GetNode(xn, "value").InnerText;
        //    return strInsteadWord;
        //}
        ///// <summary>
        ///// 自己专用的XML格式数据.获取某个节点值
        ///// </summary>
        ///// <param name="xmlUrl"></param>
        ///// <param name="index">节点索引</param>
        ///// <param name="nodeName">哪个节点</param>
        ///// <returns></returns>
        //public static string GetMyXmlValue(string xmlUrl, int index, string nodeName)
        //{
        //    string sResult = string.Empty;
        //    var item = from c in XElement.Load(HttpContext.Current.Server.MapPath(xmlUrl)).Elements("item")
        //               where c.Descendants("index").First().Value == index.ToString()
        //               select c;
        //    return item.Descendants(nodeName).First().Value;
        //}
        //#endregion

        #region 发送邮件
        //Single receiver test.MSDN上最简单的发送邮件

        public static string MultiSendEmail(string smtp, int smtpport, string mailFrom, string password, List<string> mailToList, List<string> mailCopyAddressList, List<string> mailSecretAddressList, string mailSubject, string mailBody, List<string> mailAttachList, bool isHtml)
        {
            string smtpServer = smtp;//指定 smtp 服务器地址
            string pwd = password;
            MailMessage eMail = new MailMessage();
            SmtpClient eClient = new SmtpClient(smtpServer, smtpport);
            eClient.UseDefaultCredentials = false;
            eClient.Credentials = new System.Net.NetworkCredential(mailFrom, pwd);
            eClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            eClient.EnableSsl = false;//服务器不支持安全连接
            eMail.Subject = mailSubject;
            eMail.SubjectEncoding = Encoding.UTF8;
            eMail.Body = mailBody;
            eMail.BodyEncoding = Encoding.UTF8;
            eMail.From = new MailAddress(mailFrom);

            try
            {
                eMail.To.Clear();
                if (mailToList != null && mailToList.Count > 0)
                {
                    foreach (string strTo in mailToList)
                    {
                        if (!string.IsNullOrEmpty(strTo))
                        {
                            eMail.To.Add(strTo);
                        }
                    }
                }
                if (mailCopyAddressList != null && mailCopyAddressList.Count > 0)
                {
                    eMail.CC.Clear();//清空抄送列表
                    foreach (string strCC in mailCopyAddressList)
                    {
                        if (!string.IsNullOrEmpty(strCC))
                        {
                            eMail.CC.Add(strCC);
                        }
                    }
                }
                if (mailSecretAddressList != null && mailSecretAddressList.Count > 0)
                {
                    eMail.Bcc.Clear();//清空密送列表
                    foreach (string strBCC in mailSecretAddressList)
                    {
                        if (!string.IsNullOrEmpty(strBCC))
                        {
                            eMail.Bcc.Add(strBCC);
                        }
                    }
                }
                if (isHtml)
                {
                    eMail.IsBodyHtml = true;
                }
                else
                {
                    eMail.IsBodyHtml = false;
                }
                //清空附件列表
                eMail.Attachments.Clear();
                if (mailAttachList != null && mailAttachList.Count > 0)
                {
                    for (int i = 0; i < mailAttachList.Count; i++)
                    {
                        if (!string.IsNullOrEmpty(mailAttachList[i].ToString()))
                        {
                            eMail.Attachments.Add(new Attachment(mailAttachList[i].ToString()));
                        }
                    }
                }
                eClient.Send(eMail);
                return "邮件已发送,请查收!";
            }
            catch (Exception ex)
            {
                return "邮件发送失败,原因:" + ex.Message.ToString();
            }
        }

        #endregion

        #region 其它设置
        /// <summary>
        /// 生成缩略图
        /// </summary>
        /// <param name="originalImagePath">源图路径（物理路径）</param>
        /// <param name="thumbnailPath">缩略图路径（物理路径）</param>
        /// <param name="width">缩略图宽度</param>
        /// <param name="height">缩略图高度</param>
        /// <param name="mode">生成缩略图的方式</param>    
        public static void MakeThumbnail(string originalImagePath, string thumbnailPath, int width, int height, string mode)
        {
            System.Drawing.Image originalImage = System.Drawing.Image.FromFile(originalImagePath);

            int towidth = width;
            int toheight = height;

            int x = 0;
            int y = 0;
            int ow = originalImage.Width;
            int oh = originalImage.Height;

            switch (mode)
            {
                case "HW"://指定高宽缩放（可能变形）                
                    break;
                case "W"://指定宽，高按比例
                    if (ow > towidth)
                    {
                        toheight = originalImage.Height * width / originalImage.Width;
                    }
                    else
                    {
                        towidth = ow;
                        toheight = oh;
                    }
                    break;
                case "H"://指定高，宽按比例
                    towidth = originalImage.Width * height / originalImage.Height;
                    break;
                case "Cut"://指定高宽裁减（不变形）                
                    if ((double)originalImage.Width / (double)originalImage.Height > (double)towidth / (double)toheight)
                    {
                        oh = originalImage.Height;
                        ow = originalImage.Height * towidth / toheight;
                        y = 0;
                        x = (originalImage.Width - ow) / 2;
                    }
                    else
                    {
                        ow = originalImage.Width;
                        oh = originalImage.Width * height / towidth;
                        x = 0;
                        y = (originalImage.Height - oh) / 2;
                    }
                    break;
                default:
                    break;
            }

            //新建一个bmp图片
            System.Drawing.Image bitmap = new System.Drawing.Bitmap(towidth, toheight);

            //新建一个画板
            Graphics g = System.Drawing.Graphics.FromImage(bitmap);

            //设置高质量插值法
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;

            //设置高质量,低速度呈现平滑程度
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            //清空画布并以透明背景色填充
            g.Clear(Color.Transparent);

            //在指定位置并且按指定大小绘制原图片的指定部分
            g.DrawImage(originalImage, new Rectangle(0, 0, towidth, toheight), new Rectangle(x, y, ow, oh), GraphicsUnit.Pixel);

            try
            {
                //以jpg格式保存缩略图
                bitmap.Save(thumbnailPath, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (System.Exception e)
            {
                throw e;
            }
            finally
            {
                originalImage.Dispose();
                bitmap.Dispose();
                g.Dispose();
            }
        }

        /// <summary>
        /// 生成图片水印
        /// </summary>
        /// <param name="originalImagePath">原始图片位置包含图片名称</param>
        /// <param name="waterpicPath">水印图片位置</param>
        /// <param name="newPath">加水印位置后路径，以"/"结尾</param>
        public static void WaterPicPrint(string originalImagePath, string waterpicPath, string newPath)
        {
            //加图片水印
            System.Drawing.Image image = System.Drawing.Image.FromFile(originalImagePath);
            System.Drawing.Image waterImage = System.Drawing.Image.FromFile(waterpicPath);

            using (System.Drawing.Graphics graphic = System.Drawing.Graphics.FromImage(image))
            {
                if (image.Width >= 250 && image.Height >= 250)
                {
                    graphic.DrawImage(waterImage, new System.Drawing.Rectangle(image.Width - waterImage.Width - 20, image.Height - waterImage.Height - 20, waterImage.Width, waterImage.Height), 0, 0, waterImage.Width, waterImage.Height, System.Drawing.GraphicsUnit.Pixel);
                    graphic.Dispose();

                    if (File.Exists(newPath))
                    {
                        File.Delete(newPath);//删除原始图片，用水印图片替换
                    }
                }
                image.Save(newPath);
                image.Dispose();
            }
        }


        /// <summary>
        /// 生成文字水印
        /// </summary>
        /// <param name="originalImagePath">原始图片位置包含图片名称</param>
        /// <param name="text">水印文字</param>
        /// <param name="newPath">加水印位置后路径，以"/"结尾</param>
        public static void WaterTextPrint(string originalImagePath, string text, string newPath)
        {
            //上传文件

            //加文字水印，注意，这里的代码和以下加图片水印的代码不能共存
            System.Drawing.Image image = System.Drawing.Image.FromFile(originalImagePath);
            Graphics g = Graphics.FromImage(image);
            g.DrawImage(image, 0, 0, image.Width, image.Height);
            Font f = new Font("Verdana", 32);
            Brush b = new SolidBrush(Color.White);
            g.DrawString(text, f, b, 10, 10);
            g.Dispose();

            //保存加水印过后的图片,删除原始图片
            image.Save(newPath);
            image.Dispose();

            if (File.Exists(originalImagePath))
            {
                File.Delete(originalImagePath);
            }
        }

        #endregion

    }
}