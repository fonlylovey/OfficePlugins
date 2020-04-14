using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;
using System.Threading.Tasks;
using Base;
using Core;
using Widgets;
using CustomControls;
using AutoUpdate;

namespace PPTPlugin
{
    public partial class RibbonMenu
    {
        readonly String StrUserName = "UserName";
        readonly String StrUserToken = "UserToken";

        private async void RibbonMenu_Load(object sender, RibbonUIEventArgs e)
        {
            ResetButtonEnable(false);
            await LoadUserInfo();
        }

        private async Task<bool> LoadUserInfo()
        {
            String strUserName = Regditer.GetValue(Regditer.RootKey.CurrentUser, Rigel.UserRegKey, StrUserName);
            if(!String.IsNullOrEmpty(strUserName))
            {
                String strUserToken = Regditer.GetValue(Regditer.RootKey.CurrentUser, Rigel.UserRegKey, StrUserToken);
                if(await RequestHandle.TokenValidity(strUserToken))
                {
                    Rigel.UserID = strUserName;
                    Rigel.UserName = strUserName;
                    Rigel.UserToken = strUserToken;
                    button_login.Label = Rigel.UserName;
                    ResetButtonEnable(true);
                    return true;
                }
                return false;
            }
            return false;
        }

        private async void button_login_Click(object sender, RibbonControlEventArgs e)
        {
            DialogResult result = DialogResult.None;
            if (String.IsNullOrEmpty(Rigel.UserID))
            {
                LoginWidget loginWidget = new LoginWidget();
                result = loginWidget.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if(String.IsNullOrEmpty(Rigel.UserID))
                    {
                        PromptBox.Error("登录失败！");
                        return;
                    }
                    else
                    {
                        Regditer.WriteReg(Regditer.RootKey.CurrentUser, Rigel.UserRegKey,
                        StrUserName, Rigel.UserName);
                        Regditer.WriteReg(Regditer.RootKey.CurrentUser, Rigel.UserRegKey,
                            StrUserToken, Rigel.UserToken);
                        button_login.Label = Rigel.UserName;
                        button_login.Image = Properties.Resources.Login;
                        ResetButtonEnable(true);
                    }
                }
            }
            else
            {
                result = PromptBox.Prompt("确认退出登录？");
                if (result == DialogResult.OK)
                {
                    await RequestHandle.Logout(Rigel.UserName);
                    Rigel.UserID = "";
                    Rigel.UserToken = "";
                    Regditer.WriteReg(Regditer.RootKey.CurrentUser, Rigel.UserRegKey,
                        StrUserToken, String.Empty);
                    button_login.Label = "登录\r\n";
                    button_login.Image = Properties.Resources.Logout;
                    ResetButtonEnable(false);
                }
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

        private void button_legend_Click(object sender, RibbonControlEventArgs e)
        {
            App.ResourceType = ResourceType.Legend;
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

        private void button_product_Click(object sender, RibbonControlEventArgs e)
        {
            App.ResourceType = ResourceType.Product;
            Globals.ThisAddIn.RightWidget.ResetPageCount();
            Globals.ThisAddIn.RightWidget.UpdateResourceList();
            Globals.ThisAddIn.RightWidget.ResetButton();
            Globals.ThisAddIn.TaskWidget.Visible = true;
        }

        private void button_predict_Click(object sender, RibbonControlEventArgs e)
        {
            App.ResourceType = ResourceType.Predict;
            Globals.ThisAddIn.RightWidget.ResetPageCount();
            Globals.ThisAddIn.RightWidget.UpdateResourceList();
            Globals.ThisAddIn.RightWidget.ResetButton();
            Globals.ThisAddIn.TaskWidget.Visible = true;
        }

        private void button_macro_Click(object sender, RibbonControlEventArgs e)
        {
            App.ResourceType = ResourceType.Macro;
            Globals.ThisAddIn.RightWidget.ResetPageCount();
            Globals.ThisAddIn.RightWidget.UpdateResourceList();
            Globals.ThisAddIn.RightWidget.ResetButton();
            Globals.ThisAddIn.TaskWidget.Visible = true;
        }

        private void button_about_Click(object sender, RibbonControlEventArgs e)
        {
            AboutWidget aboutWidget = new AboutWidget();
            DialogResult result = ThisAddIn.FormShower.ShowDialog(aboutWidget);
        }

        private void button_option_Click(object sender, RibbonControlEventArgs e)
        {
            UpdateWidget updateWidget = new UpdateWidget();
            updateWidget.setVersion(Rigel.PluginVersion, VSTOUpdater.ServerVersion);
            VSTOUpdater.UpdateLog.TryGetValue("slogan", out string slogan);
            VSTOUpdater.UpdateLog.TryGetValue("content", out string content);
            updateWidget.setInfo(slogan, content);
            updateWidget.setNeedUpdate(false);
            DialogResult result = ThisAddIn.FormShower.ShowDialog(updateWidget);
            if(result == DialogResult.OK)
            {
                VSTOUpdater.Update(); ;
            }
        }

        private void ResetButtonEnable(bool value)
        {
            //资源
            button_temp.Enabled = value;
            button_legend.Enabled = value;
            button_icon.Enabled = value;

            //数据
            button_market.Enabled = value;
            button_product.Enabled = value;
            button_predict.Enabled = value;
            button_macro.Enabled = value;

            //咨询
            button_policy.Enabled = value;
            button_enterprise.Enabled = false;
            button_carType.Enabled = false;
            button_technology.Enabled = false;
            //工具
            button_export.Enabled = false;
            button_zip.Enabled = false;
            button_share.Enabled = false;

            //更多
            button_about.Enabled = value;
            button_option.Enabled = value;
        }

        
    }

}
