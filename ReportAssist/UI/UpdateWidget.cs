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

namespace PPTPlugin
{
    public partial class UpdateWidget : CustomForm
    {
        public UpdateWidget()
        {
            InitializeComponent();
            info_page.Parent = null;
            history_page.Parent = null;
        }
        private void UpdateWidget_Load(object sender, EventArgs e)
        {
            //Rectangle tcRec = TabWidget.ClientRectangle;//整个tabControl的边框
            //e.Graphics.FillRectangle(new SolidBrush(info_page.BackColor), tcRec);
        }
        private void link_recordList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button_detiles_Click(object sender, EventArgs e)
        {

        }

        private void button_update_Click(object sender, EventArgs e)
        {

        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fButton1_Click(object sender, EventArgs e)
        {

        }

        private void fButton2_Click(object sender, EventArgs e)
        {

        }

        private void fButton3_Click(object sender, EventArgs e)
        {

        }

        private void info_page_Paint(object sender, PaintEventArgs e)
        {
            //Rectangle tcRec = TabWidget.ClientRectangle;//整个tabControl的边框
            //e.Graphics.FillRectangle(new SolidBrush(info_page.BackColor), tcRec);
        }

        private void UpdateWidget_Paint(object sender, PaintEventArgs e)
        {
            //Rectangle tcRec = TabWidget.ClientRectangle;//整个tabControl的边框
            //e.Graphics.FillRectangle(new SolidBrush(Color.Red), tcRec);
        }
    }
}
