using System;
using System.Reflection;
using System.Configuration;
using JC.Common;

namespace JC.DALFactory
{
	/// <summary>
    /// Abstract Factory pattern to create the DAL。
    /// 如果在这里创建对象报错，请检查web.config里是否修改了<add key="DAL" value="JC.SQLServerDAL" />。
	/// </summary>
	public sealed class DataAccess 
	{

        private static readonly string AssemblyPath = JC.Common.JsonHelper.GetJsonSiteObject()["DAL"].ToString();

        public DataAccess()
		{ }

        #region CreateObject 

		//不使用缓存
        private static object CreateObjectNoCache(string AssemblyPath,string classNamespace)
		{		
			try
			{
				object objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);	
				return objType;
			}
			catch//(System.Exception ex)
			{
				//string str=ex.Message;// 记录错误日志
				return null;
			}			
			
        }
		//使用缓存
		private static object CreateObject(string AssemblyPath,string classNamespace)
		{			
			object objType = DataCache.Get(classNamespace);
			if (objType == null)
			{
				try
				{
					objType = Assembly.Load(AssemblyPath).CreateInstance(classNamespace);					
					DataCache.Set(classNamespace, objType);// 写入缓存
				}
				catch//(System.Exception ex)
				{
					//string str=ex.Message;// 记录错误日志
				}
			}
			return objType;
		}
        #endregion

        #region 泛型生成
        ///// <summary>
        ///// 创建数据层接口。
        ///// </summary>
        //public static t Create(string ClassName)
        //{

        //    string ClassNamespace = AssemblyPath +"."+ ClassName;
        //    object objType = CreateObject(AssemblyPath, ClassNamespace);
        //    return (t)objType;
        //}
        #endregion

   
		/// <summary>
		/// 创建menus数据层接口。
		/// </summary>
		public static JC.IDAL.Imenus Createmenus()
		{

			string ClassNamespace = AssemblyPath +".menus";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (JC.IDAL.Imenus)objType;
		}


		/// <summary>
		/// 创建modules数据层接口。
		/// </summary>
		public static JC.IDAL.Imodules Createmodules()
		{

			string ClassNamespace = AssemblyPath +".modules";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (JC.IDAL.Imodules)objType;
		}


		/// <summary>
		/// 创建posts数据层接口。
		/// </summary>
		public static JC.IDAL.Iposts Createposts()
		{

			string ClassNamespace = AssemblyPath +".posts";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (JC.IDAL.Iposts)objType;
		}


		/// <summary>
		/// 创建site数据层接口。
		/// </summary>
		public static JC.IDAL.Isite Createsites()
		{

			string ClassNamespace = AssemblyPath +".sites";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (JC.IDAL.Isite)objType;
		}


		/// <summary>
		/// 创建users数据层接口。
		/// </summary>
		public static JC.IDAL.Iusers Createusers()
		{

			string ClassNamespace = AssemblyPath +".users";
			object objType=CreateObject(AssemblyPath,ClassNamespace);
			return (JC.IDAL.Iusers)objType;
		}

        /// <summary>
		/// 创建logs数据层接口。
		/// </summary>
		public static JC.IDAL.Ilogs Createlogs()
        {

            string ClassNamespace = AssemblyPath + ".logs";
            object objType = CreateObject(AssemblyPath, ClassNamespace);
            return (JC.IDAL.Ilogs)objType;
        }

    }
}