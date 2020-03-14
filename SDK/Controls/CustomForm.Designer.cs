namespace Controls
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
            System.Windows.Forms.Panel CustomTitle;
            this.label_title = new System.Windows.Forms.Label();
            CustomTitle = new System.Windows.Forms.Panel();
            CustomTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomTitle
            // 
            CustomTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(210)))), ((int)(((byte)(213)))));
            CustomTitle.BackgroundImage = global::Controls.Properties.Resources.Title_bg;
            CustomTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            CustomTitle.Controls.Add(this.label_title);
            CustomTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            CustomTitle.Dock = System.Windows.Forms.DockStyle.Top;
            CustomTitle.Location = new System.Drawing.Point(0, 0);
            CustomTitle.MaximumSize = new System.Drawing.Size(0, 32);
            CustomTitle.Name = "CustomTitle";
            CustomTitle.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            CustomTitle.Size = new System.Drawing.Size(480, 32);
            CustomTitle.TabIndex = 0;
            CustomTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CustomForm_MouseDown);
            CustomTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CustomForm_MouseMove);
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.ClientSize = new System.Drawing.Size(480, 320);
            this.ControlBox = false;
            this.Controls.Add(CustomTitle);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(480, 320);
            this.Name = "CustomForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CustomForm_Paint);
            CustomTitle.ResumeLayout(false);
            CustomTitle.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label_title;
	}
}