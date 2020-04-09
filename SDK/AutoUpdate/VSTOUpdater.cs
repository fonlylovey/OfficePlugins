using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using Base;
using Core;

namespace AutoUpdate
{
    public class VSTOUpdater
	{
		public static String ServerVersion = "";

        public static async Task<bool> CheckUpdate()
        {
            try
            {
				//http://xxw.autoinfo.org.cn/ppttools/static/update/publish
				String strLogUrl = Rigel.UpdateUrl + "ExcelChangeLog.txt"; ;
                String strVSTOUrl = Rigel.UpdateUrl + "BIMExcelPlugin.vsto";

                await GetServerVersion(strVSTOUrl);

                String strChangeLog = await GetChangeLog(strLogUrl);
                int local = 0;
                Int32.TryParse(Rigel.PluginVersion.Replace(".", ""), out local);
                int server = 0;
                Int32.TryParse(ServerVersion.Replace(".", ""), out server);

                int index = strChangeLog.IndexOf('\n') + 1;
                String strDesc = strChangeLog.Substring(0, index);
                String strLogs = strChangeLog.Substring(index, strChangeLog.Length - index);
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.ToString());
                return false;
            }
            return true;
        }

        public static async Task<bool> GetServerVersion(String fileUrl)
		{
			//下载云端vsto
			String filePath = "";
			try
			{
                filePath = await Request.HttpDownload(fileUrl);
				if(!string.IsNullOrEmpty(filePath))
				{
					LoadVersionByVSTO(filePath);
				}
				return true;
			}
			catch
			{
				Logger.LogError("检查更新失败");
				return false;
			}
			finally
			{
				System.IO.File.Delete(filePath);
			}
		}

		public static async Task<String> GetChangeLog(String fileUrl)
		{
			//下载云端vsto
			String strChangeLog = "";
			String filePath;
			FileStream file = null;
			try
			{
                filePath = await Request.HttpDownload(fileUrl);
				file = new FileStream(filePath, FileMode.Open);
				byte[] byteArray = new byte[file.Length];
				int x = await file.ReadAsync(byteArray, 0, (int)file.Length);
				strChangeLog = System.Text.Encoding.UTF8.GetString(byteArray);
			}
			catch
			{
				throw new Exception("检查更新失败");
			}
			finally
			{
				if(file != null)
				{
					file.Close();
				}
			}
			return strChangeLog;
		}
		//检测云端版本，返回是否需要更新

		static String LoadVersionByVSTO(String xmlPath)
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(xmlPath);

			var root = doc.DocumentElement;
			var assemblyIdentity = root.FirstChild;
			ServerVersion = assemblyIdentity.Attributes[1].Value;
			return ServerVersion;
		}
	}
}
