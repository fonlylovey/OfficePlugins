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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.QueryButton = new System.Windows.Forms.Button();
            this.VMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton11 = new System.Windows.Forms.RadioButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
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
            leftPlane.Controls.Add(this.LBPanel);
            leftPlane.Controls.Add(this.resourceList);
            leftPlane.Controls.Add(this.LTPanel);
            leftPlane.Dock = System.Windows.Forms.DockStyle.Fill;
            leftPlane.Location = new System.Drawing.Point(0, 0);
            leftPlane.Name = "leftPlane";
            leftPlane.Size = new System.Drawing.Size(210, 600);
            leftPlane.TabIndex = 8;
            // 
            // LBPanel
            // 
            this.LBPanel.Controls.Add(this.flowLayoutPanel1);
            this.LBPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LBPanel.Location = new System.Drawing.Point(0, 548);
            this.LBPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LBPanel.MaximumSize = new System.Drawing.Size(0, 52);
            this.LBPanel.MinimumSize = new System.Drawing.Size(0, 52);
            this.LBPanel.Name = "LBPanel";
            this.LBPanel.Size = new System.Drawing.Size(210, 52);
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
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(210, 52);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // button_prePage
            // 
            this.button_prePage.BackColor = System.Drawing.Color.Transparent;
            this.button_prePage.FlatAppearance.BorderSize = 0;
            this.button_prePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_prePage.ImageKey = "left.png";
            this.button_prePage.Location = new System.Drawing.Point(19, 9);
            this.button_prePage.Margin = new System.Windows.Forms.Padding(9);
            this.button_prePage.MaximumSize = new System.Drawing.Size(32, 32);
            this.button_prePage.MinimumSize = new System.Drawing.Size(32, 32);
            this.button_prePage.Name = "button_prePage";
            this.button_prePage.Size = new System.Drawing.Size(32, 32);
            this.button_prePage.TabIndex = 6;
            this.button_prePage.UseVisualStyleBackColor = false;
            this.button_prePage.Click += new System.EventHandler(this.button_prePage_Click);
            // 
            // pageBox
            // 
            this.pageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pageBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pageBox.Location = new System.Drawing.Point(69, 9);
            this.pageBox.Margin = new System.Windows.Forms.Padding(9);
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
            this.button_nextPage.FlatAppearance.BorderSize = 0;
            this.button_nextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nextPage.ImageKey = "right.png";
            this.button_nextPage.Location = new System.Drawing.Point(119, 9);
            this.button_nextPage.Margin = new System.Windows.Forms.Padding(9);
            this.button_nextPage.MaximumSize = new System.Drawing.Size(32, 32);
            this.button_nextPage.MinimumSize = new System.Drawing.Size(32, 32);
            this.button_nextPage.Name = "button_nextPage";
            this.button_nextPage.Size = new System.Drawing.Size(32, 32);
            this.button_nextPage.TabIndex = 7;
            this.button_nextPage.UseVisualStyleBackColor = false;
            this.button_nextPage.Click += new System.EventHandler(this.button_nextPage_Click);
            // 
            // labelPage
            // 
            this.labelPage.AutoSize = true;
            this.labelPage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPage.Location = new System.Drawing.Point(19, 59);
            this.labelPage.Margin = new System.Windows.Forms.Padding(9);
            this.labelPage.MaximumSize = new System.Drawing.Size(40, 32);
            this.labelPage.MinimumSize = new System.Drawing.Size(40, 32);
            this.labelPage.Name = "labelPage";
            this.labelPage.Size = new System.Drawing.Size(40, 32);
            this.labelPage.TabIndex = 8;
            this.labelPage.Text = "1/5";
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
            this.resourceList.Location = new System.Drawing.Point(0, 82);
            this.resourceList.Margin = new System.Windows.Forms.Padding(0);
            this.resourceList.MaximumSize = new System.Drawing.Size(210, 0);
            this.resourceList.MinimumSize = new System.Drawing.Size(210, 0);
            this.resourceList.Name = "resourceList";
            this.resourceList.RowCount = 2;
            this.resourceList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.resourceList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.resourceList.Size = new System.Drawing.Size(210, 518);
            this.resourceList.TabIndex = 7;
            // 
            // LTPanel
            // 
            this.LTPanel.Controls.Add(this.flowLayoutPanel3);
            this.LTPanel.Controls.Add(this.flowLayoutPanel2);
            this.LTPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.LTPanel.Location = new System.Drawing.Point(0, 0);
            this.LTPanel.MinimumSize = new System.Drawing.Size(0, 82);
            this.LTPanel.Name = "LTPanel";
            this.LTPanel.Size = new System.Drawing.Size(210, 82);
            this.LTPanel.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel3.Controls.Add(this.label_All);
            this.flowLayoutPanel3.Controls.Add(this.label_Mark);
            this.flowLayoutPanel3.Controls.Add(this.label_Records);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 52);
            this.flowLayoutPanel3.MaximumSize = new System.Drawing.Size(0, 30);
            this.flowLayoutPanel3.MinimumSize = new System.Drawing.Size(0, 30);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(210, 30);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // label_All
            // 
            this.label_All.AutoSize = true;
            this.label_All.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_All.Location = new System.Drawing.Point(3, 0);
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
            this.label_Mark.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Mark.Location = new System.Drawing.Point(41, 0);
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
            this.label_Records.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Records.Location = new System.Drawing.Point(103, 0);
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
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Controls.Add(this.textBox);
            this.flowLayoutPanel2.Controls.Add(this.QueryButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(210, 52);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 13);
            this.button1.MaximumSize = new System.Drawing.Size(48, 28);
            this.button1.MinimumSize = new System.Drawing.Size(48, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "筛选";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox
            // 
            this.textBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox.Location = new System.Drawing.Point(57, 13);
            this.textBox.MinimumSize = new System.Drawing.Size(110, 28);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(110, 26);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "搜索";
            // 
            // QueryButton
            // 
            this.QueryButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.QueryButton.BackColor = System.Drawing.Color.Transparent;
            this.QueryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QueryButton.FlatAppearance.BorderSize = 0;
            this.QueryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueryButton.ImageKey = "(无)";
            this.QueryButton.Location = new System.Drawing.Point(173, 13);
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
            this.VMenu.Controls.Add(this.radioButton1);
            this.VMenu.Controls.Add(this.radioButton2);
            this.VMenu.Controls.Add(this.radioButton3);
            this.VMenu.Controls.Add(this.radioButton4);
            this.VMenu.Controls.Add(this.radioButton5);
            this.VMenu.Controls.Add(this.radioButton6);
            this.VMenu.Controls.Add(this.radioButton7);
            this.VMenu.Controls.Add(this.radioButton8);
            this.VMenu.Controls.Add(this.radioButton9);
            this.VMenu.Controls.Add(this.radioButton10);
            this.VMenu.Controls.Add(this.radioButton11);
            this.VMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.VMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.VMenu.Location = new System.Drawing.Point(210, 0);
            this.VMenu.Margin = new System.Windows.Forms.Padding(0);
            this.VMenu.MaximumSize = new System.Drawing.Size(40, 0);
            this.VMenu.MinimumSize = new System.Drawing.Size(40, 0);
            this.VMenu.Name = "VMenu";
            this.VMenu.Padding = new System.Windows.Forms.Padding(0, 9, 9, 9);
            this.VMenu.Size = new System.Drawing.Size(40, 600);
            this.VMenu.TabIndex = 3;
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.AutoSize = true;
            this.radioButton1.FlatAppearance.BorderSize = 0;
            this.radioButton1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.radioButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.radioButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton1.Image = global::PPTPlugin.Properties.Resources.模板;
            this.radioButton1.Location = new System.Drawing.Point(0, 14);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.radioButton1.MaximumSize = new System.Drawing.Size(32, 32);
            this.radioButton1.MinimumSize = new System.Drawing.Size(32, 32);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(32, 32);
            this.radioButton1.TabIndex = 15;
            this.radioButton1.TabStop = true;
            this.toolTip.SetToolTip(this.radioButton1, "模板");
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.AutoSize = true;
            this.radioButton2.FlatAppearance.BorderSize = 0;
            this.radioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.radioButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.radioButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Image = global::PPTPlugin.Properties.Resources.图标;
            this.radioButton2.Location = new System.Drawing.Point(0, 56);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.radioButton2.MaximumSize = new System.Drawing.Size(32, 32);
            this.radioButton2.MinimumSize = new System.Drawing.Size(32, 32);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(32, 32);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.toolTip.SetToolTip(this.radioButton2, "图标");
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton3.AutoSize = true;
            this.radioButton3.FlatAppearance.BorderSize = 0;
            this.radioButton3.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.radioButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.radioButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Image = global::PPTPlugin.Properties.Resources.图例;
            this.radioButton3.Location = new System.Drawing.Point(0, 98);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.radioButton3.MaximumSize = new System.Drawing.Size(32, 32);
            this.radioButton3.MinimumSize = new System.Drawing.Size(32, 32);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(32, 32);
            this.radioButton3.TabIndex = 17;
            this.radioButton3.TabStop = true;
            this.toolTip.SetToolTip(this.radioButton3, "图例");
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton4.AutoSize = true;
            this.radioButton4.FlatAppearance.BorderSize = 0;
            this.radioButton4.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.radioButton4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.radioButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radioButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton4.Image = global::PPTPlugin.Properties.Resources.市场;
            this.radioButton4.Location = new System.Drawing.Point(0, 140);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.radioButton4.MaximumSize = new System.Drawing.Size(32, 32);
            this.radioButton4.MinimumSize = new System.Drawing.Size(32, 32);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(32, 32);
            this.radioButton4.TabIndex = 18;
            this.radioButton4.TabStop = true;
            this.toolTip.SetToolTip(this.radioButton4, "市场");
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton5.AutoSize = true;
            this.radioButton5.FlatAppearance.BorderSize = 0;
            this.radioButton5.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.radioButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.radioButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radioButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton5.Image = global::PPTPlugin.Properties.Resources.产品;
            this.radioButton5.Location = new System.Drawing.Point(0, 182);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.radioButton5.MaximumSize = new System.Drawing.Size(32, 32);
            this.radioButton5.MinimumSize = new System.Drawing.Size(32, 32);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(32, 32);
            this.radioButton5.TabIndex = 19;
            this.radioButton5.TabStop = true;
            this.toolTip.SetToolTip(this.radioButton5, "产品");
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton6.AutoSize = true;
            this.radioButton6.FlatAppearance.BorderSize = 0;
            this.radioButton6.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.radioButton6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.radioButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radioButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton6.Image = global::PPTPlugin.Properties.Resources.预测;
            this.radioButton6.Location = new System.Drawing.Point(0, 224);
            this.radioButton6.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.radioButton6.MaximumSize = new System.Drawing.Size(32, 32);
            this.radioButton6.MinimumSize = new System.Drawing.Size(32, 32);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(32, 32);
            this.radioButton6.TabIndex = 20;
            this.radioButton6.TabStop = true;
            this.toolTip.SetToolTip(this.radioButton6, "预测");
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            this.radioButton7.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton7.AutoSize = true;
            this.radioButton7.FlatAppearance.BorderSize = 0;
            this.radioButton7.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.radioButton7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.radioButton7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radioButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton7.Image = global::PPTPlugin.Properties.Resources.宏观;
            this.radioButton7.Location = new System.Drawing.Point(0, 266);
            this.radioButton7.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.radioButton7.MaximumSize = new System.Drawing.Size(32, 32);
            this.radioButton7.MinimumSize = new System.Drawing.Size(32, 32);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(32, 32);
            this.radioButton7.TabIndex = 21;
            this.radioButton7.TabStop = true;
            this.toolTip.SetToolTip(this.radioButton7, "宏观");
            this.radioButton7.UseVisualStyleBackColor = true;
            // 
            // radioButton8
            // 
            this.radioButton8.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton8.AutoSize = true;
            this.radioButton8.FlatAppearance.BorderSize = 0;
            this.radioButton8.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.radioButton8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.radioButton8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radioButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton8.Image = global::PPTPlugin.Properties.Resources.政策;
            this.radioButton8.Location = new System.Drawing.Point(0, 308);
            this.radioButton8.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.radioButton8.MaximumSize = new System.Drawing.Size(32, 32);
            this.radioButton8.MinimumSize = new System.Drawing.Size(32, 32);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(32, 32);
            this.radioButton8.TabIndex = 22;
            this.radioButton8.TabStop = true;
            this.toolTip.SetToolTip(this.radioButton8, "政策");
            this.radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            this.radioButton9.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton9.AutoSize = true;
            this.radioButton9.FlatAppearance.BorderSize = 0;
            this.radioButton9.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.radioButton9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.radioButton9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radioButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton9.Image = global::PPTPlugin.Properties.Resources.企业;
            this.radioButton9.Location = new System.Drawing.Point(0, 350);
            this.radioButton9.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.radioButton9.MaximumSize = new System.Drawing.Size(32, 32);
            this.radioButton9.MinimumSize = new System.Drawing.Size(32, 32);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(32, 32);
            this.radioButton9.TabIndex = 23;
            this.radioButton9.TabStop = true;
            this.toolTip.SetToolTip(this.radioButton9, "企业");
            this.radioButton9.UseVisualStyleBackColor = true;
            // 
            // radioButton10
            // 
            this.radioButton10.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton10.AutoSize = true;
            this.radioButton10.FlatAppearance.BorderSize = 0;
            this.radioButton10.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.radioButton10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.radioButton10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radioButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton10.Image = global::PPTPlugin.Properties.Resources.车型;
            this.radioButton10.Location = new System.Drawing.Point(0, 392);
            this.radioButton10.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.radioButton10.MaximumSize = new System.Drawing.Size(32, 32);
            this.radioButton10.MinimumSize = new System.Drawing.Size(32, 32);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(32, 32);
            this.radioButton10.TabIndex = 24;
            this.radioButton10.TabStop = true;
            this.toolTip.SetToolTip(this.radioButton10, "车型");
            this.radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            this.radioButton11.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton11.AutoSize = true;
            this.radioButton11.FlatAppearance.BorderSize = 0;
            this.radioButton11.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.radioButton11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.radioButton11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.radioButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton11.Image = global::PPTPlugin.Properties.Resources.技术;
            this.radioButton11.Location = new System.Drawing.Point(0, 434);
            this.radioButton11.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.radioButton11.MaximumSize = new System.Drawing.Size(32, 32);
            this.radioButton11.MinimumSize = new System.Drawing.Size(32, 32);
            this.radioButton11.Name = "radioButton11";
            this.radioButton11.Size = new System.Drawing.Size(32, 32);
            this.radioButton11.TabIndex = 25;
            this.radioButton11.TabStop = true;
            this.radioButton11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip.SetToolTip(this.radioButton11, "技术");
            this.radioButton11.UseVisualStyleBackColor = true;
            // 
            // DockWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(leftPlane);
            this.Controls.Add(this.VMenu);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(280, 1080);
            this.MinimumSize = new System.Drawing.Size(250, 600);
            this.Name = "DockWidget";
            this.Size = new System.Drawing.Size(250, 600);
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
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button QueryButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button_prePage;
        private System.Windows.Forms.TextBox pageBox;
        private System.Windows.Forms.Button button_nextPage;
        private System.Windows.Forms.Label labelPage;
        private System.Windows.Forms.Label label_All;
        private System.Windows.Forms.Label label_Mark;
        private System.Windows.Forms.Label label_Records;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.RadioButton radioButton11;
    }
}
