using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace WinSecSentinel
{
    public class ProcessMonitor
    {
        public List<string> GetSuspiciousProcesses()
        {
            var suspiciousProcesses = new List<string>();
            foreach (var process in Process.GetProcesses())
            {
                try
                {
                    // Check for unsigned executables
                    var signed = IsSigned(process.MainModule.FileName);
                    if (!signed)
                    {
                        suspiciousProcesses.Add($"[UNSIGNED] {process.ProcessName} (PID: {process.Id})");
                    }

                    // Check for unusual file paths
                    var path = process.MainModule.FileName;
                    if (path.StartsWith(Path.GetTempPath(), StringComparison.OrdinalIgnoreCase))
                    {
                        suspiciousProcesses.Add($"[UNUSUAL PATH] {process.ProcessName} (PID: {process.Id}) is running from the temp directory.");
                    }
                }
                catch
                {
                    // Ignore processes that can't be accessed
                }
            }

            return suspiciousProcesses;
        }

        private bool IsSigned(string filePath)
        {
            try
            {
                var cert = X509Certificate.CreateFromSignedFile(filePath);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}