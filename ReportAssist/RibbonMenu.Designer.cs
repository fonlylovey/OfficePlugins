namespace PPTPlugin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonMenu));
            Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
            Microsoft.Office.Tools.Ribbon.RibbonGroup group4;
            Microsoft.Office.Tools.Ribbon.RibbonGroup group5;
            Microsoft.Office.Tools.Ribbon.RibbonGroup group6;
            this.button_login = this.Factory.CreateRibbonButton();
            this.button_temp = this.Factory.CreateRibbonButton();
            this.button_sign = this.Factory.CreateRibbonButton();
            this.button_icon = this.Factory.CreateRibbonButton();
            this.button_image = this.Factory.CreateRibbonButton();
            this.button_market = this.Factory.CreateRibbonButton();
            this.button_product = this.Factory.CreateRibbonButton();
            this.button7 = this.Factory.CreateRibbonButton();
            this.button8 = this.Factory.CreateRibbonButton();
            this.button9 = this.Factory.CreateRibbonButton();
            this.button10 = this.Factory.CreateRibbonButton();
            this.button11 = this.Factory.CreateRibbonButton();
            this.button16 = this.Factory.CreateRibbonButton();
            this.button20 = this.Factory.CreateRibbonButton();
            this.button13 = this.Factory.CreateRibbonButton();
            this.button14 = this.Factory.CreateRibbonButton();
            this.button15 = this.Factory.CreateRibbonButton();
            this.button17 = this.Factory.CreateRibbonButton();
            this.button18 = this.Factory.CreateRibbonButton();
            this.tab1 = this.Factory.CreateRibbonTab();
            group1 = this.Factory.CreateRibbonGroup();
            group2 = this.Factory.CreateRibbonGroup();
            group3 = this.Factory.CreateRibbonGroup();
            group4 = this.Factory.CreateRibbonGroup();
            group5 = this.Factory.CreateRibbonGroup();
            group6 = this.Factory.CreateRibbonGroup();
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
            this.button_login.Label = " 登录";
            this.button_login.Name = "button_login";
            this.button_login.ShowImage = true;
            this.button_login.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_login_Click);
            // 
            // group2
            // 
            group2.Items.Add(this.button_temp);
            group2.Items.Add(this.button_sign);
            group2.Items.Add(this.button_icon);
            group2.Items.Add(this.button_image);
            group2.Label = "资源";
            group2.Name = "group2";
            // 
            // button_temp
            // 
            this.button_temp.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_temp.Image = global::PPTPlugin.Properties.Resources.ModeLib;
            this.button_temp.Label = "模板库";
            this.button_temp.Name = "button_temp";
            this.button_temp.ShowImage = true;
            this.button_temp.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_temp_Click);
            // 
            // button_sign
            // 
            this.button_sign.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_sign.Image = ((System.Drawing.Image)(resources.GetObject("button_sign.Image")));
            this.button_sign.Label = "图例库";
            this.button_sign.Name = "button_sign";
            this.button_sign.ShowImage = true;
            this.button_sign.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_sign_Click);
            // 
            // button_icon
            // 
            this.button_icon.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_icon.Image = global::PPTPlugin.Properties.Resources.IconLib;
            this.button_icon.Label = "图标库";
            this.button_icon.Name = "button_icon";
            this.button_icon.ShowImage = true;
            this.button_icon.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_icon_Click);
            // 
            // button_image
            // 
            this.button_image.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_image.Image = global::PPTPlugin.Properties.Resources.ImageLib;
            this.button_image.Label = " 图片库";
            this.button_image.Name = "button_image";
            this.button_image.ShowImage = true;
            this.button_image.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button_image_Click);
            // 
            // group3
            // 
            group3.Items.Add(this.button_market);
            group3.Items.Add(this.button_product);
            group3.Items.Add(this.button7);
            group3.Items.Add(this.button8);
            group3.Label = "数据";
            group3.Name = "group3";
            // 
            // button_market
            // 
            this.button_market.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_market.Image = global::PPTPlugin.Properties.Resources.Market;
            this.button_market.Label = "市场";
            this.button_market.Name = "button_market";
            this.button_market.ShowImage = true;
            // 
            // button_product
            // 
            this.button_product.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button_product.Image = global::PPTPlugin.Properties.Resources.Production;
            this.button_product.Label = "产品";
            this.button_product.Name = "button_product";
            this.button_product.ShowImage = true;
            // 
            // button7
            // 
            this.button7.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button7.Image = global::PPTPlugin.Properties.Resources.Prediction;
            this.button7.Label = "预测";
            this.button7.Name = "button7";
            this.button7.ShowImage = true;
            // 
            // button8
            // 
            this.button8.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button8.Image = global::PPTPlugin.Properties.Resources.MacroView;
            this.button8.Label = "宏观";
            this.button8.Name = "button8";
            this.button8.ShowImage = true;
            // 
            // group4
            // 
            group4.Items.Add(this.button9);
            group4.Items.Add(this.button10);
            group4.Items.Add(this.button11);
            group4.Items.Add(this.button16);
            group4.Items.Add(this.button20);
            group4.Label = "咨询";
            group4.Name = "group4";
            // 
            // button9
            // 
            this.button9.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button9.Image = global::PPTPlugin.Properties.Resources.Policy;
            this.button9.Label = "政策";
            this.button9.Name = "button9";
            this.button9.ShowImage = true;
            // 
            // button10
            // 
            this.button10.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button10.Image = global::PPTPlugin.Properties.Resources.Enterprise;
            this.button10.Label = "企业";
            this.button10.Name = "button10";
            this.button10.ShowImage = true;
            // 
            // button11
            // 
            this.button11.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button11.Image = global::PPTPlugin.Properties.Resources.CarType;
            this.button11.Label = "车型产品";
            this.button11.Name = "button11";
            this.button11.ShowImage = true;
            // 
            // button16
            // 
            this.button16.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button16.Image = global::PPTPlugin.Properties.Resources.Technology;
            this.button16.Label = "技术";
            this.button16.Name = "button16";
            this.button16.ShowImage = true;
            // 
            // button20
            // 
            this.button20.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button20.Image = global::PPTPlugin.Properties.Resources.MarkInfo;
            this.button20.Label = "市场";
            this.button20.Name = "button20";
            this.button20.ShowImage = true;
            // 
            // group5
            // 
            group5.Items.Add(this.button13);
            group5.Items.Add(this.button14);
            group5.Items.Add(this.button15);
            group5.Label = "工具";
            group5.Name = "group5";
            // 
            // button13
            // 
            this.button13.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button13.Image = global::PPTPlugin.Properties.Resources.Export;
            this.button13.Label = "导出";
            this.button13.Name = "button13";
            this.button13.ShowImage = true;
            // 
            // button14
            // 
            this.button14.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button14.Image = global::PPTPlugin.Properties.Resources.ZipFile;
            this.button14.Label = "文件压缩";
            this.button14.Name = "button14";
            this.button14.ShowImage = true;
            // 
            // button15
            // 
            this.button15.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button15.Image = global::PPTPlugin.Properties.Resources.Share;
            this.button15.Label = "分享";
            this.button15.Name = "button15";
            this.button15.ShowImage = true;
            // 
            // group6
            // 
            group6.Items.Add(this.button17);
            group6.Items.Add(this.button18);
            group6.Label = "更多";
            group6.Name = "group6";
            // 
            // button17
            // 
            this.button17.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button17.Image = global::PPTPlugin.Properties.Resources.AboutUs;
            this.button17.Label = "关于我们";
            this.button17.Name = "button17";
            this.button17.ShowImage = true;
            // 
            // button18
            // 
            this.button18.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.button18.Image = global::PPTPlugin.Properties.Resources.Setting;
            this.button18.Label = "设置";
            this.button18.Name = "button18";
            this.button18.ShowImage = true;
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
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_image;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_market;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button_product;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button7;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button8;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button9;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button10;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button11;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button16;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button20;
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
