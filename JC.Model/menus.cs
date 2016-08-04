using System;
namespace JC.Model
{
    /// <summary>
    /// menus:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class menus
    {
        public menus()
        { }
        #region Model
        private int _id;
        private int? _parentid;
        private string _linktag;
        private string _title;
        private string _keywords;
        private string _description;
        private string _content;
        private string _titleen;
        private string _keywordsen;
        private string _contenten;
        private string _descriptionen;
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
        public string linktag
        {
            set { _linktag = value; }
            get { return _linktag; }
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
        public string keywords
        {
            set { _keywords = value; }
            get { return _keywords; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string description
        {
            set { _description = value; }
            get { return _description; }
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
        public string titleen
        {
            set { _titleen = value; }
            get { return _titleen; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string keywordsen
        {
            set { _keywordsen = value; }
            get { return _keywordsen; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string contenten
        {
            set { _contenten = value; }
            get { return _contenten; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string descriptionen
        {
            set { _descriptionen = value; }
            get { return _descriptionen; }
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

