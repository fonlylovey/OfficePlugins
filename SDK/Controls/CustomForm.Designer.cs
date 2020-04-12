namespace CustomControls
{
	partial class CustomForm
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
            this.CustomTitle = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.CustomTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomTitle
            // 
            this.CustomTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(210)))), ((int)(((byte)(213)))));
            this.CustomTitle.BackgroundImage = global::CustomControls.Properties.Resources.Title_bg;
            this.CustomTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CustomTitle.Controls.Add(this.label_title);
            this.CustomTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CustomTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.CustomTitle.Location = new System.Drawing.Point(0, 0);
            this.CustomTitle.MaximumSize = new System.Drawing.Size(0, 32);
            this.CustomTitle.Name = "CustomTitle";
            this.CustomTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.CustomTitle.Size = new System.Drawing.Size(120, 32);
            this.CustomTitle.TabIndex = 0;
            this.CustomTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CustomForm_MouseDown);
            this.CustomTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CustomForm_MouseMove);
            // 
            // label_title
            // 
            this.label_title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_title.AutoSize = true;
            this.label_title.BackColor = System.Drawing.Color.Transparent;
            this.label_title.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label_title.Location = new System.Drawing.Point(20, 1);
            this.label_title.MaximumSize = new System.Drawing.Size(0, 30);
            this.label_title.MinimumSize = new System.Drawing.Size(0, 30);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(80, 30);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "自定义标题栏";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(120, 100);
            this.ControlBox = false;
            this.Controls.Add(this.CustomTitle);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "CustomForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CustomForm_Paint);
            this.CustomTitle.ResumeLayout(false);
            this.CustomTitle.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label_title;
        protected System.Windows.Forms.Panel CustomTitle;
    }
}