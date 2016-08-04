using System;
using System.Data;
using System.Collections.Generic;
using JC.Common;
using JC.Model;
using JC.DALFactory;
using JC.IDAL;
namespace JC.BLL
{
    /// <summary>
    /// posts
    /// </summary>
    public partial class posts
    {
        //private static string cacName = "postsModel";
        private readonly Iposts dal = DataAccess.Createposts();
        public posts()
        { }
        #region  BasicMethod

        //posts表，不载入整表缓存
        public void initCache()
        {
           
        }

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return dal.GetMaxId();
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            return dal.Exists(id);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(JC.Model.posts model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(JC.Model.posts model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Del(int id)
        {
            return dal.Delete(id);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Del(string idlist)
        {
            return dal.DeleteList(JC.Common.PageValidate.SafeLongFilter(idlist, 0));
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public JC.Model.posts Get(int id)
        {
            return dal.GetModel(id);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<JC.Model.posts> GetList(string strWhere = "")
        {
            return _GetList(strWhere);
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public int Count(string strWhere = "")
        {
            return dal.GetRecordCount(strWhere);
        }

        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public List<JC.Model.posts> GetListByPage(string strWhere, string orderby, int startIndex, int rowCount)
        {
            DataSet ds = dal.GetListByPage(strWhere, orderby, startIndex, rowCount);
            return _DataSetToModelList(ds);
        }

        /// <summary>
        /// DataSet 转换成 泛型集合
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        private List<JC.Model.posts> _DataSetToModelList(DataSet ds)
        {
            List<JC.Model.posts> modelList = new List<JC.Model.posts>();
            var dt = ds.Tables[0];
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                JC.Model.posts model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = dal.DataRowToModel(dt.Rows[n]);
                    if (model != null)
                    {
                        modelList.Add(model);
                    }
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表泛型
        /// </summary>
        private List<JC.Model.posts> _GetList(string strWhere = "")
        {
            DataSet ds = dal.GetList(strWhere);
            return _DataSetToModelList(ds);
        }

        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

