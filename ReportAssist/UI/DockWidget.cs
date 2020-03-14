using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;
using Controls;

namespace PPTPlugin
{
    public partial class DockWidget : UserControl
    {
        public DockWidget()
        {
            InitializeComponent();
        }

        public void UpdateImageList(List<ResourceData> imageList)
        {
            int index = 0;
            foreach(Control control in tableLayoutPanel1.Controls)
            {
                if(index < imageList.Count)
                {
                    PictureBoxCtrl pictureBox = control as PictureBoxCtrl;
                    pictureBox.SetImage(imageList[index].IconUrl);
                }
                index++;
            }
        }
    }
}
