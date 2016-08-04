using System;
namespace JC.Model
{
    /// <summary>
    /// modules:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class modules
    {
        public modules()
        { }
        #region Model
        private int _id;
        private int? _parentid;
        private string _title;
        private string _content;
        private string _url;
        private int? _blank = 0;
        private string _pic = "/content/base/nopic.png";
        private string _path;
        private int? _stem = 1;
        private int? _haschild = 0;
        private int? _orderby = 9999;
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
        public int? parentid
        {
            set { _parentid = value; }
            get { return _parentid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string title
        {
            set { _title = value; }
            get { return _title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string content
        {
            set { _content = value; }
            get { return _content; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string url
        {
            set { _url = value; }
            get { return _url; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? blank
        {
            set { _blank = value; }
            get { return _blank; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pic
        {
            set { _pic = value; }
            get { return _pic; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string path
        {
            set { _path = value; }
            get { return _path; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? stem
        {
            set { _stem = value; }
            get { return _stem; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? haschild
        {
            set { _haschild = value; }
            get { return _haschild; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? orderby
        {
            set { _orderby = value; }
            get { return _orderby; }
        }
        #endregion Model

    }
}

