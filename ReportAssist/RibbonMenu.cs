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
                if (result == DialogResult.OK && String.IsNullOrEmpty(Rigel.UserID))
                {
                    PromptBox.Error("登陆失败！");
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
                    button_login.Label = "登陆";
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

        private void button_option_Click(object sender, RibbonControlEventArgs e)
        {
            UpdateWidget updateWidget = new UpdateWidget();
            DialogResult result = ThisAddIn.FormShower.ShowDialog(updateWidget);
            if(result == DialogResult.OK)
            {
                
            }
        }

        private void ResetButtonEnable(bool value)
        {
            //资源
            button_temp.Enabled = value;
            button_sign.Enabled = value;
            button_icon.Enabled = value;

            //数据
            button_market.Enabled = value;
            button_product.Enabled = value;
            button_predict.Enabled = value;
            button_mocro.Enabled = value;

            //咨询
            button_policy.Enabled = value;
            button_enterprise.Enabled = value;
            button_carType.Enabled = value;
            button_technology.Enabled = value;
            //工具
            button_export.Enabled = value;
            button_zip.Enabled = value;
            button_share.Enabled = value;

            //更多
            button_about.Enabled = value;
            button_option.Enabled = value;
        }
    }

}
