namespace Widgets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWidget));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passWordBox = new System.Windows.Forms.TextBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.checkPassword = new System.Windows.Forms.CheckBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label1.Location = new System.Drawing.Point(40, 62);
            this.label1.MaximumSize = new System.Drawing.Size(52, 32);
            this.label1.MinimumSize = new System.Drawing.Size(48, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(40, 106);
            this.label2.MaximumSize = new System.Drawing.Size(52, 32);
            this.label2.MinimumSize = new System.Drawing.Size(48, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // passWordBox
            // 
            this.passWordBox.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passWordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.passWordBox.Location = new System.Drawing.Point(94, 106);
            this.passWordBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.passWordBox.MaximumSize = new System.Drawing.Size(330, 32);
            this.passWordBox.MinimumSize = new System.Drawing.Size(330, 32);
            this.passWordBox.Name = "passWordBox";
            this.passWordBox.PasswordChar = '*';
            this.passWordBox.Size = new System.Drawing.Size(330, 26);
            this.passWordBox.TabIndex = 4;
            this.passWordBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "button.png");
            this.imageList.Images.SetKeyName(1, "button_ppt.png");
            this.imageList.Images.SetKeyName(2, "button_pro.png");
            this.imageList.Images.SetKeyName(3, "button_word.png");
            this.imageList.Images.SetKeyName(4, "button_excel.png");
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // userNameBox
            // 
            this.userNameBox.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.userNameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.userNameBox.Location = new System.Drawing.Point(94, 62);
            this.userNameBox.Margin = new System.Windows.Forms.Padding(0);
            this.userNameBox.MaximumSize = new System.Drawing.Size(330, 32);
            this.userNameBox.MinimumSize = new System.Drawing.Size(330, 32);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(330, 26);
            this.userNameBox.TabIndex = 3;
            this.userNameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_Login
            // 
            this.button_Login.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Login.BackColor = System.Drawing.Color.Transparent;
            this.button_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Login.FlatAppearance.BorderSize = 0;
            this.button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Login.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Login.ForeColor = System.Drawing.Color.White;
            this.button_Login.ImageList = this.imageList;
            this.button_Login.Location = new System.Drawing.Point(313, 166);
            this.button_Login.MaximumSize = new System.Drawing.Size(67, 31);
            this.button_Login.MinimumSize = new System.Drawing.Size(67, 31);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(67, 31);
            this.button_Login.TabIndex = 11;
            this.button_Login.Text = "登 录";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // checkPassword
            // 
            this.checkPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkPassword.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkPassword.AutoSize = true;
            this.checkPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.checkPassword.Checked = true;
            this.checkPassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPassword.FlatAppearance.BorderSize = 0;
            this.checkPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.checkPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.checkPassword.Image = ((System.Drawing.Image)(resources.GetObject("checkPassword.Image")));
            this.checkPassword.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.checkPassword.Location = new System.Drawing.Point(94, 166);
            this.checkPassword.Name = "checkPassword";
            this.checkPassword.Size = new System.Drawing.Size(150, 27);
            this.checkPassword.TabIndex = 10;
            this.checkPassword.Text = "  记住当前用户名密码";
            this.checkPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.checkPassword.UseVisualStyleBackColor = false;
            this.checkPassword.CheckedChanged += new System.EventHandler(this.checkPassword_CheckedChanged);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.button_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Cancel.FlatAppearance.BorderSize = 0;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_Cancel.ImageIndex = 0;
            this.button_Cancel.ImageList = this.imageList;
            this.button_Cancel.Location = new System.Drawing.Point(392, 166);
            this.button_Cancel.MaximumSize = new System.Drawing.Size(67, 31);
            this.button_Cancel.MinimumSize = new System.Drawing.Size(67, 31);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(67, 31);
            this.button_Cancel.TabIndex = 6;
            this.button_Cancel.Text = "取 消";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // LoginWidget
            // 
            this.AcceptButton = this.button_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(480, 210);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.checkPassword);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.passWordBox);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 210);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(480, 210);
            this.Name = "LoginWidget";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.TitleText = "登录";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Shown += new System.EventHandler(this.LoginForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox passWordBox;
		private System.Windows.Forms.Button button_Cancel;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.ErrorProvider errorProvider2;
		private System.Windows.Forms.CheckBox checkPassword;
		private System.Windows.Forms.TextBox userNameBox;
		private System.Windows.Forms.Button button_Login;
		private System.Windows.Forms.ImageList imageList;
	}
}