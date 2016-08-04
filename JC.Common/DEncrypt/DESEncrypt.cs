using System;
using System.Security.Cryptography;
using System.Text;

namespace JC.Common
{
    /// <summary>
    /// DES加密/解密类。
    /// </summary>
    public class DESEncrypt
    {
        public Newtonsoft.Json.Linq.JObject obj = JC.Common.JsonHelper.GetJsonSiteObject();
        public static string key = string.Empty;

        public DESEncrypt()
        {
            key = obj["siteKey"].ToString();
        }

        #region ========加密======== 

        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public static string Encrypt(string Text)
        {
            return Encrypt(Text, key);
        }
        /// <summary> 
        /// 加密数据 
        /// </summary> 
        /// <param name="Text"></param> 
        /// <param name="sKey"></param> 
        /// <returns></returns> 
        public static string Encrypt(string Text, string sKey)
        {
            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
            {
                byte[] inputByteArray = Encoding.UTF8.GetBytes(Text);
                des.Key = ASCIIEncoding.ASCII.GetBytes(MD5Encrypt(sKey).Substring(0, 8));
                des.IV = ASCIIEncoding.ASCII.GetBytes(MD5Encrypt(sKey).Substring(0, 8));
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                using (CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(inputByteArray, 0, inputByteArray.Length);
                    cs.FlushFinalBlock();
                    cs.Close();
                }
                string str = Convert.ToBase64String(ms.ToArray());
                ms.Close();
                return str;
            }


        }

        #endregion

        #region ========解密======== 


        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public static string Decrypt(string Text)
        {
            return Decrypt(Text, key);
        }
        /// <summary> 
        /// 解密数据 
        /// </summary> 
        /// <param name="Text"></param> 
        /// <param name="sKey"></param> 
        /// <returns></returns> 
        public static string Decrypt(string Text, string sKey)
        {
            byte[] inputByteArray = Convert.FromBase64String(Text);
            using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
            {
                des.Key = ASCIIEncoding.ASCII.GetBytes(MD5Encrypt(sKey).Substring(0,8));
                des.IV = ASCIIEncoding.ASCII.GetBytes(MD5Encrypt(sKey).Substring(0, 8));
                System.IO.MemoryStream ms = new System.IO.MemoryStream();
                using (CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(inputByteArray, 0, inputByteArray.Length);
                    cs.FlushFinalBlock();
                    cs.Close();
                }
                string str = Encoding.UTF8.GetString(ms.ToArray());
                ms.Close();
                return str;
            }
        }

        #endregion

        #region ==============================MD5算法==================================
        /// <summary>
        /// 使用MD5算法求Hash散列
        /// </summary>
        /// <param name="text">明文</param>
        /// <returns>散列值</returns>
        public static string MD5Encrypt(string text)
        {
            MD5 hash = MD5.Create();
            byte[] data = hash.ComputeHash(Encoding.UTF8.GetBytes(text));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }

            return sb.ToString();
        }
        #endregion============================================================


        #region =============================SHA1==============================
        /// <summary>
        /// 使用SHA1算法求Hash散列
        /// </summary>
        /// <param name="text">明文</param>
        /// <returns>散列值</returns>
        public static string SHA1Encrypt(string text)
        {
            SHA1 hash = SHA1.Create();
            byte[] data = hash.ComputeHash(Encoding.UTF8.GetBytes(text));
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }

            return sb.ToString();
        }
        #endregion=============================================================


    }
}
