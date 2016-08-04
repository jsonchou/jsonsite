using System;
namespace JC.Model
{
    /// <summary>
    /// posts:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class posts
    {
        public posts()
        { }
        #region Model
        private int _id;
        private int _typeid;
        private string _title;
        private string _keywords;
        private string _description;
        private string _content;
        private string _titleen;
        private string _keywordsen;
        private string _descriptionen;
        private string _contenten;
        private string _pic = "/content/base/nopic.png";
        private string _piclist = "/content/base/nopic.png";
        private int? _hit = 1;
        private string _postby;
        private int? _enable = 1;//有效
        private DateTime? _postdate;
        private DateTime? _modifydate;
        private int _top = 0;
        private int _hot = 0;
        private int _intro = 0;
        private int _read = 0;//是否已查看
        private int _blank = 1;//弹出窗口打开
        private int _orderby = 9999;//排序
        private string _tag;//自定义标签
        private string _ext;
        private string _ext1;
        private string _ext2;
        private string _ext3;
        private string _ext4;
        private string _ext5;
        private string _ext6;
        private string _ext7;
        private string _ext8;
        private string _ext9;
        private string _ext10;
        private string _ext11;
        private string _ext12;
        private string _ext13;
        private string _ext14;
        private string _ext15;
        private string _ext16;
        private string _ext17;
        private string _ext18;
        private string _ext19;
        private string _ext20;
        private string _ext21;
        private string _ext22;
        private string _ext23;
        private string _ext24;
        private string _ext25;
        private string _ext26;
        private string _ext27;
        private string _ext28;
        private string _ext29;
        private string _ext30;
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
        public int typeid
        {
            set { _typeid = value; }
            get { return _typeid; }
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
        public string descriptionen
        {
            set { _descriptionen = value; }
            get { return _descriptionen; }
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
        public string pic
        {
            set { _pic = value; }
            get { return _pic; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string piclist
        {
            set { _piclist = value; }
            get { return _piclist; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? hit
        {
            set { _hit = value; }
            get { return _hit; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string postby
        {
            set { _postby = value; }
            get { return _postby; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? enable
        {
            set { _enable = value; }
            get { return _enable; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? postdate
        {
            set { _postdate = value; }
            get { return _postdate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? modifydate
        {
            set { _modifydate = value; }
            get { return _modifydate; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int top
        {
            set { _top = value; }
            get { return _top; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int hot
        {
            set { _hot = value; }
            get { return _hot; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int intro
        {
            set { _intro = value; }
            get { return _intro; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int read
        {
            set { _read = value; }
            get { return _read; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int blank
        {
            set { _blank = value; }
            get { return _blank; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int orderby
        {
            set { _orderby = value; }
            get { return _orderby; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string tag
        {
            set { _tag = value; }
            get { return _tag; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext
        {
            set { _ext = value; }
            get { return _ext; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext1
        {
            set { _ext1 = value; }
            get { return _ext1; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext2
        {
            set { _ext2 = value; }
            get { return _ext2; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext3
        {
            set { _ext3 = value; }
            get { return _ext3; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext4
        {
            set { _ext4 = value; }
            get { return _ext4; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext5
        {
            set { _ext5 = value; }
            get { return _ext5; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext6
        {
            set { _ext6 = value; }
            get { return _ext6; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext7
        {
            set { _ext7 = value; }
            get { return _ext7; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext8
        {
            set { _ext8 = value; }
            get { return _ext8; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext9
        {
            set { _ext9 = value; }
            get { return _ext9; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext10
        {
            set { _ext10 = value; }
            get { return _ext10; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext11
        {
            set { _ext11 = value; }
            get { return _ext11; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext12
        {
            set { _ext12 = value; }
            get { return _ext12; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext13
        {
            set { _ext13 = value; }
            get { return _ext13; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext14
        {
            set { _ext14 = value; }
            get { return _ext14; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext15
        {
            set { _ext15 = value; }
            get { return _ext15; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext16
        {
            set { _ext16 = value; }
            get { return _ext16; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext17
        {
            set { _ext17 = value; }
            get { return _ext17; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext18
        {
            set { _ext18 = value; }
            get { return _ext18; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext19
        {
            set { _ext19 = value; }
            get { return _ext19; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext20
        {
            set { _ext20 = value; }
            get { return _ext20; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext21
        {
            set { _ext21 = value; }
            get { return _ext21; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext22
        {
            set { _ext22 = value; }
            get { return _ext22; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext23
        {
            set { _ext23 = value; }
            get { return _ext23; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext24
        {
            set { _ext24 = value; }
            get { return _ext24; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext25
        {
            set { _ext25 = value; }
            get { return _ext25; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext26
        {
            set { _ext26 = value; }
            get { return _ext26; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext27
        {
            set { _ext27 = value; }
            get { return _ext27; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext28
        {
            set { _ext28 = value; }
            get { return _ext28; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext29
        {
            set { _ext29 = value; }
            get { return _ext29; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ext30
        {
            set { _ext30 = value; }
            get { return _ext30; }
        }
        #endregion Model

    }
}

