using Core;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public void ResetButton()
        {
            foreach (Control control in VMenu.Controls)
            {
                control.BackColor = Color.Transparent;
                if (control.Tag != null)
                {
                    if (Enum.TryParse<ResourceType>(control.Tag.ToString(), out ResourceType type))
                    {
                        if(type == App.ResourceType)
                        {
                            control.BackColor = Color.White;
                        }
                    }
                }
            }
        }

        public static void ApplyTemplate(Object data)
        {
            ResourceData resourceData = data as ResourceData;
            if (resourceData != null)
            {
                string strUrl = resourceData.FileUrl;
                string strPath = Request.HttpDownload(strUrl).Result;

                Globals.ThisAddIn.Application.Presentations.Open(strPath);
            }
        }

        public static void ApplyIcon(Object data)
        {
            ResourceData resourceData = data as ResourceData;
            if (resourceData != null)
            {
                string strUrl = resourceData.FileUrl;
                string strPath = Request.HttpDownload(strUrl).Result;
                Image image = Image.FromFile(strPath);

                PowerPoint.Slide slide = Globals.ThisAddIn.Application.ActiveWindow.View.Slide;
                if (slide != null)
                {
                    PowerPoint.Shape shape =  slide.Shapes.AddPicture(strPath, 
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
                    resModel = await RequestHandle.GetTempList(CurrentIndex, PrePageCount, "", FilterText);
                    break;
                case ResourceType.Icon:
                    resModel = await RequestHandle.GetIconList(CurrentIndex, PrePageCount, "", FilterText);
                    break;
                case ResourceType.Legend:
                    resModel = await RequestHandle.GetLegendList(CurrentIndex, PrePageCount, "", FilterText);
                    break;
                case ResourceType.Policy:
                    resModel = await RequestHandle.GetPolicyList(CurrentIndex, PrePageCount, "", FilterText);
                    break;
                case ResourceType.Market:
                    resModel = await RequestHandle.GetMarketList(CurrentIndex, PrePageCount, "", FilterText);
                    break;
                case ResourceType.Product:
                    resModel = await RequestHandle.GetProductList(CurrentIndex, PrePageCount, "产品", FilterText);
                    break;
                case ResourceType.Predict:
                    resModel = await RequestHandle.GetPredictList(CurrentIndex, PrePageCount, "预测", FilterText);
                    break;
                case ResourceType.Macro:
                    resModel = await RequestHandle.GetMacroList(CurrentIndex, PrePageCount, "宏观", FilterText);
                    break;
            }

            PageCount = resModel.PageCount / PrePageCount;
            if(resModel.PageCount % PrePageCount > 0)
            {
                PageCount++;
            }

            return resModel;
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
        }

    }
}
