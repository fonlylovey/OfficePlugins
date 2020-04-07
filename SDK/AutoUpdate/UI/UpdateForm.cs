using System;
using System.Drawing;
using BIM.Base;
using BIM.Controls;
using System.IO;
using BIM.Widget;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BIM.AutoUpdate
{
	public partial class UpdateForm : CustomForm
	{
		public UpdateForm()
		{
			InitializeComponent();
			if (BIM5D.AppType == PluginType.MS_Word)
			{
				button_OK.ImageIndex = 3;
			}
			else if (BIM5D.AppType == PluginType.MS_Project)
			{
				button_OK.ImageIndex = 2;
			}
			else if (BIM5D.AppType == PluginType.MS_PowerPoint)
			{
				button_OK.ImageIndex = 1;
			}
            else if (BIM5D.AppType == PluginType.MS_Excel)
            {
                button_OK.ImageIndex = 4;
            }
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            if (BIM5D.PluginVersion == ServerVersion)
            {
                button_OK.Enabled = false;
            }
        }

        public void SetNeedUpdate(bool isUpdate)
		{
			button_OK.Enabled = isUpdate;
		}

		public void SetCurrentVersion(String strVersion)
		{
			String strInfo = "当前版本：" + strVersion;
			label_CurrentVersion.Text = strInfo;
		}

		public void SetServerVersion(String strVersion)
		{
			ServerVersion = strVersion;
			String strInfo = "最新版本：" + strVersion;
			label_ServerVersion.Text = strInfo;
		}

		public void SetDescription(String strDesc)
		{
			textBox_Description.Text = strDesc;
			textBox_Description.SelectedText = "";
		}

		public void SetChangeLog(String strLog)
		{
			String strTitle = "版本号：" + ServerVersion + "\r\n";
			TextBox_ChangeLog.Text = strTitle + strLog;
			TextBox_ChangeLog.Find(strTitle);
			string strFont = "Microsoft YaHei UI";
			TextBox_ChangeLog.SelectionFont = new Font(strFont, 10.5f, FontStyle.Bold);
		}

        public bool UpdatePlugin()
        {
            String strSourceVSTO = BIM5D.BIMTempPath;
            String strTargetVSTO = BIM5D.PluginDir;
            String strInstaller = BIM5D.PluginDir + "10.0\\VSTOInstaller.exe";

            try
            {
                String strPath = "";
                if (BIM5D.AppType == PluginType.MS_Word)
                {
                    strPath = BIM5D.UpdateUrl + "BIMWordPlugin.vsto";
                    strSourceVSTO += "BIMWordPlugin.vsto";
                    strTargetVSTO += "Plugins\\BIMWordPlugin.vsto";
                }
                else if (BIM5D.AppType == PluginType.MS_Project)
                {
                    strPath = BIM5D.UpdateUrl + "BIMProjectPlugin.vsto";
                    strSourceVSTO += "BIMProjectPlugin.vsto";
                    strTargetVSTO += "Plugins\\BIMProjectPlugin.vsto";
                }
                else if (BIM5D.AppType == PluginType.MS_PowerPoint)
                {
                    strPath = BIM5D.UpdateUrl + "BIMPPTPlugin.vsto";
                    strSourceVSTO += "BIMPPTPlugin.vsto";
                    strTargetVSTO += "Plugins\\BIMPPTPlugin.vsto";
                }
                else if (BIM5D.AppType == PluginType.MS_Excel)
                {
                    strPath = BIM5D.UpdateUrl + "BIMExcelPlugin.vsto";
                    strSourceVSTO += "BIMExcelPlugin.vsto";
                    strTargetVSTO += "Plugins\\BIMExcelPlugin.vsto";
                }

                if (File.Exists(strInstaller))
                {
                    System.Diagnostics.Process.Start(strInstaller, " /i " + strPath).WaitForExit();
                    //更新成功把最新的vsto文件拷贝到安装目录
                    if (File.Exists(strSourceVSTO) && File.Exists(strTargetVSTO))
                    {
                        //判断是否被占用
                        if (!BIMAPI.IsUsing(strTargetVSTO))
                        {
                            File.Delete(strTargetVSTO);    //存在则删除
                        }
                        FileInfo fi = new FileInfo(strSourceVSTO);
                        fi.MoveTo(strTargetVSTO);
                    }
                    return true;
                }
                else
                {
                    Logger.LogError("没有找到升级文件：" + strTargetVSTO);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Logger.LogError(ex.ToString());
                return false;
            }
        }

        public static async Task<bool> UninstallPlugin()
        {
            String strUninstall = BIM5D.UpdateUrl + "UninstallVSTO.bat";
            String strPath = "";
            //下载云端卸载脚本
            try
            {
                strPath = await Request.HttpDownload(strUninstall);
                if (!string.IsNullOrEmpty(strPath))
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo(strPath);
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
                return false;
            }
            catch
            {
                Logger.LogError("卸载老插件失败！");
                return false;
            }
            finally
            {
                System.IO.File.Delete(strPath);
            }
        }

        private String ServerVersion = "";

		private async void button_OK_Click(object sender, EventArgs e)
		{
			 await UninstallPlugin();

			if (UpdatePlugin())
			{
                System.Windows.Forms.DialogResult result = PromptBox.Prompt("更新完成，请点击确定之后重新启动软件。");
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    System.Environment.Exit(0);
                }
            }
			else
			{
				PromptBox.Prompt("非常抱歉更新失败，请联系工作人员！");
			}
        }

		private void button_Cancel_Click(object sender, EventArgs e)
		{
            Close();
		}
    }
}
