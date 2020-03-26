namespace CustomControls
{
	partial class ProgressCtrl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressCtrl));
            this.LayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.progress = new System.Windows.Forms.Label();
            this.InfoText = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.LayoutMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutMain
            // 
            this.LayoutMain.BackColor = System.Drawing.Color.Transparent;
            this.LayoutMain.ColumnCount = 2;
            this.LayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.LayoutMain.Controls.Add(this.progress, 0, 1);
            this.LayoutMain.Controls.Add(this.InfoText, 0, 0);
            this.LayoutMain.Controls.Add(this.Result, 1, 1);
            this.LayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutMain.Location = new System.Drawing.Point(0, 0);
            this.LayoutMain.Margin = new System.Windows.Forms.Padding(0);
            this.LayoutMain.MinimumSize = new System.Drawing.Size(0, 100);
            this.LayoutMain.Name = "LayoutMain";
            this.LayoutMain.Padding = new System.Windows.Forms.Padding(5);
            this.LayoutMain.RowCount = 2;
            this.LayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LayoutMain.Size = new System.Drawing.Size(503, 120);
            this.LayoutMain.TabIndex = 4;
            // 
            // progress
            // 
            this.progress.AutoSize = true;
            this.progress.BackColor = System.Drawing.Color.Transparent;
            this.progress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.progress.Location = new System.Drawing.Point(5, 60);
            this.progress.Margin = new System.Windows.Forms.Padding(0);
            this.progress.MaximumSize = new System.Drawing.Size(0, 30);
            this.progress.MinimumSize = new System.Drawing.Size(300, 30);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(463, 30);
            this.progress.TabIndex = 3;
            // 
            // InfoText
            // 
            this.InfoText.AutoSize = true;
            this.InfoText.BackColor = System.Drawing.Color.Transparent;
            this.LayoutMain.SetColumnSpan(this.InfoText, 2);
            this.InfoText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoText.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.InfoText.Location = new System.Drawing.Point(5, 5);
            this.InfoText.Margin = new System.Windows.Forms.Padding(0);
            this.InfoText.MinimumSize = new System.Drawing.Size(150, 30);
            this.InfoText.Name = "InfoText";
            this.InfoText.Size = new System.Drawing.Size(493, 55);
            this.InfoText.TabIndex = 1;
            this.InfoText.Text = "正在获取网络数据，请稍后...";
            this.InfoText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Result.ImageIndex = 0;
            this.Result.ImageList = this.imageList;
            this.Result.Location = new System.Drawing.Point(468, 60);
            this.Result.Margin = new System.Windows.Forms.Padding(0);
            this.Result.MaximumSize = new System.Drawing.Size(30, 30);
            this.Result.MinimumSize = new System.Drawing.Size(30, 30);
            this.Result.Name = "Result";
            this.Result.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.Result.Size = new System.Drawing.Size(30, 30);
            this.Result.TabIndex = 2;
            this.Result.Text = "50%";
            this.Result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "pro_failed.png");
            this.imageList.Images.SetKeyName(1, "pro_success.png");
            // 
            // ProgressCtrl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.LayoutMain);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(350, 120);
            this.Name = "ProgressCtrl";
            this.Size = new System.Drawing.Size(503, 120);
            this.Load += new System.EventHandler(this.ProgressCtrl_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Progress_Paint);
            this.Resize += new System.EventHandler(this.ProgressCtrl_Resize);
            this.LayoutMain.ResumeLayout(false);
            this.LayoutMain.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label InfoText;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.Label progress;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TableLayoutPanel LayoutMain;
    }
}
