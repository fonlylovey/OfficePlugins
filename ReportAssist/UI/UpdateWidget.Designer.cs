namespace PPTPlugin
{
    partial class UpdateWidget
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
            this.label_currentVersion = new System.Windows.Forms.Label();
            this.link_recordList = new System.Windows.Forms.LinkLabel();
            this.button_detiles = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PPTPlugin.Properties.Resources.Logo2;
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(148, 45);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(148, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 45);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label_currentVersion
            // 
            this.label_currentVersion.AutoSize = true;
            this.label_currentVersion.Location = new System.Drawing.Point(15, 51);
            this.label_currentVersion.Margin = new System.Windows.Forms.Padding(15, 6, 3, 3);
            this.label_currentVersion.Name = "label_currentVersion";
            this.label_currentVersion.Size = new System.Drawing.Size(96, 17);
            this.label_currentVersion.TabIndex = 3;
            this.label_currentVersion.Text = "当前版本:1.0.0.5";
            // 
            // link_recordList
            // 
            this.link_recordList.AutoSize = true;
            this.link_recordList.Location = new System.Drawing.Point(15, 91);
            this.link_recordList.Margin = new System.Windows.Forms.Padding(15, 20, 9, 9);
            this.link_recordList.Name = "link_recordList";
            this.link_recordList.Size = new System.Drawing.Size(56, 17);
            this.link_recordList.TabIndex = 4;
            this.link_recordList.TabStop = true;
            this.link_recordList.Text = "历史更新";
            this.link_recordList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_recordList_LinkClicked);
            // 
            // button_detiles
            // 
            this.button_detiles.Location = new System.Drawing.Point(15, 122);
            this.button_detiles.Margin = new System.Windows.Forms.Padding(15, 5, 9, 9);
            this.button_detiles.Name = "button_detiles";
            this.button_detiles.Size = new System.Drawing.Size(75, 23);
            this.button_detiles.TabIndex = 5;
            this.button_detiles.Text = "功能介绍";
            this.button_detiles.UseVisualStyleBackColor = true;
            this.button_detiles.Click += new System.EventHandler(this.button_detiles_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(205, 6);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(6, 6, 15, 6);
            this.button_cancel.MaximumSize = new System.Drawing.Size(80, 28);
            this.button_cancel.MinimumSize = new System.Drawing.Size(80, 28);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(80, 28);
            this.button_cancel.TabIndex = 6;
            this.button_cancel.Text = "取消";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(104, 6);
            this.button_update.Margin = new System.Windows.Forms.Padding(6, 6, 15, 6);
            this.button_update.MaximumSize = new System.Drawing.Size(80, 28);
            this.button_update.MinimumSize = new System.Drawing.Size(80, 28);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(80, 28);
            this.button_update.TabIndex = 7;
            this.button_update.Tag = "";
            this.button_update.Text = "更新";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.label_currentVersion);
            this.flowLayoutPanel1.Controls.Add(this.link_recordList);
            this.flowLayoutPanel1.Controls.Add(this.button_detiles);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 33);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(150, 0);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(148, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(150, 198);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.button_cancel);
            this.flowLayoutPanel3.Controls.Add(this.button_update);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 156);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.MaximumSize = new System.Drawing.Size(300, 40);
            this.flowLayoutPanel3.MinimumSize = new System.Drawing.Size(280, 40);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(300, 40);
            this.flowLayoutPanel3.TabIndex = 12;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.richTextBox);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(151, 33);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel4.MaximumSize = new System.Drawing.Size(300, 0);
            this.flowLayoutPanel4.MinimumSize = new System.Drawing.Size(300, 0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(300, 198);
            this.flowLayoutPanel4.TabIndex = 13;
            // 
            // richTextBox
            // 
            this.richTextBox.BackColor = System.Drawing.Color.White;
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox.Location = new System.Drawing.Point(3, 3);
            this.richTextBox.MaximumSize = new System.Drawing.Size(296, 160);
            this.richTextBox.MinimumSize = new System.Drawing.Size(296, 150);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox.ShowSelectionMargin = true;
            this.richTextBox.Size = new System.Drawing.Size(296, 150);
            this.richTextBox.TabIndex = 13;
            this.richTextBox.Text = "最新版本：1.0.0.6 \n版本特性：\n-新增导入图标功能\n-新增插入视频功能\n-修改一些bug\n";
            // 
            // UpdateWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderWidth = 1;
            this.ClientSize = new System.Drawing.Size(452, 232);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(452, 232);
            this.MinimumSize = new System.Drawing.Size(452, 232);
            this.Name = "UpdateWidget";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateWidget";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_currentVersion;
        private System.Windows.Forms.LinkLabel link_recordList;
        private System.Windows.Forms.Button button_detiles;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}