namespace BIM.AutoUpdate
{
	partial class UpdateForm
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
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.TextBox_ChangeLog = new System.Windows.Forms.RichTextBox();
            this.label_CurrentVersion = new System.Windows.Forms.Label();
            this.label_ServerVersion = new System.Windows.Forms.Label();
            this.label_Level = new System.Windows.Forms.Label();
            this.textBox_Description = new System.Windows.Forms.RichTextBox();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            flowLayoutPanel3.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BackColor = System.Drawing.Color.White;
            flowLayoutPanel3.Controls.Add(this.TextBox_ChangeLog);
            flowLayoutPanel3.Location = new System.Drawing.Point(264, 56);
            flowLayoutPanel3.MaximumSize = new System.Drawing.Size(340, 0);
            flowLayoutPanel3.MinimumSize = new System.Drawing.Size(340, 200);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(10);
            flowLayoutPanel3.Size = new System.Drawing.Size(340, 200);
            flowLayoutPanel3.TabIndex = 19;
            // 
            // TextBox_ChangeLog
            // 
            this.TextBox_ChangeLog.BackColor = System.Drawing.Color.White;
            this.TextBox_ChangeLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_ChangeLog.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TextBox_ChangeLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TextBox_ChangeLog.Location = new System.Drawing.Point(13, 13);
            this.TextBox_ChangeLog.MaximumSize = new System.Drawing.Size(315, 0);
            this.TextBox_ChangeLog.MinimumSize = new System.Drawing.Size(315, 186);
            this.TextBox_ChangeLog.Name = "TextBox_ChangeLog";
            this.TextBox_ChangeLog.ReadOnly = true;
            this.TextBox_ChangeLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TextBox_ChangeLog.Size = new System.Drawing.Size(315, 186);
            this.TextBox_ChangeLog.TabIndex = 0;
            this.TextBox_ChangeLog.Text = "1、";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            flowLayoutPanel1.Controls.Add(this.label_CurrentVersion);
            flowLayoutPanel1.Controls.Add(this.label_ServerVersion);
            flowLayoutPanel1.Controls.Add(this.label_Level);
            flowLayoutPanel1.Controls.Add(this.textBox_Description);
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            flowLayoutPanel1.Location = new System.Drawing.Point(24, 56);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            flowLayoutPanel1.MaximumSize = new System.Drawing.Size(220, 0);
            flowLayoutPanel1.MinimumSize = new System.Drawing.Size(220, 200);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            flowLayoutPanel1.Size = new System.Drawing.Size(220, 200);
            flowLayoutPanel1.TabIndex = 17;
            // 
            // label_CurrentVersion
            // 
            this.label_CurrentVersion.AutoSize = true;
            this.label_CurrentVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label_CurrentVersion.Location = new System.Drawing.Point(13, 10);
            this.label_CurrentVersion.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label_CurrentVersion.MaximumSize = new System.Drawing.Size(200, 24);
            this.label_CurrentVersion.MinimumSize = new System.Drawing.Size(200, 24);
            this.label_CurrentVersion.Name = "label_CurrentVersion";
            this.label_CurrentVersion.Size = new System.Drawing.Size(200, 24);
            this.label_CurrentVersion.TabIndex = 0;
            this.label_CurrentVersion.Text = "当前版本：";
            this.label_CurrentVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_ServerVersion
            // 
            this.label_ServerVersion.AutoSize = true;
            this.label_ServerVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label_ServerVersion.Location = new System.Drawing.Point(13, 39);
            this.label_ServerVersion.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label_ServerVersion.MaximumSize = new System.Drawing.Size(200, 24);
            this.label_ServerVersion.MinimumSize = new System.Drawing.Size(200, 24);
            this.label_ServerVersion.Name = "label_ServerVersion";
            this.label_ServerVersion.Size = new System.Drawing.Size(200, 24);
            this.label_ServerVersion.TabIndex = 1;
            this.label_ServerVersion.Text = "最新版本：";
            this.label_ServerVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Level
            // 
            this.label_Level.AutoSize = true;
            this.label_Level.ForeColor = System.Drawing.Color.Firebrick;
            this.label_Level.Location = new System.Drawing.Point(13, 68);
            this.label_Level.MaximumSize = new System.Drawing.Size(200, 24);
            this.label_Level.MinimumSize = new System.Drawing.Size(200, 24);
            this.label_Level.Name = "label_Level";
            this.label_Level.Size = new System.Drawing.Size(200, 24);
            this.label_Level.TabIndex = 2;
            this.label_Level.Text = "版本说明";
            this.label_Level.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_Description
            // 
            this.textBox_Description.BackColor = System.Drawing.Color.White;
            this.textBox_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Description.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textBox_Description.Location = new System.Drawing.Point(13, 95);
            this.textBox_Description.MaximumSize = new System.Drawing.Size(200, 0);
            this.textBox_Description.MinimumSize = new System.Drawing.Size(200, 80);
            this.textBox_Description.Name = "textBox_Description";
            this.textBox_Description.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.textBox_Description.Size = new System.Drawing.Size(200, 80);
            this.textBox_Description.TabIndex = 4;
            this.textBox_Description.Text = "";
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
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.button_Cancel);
            this.flowLayoutPanel2.Controls.Add(this.button_OK);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(2, 266);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.MaximumSize = new System.Drawing.Size(0, 52);
            this.flowLayoutPanel2.MinimumSize = new System.Drawing.Size(0, 52);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(12);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(626, 52);
            this.flowLayoutPanel2.TabIndex = 18;
            // 
            // button_Cancel
            // 
            this.button_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.button_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.button_Cancel.FlatAppearance.BorderSize = 0;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_Cancel.ImageIndex = 0;
            this.button_Cancel.ImageList = this.imageList;
            this.button_Cancel.Location = new System.Drawing.Point(535, 12);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(0);
            this.button_Cancel.MaximumSize = new System.Drawing.Size(67, 31);
            this.button_Cancel.MinimumSize = new System.Drawing.Size(67, 31);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(67, 31);
            this.button_Cancel.TabIndex = 13;
            this.button_Cancel.Text = "取消";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_OK.BackColor = System.Drawing.Color.Transparent;
            this.button_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_OK.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.button_OK.FlatAppearance.BorderSize = 0;
            this.button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_OK.ForeColor = System.Drawing.Color.White;
            this.button_OK.ImageIndex = 1;
            this.button_OK.ImageList = this.imageList;
            this.button_OK.Location = new System.Drawing.Point(458, 12);
            this.button_OK.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.button_OK.MaximumSize = new System.Drawing.Size(67, 31);
            this.button_OK.MinimumSize = new System.Drawing.Size(67, 31);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(67, 31);
            this.button_OK.TabIndex = 1;
            this.button_OK.Text = "更新";
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // UpdateForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(630, 320);
            this.Controls.Add(flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(630, 320);
            this.MinimumSize = new System.Drawing.Size(630, 0);
            this.Name = "UpdateForm";
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateForm";
            this.TitleText = "更新检测";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.RichTextBox TextBox_ChangeLog;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Label label_CurrentVersion;
        private System.Windows.Forms.Label label_ServerVersion;
        private System.Windows.Forms.Label label_Level;
        private System.Windows.Forms.RichTextBox textBox_Description;
        private System.Windows.Forms.Button button_OK;
    }
}