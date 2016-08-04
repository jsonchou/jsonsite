using System;
using System.Data;
using System.Text;
using System.Data.SQLite;
using JC.IDAL;
using JC.DBUtility;//Please add references
namespace JC.SQLiteDAL
{
	/// <summary>
	/// 数据访问类:posts
	/// </summary>
	public partial class posts:Iposts
	{
		public posts()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("id", "posts"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from posts");
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
		public int Add(JC.Model.posts model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into posts(");
			strSql.Append("typeid,title,keywords,description,content,titleen,keywordsen,descriptionen,contenten,pic,piclist,hit,postby,enable,postdate,modifydate,top,hot,intro,read,blank,orderby,tag,ext,ext1,ext2,ext3,ext4,ext5,ext6,ext7,ext8,ext9,ext10,ext11,ext12,ext13,ext14,ext15,ext16,ext17,ext18,ext19,ext20,ext21,ext22,ext23,ext24,ext25,ext26,ext27,ext28,ext29,ext30)");
			strSql.Append(" values (");
			strSql.Append("@typeid,@title,@keywords,@description,@content,@titleen,@keywordsen,@descriptionen,@contenten,@pic,@piclist,@hit,@postby,@enable,@postdate,@modifydate,@top,@hot,@intro,@read,@blank,@orderby,@tag,@ext,@ext1,@ext2,@ext3,@ext4,@ext5,@ext6,@ext7,@ext8,@ext9,@ext10,@ext11,@ext12,@ext13,@ext14,@ext15,@ext16,@ext17,@ext18,@ext19,@ext20,@ext21,@ext22,@ext23,@ext24,@ext25,@ext26,@ext27,@ext28,@ext29,@ext30)");
			strSql.Append(";select LAST_INSERT_ROWID()");
			SQLiteParameter[] parameters = {
                    new SQLiteParameter("@typeid", DbType.Int32,8),
                    new SQLiteParameter("@title", DbType.String),
					new SQLiteParameter("@keywords", DbType.String),
					new SQLiteParameter("@description", DbType.String),
					new SQLiteParameter("@content", DbType.String),
					new SQLiteParameter("@titleen", DbType.String),
					new SQLiteParameter("@keywordsen", DbType.String),
					new SQLiteParameter("@descriptionen", DbType.String),
					new SQLiteParameter("@contenten", DbType.String),
					new SQLiteParameter("@pic", DbType.String),
                    new SQLiteParameter("@piclist", DbType.String),
                    new SQLiteParameter("@hit", DbType.Int32,8),
					new SQLiteParameter("@postby", DbType.String),
					new SQLiteParameter("@enable", DbType.Int32,8),
                    new SQLiteParameter("@postdate", DbType.DateTime),
					new SQLiteParameter("@modifydate", DbType.DateTime),
					new SQLiteParameter("@top", DbType.Int32,8),
					new SQLiteParameter("@hot", DbType.Int32,8),
					new SQLiteParameter("@intro", DbType.Int32,8),
                    new SQLiteParameter("@read", DbType.Int32,8),
                    new SQLiteParameter("@blank", DbType.Int32,8),
                    new SQLiteParameter("@orderby", DbType.Int32,8),
                    new SQLiteParameter("@tag", DbType.String),
                    new SQLiteParameter("@ext", DbType.String),
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
					new SQLiteParameter("@ext11", DbType.String),
					new SQLiteParameter("@ext12", DbType.String),
					new SQLiteParameter("@ext13", DbType.String),
					new SQLiteParameter("@ext14", DbType.String),
					new SQLiteParameter("@ext15", DbType.String),
					new SQLiteParameter("@ext16", DbType.String),
					new SQLiteParameter("@ext17", DbType.String),
					new SQLiteParameter("@ext18", DbType.String),
					new SQLiteParameter("@ext19", DbType.String),
					new SQLiteParameter("@ext20", DbType.String),
					new SQLiteParameter("@ext21", DbType.String),
					new SQLiteParameter("@ext22", DbType.String),
					new SQLiteParameter("@ext23", DbType.String),
					new SQLiteParameter("@ext24", DbType.String),
					new SQLiteParameter("@ext25", DbType.String),
					new SQLiteParameter("@ext26", DbType.String),
					new SQLiteParameter("@ext27", DbType.String),
					new SQLiteParameter("@ext28", DbType.String),
					new SQLiteParameter("@ext29", DbType.String),
					new SQLiteParameter("@ext30", DbType.String)};
            parameters[0].Value = model.typeid;
            parameters[1].Value = model.title;
			parameters[2].Value = model.keywords;
			parameters[3].Value = model.description;
			parameters[4].Value = model.content;
			parameters[5].Value = model.titleen;
			parameters[6].Value = model.keywordsen;
			parameters[7].Value = model.descriptionen;
			parameters[8].Value = model.contenten;
			parameters[9].Value = model.pic;
            parameters[10].Value = model.piclist;
            parameters[11].Value = model.hit;
			parameters[12].Value = model.postby;
			parameters[13].Value = model.enable;
			parameters[14].Value = model.postdate;
			parameters[15].Value = model.modifydate;
			parameters[16].Value = model.top;
			parameters[17].Value = model.hot;
			parameters[18].Value = model.intro;
            parameters[19].Value = model.read;
            parameters[20].Value = model.blank;
            parameters[21].Value = model.orderby;
            parameters[22].Value = model.tag;
            parameters[23].Value = model.ext;
            parameters[24].Value = model.ext1;
			parameters[25].Value = model.ext2;
			parameters[26].Value = model.ext3;
			parameters[27].Value = model.ext4;
			parameters[28].Value = model.ext5;
			parameters[29].Value = model.ext6;
			parameters[30].Value = model.ext7;
			parameters[31].Value = model.ext8;
			parameters[32].Value = model.ext9;
			parameters[33].Value = model.ext10;
			parameters[34].Value = model.ext11;
			parameters[35].Value = model.ext12;
			parameters[36].Value = model.ext13;
			parameters[37].Value = model.ext14;
			parameters[38].Value = model.ext15;
			parameters[39].Value = model.ext16;
			parameters[40].Value = model.ext17;
			parameters[41].Value = model.ext18;
			parameters[42].Value = model.ext19;
			parameters[43].Value = model.ext20;
			parameters[44].Value = model.ext21;
			parameters[45].Value = model.ext22;
			parameters[46].Value = model.ext23;
			parameters[47].Value = model.ext24;
			parameters[48].Value = model.ext25;
			parameters[49].Value = model.ext26;
			parameters[50].Value = model.ext27;
			parameters[51].Value = model.ext28;
			parameters[52].Value = model.ext29;
			parameters[53].Value = model.ext30;

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
		public bool Update(JC.Model.posts model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update posts set ");
            strSql.Append("typeid=@typeid,");
            strSql.Append("title=@title,");
			strSql.Append("keywords=@keywords,");
			strSql.Append("description=@description,");
			strSql.Append("content=@content,");
			strSql.Append("titleen=@titleen,");
			strSql.Append("keywordsen=@keywordsen,");
			strSql.Append("descriptionen=@descriptionen,");
			strSql.Append("contenten=@contenten,");
			strSql.Append("pic=@pic,");
            strSql.Append("piclist=@piclist,");
            strSql.Append("hit=@hit,");
			strSql.Append("postby=@postby,");
			strSql.Append("enable=@enable,");
			strSql.Append("postdate=@postdate,");
			strSql.Append("modifydate=@modifydate,");
			strSql.Append("top=@top,");
			strSql.Append("hot=@hot,");
			strSql.Append("intro=@intro,");
            strSql.Append("read=@read,");
            strSql.Append("blank=@blank,");
            strSql.Append("orderby=@orderby,");
            strSql.Append("tag=@tag,");
            strSql.Append("ext=@ext,");
            strSql.Append("ext1=@ext1,");
			strSql.Append("ext2=@ext2,");
			strSql.Append("ext3=@ext3,");
			strSql.Append("ext4=@ext4,");
			strSql.Append("ext5=@ext5,");
			strSql.Append("ext6=@ext6,");
			strSql.Append("ext7=@ext7,");
			strSql.Append("ext8=@ext8,");
			strSql.Append("ext9=@ext9,");
			strSql.Append("ext10=@ext10,");
			strSql.Append("ext11=@ext11,");
			strSql.Append("ext12=@ext12,");
			strSql.Append("ext13=@ext13,");
			strSql.Append("ext14=@ext14,");
			strSql.Append("ext15=@ext15,");
			strSql.Append("ext16=@ext16,");
			strSql.Append("ext17=@ext17,");
			strSql.Append("ext18=@ext18,");
			strSql.Append("ext19=@ext19,");
			strSql.Append("ext20=@ext20,");
			strSql.Append("ext21=@ext21,");
			strSql.Append("ext22=@ext22,");
			strSql.Append("ext23=@ext23,");
			strSql.Append("ext24=@ext24,");
			strSql.Append("ext25=@ext25,");
			strSql.Append("ext26=@ext26,");
			strSql.Append("ext27=@ext27,");
			strSql.Append("ext28=@ext28,");
			strSql.Append("ext29=@ext29,");
			strSql.Append("ext30=@ext30");
			strSql.Append(" where id=@id");
			SQLiteParameter[] parameters = {
                    new SQLiteParameter("@typeid", DbType.Int32,8),
                    new SQLiteParameter("@title", DbType.String),
					new SQLiteParameter("@keywords", DbType.String),
					new SQLiteParameter("@description", DbType.String),
					new SQLiteParameter("@content", DbType.String),
					new SQLiteParameter("@titleen", DbType.String),
					new SQLiteParameter("@keywordsen", DbType.String),
					new SQLiteParameter("@descriptionen", DbType.String),
					new SQLiteParameter("@contenten", DbType.String),
					new SQLiteParameter("@pic", DbType.String),
                    new SQLiteParameter("@piclist", DbType.String),
                    new SQLiteParameter("@hit", DbType.Int32,8),
					new SQLiteParameter("@postby", DbType.String),
					new SQLiteParameter("@enable", DbType.Int32,8),
                    new SQLiteParameter("@postdate", DbType.DateTime),
					new SQLiteParameter("@modifydate", DbType.DateTime),
					new SQLiteParameter("@top", DbType.Int32,8),
					new SQLiteParameter("@hot", DbType.Int32,8),
					new SQLiteParameter("@intro", DbType.Int32,8),
                    new SQLiteParameter("@read", DbType.Int32,8),
                    new SQLiteParameter("@blank", DbType.Int32,8),
                    new SQLiteParameter("@orderby", DbType.Int32,8),
                    new SQLiteParameter("@tag", DbType.String),
                    new SQLiteParameter("@ext", DbType.String),
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
					new SQLiteParameter("@ext11", DbType.String),
					new SQLiteParameter("@ext12", DbType.String),
					new SQLiteParameter("@ext13", DbType.String),
					new SQLiteParameter("@ext14", DbType.String),
					new SQLiteParameter("@ext15", DbType.String),
					new SQLiteParameter("@ext16", DbType.String),
					new SQLiteParameter("@ext17", DbType.String),
					new SQLiteParameter("@ext18", DbType.String),
					new SQLiteParameter("@ext19", DbType.String),
					new SQLiteParameter("@ext20", DbType.String),
					new SQLiteParameter("@ext21", DbType.String),
					new SQLiteParameter("@ext22", DbType.String),
					new SQLiteParameter("@ext23", DbType.String),
					new SQLiteParameter("@ext24", DbType.String),
					new SQLiteParameter("@ext25", DbType.String),
					new SQLiteParameter("@ext26", DbType.String),
					new SQLiteParameter("@ext27", DbType.String),
					new SQLiteParameter("@ext28", DbType.String),
					new SQLiteParameter("@ext29", DbType.String),
					new SQLiteParameter("@ext30", DbType.String),
					new SQLiteParameter("@id", DbType.Int32,8)};
            parameters[0].Value = model.typeid;
            parameters[1].Value = model.title;
            parameters[2].Value = model.keywords;
            parameters[3].Value = model.description;
            parameters[4].Value = model.content;
            parameters[5].Value = model.titleen;
            parameters[6].Value = model.keywordsen;
            parameters[7].Value = model.descriptionen;
            parameters[8].Value = model.contenten;
            parameters[9].Value = model.pic;
            parameters[10].Value = model.piclist;
            parameters[11].Value = model.hit;
            parameters[12].Value = model.postby;
            parameters[13].Value = model.enable;
            parameters[14].Value = model.postdate;
            parameters[15].Value = model.modifydate;
            parameters[16].Value = model.top;
            parameters[17].Value = model.hot;
            parameters[18].Value = model.intro;
            parameters[19].Value = model.read;
            parameters[20].Value = model.blank;
            parameters[21].Value = model.orderby;
            parameters[22].Value = model.tag;
            parameters[23].Value = model.ext;
            parameters[24].Value = model.ext1;
            parameters[25].Value = model.ext2;
            parameters[26].Value = model.ext3;
            parameters[27].Value = model.ext4;
            parameters[28].Value = model.ext5;
            parameters[29].Value = model.ext6;
            parameters[30].Value = model.ext7;
            parameters[31].Value = model.ext8;
            parameters[32].Value = model.ext9;
            parameters[33].Value = model.ext10;
            parameters[34].Value = model.ext11;
            parameters[35].Value = model.ext12;
            parameters[36].Value = model.ext13;
            parameters[37].Value = model.ext14;
            parameters[38].Value = model.ext15;
            parameters[39].Value = model.ext16;
            parameters[40].Value = model.ext17;
            parameters[41].Value = model.ext18;
            parameters[42].Value = model.ext19;
            parameters[43].Value = model.ext20;
            parameters[44].Value = model.ext21;
            parameters[45].Value = model.ext22;
            parameters[46].Value = model.ext23;
            parameters[47].Value = model.ext24;
            parameters[48].Value = model.ext25;
            parameters[49].Value = model.ext26;
            parameters[50].Value = model.ext27;
            parameters[51].Value = model.ext28;
            parameters[52].Value = model.ext29;
            parameters[53].Value = model.ext30;
            parameters[54].Value = model.id;

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
			strSql.Append("delete from posts ");
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
			strSql.Append("delete from posts ");
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
		public JC.Model.posts GetModel(int id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,typeid,title,keywords,description,content,titleen,keywordsen,descriptionen,contenten,pic,piclist,hit,postby,enable,postdate,modifydate,top,hot,intro,read,blank,orderby,tag,ext,ext1,ext2,ext3,ext4,ext5,ext6,ext7,ext8,ext9,ext10,ext11,ext12,ext13,ext14,ext15,ext16,ext17,ext18,ext19,ext20,ext21,ext22,ext23,ext24,ext25,ext26,ext27,ext28,ext29,ext30 from posts ");
			strSql.Append(" where id=@id");
			SQLiteParameter[] parameters = {
					new SQLiteParameter("@id", DbType.Int32,4)
			};
			parameters[0].Value = id;

			JC.Model.posts model=new JC.Model.posts();
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
		public JC.Model.posts DataRowToModel(DataRow row)
		{
			JC.Model.posts model=new JC.Model.posts();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=int.Parse(row["id"].ToString());
				}
                if (row["typeid"] != null && row["typeid"].ToString() != "")
                {
                    model.typeid = int.Parse(row["typeid"].ToString());
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
				if(row["descriptionen"]!=null)
				{
					model.descriptionen=row["descriptionen"].ToString();
				}
				if(row["contenten"]!=null)
				{
					model.contenten=row["contenten"].ToString();
				}
				if(row["pic"]!=null)
				{
					model.pic=row["pic"].ToString();
				}
                if (row["piclist"] != null)
                {
                    model.piclist = row["piclist"].ToString();
                }
                if (row["hit"]!=null && row["hit"].ToString()!="")
				{
					model.hit=int.Parse(row["hit"].ToString());
				}
				if(row["postby"]!=null)
				{
					model.postby=row["postby"].ToString();
				}
                if (row["enable"] != null && row["enable"].ToString() != "")
                {
                    model.enable = int.Parse(row["enable"].ToString());
                }
                if (row["postdate"]!=null && row["postdate"].ToString()!="")
				{
					model.postdate=DateTime.Parse(row["postdate"].ToString());
				}
				if(row["modifydate"]!=null && row["modifydate"].ToString()!="")
				{
					model.modifydate=DateTime.Parse(row["modifydate"].ToString());
				}
				if(row["top"]!=null && row["top"].ToString()!="")
				{
					model.top=int.Parse(row["top"].ToString());
				}
				if(row["hot"]!=null && row["hot"].ToString()!="")
				{
					model.hot=int.Parse(row["hot"].ToString());
				}
				if(row["intro"]!=null && row["intro"].ToString()!="")
				{
					model.intro=int.Parse(row["intro"].ToString());
				}
                if (row["read"] != null && row["read"].ToString() != "")
                {
                    model.read = int.Parse(row["read"].ToString());
                }
                if (row["blank"] != null && row["blank"].ToString() != "")
                {
                    model.blank = int.Parse(row["blank"].ToString());
                }
                if (row["orderby"] != null && row["orderby"].ToString() != "")
                {
                    model.orderby = int.Parse(row["orderby"].ToString());
                }
                if (row["tag"] != null)
                {
                    model.tag = row["tag"].ToString();
                }
                if (row["ext"] != null)
                {
                    model.ext = row["ext"].ToString();
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
				if(row["ext11"]!=null)
				{
					model.ext11=row["ext11"].ToString();
				}
				if(row["ext12"]!=null)
				{
					model.ext12=row["ext12"].ToString();
				}
				if(row["ext13"]!=null)
				{
					model.ext13=row["ext13"].ToString();
				}
				if(row["ext14"]!=null)
				{
					model.ext14=row["ext14"].ToString();
				}
				if(row["ext15"]!=null)
				{
					model.ext15=row["ext15"].ToString();
				}
				if(row["ext16"]!=null)
				{
					model.ext16=row["ext16"].ToString();
				}
				if(row["ext17"]!=null)
				{
					model.ext17=row["ext17"].ToString();
				}
				if(row["ext18"]!=null)
				{
					model.ext18=row["ext18"].ToString();
				}
				if(row["ext19"]!=null)
				{
					model.ext19=row["ext19"].ToString();
				}
				if(row["ext20"]!=null)
				{
					model.ext20=row["ext20"].ToString();
				}
				if(row["ext21"]!=null)
				{
					model.ext21=row["ext21"].ToString();
				}
				if(row["ext22"]!=null)
				{
					model.ext22=row["ext22"].ToString();
				}
				if(row["ext23"]!=null)
				{
					model.ext23=row["ext23"].ToString();
				}
				if(row["ext24"]!=null)
				{
					model.ext24=row["ext24"].ToString();
				}
				if(row["ext25"]!=null)
				{
					model.ext25=row["ext25"].ToString();
				}
				if(row["ext26"]!=null)
				{
					model.ext26=row["ext26"].ToString();
				}
				if(row["ext27"]!=null)
				{
					model.ext27=row["ext27"].ToString();
				}
				if(row["ext28"]!=null)
				{
					model.ext28=row["ext28"].ToString();
				}
				if(row["ext29"]!=null)
				{
					model.ext29=row["ext29"].ToString();
				}
				if(row["ext30"]!=null)
				{
					model.ext30=row["ext30"].ToString();
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
			strSql.Append("select id,typeid,title,keywords,description,content,titleen,keywordsen,descriptionen,contenten,pic,piclist,hit,postby,enable,postdate,modifydate,top,hot,intro,read,blank,orderby,tag,ext,ext1,ext2,ext3,ext4,ext5,ext6,ext7,ext8,ext9,ext10,ext11,ext12,ext13,ext14,ext15,ext16,ext17,ext18,ext19,ext20,ext21,ext22,ext23,ext24,ext25,ext26,ext27,ext28,ext29,ext30 ");
			strSql.Append(" FROM posts ");
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
			strSql.Append("select count(1) FROM posts ");
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

            StringBuilder strSql =new StringBuilder();
			strSql.Append("SELECT * , rowid FROM posts ");

            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere+" ");
            }
            else {
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
			parameters[0].Value = "posts";
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

