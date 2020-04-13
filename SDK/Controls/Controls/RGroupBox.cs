
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class RGroupBox : GroupBox
    {
        [DefaultValue(true)]
        public bool Checkable
        {
            get 
            {
                return m_isCheckable;
            }
            set
            {
                m_isCheckable = value;
                Refresh();
            }
        }

        [DefaultValue(false)]
        public bool Checked
        {
            get
            {
                return m_checkBox.Checked;
            }
            set
            {
                m_checkBox.Checked = value;
                CheckChange();
                Refresh();
            }
        }

        public override string Text { get; set; }

        public Padding CheckMargin
        {
            get
            {
                return m_margin;
            }
            set
            {
                m_margin = value;
                Refresh();
            }
        }

        public Color BorderColor
        {
            get
            {
                return m_borderColor;
            }
            set
            {
                m_borderColor = value;
                Refresh();
            }
        }

        public FlowLayoutPanel LayoutPanel = new FlowLayoutPanel();
        public RGroupBox()
        {
            InitializeComponent();
            createChecked();
            init();
        }

        public RGroupBox(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            createChecked();
            init();
        }

        void init()
        {
            Text = "";
            m_margin = new Padding(3);
            m_isCheckable = true;
            m_borderColor = Color.DarkGray;
            LayoutPanel.Parent = this;
            LayoutPanel.Dock = DockStyle.Fill;
            this.Controls.Add(LayoutPanel);
            m_checkBox.CheckedChanged += CheckEvent;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            m_checkBox.Text = Text;
            m_checkBox.Visible = m_isCheckable;
            m_checkBox.Location = new Point(10 + m_margin.Left, m_margin.Top);
            Graphics g = e.Graphics;
            Rectangle rect = ClientRectangle;
            rect.Y += m_checkBox.Height / 2;
            rect.Height -= m_checkBox.Height / 2;
            ControlPaint.DrawBorder(g, rect, m_borderColor, ButtonBorderStyle.Solid);
        }


        void createChecked()
        {
            m_checkBox = new CheckBox();
            m_checkBox.AutoSize = true;
            m_checkBox.Parent = this;
            m_checkBox.Text = Text;
            m_checkBox.BringToFront();
        }

        void CheckEvent(object sender, EventArgs e)
        {
            CheckChange();
        }

        void  CheckChange()
        {
            foreach (Control control in LayoutPanel.Controls)
            {
                CheckBox check = control as CheckBox;
                if (check != null)
                {
                    check.Checked = m_checkBox.Checked;
                }
            }
        }

        bool m_isCheckable;
        CheckBox m_checkBox;
        Padding m_margin;
        Color m_borderColor;
    }
}
