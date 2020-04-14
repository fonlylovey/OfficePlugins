namespace PPTPlugin
{
    partial class LoginWidget
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Layout1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_cancel = new WinForm.UI.Controls.CirclePictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.account_Layout = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lineEdit_account = new WinForm.UI.Controls.FTextBox();
            this.button_identCode = new WinForm.UI.Controls.FButton();
            this.ident_Layout = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lineEdit_identCode = new WinForm.UI.Controls.FTextBox();
            this.invite_Layout = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.lineEdit_inviteCode = new WinForm.UI.Controls.FTextBox();
            this.button_login = new WinForm.UI.Controls.FButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Layout1.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_cancel)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.account_Layout.SuspendLayout();
            this.ident_Layout.SuspendLayout();
            this.invite_Layout.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomTitle
            // 
            this.CustomTitle.Location = new System.Drawing.Point(1, 1);
            this.CustomTitle.Size = new System.Drawing.Size(290, 32);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PPTPlugin.Properties.Resources.Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(104, 42);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(104, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 42);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Layout1
            // 
            this.Layout1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Layout1.Controls.Add(this.flowLayoutPanel5);
            this.Layout1.Controls.Add(this.flowLayoutPanel1);
            this.Layout1.Controls.Add(this.account_Layout);
            this.Layout1.Controls.Add(this.ident_Layout);
            this.Layout1.Controls.Add(this.invite_Layout);
            this.Layout1.Controls.Add(this.button_login);
            this.Layout1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.Layout1.Location = new System.Drawing.Point(1, 1);
            this.Layout1.Margin = new System.Windows.Forms.Padding(0);
            this.Layout1.MaximumSize = new System.Drawing.Size(290, 430);
            this.Layout1.MinimumSize = new System.Drawing.Size(290, 430);
            this.Layout1.Name = "Layout1";
            this.Layout1.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.Layout1.Size = new System.Drawing.Size(290, 430);
            this.Layout1.TabIndex = 2;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.button_cancel);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(32, 0);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel5.MaximumSize = new System.Drawing.Size(245, 45);
            this.flowLayoutPanel5.MinimumSize = new System.Drawing.Size(245, 45);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(245, 45);
            this.flowLayoutPanel5.TabIndex = 5;
            // 
            // button_cancel
            // 
            this.button_cancel.Image = global::PPTPlugin.Properties.Resources.close;
            this.button_cancel.IsSelected = false;
            this.button_cancel.Location = new System.Drawing.Point(215, 0);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(0);
            this.button_cancel.MaximumSize = new System.Drawing.Size(30, 45);
            this.button_cancel.MinimumSize = new System.Drawing.Size(30, 45);
            this.button_cancel.MouseMoveImage = global::PPTPlugin.Properties.Resources.close_s;
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.SelectedImage = null;
            this.button_cancel.Size = new System.Drawing.Size(30, 45);
            this.button_cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.button_cancel.TabIndex = 0;
            this.button_cancel.TabStop = false;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(35, 48);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(245, 100);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(245, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(245, 100);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.label1.Location = new System.Drawing.Point(0, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.MaximumSize = new System.Drawing.Size(104, 28);
            this.label1.MinimumSize = new System.Drawing.Size(104, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "欢迎您登录";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // account_Layout
            // 
            this.account_Layout.Controls.Add(this.label2);
            this.account_Layout.Controls.Add(this.lineEdit_account);
            this.account_Layout.Controls.Add(this.button_identCode);
            this.account_Layout.Location = new System.Drawing.Point(32, 164);
            this.account_Layout.Margin = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.account_Layout.MaximumSize = new System.Drawing.Size(245, 40);
            this.account_Layout.MinimumSize = new System.Drawing.Size(245, 40);
            this.account_Layout.Name = "account_Layout";
            this.account_Layout.Size = new System.Drawing.Size(245, 40);
            this.account_Layout.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = global::PPTPlugin.Properties.Resources.icon1;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.MaximumSize = new System.Drawing.Size(24, 24);
            this.label2.MinimumSize = new System.Drawing.Size(24, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 24);
            this.label2.TabIndex = 6;
            // 
            // lineEdit_account
            // 
            this.lineEdit_account.HotColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(153)))), ((int)(((byte)(240)))));
            this.lineEdit_account.Location = new System.Drawing.Point(24, 0);
            this.lineEdit_account.Margin = new System.Windows.Forms.Padding(0);
            this.lineEdit_account.MaximumSize = new System.Drawing.Size(120, 22);
            this.lineEdit_account.MinimumSize = new System.Drawing.Size(120, 22);
            this.lineEdit_account.Name = "lineEdit_account";
            this.lineEdit_account.Size = new System.Drawing.Size(120, 23);
            this.lineEdit_account.TabIndex = 1;
            this.lineEdit_account.WatermarkText = "请输入手机号";
            this.lineEdit_account.WordWrap = false;
            // 
            // button_identCode
            // 
            this.button_identCode.BackColor = System.Drawing.Color.Transparent;
            this.button_identCode.BackgroundImage = global::PPTPlugin.Properties.Resources.yzm_btn;
            this.button_identCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_identCode.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_identCode.ForeColor = System.Drawing.Color.White;
            this.button_identCode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_identCode.Location = new System.Drawing.Point(144, 0);
            this.button_identCode.Margin = new System.Windows.Forms.Padding(0);
            this.button_identCode.MaximumSize = new System.Drawing.Size(70, 23);
            this.button_identCode.MinimumSize = new System.Drawing.Size(70, 23);
            this.button_identCode.mouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_identCode.Name = "button_identCode";
            this.button_identCode.Radius = 1;
            this.button_identCode.Size = new System.Drawing.Size(70, 23);
            this.button_identCode.TabIndex = 9;
            this.button_identCode.Click += new System.EventHandler(this.button_identCode_Click);
            // 
            // ident_Layout
            // 
            this.ident_Layout.Controls.Add(this.label3);
            this.ident_Layout.Controls.Add(this.lineEdit_identCode);
            this.ident_Layout.Location = new System.Drawing.Point(32, 207);
            this.ident_Layout.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.ident_Layout.MaximumSize = new System.Drawing.Size(245, 40);
            this.ident_Layout.MinimumSize = new System.Drawing.Size(245, 40);
            this.ident_Layout.Name = "ident_Layout";
            this.ident_Layout.Size = new System.Drawing.Size(245, 40);
            this.ident_Layout.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Image = global::PPTPlugin.Properties.Resources.icon3;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.MaximumSize = new System.Drawing.Size(24, 24);
            this.label3.MinimumSize = new System.Drawing.Size(24, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 24);
            this.label3.TabIndex = 9;
            // 
            // lineEdit_identCode
            // 
            this.lineEdit_identCode.HotColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(153)))), ((int)(((byte)(240)))));
            this.lineEdit_identCode.Location = new System.Drawing.Point(24, 0);
            this.lineEdit_identCode.Margin = new System.Windows.Forms.Padding(0);
            this.lineEdit_identCode.MaximumSize = new System.Drawing.Size(190, 22);
            this.lineEdit_identCode.MinimumSize = new System.Drawing.Size(190, 22);
            this.lineEdit_identCode.Name = "lineEdit_identCode";
            this.lineEdit_identCode.Size = new System.Drawing.Size(190, 23);
            this.lineEdit_identCode.TabIndex = 2;
            this.lineEdit_identCode.WatermarkText = "请输入验证码";
            this.lineEdit_identCode.WordWrap = false;
            // 
            // invite_Layout
            // 
            this.invite_Layout.Controls.Add(this.label5);
            this.invite_Layout.Controls.Add(this.lineEdit_inviteCode);
            this.invite_Layout.Location = new System.Drawing.Point(32, 247);
            this.invite_Layout.Margin = new System.Windows.Forms.Padding(0);
            this.invite_Layout.MaximumSize = new System.Drawing.Size(245, 40);
            this.invite_Layout.MinimumSize = new System.Drawing.Size(245, 40);
            this.invite_Layout.Name = "invite_Layout";
            this.invite_Layout.Size = new System.Drawing.Size(245, 40);
            this.invite_Layout.TabIndex = 11;
            this.invite_Layout.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Image = global::PPTPlugin.Properties.Resources.icon2;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.MaximumSize = new System.Drawing.Size(24, 24);
            this.label5.MinimumSize = new System.Drawing.Size(24, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 24);
            this.label5.TabIndex = 9;
            // 
            // lineEdit_inviteCode
            // 
            this.lineEdit_inviteCode.HotColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(153)))), ((int)(((byte)(240)))));
            this.lineEdit_inviteCode.Location = new System.Drawing.Point(24, 0);
            this.lineEdit_inviteCode.Margin = new System.Windows.Forms.Padding(0);
            this.lineEdit_inviteCode.MaximumSize = new System.Drawing.Size(190, 22);
            this.lineEdit_inviteCode.MinimumSize = new System.Drawing.Size(190, 22);
            this.lineEdit_inviteCode.Name = "lineEdit_inviteCode";
            this.lineEdit_inviteCode.Size = new System.Drawing.Size(190, 23);
            this.lineEdit_inviteCode.TabIndex = 3;
            this.lineEdit_inviteCode.WatermarkText = "请输入邀请码";
            this.lineEdit_inviteCode.WordWrap = false;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.Transparent;
            this.button_login.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.Image = global::PPTPlugin.Properties.Resources.login_btn;
            this.button_login.Location = new System.Drawing.Point(57, 312);
            this.button_login.Margin = new System.Windows.Forms.Padding(25, 25, 0, 0);
            this.button_login.MaximumSize = new System.Drawing.Size(186, 28);
            this.button_login.MinimumSize = new System.Drawing.Size(186, 28);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(186, 28);
            this.button_login.TabIndex = 4;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // LoginWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderWidth = 1;
            this.ClientSize = new System.Drawing.Size(292, 432);
            this.Controls.Add(this.Layout1);
            this.MaximumSize = new System.Drawing.Size(292, 432);
            this.MinimumSize = new System.Drawing.Size(292, 432);
            this.Name = "LoginWidget";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginWidget";
            this.TitleText = "登陆";
            this.TitleVisible = true;
            this.Controls.SetChildIndex(this.CustomTitle, 0);
            this.Controls.SetChildIndex(this.Layout1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Layout1.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.button_cancel)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.account_Layout.ResumeLayout(false);
            this.account_Layout.PerformLayout();
            this.ident_Layout.ResumeLayout(false);
            this.ident_Layout.PerformLayout();
            this.invite_Layout.ResumeLayout(false);
            this.invite_Layout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel Layout1;
        private System.Windows.Forms.FlowLayoutPanel ident_Layout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel account_Layout;
        private WinForm.UI.Controls.FTextBox lineEdit_account;
        private System.Windows.Forms.Label label3;
        private WinForm.UI.Controls.FTextBox lineEdit_identCode;
        private WinForm.UI.Controls.FButton button_login;
        private System.Windows.Forms.FlowLayoutPanel invite_Layout;
        private System.Windows.Forms.Label label5;
        private WinForm.UI.Controls.FTextBox lineEdit_inviteCode;
        private WinForm.UI.Controls.CirclePictureBox button_cancel;
        private WinForm.UI.Controls.FButton button_identCode;
    }
}