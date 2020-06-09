using System;
using System.Collections.Generic;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools;
using Core;
using CustomControls;
using AutoUpdate;
using System.Windows.Forms;
using System.Deployment.Application;
using Base;
using Widgets;
using System.Net.NetworkInformation;
using System.Diagnostics;

namespace PPTPlugin
{
    public partial class ThisAddIn
    {
        public CustomTaskPane TaskWidget = null;
        public DockWidget RightWidget = null;
        static public FormMgr FormShower = null;
        static public PowerPoint.Presentation CurrentPPT = null;
        public Dictionary<PowerPoint.DocumentWindow, CustomTaskPane> TaskPaneDict = null;
        private async void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            TaskPaneDict = new Dictionary<PowerPoint.DocumentWindow, CustomTaskPane>();
            Rigel.PluginDir = Regditer.GetValue(Regditer.RootKey.CurrentUser, Rigel.UserRegKey, "InstallPath");
            Rigel.UserName = Regditer.GetValue(Regditer.RootKey.CurrentUser, Rigel.UserRegKey, "UserName");
            Rigel.UserToken = Regditer.GetValue(Regditer.RootKey.CurrentUser, Rigel.UserRegKey, "UserToken");
            /*if(String.IsNullOrEmpty(Rigel.PluginDir))
            {
                PromptBox.Error("没有找到安装目录！");
            }*/
            //Rigel.PluginDir += "/";
            Rigel.InitWorkConfig();
            FormShower = new FormMgr(new IntPtr(this.Application.HWND));
            App.ResourceType = ResourceType.None;
            this.Application.WindowActivate += WindowActivate_Event;

            Rigel.PluginVersion = "1.0.0.25";
            var aaaa = System.Reflection.Assembly.GetExecutingAssembly();

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                try {
                    ApplicationDeployment applicationDeployment = ApplicationDeployment.CurrentDeployment;
                    Logger.LogInfo("UpdatedVersion:" + applicationDeployment.UpdatedVersion.ToString());
                    Logger.LogInfo("CurrentVersion" + applicationDeployment.CurrentVersion.ToString());
                    Rigel.PluginVersion = applicationDeployment.CurrentVersion.ToString();

                }
                catch(Exception ex)
                {
                    Console.WriteLine( ex.Message);
                }
                
            }
            VSTOUpdater.CheckUpdate().Wait();
            
            
            /*if (VSTOUpdater.NeedUpdate)
            {
                UpdateWidget updateWidget = new UpdateWidget();
                updateWidget.setNeedUpdate(VSTOUpdater.NeedUpdate);
                updateWidget.setVersion(Rigel.PluginVersion, VSTOUpdater.ServerVersion);
                VSTOUpdater.UpdateLog.TryGetValue("slogan", out string slogan);
                VSTOUpdater.UpdateLog.TryGetValue("content", out string content);
                updateWidget.setInfo(slogan, content);
                DialogResult result = ThisAddIn.FormShower.ShowDialog(updateWidget);
                if (result == DialogResult.OK)
                {
                    VSTOUpdater.Update(); ;
                }
            }*/
        }

        public String getTypeName(ResourceType type)
        {
            String strName = "模板";
            switch(type)
            {
                case ResourceType.Template:
                    strName = "模板";
                    break;
                case ResourceType.Icon:
                    strName = "图标";
                    break;
                case ResourceType.Legend:
                    strName = "图例";
                    break;
                case ResourceType.Market:
                    strName = "市场";
                    break;
                case ResourceType.Policy:
                    strName = "政策";
                    break;
                case ResourceType.Product:
                    strName = "产品";
                    break;
                case ResourceType.Predict:
                    strName = "预测";
                    break;
                case ResourceType.Macro:
                    strName = "宏观";
                    break;
                case ResourceType.Upload_icon:
                    strName = "我的图标";
                    break;
                case ResourceType.Upload_legend:
                    strName = "我的图例";
                    break;
                case ResourceType.Upload_template:
                    strName = "我的资源";
                    break;
                case ResourceType.Enterprise:
                    strName = "企业";
                    break;
                case ResourceType.Technology:
                    strName = "技术";
                    break;
                default:
                    strName = "模板";
                    break;
                //case ResourceType.Icon:
                //    strName = "图标";
                //    break;
                //case ResourceType.Icon:
                //    strName = "图标";
                //    break;

            }

            return strName;
        }

        public bool PingNetAddress(string strNetAdd)
        {
            bool Flage = false;
            Ping ping = new Ping();
            try
            {
                PingReply pr = ping.Send(strNetAdd, 3000);
                if (pr.Status == IPStatus.TimedOut)
                {
                    Flage = false;
                }
                if (pr.Status == IPStatus.Success)
                {
                    Flage = true;
                }
                else
                {
                    Flage = false;
                }
            }
            catch
            {
                Flage = false;
            }
            return Flage;
        }
        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }


        private void WindowActivate_Event(PowerPoint.Presentation Pres, PowerPoint.DocumentWindow Wn)
        {
            ResetSidebar();
        }
        
        public void ResetSidebar()
        {
            try
            {
                if (TaskWidget != null)
                {
                    CustomTaskPanes.Remove(TaskWidget);
                }
                RightWidget = new DockWidget();
                TaskWidget = CustomTaskPanes.Add(RightWidget, getTypeName(App.ResourceType) + "库");
                TaskWidget.DockPosition =
                Office.MsoCTPDockPosition.msoCTPDockPositionRight;
                //int SH = Screen.PrimaryScreen.Bounds.Height;
                int SW = Screen.PrimaryScreen.Bounds.Width;
                int widths = 260;
                if (SW > 1600)
                {
                    widths = 320;
                }
                TaskWidget.Width = widths;

                if (App.ResourceType != ResourceType.None)
                {
                    RightWidget.ResetPageCount();
                    RightWidget.UpdateResourceList();
                    RightWidget.ResetButton();
                    TaskWidget.Visible = true;
                }
                else
                {
                    TaskWidget.Visible = false;
                }
            }
            catch
            {

            }
        }

       

        #region VSTO 生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
