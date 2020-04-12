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
using WinForm.UI.Controls;

namespace PPTPlugin
{
    public partial class LoginWidget : CustomForm
    {
        private FErrorProvider errorProvider;
        public LoginWidget()
        {
            InitializeComponent();
            errorProvider = new FErrorProvider();
            button_identCode.SetAnimating(false);
            lineEdit_account.Select();
        }

        private async void button_identCode_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lineEdit_account.Text))
            {
                try
                {
                    int userFlag = await RequestHandle.SendIdentCode(lineEdit_account.Text);
                    if (userFlag == 0)//未注册
                    {
                        inviteLayout.Visible = true;
                    }
                    else if(userFlag == 1)
                    {
                        //none
                    }
                    else//2 出错
                    {
                        errorProvider.ErrorAlignment = ErrorAlignment.Top;
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

            String strAccount = "";
            String identCode = "";
            String inviteCode = "";
            if (string.IsNullOrEmpty(lineEdit_account.Text))
            {
                errorProvider.ErrorAlignment = ErrorAlignment.Top;
                errorProvider.SetError(flowLayoutPanel6, "手机号为空");
                return;
            }

            if (string.IsNullOrEmpty(lineEdit_identCode.Text))
            {
                errorProvider.ErrorAlignment = ErrorAlignment.Top;
                errorProvider.SetError(flowLayoutPanel3, "验证码为空");
                return;
            }
            strAccount = lineEdit_account.Text;
            identCode = lineEdit_identCode.Text;
            inviteCode = lineEdit_inviteCode.Text;
            try
            {
                bool isLogin = await RequestHandle.Login(strAccount, identCode, inviteCode);
                if (isLogin)
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                PromptBox.Error(ex.Message);
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
