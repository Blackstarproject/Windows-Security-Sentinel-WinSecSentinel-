namespace WinSecSentinel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogs = new WinSecSentinel.FuturisticButton();
            this.btnAdvanced = new WinSecSentinel.FuturisticButton();
            this.btnRansomware = new WinSecSentinel.FuturisticButton();
            this.btnAntiPhishing = new WinSecSentinel.FuturisticButton();
            this.btnProcesses = new WinSecSentinel.FuturisticButton();
            this.btnSystemInfo = new WinSecSentinel.FuturisticButton();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSystemInfo = new System.Windows.Forms.Panel();
            this.lblOSVersion = new System.Windows.Forms.Label();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelProcesses = new System.Windows.Forms.Panel();
            this.listViewProcesses = new System.Windows.Forms.ListView();
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelAntiPhishing = new System.Windows.Forms.Panel();
            this.rtbPhishingLog = new System.Windows.Forms.RichTextBox();
            this.btnScanUrl = new WinSecSentinel.FuturisticButton();
            this.txtUrlToScan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelRansomware = new System.Windows.Forms.Panel();
            this.rtbHoneypotLog = new System.Windows.Forms.RichTextBox();
            this.btnStopHoneypot = new WinSecSentinel.FuturisticButton();
            this.btnDeployHoneypot = new WinSecSentinel.FuturisticButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panelAdvanced = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbUserAccounts = new System.Windows.Forms.ListBox();
            this.lbNetworkConnections = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbFileIntegrity = new System.Windows.Forms.ListBox();
            this.btnRunAllChecks = new WinSecSentinel.FuturisticButton();
            this.btnCreateBaseline = new WinSecSentinel.FuturisticButton();
            this.panelLogs = new System.Windows.Forms.Panel();
            this.rtbAppLog = new System.Windows.Forms.RichTextBox();
            this.monitoringTimer = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelSystemInfo.SuspendLayout();
            this.panelProcesses.SuspendLayout();
            this.panelAntiPhishing.SuspendLayout();
            this.panelRansomware.SuspendLayout();
            this.panelAdvanced.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(30)))));
            this.panelMenu.Controls.Add(this.btnLogs);
            this.panelMenu.Controls.Add(this.btnAdvanced);
            this.panelMenu.Controls.Add(this.btnRansomware);
            this.panelMenu.Controls.Add(this.btnAntiPhishing);
            this.panelMenu.Controls.Add(this.btnProcesses);
            this.panelMenu.Controls.Add(this.btnSystemInfo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 40);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 521);
            this.panelMenu.TabIndex = 1;
            // 
            // btnLogs
            // 
            this.btnLogs.BackColor = System.Drawing.Color.Transparent;
            this.btnLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogs.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.btnLogs.Location = new System.Drawing.Point(0, 225);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Size = new System.Drawing.Size(180, 45);
            this.btnLogs.TabIndex = 5;
            this.btnLogs.Text = "Logs";
            this.btnLogs.UseVisualStyleBackColor = false;
            this.btnLogs.Click += new System.EventHandler(this.BtnLogs_Click);
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.BackColor = System.Drawing.Color.Transparent;
            this.btnAdvanced.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdvanced.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdvanced.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdvanced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvanced.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdvanced.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.btnAdvanced.Location = new System.Drawing.Point(0, 180);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(180, 45);
            this.btnAdvanced.TabIndex = 4;
            this.btnAdvanced.Text = "Advanced Monitoring";
            this.btnAdvanced.UseVisualStyleBackColor = false;
            this.btnAdvanced.Click += new System.EventHandler(this.BtnAdvanced_Click);
            // 
            // btnRansomware
            // 
            this.btnRansomware.BackColor = System.Drawing.Color.Transparent;
            this.btnRansomware.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRansomware.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRansomware.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRansomware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRansomware.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRansomware.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.btnRansomware.Location = new System.Drawing.Point(0, 135);
            this.btnRansomware.Name = "btnRansomware";
            this.btnRansomware.Size = new System.Drawing.Size(180, 45);
            this.btnRansomware.TabIndex = 3;
            this.btnRansomware.Text = "Ransomware";
            this.btnRansomware.UseVisualStyleBackColor = false;
            this.btnRansomware.Click += new System.EventHandler(this.BtnRansomware_Click);
            // 
            // btnAntiPhishing
            // 
            this.btnAntiPhishing.BackColor = System.Drawing.Color.Transparent;
            this.btnAntiPhishing.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAntiPhishing.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAntiPhishing.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAntiPhishing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAntiPhishing.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAntiPhishing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.btnAntiPhishing.Location = new System.Drawing.Point(0, 90);
            this.btnAntiPhishing.Name = "btnAntiPhishing";
            this.btnAntiPhishing.Size = new System.Drawing.Size(180, 45);
            this.btnAntiPhishing.TabIndex = 2;
            this.btnAntiPhishing.Text = "Anti-Phishing";
            this.btnAntiPhishing.UseVisualStyleBackColor = false;
            this.btnAntiPhishing.Click += new System.EventHandler(this.BtnAntiPhishing_Click);
            // 
            // btnProcesses
            // 
            this.btnProcesses.BackColor = System.Drawing.Color.Transparent;
            this.btnProcesses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProcesses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnProcesses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnProcesses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesses.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnProcesses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.btnProcesses.Location = new System.Drawing.Point(0, 45);
            this.btnProcesses.Name = "btnProcesses";
            this.btnProcesses.Size = new System.Drawing.Size(180, 45);
            this.btnProcesses.TabIndex = 1;
            this.btnProcesses.Text = "Processes";
            this.btnProcesses.UseVisualStyleBackColor = false;
            this.btnProcesses.Click += new System.EventHandler(this.BtnProcesses_Click);
            // 
            // btnSystemInfo
            // 
            this.btnSystemInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnSystemInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSystemInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSystemInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSystemInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSystemInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.btnSystemInfo.Location = new System.Drawing.Point(0, 0);
            this.btnSystemInfo.Name = "btnSystemInfo";
            this.btnSystemInfo.Size = new System.Drawing.Size(180, 45);
            this.btnSystemInfo.TabIndex = 0;
            this.btnSystemInfo.Text = "System Info";
            this.btnSystemInfo.UseVisualStyleBackColor = false;
            this.btnSystemInfo.Click += new System.EventHandler(this.BtnSystemInfo_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(984, 40);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHeader_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(155, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "WIN SEC SENTINEL";
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(942, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.panelSystemInfo);
            this.panelMain.Controls.Add(this.panelProcesses);
            this.panelMain.Controls.Add(this.panelAntiPhishing);
            this.panelMain.Controls.Add(this.panelRansomware);
            this.panelMain.Controls.Add(this.panelAdvanced);
            this.panelMain.Controls.Add(this.panelLogs);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(180, 40);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(10);
            this.panelMain.Size = new System.Drawing.Size(804, 521);
            this.panelMain.TabIndex = 2;
            // 
            // panelSystemInfo
            // 
            this.panelSystemInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelSystemInfo.Controls.Add(this.lblOSVersion);
            this.panelSystemInfo.Controls.Add(this.lblMachineName);
            this.panelSystemInfo.Controls.Add(this.lblUserName);
            this.panelSystemInfo.Controls.Add(this.label3);
            this.panelSystemInfo.Controls.Add(this.label2);
            this.panelSystemInfo.Controls.Add(this.label1);
            this.panelSystemInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSystemInfo.Location = new System.Drawing.Point(10, 10);
            this.panelSystemInfo.Name = "panelSystemInfo";
            this.panelSystemInfo.Size = new System.Drawing.Size(784, 501);
            this.panelSystemInfo.TabIndex = 0;
            // 
            // lblOSVersion
            // 
            this.lblOSVersion.AutoSize = true;
            this.lblOSVersion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOSVersion.Location = new System.Drawing.Point(135, 78);
            this.lblOSVersion.Name = "lblOSVersion";
            this.lblOSVersion.Size = new System.Drawing.Size(76, 17);
            this.lblOSVersion.TabIndex = 5;
            this.lblOSVersion.Text = "OS Version";
            // 
            // lblMachineName
            // 
            this.lblMachineName.AutoSize = true;
            this.lblMachineName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMachineName.Location = new System.Drawing.Point(135, 49);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(95, 17);
            this.lblMachineName.TabIndex = 4;
            this.lblMachineName.Text = "Machine Name";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(135, 20);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(74, 17);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "OS Version:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Machine Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name:";
            // 
            // panelProcesses
            // 
            this.panelProcesses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelProcesses.Controls.Add(this.listViewProcesses);
            this.panelProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProcesses.Location = new System.Drawing.Point(10, 10);
            this.panelProcesses.Name = "panelProcesses";
            this.panelProcesses.Size = new System.Drawing.Size(784, 501);
            this.panelProcesses.TabIndex = 1;
            // 
            // listViewProcesses
            // 
            this.listViewProcesses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.listViewProcesses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderName,
            this.columnHeaderId,
            this.columnHeaderStatus});
            this.listViewProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewProcesses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewProcesses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.listViewProcesses.GridLines = true;
            this.listViewProcesses.HideSelection = false;
            this.listViewProcesses.Location = new System.Drawing.Point(0, 0);
            this.listViewProcesses.Name = "listViewProcesses";
            this.listViewProcesses.Size = new System.Drawing.Size(784, 501);
            this.listViewProcesses.TabIndex = 0;
            this.listViewProcesses.UseCompatibleStateImageBehavior = false;
            this.listViewProcesses.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderName
            // 
            this.columnHeaderName.Text = "Process Name";
            this.columnHeaderName.Width = 350;
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "Process ID";
            this.columnHeaderId.Width = 120;
            // 
            // columnHeaderStatus
            // 
            this.columnHeaderStatus.Text = "Status";
            this.columnHeaderStatus.Width = 150;
            // 
            // panelAntiPhishing
            // 
            this.panelAntiPhishing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelAntiPhishing.Controls.Add(this.rtbPhishingLog);
            this.panelAntiPhishing.Controls.Add(this.btnScanUrl);
            this.panelAntiPhishing.Controls.Add(this.txtUrlToScan);
            this.panelAntiPhishing.Controls.Add(this.label4);
            this.panelAntiPhishing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAntiPhishing.Location = new System.Drawing.Point(10, 10);
            this.panelAntiPhishing.Name = "panelAntiPhishing";
            this.panelAntiPhishing.Size = new System.Drawing.Size(784, 501);
            this.panelAntiPhishing.TabIndex = 2;
            // 
            // rtbPhishingLog
            // 
            this.rtbPhishingLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbPhishingLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.rtbPhishingLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbPhishingLog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbPhishingLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.rtbPhishingLog.Location = new System.Drawing.Point(23, 80);
            this.rtbPhishingLog.Name = "rtbPhishingLog";
            this.rtbPhishingLog.ReadOnly = true;
            this.rtbPhishingLog.Size = new System.Drawing.Size(738, 398);
            this.rtbPhishingLog.TabIndex = 3;
            this.rtbPhishingLog.Text = "";
            // 
            // btnScanUrl
            // 
            this.btnScanUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScanUrl.BackColor = System.Drawing.Color.Transparent;
            this.btnScanUrl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnScanUrl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnScanUrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScanUrl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnScanUrl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.btnScanUrl.Location = new System.Drawing.Point(611, 20);
            this.btnScanUrl.Name = "btnScanUrl";
            this.btnScanUrl.Size = new System.Drawing.Size(150, 45);
            this.btnScanUrl.TabIndex = 2;
            this.btnScanUrl.Text = "Scan URL";
            this.btnScanUrl.UseVisualStyleBackColor = false;
            this.btnScanUrl.Click += new System.EventHandler(this.BtnScanUrl_Click);
            // 
            // txtUrlToScan
            // 
            this.txtUrlToScan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrlToScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.txtUrlToScan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUrlToScan.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrlToScan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.txtUrlToScan.Location = new System.Drawing.Point(120, 28);
            this.txtUrlToScan.Name = "txtUrlToScan";
            this.txtUrlToScan.Size = new System.Drawing.Size(473, 27);
            this.txtUrlToScan.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "URL to Scan:";
            // 
            // panelRansomware
            // 
            this.panelRansomware.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelRansomware.Controls.Add(this.rtbHoneypotLog);
            this.panelRansomware.Controls.Add(this.btnStopHoneypot);
            this.panelRansomware.Controls.Add(this.btnDeployHoneypot);
            this.panelRansomware.Controls.Add(this.label5);
            this.panelRansomware.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRansomware.Location = new System.Drawing.Point(10, 10);
            this.panelRansomware.Name = "panelRansomware";
            this.panelRansomware.Size = new System.Drawing.Size(784, 501);
            this.panelRansomware.TabIndex = 3;
            // 
            // rtbHoneypotLog
            // 
            this.rtbHoneypotLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbHoneypotLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.rtbHoneypotLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbHoneypotLog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbHoneypotLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.rtbHoneypotLog.Location = new System.Drawing.Point(23, 105);
            this.rtbHoneypotLog.Name = "rtbHoneypotLog";
            this.rtbHoneypotLog.ReadOnly = true;
            this.rtbHoneypotLog.Size = new System.Drawing.Size(738, 373);
            this.rtbHoneypotLog.TabIndex = 4;
            this.rtbHoneypotLog.Text = "";
            // 
            // btnStopHoneypot
            // 
            this.btnStopHoneypot.BackColor = System.Drawing.Color.Transparent;
            this.btnStopHoneypot.Enabled = false;
            this.btnStopHoneypot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnStopHoneypot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnStopHoneypot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopHoneypot.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnStopHoneypot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.btnStopHoneypot.Location = new System.Drawing.Point(204, 47);
            this.btnStopHoneypot.Name = "btnStopHoneypot";
            this.btnStopHoneypot.Size = new System.Drawing.Size(150, 45);
            this.btnStopHoneypot.TabIndex = 2;
            this.btnStopHoneypot.Text = "Stop Monitoring";
            this.btnStopHoneypot.UseVisualStyleBackColor = false;
            this.btnStopHoneypot.Click += new System.EventHandler(this.BtnStopHoneypot_Click);
            // 
            // btnDeployHoneypot
            // 
            this.btnDeployHoneypot.BackColor = System.Drawing.Color.Transparent;
            this.btnDeployHoneypot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDeployHoneypot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDeployHoneypot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeployHoneypot.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeployHoneypot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.btnDeployHoneypot.Location = new System.Drawing.Point(23, 47);
            this.btnDeployHoneypot.Name = "btnDeployHoneypot";
            this.btnDeployHoneypot.Size = new System.Drawing.Size(150, 45);
            this.btnDeployHoneypot.TabIndex = 1;
            this.btnDeployHoneypot.Text = "Deploy Honeypot";
            this.btnDeployHoneypot.UseVisualStyleBackColor = false;
            this.btnDeployHoneypot.Click += new System.EventHandler(this.BtnDeployHoneypot_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(20, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(434, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Creates a bait folder and monitors it for changes, which can indicate ransomware" +
    ".";
            // 
            // panelAdvanced
            // 
            this.panelAdvanced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelAdvanced.Controls.Add(this.tableLayoutPanel1);
            this.panelAdvanced.Controls.Add(this.btnRunAllChecks);
            this.panelAdvanced.Controls.Add(this.btnCreateBaseline);
            this.panelAdvanced.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAdvanced.Location = new System.Drawing.Point(10, 10);
            this.panelAdvanced.Name = "panelAdvanced";
            this.panelAdvanced.Size = new System.Drawing.Size(784, 501);
            this.panelAdvanced.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.lbUserAccounts, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbNetworkConnections, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbFileIntegrity, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(738, 408);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // lbUserAccounts
            // 
            this.lbUserAccounts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lbUserAccounts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbUserAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbUserAccounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.lbUserAccounts.FormattingEnabled = true;
            this.lbUserAccounts.ItemHeight = 15;
            this.lbUserAccounts.Location = new System.Drawing.Point(495, 23);
            this.lbUserAccounts.Name = "lbUserAccounts";
            this.lbUserAccounts.Size = new System.Drawing.Size(240, 382);
            this.lbUserAccounts.TabIndex = 5;
            // 
            // lbNetworkConnections
            // 
            this.lbNetworkConnections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lbNetworkConnections.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbNetworkConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNetworkConnections.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.lbNetworkConnections.FormattingEnabled = true;
            this.lbNetworkConnections.ItemHeight = 15;
            this.lbNetworkConnections.Location = new System.Drawing.Point(249, 23);
            this.lbNetworkConnections.Name = "lbNetworkConnections";
            this.lbNetworkConnections.Size = new System.Drawing.Size(240, 382);
            this.lbNetworkConnections.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(495, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "User Account Monitor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(249, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Network Monitor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "File Integrity Monitor";
            // 
            // lbFileIntegrity
            // 
            this.lbFileIntegrity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lbFileIntegrity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbFileIntegrity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbFileIntegrity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.lbFileIntegrity.FormattingEnabled = true;
            this.lbFileIntegrity.ItemHeight = 15;
            this.lbFileIntegrity.Location = new System.Drawing.Point(3, 23);
            this.lbFileIntegrity.Name = "lbFileIntegrity";
            this.lbFileIntegrity.Size = new System.Drawing.Size(240, 382);
            this.lbFileIntegrity.TabIndex = 3;
            // 
            // btnRunAllChecks
            // 
            this.btnRunAllChecks.BackColor = System.Drawing.Color.Transparent;
            this.btnRunAllChecks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRunAllChecks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRunAllChecks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunAllChecks.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRunAllChecks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.btnRunAllChecks.Location = new System.Drawing.Point(204, 15);
            this.btnRunAllChecks.Name = "btnRunAllChecks";
            this.btnRunAllChecks.Size = new System.Drawing.Size(150, 45);
            this.btnRunAllChecks.TabIndex = 4;
            this.btnRunAllChecks.Text = "Run Manual Scan";
            this.btnRunAllChecks.UseVisualStyleBackColor = false;
            this.btnRunAllChecks.Click += new System.EventHandler(this.BtnRunAllChecks_Click);
            // 
            // btnCreateBaseline
            // 
            this.btnCreateBaseline.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateBaseline.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCreateBaseline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCreateBaseline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateBaseline.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCreateBaseline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.btnCreateBaseline.Location = new System.Drawing.Point(23, 15);
            this.btnCreateBaseline.Name = "btnCreateBaseline";
            this.btnCreateBaseline.Size = new System.Drawing.Size(150, 45);
            this.btnCreateBaseline.TabIndex = 3;
            this.btnCreateBaseline.Text = "Create File Baseline";
            this.btnCreateBaseline.UseVisualStyleBackColor = false;
            this.btnCreateBaseline.Click += new System.EventHandler(this.BtnCreateBaseline_Click);
            // 
            // panelLogs
            // 
            this.panelLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panelLogs.Controls.Add(this.rtbAppLog);
            this.panelLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLogs.Location = new System.Drawing.Point(10, 10);
            this.panelLogs.Name = "panelLogs";
            this.panelLogs.Size = new System.Drawing.Size(784, 501);
            this.panelLogs.TabIndex = 5;
            // 
            // rtbAppLog
            // 
            this.rtbAppLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.rtbAppLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbAppLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbAppLog.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.rtbAppLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.rtbAppLog.Location = new System.Drawing.Point(0, 0);
            this.rtbAppLog.Name = "rtbAppLog";
            this.rtbAppLog.ReadOnly = true;
            this.rtbAppLog.Size = new System.Drawing.Size(784, 501);
            this.rtbAppLog.TabIndex = 0;
            this.rtbAppLog.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WinSecSentinel.Properties.Resources.form_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinSecSentinel";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelSystemInfo.ResumeLayout(false);
            this.panelSystemInfo.PerformLayout();
            this.panelProcesses.ResumeLayout(false);
            this.panelAntiPhishing.ResumeLayout(false);
            this.panelAntiPhishing.PerformLayout();
            this.panelRansomware.ResumeLayout(false);
            this.panelRansomware.PerformLayout();
            this.panelAdvanced.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelLogs.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FuturisticButton btnSystemInfo;
        private FuturisticButton btnProcesses;
        private FuturisticButton btnAntiPhishing;
        private FuturisticButton btnRansomware;
        private FuturisticButton btnAdvanced;
        private FuturisticButton btnLogs;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelSystemInfo;
        private System.Windows.Forms.Panel panelProcesses;
        private System.Windows.Forms.Panel panelAntiPhishing;
        private System.Windows.Forms.Panel panelRansomware;
        private System.Windows.Forms.Panel panelAdvanced;
        private System.Windows.Forms.Panel panelLogs;
        private System.Windows.Forms.Label lblOSVersion;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewProcesses;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderStatus;
        private System.Windows.Forms.RichTextBox rtbPhishingLog;
        private FuturisticButton btnScanUrl;
        private System.Windows.Forms.TextBox txtUrlToScan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbHoneypotLog;
        private FuturisticButton btnStopHoneypot;
        private FuturisticButton btnDeployHoneypot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox lbUserAccounts;
        private System.Windows.Forms.ListBox lbNetworkConnections;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbFileIntegrity;
        private FuturisticButton btnRunAllChecks;
        private FuturisticButton btnCreateBaseline;
        private System.Windows.Forms.RichTextBox rtbAppLog;
        private System.Windows.Forms.Timer monitoringTimer;
    }
}