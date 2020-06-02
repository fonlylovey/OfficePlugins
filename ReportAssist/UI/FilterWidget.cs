using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Core;
using CustomControls;

namespace PPTPlugin
{
    public partial class FilterWidget : CustomForm
    {
        public FilterWidget()
        {
            InitializeComponent();
            CustomTitle.Visible = false;
        }

        public void AddFilterItem(List<GroupItem> groups)
        {
            ClearItem();
            MainLayout.Padding = new Padding(10);
            int groupsHeight = 0;
            foreach (GroupItem pItem in groups)
            {
                RGroupBox group = new RGroupBox();
                group.Checkable = false;
                group.MaximumSize = new Size(210, 800);
                group.MinimumSize = new Size(210, 50);
                if (groups.Count > 1)
                {
                    group.Text = pItem.Name;
                    group.Checkable = true;
                }
                int totalWidth = 0;
                foreach(GroupItem item in pItem.Children)
                {
                    CheckBox checkBox = new CheckBox();
                    checkBox.UseVisualStyleBackColor = true;
                    checkBox.AutoSize = true;
                    checkBox.Text = item.Name;
                    checkBox.Parent = group;
                    totalWidth += checkBox.Width;
                    group.LayoutPanel.Controls.Add(checkBox);
                }
                int mod = totalWidth / 200;
                if (totalWidth % 200 > 0)
                {
                    mod++;
                }
                group.Height = mod * 45;
                groupsHeight += group.Height + 10;
                MainLayout.Controls.Add(group);
            }
            MainLayout.Controls.SetChildIndex(ButtonLayout, MainLayout.Controls.Count);
            if(groups.Count > 1)
            {
                this.Height = groupsHeight + 40;
            }
            else
                this.Height = groupsHeight + 60;
        }

        public void ClearItem()
        {
            List<RGroupBox> deleteLsit = new List<RGroupBox>();
            foreach(Control control in MainLayout.Controls)
            {
                RGroupBox group = control as RGroupBox;
                if (group != null)
                {
                    deleteLsit.Add(group);
                }
            }
            foreach(RGroupBox control in deleteLsit)
            {
                MainLayout.Controls.Remove(control);
            }
        }

        public void ResetItem()
        {
            foreach (Control control in MainLayout.Controls)
            {
                RGroupBox group = control as RGroupBox;
                if (group != null)
                {
                    group.Checked = false;
                }
            }
        }
        private void FilterWidget_Deactivate(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            Selection.Clear();
            foreach (Control control in MainLayout.Controls)
            {
                RGroupBox group = control as RGroupBox;
                if (group != null)
                {
                    if (!String.IsNullOrEmpty(group.Text) && group.Checked)
                    {
                        Selection.Add(group.Text);
                    }
                    foreach (Control itemCtrl in group.LayoutPanel.Controls)
                    {
                        CheckBox check = itemCtrl as CheckBox;
                        if(check != null)
                        {
                            if (!String.IsNullOrEmpty(check.Text) && check.Checked)
                            {
                                Selection.Add(check.Text);
                            }
                        }
                    }
                }
            }
            this.Visible = false;
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            ResetItem();
        }

        public List<String> Selection = new List<string>();
    }
}
