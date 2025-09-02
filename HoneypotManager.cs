using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace WinSecSentinel
{
    public class HoneypotManager : IDisposable
    {
        private FileSystemWatcher _watcher;
        public string HoneypotPath { get; private set; }
        public event Action<string> SuspiciousActivityDetected;

        public HoneypotManager(string honeypotRelativePath) // CONSTRUCTOR
        {
            // Use a path relative to the user's Documents folder from settings
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            HoneypotPath = Path.Combine(documentsPath, honeypotRelativePath);
        }

        public string Deploy()
        {
            HoneypotPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FinancialReports");

            try
            {
                if (Directory.Exists(HoneypotPath))
                {
                    return HoneypotPath;
                }

                Directory.CreateDirectory(HoneypotPath);

                File.WriteAllText(Path.Combine(HoneypotPath, "Q4_Sales_Projections.xlsx"), "This is a dummy file.");
                File.WriteAllText(Path.Combine(HoneypotPath, "Employee_Salaries.docx"), "This is a dummy file.");
                File.WriteAllText(Path.Combine(HoneypotPath, "Customer_Data.csv"), "This is a dummy file.");

                return HoneypotPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deploying honeypot: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void StartMonitoring()
        {
            if (HoneypotPath == null || !Directory.Exists(HoneypotPath))
            {
                return;
            }

            _watcher = new FileSystemWatcher(HoneypotPath)
            {
                NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.DirectoryName,
                Filter = "*.*",
                IncludeSubdirectories = true
            };

            _watcher.Changed += OnSuspiciousActivity;
            _watcher.Created += OnSuspiciousActivity;
            _watcher.Deleted += OnSuspiciousActivity;
            _watcher.Renamed += OnSuspiciousActivity;

            _watcher.EnableRaisingEvents = true;
        }

        public void StopMonitoring()
        {
            if (_watcher != null)
            {
                _watcher.EnableRaisingEvents = false;
                _watcher.Dispose();
                _watcher = null;
            }
        }

        private void OnSuspiciousActivity(object source, FileSystemEventArgs e)
        {
            var logMessage = $"ALERT: Suspicious activity detected! Type: {e.ChangeType}, File: {e.FullPath}";
            SuspiciousActivityDetected?.Invoke(logMessage);

            // Automated Response
            var process = GetLockingProcess(e.FullPath);
            if (process != null)
            {
                var processLogMessage = $"Terminating process '{process.ProcessName}' (PID: {process.Id}) for accessing honeypot file.";
                SuspiciousActivityDetected?.Invoke(processLogMessage);
                process.Kill();
            }

            // Other automated responses (use with caution)
            // IsolateNetwork();
            // LogOffUser();
        }

        private Process GetLockingProcess(string filePath)
        {
            var processes = Process.GetProcesses();
            foreach (var process in processes)
            {
                try
                {
                    var files = process.Modules.Cast<ProcessModule>()
                        .Select(m => m.FileName)
                        .Where(f => f.Equals(filePath, StringComparison.OrdinalIgnoreCase));

                    if (files.Any())
                    {
                        return process;
                    }
                }
                catch
                {
                    // Ignore processes that can't be accessed
                }
            }

            return null;
        }

        // Other automated responses (use with caution)
        private void IsolateNetwork()
        {
            // This is a placeholder for network isolation logic.
            // It would typically involve using the Windows Firewall API to block all network connections.
            // This is a complex operation and should be implemented with care.
        }
        // Other automated responses(use with caution)
        private void LogOffUser()
        {
            // This is a placeholder for user logoff logic.
            // It would typically involve calling the ExitWindowsEx function from the Windows API.
        }

        public void Dispose()
        {
            StopMonitoring();
        }
    }
}