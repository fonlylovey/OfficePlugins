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
using PowerPoint = Microsoft.Office.Interop.PowerPoint;

namespace PPTPlugin
{
    public partial class DockWidget : UserControl
    {
        public DockWidget()
        {
            InitializeComponent();
        }

        public void UpdateResourceList(List<ResourceData> imageList)
        {
            if (resourceList.InvokeRequired)
            {
                if (Disposing || IsDisposed)
                {
                    return;
                }
                ClearControl @delegate = new ClearControl(resourceList.Controls.Clear);
                Invoke(@delegate);
            }
            else
            {
                resourceList.Controls.Clear();
            }
           
            int count = resourceList.RowCount * resourceList.ColumnCount;
            int index = 1;
            foreach(ResourceData resData in imageList)
            {
                if(index < imageList.Count/* && index <= count*/)
                {
                    PictureBoxCtrl pictureBox = new PictureBoxCtrl();
                    pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
                    pictureBox.Margin = new Padding(5);
                    pictureBox.SetImage(imageList[index - 1].IconUrl);
                    pictureBox.pictureBox.Tag = imageList[index - 1];
                    pictureBox.pictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(PictureBoxCtrl_DoubleClick);
                    pictureBox.pictureBox.MouseHover += new System.EventHandler(this.PictureBoxCtrl_MouseHover);
                    
                    if (resourceList.InvokeRequired)
                    {
                        if (Disposing || IsDisposed)
                        {
                            return;
                        }
                        AddControl @delegate = new AddControl(resourceList.Controls.Add);
                        Invoke(@delegate, pictureBox);
                    }
                    else
                    {
                        resourceList.Controls.Add(pictureBox);
                    }
                    
                }
                index++;
            }
        }

        private void DockWidget_SizeChanged(object sender, EventArgs e)
        {
            int listWidgetH = this.Height - 152;
            int rows = listWidgetH / 86;
            if (rows > 0)
            {
                int mod = listWidgetH % 86;
                if(mod > 5)
                {
                    rows++;
                }
                resourceList.RowCount = rows;
                int rowIndex = 0;
                while (rowIndex <= rows)
                {
                    RowStyle rowStyle = new RowStyle(System.Windows.Forms.SizeType.Absolute, 86F);
                    resourceList.RowStyles.Add(rowStyle);
                    rowIndex++;
                }
            }
        }

        private delegate void AddControl(Control control);
        private delegate void ClearControl();

        private async void PictureBoxCtrl_DoubleClick(object sender, MouseEventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            ResourceData resourceData = pictureBox.Tag as ResourceData;
            string strUrl = resourceData.FileUrl;
            string strPath = await Request.HttpDownload(strUrl);
            if (strPath.Contains(".pptx"))
            {
                Globals.ThisAddIn.Application.Presentations.Open(strPath);
            }
            else
            { 
                PowerPoint.Slide slide =  Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
                if(slide != null)
                {
                    slide.Shapes.AddPicture(strPath, Microsoft.Office.Core.MsoTriState.msoFalse,
                        Microsoft.Office.Core.MsoTriState.msoCTrue, 50, 50
                         );
                }
                //Globals.ThisAddIn.Application.ActivePresentation.Slides;
            }
        }

        private void PictureBoxCtrl_MouseHover(object sender, EventArgs e)
        {
            //PictureBoxCtrl pictureBox = sender as PictureBoxCtrl;
            //ResourceData resourceData = pictureBox.picData;
            PictureBox picture = new PictureBox();
            //picture.LoadAsync(resourceData.IconUrl);
            picture.Visible = true;
            picture.Size = new Size(50, 50);
            int xxx = Control.MousePosition.X - picture.Width;
            int yyy = Control.MousePosition.Y + picture.Height;
            picture.Location = new Point();
        }
    }
}
