using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIM.Controls.Controls
{
    partial class PushButton
    {
        private Color m_NormalColor = Color.White;
        private Color m_HoverColor = Color.White;
        private Color m_PressedColor = Color.White;
        private Color BackgroundColor = Color.White;

        private Image m_NormalImage = null;
        private Image m_HoverImage = null;
        private Image m_PressedImage = null;

        private int m_BorderRadius = 4;
        public int BorderWidth { get; set; } = 0;
        private bool m_CheckedEnable = false;
        private bool m_IsChecked = false;
        ButtonState m_ButtonState = ButtonState.Normal;
        private StringFormat m_TextAlign = new StringFormat();

        //计算圆角区域
        private GraphicsPath calcRoundPath(RectangleF rect, int lineWidth)
        {
            float diameter = m_BorderRadius * 2;
            GraphicsPath path = new GraphicsPath();
            RectangleF arcRect = new RectangleF(rect.X + lineWidth/2.0f, rect.Y + lineWidth/2.0f, diameter, diameter);
            float roundWidth = rect.Width - diameter;
            float roundHeight = rect.Height - (diameter * 2);
            //左上角
            
            path.AddArc(arcRect, 180, 90);
            
            //top
            path.AddLine(arcRect.X + m_BorderRadius, arcRect.Y, arcRect.X + roundWidth, arcRect.Y);
            
            //右上角
            arcRect.X += roundWidth - lineWidth;
            path.AddArc(arcRect, 270, 90);
           
            //right
            arcRect.X += diameter;
            path.AddLine(arcRect.X, arcRect.Y + diameter, arcRect.X, rect.Bottom - diameter);
            

            //右下角
            arcRect.X -= diameter;
            arcRect.Y = rect.Bottom - diameter - lineWidth;
            path.AddArc(arcRect, 0, 90);
            
            //bottom
            arcRect.Y = rect.Bottom - lineWidth + 1;
            path.AddLine(arcRect.X, arcRect.Y, rect.Left + diameter, arcRect.Y);
            
            //左下
            arcRect.X = rect.X + lineWidth / 2.0f;
            arcRect.Y = rect.Bottom - diameter - lineWidth + 1;
            path.AddArc(arcRect, 90, 90);
            //闭合
            path.CloseFigure();

            return path;
        }

        public Color NormalColor
        {
            get
            {
                return m_NormalColor;
            }
            set
            {
                m_NormalColor = value;
            }
        }

        public Color HoverColor
        {
            get
            {
                return m_HoverColor;
            }
            set
            {
                m_HoverColor = value;
            }
        }

        public Color PressedColor
        {
            get
            {
                return m_PressedColor;
            }
            set
            {
                m_PressedColor = value;
            }
        }

        public Image NormalImage
        {
            get
            {
                return m_NormalImage;
            }
            set
            {
                m_NormalImage = value;
            }
        }

        public Image HoverImage
        {
            get
            {
                return m_HoverImage;
            }
            set
            {
                m_HoverImage = value;
            }
        }

        public Image PressedImage
        {
            get
            {
                return m_PressedImage;
            }
            set
            {
                m_PressedImage = value;
            }
        }

        //[DefaultValue(4)]
        public int BorderRadius
        {
            get
            {
                return m_BorderRadius;
            }
            set
            {
                m_BorderRadius = value;
            }
        }
        
        public ButtonState State
        {
            get
            {
                return m_ButtonState;
            }
            set
            {
                m_ButtonState = value;
            }
        }

        public bool CheckedEnable
        {
            get
            {
                return m_CheckedEnable;
            }
            set
            {
                m_CheckedEnable = value;
            }
        }

        public bool IsChecked
        {
            get
            {
                return m_IsChecked;
            }
            set
            {
                m_IsChecked = value;
            }
        }

        //文本水平对齐方式
        public StringAlignment TextHAlign
        {
            get
            {
                return m_TextAlign.LineAlignment;
            }
            set
            {
                m_TextAlign.LineAlignment = value;
            }
        }

        //文本竖直对齐方式
        public StringAlignment TextVAlign
        {
            get
            {
                return m_TextAlign.Alignment;
            }
            set
            {
                m_TextAlign.Alignment = value;
            }
        }
    }
}
