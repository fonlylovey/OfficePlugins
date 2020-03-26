using System;
using Microsoft.Win32;
using Base;
using Core;
using CustomControls;


namespace Widgets
{
    public partial class LoginWidget : CustomForm
	{
        public LoginWidget()
        {
            InitializeComponent();
			userNameBox.AutoSize = false;
			passWordBox.AutoSize = false;
		}

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(userNameBox.Text))
            {
                errorProvider1.SetError(userNameBox, "用户名不能为空!");
            }
            else if(String.IsNullOrEmpty(userNameBox.Text) &&
				userNameBox.Text.Length < 3)
            {
                errorProvider1.SetError(userNameBox,"不得少于三位！");
            }
            else
            {
                errorProvider1.Clear();
            }
         }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(passWordBox.Text))
            {
                errorProvider2.SetError(passWordBox, "不能为空!");
            }
            else if(passWordBox.Text.Length < 3)
            {
                errorProvider2.SetError(passWordBox, "不得少于三位！");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            var userName = userNameBox.Text;
            var passWord = passWordBox.Text.Trim();

            if (String.IsNullOrEmpty(userName))
            {
                errorProvider1.SetError(userNameBox, "用户名不能为空!");
                return;
            }
            
            if(String.IsNullOrEmpty(passWord))
            {
                errorProvider2.SetError(passWordBox, "不能为空!");
                return;
            }

			bool isLogin = false;
			try
			{
                isLogin = Request.HttpLogin(userName, passWord);
			}
			catch (Exception ex) 
			{
                Logger.LogError(ex.ToString());
				PromptBox.Error(ex.Message);
				return;
			}
            
            if(isLogin)
            {
				this.Close();
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

		private void checkPassword_CheckedChanged(object sender, EventArgs e)
		{
			if (checkPassword.Checked)
			{
				checkPassword.Image = Properties.Resources.checked_true;
			}
			else
			{
				checkPassword.Image = Properties.Resources.checked_false;
			}
		}
	}
}
