using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Core;

namespace PPTPlugin
{
    internal class WriteSlide
    {
        public async Task<bool> WriteData(String strID)
        {
            PowerPoint.Shapes shapes = PPTPlugin.ThisAddIn.CurrentPPT.Slides[1].Shapes;
            try
            {
                JObject jsonData = await RequestData.GetPredictData(strID);
                JObject dataObj = jsonData["data"].ToObject<JObject>();
                PowerPoint.Shape shape = PPTAPI.getShape(shapes, "Label_1");
                if (shape != null)
                {
                    shape.TextFrame.TextRange.Text = dataObj.Value<String>("labelInfo");
                }
                shape = PPTAPI.getShape(shapes, "DateLabel");
                if (shape != null)
                {
                    String strText = shape.TextFrame.TextRange.Text;
                    strText = strText.Replace("{Date}", dataObj.Value<String>("date"));
                    shape.TextFrame.TextRange.Text = strText;
                }

                shape = PPTAPI.getShape(shapes, "Table_1");
                if (shape != null)
                {
                    PowerPoint.Table table = shape.Table;

                    shape = PPTAPI.getShape(shapes, "Chart_1");
                    PowerPoint.Chart chart = shape.Chart;
                    var ws = chart.ChartData.Workbook.Worksheets[1];
                    JArray array = dataObj.Value<JArray>("salesData");
                    List<PredictData> predicts = CoreAPI.Deserialize<List<PredictData>>(array.ToString());

                    int col = 2;
                    char colStart = 'B';
                    foreach(PredictData predict in predicts)
                    {
                        int row = 1;
                        String step = colStart + row.ToString();
                        ws.Range[step].Value = predict.Month;
                        table.Cell(row, col).Shape.TextFrame.TextRange.Text = predict.Sales;
                        row++;
                        step = colStart + row.ToString();
                        ws.Range[step].Value = predict.Sales;
                        table.Cell(row, col).Shape.TextFrame.TextRange.Text = predict.Ratio;
                        row++;
                        step = colStart + row.ToString();
                        ws.Range[step].Value = predict.Ratio;
                        col++;
                        colStart++;
                    }
                }

                shape = PPTAPI.getShape(shapes, "Image_1");
                if (shape != null)
                {
                    String strUrl = dataObj.Value<String>("imageUrl");
                    if(!String.IsNullOrEmpty(strUrl))
                    {
                        string strPath = Request.HttpDownload(strUrl).Result;
                        shapes.AddPicture(strPath, Microsoft.Office.Core.MsoTriState.msoCTrue, Microsoft.Office.Core.MsoTriState.msoCTrue,
                            shape.Left, shape.Top, shape.Width, shape.Height);
                        shape.Delete();
                    }    
                }
            }
            catch
            {

            }
            
            return true;
        }
    }
}