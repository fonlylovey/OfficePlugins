using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using Controls;
//using System.Windows.Forms;
using Base;
using Core;

namespace Widgets
{
	public partial class ConstructionAlbum : CustomForm
	{
		//调用施工剪影功能的时候有几个固定参数, 随项目变化
		public List<String> DownloadUrls { set; get; }

		public ConstructionAlbum()
		{
			InitializeComponent();
        }

		private async void ConstructionAlbum_LoadAsync(object sender, EventArgs e)
		{
			progressForm.BringToFront();
			progressForm.Visible = true;
			
			//progressForm.SetValue(0);

			//CurrentButton.ForeColor = Color.White;
			//CurrentButton.BackColor = Color.FromArgb(52, 142, 233);

			// progressForm.SetValue(100);
		}


    }

}
