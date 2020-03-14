using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controls
{
    public class ComboBoxItem
    {
        public object Tag { get; set; } = null;
        public string Text { get; set; } = string.Empty;

        public ComboBoxItem()
        {

        }

        public ComboBoxItem(object tag, string text)
        {
            Tag = tag;
            Text = text;
        }
        public ComboBoxItem(string text)
        {
            Text = text;
        }

        public override string ToString()
        {
            return Text;
        }
    }
}
