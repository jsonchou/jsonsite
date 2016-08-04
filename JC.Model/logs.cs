using System;
namespace JC.Model
{
    /// <summary>
    /// logs:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class logs
    {
        public logs()
        { }
        #region Model
        private int _id;
        private string _username;
        private string _logtype;
        private string _loginfo;
        private DateTime? _postdate;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string username
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string logtype
        {
            set { _logtype = value; }
            get { return _logtype; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string loginfo
        {
            set { _loginfo = value; }
            get { return _loginfo; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? postdate
        {
            set { _postdate = value; }
            get { return _postdate; }
        }
        #endregion Model

    }
}

