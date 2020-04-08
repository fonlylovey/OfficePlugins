using System;
using System.Windows.Forms;

namespace CustomControls
{
    public partial class FormMgr : IWin32Window
    {
        public FormMgr(IntPtr pHwnd)
        {
            Handle = pHwnd;
        }

        public void Show(Form form)
        {
            form.ShowInTaskbar = false;
            form.Show(this);
        }

        public DialogResult ShowDialog(Form form)
        {
            form.ShowInTaskbar = false;
            DialogResult result = form.ShowDialog(this); ;
            return result;
        }

        public IntPtr Handle { get; }
    }
}
