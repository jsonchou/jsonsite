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
    /// modules
    /// </summary>
    public partial class modules
    {
        private static string cacName = "modulesModel";
        private readonly Imodules dal = DataAccess.Createmodules();
        public modules()
        { }
        #region  BasicMethod

        //载入整表缓存
        public void initCache()
        {
            JC.Common.DataCache.Set(cacName, _GetList());
        }

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            var objCache = JC.Common.DataCache.Get(cacName);
            if (objCache != null)
            {
                var lst = (List<JC.Model.modules>)objCache;
                if (lst != null)
                {
                    var lstLen = lst.Count;
                    var lstLast = lst[lstLen - 1];
                    return lstLast.id + 1;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return dal.GetMaxId();
            }
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id)
        {
            var objCache = JC.Common.DataCache.Get(cacName);
            if (objCache != null)
            {
                var md = ((List<JC.Model.modules>)objCache).Find(c => c.id == id);
                return md != null ? true : false;
            }
            else
            {
                return dal.Exists(id);
            }
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(JC.Model.modules model)
        {
            var cb = dal.Add(model);
            JC.Common.DataCache.Set(cacName, _GetList());
            return cb;
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(JC.Model.modules model)
        {
            var cb = dal.Update(model);
            JC.Common.DataCache.Set(cacName, _GetList());
            return cb;
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Del(int id)
        {
            var cb = dal.Delete(id);
            JC.Common.DataCache.Set(cacName, _GetList());
            return cb;
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Del(string idlist)
        {
            var cb = dal.DeleteList(JC.Common.PageValidate.SafeLongFilter(idlist, 0));
            JC.Common.DataCache.Set(cacName, _GetList());
            return cb;
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public JC.Model.modules Get(int id)
        {
            object objModel = JC.Common.DataCache.Get(cacName);
            JC.Model.modules md = new Model.modules();
            if (objModel != null)
            {
                List<JC.Model.modules> modelList = (List<JC.Model.modules>)objModel;
                if (modelList != null && modelList.Count > 0)
                {
                    md = modelList.Find(c => c.id == id);
                }
            }
            else
            {
                md = dal.GetModel(id);
            }
            return md;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<JC.Model.modules> GetList(string strWhere = "")
        {
            List<JC.Model.modules> modelList = new List<JC.Model.modules>();

            //无参数，做缓存
            if (string.IsNullOrEmpty(strWhere))
            {
                modelList = (List<JC.Model.modules>)JC.Common.DataCache.Get(cacName);
                if (modelList != null && modelList.Count > 0)
                {
                    return modelList;
                }
                else
                {
                    modelList = _GetList(strWhere);
                    JC.Common.DataCache.Set(cacName, modelList);
                    return modelList;
                }
            }
            else
            {
                //有参数，不做缓存
                return _GetList(strWhere);
            }

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
        public List<JC.Model.modules> GetListByPage(string strWhere, string orderby, int startIndex, int rowCount)
        {
            DataSet ds = dal.GetListByPage(strWhere, orderby, startIndex, rowCount);
            return _DataSetToModelList(ds);
        }

        /// <summary>
        /// DataSet 转换成 泛型集合
        /// </summary>
        /// <param name="ds"></param>
        /// <returns></returns>
        private List<JC.Model.modules> _DataSetToModelList(DataSet ds)
        {
            List<JC.Model.modules> modelList = new List<JC.Model.modules>();
            var dt = ds.Tables[0];
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                JC.Model.modules model;
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
        private List<JC.Model.modules> _GetList(string strWhere = "")
        {
            DataSet ds = dal.GetList(strWhere);
            return _DataSetToModelList(ds);
        }

        #endregion  BasicMethod

        #region  ExtensionMethod

        #endregion  ExtensionMethod
    }
}

