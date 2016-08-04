using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using JC.IDAL;
using JC.DBUtility;//Please add references
namespace JC.SQLiteDAL
{
    /// <summary>
    /// 数据访问类:logs
    /// </summary>
    public partial class logs : Ilogs
    {
        public logs()
        { }
        #region  BasicMethod

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQLite.GetMaxID("id", "logs");
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from logs");
            strSql.Append(" where id=@id");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@id", DbType.Int32,4)
            };
            parameters[0].Value = id;

            return DbHelperSQLite.Exists(strSql.ToString(), parameters);
        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(JC.Model.logs model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into logs(");
            strSql.Append("username,logtype,loginfo,postdate)");
            strSql.Append(" values (");
            strSql.Append("@username,@logtype,@loginfo,@postdate)");
            strSql.Append(";select LAST_INSERT_ROWID()");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@username", DbType.String),
                    new SQLiteParameter("@logtype", DbType.String),
                    new SQLiteParameter("@loginfo", DbType.String),
                    new SQLiteParameter("@postdate", DbType.DateTime)};
            parameters[0].Value = model.username;
            parameters[1].Value = model.logtype;
            parameters[2].Value = model.loginfo;
            parameters[3].Value = model.postdate;

            object obj = DbHelperSQLite.GetSingle(strSql.ToString(), parameters);
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
        public bool Update(JC.Model.logs model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update logs set ");
            strSql.Append("username=@username,");
            strSql.Append("logtype=@logtype,");
            strSql.Append("loginfo=@loginfo,");
            strSql.Append("postdate=@postdate");
            strSql.Append(" where id=@id");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@username", DbType.String),
                    new SQLiteParameter("@logtype", DbType.String),
                    new SQLiteParameter("@loginfo", DbType.String),
                    new SQLiteParameter("@postdate", DbType.DateTime),
                    new SQLiteParameter("@id", DbType.Int32,8)};
            parameters[0].Value = model.username;
            parameters[1].Value = model.logtype;
            parameters[2].Value = model.loginfo;
            parameters[3].Value = model.postdate;
            parameters[4].Value = model.id;

            int rows = DbHelperSQLite.ExecuteSql(strSql.ToString(), parameters);
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

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from logs ");
            strSql.Append(" where id=@id");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@id", DbType.Int32,4)
            };
            parameters[0].Value = id;

            int rows = DbHelperSQLite.ExecuteSql(strSql.ToString(), parameters);
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
        public bool DeleteList(string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from logs ");
            strSql.Append(" where id in (" + idlist + ")  ");
            int rows = DbHelperSQLite.ExecuteSql(strSql.ToString());
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
        public bool DeleteWhere(string strWhere)
        {
            if (string.IsNullOrEmpty(strWhere))
            {
                return false;
            }
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from logs ");
            strSql.Append(" where " + strWhere);
            int rows = DbHelperSQLite.ExecuteSql(strSql.ToString());
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
        public JC.Model.logs GetModel(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,username,logtype,loginfo,postdate from logs ");
            strSql.Append(" where id=@id");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@id", DbType.Int32,4)
            };
            parameters[0].Value = id;

            JC.Model.logs model = new JC.Model.logs();
            DataSet ds = DbHelperSQLite.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
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
        public JC.Model.logs DataRowToModel(DataRow row)
        {
            JC.Model.logs model = new JC.Model.logs();
            if (row != null)
            {
                if (row["id"] != null && row["id"].ToString() != "")
                {
                    model.id = int.Parse(row["id"].ToString());
                }
                if (row["username"] != null)
                {
                    model.username = row["username"].ToString();
                }
                if (row["logtype"] != null)
                {
                    model.logtype = row["logtype"].ToString();
                }
                if (row["loginfo"] != null)
                {
                    model.loginfo = row["loginfo"].ToString();
                }
                if (row["postdate"] != null && row["postdate"].ToString() != "")
                {
                    model.postdate = DateTime.Parse(row["postdate"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,username,logtype,loginfo,postdate ");
            strSql.Append(" FROM logs ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQLite.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM logs ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
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
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int rowCount)
        {
            //select *,rowid from posts where rowid  between 10 and 20 order by rowid desc

            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * , rowid FROM logs ");

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
			parameters[0].Value = "logs";
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

