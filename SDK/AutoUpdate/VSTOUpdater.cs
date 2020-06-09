using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Xml;
using Base;
using Core;
using TG.INI;
using System.Diagnostics;
using System.IO;
using Widgets;
using System.Linq;
using System.Runtime.CompilerServices;

namespace AutoUpdate
{
    public class VSTOUpdater
	{
		public static bool NeedUpdate = false;
		public static String ServerVersion = "";
		public static Dictionary<String, String> UpdateLog = new Dictionary<string, string>();
		public static async Task<bool> CheckUpdate()
        {
            try
            {
				//http://xxw.autoinfo.org.cn/ppttools/static/update/publish
				String strLogUrl = Rigel.UpdateUrl + "UpdateLog.ini"; ;
                String strVSTOUrl = Rigel.UpdateUrl + "Auto PPTer.vsto";

                await GetServerVersion(strVSTOUrl);

                await GetChangeLog(strLogUrl);
                int local = 0;
                Int32.TryParse(Rigel.PluginVersion.Replace(".", ""), out local);
                int server = 0;
				string userId = Rigel.UserID;
				string userName = Rigel.UserName;
				List<string> userIds = new List<string>();
			    string serverver = ServerVersion.Replace(".", "").PadRight(local.ToString().Length,'0');
				Int32.TryParse(serverver, out server);
				UpdateLog.TryGetValue("sjhs", out string sjhs);
				userIds = sjhs.Split(',').ToList<string>();
				if ((userIds.Contains(userName) ||userIds.Contains("all"))&&local < server)
				{
					NeedUpdate = true;
				}
				else
				{
					NeedUpdate = false;
				}
					
			}
            catch (Exception ex)
            {
                Logger.LogError(ex.ToString());
                return false;
            }
            return true;
        }

		public static bool Update()
		{
			UninstallPlugin();
			String strinstall = Rigel.PluginDir + "Plugins/InstallVSTO.bat";
			try
			{
				if (File.Exists(strinstall))
				{
					ProcessStartInfo startInfo = new ProcessStartInfo(strinstall);
					//设置不在新窗口中启动新的进程
					startInfo.CreateNoWindow = true;
					//不使用操作系统使用的shell启动进程
					startInfo.UseShellExecute = false;
					//将输出信息重定向
					startInfo.RedirectStandardOutput = true;
					Process process = Process.Start(startInfo);

					if (process != null)
					{
						process.WaitForExit();
						return true;
					}
				}
				else
				{
					bool flag = execCmd("i");
					if (!flag)
					{
						PromptBox.Prompt("升级失败");
					}
					return flag;
				}
				
			}
			catch (Exception ex)
			{
				Logger.LogError(ex.ToString());
				PromptBox.Prompt("非常抱歉更新失败，请联系工作人员！");
			}
			return false;
		}

		public static void UninstallPlugin()
		{
			String strUninstall = Rigel.PluginDir + "Plugins/UninstallVSTO.bat";
			try
			{
				if (File.Exists(strUninstall))
				{
					ProcessStartInfo startInfo = new ProcessStartInfo(strUninstall);
					//设置不在新窗口中启动新的进程
					startInfo.CreateNoWindow = true;
					//不使用操作系统使用的shell启动进程
					startInfo.UseShellExecute = false;
					//将输出信息重定向
					startInfo.RedirectStandardOutput = true;
					Process process = Process.Start(startInfo);

					if (process != null)
					{
						process.WaitForExit();
					}
				}
				else
				{
					bool flag = execCmd("u");
					if (!flag)
					{
						Logger.LogError("升级失败");
					}
				}
			}
			catch(Exception ex)
			{
				Logger.LogError(ex.ToString());
			}
		}
		public static bool execCmd(string flag)
		{
			bool ret;
			try
			{
				//创建一个进程
				Process p = new Process();
				p.StartInfo.FileName = "cmd.exe";
				p.StartInfo.UseShellExecute = false;//是否使用操作系统shell启动
				p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
				p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
				p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
				p.StartInfo.CreateNoWindow = true;//不显示程序窗口
				p.Start();//启动程序

				string strCMD = "";
				if (!string.IsNullOrEmpty(flag))
				{
					if (flag.Equals("i"))
					{
						strCMD = "\"" + @"C:\Program Files\Common Files\microsoft shared\VSTO\10.0\VSTOInstaller.exe" + "\" /i \"http://www.catarc.ac.cn/ppttools/static/update/publish/Auto PPTer.vsto\" /s";
					}
					else
					{
						strCMD = "\"" + @"C:\Program Files\Common Files\microsoft shared\VSTO\10.0\VSTOInstaller.exe" + "\" /i \"http://www.catarc.ac.cn/ppttools/static/update/publish/Auto PPTer.vsto\" /s";
					}
				}
				//向cmd窗口发送输入信息
				p.StandardInput.WriteLine(strCMD + "&exit");

				p.StandardInput.AutoFlush = true;

				//获取cmd窗口的输出信息
				string output = p.StandardOutput.ReadToEnd();
				//等待程序执行完退出进程
				p.WaitForExit();
				p.Close();
				ret = true;
			}
			catch (Exception ex)
			{
				ret = false;
			}
			return ret;
		}
		private static async Task<bool> GetServerVersion(String fileUrl)
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

		private static async Task<bool> GetChangeLog(String fileUrl)
		{
			UpdateLog.Clear();
			String filePath;
			IniDocument document = null;
			try
			{
                filePath = await Request.HttpDownload(fileUrl);
				document = new IniDocument(filePath);
				if(document != null)
				{

					IniKeyValue pair = document["setting"]["slogan"];
					String str = pair == null ? "" : pair.Value;
					UpdateLog.Add("slogan", str);
					pair = pair = document["setting"]["content"];
					str = pair == null ? "" : pair.Value;
					UpdateLog.Add("content", str);
					pair = document["update"]["sjh"];
					str = pair == null ? "" : pair.Value;
					UpdateLog.Add("sjhs", str);
				}
				return true;
			}
			catch
			{
				return false;
			}
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
