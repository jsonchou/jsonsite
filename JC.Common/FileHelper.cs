using System.IO;

namespace JC.Common
{
    /// <summary>
    /// 对文件和文件夹的操作类
    /// </summary>
    public class FileHelper
    {
        public FileHelper()
        {

        }
        /// <summary>
        /// 在根目录下创建文件夹
        /// </summary>
        /// <param name="FolderPathName"></param>
        public static void CreateFolder(string FolderPathName)
        {
            if (FolderPathName.Trim().Length > 0)
            {
                try
                {
                    string CreatePath = FolderPathName;
                    if (!Directory.Exists(CreatePath))
                    {
                        Directory.CreateDirectory(CreatePath);
                    }
                }
                catch
                {
                    throw;
                }
            }
        }

        public static void CreateFolderWeb(string FolderPathName)
        {
            if (FolderPathName.Trim().Length > 0)
            {
                try
                {
                    string CreatePath = FolderPathName;
                    if (!Directory.Exists(CreatePath))
                    {
                        Directory.CreateDirectory(CreatePath);
                    }
                }
                catch
                {
                    throw;
                }
            }
        }
        /// <summary>
        /// 删除一个文件夹下面的字文件夹和文件
        /// </summary>
        /// <param name="FolderPathName"></param>
        public static void DeleteChildFolder(string FolderPathName)
        {
            if (FolderPathName.Trim().Length > 0)
            {
                try
                {
                    string CreatePath = FolderPathName;
                    if (Directory.Exists(CreatePath))
                    {
                        Directory.Delete(CreatePath,true);
                    }
                }
                catch
                {
                    throw;
                }
            }
        }

 

        /// <summary>
        /// 删除一个文件
        /// </summary>
        /// <param name="FilePathName"></param>
        public static void DeleteFile(string FilePathName)
        {
            try
            {
                FileInfo DeleFile = new FileInfo(FilePathName);
                DeleFile.Delete();
            }
            catch
            {
            }
        }
 

        public static void CreateFile(string FilePathName)
        {
            try
            {
                //创建文件夹
                string[] strPath = FilePathName.Split('\\');
                CreateFolder(FilePathName.Replace("\\" + strPath[strPath.Length - 1].ToString(), "")); //创建文件夹
                FileInfo CreateFile = new FileInfo(FilePathName); //创建文件
                if (!CreateFile.Exists)
                {
                    FileStream FS = CreateFile.Create();
                    FS.Close();
                }
            }
            catch
            {
            }
        }
 
        /// <summary>
        /// 在文件里追加内容
        /// </summary>
        /// <param name="FilePathName"></param>
        /// <param name="WriteWord"></param>
        public static void ReWriteReadinnerText(string FilePathName, string WriteWord)
        {
            try
            {
                //建立文件夹和文件
                //CreateFolder(FilePathName);
                CreateFile(FilePathName);
                //得到原来文件的内容
                FileStream FileRead = new FileStream(FilePathName, FileMode.Open, FileAccess.ReadWrite);
                StreamReader FileReadWord = new StreamReader(FileRead, System.Text.Encoding.UTF8);
                string OldString = FileReadWord.ReadToEnd().ToString();
                OldString = OldString + WriteWord;
                //把新的内容重新写入
                StreamWriter FileWrite = new StreamWriter(FileRead, System.Text.Encoding.UTF8);
                FileWrite.Write(WriteWord);
                //关闭
                FileWrite.Close();
                FileReadWord.Close();
                FileRead.Close();
            }
            catch
            {
                // throw;
            }
        }

        /// <summary>
        /// 在文件里追加内容
        /// </summary>
        /// <param name="FilePathName"></param>
        /// <returns></returns>
        public static string ReaderFileData(string FilePathName)
        {
            try
            {
                FileStream FileRead = new FileStream(System.Web.HttpContext.Current.Server.MapPath(FilePathName).ToString(), FileMode.Open, FileAccess.Read);
                StreamReader FileReadWord = new StreamReader(FileRead, System.Text.Encoding.Default);
                string TxtString = FileReadWord.ReadToEnd().ToString();
                //关闭
                FileReadWord.Close();
                FileRead.Close();
                return TxtString;
            }
            catch
            {
                throw;
            }
        }
        /// <summary>
        /// 读取文件夹的文件
        /// </summary>
        /// <param name="FilePathName"></param>
        /// <returns></returns>
        public static DirectoryInfo checkValidSessionPath(string FilePathName)
        {
            try
            {
                DirectoryInfo MainDir = new DirectoryInfo(System.Web.HttpContext.Current.Server.MapPath(FilePathName));
                return MainDir;

            }
            catch
            {
                throw;
            }
        }
    }
}