﻿namespace Widgets
{
    partial class PromptBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PromptBox));
            this.message = new System.Windows.Forms.Label();
            this.msgTitle = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.button_Cancel = new System.Windows.Forms.Button();
            this.msgImage = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.msgImage)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // message
            // 
            this.message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.message.AutoEllipsis = true;
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.message.Location = new System.Drawing.Point(86, 49);
            this.message.MaximumSize = new System.Drawing.Size(300, 800);
            this.message.MinimumSize = new System.Drawing.Size(300, 60);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(300, 60);
            this.message.TabIndex = 15;
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // msgTitle
            // 
            this.msgTitle.AutoSize = true;
            this.msgTitle.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.msgTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.msgTitle.Location = new System.Drawing.Point(20, 15);
            this.msgTitle.Name = "msgTitle";
            this.msgTitle.Size = new System.Drawing.Size(42, 21);
            this.msgTitle.TabIndex = 16;
            this.msgTitle.Text = "提示";
            // 
            // button_OK
            // 
            this.button_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_OK.BackColor = System.Drawing.Color.Transparent;
            this.button_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_OK.FlatAppearance.BorderSize = 0;
            this.button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OK.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_OK.ForeColor = System.Drawing.Color.White;
            this.button_OK.ImageIndex = 1;
            this.button_OK.ImageList = this.imageList;
            this.button_OK.Location = new System.Drawing.Point(280, 12);
            this.button_OK.Margin = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.button_OK.MaximumSize = new System.Drawing.Size(67, 31);
            this.button_OK.MinimumSize = new System.Drawing.Size(67, 31);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(67, 31);
            this.button_OK.TabIndex = 13;
            this.button_OK.Text = "确 定";
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Visible = false;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
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
            // button_Cancel
            // 
            this.button_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Cancel.BackColor = System.Drawing.Color.Transparent;
            this.button_Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.FlatAppearance.BorderSize = 0;
            this.button_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cancel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button_Cancel.ImageIndex = 0;
            this.button_Cancel.ImageList = this.imageList;
            this.button_Cancel.Location = new System.Drawing.Point(359, 12);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(0);
            this.button_Cancel.MaximumSize = new System.Drawing.Size(67, 31);
            this.button_Cancel.MinimumSize = new System.Drawing.Size(67, 31);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(67, 31);
            this.button_Cancel.TabIndex = 12;
            this.button_Cancel.Text = "取 消";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Visible = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // msgImage
            // 
            this.msgImage.BackColor = System.Drawing.Color.Transparent;
            this.msgImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.msgImage.Image = global::Widgets.Properties.Resources.Warning_icon;
            this.msgImage.Location = new System.Drawing.Point(48, 62);
            this.msgImage.Name = "msgImage";
            this.msgImage.Size = new System.Drawing.Size(32, 32);
            this.msgImage.TabIndex = 14;
            this.msgImage.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button_Cancel);
            this.flowLayoutPanel1.Controls.Add(this.button_OK);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 124);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(0, 52);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(0, 52);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(12, 12, 6, 12);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(444, 52);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // PromptBox
            // 
            this.AcceptButton = this.button_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(444, 176);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.msgTitle);
            this.Controls.Add(this.message);
            this.Controls.Add(this.msgImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(400, 150);
            this.Name = "PromptBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PromptBox";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.msgImage)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.PictureBox msgImage;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Label msgTitle;
		private System.Windows.Forms.ImageList imageList;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	}
}