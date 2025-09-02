using System.Drawing;
using System.Windows.Forms;

namespace WinSecSentinel
{
    public class StylishButton : Button
    {
        private readonly Color _buttonColor = ColorTranslator.FromHtml("#343A40");
        private readonly Color _borderColor = ColorTranslator.FromHtml("#495057");
        private bool _isHovering = false;

        public StylishButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            ForeColor = ColorTranslator.FromHtml("#F8F9FA");
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Size = new Size(150, 40);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            // Base background
            pevent.Graphics.Clear(Parent.BackColor);

            // Main button body
            using (var brush = new SolidBrush(_isHovering ? ControlPaint.Light(_buttonColor, 0.2f) : _buttonColor))
            {
                pevent.Graphics.FillRectangle(brush, ClientRectangle);
            }

            // Draw 3D border
            ControlPaint.DrawBorder3D(pevent.Graphics, ClientRectangle, Border3DStyle.Raised);

            // Draw Text
            TextRenderer.DrawText(pevent.Graphics, Text, Font,
                ClientRectangle, ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }

        protected override void OnMouseEnter(System.EventArgs e)
        {
            base.OnMouseEnter(e);
            _isHovering = true;
            Invalidate(); // Redraw the control
        }

        protected override void OnMouseLeave(System.EventArgs e)
        {
            base.OnMouseLeave(e);
            _isHovering = false;
            Invalidate(); // Redraw the control
        }
    }
}