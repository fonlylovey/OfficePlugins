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
using CustomControls;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using WinForm.UI.Controls;

namespace PPTPlugin
{
    public partial class DockWidget : UserControl
    {
        public DockWidget()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        public async void UpdateResourceList()
        {
            ResourceModel resModel = await GetResource();
            resourceList.SuspendLayout();
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
           
            
            int index = 1;
            foreach(ResourceData resData in resModel.ResourceList)
            {
                if(index <= resModel.ResourceList.Count && index <= PrePageCount)
                {
                    PicturePlane pictureBox = new PicturePlane();
                    pictureBox.Dock = DockStyle.Fill;
                    pictureBox.SetImage(resModel.ResourceList[index - 1].IconUrl);
                    pictureBox.Picture.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(PictureBoxCtrl_DoubleClick);
                    pictureBox.Tag = resModel.ResourceList[index - 1];
                    pictureBox.Picture.Tag = resModel.ResourceList[index - 1];
                    

                    if (App.ResourceType == ResourceType.Icon)
                    {
                        pictureBox.SetMarkVisible(false);
                        pictureBox.SetMenuVisible(true);
                        pictureBox.Padding = new Padding(5);
                        pictureBox.ApplyFunction = new PicturePlane.DelegateApply(ApplyIcon);
                    }
                    else
                    {
                        pictureBox.SetMenuVisible(true);
                        pictureBox.ApplyFunction = new PicturePlane.DelegateApply(ApplyTemplate);
                    }

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
            resourceList.ResumeLayout();
        }

        private void DockWidget_SizeChanged(object sender, EventArgs e)
        {
            ResetPageCount();
            Update();
        }

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
            }
        }

        private void pageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                if(int.TryParse(pageBox.Text, out int pageIndex))
                {
                    CurrentIndex = pageIndex;
                    labelPage.Text = CurrentIndex + "/" + PageCount;
                    pageBox.Text = CurrentIndex.ToString();
                    UpdateResourceList();
                }
            }
        }

        private void button_prePage_Click(object sender, EventArgs e)
        {
            if(CurrentIndex == 1)
            {
                return;
            }
            CurrentIndex--;
            labelPage.Text = CurrentIndex + "/" + PageCount;
            pageBox.Text = CurrentIndex.ToString();
            UpdateResourceList();
        }

        private void button_nextPage_Click(object sender, EventArgs e)
        {
            if(CurrentIndex == PageCount)
            {
                return;
            }
            CurrentIndex++;
            labelPage.Text = CurrentIndex + "/" + PageCount;
            pageBox.Text = CurrentIndex.ToString();
            UpdateResourceList();
        }

        private void QueryButton_Click(object sender, EventArgs e)
        {
            CurrentIndex = 1;
            FilterText = textBox.Text;
            pageBox.Text = CurrentIndex.ToString();
            UpdateResourceList();
        }

        private void label_All_Click(object sender, EventArgs e)
        {

        }

        private void label_Mark_Click(object sender, EventArgs e)
        {

        }

        private void label_Records_Click(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {
            Label button = sender as Label;
            if (button != null)
            {
                button.BackColor = Color.White;
            }
            if(button.Tag != null)
            {
               if (Enum.TryParse<ResourceType>(button.Tag.ToString(), out App.ResourceType))
                {
                    Globals.ThisAddIn.RightWidget.ResetPageCount();
                    Globals.ThisAddIn.RightWidget.UpdateResourceList();
                }
               else
               {
                    App.ResourceType = ResourceType.None;
               }
               ResetButton();
            }

        }

        private void button_filter_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            FilterWidget filterWidget = new FilterWidget();
            filterWidget.Location = button.PointToScreen(
                new Point(button.Location.X - filterWidget.Width, button.Location.Y));
            List<GroupItem> group = null;
            if (App.ResourceType == ResourceType.Template)
            {
                group = RequestHandle.GetTempFilter();
            }
            else if (App.ResourceType == ResourceType.Legend)
            {
                group = RequestHandle.GetLegendFilter();
            }
            else if (App.ResourceType == ResourceType.Icon)
            {
                group = RequestHandle.GetIconFilter();
            }
            if(group != null)
            {
                filterWidget.AddFilterItem(group);
                filterWidget.ShowDialog();
                List<String> filterList = filterWidget.Selection;
                FilterText = string.Join(",", filterList);
                UpdateResourceList();
            }
        }

    }
}
