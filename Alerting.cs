using System.Windows.Forms;

namespace WinSecSentinel
{
    public enum AlertLevel
    {
        Informational,
        Warning,
        Critical
    }

    public static class Alerter
    {
        public static void ShowAlert(string message, AlertLevel level)
        {
            switch (level)
            {
                case AlertLevel.Informational:
                    MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case AlertLevel.Warning:
                    MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case AlertLevel.Critical:
                    MessageBox.Show(message, "Critical Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}