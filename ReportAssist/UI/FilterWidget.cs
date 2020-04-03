using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPTPlugin
{
    public partial class FilterWidget : Form
    {
        public FilterWidget()
        {
            InitializeComponent();
        }

        private void FilterWidget_Deactivate(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
