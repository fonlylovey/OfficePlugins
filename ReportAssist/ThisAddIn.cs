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
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            RightWidget = new DockWidget();
            TaskWidget = CustomTaskPanes.Add(RightWidget, "模板选择");
            TaskWidget.DockPosition =
            Office.MsoCTPDockPosition.msoCTPDockPositionRight;
            TaskWidget.Width = 260;
            TaskWidget.Visible = false;
            FormShower = new FormMgr(new IntPtr(this.Application.HWND));
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
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
