namespace PPTPlugin
{
    partial class DockWidget
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
            System.Windows.Forms.Panel leftPlane;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DockWidget));
            this.LBPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_prePage = new System.Windows.Forms.Button();
            this.pageBox = new System.Windows.Forms.TextBox();
            this.button_nextPage = new System.Windows.Forms.Button();
            this.labelPage = new System.Windows.Forms.Label();
            this.resourceList = new System.Windows.Forms.TableLayoutPanel();
            this.LTPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label_All = new System.Windows.Forms.Label();
            this.label_Mark = new System.Windows.Forms.Label();
            this.label_Records = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_filter = new System.Windows.Forms.Button();
            this.QueryButton = new System.Windows.Forms.Button();
            this.VMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.label_MB = new System.Windows.Forms.Label();
            this.label_TL = new System.Windows.Forms.Label();
            this.label_TB = new System.Windows.Forms.Label();
            this.label_SC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.textBox = new WinForm.UI.Controls.FTextBox();
            leftPlane = new System.Windows.Forms.Panel();
            leftPlane.SuspendLayout();
            this.LBPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.LTPanel.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.VMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPlane
            // 
            leftPlane.BackColor = System.Drawing.Color.White;
            leftPlane.Controls.Add(this.LBPanel);
            leftPlane.Controls.Add(this.resourceList);
            leftPlane.Controls.Add(this.LTPanel);
            leftPlane.Dock = System.Windows.Forms.DockStyle.Fill;
            leftPlane.Location = new System.Drawing.Point(0, 0);
            leftPlane.Name = "leftPlane";
            leftPlane.Size = new System.Drawing.Size(220, 600);
            leftPlane.TabIndex = 8;
            // 
            // LBPanel
            // 
            this.LBPanel.Controls.Add(this.flowLayoutPanel1);
            this.LBPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LBPanel.Location = new System.Drawing.Point(0, 560);
            this.LBPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LBPanel.MaximumSize = new System.Drawing.Size(0, 40);
            this.LBPanel.MinimumSize = new System.Drawing.Size(0, 40);
            this.LBPanel.Name = "LBPanel";
            this.LBPanel.Size = new System.Drawing.Size(220, 40);
            this.LBPanel.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button_prePage);
            this.flowLayoutPanel1.Controls.Add(this.pageBox);
            this.flowLayoutPanel1.Controls.Add(this.button_nextPage);
            this.flowLayoutPanel1.Controls.Add(this.labelPage);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(220, 40);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button_prePage
            // 
            this.button_prePage.BackColor = System.Drawing.Color.Transparent;
            this.button_prePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_prePage.FlatAppearance.BorderSize = 0;
            this.button_prePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_prePage.Image = global::PPTPlugin.Properties.Resources.prePage;
            this.button_prePage.Location = new System.Drawing.Point(14, 4);
            this.button_prePage.Margin = new System.Windows.Forms.Padding(9, 4, 9, 0);
            this.button_prePage.MaximumSize = new System.Drawing.Size(32, 32);
            this.button_prePage.MinimumSize = new System.Drawing.Size(32, 32);
            this.button_prePage.Name = "button_prePage";
            this.button_prePage.Size = new System.Drawing.Size(32, 32);
            this.button_prePage.TabIndex = 6;
            this.toolTip.SetToolTip(this.button_prePage, "上一页");
            this.button_prePage.UseVisualStyleBackColor = false;
            this.button_prePage.Click += new System.EventHandler(this.button_prePage_Click);
            // 
            // pageBox
            // 
            this.pageBox.BackColor = System.Drawing.Color.White;
            this.pageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pageBox.Location = new System.Drawing.Point(64, 4);
            this.pageBox.Margin = new System.Windows.Forms.Padding(9, 4, 9, 0);
            this.pageBox.MaximumSize = new System.Drawing.Size(32, 32);
            this.pageBox.MaxLength = 32;
            this.pageBox.MinimumSize = new System.Drawing.Size(32, 32);
            this.pageBox.Name = "pageBox";
            this.pageBox.Size = new System.Drawing.Size(32, 26);
            this.pageBox.TabIndex = 9;
            this.pageBox.Text = "1";
            this.pageBox.WordWrap = false;
            this.pageBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pageBox_KeyDown);
            // 
            // button_nextPage
            // 
            this.button_nextPage.BackColor = System.Drawing.Color.Transparent;
            this.button_nextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_nextPage.FlatAppearance.BorderSize = 0;
            this.button_nextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nextPage.Image = global::PPTPlugin.Properties.Resources.nextPage;
            this.button_nextPage.Location = new System.Drawing.Point(114, 4);
            this.button_nextPage.Margin = new System.Windows.Forms.Padding(9, 4, 9, 0);
            this.button_nextPage.MaximumSize = new System.Drawing.Size(32, 32);
            this.button_nextPage.MinimumSize = new System.Drawing.Size(32, 32);
            this.button_nextPage.Name = "button_nextPage";
            this.button_nextPage.Size = new System.Drawing.Size(32, 32);
            this.button_nextPage.TabIndex = 7;
            this.toolTip.SetToolTip(this.button_nextPage, "下一页");
            this.button_nextPage.UseVisualStyleBackColor = false;
            this.button_nextPage.Click += new System.EventHandler(this.button_nextPage_Click);
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPage.Location = new System.Drawing.Point(155, 4);
            this.labelPage.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.labelPage.MaximumSize = new System.Drawing.Size(60, 4032);
            this.labelPage.MinimumSize = new System.Drawing.Size(60, 32);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(60, 32);
            this.labelPage.TabIndex = 8;
            this.labelPage.Text = "99/99";
            this.labelPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // resourceList
            // 
            this.resourceList.BackColor = System.Drawing.Color.White;
            this.resourceList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.resourceList.ColumnCount = 2;
            this.resourceList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.resourceList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.resourceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourceList.Location = new System.Drawing.Point(0, 72);
            this.resourceList.Margin = new System.Windows.Forms.Padding(0);
            this.resourceList.MaximumSize = new System.Drawing.Size(210, 0);
            this.resourceList.MinimumSize = new System.Drawing.Size(210, 0);
            this.resourceList.Name = "resourceList";
            this.resourceList.RowCount = 2;
            this.resourceList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.resourceList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.resourceList.Size = new System.Drawing.Size(210, 528);
            this.resourceList.TabIndex = 7;
            // 
            // LTPanel
            // 
            this.LTPanel.Controls.Add(this.flowLayoutPanel3);
            this.LTPanel.Controls.Add(this.flowLayoutPanel2);
            this.LTPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LTPanel.Location = new System.Drawing.Point(0, 0);
            this.LTPanel.MaximumSize = new System.Drawing.Size(0, 72);
            this.LTPanel.MinimumSize = new System.Drawing.Size(0, 72);
            this.LTPanel.Name = "LTPanel";
            this.LTPanel.Size = new System.Drawing.Size(220, 72);
            this.LTPanel.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel3.Controls.Add(this.label_All);
            this.flowLayoutPanel3.Controls.Add(this.label_Mark);
            this.flowLayoutPanel3.Controls.Add(this.label_Records);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 44);
            this.flowLayoutPanel3.MaximumSize = new System.Drawing.Size(0, 30);
            this.flowLayoutPanel3.MinimumSize = new System.Drawing.Size(0, 30);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(220, 30);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // label_All
            // 
            this.label_All.AutoSize = true;
            this.label_All.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_All.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_All.Location = new System.Drawing.Point(33, 0);
            this.label_All.MinimumSize = new System.Drawing.Size(0, 28);
            this.label_All.Name = "label_All";
            this.label_All.Size = new System.Drawing.Size(32, 28);
            this.label_All.TabIndex = 9;
            this.label_All.Text = "全部";
            this.label_All.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_All.Click += new System.EventHandler(this.label_All_Click);
            // 
            // label_Mark
            // 
            this.label_Mark.AutoSize = true;
            this.label_Mark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Mark.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Mark.Location = new System.Drawing.Point(71, 0);
            this.label_Mark.MinimumSize = new System.Drawing.Size(0, 28);
            this.label_Mark.Name = "label_Mark";
            this.label_Mark.Size = new System.Drawing.Size(56, 28);
            this.label_Mark.TabIndex = 11;
            this.label_Mark.Text = "我的收藏";
            this.label_Mark.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Mark.Click += new System.EventHandler(this.label_Mark_Click);
            // 
            // label_Records
            // 
            this.label_Records.AutoSize = true;
            this.label_Records.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_Records.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Records.Location = new System.Drawing.Point(133, 0);
            this.label_Records.MinimumSize = new System.Drawing.Size(0, 28);
            this.label_Records.Name = "label_Records";
            this.label_Records.Size = new System.Drawing.Size(56, 28);
            this.label_Records.TabIndex = 12;
            this.label_Records.Text = "历史记录";
            this.label_Records.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Records.Click += new System.EventHandler(this.label_Records_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Controls.Add(this.button_filter);
            this.flowLayoutPanel2.Controls.Add(this.textBox);
            this.flowLayoutPanel2.Controls.Add(this.QueryButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(220, 44);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // button_filter
            // 
            this.button_filter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_filter.Location = new System.Drawing.Point(3, 13);
            this.button_filter.MaximumSize = new System.Drawing.Size(48, 28);
            this.button_filter.MinimumSize = new System.Drawing.Size(48, 28);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(48, 28);
            this.button_filter.TabIndex = 2;
            this.button_filter.Text = "筛选";
            this.button_filter.UseVisualStyleBackColor = true;
            this.button_filter.Click += new System.EventHandler(this.button_filter_Click);
            // 
            // QueryButton
            // 
            this.QueryButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.QueryButton.BackColor = System.Drawing.Color.Transparent;
            this.QueryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QueryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QueryButton.FlatAppearance.BorderSize = 0;
            this.QueryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueryButton.Image = global::PPTPlugin.Properties.Resources.find;
            this.QueryButton.Location = new System.Drawing.Point(177, 13);
            this.QueryButton.MaximumSize = new System.Drawing.Size(32, 32);
            this.QueryButton.MinimumSize = new System.Drawing.Size(28, 28);
            this.QueryButton.Name = "QueryButton";
            this.QueryButton.Size = new System.Drawing.Size(28, 28);
            this.QueryButton.TabIndex = 1;
            this.QueryButton.UseVisualStyleBackColor = false;
            this.QueryButton.Click += new System.EventHandler(this.QueryButton_Click);
            // 
            // VMenu
            // 
            this.VMenu.BackColor = System.Drawing.Color.LightGray;
            this.VMenu.Controls.Add(this.label_MB);
            this.VMenu.Controls.Add(this.label_TL);
            this.VMenu.Controls.Add(this.label_TB);
            this.VMenu.Controls.Add(this.label_SC);
            this.VMenu.Controls.Add(this.label5);
            this.VMenu.Controls.Add(this.label6);
            this.VMenu.Controls.Add(this.label7);
            this.VMenu.Controls.Add(this.label8);
            this.VMenu.Controls.Add(this.label9);
            this.VMenu.Controls.Add(this.label10);
            this.VMenu.Controls.Add(this.label11);
            this.VMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.VMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.VMenu.Location = new System.Drawing.Point(220, 0);
            this.VMenu.Margin = new System.Windows.Forms.Padding(0);
            this.VMenu.MaximumSize = new System.Drawing.Size(40, 0);
            this.VMenu.MinimumSize = new System.Drawing.Size(40, 0);
            this.VMenu.Name = "VMenu";
            this.VMenu.Padding = new System.Windows.Forms.Padding(0, 9, 0, 9);
            this.VMenu.Size = new System.Drawing.Size(40, 600);
            this.VMenu.TabIndex = 3;
            // 
            // label_MB
            // 
            this.label_MB.AutoSize = true;
            this.label_MB.Image = global::PPTPlugin.Properties.Resources.模板;
            this.label_MB.Location = new System.Drawing.Point(0, 9);
            this.label_MB.Margin = new System.Windows.Forms.Padding(0);
            this.label_MB.MaximumSize = new System.Drawing.Size(38, 38);
            this.label_MB.MinimumSize = new System.Drawing.Size(38, 38);
            this.label_MB.Name = "label_MB";
            this.label_MB.Size = new System.Drawing.Size(38, 38);
            this.label_MB.TabIndex = 27;
            this.label_MB.Tag = "0";
            this.toolTip.SetToolTip(this.label_MB, "模板");
            this.label_MB.Click += new System.EventHandler(this.label_Click);
            // 
            // label_TL
            // 
            this.label_TL.AutoSize = true;
            this.label_TL.Image = global::PPTPlugin.Properties.Resources.图例;
            this.label_TL.Location = new System.Drawing.Point(0, 47);
            this.label_TL.Margin = new System.Windows.Forms.Padding(0);
            this.label_TL.MaximumSize = new System.Drawing.Size(38, 38);
            this.label_TL.MinimumSize = new System.Drawing.Size(38, 38);
            this.label_TL.Name = "label_TL";
            this.label_TL.Size = new System.Drawing.Size(38, 38);
            this.label_TL.TabIndex = 28;
            this.label_TL.Tag = "2";
            this.toolTip.SetToolTip(this.label_TL, "图例");
            this.label_TL.Click += new System.EventHandler(this.label_Click);
            // 
            // label_TB
            // 
            this.label_TB.AutoSize = true;
            this.label_TB.Image = global::PPTPlugin.Properties.Resources.图标;
            this.label_TB.Location = new System.Drawing.Point(0, 85);
            this.label_TB.Margin = new System.Windows.Forms.Padding(0);
            this.label_TB.MaximumSize = new System.Drawing.Size(38, 38);
            this.label_TB.MinimumSize = new System.Drawing.Size(38, 38);
            this.label_TB.Name = "label_TB";
            this.label_TB.Size = new System.Drawing.Size(38, 38);
            this.label_TB.TabIndex = 26;
            this.label_TB.Tag = "1";
            this.toolTip.SetToolTip(this.label_TB, "图标");
            this.label_TB.Click += new System.EventHandler(this.label_Click);
            // 
            // label_SC
            // 
            this.label_SC.AutoSize = true;
            this.label_SC.Image = global::PPTPlugin.Properties.Resources.市场;
            this.label_SC.Location = new System.Drawing.Point(0, 123);
            this.label_SC.Margin = new System.Windows.Forms.Padding(0);
            this.label_SC.MaximumSize = new System.Drawing.Size(38, 38);
            this.label_SC.MinimumSize = new System.Drawing.Size(38, 38);
            this.label_SC.Name = "label_SC";
            this.label_SC.Size = new System.Drawing.Size(38, 38);
            this.label_SC.TabIndex = 29;
            this.label_SC.Tag = "3";
            this.toolTip.SetToolTip(this.label_SC, "市场");
            this.label_SC.Click += new System.EventHandler(this.label_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(0, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.MaximumSize = new System.Drawing.Size(38, 38);
            this.label5.MinimumSize = new System.Drawing.Size(38, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 38);
            this.label5.TabIndex = 30;
            this.label5.Tag = "kk";
            this.toolTip.SetToolTip(this.label5, "产品");
            this.label5.Click += new System.EventHandler(this.label_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Image = global::PPTPlugin.Properties.Resources.预测;
            this.label6.Location = new System.Drawing.Point(0, 199);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.MaximumSize = new System.Drawing.Size(38, 38);
            this.label6.MinimumSize = new System.Drawing.Size(38, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 38);
            this.label6.TabIndex = 31;
            this.label6.Tag = "l";
            this.toolTip.SetToolTip(this.label6, "预测");
            this.label6.Click += new System.EventHandler(this.label_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Image = global::PPTPlugin.Properties.Resources.宏观;
            this.label7.Location = new System.Drawing.Point(0, 237);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.MaximumSize = new System.Drawing.Size(38, 38);
            this.label7.MinimumSize = new System.Drawing.Size(38, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 38);
            this.label7.TabIndex = 32;
            this.label7.Tag = "l";
            this.toolTip.SetToolTip(this.label7, "宏观");
            this.label7.Click += new System.EventHandler(this.label_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Image = global::PPTPlugin.Properties.Resources.政策;
            this.label8.Location = new System.Drawing.Point(0, 275);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.MaximumSize = new System.Drawing.Size(38, 38);
            this.label8.MinimumSize = new System.Drawing.Size(38, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 38);
            this.label8.TabIndex = 33;
            this.label8.Tag = "4";
            this.toolTip.SetToolTip(this.label8, "政策");
            this.label8.Click += new System.EventHandler(this.label_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Image = global::PPTPlugin.Properties.Resources.企业;
            this.label9.Location = new System.Drawing.Point(0, 313);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.MaximumSize = new System.Drawing.Size(38, 38);
            this.label9.MinimumSize = new System.Drawing.Size(38, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 38);
            this.label9.TabIndex = 34;
            this.label9.Tag = "l";
            this.toolTip.SetToolTip(this.label9, "企业");
            this.label9.Click += new System.EventHandler(this.label_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Image = global::PPTPlugin.Properties.Resources.车型;
            this.label10.Location = new System.Drawing.Point(0, 351);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.MaximumSize = new System.Drawing.Size(38, 38);
            this.label10.MinimumSize = new System.Drawing.Size(38, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 38);
            this.label10.TabIndex = 35;
            this.label10.Tag = "l";
            this.toolTip.SetToolTip(this.label10, "车型");
            this.label10.Click += new System.EventHandler(this.label_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Image = global::PPTPlugin.Properties.Resources.技术;
            this.label11.Location = new System.Drawing.Point(0, 389);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.MaximumSize = new System.Drawing.Size(38, 38);
            this.label11.MinimumSize = new System.Drawing.Size(38, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 38);
            this.label11.TabIndex = 36;
            this.label11.Tag = "l";
            this.toolTip.SetToolTip(this.label11, "技术");
            this.label11.Click += new System.EventHandler(this.label_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.textBox.HotColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(153)))), ((int)(((byte)(240)))));
            this.textBox.Location = new System.Drawing.Point(54, 15);
            this.textBox.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.textBox.MaximumSize = new System.Drawing.Size(120, 0);
            this.textBox.MinimumSize = new System.Drawing.Size(120, 0);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(120, 25);
            this.textBox.TabIndex = 3;
            this.textBox.WatermarkText = "搜索";
            // 
            // DockWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(leftPlane);
            this.Controls.Add(this.VMenu);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(260, 1080);
            this.MinimumSize = new System.Drawing.Size(250, 400);
            this.Name = "DockWidget";
            this.Size = new System.Drawing.Size(260, 600);
            this.SizeChanged += new System.EventHandler(this.DockWidget_SizeChanged);
            leftPlane.ResumeLayout(false);
            this.LBPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.LTPanel.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.VMenu.ResumeLayout(false);
            this.VMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel VMenu;
        private System.Windows.Forms.Panel LBPanel;
        private System.Windows.Forms.Panel LTPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel resourceList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button QueryButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_prePage;
        private System.Windows.Forms.TextBox pageBox;
        private System.Windows.Forms.Button button_nextPage;
        private System.Windows.Forms.Label labelPage;
        private System.Windows.Forms.Label label_All;
        private System.Windows.Forms.Label label_Mark;
        private System.Windows.Forms.Label label_Records;
        private System.Windows.Forms.Button button_filter;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label_TB;
        private System.Windows.Forms.Label label_MB;
        private System.Windows.Forms.Label label_TL;
        private System.Windows.Forms.Label label_SC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private WinForm.UI.Controls.FTextBox textBox;
    }
}
