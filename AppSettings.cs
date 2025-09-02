using System.Collections.Generic;

namespace WinSecSentinel
{
    public class AppSettings
    {
        public int TimerIntervalSeconds { get; set; } = 300; // 5 minutes
        public string HoneypotPath { get; set; } = "FinancialReports"; // Relative to MyDocuments
        public List<string> MonitoredDirectories { get; set; } = new List<string>
        {
            @"C:\Windows\System32"
        };
        public List<string> MonitoredRegistryKeys { get; set; } = new List<string>
        {
            @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run",
            @"SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce"
        };
    }
}