using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Base;
using Core;
using Newtonsoft.Json.Linq;
using Widgets;
using System.Windows.Forms;

namespace PPTPlugin
{
    public partial class RibbonMenu
    {
        private void RibbonMenu_Load(object sender, RibbonUIEventArgs e)
        {
            
        }

        private async void button_login_Click(object sender, RibbonControlEventArgs e)
        {
            LoginWidget loginWidget = new LoginWidget();
            DialogResult result = loginWidget.ShowDialog();
            if(result == DialogResult.OK && String.IsNullOrEmpty(Rigel.UserID))
            {
                PromptBox.Error("登陆失败！");
            }

            {

                String strAPI = "http://xxw.autoinfo.org.cn/ppttools/user/logout?sjh={0}";
                strAPI = String.Format(strAPI, "18800174194");
                JObject obj = await Request.HttpGet(strAPI);
                int code = obj.Value<int>("code");
            }
        }

        private void button_temp_Click(object sender, RibbonControlEventArgs e)
        {
            App.ResourceType = ResourceType.Template;
            Globals.ThisAddIn.RightWidget.ResetPageCount();
            Globals.ThisAddIn.RightWidget.UpdateResourceList();
            Globals.ThisAddIn.RightWidget.ResetButton();
            Globals.ThisAddIn.TaskWidget.Visible = true;
        }

        private void button_sign_Click(object sender, RibbonControlEventArgs e)
        {
            App.ResourceType = ResourceType.legend;
            Globals.ThisAddIn.RightWidget.ResetPageCount();
            Globals.ThisAddIn.RightWidget.UpdateResourceList();
            Globals.ThisAddIn.RightWidget.ResetButton();
            Globals.ThisAddIn.TaskWidget.Visible = true;
        }

        private void button_icon_Click(object sender, RibbonControlEventArgs e)
        {
            App.ResourceType = ResourceType.Icon;
            Globals.ThisAddIn.RightWidget.ResetPageCount();
            Globals.ThisAddIn.RightWidget.UpdateResourceList();
            Globals.ThisAddIn.RightWidget.ResetButton();
            Globals.ThisAddIn.TaskWidget.Visible = true;
        }

        private void button_label_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void button_market_Click(object sender, RibbonControlEventArgs e)
        {
            App.ResourceType = ResourceType.Market;
            Globals.ThisAddIn.RightWidget.ResetPageCount();
            Globals.ThisAddIn.RightWidget.UpdateResourceList();
            Globals.ThisAddIn.RightWidget.ResetButton();
            Globals.ThisAddIn.TaskWidget.Visible = true;
        }

        private void button_policy_Click(object sender, RibbonControlEventArgs e)
        {
            App.ResourceType = ResourceType.Policy;
            Globals.ThisAddIn.RightWidget.ResetPageCount();
            Globals.ThisAddIn.RightWidget.UpdateResourceList();
            Globals.ThisAddIn.RightWidget.ResetButton();
            Globals.ThisAddIn.TaskWidget.Visible = true;
        }
    }
}
