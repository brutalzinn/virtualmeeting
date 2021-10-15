namespace VirtualMeetingMonitor
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusNoCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.onAirOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onAirOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.openLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configTimeoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pluginManagertoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationstatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableSleepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meetingTxt = new System.Windows.Forms.Label();
            this.label_meeting = new System.Windows.Forms.Label();
            this.label_started = new System.Windows.Forms.Label();
            this.label_ended = new System.Windows.Forms.Label();
            this.label_ip = new System.Windows.Forms.Label();
            this.label_udp_packts = new System.Windows.Forms.Label();
            this.label_inbound = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.startedTxt = new System.Windows.Forms.Label();
            this.EnedTxt = new System.Windows.Forms.Label();
            this.IpTxt = new System.Windows.Forms.Label();
            this.InboundTxt = new System.Windows.Forms.Label();
            this.OutboundTxt = new System.Windows.Forms.Label();
            this.TotalTxt = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Status = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Dev_LabelMode = new System.Windows.Forms.Label();
            this.devGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_version = new System.Windows.Forms.Label();
            this.lbl_arduino_status = new System.Windows.Forms.Label();
            this.lbl_tags_count = new System.Windows.Forms.Label();
            this.lbl_plugin_count = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Dev_TestGoogle = new System.Windows.Forms.Button();
            this.Dev_Config = new System.Windows.Forms.Button();
            this.Dev_helpButton = new System.Windows.Forms.Button();
            this.Dev_ButtonTeste = new System.Windows.Forms.Button();
            this.Dev_ClearConfigs = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label_outbound = new System.Windows.Forms.Label();
            this.internetWorker = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip.SuspendLayout();
            this.devGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusNoCallToolStripMenuItem,
            this.toolStripSeparator2,
            this.onAirOnToolStripMenuItem,
            this.onAirOffToolStripMenuItem,
            this.toolStripSeparator3,
            this.openLogToolStripMenuItem,
            this.configTimeoutToolStripMenuItem,
            this.pluginManagertoolStripMenuItem,
            this.helpToolStripMenuItem,
            this.notificationsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.endCallToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip.Size = new System.Drawing.Size(164, 264);
            this.contextMenuStrip.Opened += new System.EventHandler(this.contextMenuStrip_Opened);
            // 
            // statusNoCallToolStripMenuItem
            // 
            this.statusNoCallToolStripMenuItem.Name = "statusNoCallToolStripMenuItem";
            this.statusNoCallToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.statusNoCallToolStripMenuItem.Text = "Status: No call";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(160, 6);
            // 
            // onAirOnToolStripMenuItem
            // 
            this.onAirOnToolStripMenuItem.Name = "onAirOnToolStripMenuItem";
            this.onAirOnToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.onAirOnToolStripMenuItem.Text = "Air On";
            this.onAirOnToolStripMenuItem.Click += new System.EventHandler(this.onAirOnToolStripMenuItem_Click);
            // 
            // onAirOffToolStripMenuItem
            // 
            this.onAirOffToolStripMenuItem.Name = "onAirOffToolStripMenuItem";
            this.onAirOffToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.onAirOffToolStripMenuItem.Text = "Air Off";
            this.onAirOffToolStripMenuItem.Click += new System.EventHandler(this.onAirOffToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(160, 6);
            // 
            // openLogToolStripMenuItem
            // 
            this.openLogToolStripMenuItem.Name = "openLogToolStripMenuItem";
            this.openLogToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.openLogToolStripMenuItem.Text = "Open Log";
            this.openLogToolStripMenuItem.Click += new System.EventHandler(this.openLogToolStripMenuItem_Click);
            // 
            // configTimeoutToolStripMenuItem
            // 
            this.configTimeoutToolStripMenuItem.Name = "configTimeoutToolStripMenuItem";
            this.configTimeoutToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.configTimeoutToolStripMenuItem.Text = "Config";
            this.configTimeoutToolStripMenuItem.Click += new System.EventHandler(this.configTimeoutToolStripMenuItem_Click);
            // 
            // pluginManagertoolStripMenuItem
            // 
            this.pluginManagertoolStripMenuItem.Name = "pluginManagertoolStripMenuItem";
            this.pluginManagertoolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.pluginManagertoolStripMenuItem.Text = "Plugins Manager";
            this.pluginManagertoolStripMenuItem.Click += new System.EventHandler(this.pluginManagertoolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // notificationsToolStripMenuItem
            // 
            this.notificationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notificationstatusToolStripMenuItem,
            this.enableSleepToolStripMenuItem});
            this.notificationsToolStripMenuItem.Name = "notificationsToolStripMenuItem";
            this.notificationsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.notificationsToolStripMenuItem.Text = "Notifications";
            // 
            // notificationstatusToolStripMenuItem
            // 
            this.notificationstatusToolStripMenuItem.Name = "notificationstatusToolStripMenuItem";
            this.notificationstatusToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.notificationstatusToolStripMenuItem.Text = "{notification.status}";
            this.notificationstatusToolStripMenuItem.Click += new System.EventHandler(this.notificationstatusToolStripMenuItem_Click);
            // 
            // enableSleepToolStripMenuItem
            // 
            this.enableSleepToolStripMenuItem.Name = "enableSleepToolStripMenuItem";
            this.enableSleepToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.enableSleepToolStripMenuItem.Text = "Enable sleep";
            this.enableSleepToolStripMenuItem.Click += new System.EventHandler(this.enableSleepToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click_1);
            // 
            // endCallToolStripMenuItem
            // 
            this.endCallToolStripMenuItem.Name = "endCallToolStripMenuItem";
            this.endCallToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.endCallToolStripMenuItem.Text = "End call";
            this.endCallToolStripMenuItem.Click += new System.EventHandler(this.endCallToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(160, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // meetingTxt
            // 
            this.meetingTxt.AutoSize = true;
            this.meetingTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.meetingTxt.Location = new System.Drawing.Point(90, 13);
            this.meetingTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.meetingTxt.Name = "meetingTxt";
            this.meetingTxt.Size = new System.Drawing.Size(38, 13);
            this.meetingTxt.TabIndex = 1;
            this.meetingTxt.Text = "Zoom";
            // 
            // label_meeting
            // 
            this.label_meeting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_meeting.AutoSize = true;
            this.label_meeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_meeting.Location = new System.Drawing.Point(5, 10);
            this.label_meeting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_meeting.Name = "label_meeting";
            this.label_meeting.Size = new System.Drawing.Size(58, 16);
            this.label_meeting.TabIndex = 1;
            this.label_meeting.Text = "Meeting:";
            // 
            // label_started
            // 
            this.label_started.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_started.AutoSize = true;
            this.label_started.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_started.Location = new System.Drawing.Point(5, 45);
            this.label_started.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_started.Name = "label_started";
            this.label_started.Size = new System.Drawing.Size(53, 16);
            this.label_started.TabIndex = 2;
            this.label_started.Text = "Started:";
            this.label_started.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_ended
            // 
            this.label_ended.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_ended.AutoSize = true;
            this.label_ended.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ended.Location = new System.Drawing.Point(5, 77);
            this.label_ended.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ended.Name = "label_ended";
            this.label_ended.Size = new System.Drawing.Size(50, 16);
            this.label_ended.TabIndex = 3;
            this.label_ended.Text = "Ended:";
            this.label_ended.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_ip
            // 
            this.label_ip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_ip.AutoSize = true;
            this.label_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ip.Location = new System.Drawing.Point(27, 110);
            this.label_ip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(22, 16);
            this.label_ip.TabIndex = 4;
            this.label_ip.Text = "IP:";
            this.label_ip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_udp_packts
            // 
            this.label_udp_packts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_udp_packts.AutoSize = true;
            this.label_udp_packts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_udp_packts.Location = new System.Drawing.Point(302, 9);
            this.label_udp_packts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_udp_packts.Name = "label_udp_packts";
            this.label_udp_packts.Size = new System.Drawing.Size(80, 16);
            this.label_udp_packts.TabIndex = 5;
            this.label_udp_packts.Text = "UDP Packts";
            // 
            // label_inbound
            // 
            this.label_inbound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_inbound.AutoSize = true;
            this.label_inbound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_inbound.Location = new System.Drawing.Point(318, 44);
            this.label_inbound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_inbound.Name = "label_inbound";
            this.label_inbound.Size = new System.Drawing.Size(22, 16);
            this.label_inbound.TabIndex = 6;
            this.label_inbound.Text = "---:";
            this.label_inbound.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_total
            // 
            this.label_total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_total.Location = new System.Drawing.Point(318, 113);
            this.label_total.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(22, 16);
            this.label_total.TabIndex = 8;
            this.label_total.Text = "---:";
            this.label_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // startedTxt
            // 
            this.startedTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.startedTxt.AutoSize = true;
            this.startedTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.startedTxt.Location = new System.Drawing.Point(90, 47);
            this.startedTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startedTxt.Name = "startedTxt";
            this.startedTxt.Size = new System.Drawing.Size(95, 13);
            this.startedTxt.TabIndex = 9;
            this.startedTxt.Text = "02/24 11:29:56";
            // 
            // EnedTxt
            // 
            this.EnedTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EnedTxt.AutoSize = true;
            this.EnedTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EnedTxt.Location = new System.Drawing.Point(90, 81);
            this.EnedTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnedTxt.Name = "EnedTxt";
            this.EnedTxt.Size = new System.Drawing.Size(95, 13);
            this.EnedTxt.TabIndex = 10;
            this.EnedTxt.Text = "02/24 11:29:56";
            // 
            // IpTxt
            // 
            this.IpTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.IpTxt.AutoSize = true;
            this.IpTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IpTxt.Location = new System.Drawing.Point(90, 113);
            this.IpTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IpTxt.Name = "IpTxt";
            this.IpTxt.Size = new System.Drawing.Size(89, 13);
            this.IpTxt.TabIndex = 11;
            this.IpTxt.Text = "147.124.99.96";
            // 
            // InboundTxt
            // 
            this.InboundTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InboundTxt.AutoSize = true;
            this.InboundTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InboundTxt.Location = new System.Drawing.Point(394, 47);
            this.InboundTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.InboundTxt.Name = "InboundTxt";
            this.InboundTxt.Size = new System.Drawing.Size(28, 13);
            this.InboundTxt.TabIndex = 12;
            this.InboundTxt.Text = "200";
            // 
            // OutboundTxt
            // 
            this.OutboundTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutboundTxt.AutoSize = true;
            this.OutboundTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OutboundTxt.Location = new System.Drawing.Point(394, 81);
            this.OutboundTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutboundTxt.Name = "OutboundTxt";
            this.OutboundTxt.Size = new System.Drawing.Size(28, 13);
            this.OutboundTxt.TabIndex = 13;
            this.OutboundTxt.Text = "222";
            // 
            // TotalTxt
            // 
            this.TotalTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalTxt.AutoSize = true;
            this.TotalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalTxt.Location = new System.Drawing.Point(394, 115);
            this.TotalTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalTxt.Name = "TotalTxt";
            this.TotalTxt.Size = new System.Drawing.Size(28, 13);
            this.TotalTxt.TabIndex = 14;
            this.TotalTxt.Text = "422";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Status.Location = new System.Drawing.Point(0, 359);
            this.Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(22, 15);
            this.Status.TabIndex = 15;
            this.Status.Text = "---";
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 45);
            this.button1.TabIndex = 16;
            this.button1.Text = "Test notify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Dev_LabelMode
            // 
            this.Dev_LabelMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Dev_LabelMode.AutoSize = true;
            this.Dev_LabelMode.Location = new System.Drawing.Point(331, 350);
            this.Dev_LabelMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dev_LabelMode.Name = "Dev_LabelMode";
            this.Dev_LabelMode.Size = new System.Drawing.Size(84, 15);
            this.Dev_LabelMode.TabIndex = 17;
            this.Dev_LabelMode.Text = "Mode: Normal";
            // 
            // devGroupBox
            // 
            this.devGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.devGroupBox.Controls.Add(this.groupBox1);
            this.devGroupBox.Controls.Add(this.button3);
            this.devGroupBox.Controls.Add(this.Dev_TestGoogle);
            this.devGroupBox.Controls.Add(this.Dev_Config);
            this.devGroupBox.Controls.Add(this.Dev_helpButton);
            this.devGroupBox.Controls.Add(this.Dev_ButtonTeste);
            this.devGroupBox.Controls.Add(this.Dev_ClearConfigs);
            this.devGroupBox.Controls.Add(this.button2);
            this.devGroupBox.Controls.Add(this.button1);
            this.devGroupBox.Enabled = false;
            this.devGroupBox.Location = new System.Drawing.Point(8, 167);
            this.devGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.devGroupBox.Name = "devGroupBox";
            this.devGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.devGroupBox.Size = new System.Drawing.Size(414, 164);
            this.devGroupBox.TabIndex = 18;
            this.devGroupBox.TabStop = false;
            this.devGroupBox.Text = "Developer mode";
            this.devGroupBox.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_version);
            this.groupBox1.Controls.Add(this.lbl_arduino_status);
            this.groupBox1.Controls.Add(this.lbl_tags_count);
            this.groupBox1.Controls.Add(this.lbl_plugin_count);
            this.groupBox1.Location = new System.Drawing.Point(294, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 127);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dev - Status";
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Location = new System.Drawing.Point(7, 19);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(84, 15);
            this.lbl_version.TabIndex = 3;
            this.lbl_version.Text = "Version: 0.0.0.0";
            // 
            // lbl_arduino_status
            // 
            this.lbl_arduino_status.AutoSize = true;
            this.lbl_arduino_status.Location = new System.Drawing.Point(6, 79);
            this.lbl_arduino_status.Name = "lbl_arduino_status";
            this.lbl_arduino_status.Size = new System.Drawing.Size(95, 15);
            this.lbl_arduino_status.TabIndex = 2;
            this.lbl_arduino_status.Text = "Arduino: {status}";
            // 
            // lbl_tags_count
            // 
            this.lbl_tags_count.AutoSize = true;
            this.lbl_tags_count.Location = new System.Drawing.Point(7, 94);
            this.lbl_tags_count.Name = "lbl_tags_count";
            this.lbl_tags_count.Size = new System.Drawing.Size(89, 15);
            this.lbl_tags_count.TabIndex = 1;
            this.lbl_tags_count.Text = "Tags: {0} loaded";
            // 
            // lbl_plugin_count
            // 
            this.lbl_plugin_count.AutoSize = true;
            this.lbl_plugin_count.Location = new System.Drawing.Point(7, 109);
            this.lbl_plugin_count.Name = "lbl_plugin_count";
            this.lbl_plugin_count.Size = new System.Drawing.Size(91, 15);
            this.lbl_plugin_count.TabIndex = 0;
            this.lbl_plugin_count.Text = "Plugins: {count}";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 25);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 44);
            this.button3.TabIndex = 21;
            this.button3.Text = "Actions";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Dev_TestGoogle
            // 
            this.Dev_TestGoogle.Location = new System.Drawing.Point(7, 103);
            this.Dev_TestGoogle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Dev_TestGoogle.Name = "Dev_TestGoogle";
            this.Dev_TestGoogle.Size = new System.Drawing.Size(65, 45);
            this.Dev_TestGoogle.TabIndex = 20;
            this.Dev_TestGoogle.Text = "Google Test";
            this.Dev_TestGoogle.UseVisualStyleBackColor = true;
            this.Dev_TestGoogle.Click += new System.EventHandler(this.Dev_TestGoogle_Click);
            // 
            // Dev_Config
            // 
            this.Dev_Config.Location = new System.Drawing.Point(150, 103);
            this.Dev_Config.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Dev_Config.Name = "Dev_Config";
            this.Dev_Config.Size = new System.Drawing.Size(68, 46);
            this.Dev_Config.TabIndex = 19;
            this.Dev_Config.Text = "TEST LANGUAGE";
            this.Dev_Config.UseVisualStyleBackColor = true;
            this.Dev_Config.Click += new System.EventHandler(this.Dev_Config_Click);
            // 
            // Dev_helpButton
            // 
            this.Dev_helpButton.Location = new System.Drawing.Point(226, 24);
            this.Dev_helpButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Dev_helpButton.Name = "Dev_helpButton";
            this.Dev_helpButton.Size = new System.Drawing.Size(63, 45);
            this.Dev_helpButton.TabIndex = 19;
            this.Dev_helpButton.Text = "Test Help Dialog";
            this.Dev_helpButton.UseVisualStyleBackColor = true;
            this.Dev_helpButton.Click += new System.EventHandler(this.Dev_helpButton_Click);
            // 
            // Dev_ButtonTeste
            // 
            this.Dev_ButtonTeste.Location = new System.Drawing.Point(150, 25);
            this.Dev_ButtonTeste.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Dev_ButtonTeste.Name = "Dev_ButtonTeste";
            this.Dev_ButtonTeste.Size = new System.Drawing.Size(68, 44);
            this.Dev_ButtonTeste.TabIndex = 19;
            this.Dev_ButtonTeste.Text = "TESTE";
            this.Dev_ButtonTeste.UseVisualStyleBackColor = true;
            this.Dev_ButtonTeste.Click += new System.EventHandler(this.Dev_ButtonTeste_Click);
            // 
            // Dev_ClearConfigs
            // 
            this.Dev_ClearConfigs.Location = new System.Drawing.Point(230, 103);
            this.Dev_ClearConfigs.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Dev_ClearConfigs.Name = "Dev_ClearConfigs";
            this.Dev_ClearConfigs.Size = new System.Drawing.Size(59, 45);
            this.Dev_ClearConfigs.TabIndex = 18;
            this.Dev_ClearConfigs.Text = "Clear configs";
            this.Dev_ClearConfigs.UseVisualStyleBackColor = true;
            this.Dev_ClearConfigs.Click += new System.EventHandler(this.Dev_ClearConfigs_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(79, 104);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 45);
            this.button2.TabIndex = 17;
            this.button2.Text = "Stop all";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label_outbound
            // 
            this.label_outbound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_outbound.AutoSize = true;
            this.label_outbound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_outbound.Location = new System.Drawing.Point(318, 77);
            this.label_outbound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_outbound.Name = "label_outbound";
            this.label_outbound.Size = new System.Drawing.Size(18, 16);
            this.label_outbound.TabIndex = 19;
            this.label_outbound.Text = "--:";
            this.label_outbound.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // internetWorker
            // 
            this.internetWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.internetWorker_DoWork);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(429, 374);
            this.Controls.Add(this.label_outbound);
            this.Controls.Add(this.devGroupBox);
            this.Controls.Add(this.Dev_LabelMode);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.TotalTxt);
            this.Controls.Add(this.OutboundTxt);
            this.Controls.Add(this.InboundTxt);
            this.Controls.Add(this.IpTxt);
            this.Controls.Add(this.EnedTxt);
            this.Controls.Add(this.startedTxt);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label_inbound);
            this.Controls.Add(this.label_udp_packts);
            this.Controls.Add(this.label_ip);
            this.Controls.Add(this.label_ended);
            this.Controls.Add(this.label_started);
            this.Controls.Add(this.label_meeting);
            this.Controls.Add(this.meetingTxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Virtual Meeting Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDoubleClick);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip.ResumeLayout(false);
            this.devGroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label meetingTxt;
        private System.Windows.Forms.Label label_meeting;
        private System.Windows.Forms.Label label_started;
        private System.Windows.Forms.Label label_ended;
        private System.Windows.Forms.Label label_ip;
        private System.Windows.Forms.Label label_udp_packts;
        private System.Windows.Forms.Label label_inbound;
        private System.Windows.Forms.Label startedTxt;
        private System.Windows.Forms.Label EnedTxt;
        private System.Windows.Forms.Label IpTxt;
        private System.Windows.Forms.Label InboundTxt;
        private System.Windows.Forms.Label OutboundTxt;
        private System.Windows.Forms.Label TotalTxt;
        private System.Windows.Forms.ToolStripMenuItem openLogToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem configTimeoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusNoCallToolStripMenuItem;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Dev_LabelMode;
        private System.Windows.Forms.GroupBox devGroupBox;
        private System.Windows.Forms.Button Dev_ClearConfigs;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button Dev_helpButton;
        private System.Windows.Forms.Button Dev_ButtonTeste;
        private System.Windows.Forms.Button Dev_Config;
        private System.Windows.Forms.Button Dev_TestGoogle;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label label_outbound;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endCallToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem notificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificationstatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableSleepToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_plugin_count;
        private System.Windows.Forms.Label lbl_tags_count;
        private System.Windows.Forms.Label lbl_arduino_status;
        private System.ComponentModel.BackgroundWorker internetWorker;
        private System.Windows.Forms.Label lbl_version;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem onAirOnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onAirOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem pluginManagertoolStripMenuItem;
    }
}

