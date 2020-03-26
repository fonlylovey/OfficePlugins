﻿namespace PPTPlugin
{
    partial class RibbonMenu : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public RibbonMenu()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
            Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
            Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
            Microsoft.Office.Tools.Ribbon.RibbonLabel label3;
            Microsoft.Office.Tools.Ribbon.RibbonLabel label4;
            Microsoft.Office.Tools.Ribbon.RibbonLabel label5;
            Microsoft.Office.Tools.Ribbon.RibbonLabel label6;
            Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
            Microsoft.Office.Tools.Ribbon.RibbonLabel label7;
            Microsoft.Office.Tools.Ribbon.RibbonLabel label8;
            Microsoft.Office.Tools.Ribbon.RibbonLabel label9;
            Microsoft.Office.Tools.Ribbon.RibbonLabel label10;
            Microsoft.Office.Tools.Ribbon.RibbonLabel label15;
            Microsoft.Office.Tools.Ribbon.RibbonGroup group4;
            Microsoft.Office.Tools.Ribbon.RibbonLabel label12;
            Microsoft.Office.Tools.Ribbon.RibbonLabel label13;
            Microsoft.Office.Tools.Ribbon.RibbonLabel label14;
            Microsoft.Office.Tools.Ribbon.RibbonLabel label11;
            Microsoft.Office.Tools.Ribbon.RibbonLabel label16;
            Microsoft.Office.Tools.Ribbon.RibbonGroup group5;
            Microsoft.Office.Tools.Ribbon.RibbonLabel label17;
            Microsoft.Office.Tools.Ribbon.RibbonLabel label18;
            Microsoft.Office.Tools.Ribbon.RibbonLabel label19;
            Microsoft.Office.Tools.Ribbon.RibbonLabel label20;
            Microsoft.Office.Tools.Ribbon.RibbonGroup group6;
            Microsoft.Office.Tools.Ribbon.RibbonLabel label21;
            Microsoft.Office.Tools.Ribbon.RibbonLabel label26;
            Microsoft.Office.Tools.Ribbon.RibbonLabel label22;
            Microsoft.Office.Tools.Ribbon.RibbonLabel label25;
            Microsoft.Office.Tools.Ribbon.RibbonLabel label23;
            Microsoft.Office.Tools.Ribbon.RibbonLabel label24;
            this.button_login = this.Factory.CreateRibbonButton();
            this.button_temp = this.Factory.CreateRibbonButton();
            this.button_sign = this.Factory.CreateRibbonButton();
            this.button_icon = this.Factory.CreateRibbonButton();
            this.button_market = this.Factory.CreateRibbonButton();
            this.button_product = this.Factory.CreateRibbonButton();
            this.button7 = this.Factory.CreateRibbonButton();
            this.button8 = this.Factory.CreateRibbonButton();
            this.button9 = this.Factory.CreateRibbonButton();
            this.button10 = this.Factory.CreateRibbonButton();
            this.button11 = this.Factory.CreateRibbonButton();
            this.button16 = this.Factory.CreateRibbonButton();
            this.button13 = this.Factory.CreateRibbonButton();
            this.button14 = this.Factory.CreateRibbonButton();
            this.button15 = this.Factory.CreateRibbonButton();
            this.button17 = this.Factory.CreateRibbonButton();
            this.button18 = this.Factory.CreateRibbonButton();
            this.tab1 = this.Factory.CreateRibbonTab();
            group1 = this.Factory.CreateRibbonGroup();
            group2 = this.Factory.CreateRibbonGroup();
            label3 = this.Factory.CreateRibbonLabel();
            label4 = this.Factory.CreateRibbonLabel();
            label5 = this.Factory.CreateRibbonLabel();
            label6 = this.Factory.CreateRibbonLabel();
            group3 = this.Factory.CreateRibbonGroup();
            label7 = this.Factory.CreateRibbonLabel();
            label8 = this.Factory.CreateRibbonLabel();
            label9 = this.Factory.CreateRibbonLabel();
            label10 = this.Factory.CreateRibbonLabel();
            label15 = this.Factory.CreateRibbonLabel();
            group4 = this.Factory.CreateRibbonGroup();
            label12 = this.Factory.CreateRibbonLabel();
            label13 = this.Factory.CreateRibbonLabel();
            label14 = this.Factory.CreateRibbonLabel();
            label11 = this.Factory.CreateRibbonLabel();
            label16 = this.Factory.CreateRibbonLabel();
            group5 = this.Factory.CreateRibbonGroup();
            label17 = this.Factory.CreateRibbonLabel();
            label18 = this.Factory.CreateRibbonLabel();
            label19 = this.Factory.CreateRibbonLabel();
            label20 = this.Factory.CreateRibbonLabel();
            group6 = this.Factory.CreateRibbonGroup();
            label21 = this.Factory.CreateRibbonLabel();
            label26 = this.Factory.CreateRibbonLabel();
            label22 = this.Factory.CreateRibbonLabel();
            label25 = this.Factory.CreateRibbonLabel();
            label23 = this.Factory.CreateRibbonLabel();
            label24 = this.Factory.CreateRibbonLabel();
            group1.SuspendLayout();
            group2.SuspendLayout();
            group3.SuspendLayout();
            group4.SuspendLayout();
            group5.SuspendLayout();
            group6.SuspendLayout();
            this.tab1.SuspendLayout();
            this.SuspendLayout();
            // 
            // group1
            // 
            group1.Items.Add(this.button_login);
            group1.Label = "账户";
            group1.Name = "group1";
            // 
            // button_login
            // 
            this.button_login.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_login.Image = global::PPTPlugin.Properties.Resources.Login;
            this.button_login.Label = "登录\n";
            this.button_login.Name = "button_login";
            this.button_login.ShowImage = true;
            this.button_login.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_login_Click);
            // 
            // group2
            // 
            group2.Items.Add(label3);
            group2.Items.Add(this.button_temp);
            group2.Items.Add(label4);
            group2.Items.Add(this.button_sign);
            group2.Items.Add(label5);
            group2.Items.Add(this.button_icon);
            group2.Items.Add(label6);
            group2.Label = "资源";
            group2.Name = "group2";
            // 
            // label3
            // 
            label3.Label = " ";
            label3.Name = "label3";
            // 
            // button_temp
            // 
            this.button_temp.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_temp.Image = global::PPTPlugin.Properties.Resources.ModeLib;
            this.button_temp.Label = "模板库\n";
            this.button_temp.Name = "button_temp";
            this.button_temp.ShowImage = true;
            this.button_temp.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_temp_Click);
            // 
            // label4
            // 
            label4.Label = " ";
            label4.Name = "label4";
            // 
            // button_sign
            // 
            this.button_sign.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_sign.Image = global::PPTPlugin.Properties.Resources.ImageLib;
            this.button_sign.Label = "图例库\n";
            this.button_sign.Name = "button_sign";
            this.button_sign.ShowImage = true;
            this.button_sign.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_sign_Click);
            // 
            // label5
            // 
            label5.Label = " ";
            label5.Name = "label5";
            // 
            // button_icon
            // 
            this.button_icon.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_icon.Image = global::PPTPlugin.Properties.Resources.IconLib;
            this.button_icon.Label = "图标库\n";
            this.button_icon.Name = "button_icon";
            this.button_icon.ShowImage = true;
            this.button_icon.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_icon_Click);
            // 
            // label6
            // 
            label6.Label = " ";
            label6.Name = "label6";
            // 
            // group3
            // 
            group3.Items.Add(label7);
            group3.Items.Add(this.button_market);
            group3.Items.Add(label8);
            group3.Items.Add(this.button_product);
            group3.Items.Add(label9);
            group3.Items.Add(this.button7);
            group3.Items.Add(label10);
            group3.Items.Add(this.button8);
            group3.Items.Add(label15);
            group3.Label = "数据";
            group3.Name = "group3";
            // 
            // label7
            // 
            label7.Label = " ";
            label7.Name = "label7";
            // 
            // button_market
            // 
            this.button_market.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_market.Image = global::PPTPlugin.Properties.Resources.Market;
            this.button_market.Label = "市场\n";
            this.button_market.Name = "button_market";
            this.button_market.ShowImage = true;
            // 
            // label8
            // 
            label8.Label = " ";
            label8.Name = "label8";
            // 
            // button_product
            // 
            this.button_product.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_product.Image = global::PPTPlugin.Properties.Resources.Production;
            this.button_product.Label = "产品\n";
            this.button_product.Name = "button_product";
            this.button_product.ShowImage = true;
            // 
            // label9
            // 
            label9.Label = " ";
            label9.Name = "label9";
            // 
            // button7
            // 
            this.button7.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button7.Image = global::PPTPlugin.Properties.Resources.Prediction;
            this.button7.Label = "预测\n";
            this.button7.Name = "button7";
            this.button7.ShowImage = true;
            // 
            // label10
            // 
            label10.Label = " ";
            label10.Name = "label10";
            // 
            // button8
            // 
            this.button8.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button8.Image = global::PPTPlugin.Properties.Resources.MacroView;
            this.button8.Label = "宏观\n";
            this.button8.Name = "button8";
            this.button8.ShowImage = true;
            // 
            // label15
            // 
            label15.Label = " ";
            label15.Name = "label15";
            // 
            // group4
            // 
            group4.Items.Add(label12);
            group4.Items.Add(this.button9);
            group4.Items.Add(label13);
            group4.Items.Add(this.button10);
            group4.Items.Add(label14);
            group4.Items.Add(this.button11);
            group4.Items.Add(label11);
            group4.Items.Add(this.button16);
            group4.Items.Add(label16);
            group4.Label = "资讯";
            group4.Name = "group4";
            // 
            // label12
            // 
            label12.Label = " ";
            label12.Name = "label12";
            // 
            // button9
            // 
            this.button9.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button9.Image = global::PPTPlugin.Properties.Resources.Policy;
            this.button9.Label = "政策\n";
            this.button9.Name = "button9";
            this.button9.ShowImage = true;
            // 
            // label13
            // 
            label13.Label = " ";
            label13.Name = "label13";
            // 
            // button10
            // 
            this.button10.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button10.Image = global::PPTPlugin.Properties.Resources.Enterprise;
            this.button10.Label = "企业\n";
            this.button10.Name = "button10";
            this.button10.ShowImage = true;
            // 
            // label14
            // 
            label14.Label = " ";
            label14.Name = "label14";
            // 
            // button11
            // 
            this.button11.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button11.Image = global::PPTPlugin.Properties.Resources.CarType;
            this.button11.Label = "车型产品";
            this.button11.Name = "button11";
            this.button11.ShowImage = true;
            // 
            // label11
            // 
            label11.Label = " ";
            label11.Name = "label11";
            // 
            // button16
            // 
            this.button16.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button16.Image = global::PPTPlugin.Properties.Resources.Technology;
            this.button16.Label = "技术\n";
            this.button16.Name = "button16";
            this.button16.ShowImage = true;
            // 
            // label16
            // 
            label16.Label = " ";
            label16.Name = "label16";
            // 
            // group5
            // 
            group5.Items.Add(label17);
            group5.Items.Add(this.button13);
            group5.Items.Add(label18);
            group5.Items.Add(this.button14);
            group5.Items.Add(label19);
            group5.Items.Add(this.button15);
            group5.Items.Add(label20);
            group5.Label = "工具";
            group5.Name = "group5";
            // 
            // label17
            // 
            label17.Label = " ";
            label17.Name = "label17";
            // 
            // button13
            // 
            this.button13.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button13.Image = global::PPTPlugin.Properties.Resources.Export;
            this.button13.Label = "导出\n";
            this.button13.Name = "button13";
            this.button13.ShowImage = true;
            // 
            // label18
            // 
            label18.Label = " ";
            label18.Name = "label18";
            // 
            // button14
            // 
            this.button14.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button14.Image = global::PPTPlugin.Properties.Resources.ZipFile;
            this.button14.Label = "文件压缩";
            this.button14.Name = "button14";
            this.button14.ShowImage = true;
            // 
            // label19
            // 
            label19.Label = " ";
            label19.Name = "label19";
            // 
            // button15
            // 
            this.button15.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button15.Image = global::PPTPlugin.Properties.Resources.Share;
            this.button15.Label = "分享\n";
            this.button15.Name = "button15";
            this.button15.ShowImage = true;
            // 
            // label20
            // 
            label20.Label = " ";
            label20.Name = "label20";
            // 
            // group6
            // 
            group6.Items.Add(label21);
            group6.Items.Add(label26);
            group6.Items.Add(this.button17);
            group6.Items.Add(label22);
            group6.Items.Add(label25);
            group6.Items.Add(this.button18);
            group6.Items.Add(label23);
            group6.Items.Add(label24);
            group6.Label = "更多";
            group6.Name = "group6";
            // 
            // label21
            // 
            label21.Label = " ";
            label21.Name = "label21";
            // 
            // label26
            // 
            label26.Label = " ";
            label26.Name = "label26";
            // 
            // button17
            // 
            this.button17.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button17.Image = global::PPTPlugin.Properties.Resources.AboutUs;
            this.button17.Label = "关于我们";
            this.button17.Name = "button17";
            this.button17.ShowImage = true;
            // 
            // label22
            // 
            label22.Label = " ";
            label22.Name = "label22";
            // 
            // label25
            // 
            label25.Label = " ";
            label25.Name = "label25";
            // 
            // button18
            // 
            this.button18.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button18.Image = global::PPTPlugin.Properties.Resources.Setting;
            this.button18.Label = "设置\n";
            this.button18.Name = "button18";
            this.button18.ShowImage = true;
            // 
            // label23
            // 
            label23.Label = " ";
            label23.Name = "label23";
            // 
            // label24
            // 
            label24.Label = " ";
            label24.Name = "label24";
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(group1);
            this.tab1.Groups.Add(group2);
            this.tab1.Groups.Add(group3);
            this.tab1.Groups.Add(group4);
            this.tab1.Groups.Add(group5);
            this.tab1.Groups.Add(group6);
            this.tab1.Label = "智妍";
            this.tab1.Name = "tab1";
            // 
            // RibbonMenu
            // 
            this.Name = "RibbonMenu";
            this.RibbonType = "Microsoft.PowerPoint.Presentation";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.RibbonMenu_Load);
            group1.ResumeLayout(false);
            group1.PerformLayout();
            group2.ResumeLayout(false);
            group2.PerformLayout();
            group3.ResumeLayout(false);
            group3.PerformLayout();
            group4.ResumeLayout(false);
            group4.PerformLayout();
            group5.ResumeLayout(false);
            group5.PerformLayout();
            group6.ResumeLayout(false);
            group6.PerformLayout();
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_login;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_temp;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_sign;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_icon;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_market;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_product;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button7;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button8;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button9;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button10;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button11;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button16;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button13;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button14;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button15;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button17;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button18;
    }

    partial class ThisRibbonCollection
    {
        internal RibbonMenu RibbonMenu
        {
            get { return this.GetRibbon<RibbonMenu>(); }
        }
    }
}
