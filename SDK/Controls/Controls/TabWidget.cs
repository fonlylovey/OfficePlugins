using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomControls.Controls
{
    public partial class TabWidget : TabControl
    {
        public bool DrawTabButton
        {
            get
            {
                return m_isDrawTabButton;
            }
            set
            {
                m_isDrawTabButton = value;
            }
        }

        public TabWidget()
            : base()
        {
            InitializeComponent();
            base.SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor, true);
            base.UpdateStyles();
        }

        public TabWidget(IContainer container)
            : base()
        {
            container.Add(this);

            InitializeComponent();
            base.SetStyle(
               ControlStyles.UserPaint |
               ControlStyles.DoubleBuffer |
               ControlStyles.OptimizedDoubleBuffer |
               ControlStyles.AllPaintingInWmPaint |
               ControlStyles.ResizeRedraw |
               ControlStyles.SupportsTransparentBackColor, true);
            base.UpdateStyles();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            if(m_isDrawTabButton && SelectedTab != null)
            {
                //pevent.Graphics.FillRectangle(new SolidBrush(Color.White), SelectedTab.ClientRectangle);
                base.OnPaintBackground(pevent);
            }
            else
            {
                pevent.Graphics.FillRectangle(new SolidBrush(Color.White), this.ClientRectangle);
            }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public TabPage CurrentTab 
        {
            get 
            {
                return SelectedTab;
            }
            set
            {
                SelectTab(value);
            }
        }

        private bool m_isDrawTabButton = true;
    }
}
