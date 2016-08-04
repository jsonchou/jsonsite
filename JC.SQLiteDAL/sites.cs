using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using JC.IDAL;
using JC.DBUtility;//Please add references
namespace JC.SQLiteDAL
{
	/// <summary>
	/// 数据访问类:sites
	/// </summary>
	public partial class sites:Isite
	{
		public sites()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("id", "sites"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sites");
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
		public int Add(JC.Model.sites model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into sites(");
			strSql.Append("url,logo,icon,lang,langcode,title,keywords,description,titleen,keywordsen,descriptionen,company,freetele,beiancode,sitetrack,mail,mailpwd,mailsmtp,mailport,nopic,picmaxlength,contact,logday,ext1,ext2,ext3,ext4,ext5,ext6,ext7,ext8,ext9,ext10)");
			strSql.Append(" values (");
			strSql.Append("@url,@logo,@icon,@lang,@langcode,@title,@keywords,@description,@titleen,@keywordsen,@descriptionen,@company,@freetele,@beiancode,@sitetrack,@mail,@mailpwd,@mailsmtp,@mailport,@nopic,@picmaxlength,@contact,@logday,@ext1,@ext2,@ext3,@ext4,@ext5,@ext6,@ext7,@ext8,@ext9,@ext10)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@url", DbType.String),
					new SQLiteParameter("@logo", DbType.String),
					new SQLiteParameter("@icon", DbType.String),
					new SQLiteParameter("@lang", DbType.String),
                    new SQLiteParameter("@langcode", DbType.String),
                    new SQLiteParameter("@title", DbType.String),
                    new SQLiteParameter("@keywords", DbType.String),
					new SQLiteParameter("@description", DbType.String),
					new SQLiteParameter("@titleen", DbType.String),
					new SQLiteParameter("@keywordsen", DbType.String),
					new SQLiteParameter("@descriptionen", DbType.String),
                    new SQLiteParameter("@company", DbType.String),
                    new SQLiteParameter("@freetele", DbType.String),
                    new SQLiteParameter("@beiancode", DbType.String),
					new SQLiteParameter("@sitetrack", DbType.String),
                    new SQLiteParameter("@mail", DbType.String),
                    new SQLiteParameter("@mailpwd", DbType.String),
                    new SQLiteParameter("@mailsmtp", DbType.String),
                    new SQLiteParameter("@mailport", DbType.Int32,8),
                    new SQLiteParameter("@nopic", DbType.String),
                    new SQLiteParameter("@picmaxlength", DbType.Int32,8),
                    new SQLiteParameter("@contact", DbType.String),
                    new SQLiteParameter("@logday", DbType.Int32,8),
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
			parameters[0].Value = model.url;
			parameters[1].Value = model.logo;
			parameters[2].Value = model.icon;
            parameters[3].Value = model.lang;
            parameters[4].Value = model.langcode;
            parameters[5].Value = model.title;
			parameters[6].Value = model.keywords;
			parameters[7].Value = model.description;
			parameters[8].Value = model.titleen;
			parameters[9].Value = model.keywordsen;
			parameters[10].Value = model.descriptionen;
            parameters[11].Value = model.company;
            parameters[12].Value = model.freetele;
            parameters[13].Value = model.beiancode;
			parameters[14].Value = model.sitetrack;
            parameters[15].Value = model.mail;
            parameters[16].Value = model.mailpwd;
            parameters[17].Value = model.mailsmtp;
            parameters[18].Value = model.mailport;
            parameters[19].Value = model.nopic;
            parameters[20].Value = model.picmaxlength;
            parameters[21].Value = model.contact;
            parameters[22].Value = model.logday;
            parameters[23].Value = model.ext1;
            parameters[24].Value = model.ext2;
            parameters[25].Value = model.ext3;
            parameters[26].Value = model.ext4;
            parameters[27].Value = model.ext5;
            parameters[28].Value = model.ext6;
            parameters[29].Value = model.ext7;
            parameters[30].Value = model.ext8;
            parameters[31].Value = model.ext9;
            parameters[32].Value = model.ext10;

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
		public bool Update(JC.Model.sites model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update sites set ");
			strSql.Append("url=@url,");
			strSql.Append("logo=@logo,");
			strSql.Append("icon=@icon,");
            strSql.Append("lang=@lang,");
            strSql.Append("langcode=@langcode,");
            strSql.Append("title=@title,");
			strSql.Append("keywords=@keywords,");
			strSql.Append("description=@description,");
			strSql.Append("titleen=@titleen,");
			strSql.Append("keywordsen=@keywordsen,");
			strSql.Append("descriptionen=@descriptionen,");
            strSql.Append("freetele=@freetele,");
            strSql.Append("company=@company,");
            strSql.Append("beiancode=@beiancode,");
			strSql.Append("sitetrack=@sitetrack,");
            strSql.Append("mail=@mail,");
            strSql.Append("mailpwd=@mailpwd,");
            strSql.Append("mailsmtp=@mailsmtp,");
            strSql.Append("mailport=@mailport,");
            strSql.Append("nopic=@nopic,");
            strSql.Append("picmaxlength=@picmaxlength,");
            strSql.Append("contact=@contact,");
            strSql.Append("logday=@logday,");
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
					new SQLiteParameter("@url", DbType.String),
					new SQLiteParameter("@logo", DbType.String),
					new SQLiteParameter("@icon", DbType.String),
					new SQLiteParameter("@lang", DbType.String),
                    new SQLiteParameter("@langcode", DbType.String),
                    new SQLiteParameter("@title", DbType.String),
                    new SQLiteParameter("@keywords", DbType.String),
					new SQLiteParameter("@description", DbType.String),
					new SQLiteParameter("@titleen", DbType.String),
					new SQLiteParameter("@keywordsen", DbType.String),
					new SQLiteParameter("@descriptionen", DbType.String),
                    new SQLiteParameter("@company", DbType.String),
                    new SQLiteParameter("@freetele", DbType.String),
                    new SQLiteParameter("@beiancode", DbType.String),
					new SQLiteParameter("@sitetrack", DbType.String),
                    new SQLiteParameter("@mail", DbType.String),
                    new SQLiteParameter("@mailpwd", DbType.String),
                    new SQLiteParameter("@mailsmtp", DbType.String),
                    new SQLiteParameter("@mailport", DbType.Int32,8),
                    new SQLiteParameter("@nopic", DbType.String),
                    new SQLiteParameter("@picmaxlength", DbType.Int32,8),
                    new SQLiteParameter("@contact", DbType.String),
                    new SQLiteParameter("@logday", DbType.Int32,8),
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
            parameters[0].Value = model.url;
            parameters[1].Value = model.logo;
            parameters[2].Value = model.icon;
            parameters[3].Value = model.lang;
            parameters[4].Value = model.langcode;
            parameters[5].Value = model.title;
            parameters[6].Value = model.keywords;
            parameters[7].Value = model.description;
            parameters[8].Value = model.titleen;
            parameters[9].Value = model.keywordsen;
            parameters[10].Value = model.descriptionen;
            parameters[11].Value = model.company;
            parameters[12].Value = model.freetele;
            parameters[13].Value = model.beiancode;
            parameters[14].Value = model.sitetrack;
            parameters[15].Value = model.mail;
            parameters[16].Value = model.mailpwd;
            parameters[17].Value = model.mailsmtp;
            parameters[18].Value = model.mailport;
            parameters[19].Value = model.nopic;
            parameters[20].Value = model.picmaxlength;
            parameters[21].Value = model.contact;
            parameters[22].Value = model.logday;
            parameters[23].Value = model.ext1;
            parameters[24].Value = model.ext2;
            parameters[25].Value = model.ext3;
            parameters[26].Value = model.ext4;
            parameters[27].Value = model.ext5;
            parameters[28].Value = model.ext6;
            parameters[29].Value = model.ext7;
            parameters[30].Value = model.ext8;
            parameters[31].Value = model.ext9;
            parameters[32].Value = model.ext10;
            parameters[33].Value = model.id;

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
			strSql.Append("delete from sites ");
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
			strSql.Append("delete from sites ");
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
		public JC.Model.sites GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,url,logo,icon,lang,langcode,title,keywords,description,titleen,keywordsen,descriptionen,company,freetele,beiancode,sitetrack,mail,mailpwd,mailsmtp,mailport,nopic,picmaxlength,contact,logday,ext1,ext2,ext3,ext4,ext5,ext6,ext7,ext8,ext9,ext10 from sites ");
			strSql.Append(" where id=@id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@id", DbType.Int32,4)
			};
			parameters[0].Value = id;

			JC.Model.sites model=new JC.Model.sites();
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
		public JC.Model.sites DataRowToModel(DataRow row)
		{
			JC.Model.sites model=new JC.Model.sites();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
				if(row["url"]!=null)
				{
					model.url=row["url"].ToString();
				}
				if(row["logo"]!=null)
				{
					model.logo=row["logo"].ToString();
				}
				if(row["icon"]!=null)
				{
					model.icon=row["icon"].ToString();
				}
                if (row["lang"] != null)
                {
                    model.lang = row["lang"].ToString();
                }
                if (row["langcode"] != null)
                {
                    model.langcode = row["langcode"].ToString();
                }
                if (row["title"]!=null)
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
				if(row["titleen"]!=null)
				{
					model.titleen=row["titleen"].ToString();
				}
				if(row["keywordsen"]!=null)
				{
					model.keywordsen=row["keywordsen"].ToString();
				}
				if(row["descriptionen"]!=null)
				{
					model.descriptionen=row["descriptionen"].ToString();
				}
                if (row["company"] != null)
                {
                    model.company = row["company"].ToString();
                }
                if (row["freetele"] != null)
                {
                    model.freetele = row["freetele"].ToString();
                }
                if (row["beiancode"]!=null)
				{
					model.beiancode=row["beiancode"].ToString();
				}
				if(row["sitetrack"]!=null)
				{
					model.sitetrack=row["sitetrack"].ToString();
				}
                if (row["mail"] != null)
                {
                    model.mail = row["mail"].ToString();
                }
                if (row["mailpwd"] != null)
                {
                    model.mailpwd = row["mailpwd"].ToString();
                }
                if (row["mailsmtp"] != null)
                {
                    model.mailsmtp = row["mailsmtp"].ToString();
                }
                if (row["mailport"] != null && row["mailport"].ToString() != "")
                {
                    model.mailport = int.Parse(row["mailport"].ToString());
                }
                if (row["nopic"] != null)
                {
                    model.nopic = row["nopic"].ToString();
                }
                if (row["picmaxlength"] != null && row["picmaxlength"].ToString() != "")
                {
                    model.picmaxlength = int.Parse(row["picmaxlength"].ToString());
                }
                if (row["contact"]!=null)
				{
					model.contact=row["contact"].ToString();
				}
                if (row["logday"] != null && row["logday"].ToString() != "")
                {
                    model.logday = int.Parse(row["logday"].ToString());
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
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,url,logo,icon,lang,langcode,title,keywords,description,titleen,keywordsen,descriptionen,company,freetele,beiancode,sitetrack,mail,mailpwd,mailsmtp,mailport,nopic,picmaxlength,contact,logday,ext1,ext2,ext3,ext4,ext5,ext6,ext7,ext8,ext9,ext10 ");
			strSql.Append(" from sites ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQLite.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from sites ");
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
            strSql.Append("SELECT * , rowid from sites ");

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
			parameters[0].Value = "sites";
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

