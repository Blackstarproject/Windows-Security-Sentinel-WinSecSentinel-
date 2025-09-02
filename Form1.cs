using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Runtime.InteropServices; 

namespace WinSecSentinel
{
    public partial class Form1 : Form
    {
        // Instances of Security Modules 
        private readonly PhishingDetector _phishingDetector;
        private readonly HoneypotManager _honeypotManager;
        private readonly FileIntegrityMonitor _fileIntegrityMonitor;
        private readonly NetworkMonitor _networkMonitor;
        private readonly UserAccountMonitor _userAccountMonitor;

        // Class-level variables
        private AppSettings _settings;
        private readonly List<Panel> _contentPanels = new List<Panel>();

        public Form1()
        {
            InitializeComponent();
            LoadSettings();

            // Initialize all security modules
            _phishingDetector = new PhishingDetector();
            _honeypotManager = new HoneypotManager(_settings.HoneypotPath);
            _fileIntegrityMonitor = new FileIntegrityMonitor();
            _networkMonitor = new NetworkMonitor();
            _userAccountMonitor = new UserAccountMonitor();

            // Subscribe to the honeypot's detection event
            _honeypotManager.SuspiciousActivityDetected += OnHoneypotActivity;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeContentPanels();
            InitializeMonitoringTimer();

            // Populate initial data
            PopulateSystemInfo();
            PopulateProcesses();
            LogActivity("Application initialized. Welcome to WinSecSentinel.");
        }

        #region Futuristic UI - Window Management & Navigation

        // Import WinAPI functions to allow dragging a borderless window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        /// <summary>
        /// Handles the mouse down event on the header panel to allow window dragging.
        /// </summary>
        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        /// <summary>
        /// Handles the click event for the custom close button.
        /// </summary>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Initializes the list of content panels and shows the default one.
        /// </summary>
        private void InitializeContentPanels()
        {
            _contentPanels.Add(panelSystemInfo);
            _contentPanels.Add(panelProcesses);
            _contentPanels.Add(panelAntiPhishing);
            _contentPanels.Add(panelRansomware);
            _contentPanels.Add(panelAdvanced);
            _contentPanels.Add(panelLogs);

            ShowPanel(panelSystemInfo); // Show the System Info panel on startup
        }

        /// <summary>
        /// Hides all content panels except for the one specified.
        /// </summary>
        private void ShowPanel(Panel panelToShow)
        {
            foreach (var panel in _contentPanels)
            {
                panel.Visible = (panel == panelToShow);
            }
        }

        // Menu Button Click Events 
        private void BtnSystemInfo_Click(object sender, EventArgs e) => ShowPanel(panelSystemInfo);
        private void BtnProcesses_Click(object sender, EventArgs e) => ShowPanel(panelProcesses);
        private void BtnAntiPhishing_Click(object sender, EventArgs e) => ShowPanel(panelAntiPhishing);
        private void BtnRansomware_Click(object sender, EventArgs e) => ShowPanel(panelRansomware);
        private void BtnAdvanced_Click(object sender, EventArgs e) => ShowPanel(panelAdvanced);
        private void BtnLogs_Click(object sender, EventArgs e) => ShowPanel(panelLogs);

        #endregion

        #region Core Application Logic & Timers

        /// <summary>
        /// Loads settings from config.json or creates a default file.
        /// </summary>
        private void LoadSettings()
        {
            try
            {
                if (File.Exists("config.json"))
                {
                    _settings = JsonConvert.DeserializeObject<AppSettings>(File.ReadAllText("config.json"));
                }
                else
                {
                    _settings = new AppSettings();
                    File.WriteAllText("config.json", JsonConvert.SerializeObject(_settings, Formatting.Indented));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading configuration: {ex.Message}", "Config Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _settings = new AppSettings(); // Use default settings on error
            }
        }

        /// <summary>
        /// Configures and starts the main timer for real-time monitoring.
        /// </summary>
        private void InitializeMonitoringTimer()
        {
            monitoringTimer.Interval = _settings.TimerIntervalSeconds * 1000;
            monitoringTimer.Tick += MonitoringTimer_Tick;
            monitoringTimer.Start();
            LogActivity($"Real-time monitoring enabled. Scan interval: {_settings.TimerIntervalSeconds} seconds.");
        }

        /// <summary>
        /// Event handler for the monitoring timer's tick.
        /// </summary>
        private void MonitoringTimer_Tick(object sender, EventArgs e)
        {
            LogActivity("Performing scheduled real-time security scan...");
            RunAllChecks();
        }

        /// <summary>
        /// Centralized method for logging messages to the UI.
        /// </summary>
        private void LogActivity(string message)
        {
            if (rtbAppLog.InvokeRequired)
            {
                rtbAppLog.Invoke(new Action<string>(LogActivity), message);
                return;
            }
            rtbAppLog.AppendText($"[{DateTime.Now:G}] {message}{Environment.NewLine}");
            rtbAppLog.ScrollToCaret();
        }

        /// <summary>
        /// Runs all automated security checks and updates the relevant UI panels.
        /// </summary>
        private void RunAllChecks()
        {
            LogActivity("Updating advanced monitor views...");
            PopulateAdvancedMonitors();
        }

        #endregion

        #region UI Population & On-Demand Actions

        private void PopulateSystemInfo()
        {
            lblUserName.Text = Environment.UserName;
            lblMachineName.Text = Environment.MachineName;
            lblOSVersion.Text = Environment.OSVersion.ToString();
        }

        private void PopulateProcesses()
        {
            listViewProcesses.Items.Clear();
            foreach (var process in Process.GetProcesses().OrderBy(p => p.ProcessName))
            {
                var item = new ListViewItem(process.ProcessName);
                item.SubItems.Add(process.Id.ToString());
                item.SubItems.Add(process.Responding ? "Running" : "Not Responding");
                listViewProcesses.Items.Add(item);
            }
        }

        private void PopulateAdvancedMonitors()
        {
            // File Integrity Monitor:
            lbFileIntegrity.Items.Clear();
            var fileAlerts = _fileIntegrityMonitor.CheckIntegrity();
            if (fileAlerts.Any()) fileAlerts.ForEach(alert => lbFileIntegrity.Items.Add(alert));
            else lbFileIntegrity.Items.Add("[OK] No file integrity issues detected.");

            // Network Connections Monitor:
            lbNetworkConnections.Items.Clear();
            _networkMonitor.GetActiveConnections().ForEach(c => lbNetworkConnections.Items.Add(c));

            // User Accounts Monitor:
            lbUserAccounts.Items.Clear();
            var userAlerts = _userAccountMonitor.CheckUserAccounts();
            if (userAlerts.Any()) userAlerts.ForEach(alert => lbUserAccounts.Items.Add(alert));
            else lbUserAccounts.Items.Add("[OK] No user account issues detected.");
        }

        private async void BtnScanUrl_Click(object sender, EventArgs e)
        {
            var url = txtUrlToScan.Text.Trim();
            if (string.IsNullOrWhiteSpace(url))
            {
                rtbPhishingLog.AppendText("Please enter a URL to scan.\n");
                return;
            }

            rtbPhishingLog.AppendText($"Scanning: {url}...\n");
            var result = await _phishingDetector.ScanUrlAsync(url);
            rtbPhishingLog.AppendText($"{result}\n");

            if (result.Contains("CRITICAL"))
            {
                LogActivity($"Critical phishing URL detected: {url}");
                Alerter.ShowAlert(result, AlertLevel.Critical);
            }
        }

        private void BtnCreateBaseline_Click(object sender, EventArgs e)
        {
            LogActivity("User initiated creation of a new file integrity baseline...");
            _fileIntegrityMonitor.CreateBaseline(_settings.MonitoredDirectories);
            LogActivity("Baseline creation complete.");
            MessageBox.Show("File integrity baseline created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RunAllChecks(); // Refresh the view
        }

        private void BtnRunAllChecks_Click(object sender, EventArgs e)
        {
            LogActivity("Manual security scan initiated by user.");
            RunAllChecks();
        }

        private void BtnDeployHoneypot_Click(object sender, EventArgs e)
        {
            var path = _honeypotManager.Deploy();
            if (path != null)
            {
                rtbHoneypotLog.AppendText($"[{DateTime.Now}] Honeypot deployed at: {path}\n");
                LogActivity($"Honeypot deployed at: {path}");
                _honeypotManager.StartMonitoring();
                btnDeployHoneypot.Enabled = false;
                btnStopHoneypot.Enabled = true;
            }
        }

        private void BtnStopHoneypot_Click(object sender, EventArgs e)
        {
            _honeypotManager.StopMonitoring();
            rtbHoneypotLog.AppendText($"[{DateTime.Now}] Honeypot monitoring stopped.\n");
            LogActivity("Honeypot monitoring stopped.");
            btnDeployHoneypot.Enabled = true;
            btnStopHoneypot.Enabled = false;
        }

        private void OnHoneypotActivity(string logMessage)
        {
            LogActivity($"HONEYPOT ALERT: {logMessage}");

            if (rtbHoneypotLog.InvokeRequired)
            {
                rtbHoneypotLog.Invoke(new Action<string>(OnHoneypotActivity), logMessage);
                return;
            }
            rtbHoneypotLog.SelectionColor = Color.Red;
            rtbHoneypotLog.AppendText($"[{DateTime.Now}] {logMessage}{Environment.NewLine}");
            rtbHoneypotLog.SelectionColor = rtbHoneypotLog.ForeColor;
            rtbHoneypotLog.ScrollToCaret();

            Alerter.ShowAlert(logMessage, AlertLevel.Critical);
        }

        #endregion
    }
}