﻿using System;
using System.Data;
using JC.Model;

namespace JC.IDAL
{
    /// <summary>
    /// 接口层logs
    /// </summary>
    public interface Ilogs
    {
        #region  成员方法
        /// <summary>
        /// 得到最大ID
        /// </summary>
        int GetMaxId();

        /// <summary>
		/// 得到记录条数
		/// </summary>
        int GetRecordCount(string strWhere = "");
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        bool Exists(int id);
        /// <summary>
        /// 增加一条数据
        /// </summary>
        int Add(JC.Model.logs model);
        /// <summary>
        /// 更新一条数据
        /// </summary>
        bool Update(JC.Model.logs model);
        /// <summary>
        /// 删除一条数据
        /// </summary>
        bool Delete(int id);
        bool DeleteList(string idlist);
        bool DeleteWhere(string strWhere = "");
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        JC.Model.logs GetModel(int id);
        JC.Model.logs DataRowToModel(DataRow row);
        /// <summary>
        /// 获得数据列表
        /// </summary>
        DataSet GetList(string strWhere = "");

        /// <summary>
		/// 获得数据列表通过页码
		/// </summary>
        DataSet GetListByPage(string strWhere, string orderby, int startIndex, int rowCount);
        /// <summary>
        /// 根据分页获得数据列表
        /// </summary>
        //DataSet GetList(int logsize,int PageIndex,string strWhere);
        #endregion  成员方法
        #region  MethodEx

        #endregion  MethodEx
    }
}
