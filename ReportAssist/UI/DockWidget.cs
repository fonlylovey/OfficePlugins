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
            ResourceModel resModel = null;
            switch (App.ResourceType)
            {
                case ResourceType.Template:
                    resModel = await RequestHandle.GetTempList(CurrentIndex, PrePageCount, FilterText, "");
                    break;
                case ResourceType.Icon:
                    resModel = await RequestHandle.GetIconList(CurrentIndex, PrePageCount, FilterText, "");
                    break;
                case ResourceType.legend:
                    resModel = await RequestHandle.GetSignList(CurrentIndex, PrePageCount, FilterText, "");
                    break;
            }
            PageCount = resModel.PageCount;
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
                    pictureBox.ApplyFunction = new PicturePlane.DelegateApply(ApplyTemplate);

                    if (App.ResourceType == ResourceType.Icon)
                    {
                        pictureBox.SetMenuVisible(false);
                        pictureBox.SetPreviewVisible(false);
                        pictureBox.Padding = new Padding(5);
                    }
                    else
                    {
                        pictureBox.SetMenuVisible(true);
                        pictureBox.SetPreviewVisible(true);
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
                //Globals.ThisAddIn.Application.ActivePresentation.Slides;
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
            CurrentIndex--;
            labelPage.Text = CurrentIndex + "/" + PageCount;
            pageBox.Text = CurrentIndex.ToString();
            UpdateResourceList();
        }

        private void button_nextPage_Click(object sender, EventArgs e)
        {
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

        public void ResetPageCount()
        {
            int listWidgetH = this.Height - LTPanel.Height;//减去顶部菜单的高度

            int w = 206;
            int h = 125;
            if (App.ResourceType == ResourceType.Icon)
            {
                resourceList.ColumnCount = 3;
                h = 68;
                w = 68;
            }
            else
            {
                resourceList.ColumnCount = 1;
                h = 125;
                w = 206;
            }

            int rows = listWidgetH / h;
            if (rows > 0)
            {
                int mod = listWidgetH % h;
                if (mod > h)
                {
                    rows++;
                }
                resourceList.RowCount = rows;
                int rowIndex = 0;
                resourceList.RowStyles.Clear();
                resourceList.ColumnStyles.Clear();
                while (rowIndex <= rows)
                {
                    RowStyle rowStyle = new RowStyle(System.Windows.Forms.SizeType.Absolute, h);
                    resourceList.RowStyles.Add(rowStyle);

                    ColumnStyle colStyle = new ColumnStyle(System.Windows.Forms.SizeType.Absolute, w);
                    resourceList.ColumnStyles.Add(colStyle);
                    rowIndex++;
                }
            }
            PrePageCount = resourceList.RowCount * resourceList.ColumnCount;
        }

        private delegate void AddControl(Control control);
        private delegate void ClearControl();
        private int CurrentIndex = 1;
        private int PageCount = 1;
        private int PrePageCount = 5;
        private String FilterText = "";
        public static void ApplyTemplate(Object data)
        {
            ResourceData resourceData = data as ResourceData;
            if(resourceData != null)
            {
                string strUrl = resourceData.FileUrl;
                string strPath = Request.HttpDownload(strUrl).Result;
                Globals.ThisAddIn.Application.Presentations.Open(strPath);
            }
        }

        private void label_All_Click(object sender, EventArgs e)
        {

        }

        private void label_Type_Click(object sender, EventArgs e)
        {

        }

        private void label_Mark_Click(object sender, EventArgs e)
        {

        }

        private void label_Records_Click(object sender, EventArgs e)
        {

        }
    }
}
