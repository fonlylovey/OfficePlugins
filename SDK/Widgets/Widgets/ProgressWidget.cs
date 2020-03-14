using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controls;

namespace Widgets
{
	public partial class ProgressWidget : Form
	{
		public ProgressWidget()
		{
			InitializeComponent();
			this.TopMost = true;
		}

		public ProgressCtrl GetProgressCtrl()
		{
			return progressCtrl;
		}

		public String InfoText()
		{
			return progressCtrl.GetInfoText();
		}

		public void SetInfoText(String strText)
		{
			progressCtrl.SetInfoText(strText);
		}

		public void SetValue(int value)
		{
			progressCtrl.SetValue(value);
			progressCtrl.Visible = true;
			this.TopMost = true;
		}

        public new void Hide()
        {
            if (InvokeRequired)
            {
                if (Disposing || IsDisposed)
                {
                    return;
                }
                DelegateHide @delegate = new DelegateHide(Hide);
                Invoke(@delegate);
            }
            else
            {
                progressCtrl.Visible = false;
                Visible = false;
            }
        }

        private delegate void DelegateHide();
    }
}
