﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CustomControls
{
    public partial class PicturePlane : UserControl
    {
        public PicturePlane()
        {
            InitializeComponent();
            MenuPanel.Visible = false;
            MenuPanel.Parent = Picture;
            MenuPanel.BackColor = Color.FromArgb(100, 255, 255, 255);
        }

        public void SetMarkVisible(bool isVisible)
        {
            markButton.Visible = isVisible;
        }

        public void SetMarkStatus(bool status)
        {
            IsMark = status;
            markButton.Image = Properties.Resources.mark;
        }

        public void SetMenuVisible(bool isVisible)
        {
            MenuVisible = isVisible;
        }

        public void SetImage(Image image)
        {
            if (InvokeRequired)
            {
                if (Disposing || IsDisposed)
                {
                    return;
                }
                DelegateSetImage @delegate = new DelegateSetImage(SetImage);
                Invoke(@delegate, image);
            }
            else
            {
                Picture.Image = image;
            }
        }

        public void SetImage(String strUrl)
        {
            if (InvokeRequired)
            {
                if (Disposing || IsDisposed)
                {
                    return;
                }
                DelegateSetImageUrl @delegate = new DelegateSetImageUrl(SetImage);
                Invoke(@delegate, strUrl);
            }
            else
            {
                Picture.ImageLocation = strUrl;
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if(ApplyFunction != null)
            {
                Invoke(ApplyFunction, Tag);
            }
        }
        
        private void markButton_Click(object sender, EventArgs e)
        {
            IsMark = !IsMark;
            if (IsMark)
            {
                markButton.Image = Properties.Resources.mark;
                if(MarkFunction != null)
                {
                    Invoke(MarkFunction, Tag);
                }
            }
            else
            {
                markButton.Image = Properties.Resources.unMark;
                if (UnMarkFunction != null)
                {
                    Invoke(UnMarkFunction, Tag);
                }

            }
            
        }

        private void Picture_MouseMove(object sender, MouseEventArgs e)
        {
            bool flag = false;
            for (int i = 0; i < 50000; i++)
            {
                flag = mouseFlag();
            }
            MenuPanel.Visible = flag;
        }
        public bool mouseFlag()
        {
            bool flag = false;
            Rectangle myRect = this.RectangleToScreen(this.ClientRectangle);
            myRect = new Rectangle(myRect.X + 5, myRect.Y + 5, myRect.Width - 10, myRect.Height - 10);
            if (myRect.Contains(Cursor.Position))
            {
                flag = true;
            }
            return flag;

        }
       

        bool MenuVisible = false;
        bool IsMark = false;
        public delegate void DelegateApply(object data);
        public delegate void DelegateMark();
        public DelegateApply ApplyFunction = null;
        public DelegateApply MarkFunction = null;
        public DelegateApply UnMarkFunction = null;

        delegate void DelegateSetImage(Image image);
        delegate void DelegateSetImageUrl(String strUrl);

        private void MenuPanel_MouseLeave(object sender, EventArgs e)
        {
            MenuPanel.Visible = false;
        }

        private void MenuPanel_Resize(object sender, EventArgs e)
        {
            int x = Width - applyButton.Width - Padding.Left - Padding.Right;
            int y = Height - applyButton.Height - Padding.Left - Padding.Right;
            applyButton.Location = new Point(x/2, y/2);
        }

       
    }
}
