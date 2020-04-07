using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControls
{
	public partial class CustomForm : Form
	{ 
		public int BorderWidth { get; set; } = 0;
		public Color BorderColor { get; set; } = Color.Red;
		public bool DragResizeEnable { get; set; } = false;
		public String TitleText { get; set;}

		public CustomForm()
		{
			InitializeComponent();
		}

		protected void SetTitle(String strTitle)
		{
			TitleText = strTitle;
			label_title.Text = TitleText;
		}

		protected void CustomForm_Paint(object sender, PaintEventArgs e)
		{
			if(BorderWidth > 0)
			{
				Padding = new Padding(BorderWidth);
				Pen pen = new Pen(BorderColor, BorderWidth);
				e.Graphics.DrawRectangle(pen, 0, 0, this.Width - BorderWidth, this.Height - BorderWidth);
				label_title.Text = TitleText;
			}
		}

		protected void CustomForm_MouseDown(object sender, MouseEventArgs e)
		{
			MousePressPos = new Point(e.X, e.Y);
		}

		protected void CustomForm_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				Location = new Point(Location.X + e.X - MousePressPos.X,
					Location.Y + e.Y - MousePressPos.Y);
			}
		}

		protected override void WndProc(ref Message msg)
		{
			switch (msg.Msg)
			{
				case 0x0084:
					if(DragResizeEnable)
					{
						int borderWidth = 10;
						base.WndProc(ref msg);
						Point vPoint = new Point((int)msg.LParam & 0xFFFF,
							(int)msg.LParam >> 16 & 0xFFFF);
						vPoint = PointToClient(vPoint);
						if (vPoint.X <= borderWidth)
						{
							if (vPoint.Y >= ClientSize.Height - borderWidth)
								msg.Result = HT_LeftBottom;
							else msg.Result = HT_Left;
						}
						else if (vPoint.X >= ClientSize.Width - borderWidth)
						{
							if (vPoint.Y >= ClientSize.Height - borderWidth)
								msg.Result = HT_RightBottom;
							else msg.Result = HT_Right;
						}
						else if (vPoint.Y >= ClientSize.Height - borderWidth)
							msg.Result = HT_Bottom;
						Refresh();
					}
					break;
				default:
					base.WndProc(ref msg);
					break;
			}

            FrameEvent();
        }

        protected virtual void FrameEvent()
        {
            
        }

        private Point MousePressPos { get; set; }
		private readonly IntPtr HT_Left = new IntPtr(10);
		private readonly IntPtr HT_Right = new IntPtr(11);
		private readonly IntPtr HT_Bottom = new IntPtr(15);
		private readonly IntPtr HT_LeftBottom = new IntPtr(16);
		private readonly IntPtr HT_RightBottom = new IntPtr(17);
	}
}
