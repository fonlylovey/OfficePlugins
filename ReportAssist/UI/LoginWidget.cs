using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;
using CustomControls;
using Widgets;
using Newtonsoft.Json.Linq;

namespace PPTPlugin
{
    public partial class LoginWidget : CustomForm
    {
        private int userFlag = 0;
        public LoginWidget()
        {
            InitializeComponent();
        }

        private async void button_inviteCode_Click(object sender, EventArgs e)
        {
            

            if (!string.IsNullOrEmpty(lineEdit_account.Text))
            {
                try
                {
                    String strAPI = "http://xxw.autoinfo.org.cn/ppttools/user/getCode?sjh={0}";
                    strAPI = String.Format(strAPI, lineEdit_account.Text);
                    JObject obj = await Request.HttpGet(strAPI);
                    userFlag = obj.Value<int>("flag");
                    
                    if(userFlag == 0)//未注册
                    {
                        lineEdit_inviteCode.Visible = true;
                    }
                    else//2 出错
                    {
                        errorProvider.SetError(lineEdit_account, "手机号输入错误");
                    }
                }
                catch(Exception ex)
                {
                    PromptBox.Error(ex.Message);
                }
                
            }
        }

        private async void button_login_Click(object sender, EventArgs e)
        {
        
            { 
            String strAccount = "";
            String identCode = "";
            String inviteCode = "";
            if (string.IsNullOrEmpty(lineEdit_account.Text))
            {
                errorProvider.SetError(lineEdit_account, "手机号为空");
                return;
            }

            if (string.IsNullOrEmpty(lineEdit_identCode.Text))
            {
                errorProvider.SetError(lineEdit_identCode, "验证码为空");
                return;
            }
            strAccount = lineEdit_account.Text;
            identCode = lineEdit_identCode.Text;
            inviteCode = lineEdit_inviteCode.Text;
            String strMsg = "";
            try
            {
                //
                String strAPI = "http://xxw.autoinfo.org.cn/ppttools/user/checkUserLogin?sjh={0}&code={1}&yqm={2}";
                strAPI = String.Format(strAPI, strAccount, identCode, inviteCode);
                JObject obj = await Request.HttpGet(strAPI);
                int code = obj.Value<int>("code");
                strMsg = obj.Value<String>("msg");
                if (code == 200)
                {
                    strAPI = "http://xxw.autoinfo.org.cn/ppttools/if/getUserBySjh?sjh=";
                    strAPI = String.Format(strAPI, strAccount);
                    obj = await Request.HttpGet(strAPI);
                    code = obj.Value<int>("result");
                    strMsg = obj.Value<String>("msg");
                    if (code == 200)
                    {

                    }
                    else
                    {
                        PromptBox.Error(strMsg);
                    }
                }
                else
                {
                    PromptBox.Error(strMsg);
                }
            }
            catch (Exception ex)
            {
                PromptBox.Error(ex.Message);
            }
            }

            
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
