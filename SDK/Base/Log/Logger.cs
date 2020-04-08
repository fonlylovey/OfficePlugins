using System;
using System.Threading;

namespace Base
{
	public class Logger
	{
		public static string[] typeSet = { "Error", "Info" };
        public static string LogDir { get; set; } = "C://ErrorLog//";
		public static string LogPath = "";
        static ReaderWriterLockSlim writerLock = new ReaderWriterLockSlim();

        public static void WriteLog(string type, string logInfo)
		{
            try
            {
                writerLock.EnterWriteLock();

                if (!System.IO.Directory.Exists(LogDir))
                {
                    System.IO.Directory.CreateDirectory(LogDir);
                }
                if (string.IsNullOrEmpty(LogPath))
                {
                    String strTime = DateTime.Now.ToString("yyyy_MM_dd");
                    LogPath = LogDir + strTime + ".log";
                }
                String strTimeTick = DateTime.Now.ToString("yyyy_MM_dd hh:mm:ss");
                String strContent = type + ":\r\n" + strTimeTick + "：" + logInfo + "\r\n";
                System.IO.File.AppendAllText(LogPath, strContent, System.Text.Encoding.Default);
            }
			catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                writerLock.ExitWriteLock();
            }

		}

		public static void LogError(string logInfo)
		{
            WriteLog("Error", logInfo);
		}

		public static void LogInfo(string logInfo)
		{
			WriteLog("Info", logInfo);
		}
    }
}
