namespace Widgets
{
	partial class ProgressWidget
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
            this.progressCtrl = new Controls.ProgressCtrl();
            this.SuspendLayout();
            // 
            // progressCtrl
            // 
            this.progressCtrl.ChuckColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(250)))));
            this.progressCtrl.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.progressCtrl.Location = new System.Drawing.Point(5, 5);
            this.progressCtrl.Margin = new System.Windows.Forms.Padding(0);
            this.progressCtrl.Maximum = 100;
            this.progressCtrl.MinimumSize = new System.Drawing.Size(350, 120);
            this.progressCtrl.Name = "progressCtrl";
            this.progressCtrl.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.progressCtrl.progressState = Controls.ProgressCtrl.ProgressState.Progress;
            this.progressCtrl.Size = new System.Drawing.Size(540, 120);
            this.progressCtrl.TabIndex = 0;
            this.progressCtrl.Value = 0;
            // 
            // ProgressWidget
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(550, 130);
            this.ControlBox = false;
            this.Controls.Add(this.progressCtrl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(350, 130);
            this.Name = "ProgressWidget";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgressWidget";
            this.TopMost = true;
            this.ResumeLayout(false);

		}

        #endregion

        private Controls.ProgressCtrl progressCtrl;
    }
}