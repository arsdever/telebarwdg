using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeleBarWdg
{
    public partial class TaskbarButton : UserControl
    {
        public Color BackColorDefault { get; set; }
        public Color BackColorHover { get; set; }
        public Color BackColorPressed { get; set; }
        public Color BackColorDisabled { get; set; }
        public Image Icon { get; set; }
        public State ButtonState { get => _state; }

        private State _state = State.Default;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x20;
                return cp;
            }
        }

        public enum State
        {
            Default = 0,
            Hover = 1,
            Pressed = 2,
            Disabled = 4
        }

        public TaskbarButton()
        {
            InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            //SetStyle(ControlStyles.Opaque, true);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Color fill = BackColorDefault;
            if ((ButtonState & State.Pressed) != 0)
                fill = BackColorPressed;
            else if ((ButtonState & State.Hover) != 0)
                fill = BackColorHover;
            e.Graphics.Clear(fill);
            Rectangle rect = e.ClipRectangle;
            rect.Inflate(-6, -6);
            e.Graphics.DrawImage(Icon, rect);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            _state |= State.Hover;
            base.OnMouseEnter(e);
            Refresh();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            _state &= ~State.Hover;
            base.OnMouseLeave(e);
            Refresh();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            _state |= State.Pressed;
            base.OnMouseDown(e);
            Refresh();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            _state &= ~State.Pressed;
            base.OnMouseUp(e);
            Refresh();
        }

        protected override void OnResize(EventArgs e)
        {
            if (Width > Height)
            {
                Width = Height;
            }
            else
            {
                Height = Width;
            }
            base.OnResize(e);
        }
    }
}
