using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIM.Controls.Controls
{
    public partial class PushButton : Button
    {
        public enum ButtonState
        {
            Normal,
            Hover,
            Pressed,
            UnEnable
        }

        public PushButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            m_TextAlign.Alignment = StringAlignment.Center;
            m_TextAlign.LineAlignment = StringAlignment.Center;
            UseVisualStyleBackColor = false;
            this.SetStyle(
                ControlStyles.UserPaint |  //控件自行绘制，而不使用操作系统的绘制
                ControlStyles.AllPaintingInWmPaint | //忽略擦出的消息，减少闪烁。
                ControlStyles.OptimizedDoubleBuffer |//在缓冲区上绘制，不直接绘制到屏幕上，减少闪烁。
                ControlStyles.ResizeRedraw | //控件大小发生变化时，重绘。                  
                ControlStyles.SupportsTransparentBackColor, true);//支持透明背景颜色
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if(BackgroundImage != null)
            {
                base.OnPaintBackground(e);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (IsChecked)
            {

            }
            else
            {
                DrawButton(e);
                OnPaintBackground(e);
            }
        }
        

        void DrawButton(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            GraphicsPath path = null;
            if (BorderRadius > 0)
            {
                path = calcRoundPath(ClientRectangle, BorderWidth);
                this.Region = new Region(path);
            }
            else
            {

            }

            if (BorderWidth > 0)
            {
                if (BorderRadius > 0)
                {
                    Rectangle bdRect = new Rectangle(0, 0, Width - BorderWidth, Height - BorderWidth);
                    path = calcRoundPath(bdRect, BorderWidth);
                    g.DrawPath(new Pen(FlatAppearance.BorderColor, BorderWidth), path);
                }
                else
                {
                    g.DrawRectangle(new Pen(FlatAppearance.BorderColor, BorderWidth), ClientRectangle);
                }
            }

            //绘制文本
            Brush brush = new SolidBrush(ForeColor);
            e.Graphics.DrawString(Text, Font, brush, ClientRectangle, m_TextAlign);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            State  = ButtonState.Hover;
            BackColor = m_HoverColor;
            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            State = ButtonState.Normal;
            BackColor = m_NormalColor;
            base.OnMouseLeave(e);
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            State = ButtonState.Pressed;
            BackColor = m_PressedColor;
            base.OnMouseDown(mevent);
        }
        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            State = ButtonState.Hover;
            BackColor = m_HoverColor;
            base.OnMouseUp(mevent);
        }

    }
}
