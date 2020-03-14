using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Base
{
	public class UtilAPI
	{
		[DllImport("kernel32.dll")]
		public static extern IntPtr _lopen(string lpPathName, int iReadWrite);
		[DllImport("kernel32.dll")]
		public static extern bool CloseHandle(IntPtr hObject);

		[DllImport("kernel32.dll", EntryPoint = "DeleteFile")]
		public static extern int DeleteFile(String path);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        //判断文件是否被占用
        public static bool IsUsing(string strPath)
		{
			IntPtr vHandle = IntPtr.Zero;
			try
			{
				if (!File.Exists(strPath))
				{
					return false;
				}
				vHandle = _lopen(strPath, 2 | 0x40);
				if (vHandle == new IntPtr(-1))
				{
					return true;
				}
				return false;
			}
			catch
			{
				throw new Exception("判断文件占用时出错");
			}
			finally
			{
				CloseHandle(vHandle);
			}
		}

		//清除文件夹
		public static bool ClearTempDir(String strDIr)
		{
			if(Directory.Exists(strDIr))
			{
				try
				{
					DirectoryInfo dirInfo = new DirectoryInfo(strDIr);
					var infoList = dirInfo.GetFileSystemInfos();
					foreach (var fileInfo in infoList)
					{
						if (fileInfo is DirectoryInfo)			//判断是否文件夹
						{
							DirectoryInfo subdir = new DirectoryInfo(fileInfo.FullName);
							subdir.Delete(true);				//删除子目录和文件
						}
						else
						{
							File.Delete(fileInfo.FullName);		//删除指定文件
						}
					}
				}
				catch (Exception ex)
				{
					Logger.LogError(ex.ToString());
					return false;
				}
			}
			return true;
		}

		//清除日志文件夹
		public static bool ClearLogDir()
		{
            if (Directory.Exists(Logger.LogDir))
            {
                try
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(Logger.LogDir);
                    var infoList = dirInfo.GetFileSystemInfos();
                    foreach (var fileInfo in infoList)
                    {
                        File.Delete(fileInfo.FullName);
                    }
                }
                catch (Exception ex)
                {
                    Logger.LogError(ex.ToString());
                    return false;
                }
            }
            return true;
		}

		public static bool SaveFileTo(byte[] fileByte, String strPath)
		{
            if(IsUsing(strPath))
            {
                return false;
            }
			FileStream fileStream = new FileStream(strPath, FileMode.OpenOrCreate);
			try
			{
				fileStream.Write(fileByte, 0, fileByte.Length);
				fileStream.Close();
				return true;
			}
			catch (Exception ex)
			{
				fileStream.Close();
				Logger.LogError(ex.ToString());
				return false;
			}
		}

        //时间戳转换为DataTime
        public static DateTime StampToDateTime(long stamp)
        {
            // 定义时区
            DateTime TZone = TimeZone.CurrentTimeZone.
                ToLocalTime(new DateTime(1970, 1, 1));
            DateTime dt = TZone.AddMilliseconds(stamp);
            return dt;
        }

        //DataTime转换为时间戳
        public static long DateTimeToStamp(DateTime dateTime)
        {
            long stamp = 0;
            // 定义时区
            DateTime TZone = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            TimeSpan theSpan = dateTime - TZone;
            stamp = (long)theSpan.TotalMilliseconds;
            return stamp;
        }

        //创建一个16位的ID
        public static long NewID()
        {
            long time = DateTime.Now.Ticks;
            return time;
        }
    }
}
