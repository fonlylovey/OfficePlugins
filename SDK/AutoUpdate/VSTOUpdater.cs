using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using BIM.Base;

namespace BIM.AutoUpdate
{
    public class VSTOUpdater
	{
		public static String ServerVersion = "";
		public static UpdateForm UpdateWidget = new UpdateForm();

		public static async Task<bool> GetServerVersion(String fileUrl)
		{
			//下载云端vsto
			String filePath = "";
			try
			{
                filePath = await Request.HttpDownload(fileUrl);
				if(!string.IsNullOrEmpty(filePath))
				{
					LoadVersionByXml(filePath);
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
		public static async Task<bool> CheckUpdate()
		{
			try
			{
				String strLogUrl = "";
				String strVSTOUrl = "";
				if (BIM5D.AppType == PluginType.MS_Word)
				{
					strLogUrl = BIM5D.UpdateUrl + "WordChangeLog.txt";
					strVSTOUrl = BIM5D.UpdateUrl + "BIMWordPlugin.vsto";
				}
				else if (BIM5D.AppType == PluginType.MS_Project)
				{
					strLogUrl = BIM5D.UpdateUrl + "ProjectChangeLog.txt";
					strVSTOUrl = BIM5D.UpdateUrl + "BIMProjectPlugin.vsto";
				}
				else if (BIM5D.AppType == PluginType.MS_PowerPoint)
				{
					strLogUrl = BIM5D.UpdateUrl + "PPTChangeLog.txt";
					strVSTOUrl = BIM5D.UpdateUrl + "BIMPPTPlugin.vsto";
				}
                else if (BIM5D.AppType == PluginType.MS_Excel)
                {
                    strLogUrl = BIM5D.UpdateUrl + "ExcelChangeLog.txt";
                    strVSTOUrl = BIM5D.UpdateUrl + "BIMExcelPlugin.vsto";
                }

                await GetServerVersion(strVSTOUrl);

				String strChangeLog = await GetChangeLog(strLogUrl);
				int local = 0;
                Int32.TryParse(BIM5D.PluginVersion.Replace(".", ""), out local);
				int server = 0;
                Int32.TryParse(ServerVersion.Replace(".", ""), out server);

				UpdateWidget.SetCurrentVersion(BIM5D.PluginVersion);
				UpdateWidget.SetServerVersion(ServerVersion);
				int index = strChangeLog.IndexOf('\n') + 1;
				String strDesc = strChangeLog.Substring(0, index);
                String strLogs = strChangeLog.Substring(index, strChangeLog.Length - index);

				UpdateWidget.SetDescription(strDesc);
                UpdateWidget.SetChangeLog(strLogs);

				if (local < server)
				{
                    if (local < 400126)
                    {
						UpdateWidget.SetNeedUpdate(false);
					}
                    else
                    {
						UpdateWidget.SetNeedUpdate(true);
					}
					UpdateWidget.ShowDialog();
                }
				else
				{
					UpdateWidget.SetNeedUpdate(false);
					return false;
				}
			}
			catch(Exception ex)
			{
				Logger.LogError(ex.ToString());
				return false;
			}
			return true;
		}

		static String LoadVersionByXml(String xmlPath)
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
