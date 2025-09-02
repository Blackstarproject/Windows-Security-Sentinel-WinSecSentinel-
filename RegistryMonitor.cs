using System;
using System.Collections.Generic;
using Microsoft.Win32;

namespace WinSecSentinel
{
    public class RegistryMonitor
    {
        public List<string> CheckStartupPrograms()
        {
            var startupPrograms = new List<string>();
            try
            {
                using (var key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", false))
                {
                    foreach (var name in key.GetValueNames())
                    {
                        startupPrograms.Add($"[USER STARTUP] {name}: {key.GetValue(name)}");
                    }
                }

                using (var key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", false))
                {
                    foreach (var name in key.GetValueNames())
                    {
                        startupPrograms.Add($"[MACHINE STARTUP] {name}: {key.GetValue(name)}");
                    }
                }
            }
            catch (Exception ex)
            {
                startupPrograms.Add($"Error checking startup programs: {ex.Message}");
            }

            return startupPrograms;
        }
    }
}