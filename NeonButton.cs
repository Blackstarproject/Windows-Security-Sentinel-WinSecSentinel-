using System.Drawing;
using System.Windows.Forms;

namespace WinSecSentinel
{
    public class NeonButton : Button
    {
        private readonly Color _buttonColor = ColorTranslator.FromHtml("#343A40");
        private readonly Color _neonColor = Color.HotPink;
        private bool _isHovering = false;

        public NeonButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Size = new Size(150, 40);
            Margin = new Padding(0);
            // Set the text color to neon pink
            ForeColor = _neonColor;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            // Base background
            pevent.Graphics.Clear(Parent.BackColor);

            // Main button body
            using (var brush = new SolidBrush(_isHovering ? ColorTranslator.FromHtml("#495057") : _buttonColor))
            {
                pevent.Graphics.FillRectangle(brush, ClientRectangle);
            }

            // Draw the neon border
            using (var pen = new Pen(_neonColor, 2))
            {
                // Draw rectangle inset by 1 pixel for better appearance
                pevent.Graphics.DrawRectangle(pen, 1, 1, Width - 2, Height - 2);
            }

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