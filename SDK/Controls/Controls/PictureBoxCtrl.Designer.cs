namespace Controls
{
	partial class PictureBoxCtrl
	{
		/// <summary> 
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 组件设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.checkPicture = new System.Windows.Forms.CheckBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // checkPicture
            // 
            this.checkPicture.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.checkPicture.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkPicture.AutoCheck = false;
            this.checkPicture.BackColor = System.Drawing.Color.Transparent;
            this.checkPicture.BackgroundImage = global::Controls.Properties.Resources.checked_false;
            this.checkPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkPicture.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkPicture.FlatAppearance.BorderSize = 0;
            this.checkPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkPicture.Location = new System.Drawing.Point(6, 5);
            this.checkPicture.Margin = new System.Windows.Forms.Padding(0);
            this.checkPicture.MaximumSize = new System.Drawing.Size(16, 16);
            this.checkPicture.MinimumSize = new System.Drawing.Size(16, 16);
            this.checkPicture.Name = "checkPicture";
            this.checkPicture.Size = new System.Drawing.Size(16, 16);
            this.checkPicture.TabIndex = 1;
            this.checkPicture.UseVisualStyleBackColor = false;
            this.checkPicture.SizeChanged += new System.EventHandler(this.checkPicture_SizeChanged);
            this.checkPicture.Click += new System.EventHandler(this.CheckedEvent);
            this.checkPicture.Resize += new System.EventHandler(this.ControlResize);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.InitialImage = global::Controls.Properties.Resources.Image_bg;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(120, 120);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.CheckPicture);
            this.pictureBox.Resize += new System.EventHandler(this.ControlResize);
            // 
            // PictureBoxCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.checkPicture);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PictureBoxCtrl";
            this.Size = new System.Drawing.Size(120, 120);
            this.Click += new System.EventHandler(this.CheckPicture);
            this.Resize += new System.EventHandler(this.ControlResize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.CheckBox checkPicture;
		public System.Windows.Forms.PictureBox pictureBox;
	}
}
