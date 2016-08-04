using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using JC.IDAL;
using JC.DBUtility;//Please add references

namespace JC.SQLiteDAL
{
	/// <summary>
	/// 数据访问类:modules
	/// </summary>
	public partial class modules:Imodules
	{
		public modules()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("id", "modules"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from modules");
			strSql.Append(" where id=@id ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@id", DbType.Int32,8)			};
			parameters[0].Value = id;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(JC.Model.modules model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into modules(");
			strSql.Append("parentid,title,content,url,blank,pic,path,stem,haschild,orderby)");
			strSql.Append(" values (");
			strSql.Append("@parentid,@title,@content,@url,@blank,@pic,@path,@stem,@haschild,@orderby)");
			strSql.Append(";select LAST_INSERT_ROWID()");//rowid id 居然是保持一致的
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@parentid", DbType.Int32,8),
					new SQLiteParameter("@title", DbType.String),
					new SQLiteParameter("@content", DbType.String),
					new SQLiteParameter("@url", DbType.String),
					new SQLiteParameter("@blank", DbType.Int32,8),
					new SQLiteParameter("@pic", DbType.String),
                    new SQLiteParameter("@path", DbType.String),
                    new SQLiteParameter("@stem", DbType.Int32,8),
                    new SQLiteParameter("@haschild", DbType.Int32,8),
                    new SQLiteParameter("@orderby", DbType.Int32,8)};
			parameters[0].Value = model.parentid;
			parameters[1].Value = model.title;
			parameters[2].Value = model.content;
			parameters[3].Value = model.url;
			parameters[4].Value = model.blank;
			parameters[5].Value = model.pic;
            parameters[6].Value = model.path;
            parameters[7].Value = model.stem;
            parameters[8].Value = model.haschild;
            parameters[9].Value = model.orderby;

			object obj = DbHelperSQLite.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(JC.Model.modules model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update modules set ");
			strSql.Append("parentid=@parentid,");
			strSql.Append("title=@title,");
			strSql.Append("content=@content,");
			strSql.Append("url=@url,");
			strSql.Append("blank=@blank,");
			strSql.Append("pic=@pic,");
            strSql.Append("path=@path,");
            strSql.Append("stem=@stem,");
            strSql.Append("haschild=@haschild,");
            strSql.Append("orderby=@orderby");
			strSql.Append(" where id=@id ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@parentid", DbType.Int32,8),
					new SQLiteParameter("@title", DbType.String),
					new SQLiteParameter("@content", DbType.String),
					new SQLiteParameter("@url", DbType.String),
					new SQLiteParameter("@blank", DbType.Int32,8),
					new SQLiteParameter("@pic", DbType.String),
                    new SQLiteParameter("@path", DbType.String),
                    new SQLiteParameter("@stem", DbType.Int32,8),
                    new SQLiteParameter("@haschild", DbType.Int32,8),
                    new SQLiteParameter("@orderby", DbType.Int32,8),
					new SQLiteParameter("@id", DbType.Int32,8)};
			parameters[0].Value = model.parentid;
			parameters[1].Value = model.title;
			parameters[2].Value = model.content;
			parameters[3].Value = model.url;
			parameters[4].Value = model.blank;
			parameters[5].Value = model.pic;
            parameters[6].Value = model.path;
            parameters[7].Value = model.stem;
            parameters[8].Value = model.haschild;
            parameters[9].Value = model.orderby;
			parameters[10].Value = model.id;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from modules ");
			strSql.Append(" where id=@id ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@id", DbType.Int32,8)			};
			parameters[0].Value = id;

			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from modules ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public JC.Model.modules GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,parentid,title,content,url,blank,pic,path,stem,haschild,orderby from modules ");
			strSql.Append(" where id=@id ");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@id", DbType.Int32,8)			};
			parameters[0].Value = id;

			JC.Model.modules model=new JC.Model.modules();
			DataSet ds=DbHelperSQLite.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public JC.Model.modules DataRowToModel(DataRow row)
		{
			JC.Model.modules model=new JC.Model.modules();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["parentid"]!=null && row["parentid"].ToString()!="")
				{
					model.parentid=int.Parse(row["parentid"].ToString());
				}
				if(row["title"]!=null)
				{
					model.title=row["title"].ToString();
				}
				if(row["content"]!=null)
				{
					model.content=row["content"].ToString();
				}
				if(row["url"]!=null)
				{
					model.url=row["url"].ToString();
				}
				if(row["blank"]!=null && row["blank"].ToString()!="")
				{
					model.blank=int.Parse(row["blank"].ToString());
				}
				if(row["pic"]!=null)
				{
					model.pic=row["pic"].ToString();
				}
                if (row["path"] != null)
                {
                    model.path = row["path"].ToString();
                }
                if (row["stem"] != null && row["stem"].ToString() != "")
                {
                    model.stem = int.Parse(row["stem"].ToString());
                }
                if (row["haschild"] != null && row["haschild"].ToString() != "")
                {
                    model.haschild = int.Parse(row["haschild"].ToString());
                }
                if (row["orderby"]!=null && row["orderby"].ToString()!="")
				{
					model.orderby=int.Parse(row["orderby"].ToString());
				}
			}
			return model;
		}

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere = "")
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,parentid,title,content,url,blank,pic,path,stem,haschild,orderby ");
            strSql.Append(" FROM modules ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by parentid asc,orderby asc,id asc ");
            return DbHelperSQLite.Query(strSql.ToString());
        }

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM modules ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQLite.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}

        /// <summary>
		/// 分页获取数据列表,slqite 有区别
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int rowCount)
        {
            //select *,rowid from posts where rowid  between 10 and 20 order by rowid desc

            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * , rowid FROM modules ");

            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere + " ");
            }
            else
            {
                strSql.Append(" ");
            }

            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append(" order by " + orderby);
            }
            else
            {
                strSql.Append(" order by id desc");
            }

            strSql.AppendFormat(" limit {0} , {1}", startIndex, rowCount);

            return DbHelperSQLite.Query(strSql.ToString());
        }

        /*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@tblName", DbType.VarChar, 255),
					new SQLiteParameter("@fldName", DbType.VarChar, 255),
					new SQLiteParameter("@PageSize", DbType.Int32),
					new SQLiteParameter("@PageIndex", DbType.Int32),
					new SQLiteParameter("@IsReCount", DbType.bit),
					new SQLiteParameter("@OrderType", DbType.bit),
					new SQLiteParameter("@strWhere", DbType.VarChar,1000),
					};
			parameters[0].Value = "modules";
			parameters[1].Value = "id";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQLite.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  BasicMethod
        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

