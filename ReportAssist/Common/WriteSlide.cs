using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using PowerPoint = Microsoft.Office.Interop.PowerPoint;
using Core;
using Newtonsoft.Json;

namespace PPTPlugin
{
    internal class WriteSlide
    {
        public async Task<bool> WriteData(String strID)
        {
            PowerPoint.Shapes shapes = Globals.ThisAddIn.Application.ActivePresentation.Slides[1].Shapes;
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
                    foreach (PredictData predict in predicts)
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
                    if (!String.IsNullOrEmpty(strUrl))
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

        public async Task<bool> WriteDataFor100(String strID)
        {
            try
            {
                JObject jsonData = await RequestData.GetWxPPTData("164");
                if (jsonData.Value<String>("code").Equals("200") && jsonData.Value<JObject>("data") != null)
                {
                    JObject dataObj = jsonData["data"].ToObject<JObject>();
                    string pptdata = dataObj.Value<String>("pptdata");
                    JArray pptdataArr = JsonConvert.DeserializeObject<JArray>(pptdata);
                    foreach (JObject jObject in pptdataArr)
                    {
                        string picUrl = jObject.Value<String>("picurl");
                        string content = jObject.Value<String>("content");
                        int index = (int)decimal.Parse(jObject.Value<string>("index"));
                        PowerPoint.Shapes shapes = Globals.ThisAddIn.Application.ActivePresentation.Slides[index].Shapes;
                        PowerPoint.Shape shape = PPTAPI.getShape(shapes, "pic_1");
                        if (shape != null)
                        {

                            if (!String.IsNullOrEmpty(picUrl))
                            {
                                string strPath = Request.HttpDownload(picUrl).Result;
                                shapes.AddPicture(strPath, Microsoft.Office.Core.MsoTriState.msoCTrue, Microsoft.Office.Core.MsoTriState.msoCTrue,
                                shape.Left, shape.Top, shape.Width, shape.Height);
                                shape.Delete();
                            }
                        }
                        shape = PPTAPI.getShape(shapes, "text_1");
                        if (shape != null)
                        {
                            shape.TextFrame.TextRange.Text = jObject.Value<String>("content");
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {

            }

            return true;
        }
        public async Task<bool> WriteDataFor164()
        {
            try
            {
                JObject jsonData = await RequestData.GetPredictData("164");
                if (jsonData.Value<String>("code").Equals("200") && jsonData.Value<JObject>("data") != null)
                {
                    JObject dataObj = jsonData["data"].ToObject<JObject>();
                    string mbnrStr = dataObj.Value<String>("mbnr");
                    JArray mbnrArr = JsonConvert.DeserializeObject<JArray>(mbnrStr);
                    foreach (JObject jObject in mbnrArr)
                    {
                        if (jObject.Value<String>("index").Equals("3"))
                        {
                            PowerPoint.Shapes shapes = Globals.ThisAddIn.Application.ActivePresentation.Slides[3].Shapes;

                            JObject tableObj = jObject.Value<JObject>("table");

                            PowerPoint.Shape shape = PPTAPI.getShape(shapes, "table_1");
                            if (shape != null)
                            {
                                PowerPoint.Table table = shape.Table;
                                shape = PPTAPI.getShape(shapes, "chart_1");
                                PowerPoint.Chart chart = shape.Chart;
                                var ws = chart.ChartData.Workbook.Worksheets[1];
                                JArray tb1 = tableObj.Value<JArray>("tb1");
                                int col = 2;
                                char colStart = 'B';
                                for (int i = 0; i < tb1.Count(); i++)
                                {
                                    int row = 1;
                                    String step = colStart + row.ToString();
                                    ws.Range[step].Value = tb1[i].Value<String>("c1");
                                    table.Cell(row, col).Shape.TextFrame.TextRange.Text = tb1[i].Value<String>("c2"); ;
                                    row++;
                                    step = colStart + row.ToString();
                                    ws.Range[step].Value = tb1[i].Value<String>("c2"); ;
                                    table.Cell(row, col).Shape.TextFrame.TextRange.Text = tb1[i].Value<String>("c3"); ;
                                    row++;
                                    step = colStart + row.ToString();
                                    ws.Range[step].Value = tb1[i].Value<String>("c3"); ;
                                    col++;
                                    colStart++;
                                }
                            }
                        }
                        else if (jObject.Value<String>("index").Equals("4"))
                        {
                            PowerPoint.Shapes shapes = Globals.ThisAddIn.Application.ActivePresentation.Slides[4].Shapes;
                            JObject tableObj = jObject.Value<JObject>("table");
                            PowerPoint.Shape shape = PPTAPI.getShape(shapes, "chart_1");
                            if (shape != null)
                            {
                                PowerPoint.Chart chart = shape.Chart;
                                var ws = chart.ChartData.Workbook.Worksheets[1];
                                JArray tb1 = tableObj.Value<JArray>("tb1");
                                int col = 2;
                                char colStart = 'B';
                                for (int i = 0; i < tb1.Count(); i++)
                                {
                                    int row = 1;
                                    String step = colStart + row.ToString();
                                    ws.Range[step].Value = tb1[i].Value<String>("c1");
                                    row++;
                                    step = colStart + row.ToString();
                                    ws.Range[step].Value = tb1[i].Value<String>("c2"); ;
                                    row++;
                                    step = colStart + row.ToString();
                                    ws.Range[step].Value = tb1[i].Value<String>("c3"); ;
                                    col++;
                                    colStart++;
                                }
                            }
                            shape = PPTAPI.getShape(shapes, "chart_2");
                            if (shape != null)
                            {
                                PowerPoint.Chart chart = shape.Chart;
                                var ws = chart.ChartData.Workbook.Worksheets[1];
                                JArray tb1 = tableObj.Value<JArray>("tb2");
                                int col = 2;
                                char colStart = 'B';
                                for (int i = 0; i < tb1.Count(); i++)
                                {
                                    int row = 1;
                                    String step = colStart + row.ToString();
                                    ws.Range[step].Value = tb1[i].Value<String>("c1");
                                    row++;
                                    step = colStart + row.ToString();
                                    string[] lsArr = tb1[i].Value<String>("c2").Split(',');
                                    int length = lsArr.Length;
                                    if (length < 5)
                                    {
                                        Array.Resize(ref lsArr, 5);
                                    }
                                    for (int j = length; j < 5; j++)
                                    {
                                        lsArr[j] = "0.0%";

                                    }
                                    ws.Range[step].Value = lsArr[0];
                                    row++;
                                    step = colStart + row.ToString();
                                    ws.Range[step].Value = lsArr[1];
                                    row++;
                                    step = colStart + row.ToString();
                                    ws.Range[step].Value = lsArr[2];
                                    row++;
                                    step = colStart + row.ToString();
                                    ws.Range[step].Value = lsArr[3];
                                    row++;
                                    step = colStart + row.ToString();
                                    ws.Range[step].Value = lsArr[4];
                                    col++;
                                    colStart++;
                                }
                            }
                        }
                        else if (jObject.Value<String>("index").Equals("5"))
                        {

                            PowerPoint.Shapes shapes = Globals.ThisAddIn.Application.ActivePresentation.Slides[5].Shapes;

                            JObject tableObj = jObject.Value<JObject>("table");
                            PowerPoint.Shape shape = PPTAPI.getShape(shapes, "chart_1");
                            if (shape != null)
                            {
                                PowerPoint.Chart chart = shape.Chart;
                                var ws = chart.ChartData.Workbook.Worksheets[1];
                                JArray tb1 = tableObj.Value<JArray>("tb1");
                                int col = 2;
                                char colStart = 'B';
                                for (int i = 0; i < tb1.Count(); i++)
                                {
                                    int row = 1;
                                    String step = colStart + row.ToString();
                                    ws.Range[step].Value = tb1[i].Value<String>("c1");
                                    row++;
                                    step = colStart + row.ToString();
                                    ws.Range[step].Value = tb1[i].Value<String>("c2"); ;
                                    row++;
                                    step = colStart + row.ToString();
                                    ws.Range[step].Value = tb1[i].Value<String>("c3"); ;
                                    col++;
                                    colStart++;
                                }
                            }
                            shape = PPTAPI.getShape(shapes, "chart_2");
                            if (shape != null)
                            {
                                PowerPoint.Chart chart = shape.Chart;
                                var ws = chart.ChartData.Workbook.Worksheets[1];
                                JArray tb1 = tableObj.Value<JArray>("tb2");
                                int col = 2;
                                char colStart = 'B';
                                for (int i = 0; i < tb1.Count(); i++)
                                {
                                    int row = 1;
                                    String step = colStart + row.ToString();
                                    ws.Range[step].Value = tb1[i].Value<String>("c1");
                                    row++;
                                    step = colStart + row.ToString();
                                    string[] lsArr = tb1[i].Value<String>("c2").Split(',');
                                    int length = lsArr.Length;
                                    if (length < 5)
                                    {
                                        Array.Resize(ref lsArr, 5);
                                    }
                                    for (int j = length; j < 5; j++)
                                    {
                                        lsArr[j] = "0.0%";

                                    }
                                    ws.Range[step].Value = lsArr[0];
                                    row++;
                                    step = colStart + row.ToString();
                                    ws.Range[step].Value = lsArr[1];
                                    row++;
                                    step = colStart + row.ToString();
                                    ws.Range[step].Value = lsArr[2];
                                    row++;
                                    step = colStart + row.ToString();
                                    ws.Range[step].Value = lsArr[3];
                                    row++;
                                    step = colStart + row.ToString();
                                    ws.Range[step].Value = lsArr[4];
                                    col++;
                                    colStart++;
                                }
                            }
                        }
                        else if (jObject.Value<String>("index").Equals("6"))
                        {

                            PowerPoint.Shapes shapes = Globals.ThisAddIn.Application.ActivePresentation.Slides[6].Shapes;

                            JObject tableObj = jObject.Value<JObject>("table");
                            PowerPoint.Shape shape = PPTAPI.getShape(shapes, "chart_1");
                            if (shape != null)
                            {
                                PowerPoint.Chart chart = shape.Chart;
                                var ws = chart.ChartData.Workbook.Worksheets[1];
                                JArray tb1 = tableObj.Value<JArray>("tb1");
                                int col = 2;
                                char colStart = 'B';
                                for (int i = 0; i < tb1.Count(); i++)
                                {
                                    int row = 1;
                                    String step = colStart + row.ToString();
                                    ws.Range[step].Value = tb1[i].Value<String>("c1");
                                    row++;
                                    step = colStart + row.ToString();
                                    ws.Range[step].Value = tb1[i].Value<String>("c2"); ;
                                    row++;
                                    step = colStart + row.ToString();
                                    ws.Range[step].Value = tb1[i].Value<String>("c3"); ;
                                    col++;
                                    colStart++;
                                }
                            }
                            shape = PPTAPI.getShape(shapes, "chart_2");
                            if (shape != null)
                            {
                                PowerPoint.Chart chart = shape.Chart;
                                var ws = chart.ChartData.Workbook.Worksheets[1];
                                JArray tb1 = tableObj.Value<JArray>("tb2");
                                int col = 2;
                                char colStart = 'B';
                                for (int i = 0; i < tb1.Count(); i++)
                                {
                                    int row = 1;
                                    String step = colStart + row.ToString();
                                    ws.Range[step].Value = tb1[i].Value<String>("c1");
                                    row++;
                                    step = colStart + row.ToString();
                                    string[] lsArr = tb1[i].Value<String>("c2").Split(',');
                                    int length = lsArr.Length;
                                    if (length < 5)
                                    {
                                        Array.Resize(ref lsArr, 5);
                                    }
                                    for (int j = length; j < 5; j++)
                                    {
                                        lsArr[j] = "0.0%";

                                    }
                                    ws.Range[step].Value = lsArr[0];
                                    row++;
                                    step = colStart + row.ToString();
                                    ws.Range[step].Value = lsArr[1];
                                    row++;
                                    step = colStart + row.ToString();
                                    ws.Range[step].Value = lsArr[2];
                                    row++;
                                    step = colStart + row.ToString();
                                    ws.Range[step].Value = lsArr[3];
                                    row++;
                                    step = colStart + row.ToString();
                                    ws.Range[step].Value = lsArr[4];
                                    col++;
                                    colStart++;
                                }
                            }
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            catch
            {

            }

            return true;
        }

        /* public  bool WriteDataFor164()
         {
             try
             {
                 //JObject jsonData = await RequestData.GetPredictData("164");
                 String res = "{\"result\":\"0\",\"msg\":\"success\",\"data\":{\"id\":\"1\",\"mbid\":\"1\",\"mbnr\":\"[{\\\"index\\\":\\\"3\\\",\\\"content\\\":{\\\"title\\\":\\\"预测5月销量158.5万辆，全年销量同比下降11.9%\\\",\\\"text\\\":{\\\"te1\\\":\\\"        2020年4月份乘用车市场销量同比下降8.3%，同比降幅有所收窄。5月份，我国乘用车市场将持续回暖，预计销量将达到158.5万辆，同比下降速度继续收窄。根据当前乘用车市场发展趋势发展，以及各地刺激政策不断发布情况分析，预计2020年乘用车销量1786.4万辆，同比下降11.9%，较之前预测同比降幅相比收窄0.5%。\\\",\\\"te2\\\":\\\"2020年国产乘用车销量预测（万辆）\\\"},\\\"table\\\":{\\\"tb1\\\":[{\\\"c1\\\":\\\"202001\\\",\\\"c2\\\":\\\"183.6\\\",\\\"c3\\\":\\\"-0.29916\\\"},{\\\"c1\\\":\\\"202002\\\",\\\"c2\\\":\\\"19.2\\\",\\\"c3\\\":\\\"-0.78165\\\"},{\\\"c1\\\":\\\"202003\\\",\\\"c2\\\":\\\"100.6\\\",\\\"c3\\\":\\\"-0.30687\\\"},{\\\"c1\\\":\\\"202004\\\",\\\"c2\\\":\\\"132.5\\\",\\\"c3\\\":\\\"-0.08329\\\"},{\\\"c1\\\":\\\"202004\\\",\\\"c2\\\":\\\"183.6\\\",\\\"c3\\\":\\\"-0.29916\\\"},{\\\"c1\\\":\\\"202006\\\",\\\"c2\\\":\\\"19.2\\\",\\\"c3\\\":\\\"-0.78165\\\"},{\\\"c1\\\":\\\"202007\\\",\\\"c2\\\":\\\"100.6\\\",\\\"c3\\\":\\\"-0.30687\\\"},{\\\"c1\\\":\\\"202008\\\",\\\"c2\\\":\\\"132.5\\\",\\\"c3\\\":\\\"-0.08329\\\"},{\\\"c1\\\":\\\"202009\\\",\\\"c2\\\":\\\"183.6\\\",\\\"c3\\\":\\\"-0.29916\\\"},{\\\"c1\\\":\\\"202010\\\",\\\"c2\\\":\\\"19.2\\\",\\\"c3\\\":\\\"-0.78165\\\"},{\\\"c1\\\":\\\"202011\\\",\\\"c2\\\":\\\"100.6\\\",\\\"c3\\\":\\\"-0.30687\\\"},{\\\"c1\\\":\\\"202012\\\",\\\"c2\\\":\\\"132.5\\\",\\\"c3\\\":\\\"-0.08329\\\"}]}}},{\\\"index\\\":\\\"4\\\",\\\"content\\\":{\\\"title\\\":\\\"轿车市场销量分析及预测\\\",\\\"text\\\":{\\\"te1\\\":\\\"多个主销车型销量回暖拉动轿车市场销量，预计2020年5月轿车销量72.3万辆，同比下滑12.9%。预计轿车市场将后续几个月持续回暖，除了之前库存车型集中降价销售之外，下半年新产品集中上市拉动有关。分级别分析，当前紧凑型市场接近饱和，中型以及中大型轿车市场份额会持续提升，小型级别主要受新能源车型拉动。\\\",\\\"te2\\\":\\\"2020年轿车市场销量预测（万辆）\\\",\\\"te3\\\":\\\"2020年轿车各级别市场份额预测\\\"},\\\"table\\\":{\\\"tb1\\\":[{\\\"c1\\\":\\\"1月\\\",\\\"c2\\\":\\\"183.6\\\",\\\"c3\\\":\\\"-0.29916\\\"},{\\\"c1\\\":\\\"2月\\\",\\\"c2\\\":\\\"19.2\\\",\\\"c3\\\":\\\"-0.78165\\\"},{\\\"c1\\\":\\\"3月\\\",\\\"c2\\\":\\\"100.6\\\",\\\"c3\\\":\\\"-0.30687\\\"},{\\\"c1\\\":\\\"4月\\\",\\\"c2\\\":\\\"132.5\\\",\\\"c3\\\":\\\"-0.08329\\\"},{\\\"c1\\\":\\\"5月\\\",\\\"c2\\\":\\\"183.6\\\",\\\"c3\\\":\\\"-0.29916\\\"},{\\\"c1\\\":\\\"6月\\\",\\\"c2\\\":\\\"19.2\\\",\\\"c3\\\":\\\"-0.78165\\\"},{\\\"c1\\\":\\\"7月\\\",\\\"c2\\\":\\\"100.6\\\",\\\"c3\\\":\\\"-0.30687\\\"},{\\\"c1\\\":\\\"2月\\\",\\\"c2\\\":\\\"132.5\\\",\\\"c3\\\":\\\"-0.08329\\\"},{\\\"c1\\\":\\\"8月\\\",\\\"c2\\\":\\\"183.6\\\",\\\"c3\\\":\\\"-0.29916\\\"},{\\\"c1\\\":\\\"9月\\\",\\\"c2\\\":\\\"19.2\\\",\\\"c3\\\":\\\"-0.78165\\\"},{\\\"c1\\\":\\\"10月\\\",\\\"c2\\\":\\\"100.6\\\",\\\"c3\\\":\\\"-0.30687\\\"},{\\\"c1\\\":\\\"11月\\\",\\\"c2\\\":\\\"132.5\\\",\\\"c3\\\":\\\"-0.08329\\\"},{\\\"c1\\\":\\\"12月\\\",\\\"c2\\\":\\\"132.5\\\",\\\"c3\\\":\\\"-0.08329\\\"}],\\\"tb2\\\":[{\\\"c1\\\":\\\"2019\\\",\\\"c2\\\":\\\"1.6%\\\",\\\"c3\\\":\\\"6.5%\\\",\\\"c4\\\":\\\"65.1%\\\",\\\"c5\\\":\\\"20.7%\\\",\\\"c6\\\":\\\"6.1%\\\"},{\\\"c1\\\":\\\"2019\\\",\\\"c2\\\":\\\"1.6%\\\",\\\"c3\\\":\\\"6.5%\\\",\\\"c4\\\":\\\"65.1%\\\",\\\"c5\\\":\\\"20.7%\\\",\\\"c6\\\":\\\"6.1%\\\"},{\\\"c1\\\":\\\"2019\\\",\\\"c2\\\":\\\"1.6%\\\",\\\"c3\\\":\\\"6.5%\\\",\\\"c4\\\":\\\"65.1%\\\",\\\"c5\\\":\\\"20.7%\\\",\\\"c6\\\":\\\"6.1%\\\"},{\\\"c1\\\":\\\"2019\\\",\\\"c2\\\":\\\"1.6%\\\",\\\"c3\\\":\\\"6.5%\\\",\\\"c4\\\":\\\"65.1%\\\",\\\"c5\\\":\\\"20.7%\\\",\\\"c6\\\":\\\"6.1%\\\"},{\\\"c1\\\":\\\"2019\\\",\\\"c2\\\":\\\"1.6%\\\",\\\"c3\\\":\\\"6.5%\\\",\\\"c4\\\":\\\"65.1%\\\",\\\"c5\\\":\\\"20.7%\\\",\\\"c6\\\":\\\"6.1%\\\"}]}}}]\",\"gxrq\":\"20200622\",\"uid\":\"15222424548\",\"del_flag\":\"0\",\"mblb\":\"Predict\"}}";
                 Console.Out.WriteLine(res);
                 JObject jsonData = JsonConvert.DeserializeObject<JObject>(res);
                 if (jsonData.Value<String>("result").Equals("0") && jsonData.Value<JObject>("data") != null)
                 {
                     JObject dataObj = jsonData["data"].ToObject<JObject>();
                     string mbnrStr = dataObj.Value<String>("mbnr");
                     JArray mbnrArr = JsonConvert.DeserializeObject<JArray>(mbnrStr);
                     foreach (JObject jObject in mbnrArr)
                     {
                         if (jObject.Value<String>("index").Equals("3"))
                         {
                             JObject content = jObject.Value<JObject>("content");
                             JObject text = content.Value<JObject>("text");

                             PowerPoint.Shapes shapes = Globals.ThisAddIn.Application.ActivePresentation.Slides[3].Shapes;
                             PowerPoint.Shape shape = PPTAPI.getShape(shapes, "title");
                             if (shape != null)
                             {
                                 shape.TextFrame.TextRange.Text = content.Value<String>("title");
                             }
                             JObject textObj = jObject.Value<JObject>("text");
                             shape = PPTAPI.getShape(shapes, "text_1");
                             if (shape != null)
                             {
                                 shape.TextFrame.TextRange.Text = text.Value<String>("te1");
                             }
                             shape = PPTAPI.getShape(shapes, "text_2");
                             if (shape != null)
                             {
                                 shape.TextFrame.TextRange.Text = text.Value<String>("te2");
                             }
                             JObject tableObj = content.Value<JObject>("table");

                             shape = PPTAPI.getShape(shapes, "table_1");
                             if (shape != null)
                             {
                                 PowerPoint.Table table = shape.Table;
                                 shape = PPTAPI.getShape(shapes, "chart_1");
                                 PowerPoint.Chart chart = shape.Chart;
                                 var ws = chart.ChartData.Workbook.Worksheets[1];
                                 JArray tb1 = tableObj.Value<JArray>("tb1");
                                 int col = 2;
                                 char colStart = 'B';
                                 for (int i = 0; i < tb1.Count(); i++)
                                 {
                                     int row = 1;
                                     String step = colStart + row.ToString();
                                     ws.Range[step].Value = tb1[i].Value<String>("c1");
                                     table.Cell(row, col).Shape.TextFrame.TextRange.Text = tb1[i].Value<String>("c2"); ;
                                     row++;
                                     step = colStart + row.ToString();
                                     ws.Range[step].Value = tb1[i].Value<String>("c2"); ;
                                     table.Cell(row, col).Shape.TextFrame.TextRange.Text = tb1[i].Value<String>("c3"); ;
                                     row++;
                                     step = colStart + row.ToString();
                                     ws.Range[step].Value = tb1[i].Value<String>("c3"); ;
                                     col++;
                                     colStart++;
                                 }
                             }
                         }
                         else if (jObject.Value<String>("index").Equals("4"))
                         {
                             //PowerPoint.Shapes shapes = Globals.ThisAddIn.Application.ActivePresentation.Slides[4].Shapes;
                         }
                     }
                 }
                 else
                 {
                     return false;
                 }
             }
             catch
             {

             }

             return true;
         }*/
    }
}