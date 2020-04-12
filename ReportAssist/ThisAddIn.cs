using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools;
using Core;
using CustomControls;

namespace PPTPlugin
{
    public partial class ThisAddIn
    {
        public CustomTaskPane TaskWidget = null;
        public DockWidget RightWidget = null;
        static public FormMgr FormShower = null;
        public Dictionary<PowerPoint.DocumentWindow, CustomTaskPane> TaskPaneDict = null;
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            TaskPaneDict = new Dictionary<PowerPoint.DocumentWindow, CustomTaskPane>();
            //RightWidget = new DockWidget();
            //TaskWidget = CustomTaskPanes.Add(RightWidget, "模板选择");
            //TaskWidget.DockPosition =
            //Office.MsoCTPDockPosition.msoCTPDockPositionRight;
            //TaskWidget.Width = 260;
            //TaskWidget.Visible = true;
            //TaskWidget = CustomTaskPanes.Add(RightWidget, "模板选择");
            FormShower = new FormMgr(new IntPtr(this.Application.HWND));
            Rigel.ServerUrl = "http://114.115.234.131";
            App.ResourceType = ResourceType.None;
            this.Application.WindowActivate += WindowActivate_Event;
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }


        private void WindowActivate_Event(PowerPoint.Presentation Pres, PowerPoint.DocumentWindow Wn)
        {
            try
            {
                if (TaskWidget != null)
                {
                    CustomTaskPanes.Remove(TaskWidget);
                }
                RightWidget = new DockWidget();
                TaskWidget = CustomTaskPanes.Add(RightWidget, "模板选择");
                TaskWidget.DockPosition =
                Office.MsoCTPDockPosition.msoCTPDockPositionRight;
                TaskWidget.Width = 260;
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
