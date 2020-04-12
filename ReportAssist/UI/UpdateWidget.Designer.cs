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
            this.components = new System.ComponentModel.Container();
            this.button_close = new WinForm.UI.Controls.CirclePictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_history = new WinForm.UI.Controls.FButton();
            this.button_detiles = new WinForm.UI.Controls.FButton();
            this.button_update = new WinForm.UI.Controls.FButton();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.TabWidget = new CustomControls.Controls.TabWidget(this.components);
            this.info_page = new System.Windows.Forms.TabPage();
            this.history_page = new System.Windows.Forms.TabPage();
            this.recordList = new WinForm.UI.Controls.FListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_close)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.TabWidget.SuspendLayout();
            this.info_page.SuspendLayout();
            this.history_page.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomTitle
            // 
            this.CustomTitle.Controls.Add(this.flowLayoutPanel1);
            this.CustomTitle.Location = new System.Drawing.Point(1, 1);
            this.CustomTitle.MaximumSize = new System.Drawing.Size(0, 40);
            this.CustomTitle.MinimumSize = new System.Drawing.Size(0, 40);
            this.CustomTitle.Size = new System.Drawing.Size(760, 40);
            this.CustomTitle.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            // 
            // button_close
            // 
            this.button_close.Image = global::PPTPlugin.Properties.Resources.close;
            this.button_close.IsSelected = false;
            this.button_close.Location = new System.Drawing.Point(695, 10);
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
            this.flowLayoutPanel1.Size = new System.Drawing.Size(740, 40);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1, 41);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.MaximumSize = new System.Drawing.Size(210, 480);
            this.flowLayoutPanel2.MinimumSize = new System.Drawing.Size(210, 480);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(210, 480);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::PPTPlugin.Properties.Resources.Logo2;
            this.label1.Location = new System.Drawing.Point(30, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 150, 0, 0);
            this.label1.MaximumSize = new System.Drawing.Size(145, 42);
            this.label1.MinimumSize = new System.Drawing.Size(145, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 42);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.label2.Location = new System.Drawing.Point(30, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.label2.MaximumSize = new System.Drawing.Size(145, 42);
            this.label2.MinimumSize = new System.Drawing.Size(145, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "PPTer 插件2010";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.button_history);
            this.flowLayoutPanel3.Controls.Add(this.button_detiles);
            this.flowLayoutPanel3.Controls.Add(this.button_update);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 390);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowLayoutPanel3.MaximumSize = new System.Drawing.Size(545, 100);
            this.flowLayoutPanel3.MinimumSize = new System.Drawing.Size(545, 100);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(545, 100);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // button_history
            // 
            this.button_history.BackColor = System.Drawing.Color.Transparent;
            this.button_history.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_history.ForeColor = System.Drawing.Color.White;
            this.button_history.Image = global::PPTPlugin.Properties.Resources.history_btn;
            this.button_history.Location = new System.Drawing.Point(0, 0);
            this.button_history.Margin = new System.Windows.Forms.Padding(0);
            this.button_history.MaximumSize = new System.Drawing.Size(100, 34);
            this.button_history.MinimumSize = new System.Drawing.Size(100, 34);
            this.button_history.mouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_history.Name = "button_history";
            this.button_history.Padding = new System.Windows.Forms.Padding(0, 2, 1, 1);
            this.button_history.Size = new System.Drawing.Size(100, 34);
            this.button_history.TabIndex = 0;
            this.button_history.Click += new System.EventHandler(this.button_history_Click);
            // 
            // button_detiles
            // 
            this.button_detiles.BackColor = System.Drawing.Color.Transparent;
            this.button_detiles.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_detiles.ForeColor = System.Drawing.Color.White;
            this.button_detiles.Image = global::PPTPlugin.Properties.Resources.about_btn;
            this.button_detiles.Location = new System.Drawing.Point(122, 0);
            this.button_detiles.Margin = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.button_detiles.MaximumSize = new System.Drawing.Size(100, 34);
            this.button_detiles.MinimumSize = new System.Drawing.Size(100, 34);
            this.button_detiles.mouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_detiles.Name = "button_detiles";
            this.button_detiles.Padding = new System.Windows.Forms.Padding(1, 2, 1, 1);
            this.button_detiles.Size = new System.Drawing.Size(100, 34);
            this.button_detiles.TabIndex = 1;
            this.button_detiles.Click += new System.EventHandler(this.button_detiles_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.Transparent;
            this.button_update.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_update.ForeColor = System.Drawing.Color.White;
            this.button_update.Image = global::PPTPlugin.Properties.Resources.updata_btn;
            this.button_update.Location = new System.Drawing.Point(382, 0);
            this.button_update.Margin = new System.Windows.Forms.Padding(160, 0, 0, 0);
            this.button_update.MaximumSize = new System.Drawing.Size(100, 34);
            this.button_update.MinimumSize = new System.Drawing.Size(100, 34);
            this.button_update.mouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_update.Name = "button_update";
            this.button_update.Padding = new System.Windows.Forms.Padding(1, 2, 1, 1);
            this.button_update.Size = new System.Drawing.Size(100, 34);
            this.button_update.TabIndex = 2;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.TabWidget);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(211, 41);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(550, 480);
            this.flowLayoutPanel4.TabIndex = 4;
            // 
            // TabWidget
            // 
            this.TabWidget.Controls.Add(this.info_page);
            this.TabWidget.Controls.Add(this.history_page);
            this.TabWidget.CurrentTab = this.info_page;
            this.TabWidget.DrawTabButton = false;
            this.TabWidget.Location = new System.Drawing.Point(0, 0);
            this.TabWidget.Margin = new System.Windows.Forms.Padding(0);
            this.TabWidget.MaximumSize = new System.Drawing.Size(545, 380);
            this.TabWidget.MinimumSize = new System.Drawing.Size(545, 380);
            this.TabWidget.Name = "TabWidget";
            this.TabWidget.Padding = new System.Drawing.Point(0, 0);
            this.TabWidget.SelectedIndex = 0;
            this.TabWidget.Size = new System.Drawing.Size(545, 380);
            this.TabWidget.TabIndex = 1;
            // 
            // info_page
            // 
            this.info_page.Controls.Add(this.label4);
            this.info_page.Controls.Add(this.label3);
            this.info_page.Location = new System.Drawing.Point(4, 26);
            this.info_page.Name = "info_page";
            this.info_page.Size = new System.Drawing.Size(537, 350);
            this.info_page.TabIndex = 0;
            this.info_page.Text = "信息";
            this.info_page.UseVisualStyleBackColor = true;
            // 
            // history_page
            // 
            this.history_page.Controls.Add(this.recordList);
            this.history_page.Location = new System.Drawing.Point(4, 26);
            this.history_page.Name = "history_page";
            this.history_page.Size = new System.Drawing.Size(537, 350);
            this.history_page.TabIndex = 1;
            this.history_page.Text = "历史";
            this.history_page.UseVisualStyleBackColor = true;
            // 
            // recordList
            // 
            this.recordList.Adapter = null;
            this.recordList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recordList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordList.Location = new System.Drawing.Point(0, 0);
            this.recordList.MouseHolder = null;
            this.recordList.Name = "recordList";
            this.recordList.SelectHolder = null;
            this.recordList.Size = new System.Drawing.Size(537, 350);
            this.recordList.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("黑体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label3.Location = new System.Drawing.Point(99, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "关于PPTer插件";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.label4.Location = new System.Drawing.Point(114, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "关于PPTer插件";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpdateWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderWidth = 1;
            this.ClientSize = new System.Drawing.Size(762, 522);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel2);
            this.MinimumSize = new System.Drawing.Size(762, 522);
            this.Name = "UpdateWidget";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateWidget";
            this.TitleVisible = true;
            this.Controls.SetChildIndex(this.CustomTitle, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel2, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel4, 0);
            this.CustomTitle.ResumeLayout(false);
            this.CustomTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button_close)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.TabWidget.ResumeLayout(false);
            this.info_page.ResumeLayout(false);
            this.info_page.PerformLayout();
            this.history_page.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private WinForm.UI.Controls.CirclePictureBox button_close;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private WinForm.UI.Controls.FButton button_history;
        private WinForm.UI.Controls.FButton button_detiles;
        private WinForm.UI.Controls.FButton button_update;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private CustomControls.Controls.TabWidget TabWidget;
        private System.Windows.Forms.TabPage info_page;
        private System.Windows.Forms.TabPage history_page;
        private WinForm.UI.Controls.FListView recordList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}