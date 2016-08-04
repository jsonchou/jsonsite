using System;
namespace JC.Model
{
    /// <summary>
    /// users:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class users
    {
        public users()
        { }
        #region Model
        private int _id;
        private string _username;
        private string _nickname;
        private string _email;
        private string _pwd;
        private string _avator = "/content/base/nopic.png";
        private DateTime? _postdate;
        private DateTime? _modifydate;
        private int? _isadmin = 0;
        private int? _logtime = 1;
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
        public string username
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
		/// 
		/// </summary>
		public string nickname
        {
            set { _nickname = value; }
            get { return _nickname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string email
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string pwd
        {
            set { _pwd = value; }
            get { return _pwd; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string avator
        {
            set { _avator = value; }
            get { return _avator; }
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
        public int? isadmin
        {
            set { _isadmin = value; }
            get { return _isadmin; }
        }
        /// <summary>
		/// 
		/// </summary>
		public int? logtime
        {
            set { _logtime = value; }
            get { return _logtime; }
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

