﻿using System;
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
                    int userFlag = await RequestHandle.SendIdentCode(lineEdit_account.Text);
                    if (userFlag == 0)//未注册
                    {
                        lineEdit_inviteCode.Visible = true;
                    }
                    else if(userFlag == 1)
                    {
                        //none
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

           bool isLogin =  await RequestHandle.Login(strAccount, identCode, inviteCode);
           if (isLogin)
           {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}