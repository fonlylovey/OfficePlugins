namespace CustomControls
{
    partial class PicturePlane
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.markButton = new System.Windows.Forms.Label();
            this.applyButton = new System.Windows.Forms.Label();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.White;
            this.MenuPanel.Controls.Add(this.markButton);
            this.MenuPanel.Controls.Add(this.applyButton);
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Padding = new System.Windows.Forms.Padding(3);
            this.MenuPanel.Size = new System.Drawing.Size(160, 160);
            this.MenuPanel.TabIndex = 1;
            this.MenuPanel.MouseLeave += new System.EventHandler(this.MenuPanel_MouseLeave);
            this.MenuPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Picture_MouseMove);
            this.MenuPanel.Resize += new System.EventHandler(this.MenuPanel_Resize);
            // 
            // markButton
            // 
            this.markButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.markButton.AutoSize = true;
            this.markButton.BackColor = System.Drawing.Color.Transparent;
            this.markButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.markButton.Image = global::CustomControls.Properties.Resources.unMark;
            this.markButton.Location = new System.Drawing.Point(124, 3);
            this.markButton.Margin = new System.Windows.Forms.Padding(3);
            this.markButton.MaximumSize = new System.Drawing.Size(32, 32);
            this.markButton.MinimumSize = new System.Drawing.Size(32, 32);
            this.markButton.Name = "markButton";
            this.markButton.Size = new System.Drawing.Size(32, 32);
            this.markButton.TabIndex = 4;
            this.markButton.Click += new System.EventHandler(this.markButton_Click);
            this.markButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Picture_MouseMove);
            // 
            // applyButton
            // 
            this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.applyButton.AutoSize = true;
            this.applyButton.BackColor = System.Drawing.Color.Transparent;
            this.applyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applyButton.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.applyButton.Image = global::CustomControls.Properties.Resources.download;
            this.applyButton.Location = new System.Drawing.Point(68, 68);
            this.applyButton.Margin = new System.Windows.Forms.Padding(0);
            this.applyButton.MaximumSize = new System.Drawing.Size(32, 32);
            this.applyButton.MinimumSize = new System.Drawing.Size(32, 32);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(32, 32);
            this.applyButton.TabIndex = 3;
            this.applyButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            this.applyButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Picture_MouseMove);
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.Color.White;
            this.Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Picture.ImageLocation = "";
            this.Picture.Location = new System.Drawing.Point(0, 0);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(160, 160);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            this.Picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Picture_MouseMove);
            // 
            // PicturePlane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.Picture);
            this.Name = "PicturePlane";
            this.Size = new System.Drawing.Size(160, 160);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Label markButton;
        private System.Windows.Forms.Label applyButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
