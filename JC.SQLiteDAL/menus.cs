using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using JC.IDAL;
using JC.DBUtility;//Please add references
namespace JC.SQLiteDAL
{
	/// <summary>
	/// 数据访问类:menus
	/// </summary>
	public partial class menus:Imenus
	{
		public menus()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("id", "menus"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from menus");
			strSql.Append(" where id=@id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@id", DbType.Int32,4)
			};
			parameters[0].Value = id;

			return DbHelperSQLite.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(JC.Model.menus model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into menus(");
			strSql.Append("parentid,linktag,title,keywords,description,content,titleen,keywordsen,contenten,descriptionen,pic,path,stem,haschild,orderby)");
			strSql.Append(" values (");
			strSql.Append("@parentid,@linktag,@title,@keywords,@description,@content,@titleen,@keywordsen,@contenten,@descriptionen,@pic,@path,@stem,@haschild,@orderby)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@parentid", DbType.Int32,8),
					new SQLiteParameter("@linktag", DbType.String),
					new SQLiteParameter("@title", DbType.String),
					new SQLiteParameter("@keywords", DbType.String),
					new SQLiteParameter("@description", DbType.String),
					new SQLiteParameter("@content", DbType.String),
					new SQLiteParameter("@titleen", DbType.String),
					new SQLiteParameter("@keywordsen", DbType.String),
					new SQLiteParameter("@contenten", DbType.String),
					new SQLiteParameter("@descriptionen", DbType.String),
					new SQLiteParameter("@pic", DbType.String),
                    new SQLiteParameter("@path", DbType.String),
                    new SQLiteParameter("@stem", DbType.Int32,8),
                    new SQLiteParameter("@haschild", DbType.Int32,8),
                    new SQLiteParameter("@orderby", DbType.Int32,8)};
			parameters[0].Value = model.parentid;
			parameters[1].Value = model.linktag;
			parameters[2].Value = model.title;
			parameters[3].Value = model.keywords;
			parameters[4].Value = model.description;
			parameters[5].Value = model.content;
			parameters[6].Value = model.titleen;
			parameters[7].Value = model.keywordsen;
			parameters[8].Value = model.contenten;
			parameters[9].Value = model.descriptionen;
			parameters[10].Value = model.pic;
            parameters[11].Value = model.path;
            parameters[12].Value = model.stem;
            parameters[13].Value = model.haschild;
            parameters[14].Value = model.orderby;

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
		public bool Update(JC.Model.menus model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update menus set ");
			strSql.Append("parentid=@parentid,");
			strSql.Append("linktag=@linktag,");
			strSql.Append("title=@title,");
			strSql.Append("keywords=@keywords,");
			strSql.Append("description=@description,");
			strSql.Append("content=@content,");
			strSql.Append("titleen=@titleen,");
			strSql.Append("keywordsen=@keywordsen,");
			strSql.Append("contenten=@contenten,");
			strSql.Append("descriptionen=@descriptionen,");
			strSql.Append("pic=@pic,");
            strSql.Append("path=@path,");
            strSql.Append("stem=@stem,");
            strSql.Append("haschild=@haschild,");
            strSql.Append("orderby=@orderby");
			strSql.Append(" where id=@id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@parentid", DbType.Int32,8),
					new SQLiteParameter("@linktag", DbType.String),
					new SQLiteParameter("@title", DbType.String),
					new SQLiteParameter("@keywords", DbType.String),
					new SQLiteParameter("@description", DbType.String),
					new SQLiteParameter("@content", DbType.String),
					new SQLiteParameter("@titleen", DbType.String),
					new SQLiteParameter("@keywordsen", DbType.String),
					new SQLiteParameter("@contenten", DbType.String),
					new SQLiteParameter("@descriptionen", DbType.String),
					new SQLiteParameter("@pic", DbType.String),
                    new SQLiteParameter("@path", DbType.String),
                    new SQLiteParameter("@stem", DbType.Int32,8),
                    new SQLiteParameter("@haschild", DbType.Int32,8),
                    new SQLiteParameter("@orderby", DbType.Int32,8),
					new SQLiteParameter("@id", DbType.Int32,8)};
			parameters[0].Value = model.parentid;
			parameters[1].Value = model.linktag;
			parameters[2].Value = model.title;
			parameters[3].Value = model.keywords;
			parameters[4].Value = model.description;
			parameters[5].Value = model.content;
			parameters[6].Value = model.titleen;
			parameters[7].Value = model.keywordsen;
			parameters[8].Value = model.contenten;
			parameters[9].Value = model.descriptionen;
			parameters[10].Value = model.pic;
            parameters[11].Value = model.path;
            parameters[12].Value = model.stem;
            parameters[13].Value = model.haschild;
            parameters[14].Value = model.orderby;
			parameters[15].Value = model.id;

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
			strSql.Append("delete from menus ");
			strSql.Append(" where id=@id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@id", DbType.Int32,4)
			};
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
			strSql.Append("delete from menus ");
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
		public JC.Model.menus GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,parentid,linktag,title,keywords,description,content,titleen,keywordsen,contenten,descriptionen,pic,path,stem,haschild,orderby from menus ");
			strSql.Append(" where id=@id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@id", DbType.Int32,4)
			};
			parameters[0].Value = id;

			JC.Model.menus model=new JC.Model.menus();
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
		public JC.Model.menus DataRowToModel(DataRow row)
		{
			JC.Model.menus model=new JC.Model.menus();
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
				if(row["linktag"]!=null)
				{
					model.linktag=row["linktag"].ToString();
				}
				if(row["title"]!=null)
				{
					model.title=row["title"].ToString();
				}
				if(row["keywords"]!=null)
				{
					model.keywords=row["keywords"].ToString();
				}
				if(row["description"]!=null)
				{
					model.description=row["description"].ToString();
				}
				if(row["content"]!=null)
				{
					model.content=row["content"].ToString();
				}
				if(row["titleen"]!=null)
				{
					model.titleen=row["titleen"].ToString();
				}
				if(row["keywordsen"]!=null)
				{
					model.keywordsen=row["keywordsen"].ToString();
				}
				if(row["contenten"]!=null)
				{
					model.contenten=row["contenten"].ToString();
				}
				if(row["descriptionen"]!=null)
				{
					model.descriptionen=row["descriptionen"].ToString();
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
		public DataSet GetList(string strWhere="")
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,parentid,linktag,title,keywords,description,content,titleen,keywordsen,contenten,descriptionen,pic,path,stem,haschild,orderby ");
			strSql.Append(" FROM menus ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			strSql.Append("select count(1) FROM menus ");
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
            strSql.Append("SELECT * , rowid FROM menus ");

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
			parameters[0].Value = "menus";
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

