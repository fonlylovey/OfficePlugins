using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;
using System.Threading.Tasks;
using Base;
using Core;
using Widgets;
using CustomControls;
using AutoUpdate;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.PowerPoint;
using Microsoft.Office.Core;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections;

namespace PPTPlugin
{
    public partial class RibbonMenu
    {
        readonly String StrUserName = "UserName";
        readonly String StrUserToken = "UserToken";
        const int WWidth = 1200;
        const int HHeight = 680;
        List<System.Drawing.Image> AllName = new List<System.Drawing.Image>();
        string FileName = "C://result.pdf";

        private async void RibbonMenu_Load(object sender, RibbonUIEventArgs e)
        {
            ResetButtonEnable(false);
            await LoadUserInfo();
        }

        private async Task<bool> LoadUserInfo()
        {
            String strUserName = Regditer.GetValue(Regditer.RootKey.CurrentUser, Rigel.UserRegKey, StrUserName);
            if (!String.IsNullOrEmpty(strUserName))
            {
                String strUserToken = Regditer.GetValue(Regditer.RootKey.CurrentUser, Rigel.UserRegKey, StrUserToken);
                if (await RequestHandle.TokenValidity(strUserToken))
                {
                    Rigel.UserID = strUserName;
                    Rigel.UserName = strUserName;
                    Rigel.UserToken = strUserToken;
                    button_login.Label = Rigel.UserName;
                    ResetButtonEnable(true);
                    return true;
                }
                return false;
            }
            return false;
        }

        private async void button_login_Click(object sender, RibbonControlEventArgs e)
        {
            DialogResult result = DialogResult.None;
            if (String.IsNullOrEmpty(Rigel.UserID))
            {
                LoginWidget loginWidget = new LoginWidget();
                result = loginWidget.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (String.IsNullOrEmpty(Rigel.UserID))
                    {
                        PromptBox.Error("登录失败！");
                        return;
                    }
                    else
                    {
                        Regditer.WriteReg(Regditer.RootKey.CurrentUser, Rigel.UserRegKey,
                        StrUserName, Rigel.UserName);
                        Regditer.WriteReg(Regditer.RootKey.CurrentUser, Rigel.UserRegKey,
                            StrUserToken, Rigel.UserToken);
                        button_login.Label = Rigel.UserName;
                        button_login.Image = Properties.Resources.Login;
                        ResetButtonEnable(true);
                    }
                }
            }
            else
            {
                result = PromptBox.Prompt("确认退出登录？");
                if (result == DialogResult.OK)
                {
                    await RequestHandle.Logout(Rigel.UserName);
                    Rigel.UserID = "";
                    Rigel.UserToken = "";
                    Regditer.WriteReg(Regditer.RootKey.CurrentUser, Rigel.UserRegKey,
                        StrUserToken, String.Empty);
                    button_login.Label = "登录\r\n";
                    button_login.Image = Properties.Resources.Logout;
                    Globals.ThisAddIn.TaskWidget.Visible = false;
                    ResetButtonEnable(false);
                }
            }

        }

        private void button_temp_Click(object sender, RibbonControlEventArgs e)
        {
            App.ResourceType = ResourceType.Template;
            App.ItemType = ResourceType.qb;
            Globals.ThisAddIn.RightWidget.updateRightLableText();
            //Globals.ThisAddIn.RightWidget.ResetPageCount();
            //Globals.ThisAddIn.RightWidget.UpdateResourceList();
            //Globals.ThisAddIn.RightWidget.ResetButton();
            //Globals.ThisAddIn.TaskWidget.Visible = true;
        }

        private void button_legend_Click(object sender, RibbonControlEventArgs e)
        {
            App.ResourceType = ResourceType.Legend;
            App.ItemType = ResourceType.qb;
            Globals.ThisAddIn.RightWidget.updateRightLableText();
            //Globals.ThisAddIn.RightWidget.ResetPageCount();
            //Globals.ThisAddIn.RightWidget.UpdateResourceList();
            //Globals.ThisAddIn.RightWidget.ResetButton();
            //Globals.ThisAddIn.TaskWidget.Visible = true;
        }

        private void button_icon_Click(object sender, RibbonControlEventArgs e)
        {
            App.ResourceType = ResourceType.Icon;
            App.ItemType = ResourceType.qb;
            Globals.ThisAddIn.RightWidget.updateRightLableText();
            //Globals.ThisAddIn.RightWidget.ResetPageCount();
            //Globals.ThisAddIn.RightWidget.UpdateResourceList();
            //Globals.ThisAddIn.RightWidget.ResetButton();
            //Globals.ThisAddIn.TaskWidget.Visible = true;
        }

        private void button_label_Click(object sender, RibbonControlEventArgs e)
        {

        }

        private void button_market_Click(object sender, RibbonControlEventArgs e)
        {
            App.ResourceType = ResourceType.Market;
            App.ItemType = ResourceType.qb;
            Globals.ThisAddIn.RightWidget.updateRightLableText();
            //Globals.ThisAddIn.RightWidget.ResetPageCount();
            //Globals.ThisAddIn.RightWidget.UpdateResourceList();
            //Globals.ThisAddIn.RightWidget.ResetButton();
            //Globals.ThisAddIn.TaskWidget.Visible = true;
        }

        private void button_policy_Click(object sender, RibbonControlEventArgs e)
        {
            App.ResourceType = ResourceType.Policy;
            App.ItemType = ResourceType.qb;
            Globals.ThisAddIn.RightWidget.updateRightLableText();
            //Globals.ThisAddIn.RightWidget.ResetPageCount();
            //Globals.ThisAddIn.RightWidget.UpdateResourceList();
            //Globals.ThisAddIn.RightWidget.ResetButton();
            //Globals.ThisAddIn.TaskWidget.Visible = true;
        }

        private void button_product_Click(object sender, RibbonControlEventArgs e)
        {
            App.ResourceType = ResourceType.Product;
            App.ItemType = ResourceType.qb;
            Globals.ThisAddIn.RightWidget.updateRightLableText();
            //Globals.ThisAddIn.RightWidget.ResetPageCount();
            //Globals.ThisAddIn.RightWidget.UpdateResourceList();
            //Globals.ThisAddIn.RightWidget.ResetButton();
            //Globals.ThisAddIn.TaskWidget.Visible = true;
        }

        private void button_predict_Click(object sender, RibbonControlEventArgs e)
        {
            App.ResourceType = ResourceType.Predict;
            App.ItemType = ResourceType.qb;
            Globals.ThisAddIn.RightWidget.updateRightLableText();
            //Globals.ThisAddIn.RightWidget.ResetPageCount();
            //Globals.ThisAddIn.RightWidget.UpdateResourceList();
            //Globals.ThisAddIn.RightWidget.ResetButton();
            //Globals.ThisAddIn.TaskWidget.Visible = true;
        }

        private void button_macro_Click(object sender, RibbonControlEventArgs e)
        {
            App.ResourceType = ResourceType.Macro;
            App.ItemType = ResourceType.qb;
            Globals.ThisAddIn.RightWidget.updateRightLableText();
            //Globals.ThisAddIn.RightWidget.ResetPageCount();
            //Globals.ThisAddIn.RightWidget.UpdateResourceList();
            //Globals.ThisAddIn.RightWidget.ResetButton();
            //Globals.ThisAddIn.TaskWidget.Visible = true;
        }

        private void button_about_Click(object sender, RibbonControlEventArgs e)
        {
            AboutWidget aboutWidget = new AboutWidget();
            DialogResult result = ThisAddIn.FormShower.ShowDialog(aboutWidget);
        }

        private void button_option_Click(object sender, RibbonControlEventArgs e)
        {
            try
            {
                UpdateWidget updateWidget = new UpdateWidget();
                updateWidget.setVersion(Rigel.PluginVersion, VSTOUpdater.ServerVersion);
                VSTOUpdater.UpdateLog.TryGetValue("slogan", out string slogan);
                VSTOUpdater.UpdateLog.TryGetValue("content", out string content);
                VSTOUpdater.UpdateLog.TryGetValue("sjhs", out string sjhs);
                List<string> lists = new List<string>();
                if (sjhs != null)
                {
                    lists = sjhs.Split(',').ToList<string>();
                }
                updateWidget.setInfo(slogan, content);
               
                Int32.TryParse(Rigel.PluginVersion.Replace(".", ""), out int local);
                Int32.TryParse(VSTOUpdater.ServerVersion.Replace(".", ""),out int server);
                if ((lists.Contains(Rigel.UserID)||lists.Contains("all"))&&local < server)
                {
                    VSTOUpdater.NeedUpdate = true;
                }
                else
                {
                    updateWidget.setVersion(Rigel.PluginVersion, Rigel.PluginVersion);
                    VSTOUpdater.NeedUpdate = false;
                }

                updateWidget.setNeedUpdate(VSTOUpdater.NeedUpdate);




                if (VSTOUpdater.NeedUpdate)
                {
                    Logger.LogInfo("需要更新版本：" + VSTOUpdater.ServerVersion);
                }
                Logger.LogInfo("开始更新从：" + Rigel.PluginVersion + "升级到：" + VSTOUpdater.ServerVersion);

                DialogResult result = ThisAddIn.FormShower.ShowDialog(updateWidget);
                if (result == DialogResult.OK && VSTOUpdater.Update())
                {
                    PromptBox.Prompt("更新完成，需要重新启动软件。");
                    return;
                }
            }
            catch (Exception ex)
            {
                PromptBox.Prompt("非常抱歉更新失败，请联系工作人员！");
                Logger.LogError(ex.ToString());
            }

        }

        private void ResetButtonEnable(bool value)
        {
            //资源
            button_temp.Enabled = value;
            button_legend.Enabled = value;
            button_icon.Enabled = value;

            //数据
            button_market.Enabled = value;
            button_product.Enabled = value;
            button_predict.Enabled = value;
            button_macro.Enabled = value;

            //咨询
            button_policy.Enabled = value;
            button_enterprise.Enabled = value;
            button_carType.Enabled = false;
            button_technology.Enabled = value;
            //工具
            button_export.Enabled = false;
            button_zip.Enabled = false;
            button_share.Enabled = false;

            //更多
            button_about.Enabled = value;
            button_option.Enabled = value;

            //我的资源
            button_upload.Enabled = value;
            button_suggest.Enabled = value;
            button_toupload.Enabled = value;
            //导出
            button_export.Enabled = value;
        }

        private void button_upload_Click(object sender, RibbonControlEventArgs e)
        {
            App.ResourceType = ResourceType.Upload_template;
            Globals.ThisAddIn.RightWidget.updateRightLableText();
            //Globals.ThisAddIn.RightWidget.ResetPageCount();
            //Globals.ThisAddIn.RightWidget.UpdateResourceList();
            //Globals.ThisAddIn.RightWidget.ResetButton();
            //Globals.ThisAddIn.TaskWidget.Visible = true;
        }

        private void button_suggest_Click(object sender, RibbonControlEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "http://autoppter.autoinfo.org.cn");
        }

        private void button_export_Click(object sender, RibbonControlEventArgs e)
        {
            string pptPath = Globals.ThisAddIn.Application.ActivePresentation.FullName;
            string imgPath = Rigel.PluginDir + "tmpImage";
            FileName = Rigel.PluginDir + "pdf";
            if (System.IO.Directory.Exists(imgPath = System.Text.RegularExpressions.Regex.Replace(imgPath, "/", "")) == false)//如果不存在就创建file文件夹
            {
                System.IO.Directory.CreateDirectory(imgPath);
            }
            if (System.IO.Directory.Exists(FileName = System.Text.RegularExpressions.Regex.Replace(FileName, "/", "")) == false)//如果不存在就创建file文件夹
            {
                System.IO.Directory.CreateDirectory(FileName);
            }
            //var app = new Microsoft.Office.Interop.PowerPointApplication();
            Presentation pre = Globals.ThisAddIn.Application.ActivePresentation;
            string path = pre.Path;
            Console.Out.Write(path);
            //var ppt = app.Presentations.Open(pptPath, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoFalse);

            var index = 0;

            //var fileName = Path.GetFileNameWithoutExtension(pptPath);

            var slides = Globals.ThisAddIn.Application.ActivePresentation.Slides;
            int cnt = slides.Count;
            int[] arr = new int[cnt];
            List<string> fileNameList = new List<string>();
            string imgName = "";
            for (int i = 0; i < cnt; i++)
            {
                arr[i] = i + 1;
            }
            foreach (Microsoft.Office.Interop.PowerPoint.Slide slid in slides.Range(arr))
            {
                ++index;
                //设置图片大小
                try
                {
                    imgName = imgPath + string.Format("\\{0}.jpg", index.ToString());
                    slid.Export(imgName, "jpg", Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                    fileNameList.Add(imgName);


                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }

            }
            FolderBrowserDialog pdfpath = new FolderBrowserDialog();
            pdfpath.ShowDialog();
            FileName = pdfpath.SelectedPath + "\\" + GetTimeStamp() + ".pdf";
            img2pdf(fileNameList);
            //释放资源
            GC.Collect();
        }

        public void TurnTheImageToPdf(List<string> SourceImage)
        {
            try
            {
                ChangeTheImageToS(SourceImage);

                FileStream fileStream = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write);
                Console.WriteLine(Screen.PrimaryScreen.Bounds.Width);
                Console.WriteLine(Screen.PrimaryScreen.Bounds.Height);
                iTextSharp.text.Rectangle rtg = new iTextSharp.text.Rectangle(0, 0, 750, 500);
                //iTextSharp.text.Rectangle rtg = new iTextSharp.text.Rectangle(170f,254f,1560f,885f);

                Document doc = new Document();
                doc.SetPageSize(rtg);
                PdfWriter write = PdfWriter.GetInstance(doc, fileStream);


                doc.Open();

                iTextSharp.text.Image jpg;

                for (int i = 0; i < AllName.Count; ++i)
                {
                    jpg = iTextSharp.text.Image.GetInstance(AllName[i], ImageFormat.Jpeg);
                    doc.NewPage();
                    doc.Add(jpg);
                }
                if (doc != null && doc.IsOpen())
                {
                    doc.Close();
                }
                if (write != null)
                {
                    write.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }


        //change all the image to standard
        private void ChangeTheImageToS(List<string> ImageName)
        {
            for (int i = 0; i < ImageName.Count; ++i)
            {
                Bitmap src = new Bitmap(ImageName[i]);

                Bitmap bmImage = new Bitmap(1119, 680);
                Graphics g = Graphics.FromImage(src);
                g.InterpolationMode = InterpolationMode.Low;
                //g.DrawImage(src, new System.Drawing.Rectangle(0, 0, bmImage.Width, bmImage.Height), new System.Drawing.Rectangle(0, 0, src.Width, src.Height), GraphicsUnit.Pixel);
                g.DrawImage(src, new System.Drawing.Rectangle(0, 0, bmImage.Width, bmImage.Height), new System.Drawing.Rectangle(0, 0, src.Width, src.Height), GraphicsUnit.Pixel);
                g.Dispose();
                AllName.Add(bmImage);
            }
        }
        private void img2pdf(List<string> ImageName)
        {

            string[] files = ImageName.ToArray();
            iTextSharp.text.Document document = new iTextSharp.text.Document(new iTextSharp.text.Rectangle(100f, 100f, 800f, 500f, 0));
            try
            {
                iTextSharp.text.pdf.PdfWriter.GetInstance(document, new FileStream(FileName, FileMode.Create, FileAccess.ReadWrite));
                document.Open();
                iTextSharp.text.Image image;
                for (int i = 0; i < files.Length; i++)
                {
                    if (String.IsNullOrEmpty(files[i])) break;
                    image = iTextSharp.text.Image.GetInstance(files[i]);
                    if (image.Height > iTextSharp.text.PageSize.A4.Height - 25)
                    {
                        image.ScaleToFit(iTextSharp.text.PageSize.A4.Width - 25, iTextSharp.text.PageSize.A4.Height - 25);
                    }
                    else if (image.Width > iTextSharp.text.PageSize.A4.Width - 25)
                    {
                        image.ScaleToFit(iTextSharp.text.PageSize.A4.Width - 25, iTextSharp.text.PageSize.A4.Height - 25);
                    }
                    image.Alignment = iTextSharp.text.Image.ALIGN_MIDDLE;
                    document.NewPage();
                    document.Add(image);
                    //iTextSharp.text.Chunk c1 = new iTextSharp.text.Chunk("Hello World");

                    //iTextSharp.text.Phrase p1 = new iTextSharp.text.Phrase();

                    //p1.Leading = 150;      //行间距

                    //document.Add(p1);

                }

                Console.WriteLine("转换成功！");

            }

            catch (Exception ex)

            {

                Console.WriteLine("转换失败，原因：" + ex.Message);

            }

            document.Close();
            PromptBox.Prompt("导出完成！");
            Console.ReadKey();
        }
        /// <summary>
        /// 获取时间戳
        /// </summary>
        /// <returns></returns>
        public static string GetTimeStamp()
        {
            TimeSpan ts = DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalMilliseconds).ToString();
        }
        public bool ConverterToPdf(string _lstrInputFile, string _lstrOutFile)
        {
            Microsoft.Office.Interop.PowerPoint.Application lobjPowerPointApp = null;
            Microsoft.Office.Interop.PowerPoint.Presentation lobjppt = null;
            object lobjMissing = System.Reflection.Missing.Value;
            object lobjSaveChanges = null;
            try
            {
                lobjPowerPointApp = new Microsoft.Office.Interop.PowerPoint.Application();
                lobjppt = lobjPowerPointApp.Presentations.Open(_lstrInputFile, MsoTriState.msoTrue, MsoTriState.msoFalse, MsoTriState.msoFalse);
                lobjppt.SaveAs(_lstrOutFile, PpSaveAsFileType.ppSaveAsPDF, MsoTriState.msoCTrue);
            }
            catch (Exception ex)
            {
                //其他日志操作；
                return false;
            }
            finally
            {
                if (lobjppt != null)
                {
                    lobjppt.Close();
                    Marshal.ReleaseComObject(lobjppt);
                    lobjppt = null;
                }
                if (lobjPowerPointApp != null)
                {
                    lobjPowerPointApp.Quit();
                    Marshal.ReleaseComObject(lobjPowerPointApp);
                    lobjPowerPointApp = null;
                }
                //主动激活垃圾回收器，主要是避免超大批量转文档时，内存占用过多，而垃圾回收器并不是时刻都在运行！
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            return true;
        }

        private void button_enterprise_Click(object sender, RibbonControlEventArgs e)
        {
            App.ResourceType = ResourceType.Enterprise;
            App.ItemType = ResourceType.qb;
            Globals.ThisAddIn.RightWidget.updateRightLableText();
        }

        private void button_technology_Click(object sender, RibbonControlEventArgs e)
        {
            App.ResourceType = ResourceType.Technology;
            App.ItemType = ResourceType.qb;
            Globals.ThisAddIn.RightWidget.updateRightLableText();
        }

        private void button_toupload_Click(object sender, RibbonControlEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", "http://autoppter.autoinfo.org.cn");
        }
    }

}
