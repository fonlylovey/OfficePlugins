using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public partial class CheckButton : CheckBox
    {
        public CheckButton()
        {
            InitializeComponent();
            Cursor = Cursors.Hand;
            Appearance = Appearance.Button;
            AutoCheck = false;
        }

        [DescriptionAttribute("用于用户自定义该控件的类型")]
        public String UserType { set; get; } = String.Empty;

        [DescriptionAttribute("判断是否需要从父容器清除")]
        public bool IsClear { set; get; } = false;

        [DescriptionAttribute("父CheckButton")]
        public CheckButton ParentCheck
        {
            set
            {
                if(value != null)
                {
                    m_ParentCheck = value;
                    m_ParentCheck.ChildList.Add(this);
                }
            }
            get
            {
                return m_ParentCheck;
            }
        }

        public List<CheckBox> ChildList = new List<CheckBox>();

		protected override void OnClick(EventArgs e)
		{
			base.OnClick(e);
			//处理自己
			if(CheckState == CheckState.Checked)
			{
				CheckState = CheckState.Unchecked;
			}
			else
			{
				CheckState = CheckState.Checked;
			}

			//处理子节点的选中状态
			AllChecked(this, CheckState);
			//处理父节点的旋转状态
			ParentState(this);
		}

		protected override void OnCheckStateChanged(EventArgs e)
		{
			base.OnCheckStateChanged(e);
			if (CheckState == CheckState.Unchecked)
			{
				ImageIndex = 0;
			}
			else if (CheckState == CheckState.Checked)
			{
				ImageIndex = 1;
			}
			else if (CheckState == CheckState.Indeterminate)
			{
				ImageIndex = 2;
			}
		}

		private void AllChecked(CheckButton check, CheckState state)
		{
			foreach (CheckButton theCheck in check.ChildList)
			{
				theCheck.CheckState = CheckState;
				AllChecked(theCheck, state);
			}
		}

		private void ParentState(CheckButton check)
		{
			if(check == null)
			{
				return;
			}
			//通过兄弟节点计算父节点的状态
			if (check.ParentCheck != null)
			{
				int isIndete = 0;
				foreach (CheckButton theCheck in check.ParentCheck.ChildList)
				{
					int flag = 0;
					if (theCheck.CheckState == CheckState.Unchecked)
						flag = 0;
					else if (theCheck.CheckState == CheckState.Checked)
						flag = 2;
					else
						flag = 1;
					isIndete += flag;
				}

				if (isIndete == 0)
				{
					check.ParentCheck.CheckState = CheckState.Unchecked;
				}
				else if (isIndete == check.ParentCheck.ChildList.Count * 2)
				{
					check.ParentCheck.CheckState = CheckState.Checked;
				}
				else
				{
					check.ParentCheck.CheckState = CheckState.Indeterminate;
				}
			}
			ParentState(check.ParentCheck);
		}

        CheckButton m_ParentCheck;
    }
}
