using System;
using System.Windows.Forms;
using Core;
using CustomControls;

namespace Widgets
{

	public partial class PromptBox : CustomForm
    {
		public enum Buttons
		{
			PB_None = 1,
			PB_OK = 2,
			PB_Cancel = 4,
			PB_OKCancel = PB_OK | PB_Cancel
		}


		public PromptBox()
        {
            InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;
            button_OK.Visible = false;
			button_Cancel.Visible = false;
		}

		public PromptBox(Buttons buttons)
		{
			InitializeComponent();
			StartPosition = FormStartPosition.CenterScreen;

            if (buttons == Buttons.PB_OK)
			{
				button_OK.Visible = true;
				button_Cancel.Visible = false;
			}
			else if (buttons == Buttons.PB_Cancel)
			{
				button_OK.Visible = false;
				button_Cancel.Visible = true;
			}
			else if (buttons == Buttons.PB_OKCancel)
			{
				button_OK.Visible = true;
				button_Cancel.Visible = true;
			}
		}

		private void button_OK_Click(object sender, EventArgs e)
		{
			Close();
			Dispose();
		}

		private void button_Cancel_Click(object sender, EventArgs e)
        {
            Close();
			Dispose();
		}

        static public DialogResult Warning( string msg , Buttons button = Buttons.PB_OK, object parent = null)
        {
			PromptBox box = new PromptBox(button);
			box.msgImage.Image = Properties.Resources.Warning_icon;
			box.TitleText = "警告";
			box.message.Text  = msg ;
			box.TopLevel = true;
			box.TopMost = true;
            box.ShowDialog();
            return box.DialogResult;
        }

        static public DialogResult Error( string msg, Buttons button = Buttons.PB_OK, object parent = null)
        {
            PromptBox box = new PromptBox(button);

			box.msgImage.Image = Properties.Resources.Error_icon;
			box.TitleText = "错误";
			box.message.Text = msg;
			box.TopLevel = true;
			box.TopMost = true;
			box.ShowDialog();

            return box.DialogResult;
        }

        static public DialogResult Prompt( string msg, Buttons button = Buttons.PB_OK, object parent = null)
        {
			PromptBox box = new PromptBox(button);
			box.msgImage.Image = Properties.Resources.Success_icon;
			box.message.Text = msg;
			box.TopLevel = true;
			box.TopMost = true;
			box.TitleText = "提示";
			
			box.ShowDialog();

            return box.DialogResult;
        }

	}
}
