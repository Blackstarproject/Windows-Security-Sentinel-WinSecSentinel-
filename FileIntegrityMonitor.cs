using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

namespace WinSecSentinel
{
    public class FileIntegrityMonitor
    {
        private const string BaselineFile = "file_baseline.json";
        private readonly Dictionary<string, string> _baseline = new Dictionary<string, string>();

        public void CreateBaseline(IEnumerable<string> directories)
        {
            _baseline.Clear();
            foreach (var dir in directories)
            {
                if (!Directory.Exists(dir)) continue;

                // This line can still throw an error if we can't access the top-level directory.
                // It's better to iterate recursively with error handling.
                var files = new List<string>();
                try
                {
                    files.AddRange(Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories));
                }
                catch (UnauthorizedAccessException ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Access denied to directory {dir}: {ex.Message}");
                    continue; // Skip this whole directory if we can't list its files
                }

                foreach (var file in files)
                {
                    // Wrap the file access in a try-catch block.
                    // This handles cases where we can list files but not read one of them.
                    try
                    {
                        using (var sha256 = SHA256.Create())
                        using (var stream = File.OpenRead(file))
                        {
                            var hash = sha256.ComputeHash(stream);
                            _baseline[file] = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                        }
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        // Output to the debug console so we know which files are skipped.
                        System.Diagnostics.Debug.WriteLine($"Access denied to file {file}: {ex.Message}");
                    }
                    catch (IOException ex)
                    {
                        // Handles cases where the file is locked or in use.
                        System.Diagnostics.Debug.WriteLine($"IO error on file {file}: {ex.Message}");
                    }
                }
            }
            // Save the baseline to a file
            File.WriteAllText(BaselineFile, JsonConvert.SerializeObject(_baseline, Formatting.Indented));
        }

        public List<string> CheckIntegrity()
        {
            var alerts = new List<string>();
            if (!File.Exists(BaselineFile))
            {
                alerts.Add("[WARNING] File integrity baseline not found. Please create one.");
                return alerts;
            }

            var previousBaseline = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(BaselineFile));

            foreach (var entry in previousBaseline)
            {
                try
                {
                    if (!File.Exists(entry.Key))
                    {
                        alerts.Add($"[CRITICAL] File Deleted: {entry.Key}");
                        continue;
                    }

                    using (var sha256 = SHA256.Create())
                    using (var stream = File.OpenRead(entry.Key))
                    {
                        var hash = sha256.ComputeHash(stream);
                        var currentHash = BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                        if (currentHash != entry.Value)
                        {
                            alerts.Add($"[CRITICAL] File Altered: {entry.Key}");
                        }
                    }
                }
                catch (UnauthorizedAccessException ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Access denied while checking {entry.Key}: {ex.Message}");
                }
                catch (IOException ex)
                {
                    System.Diagnostics.Debug.WriteLine($"IO error while checking {entry.Key}: {ex.Message}");
                }
            }

            return alerts;
        }
    }
}