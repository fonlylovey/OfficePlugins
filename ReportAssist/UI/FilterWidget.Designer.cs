namespace PPTPlugin
{
    partial class FilterWidget
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_reset = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomTitle
            // 
            this.CustomTitle.Location = new System.Drawing.Point(1, 1);
            this.CustomTitle.Size = new System.Drawing.Size(238, 32);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(238, 48);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.button_reset);
            this.flowLayoutPanel4.Controls.Add(this.button_ok);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 5);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(232, 36);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(149, 3);
            this.button_reset.MaximumSize = new System.Drawing.Size(80, 26);
            this.button_reset.MinimumSize = new System.Drawing.Size(80, 26);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(80, 26);
            this.button_reset.TabIndex = 0;
            this.button_reset.Text = "重置";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(63, 3);
            this.button_ok.MaximumSize = new System.Drawing.Size(80, 26);
            this.button_ok.MinimumSize = new System.Drawing.Size(80, 26);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(80, 26);
            this.button_ok.TabIndex = 1;
            this.button_ok.Text = "确认";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // FilterWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderWidth = 1;
            this.ClientSize = new System.Drawing.Size(240, 50);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(240, 800);
            this.MinimumSize = new System.Drawing.Size(240, 50);
            this.Name = "FilterWidget";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FilterWidget";
            this.TopMost = true;
            this.Deactivate += new System.EventHandler(this.FilterWidget_Deactivate);
            this.Controls.SetChildIndex(this.CustomTitle, 0);
            this.Controls.SetChildIndex(this.flowLayoutPanel1, 0);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_ok;
    }
}