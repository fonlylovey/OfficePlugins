
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BIM.Controls
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

        public RGroupBox()
        {
            Text = "";
            m_margin = new Padding(3);
            m_isCheckable = true;
            m_borderColor = Color.DarkGray;
            InitializeComponent();
            createChecked();
        }

        public RGroupBox(IContainer container)
        {
            Text = "";
            m_margin = new Padding(3);
            m_isCheckable = true;
            m_borderColor = Color.DarkGray;
            container.Add(this);
            InitializeComponent();
            createChecked();
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

        bool m_isCheckable;
        CheckBox m_checkBox;
        Padding m_margin;
        Color m_borderColor;
    }
}
