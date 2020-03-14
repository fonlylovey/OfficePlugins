using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
	public partial class PictureBoxCtrl : UserControl
	{
		public PictureBoxCtrl()
		{
			InitializeComponent();
			checkPicture.Parent = pictureBox;
			checkPicture.Size = new Size(16, 16);
            checkPicture.Visible = isChecked;

        }

        public void SetCheckEnable(bool isCheck)
        {
            checkPicture.Visible = isCheck;
        }

        public void SetVisible(bool isShow)
		{
			if(InvokeRequired)
			{
				if(Disposing || IsDisposed)
				{
					return;
				}
				DelegateVisible @delegate = new DelegateVisible(SetVisible);
				Invoke(@delegate, isShow);
			}
			else
			{
				Visible = isShow;
			}
		}

		public void SetChecked(bool isCheck)
		{
			isChecked = isCheck;
			if (isChecked)
			{
				checkPicture.CheckState = CheckState.Checked;
				checkPicture.BackgroundImage = Properties.Resources.checked_true;
			}
			else
			{
				checkPicture.CheckState = CheckState.Unchecked;
				checkPicture.BackgroundImage = Properties.Resources.checked_false;
			}
			checkPicture.Parent = pictureBox;
		}

		public void SetImage(String strUrl)
		{
			if(strUrl == String.Empty)
			{
				pictureBox.Image = null;
			}
			else
			{
				pictureBox.ImageLocation = strUrl;
			}
			picUrl = strUrl;
		}

		public void SetImage(Image image)
		{
			pictureBox.Image = image;
		}

		public void SetImageUrl(String strUrl)
		{
			picUrl = strUrl;
		}

		private void ControlResize(object sender, EventArgs e)
		{
			pictureBox.Size = this.Size;
		}

		private void CheckedEvent(object sender, EventArgs e)
		{
			if (checkPicture.CheckState == CheckState.Checked)
			{
				checkPicture.CheckState = CheckState.Unchecked;
				checkPicture.BackgroundImage = Properties.Resources.checked_false;
			}
			else
			{
				checkPicture.CheckState = CheckState.Checked;
				checkPicture.BackgroundImage = Properties.Resources.checked_true;
			}
			isChecked = checkPicture.Checked;
			checkPicture.Parent = pictureBox;
		}

		private void CheckPicture(object sender, EventArgs e)
		{
			if (checkPicture.CheckState == CheckState.Checked)
			{
				checkPicture.CheckState = CheckState.Unchecked;
				checkPicture.BackgroundImage = Properties.Resources.checked_false;
			}
			else
			{
				checkPicture.CheckState = CheckState.Checked;
				checkPicture.BackgroundImage = Properties.Resources.checked_true;
			}
			isChecked = checkPicture.Checked;
			checkPicture.Parent = pictureBox;
		}

		public String picUrl { get; set; } = String.Empty;
        public dynamic picData { get; set; } = null;
        public bool isChecked { get; set; } = false;

        public bool isCheckEnable { get; set; } = false;

        private delegate void DelegateVisible(bool isShow);

		private void checkPicture_SizeChanged(object sender, EventArgs e)
		{
			var checkBox = sender as CheckBox;
			if (checkPicture.BackgroundImage != null)
			{
				checkBox.Size = checkPicture.BackgroundImage.Size;
			}
			else
				checkBox.Size = new Size(16, 16);
		}
	}
}
