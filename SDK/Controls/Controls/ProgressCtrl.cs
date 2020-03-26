using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControls
{
	public partial class ProgressCtrl : UserControl
	{
        [DescriptionAttribute("进度条的前景色")]
        public Color ChuckColor { get; set; }
		public int Value { get; set; }
		public int Maximum { get; set; }

		public enum ProgressState
		{
			Success,
			Failed,
			Progress
		}

		public ProgressState progressState { get; set; }

		public ProgressCtrl()
		{
			InitializeComponent();
			Value = 0;
			Maximum = 100;
			ChuckColor = Color.FromArgb(0, 142, 250); ;
			progressState = ProgressState.Progress;
        }

		public String GetInfoText()
		{
			return InfoText.Text;
		}

		public void SetInfoText(String strText)
		{
            //判断调用者是否位于创建者（UI的）以外的线程
			if (InvokeRequired)
			{
                //判断垃圾回收线程中是否有基类，判断对象是否被释放
				if (Disposing || IsDisposed)
				{
					return;
				}
                //在拥有控件的基础窗口句柄的线程上，用指定的参数列表执行指定委托。
				DelegateText @delegate = new DelegateText(SetInfoText);
				Invoke(@delegate, strText);
			}
			else
			{
				InfoText.Text = strText;
				Refresh();
			}
		}

		public void SetState(ProgressState state)
		{
			progressState = state;
			StateChange();
		}

		public void SetValue(int value)
		{
			//if中的代码判断是不是异步刷新UI，如果是的话，就Invoke到主线程执行else
			if (InvokeRequired)
			{
				if (Disposing || IsDisposed)
				{
					return;
				}
				DelegateValue @delegate = new DelegateValue(SetValue);
				Invoke(@delegate, value);
			}
			else
			{
				Value = value;
				if (value == 0)
				{
					Maximum = 100;
					ChuckColor = Color.FromArgb(0, 142, 250);
					progressState = ProgressState.Progress;
				}
				else if (value == Maximum)
				{
					progressState = ProgressState.Success;
					Visible = false;
				}
				StateChange();
                Refresh();
			}
		}

		private void StateChange()
		{
			switch (progressState)
			{
				case ProgressState.Success:
					{
						Result.Text = "";
						Result.ImageIndex = 1;
						break;
					}
				case ProgressState.Failed:
					{
						Result.Text = "";   
						Result.ImageIndex = 0;
						break;
					}
				case ProgressState.Progress:
					{
						Result.ImageIndex = -1;
						float ratio = (float)Value / Maximum * 100;
						Result.Text = String.Format("{0}%", ratio);
						break;
					}
			}
		}

		private void Progress_Paint(object sender, PaintEventArgs e)
		{
            //progress控件只是用来方便配置颜色和定位位置宽的的，不显示出来
            SolidBrush brush = new SolidBrush(ChuckColor);
            SolidBrush brushBG = new SolidBrush(progress.BackColor);

            int _height = progress.Height;
            int posX = this.Padding.Left + progress.Location.X;
            int posY = this.Padding.Top  + progress.Location.Y;

            float radio = (float)this.Value / (float)this.Maximum;
            int labelWidth = LayoutMain.Width - this.Padding.Horizontal - LayoutMain.Padding.Horizontal;
            int _width = (int)(labelWidth * radio);

            //绘制背景色
            e.Graphics.FillRectangle(brushBG, posX, posY, progress.Width, _height);

            //绘制前景色
            e.Graphics.FillRectangle(brush, posX, posY, _width, _height);
        }

        private void ProgressCtrl_Load(object sender, EventArgs e)
		{
			Value = 0;
			Maximum = 100;
			ChuckColor = Color.FromArgb(0, 142, 250);
			progressState = ProgressState.Progress;
			StateChange();
			Refresh();
        }

        private void ProgressCtrl_Resize(object sender, EventArgs e)
        {
            Refresh();
        }

        private delegate void DelegateText(String strText);
		private delegate void DelegateValue(int value);

    }
}
