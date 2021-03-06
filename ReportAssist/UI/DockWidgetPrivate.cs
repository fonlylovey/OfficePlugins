﻿using Core;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Widgets;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;

namespace PPTPlugin
{
    partial class DockWidget
    {
        private delegate void AddControl(Control control);
        private delegate void ClearControl();
        private int CurrentIndex = 1;
        private int PageCount = 1;
        private int PrePageCount = 5;
        private String FilterText = "";
        ProgressWidget progress = new ProgressWidget();
        public void ResetButton()
        {
            foreach (Control control in VMenu.Controls)
            {
                control.BackColor = Color.Transparent;
                if (control.Tag != null)
                {
                    if (Enum.TryParse<ResourceType>(control.Tag.ToString(), out ResourceType type))
                    {
                        if (type == App.ResourceType)
                        {
                            control.BackColor = Color.White;
                        }
                    }
                }
            }
            //pageBox.Text = CurrentIndex + "/" + PageCount;
        }

        public static async void ApplyTemplate(Object data)
        {
            ResourceData resourceData = data as ResourceData;
            if (resourceData != null)
            {
                string strUrl = resourceData.FileUrl;
                string strPath = Request.HttpDownload(strUrl).Result;
                JObject jObject = new JObject();
                jObject.Add("sjh", Rigel.UserID);
                jObject.Add("lb", App.ResourceType.ToString());
                jObject.Add("tmid", resourceData.ID);
                String strAPI = "{0}/ppttools/lsjl/save?token={1}";
                String url = String.Format(strAPI, Rigel.ServerUrl, Rigel.UserToken);
                Request.HttpPost(jObject, url);
                PowerPoint.Presentation currentPPT = Globals.ThisAddIn.Application.ActivePresentation;

                if (App.ResourceType == ResourceType.Template || App.ResourceType == ResourceType.Upload_template)
                {
                    Globals.ThisAddIn.Application.Presentations.Open(strPath);
                }
                else
                {
                    if (currentPPT.Slides.Count > 0)
                    {
                        PowerPoint.Slide currentIndexPPT = (PowerPoint.Slide)Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
                        currentPPT.Slides.InsertFromFile(strPath, currentIndexPPT.SlideIndex, 1, -1);
                        currentPPT. = currentIndexPPT.SlideIndex + 1;
                    }
                    else
                    {
                        currentPPT.Slides.InsertFromFile(strPath, 0, 1, -1);
                    }
                }


                if (App.ResourceType == ResourceType.Predict)
                {
                    string id = resourceData.ID;
                    
                    WriteSlide writer = new WriteSlide();
                    if (id.Equals("100"))
                    {
                        await writer.WriteDataFor100("164");
                    }
                    else if (id.Equals("164"))
                    {
                        await writer.WriteDataFor164();
                    }
                        
                }
            }
        }

        public static async void store(Object data)
        {
            ResourceData resourceData = data as ResourceData;
            if (resourceData != null)
            {
                Newtonsoft.Json.Linq.JObject jObject = new Newtonsoft.Json.Linq.JObject();
                jObject.Add("sjh", Rigel.UserID);
                jObject.Add("lb", App.ResourceType.ToString());
                jObject.Add("tmid", resourceData.ID.ToString());
                jObject.Add("scsj", DateTime.Now.Date.ToString("yyyyMMddHHmmss"));
                await RequestHandle.Wdsc(jObject);
            }

        }

        public static async void unMark(Object data)
        {
            ResourceData resourceData = data as ResourceData;
            if (resourceData != null)
            {
                Newtonsoft.Json.Linq.JObject jObject = new Newtonsoft.Json.Linq.JObject();
                jObject.Add("sjh", Rigel.UserID);
                jObject.Add("lb", App.ResourceType.ToString());
                jObject.Add("tmid", resourceData.ID.ToString());
                await RequestHandle.delWdsc(jObject);
            }
        }
     
        public static void ApplyIcon(Object data)
        {
            ResourceData resourceData = data as ResourceData;
            if (resourceData != null)
            {
                string strUrl = resourceData.FileUrl;
                string strPath = Request.HttpDownload(strUrl).Result;
                JObject jObject = new JObject();
                jObject.Add("sjh", Rigel.UserID);
                jObject.Add("lb", App.ResourceType.ToString());
                jObject.Add("tmid", resourceData.ID);
                String strAPI = "{0}/ppttools/lsjl/save?token={1}";
                String url = String.Format(strAPI, Rigel.ServerUrl, Rigel.UserToken);
                Request.HttpPost(jObject, url);
                Image image = Image.FromFile(strPath);

                PowerPoint.Slide slide = Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
                if (slide != null)
                {
                    PowerPoint.Shape shape = slide.Shapes.AddPicture(strPath,
                        Microsoft.Office.Core.MsoTriState.msoFalse,
                        Microsoft.Office.Core.MsoTriState.msoCTrue, 50, 50);
                    /* if(shape != null && slide.ColorScheme.Count > 0)
                     {
                         PowerPoint.RGBColor color = slide.ColorScheme._Index(slide.ColorScheme.Count) as PowerPoint.RGBColor;
                         shape.Fill.ForeColor.RGB = color.RGB;
                     }*/
                }
            }
        }


        private async Task<ResourceModel> GetResource()
        {
            ResourceModel resModel = null;
            switch (App.ResourceType)
            {
                case ResourceType.Template:
                case ResourceType.Product:
                case ResourceType.Predict:
                case ResourceType.Macro:
                case ResourceType.Market:
                case ResourceType.Policy:
                case ResourceType.Enterprise:
                case ResourceType.Technology:
                case ResourceType.Wxreport:
                case ResourceType.Lsbg:
                    if (App.ItemType == ResourceType.Wdsc)
                    {
                        resModel = await RequestHandle.GetWdscList(CurrentIndex, PrePageCount, "", FilterText);
                    }
                    else if (App.ItemType == ResourceType.Lsjl)
                    {
                        resModel = await RequestHandle.GetLsjlList(CurrentIndex, PrePageCount, "", FilterText);
                    }
                    else if (App.ItemType == ResourceType.Lsbg)
                    {
                        resModel = await RequestHandle.GetLsbgList(CurrentIndex, PrePageCount, "", FilterText);
                    }
                    else
                    {
                        resModel = await RequestHandle.GetTempList(CurrentIndex, PrePageCount, "", FilterText);
                    }

                    break;
                case ResourceType.Icon:
                    if (App.ItemType == ResourceType.Wdsc)
                    {
                        resModel = await RequestHandle.GetWdscList(CurrentIndex, PrePageCount, "", FilterText);
                    }
                    else if (App.ItemType == ResourceType.Lsjl)
                    {
                        resModel = await RequestHandle.GetLsjlList(CurrentIndex, PrePageCount, "", FilterText);
                    }
                    else
                    {
                        resModel = await RequestHandle.GetIconList(CurrentIndex, PrePageCount, "", FilterText);
                    }
                    break;
                case ResourceType.Legend:
                    if (App.ItemType == ResourceType.Wdsc)
                    {
                        resModel = await RequestHandle.GetWdscList(CurrentIndex, PrePageCount, "", FilterText);
                    }
                    else if (App.ItemType == ResourceType.Lsjl)
                    {
                        resModel = await RequestHandle.GetLsjlList(CurrentIndex, PrePageCount, "", FilterText);
                    }
                    else
                    {
                        resModel = await RequestHandle.GetLegendList(CurrentIndex, PrePageCount, "", FilterText);
                    }
                    break;
                /* case ResourceType.Policy:
                    if (App.ItemType == ResourceType.Wdsc)
                    {
                        resModel = await RequestHandle.GetWdscList(CurrentIndex, PrePageCount, "", FilterText);
                    }
                    else if (App.ItemType == ResourceType.Lsjl)
                    {
                       resModel = await RequestHandle.GetLsjlList(CurrentIndex, PrePageCount, "", FilterText);
                    }
                    else
                    {
                        resModel = await RequestHandle.GetPolicyList(CurrentIndex, PrePageCount, "", FilterText);
                    }
                    break;
                case ResourceType.Market:
                    if (App.ItemType == ResourceType.Wdsc)
                    {
                        resModel = await RequestHandle.GetWdscList(CurrentIndex, PrePageCount, "", FilterText);
                    }
                    else if (App.ItemType == ResourceType.Lsjl)
                    {
                        resModel = await RequestHandle.GetLsjlList(CurrentIndex, PrePageCount, "", FilterText);
                    }
                    else
                    {
                        resModel = await RequestHandle.GetMarketList(CurrentIndex, PrePageCount, "", FilterText);
                    }
                    break;
                case ResourceType.Product:
                    if (App.ItemType == ResourceType.Wdsc)
                    {
                        resModel = await RequestHandle.GetWdscList(CurrentIndex, PrePageCount, "", FilterText);
                    }
                    else if (App.ItemType == ResourceType.Lsjl)
                    {
                        resModel = await RequestHandle.GetLsjlList(CurrentIndex, PrePageCount, "", FilterText);
                    }
                    else
                    {
                        resModel = await RequestHandle.GetProductList(CurrentIndex, PrePageCount, "产品", FilterText);
                    }
                    break;
                case ResourceType.Predict:
                    if (App.ItemType == ResourceType.Wdsc)
                    {
                        resModel = await RequestHandle.GetWdscList(CurrentIndex, PrePageCount, "", FilterText);
                    }
                    else if (App.ItemType == ResourceType.Lsjl)
                    {
                        resModel = await RequestHandle.GetLsjlList(CurrentIndex, PrePageCount, "", FilterText);
                    }
                    else
                    {
                        resModel = await RequestHandle.GetPredictList(CurrentIndex, PrePageCount, "预测", FilterText);
                    }
                    break;
                case ResourceType.Macro:
                    if (App.ItemType == ResourceType.Wdsc)
                    {
                        resModel = await RequestHandle.GetWdscList(CurrentIndex, PrePageCount, "", FilterText);
                    }
                    else if (App.ItemType == ResourceType.Lsjl)
                    {
                        resModel = await RequestHandle.GetLsjlList(CurrentIndex, PrePageCount, "", FilterText);
                    }
                    else
                    {
                        resModel = await RequestHandle.GetMacroList(CurrentIndex, PrePageCount, "宏观", FilterText);
                    }
                    break;*/
                case ResourceType.Upload_template:
                    resModel = await RequestHandle.GetUploadTemplateList(CurrentIndex, PrePageCount, "", FilterText);
                    this.label_All.Text = "模板";
                    this.label_Mark.Text = "图例";
                    this.label_Records.Text = "图标";
                    break;
                case ResourceType.Upload_icon:
                    resModel = await RequestHandle.GetUploadIconList(CurrentIndex, PrePageCount, "", FilterText);
                    break;
                case ResourceType.Upload_legend:
                    resModel = await RequestHandle.GetUploadTlList(CurrentIndex, PrePageCount, "", FilterText);
                    break;
            }
            PageCount = (int)Math.Ceiling((double)resModel.ResCount / PrePageCount);
            ///*if (resModel.PageCount % PrePageCount > 0)
            //{
            //    PageCount++;
            //}*/
            /*PageCount = resModel.ResCount / PrePageCount;
            if (resModel.PageCount % PrePageCount > 0)
            {
                PageCount++;
            }*/
            if (PageCount == 0)
            {

                pageBox.Text = "1";
            }
            else
            {
                pageBox.Text = CurrentIndex + "/" + PageCount;
            }
            return resModel;
        }

        public void ResetPageCount()
        {
            int SH = Screen.PrimaryScreen.Bounds.Height;
            int sch = (int)Math.Floor(SH / 1.3);
            //int SW = Screen.PrimaryScreen.Bounds.Width;
            int listWidgetH = sch - 50 - this.LTPanel.Height - this.flowLayoutPanel1.Height;//减去顶部菜单的高度

            int w = 260;
            int h = 145;
            if (App.ResourceType == ResourceType.Icon || App.ResourceType == ResourceType.Upload_icon)
            {
                h = 68;
                w = 68;
                //resourceList.ColumnCount = this.LTPanel.Width / h;
                resourceList.ColumnCount = 3;

            }
            else
            {
                resourceList.ColumnCount = 1;
                /*h = 122;
                w = 206;*/
                w = 206;
                h = 115;
            }

            int rows = listWidgetH / h;
            if (rows > 0)
            {
                PrePageCount = rows * resourceList.ColumnCount;
                int mod = listWidgetH % h;
                if (mod > 1)
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
            //CurrentIndex = 1;
            //pageBox.Text = "1";
        }

    }
}
