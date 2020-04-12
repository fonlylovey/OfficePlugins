using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls;
using Microsoft.Win32;

namespace PPTPlugin
{
    public partial class UpdateWidget : CustomForm
    {
        private ListViewAdapter viewAdapter;
        public UpdateWidget()
        {
            InitializeComponent();
            viewAdapter = new ListViewAdapter();
            recordList.Adapter = viewAdapter;
        }
        private void button_history_Click(object sender, EventArgs e)
        {
            Contart data = new Contart();
            data.LastMessage = "3月1日";
            data.LastMessageTime = DateTime.Now;
            data.NickName = "1.0.0.1 版本更新";
            viewAdapter.Add(data);
            data = new Contart();
            data.LastMessage = "3月7日";
            data.LastMessageTime = DateTime.Now;
            data.NickName = "1.0.0.2 版本更新";
            viewAdapter.Add(data);
            data = new Contart();
            data.LastMessage = "3月15日";
            data.LastMessageTime = DateTime.Now;
            data.NickName = "1.0.0.3 版本更新";
            viewAdapter.Add(data);
            data = new Contart();
            data.LastMessage = "3月26日";
            data.LastMessageTime = DateTime.Now;
            data.NickName = "1.0.0.4 版本更新";
            viewAdapter.Add(data);
            data = new Contart();
            data.LastMessage = "4月10日";
            data.LastMessageTime = DateTime.Now;
            data.NickName = "1.0.0.5 版本更新";
            viewAdapter.Add(data);
            TabWidget.SelectTab(history_page);
        }

        private void button_detiles_Click(object sender, EventArgs e)
        {
            String strLink = "http://www.baidu.com";
            //调用默认浏览器如果出错就使用系统默认浏览器
            try
            {
                RegistryKey key = Registry.ClassesRoot.OpenSubKey(@"http\shell\open\command\");
                string s = key.GetValue("").ToString();

                System.Diagnostics.Process process = System.Diagnostics.Process.Start(
                    s.Substring(0, s.Length - 8), strLink);

                if(process == null)
                {
                    System.Diagnostics.Process.Start(strLink);
                }
            }
            catch
            {

            }

            //TabWidget.SelectTab(info_page);
           
        }

        private void button_update_Click(object sender, EventArgs e)
        {

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
