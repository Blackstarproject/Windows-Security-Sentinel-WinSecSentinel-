using System.Drawing;
using System.Windows.Forms;

namespace WinSecSentinel
{
    public class FuturisticButton : Button
    {
        private readonly Color _glowColor = Color.FromArgb(0, 255, 255); // Cyan
        private bool _isHovering = false;

        public FuturisticButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 0, 255, 255); // Semi-transparent cyan
            FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 0, 255, 255);
            BackColor = Color.Transparent;
            ForeColor = Color.FromArgb(224, 225, 221); // Off-white text
            Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Size = new Size(150, 45);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            // Draw the base button appearance from parent
            base.OnPaint(pevent);

            if (_isHovering)
            {
                // Draw a glowing border when hovering
                using (var pen = new Pen(_glowColor, 2))
                {
                    pevent.Graphics.DrawRectangle(pen, 1, 1, Width - 2, Height - 2);
                }
            }
        }

        protected override void OnMouseEnter(System.EventArgs e)
        {
            base.OnMouseEnter(e);
            _isHovering = true;
            Invalidate();
        }

        protected override void OnMouseLeave(System.EventArgs e)
        {
            base.OnMouseLeave(e);
            _isHovering = false;
            Invalidate();
        }
    }
}