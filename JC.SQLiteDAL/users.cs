using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using JC.IDAL;
using JC.DBUtility;//Please add references
namespace JC.SQLiteDAL
{
	/// <summary>
	/// 数据访问类:users
	/// </summary>
	public partial class users:Iusers
	{
		public users()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("id", "users"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from users");
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
		public int Add(JC.Model.users model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into users(");
			strSql.Append("username,nickname,email,pwd,avator,postdate,modifydate,isadmin,logtime,ext1,ext2,ext3,ext4,ext5,ext6,ext7,ext8,ext9,ext10)");
			strSql.Append(" values (");
			strSql.Append("@username,@nickname,@email,@pwd,@avator,@postdate,@modifydate,@isadmin,@logtime,@ext1,@ext2,@ext3,@ext4,@ext5,@ext6,@ext7,@ext8,@ext9,@ext10)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@username", DbType.String),
                    new SQLiteParameter("@nickname", DbType.String),
                    new SQLiteParameter("@email", DbType.String),
					new SQLiteParameter("@pwd", DbType.String),
					new SQLiteParameter("@avator", DbType.String),
					new SQLiteParameter("@postdate", DbType.DateTime),
					new SQLiteParameter("@modifydate", DbType.DateTime),
					new SQLiteParameter("@isadmin", DbType.Int32,8),
                    new SQLiteParameter("@logtime", DbType.Int32,8),
                    new SQLiteParameter("@ext1", DbType.String),
					new SQLiteParameter("@ext2", DbType.String),
					new SQLiteParameter("@ext3", DbType.String),
					new SQLiteParameter("@ext4", DbType.String),
					new SQLiteParameter("@ext5", DbType.String),
					new SQLiteParameter("@ext6", DbType.String),
					new SQLiteParameter("@ext7", DbType.String),
					new SQLiteParameter("@ext8", DbType.String),
					new SQLiteParameter("@ext9", DbType.String),
					new SQLiteParameter("@ext10", DbType.String)};
            parameters[0].Value = model.username;
            parameters[1].Value = model.nickname;
            parameters[2].Value = model.email;
            parameters[3].Value = model.pwd;
            parameters[4].Value = model.avator;
            parameters[5].Value = model.postdate;
            parameters[6].Value = model.modifydate;
            parameters[7].Value = model.isadmin;
            parameters[8].Value = model.logtime;
            parameters[9].Value = model.ext1;
            parameters[10].Value = model.ext2;
            parameters[11].Value = model.ext3;
            parameters[12].Value = model.ext4;
            parameters[13].Value = model.ext5;
            parameters[14].Value = model.ext6;
            parameters[15].Value = model.ext7;
            parameters[16].Value = model.ext8;
            parameters[17].Value = model.ext9;
            parameters[18].Value = model.ext10;

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
		public bool Update(JC.Model.users model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update users set ");
			strSql.Append("username=@username,");
            strSql.Append("nickname=@nickname,");
            strSql.Append("email=@email,");
			strSql.Append("pwd=@pwd,");
			strSql.Append("avator=@avator,");
			strSql.Append("postdate=@postdate,");
			strSql.Append("modifydate=@modifydate,");
			strSql.Append("isadmin=@isadmin,");
            strSql.Append("logtime=@logtime,");
            strSql.Append("ext1=@ext1,");
			strSql.Append("ext2=@ext2,");
			strSql.Append("ext3=@ext3,");
			strSql.Append("ext4=@ext4,");
			strSql.Append("ext5=@ext5,");
			strSql.Append("ext6=@ext6,");
			strSql.Append("ext7=@ext7,");
			strSql.Append("ext8=@ext8,");
			strSql.Append("ext9=@ext9,");
			strSql.Append("ext10=@ext10");
			strSql.Append(" where id=@id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@username", DbType.String),
                    new SQLiteParameter("@nickname", DbType.String),
                    new SQLiteParameter("@email", DbType.String),
					new SQLiteParameter("@pwd", DbType.String),
					new SQLiteParameter("@avator", DbType.String),
					new SQLiteParameter("@postdate", DbType.DateTime),
					new SQLiteParameter("@modifydate", DbType.DateTime),
					new SQLiteParameter("@isadmin", DbType.Int32,8),
                    new SQLiteParameter("@logtime", DbType.Int32,8),
                    new SQLiteParameter("@ext1", DbType.String),
					new SQLiteParameter("@ext2", DbType.String),
					new SQLiteParameter("@ext3", DbType.String),
					new SQLiteParameter("@ext4", DbType.String),
					new SQLiteParameter("@ext5", DbType.String),
					new SQLiteParameter("@ext6", DbType.String),
					new SQLiteParameter("@ext7", DbType.String),
					new SQLiteParameter("@ext8", DbType.String),
					new SQLiteParameter("@ext9", DbType.String),
					new SQLiteParameter("@ext10", DbType.String),
					new SQLiteParameter("@id", DbType.Int32,8)};
            parameters[0].Value = model.username;
            parameters[1].Value = model.nickname;
            parameters[2].Value = model.email;
            parameters[3].Value = model.pwd;
            parameters[4].Value = model.avator;
            parameters[5].Value = model.postdate;
            parameters[6].Value = model.modifydate;
            parameters[7].Value = model.isadmin;
            parameters[8].Value = model.logtime;
            parameters[9].Value = model.ext1;
            parameters[10].Value = model.ext2;
            parameters[11].Value = model.ext3;
            parameters[12].Value = model.ext4;
            parameters[13].Value = model.ext5;
            parameters[14].Value = model.ext6;
            parameters[15].Value = model.ext7;
            parameters[16].Value = model.ext8;
            parameters[17].Value = model.ext9;
            parameters[18].Value = model.ext10;
            parameters[19].Value = model.id;

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
			strSql.Append("delete from users ");
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
			strSql.Append("delete from users ");
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
		public JC.Model.users GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,username,nickname,email,pwd,avator,postdate,modifydate,isadmin,logtime,ext1,ext2,ext3,ext4,ext5,ext6,ext7,ext8,ext9,ext10 from users ");
			strSql.Append(" where id=@id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@id", DbType.Int32,4)
			};
			parameters[0].Value = id;

			JC.Model.users model=new JC.Model.users();
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
		public JC.Model.users DataRowToModel(DataRow row)
		{
			JC.Model.users model=new JC.Model.users();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["username"]!=null)
				{
					model.username=row["username"].ToString();
				}
                if (row["nickname"] != null)
                {
                    model.nickname = row["nickname"].ToString();
                }
                if (row["email"]!=null)
				{
					model.email=row["email"].ToString();
				}
				if(row["pwd"]!=null)
				{
					model.pwd=row["pwd"].ToString();
				}
				if(row["avator"]!=null)
				{
					model.avator=row["avator"].ToString();
				}
				if(row["postdate"]!=null && row["postdate"].ToString()!="")
				{
					model.postdate=DateTime.Parse(row["postdate"].ToString());
				}
				if(row["modifydate"]!=null && row["modifydate"].ToString()!="")
				{
					model.modifydate=DateTime.Parse(row["modifydate"].ToString());
				}
				if(row["isadmin"]!=null && row["isadmin"].ToString()!="")
				{
					model.isadmin=int.Parse(row["isadmin"].ToString());
				}
                if (row["logtime"] != null && row["logtime"].ToString() != "")
                {
                    model.logtime = int.Parse(row["logtime"].ToString());
                }
                if (row["ext1"]!=null)
				{
					model.ext1=row["ext1"].ToString();
				}
				if(row["ext2"]!=null)
				{
					model.ext2=row["ext2"].ToString();
				}
				if(row["ext3"]!=null)
				{
					model.ext3=row["ext3"].ToString();
				}
				if(row["ext4"]!=null)
				{
					model.ext4=row["ext4"].ToString();
				}
				if(row["ext5"]!=null)
				{
					model.ext5=row["ext5"].ToString();
				}
				if(row["ext6"]!=null)
				{
					model.ext6=row["ext6"].ToString();
				}
				if(row["ext7"]!=null)
				{
					model.ext7=row["ext7"].ToString();
				}
				if(row["ext8"]!=null)
				{
					model.ext8=row["ext8"].ToString();
				}
				if(row["ext9"]!=null)
				{
					model.ext9=row["ext9"].ToString();
				}
				if(row["ext10"]!=null)
				{
					model.ext10=row["ext10"].ToString();
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
			strSql.Append("select id,username,nickname,email,pwd,avator,postdate,modifydate,isadmin,logtime,ext1,ext2,ext3,ext4,ext5,ext6,ext7,ext8,ext9,ext10 ");
			strSql.Append(" FROM users ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQLite.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere="")
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM users ");
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
            strSql.Append("SELECT * , rowid FROM users ");

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
			parameters[0].Value = "users";
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

