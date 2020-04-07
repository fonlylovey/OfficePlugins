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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lineEdit_account = new CustomControls.LineEdit(this.components);
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lineEdit_identCode = new CustomControls.LineEdit(this.components);
            this.button_inviteCode = new System.Windows.Forms.Button();
            this.lineEdit_inviteCode = new CustomControls.LineEdit(this.components);
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_login = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::PPTPlugin.Properties.Resources.Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(252, 202);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(252, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 202);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 32);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(555, 202);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lineEdit_account);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Controls.Add(this.lineEdit_inviteCode);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(254, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(36, 20, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(300, 202);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // lineEdit_account
            // 
            this.lineEdit_account.BackColor = System.Drawing.Color.White;
            this.lineEdit_account.Location = new System.Drawing.Point(36, 29);
            this.lineEdit_account.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.lineEdit_account.MaximumSize = new System.Drawing.Size(226, 26);
            this.lineEdit_account.MinimumSize = new System.Drawing.Size(226, 26);
            this.lineEdit_account.Name = "lineEdit_account";
            this.lineEdit_account.PlaceHolderText = "请输入手机号";
            this.lineEdit_account.Size = new System.Drawing.Size(226, 26);
            this.lineEdit_account.TabIndex = 6;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.lineEdit_identCode);
            this.flowLayoutPanel3.Controls.Add(this.button_inviteCode);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(36, 64);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.flowLayoutPanel3.MaximumSize = new System.Drawing.Size(226, 26);
            this.flowLayoutPanel3.MinimumSize = new System.Drawing.Size(226, 32);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(226, 32);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // lineEdit_identCode
            // 
            this.lineEdit_identCode.Location = new System.Drawing.Point(0, 0);
            this.lineEdit_identCode.Margin = new System.Windows.Forms.Padding(0);
            this.lineEdit_identCode.MinimumSize = new System.Drawing.Size(100, 26);
            this.lineEdit_identCode.Name = "lineEdit_identCode";
            this.lineEdit_identCode.PlaceHolderText = "请输入短信验证码";
            this.lineEdit_identCode.Size = new System.Drawing.Size(124, 26);
            this.lineEdit_identCode.TabIndex = 2;
            // 
            // button_inviteCode
            // 
            this.button_inviteCode.Location = new System.Drawing.Point(136, 0);
            this.button_inviteCode.Margin = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button_inviteCode.MinimumSize = new System.Drawing.Size(0, 26);
            this.button_inviteCode.Name = "button_inviteCode";
            this.button_inviteCode.Size = new System.Drawing.Size(80, 26);
            this.button_inviteCode.TabIndex = 1;
            this.button_inviteCode.Text = "获取验证码";
            this.button_inviteCode.UseVisualStyleBackColor = true;
            this.button_inviteCode.Click += new System.EventHandler(this.button_inviteCode_Click);
            // 
            // lineEdit_inviteCode
            // 
            this.lineEdit_inviteCode.Location = new System.Drawing.Point(36, 105);
            this.lineEdit_inviteCode.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.lineEdit_inviteCode.MaximumSize = new System.Drawing.Size(226, 26);
            this.lineEdit_inviteCode.MinimumSize = new System.Drawing.Size(226, 26);
            this.lineEdit_inviteCode.Name = "lineEdit_inviteCode";
            this.lineEdit_inviteCode.PlaceHolderText = "请输入邀请码";
            this.lineEdit_inviteCode.Size = new System.Drawing.Size(226, 26);
            this.lineEdit_inviteCode.TabIndex = 7;
            this.lineEdit_inviteCode.Visible = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.button_cancel);
            this.flowLayoutPanel4.Controls.Add(this.button_login);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(36, 140);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.flowLayoutPanel4.MaximumSize = new System.Drawing.Size(226, 26);
            this.flowLayoutPanel4.MinimumSize = new System.Drawing.Size(226, 32);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(226, 32);
            this.flowLayoutPanel4.TabIndex = 5;
            // 
            // button_cancel
            // 
            this.button_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_cancel.Location = new System.Drawing.Point(151, 0);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.button_cancel.MinimumSize = new System.Drawing.Size(0, 26);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 26);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "取消";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(67, 0);
            this.button_login.Margin = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.button_login.MinimumSize = new System.Drawing.Size(0, 26);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 26);
            this.button_login.TabIndex = 3;
            this.button_login.Text = "登陆";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // LoginWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderWidth = 1;
            this.ClientSize = new System.Drawing.Size(557, 235);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(552, 234);
            this.Name = "LoginWidget";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginWidget";
            this.TitleText = "登陆";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button button_inviteCode;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_cancel;
        private CustomControls.LineEdit lineEdit_identCode;
        private CustomControls.LineEdit lineEdit_account;
        private CustomControls.LineEdit lineEdit_inviteCode;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}