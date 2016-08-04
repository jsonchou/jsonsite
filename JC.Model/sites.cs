using System;
namespace JC.Model
{
    /// <summary>
    /// site:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class sites
    {
        public sites()
        { }
        #region Model
        private int _id;
        private string _url;
        private string _logo;
        private string _icon;
        private string _lang = "中文";
        private string _langcode = "cn";
        private string _title;
        private string _keywords;
        private string _description;
        private string _titleen;
        private string _keywordsen;
        private string _descriptionen;
        private string _company;
        private string _freetele;
        private string _beiancode;
        private string _sitetrack;
        private string _mail;
        private string _mailpwd;
        private string _mailsmtp = "smtp.163.com";
        private int _mailport = 25;
        private string _nopic = "/content/base/nopic.png";
        private int _picmaxlength =12;//子图片最大数量
        private string _contact;
        private int _logday=30;
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
        public string url
        {
            set { _url = value; }
            get { return _url; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string logo
        {
            set { _logo = value; }
            get { return _logo; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string icon
        {
            set { _icon = value; }
            get { return _icon; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string lang
        {
            set { _lang = value; }
            get { return _lang; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string langcode
        {
            set { _langcode = value; }
            get { return _langcode; }
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
        public string company
        {
            set { _company = value; }
            get { return _company; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string freetele
        {
            set { _freetele = value; }
            get { return _freetele; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string beiancode
        {
            set { _beiancode = value; }
            get { return _beiancode; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string sitetrack
        {
            set { _sitetrack = value; }
            get { return _sitetrack; }
        }
        /// <summary>
		/// 
		/// </summary>
		public string mail
        {
            set { _mail = value; }
            get { return _mail; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string mailpwd
        {
            set { _mailpwd = value; }
            get { return _mailpwd; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string mailsmtp
        {
            set { _mailsmtp = value; }
            get { return _mailsmtp; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int mailport
        {
            set { _mailport = value; }
            get { return _mailport; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string nopic
        {
            set { _nopic = value; }
            get { return _nopic; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int picmaxlength
        {
            set { _picmaxlength = value; }
            get { return _picmaxlength; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string contact
        {
            set { _contact = value; }
            get { return _contact; }
        }
        /// <summary>
		/// 
		/// </summary>
		public int logday
        {
            set { _logday = value; }
            get { return _logday; }
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
        #endregion Model

    }
}

