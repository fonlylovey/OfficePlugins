namespace PPTPlugin
{
    partial class AboutWidget
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
            this.button_close = new WinForm.UI.Controls.CirclePictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CustomTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_close)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomTitle
            // 
            this.CustomTitle.Controls.Add(this.flowLayoutPanel1);
            this.CustomTitle.Location = new System.Drawing.Point(1, 1);
            this.CustomTitle.MaximumSize = new System.Drawing.Size(0, 40);
            this.CustomTitle.MinimumSize = new System.Drawing.Size(0, 40);
            this.CustomTitle.Size = new System.Drawing.Size(550, 40);
            this.CustomTitle.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            // 
            // button_close
            // 
            this.button_close.Image = global::PPTPlugin.Properties.Resources.close;
            this.button_close.IsSelected = false;
            this.button_close.Location = new System.Drawing.Point(485, 10);
            this.button_close.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.button_close.MouseMoveImage = global::PPTPlugin.Properties.Resources.close_s;
            this.button_close.Name = "button_close";
            this.button_close.Radius = 1;
            this.button_close.SelectedImage = null;
            this.button_close.Size = new System.Drawing.Size(45, 25);
            this.button_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.button_close.TabIndex = 1;
            this.button_close.TabStop = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button_close);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(530, 40);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::PPTPlugin.Properties.Resources.Logo2;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.MaximumSize = new System.Drawing.Size(145, 42);
            this.label1.MinimumSize = new System.Drawing.Size(145, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 42);
            this.label1.TabIndex = 10;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1, 41);
            this.flowLayoutPanel2.MaximumSize = new System.Drawing.Size(550, 50);
            this.flowLayoutPanel2.MinimumSize = new System.Drawing.Size(550, 50);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(550, 50);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.label4);
            this.flowLayoutPanel3.Controls.Add(this.label5);
            this.flowLayoutPanel3.Controls.Add(this.label6);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(1, 91);
            this.flowLayoutPanel3.MaximumSize = new System.Drawing.Size(550, 180);
            this.flowLayoutPanel3.MinimumSize = new System.Drawing.Size(550, 180);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(550, 180);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label2.Location = new System.Drawing.Point(25, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(25, 20, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "中国汽车技术研究中心有限公司";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(25, 44);
            this.label3.Margin = new System.Windows.Forms.Padding(25, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "中汽研（天津）汽车信息咨询有限公司        出品";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label4.Location = new System.Drawing.Point(25, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(25, 5, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(431, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "联系人：肖倩  15822752779  022-84379386  xiqoqian@catarc.ac.cn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.label5.Location = new System.Drawing.Point(73, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(73, 5, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(447, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "栾旭东  13920500522  022-54379222-1536 luanxudong@catarc.ac.cn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label6.Location = new System.Drawing.Point(25, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(25, 25, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(337, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Copyright 2019-2020 AutoPPTer.  All rights reserved.";
            // 
            // AboutWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderWidth = 1;
            this.ClientSize = new System.Drawing.Size(552, 272);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.MaximumSize = new System.Drawing.Size(552, 272);
            this.MinimumSize = new System.Drawing.Size(552, 272);
            this.Name = "AboutWidget";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateWidget";
            this.TitleVisible = true;
            this.Controls.SetChildIndex(this.CustomTitle, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel2, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel3, 0);
            this.CustomTitle.ResumeLayout(false);
            this.CustomTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_close)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private WinForm.UI.Controls.CirclePictureBox button_close;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}