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
            this.label_All.BackColor = Color.FromArgb(215, 215, 215);
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
                    
                  
                    if (App.ResourceType == ResourceType.Icon || App.ResourceType == ResourceType.Upload_icon)
                    {
                        pictureBox.SetMarkVisible(false);
                        pictureBox.SetMenuVisible(true);
                        pictureBox.Padding = new Padding(5);
                        pictureBox.ApplyFunction = new PicturePlane.DelegateApply(ApplyIcon);
                    }
                    else if (App.ResourceType == ResourceType.Upload_template || App.ResourceType == ResourceType.Upload_legend)
                    {
                        pictureBox.SetMenuVisible(true);
                        pictureBox.SetMarkVisible(false);
                        pictureBox.ApplyFunction = new PicturePlane.DelegateApply(ApplyTemplate);
                    }
                    else
                    {
                        pictureBox.SetMenuVisible(true);
                        if (resData.MarkFlag == "1"|| App.ItemType == ResourceType.Wdsc)
                        {
                            pictureBox.SetMarkStatus(true);

                        }
                        
                        pictureBox.ApplyFunction = new PicturePlane.DelegateApply(ApplyTemplate);
                    }
                    pictureBox.MarkFunction = new  PicturePlane.DelegateApply(store);
                    pictureBox.UnMarkFunction = new PicturePlane.DelegateApply(unMark);
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
            if(CurrentIndex > 1)
            {
                CurrentIndex--;
            }
            else
            {
                CurrentIndex = PageCount;
            }
           
            labelPage.Text = CurrentIndex + "/" + PageCount;
            //pageBox.Text = CurrentIndex.ToString();
            pageBox.Text = CurrentIndex + "/" + PageCount;
            UpdateResourceList();
        }

        private void button_nextPage_Click(object sender, EventArgs e)
        {
            if (PageCount == 1|| PageCount == 0)
            {
                return;
            }
            if (CurrentIndex == PageCount)
            {
                CurrentIndex = 1;
            }
            else if (CurrentIndex < PageCount)
            {
                CurrentIndex++;
            }
            else
            {
                return;
            }
            labelPage.Text = CurrentIndex + "/" + PageCount;
            //pageBox.Text = CurrentIndex.ToString();
            pageBox.Text = CurrentIndex + "/" + PageCount;
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
            textBox.Text = "";
            Label button = sender as Label;
            this.label_All.BackColor = Color.FromArgb(215, 215, 215);
            this.label_Mark.BackColor = Color.White;
            this.label_Records.BackColor = Color.White;
            if (button != null && button.Text.Equals("模板"))
            {
                button.Tag = ResourceType.Upload_template;
                App.ItemType = ResourceType.Upload_template;
            }
            else
            {
                button.Tag = App.ResourceType;
                App.ItemType = ResourceType.qb;
            }

            afterClick(button.Tag.ToString());
        }

        private void label_Mark_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            Label button = sender as Label;
            this.label_All.BackColor = Color.White;
            this.label_Mark.BackColor = Color.FromArgb(215, 215, 215);
            this.label_Records.BackColor = Color.White;
            if (button != null && button.Text.Equals("图例"))
            {
                button.Tag = ResourceType.Upload_legend;
                App.ItemType = ResourceType.Upload_legend;

            }
            else {
                button.Tag = App.ResourceType;
                App.ItemType = ResourceType.Wdsc;
            }
            //afterClick(App.ItemType.ToString());
            afterClick(button.Tag.ToString());
        }

        private void label_Records_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            Label button = sender as Label;
            this.label_All.BackColor = Color.White;
            this.label_Mark.BackColor = Color.White;
            this.label_Records.BackColor = Color.FromArgb(215, 215, 215);
            if (button != null && button.Text.Equals("图标"))
            {
                button.Tag = ResourceType.Upload_icon;
                App.ItemType = ResourceType.Upload_icon;
            }
            else
            {
                button.Tag = App.ResourceType;
                App.ItemType = ResourceType.Lsjl;

            }
            afterClick(button.Tag.ToString());


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
                    Globals.ThisAddIn.RightWidget.CurrentIndex = 1;
                    Globals.ThisAddIn.RightWidget.FilterText = textBox.Text;
                    Globals.ThisAddIn.RightWidget.pageBox.Text = CurrentIndex.ToString();
                    Globals.ThisAddIn.RightWidget.updateRightLableText();
                    //Globals.ThisAddIn.RightWidget.ResetPageCount();
                    //Globals.ThisAddIn.RightWidget.UpdateResourceList();
                }
               else
               {
                    App.ResourceType = ResourceType.None;
               }
               //ResetButton();
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
            else if (App.ResourceType == ResourceType.Macro)
            {
                group = RequestHandle.GetMacroFilter();
            }
            else if (App.ResourceType == ResourceType.Market)
            {
                group = RequestHandle.GetMarketFilter();
            }
            else if (App.ResourceType == ResourceType.Product)
            {
                group = RequestHandle.GetProductFilter();
            }
            else if (App.ResourceType == ResourceType.Predict)
            {
                group = RequestHandle.GetPredictFilter();
            }
            else if (App.ResourceType == ResourceType.Technology)
            {
                group = RequestHandle.GetTechnologyFilter();
            }
            else if (App.ResourceType == ResourceType.Policy)
            {
                group = RequestHandle.GetPolicyFilter();
            }
            else if (App.ResourceType == ResourceType.Enterprise)
            {
                group = RequestHandle.GetEnterpriseFilter();
            }
            if (group != null)
            {
                filterWidget.AddFilterItem(group);
                filterWidget.ShowDialog();
                List<String> filterList = filterWidget.Selection;
                FilterText = string.Join(",", filterList);
                CurrentIndex = 1;
                UpdateResourceList();
                if (PageCount == 0)
                {
                    pageBox.Text = "1";
                }
                else
                {
                    pageBox.Text = CurrentIndex + "/" + PageCount;
                }
               
            }
        }

        public void updateRightLableText()
        {
            Globals.ThisAddIn.ResetSidebar();
            if (App.ResourceType==ResourceType.Upload_icon || App.ResourceType==ResourceType.Upload_legend || App.ResourceType == ResourceType.Upload_template)
            {
                this.label_All.Text = "模板";
                this.label_Mark.Text = "图标";
                this.label_Records.Text = "图例";
            }
            else
            {
                this.label_All.Text = "全部";
                this.label_Mark.Text = "我的收藏";
                this.label_Records.Text = "历史记录";
          
            }
        }

        public void afterClick(string tag)
        {

               if (Enum.TryParse<ResourceType>(tag, out App.ResourceType))
               {
                    Globals.ThisAddIn.RightWidget.CurrentIndex = 1;
                    Globals.ThisAddIn.RightWidget.FilterText = textBox.Text;
                    Globals.ThisAddIn.RightWidget.pageBox.Text = CurrentIndex.ToString();
                    Globals.ThisAddIn.RightWidget.ResetPageCount();
                    Globals.ThisAddIn.RightWidget.UpdateResourceList();
                }
                else
                {
                    App.ResourceType = ResourceType.None;
                }
                ResetButton();
        }

        private void lable_upload_Click(object sender, EventArgs e)
        {
            label_Click(sender, e);
        }

        private void textBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CurrentIndex = 1;
                FilterText = textBox.Text;
                pageBox.Text = CurrentIndex.ToString();
                UpdateResourceList();
            }
        }
    }
}
