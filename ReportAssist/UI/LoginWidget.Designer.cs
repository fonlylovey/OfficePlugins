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
            this.inviteLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_cancel = new WinForm.UI.Controls.CirclePictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lineEdit_account = new WinForm.UI.Controls.FTextBox();
            this.button_identCode = new WinForm.UI.Controls.FButton();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lineEdit_identCode = new WinForm.UI.Controls.FTextBox();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.lineEdit_inviteCode = new WinForm.UI.Controls.FTextBox();
            this.button_login = new WinForm.UI.Controls.FButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.inviteLayout.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_cancel)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
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
            // inviteLayout
            // 
            this.inviteLayout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inviteLayout.Controls.Add(this.flowLayoutPanel5);
            this.inviteLayout.Controls.Add(this.flowLayoutPanel1);
            this.inviteLayout.Controls.Add(this.flowLayoutPanel6);
            this.inviteLayout.Controls.Add(this.flowLayoutPanel3);
            this.inviteLayout.Controls.Add(this.flowLayoutPanel8);
            this.inviteLayout.Controls.Add(this.button_login);
            this.inviteLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.inviteLayout.Location = new System.Drawing.Point(1, 1);
            this.inviteLayout.Margin = new System.Windows.Forms.Padding(0);
            this.inviteLayout.MaximumSize = new System.Drawing.Size(290, 430);
            this.inviteLayout.MinimumSize = new System.Drawing.Size(290, 430);
            this.inviteLayout.Name = "inviteLayout";
            this.inviteLayout.Padding = new System.Windows.Forms.Padding(32, 0, 0, 0);
            this.inviteLayout.Size = new System.Drawing.Size(290, 430);
            this.inviteLayout.TabIndex = 2;
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
            this.label1.Text = "欢迎您登陆";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label2);
            this.flowLayoutPanel6.Controls.Add(this.lineEdit_account);
            this.flowLayoutPanel6.Controls.Add(this.button_identCode);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(32, 164);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.flowLayoutPanel6.MaximumSize = new System.Drawing.Size(245, 40);
            this.flowLayoutPanel6.MinimumSize = new System.Drawing.Size(245, 40);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(245, 40);
            this.flowLayoutPanel6.TabIndex = 7;
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
            this.lineEdit_account.Size = new System.Drawing.Size(120, 22);
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
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.lineEdit_identCode);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(32, 207);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.flowLayoutPanel3.MaximumSize = new System.Drawing.Size(245, 40);
            this.flowLayoutPanel3.MinimumSize = new System.Drawing.Size(245, 40);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(245, 40);
            this.flowLayoutPanel3.TabIndex = 0;
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
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(this.label5);
            this.flowLayoutPanel8.Controls.Add(this.lineEdit_inviteCode);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(32, 247);
            this.flowLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel8.MaximumSize = new System.Drawing.Size(245, 40);
            this.flowLayoutPanel8.MinimumSize = new System.Drawing.Size(245, 40);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(245, 40);
            this.flowLayoutPanel8.TabIndex = 11;
            this.flowLayoutPanel8.Visible = false;
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
            this.Controls.Add(this.inviteLayout);
            this.MaximumSize = new System.Drawing.Size(292, 432);
            this.MinimumSize = new System.Drawing.Size(292, 432);
            this.Name = "LoginWidget";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginWidget";
            this.TitleText = "登陆";
            this.TitleVisible = true;
            this.Controls.SetChildIndex(this.CustomTitle, 0);
            this.Controls.SetChildIndex(this.inviteLayout, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.inviteLayout.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.button_cancel)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel inviteLayout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private WinForm.UI.Controls.FTextBox lineEdit_account;
        private System.Windows.Forms.Label label3;
        private WinForm.UI.Controls.FTextBox lineEdit_identCode;
        private WinForm.UI.Controls.FButton button_login;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
        private System.Windows.Forms.Label label5;
        private WinForm.UI.Controls.FTextBox lineEdit_inviteCode;
        private WinForm.UI.Controls.CirclePictureBox button_cancel;
        private WinForm.UI.Controls.FButton button_identCode;
    }
}