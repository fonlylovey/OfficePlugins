namespace CustomControls
{
	partial class CustomTable
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ColProjectName = new System.Windows.Forms.DataGridViewImageColumn();
			this.ColProjectCreator = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColProCreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColProjectName,
            this.ColProjectCreator,
            this.ColProCreateTime});
			this.dataGridView1.GridColor = System.Drawing.Color.White;
			this.dataGridView1.Location = new System.Drawing.Point(60, 85);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.Size = new System.Drawing.Size(403, 232);
			this.dataGridView1.TabIndex = 0;
			// 
			// ColProjectName
			// 
			this.ColProjectName.Frozen = true;
			this.ColProjectName.HeaderText = "项目名称";
			this.ColProjectName.Name = "ColProjectName";
			// 
			// ColProjectCreator
			// 
			this.ColProjectCreator.Frozen = true;
			this.ColProjectCreator.HeaderText = "创建人";
			this.ColProjectCreator.Name = "ColProjectCreator";
			this.ColProjectCreator.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ColProjectCreator.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// ColProCreateTime
			// 
			this.ColProCreateTime.Frozen = true;
			this.ColProCreateTime.HeaderText = "创建时间";
			this.ColProCreateTime.MinimumWidth = 50;
			this.ColProCreateTime.Name = "ColProCreateTime";
			this.ColProCreateTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.ColProCreateTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// CustomTable
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.Controls.Add(this.dataGridView1);
			this.Name = "CustomTable";
			this.Size = new System.Drawing.Size(557, 443);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewImageColumn ColProjectName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColProjectCreator;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColProCreateTime;
	}
}
