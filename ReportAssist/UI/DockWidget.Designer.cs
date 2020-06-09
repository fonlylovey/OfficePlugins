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
            this.textBox = new WinForm.UI.Controls.FTextBox();
            this.QueryButton = new WinForm.UI.Controls.CirclePictureBox();
            this.VMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.label_MB = new System.Windows.Forms.Label();
            this.label_TL = new System.Windows.Forms.Label();
            this.label_TB = new System.Windows.Forms.Label();
            this.label_SC = new System.Windows.Forms.Label();
            this.label_CP = new System.Windows.Forms.Label();
            this.label_YC = new System.Windows.Forms.Label();
            this.label_HG = new System.Windows.Forms.Label();
            this.label_ZC = new System.Windows.Forms.Label();
            this.label_QY = new System.Windows.Forms.Label();
            this.label_CX = new System.Windows.Forms.Label();
            this.label_JS = new System.Windows.Forms.Label();
            this.lable_upload = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            leftPlane = new System.Windows.Forms.Panel();
            leftPlane.SuspendLayout();
            this.LBPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.LTPanel.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QueryButton)).BeginInit();
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
            leftPlane.Margin = new System.Windows.Forms.Padding(4);
            leftPlane.Name = "leftPlane";
            leftPlane.Size = new System.Drawing.Size(262, 540);
            leftPlane.TabIndex = 8;
            // 
            // LBPanel
            // 
            this.LBPanel.Controls.Add(this.flowLayoutPanel1);
            this.LBPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LBPanel.Location = new System.Drawing.Point(0, 490);
            this.LBPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LBPanel.MaximumSize = new System.Drawing.Size(0, 50);
            this.LBPanel.MinimumSize = new System.Drawing.Size(0, 50);
            this.LBPanel.Name = "LBPanel";
            this.LBPanel.Size = new System.Drawing.Size(262, 50);
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
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(262, 50);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button_prePage
            // 
            this.button_prePage.BackColor = System.Drawing.Color.Transparent;
            this.button_prePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_prePage.FlatAppearance.BorderSize = 0;
            this.button_prePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_prePage.Image = global::PPTPlugin.Properties.Resources.prePage;
            this.button_prePage.Location = new System.Drawing.Point(41, 5);
            this.button_prePage.Margin = new System.Windows.Forms.Padding(35, 5, 11, 0);
            this.button_prePage.MaximumSize = new System.Drawing.Size(40, 40);
            this.button_prePage.MinimumSize = new System.Drawing.Size(40, 40);
            this.button_prePage.Name = "button_prePage";
            this.button_prePage.Size = new System.Drawing.Size(40, 40);
            this.button_prePage.TabIndex = 6;
            this.toolTip.SetToolTip(this.button_prePage, "上一页");
            this.button_prePage.UseVisualStyleBackColor = false;
            this.button_prePage.Click += new System.EventHandler(this.button_prePage_Click);
            // 
            // pageBox
            // 
            this.pageBox.BackColor = System.Drawing.Color.White;
            this.pageBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pageBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pageBox.Location = new System.Drawing.Point(103, 14);
            this.pageBox.Margin = new System.Windows.Forms.Padding(11, 14, 11, 0);
            this.pageBox.MaximumSize = new System.Drawing.Size(48, 32);
            this.pageBox.MaxLength = 32;
            this.pageBox.MinimumSize = new System.Drawing.Size(48, 32);
            this.pageBox.Name = "pageBox";
            this.pageBox.ReadOnly = true;
            this.pageBox.Size = new System.Drawing.Size(48, 24);
            this.pageBox.TabIndex = 9;
            this.pageBox.Text = "1";
            this.pageBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.button_nextPage.Location = new System.Drawing.Point(173, 5);
            this.button_nextPage.Margin = new System.Windows.Forms.Padding(11, 5, 11, 0);
            this.button_nextPage.MaximumSize = new System.Drawing.Size(40, 40);
            this.button_nextPage.MinimumSize = new System.Drawing.Size(40, 40);
            this.button_nextPage.Name = "button_nextPage";
            this.button_nextPage.Size = new System.Drawing.Size(40, 40);
            this.button_nextPage.TabIndex = 7;
            this.toolTip.SetToolTip(this.button_nextPage, "下一页");
            this.button_nextPage.UseVisualStyleBackColor = false;
            this.button_nextPage.Click += new System.EventHandler(this.button_nextPage_Click);
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPage.Location = new System.Drawing.Point(6, 51);
            this.labelPage.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.labelPage.MaximumSize = new System.Drawing.Size(75, 5040);
            this.labelPage.MinimumSize = new System.Drawing.Size(75, 40);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(75, 40);
            this.labelPage.TabIndex = 8;
            this.labelPage.Text = "99/99";
            this.labelPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPage.Visible = false;
            // 
            // resourceList
            // 
            this.resourceList.BackColor = System.Drawing.Color.White;
            this.resourceList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.resourceList.ColumnCount = 2;
            this.resourceList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.resourceList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.resourceList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourceList.Location = new System.Drawing.Point(0, 90);
            this.resourceList.Margin = new System.Windows.Forms.Padding(0);
            this.resourceList.MaximumSize = new System.Drawing.Size(62, 0);
            this.resourceList.MinimumSize = new System.Drawing.Size(262, 0);
            this.resourceList.Name = "resourceList";
            this.resourceList.RowCount = 2;
            this.resourceList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.resourceList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.resourceList.Size = new System.Drawing.Size(262, 450);
            this.resourceList.TabIndex = 7;
            // 
            // LTPanel
            // 
            this.LTPanel.Controls.Add(this.flowLayoutPanel3);
            this.LTPanel.Controls.Add(this.flowLayoutPanel2);
            this.LTPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LTPanel.Location = new System.Drawing.Point(0, 0);
            this.LTPanel.Margin = new System.Windows.Forms.Padding(4);
            this.LTPanel.MaximumSize = new System.Drawing.Size(0, 90);
            this.LTPanel.MinimumSize = new System.Drawing.Size(0, 90);
            this.LTPanel.Name = "LTPanel";
            this.LTPanel.Size = new System.Drawing.Size(262, 90);
            this.LTPanel.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel3.Controls.Add(this.label_All);
            this.flowLayoutPanel3.Controls.Add(this.label_Mark);
            this.flowLayoutPanel3.Controls.Add(this.label_Records);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 55);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel3.MaximumSize = new System.Drawing.Size(0, 38);
            this.flowLayoutPanel3.MinimumSize = new System.Drawing.Size(0, 38);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(262, 38);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // label_All
            // 
            this.label_All.AutoSize = true;
            this.label_All.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_All.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_All.Location = new System.Drawing.Point(42, 0);
            this.label_All.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_All.MinimumSize = new System.Drawing.Size(0, 35);
            this.label_All.Name = "label_All";
            this.label_All.Size = new System.Drawing.Size(39, 35);
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
            this.label_Mark.Location = new System.Drawing.Point(89, 0);
            this.label_Mark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Mark.MinimumSize = new System.Drawing.Size(0, 35);
            this.label_Mark.Name = "label_Mark";
            this.label_Mark.Size = new System.Drawing.Size(69, 35);
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
            this.label_Records.Location = new System.Drawing.Point(166, 0);
            this.label_Records.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Records.MinimumSize = new System.Drawing.Size(0, 35);
            this.label_Records.Name = "label_Records";
            this.label_Records.Size = new System.Drawing.Size(69, 35);
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
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(262, 55);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // button_filter
            // 
            this.button_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(215)))), ((int)(((byte)(215)))));
            this.button_filter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_filter.FlatAppearance.BorderSize = 0;
            this.button_filter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_filter.Location = new System.Drawing.Point(4, 18);
            this.button_filter.Margin = new System.Windows.Forms.Padding(4, 6, 4, 4);
            this.button_filter.MaximumSize = new System.Drawing.Size(62, 30);
            this.button_filter.MinimumSize = new System.Drawing.Size(62, 30);
            this.button_filter.Name = "button_filter";
            this.button_filter.Size = new System.Drawing.Size(62, 30);
            this.button_filter.TabIndex = 6;
            this.button_filter.Text = "筛选";
            this.button_filter.UseVisualStyleBackColor = false;
            this.button_filter.Click += new System.EventHandler(this.button_filter_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.textBox.HotColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(153)))), ((int)(((byte)(240)))));
            this.textBox.Location = new System.Drawing.Point(70, 18);
            this.textBox.Margin = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.textBox.MaximumSize = new System.Drawing.Size(149, 24);
            this.textBox.MinimumSize = new System.Drawing.Size(149, 24);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(149, 29);
            this.textBox.TabIndex = 3;
            this.textBox.WatermarkText = "搜索";
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // QueryButton
            // 
            this.QueryButton.Image = global::PPTPlugin.Properties.Resources.find;
            this.QueryButton.IsSelected = false;
            this.QueryButton.Location = new System.Drawing.Point(223, 18);
            this.QueryButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.QueryButton.MaximumSize = new System.Drawing.Size(30, 30);
            this.QueryButton.MinimumSize = new System.Drawing.Size(30, 30);
            this.QueryButton.MouseMoveImage = null;
            this.QueryButton.Name = "QueryButton";
            this.QueryButton.Padding = new System.Windows.Forms.Padding(4);
            this.QueryButton.SelectedImage = null;
            this.QueryButton.Size = new System.Drawing.Size(30, 30);
            this.QueryButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QueryButton.TabIndex = 5;
            this.QueryButton.TabStop = false;
            this.QueryButton.Click += new System.EventHandler(this.QueryButton_Click);
            // 
            // VMenu
            // 
            this.VMenu.AllowDrop = true;
            this.VMenu.BackColor = System.Drawing.Color.LightGray;
            this.VMenu.Controls.Add(this.label_MB);
            this.VMenu.Controls.Add(this.label_TL);
            this.VMenu.Controls.Add(this.label_TB);
            this.VMenu.Controls.Add(this.label_SC);
            this.VMenu.Controls.Add(this.label_CP);
            this.VMenu.Controls.Add(this.label_YC);
            this.VMenu.Controls.Add(this.label_HG);
            this.VMenu.Controls.Add(this.label_ZC);
            this.VMenu.Controls.Add(this.label_QY);
            this.VMenu.Controls.Add(this.label_CX);
            this.VMenu.Controls.Add(this.label_JS);
            this.VMenu.Controls.Add(this.lable_upload);
            this.VMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.VMenu.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.VMenu.Location = new System.Drawing.Point(262, 0);
            this.VMenu.Margin = new System.Windows.Forms.Padding(0);
            this.VMenu.MaximumSize = new System.Drawing.Size(50, 0);
            this.VMenu.MinimumSize = new System.Drawing.Size(50, 0);
            this.VMenu.Name = "VMenu";
            this.VMenu.Padding = new System.Windows.Forms.Padding(0, 11, 0, 11);
            this.VMenu.Size = new System.Drawing.Size(50, 540);
            this.VMenu.TabIndex = 3;
            this.VMenu.TabStop = true;
            // 
            // label_MB
            // 
            this.label_MB.AutoSize = true;
            this.label_MB.Image = global::PPTPlugin.Properties.Resources.模板;
            this.label_MB.Location = new System.Drawing.Point(2, 11);
            this.label_MB.Margin = new System.Windows.Forms.Padding(0);
            this.label_MB.MaximumSize = new System.Drawing.Size(48, 48);
            this.label_MB.MinimumSize = new System.Drawing.Size(48, 48);
            this.label_MB.Name = "label_MB";
            this.label_MB.Size = new System.Drawing.Size(48, 48);
            this.label_MB.TabIndex = 27;
            this.label_MB.Tag = "0";
            this.toolTip.SetToolTip(this.label_MB, "模板");
            this.label_MB.Click += new System.EventHandler(this.label_Click);
            // 
            // label_TL
            // 
            this.label_TL.AutoSize = true;
            this.label_TL.Image = global::PPTPlugin.Properties.Resources.图例;
            this.label_TL.Location = new System.Drawing.Point(2, 59);
            this.label_TL.Margin = new System.Windows.Forms.Padding(0);
            this.label_TL.MaximumSize = new System.Drawing.Size(48, 48);
            this.label_TL.MinimumSize = new System.Drawing.Size(48, 48);
            this.label_TL.Name = "label_TL";
            this.label_TL.Size = new System.Drawing.Size(48, 48);
            this.label_TL.TabIndex = 28;
            this.label_TL.Tag = "2";
            this.toolTip.SetToolTip(this.label_TL, "图例");
            this.label_TL.Click += new System.EventHandler(this.label_Click);
            // 
            // label_TB
            // 
            this.label_TB.AutoSize = true;
            this.label_TB.Image = global::PPTPlugin.Properties.Resources.图标;
            this.label_TB.Location = new System.Drawing.Point(2, 107);
            this.label_TB.Margin = new System.Windows.Forms.Padding(0);
            this.label_TB.MaximumSize = new System.Drawing.Size(48, 48);
            this.label_TB.MinimumSize = new System.Drawing.Size(48, 48);
            this.label_TB.Name = "label_TB";
            this.label_TB.Size = new System.Drawing.Size(48, 48);
            this.label_TB.TabIndex = 26;
            this.label_TB.Tag = "1";
            this.toolTip.SetToolTip(this.label_TB, "图标");
            this.label_TB.Click += new System.EventHandler(this.label_Click);
            // 
            // label_SC
            // 
            this.label_SC.AutoSize = true;
            this.label_SC.Image = global::PPTPlugin.Properties.Resources.市场;
            this.label_SC.Location = new System.Drawing.Point(2, 155);
            this.label_SC.Margin = new System.Windows.Forms.Padding(0);
            this.label_SC.MaximumSize = new System.Drawing.Size(48, 48);
            this.label_SC.MinimumSize = new System.Drawing.Size(48, 48);
            this.label_SC.Name = "label_SC";
            this.label_SC.Size = new System.Drawing.Size(48, 48);
            this.label_SC.TabIndex = 29;
            this.label_SC.Tag = "3";
            this.toolTip.SetToolTip(this.label_SC, "市场");
            this.label_SC.Click += new System.EventHandler(this.label_Click);
            // 
            // label_CP
            // 
            this.label_CP.AutoSize = true;
            this.label_CP.Image = global::PPTPlugin.Properties.Resources.产品;
            this.label_CP.Location = new System.Drawing.Point(2, 203);
            this.label_CP.Margin = new System.Windows.Forms.Padding(0);
            this.label_CP.MaximumSize = new System.Drawing.Size(48, 48);
            this.label_CP.MinimumSize = new System.Drawing.Size(48, 48);
            this.label_CP.Name = "label_CP";
            this.label_CP.Size = new System.Drawing.Size(48, 48);
            this.label_CP.TabIndex = 30;
            this.label_CP.Tag = "5";
            this.toolTip.SetToolTip(this.label_CP, "产品");
            this.label_CP.Click += new System.EventHandler(this.label_Click);
            // 
            // label_YC
            // 
            this.label_YC.AutoSize = true;
            this.label_YC.Image = global::PPTPlugin.Properties.Resources.预测;
            this.label_YC.Location = new System.Drawing.Point(2, 251);
            this.label_YC.Margin = new System.Windows.Forms.Padding(0);
            this.label_YC.MaximumSize = new System.Drawing.Size(48, 48);
            this.label_YC.MinimumSize = new System.Drawing.Size(48, 48);
            this.label_YC.Name = "label_YC";
            this.label_YC.Size = new System.Drawing.Size(48, 48);
            this.label_YC.TabIndex = 31;
            this.label_YC.Tag = "6";
            this.toolTip.SetToolTip(this.label_YC, "预测");
            this.label_YC.Click += new System.EventHandler(this.label_Click);
            // 
            // label_HG
            // 
            this.label_HG.AutoSize = true;
            this.label_HG.Image = global::PPTPlugin.Properties.Resources.宏观;
            this.label_HG.Location = new System.Drawing.Point(2, 299);
            this.label_HG.Margin = new System.Windows.Forms.Padding(0);
            this.label_HG.MaximumSize = new System.Drawing.Size(48, 48);
            this.label_HG.MinimumSize = new System.Drawing.Size(48, 48);
            this.label_HG.Name = "label_HG";
            this.label_HG.Size = new System.Drawing.Size(48, 48);
            this.label_HG.TabIndex = 32;
            this.label_HG.Tag = "7";
            this.toolTip.SetToolTip(this.label_HG, "宏观");
            this.label_HG.Click += new System.EventHandler(this.label_Click);
            // 
            // label_ZC
            // 
            this.label_ZC.AutoSize = true;
            this.label_ZC.Image = global::PPTPlugin.Properties.Resources.政策;
            this.label_ZC.Location = new System.Drawing.Point(2, 347);
            this.label_ZC.Margin = new System.Windows.Forms.Padding(0);
            this.label_ZC.MaximumSize = new System.Drawing.Size(48, 48);
            this.label_ZC.MinimumSize = new System.Drawing.Size(48, 48);
            this.label_ZC.Name = "label_ZC";
            this.label_ZC.Size = new System.Drawing.Size(48, 48);
            this.label_ZC.TabIndex = 33;
            this.label_ZC.Tag = "4";
            this.toolTip.SetToolTip(this.label_ZC, "政策");
            this.label_ZC.Click += new System.EventHandler(this.label_Click);
            // 
            // label_QY
            // 
            this.label_QY.AutoSize = true;
            this.label_QY.Image = global::PPTPlugin.Properties.Resources.企业;
            this.label_QY.Location = new System.Drawing.Point(2, 395);
            this.label_QY.Margin = new System.Windows.Forms.Padding(0);
            this.label_QY.MaximumSize = new System.Drawing.Size(48, 48);
            this.label_QY.MinimumSize = new System.Drawing.Size(48, 48);
            this.label_QY.Name = "label_QY";
            this.label_QY.Size = new System.Drawing.Size(48, 48);
            this.label_QY.TabIndex = 34;
            this.label_QY.Tag = "14";
            this.toolTip.SetToolTip(this.label_QY, "企业");
            this.label_QY.Click += new System.EventHandler(this.label_Click);
            // 
            // label_CX
            // 
            this.label_CX.AutoSize = true;
            this.label_CX.Image = global::PPTPlugin.Properties.Resources.车型;
            this.label_CX.Location = new System.Drawing.Point(2, 443);
            this.label_CX.Margin = new System.Windows.Forms.Padding(0);
            this.label_CX.MaximumSize = new System.Drawing.Size(48, 48);
            this.label_CX.MinimumSize = new System.Drawing.Size(48, 48);
            this.label_CX.Name = "label_CX";
            this.label_CX.Size = new System.Drawing.Size(48, 48);
            this.label_CX.TabIndex = 35;
            this.label_CX.Tag = "l";
            this.toolTip.SetToolTip(this.label_CX, "车型");
            this.label_CX.Visible = false;
            this.label_CX.Click += new System.EventHandler(this.label_Click);
            // 
            // label_JS
            // 
            this.label_JS.AutoSize = true;
            this.label_JS.Image = global::PPTPlugin.Properties.Resources.技术;
            this.label_JS.Location = new System.Drawing.Point(2, 491);
            this.label_JS.Margin = new System.Windows.Forms.Padding(0);
            this.label_JS.MaximumSize = new System.Drawing.Size(48, 48);
            this.label_JS.MinimumSize = new System.Drawing.Size(48, 48);
            this.label_JS.Name = "label_JS";
            this.label_JS.Size = new System.Drawing.Size(48, 48);
            this.label_JS.TabIndex = 36;
            this.label_JS.Tag = "15";
            this.toolTip.SetToolTip(this.label_JS, "技术");
            this.label_JS.Click += new System.EventHandler(this.label_Click);
            // 
            // lable_upload
            // 
            this.lable_upload.AutoSize = true;
            this.lable_upload.Image = global::PPTPlugin.Properties.Resources.upload_slide;
            this.lable_upload.Location = new System.Drawing.Point(2, 539);
            this.lable_upload.Margin = new System.Windows.Forms.Padding(0);
            this.lable_upload.MaximumSize = new System.Drawing.Size(48, 48);
            this.lable_upload.MinimumSize = new System.Drawing.Size(48, 48);
            this.lable_upload.Name = "lable_upload";
            this.lable_upload.Size = new System.Drawing.Size(48, 48);
            this.lable_upload.TabIndex = 37;
            this.lable_upload.Tag = "8";
            this.toolTip.SetToolTip(this.lable_upload, "我的上传");
            this.lable_upload.Click += new System.EventHandler(this.lable_upload_Click);
            // 
            // DockWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(leftPlane);
            this.Controls.Add(this.VMenu);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(1250, 1350);
            this.MinimumSize = new System.Drawing.Size(312, 540);
            this.Name = "DockWidget";
            this.Size = new System.Drawing.Size(312, 540);
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
            ((System.ComponentModel.ISupportInitialize)(this.QueryButton)).EndInit();
            this.VMenu.ResumeLayout(false);
            this.VMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel VMenu;
        private System.Windows.Forms.Panel LBPanel;
        private System.Windows.Forms.Panel LTPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_prePage;
        private System.Windows.Forms.TextBox pageBox;
        private System.Windows.Forms.Button button_nextPage;
        private System.Windows.Forms.Label labelPage;
        private System.Windows.Forms.Label label_All;
        private System.Windows.Forms.Label label_Mark;
        private System.Windows.Forms.Label label_Records;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label_TB;
        private System.Windows.Forms.Label label_MB;
        private System.Windows.Forms.Label label_TL;
        private System.Windows.Forms.Label label_SC;
        private System.Windows.Forms.Label label_CP;
        private System.Windows.Forms.Label label_YC;
        private System.Windows.Forms.Label label_HG;
        private System.Windows.Forms.Label label_ZC;
        private System.Windows.Forms.Label label_QY;
        private System.Windows.Forms.Label label_CX;
        private System.Windows.Forms.Label label_JS;
        private WinForm.UI.Controls.FTextBox textBox;
        private WinForm.UI.Controls.CirclePictureBox QueryButton;
        private System.Windows.Forms.Button button_filter;
        private System.Windows.Forms.Label lable_upload;
        private System.Windows.Forms.TableLayoutPanel resourceList;
    }
}
