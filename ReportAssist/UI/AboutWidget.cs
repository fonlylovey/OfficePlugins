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
    public partial class AboutWidget : CustomForm
    {
        public AboutWidget()
        {
            InitializeComponent();
        }
        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
