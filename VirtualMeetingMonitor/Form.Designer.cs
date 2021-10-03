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
            this.openLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configTimeoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.Dev_TestGoogle = new System.Windows.Forms.Button();
            this.Dev_Config = new System.Windows.Forms.Button();
            this.Dev_helpButton = new System.Windows.Forms.Button();
            this.Dev_ButtonTeste = new System.Windows.Forms.Button();
            this.Dev_ClearConfigs = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label_outbound = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            this.devGroupBox.SuspendLayout();
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
            this.openLogToolStripMenuItem,
            this.configTimeoutToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(150, 114);
            // 
            // statusNoCallToolStripMenuItem
            // 
            this.statusNoCallToolStripMenuItem.Name = "statusNoCallToolStripMenuItem";
            this.statusNoCallToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.statusNoCallToolStripMenuItem.Text = "Status: No call";
            // 
            // openLogToolStripMenuItem
            // 
            this.openLogToolStripMenuItem.Name = "openLogToolStripMenuItem";
            this.openLogToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openLogToolStripMenuItem.Text = "Open Log";
            this.openLogToolStripMenuItem.Click += new System.EventHandler(this.openLogToolStripMenuItem_Click);
            // 
            // configTimeoutToolStripMenuItem
            // 
            this.configTimeoutToolStripMenuItem.Name = "configTimeoutToolStripMenuItem";
            this.configTimeoutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configTimeoutToolStripMenuItem.Text = "Config";
            this.configTimeoutToolStripMenuItem.Click += new System.EventHandler(this.configTimeoutToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // meetingTxt
            // 
            this.meetingTxt.AutoSize = true;
            this.meetingTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meetingTxt.Location = new System.Drawing.Point(64, 11);
            this.meetingTxt.Name = "meetingTxt";
            this.meetingTxt.Size = new System.Drawing.Size(38, 13);
            this.meetingTxt.TabIndex = 1;
            this.meetingTxt.Text = "Zoom";
            // 
            // label_meeting
            // 
            this.label_meeting.AutoSize = true;
            this.label_meeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_meeting.Location = new System.Drawing.Point(4, 9);
            this.label_meeting.Name = "label_meeting";
            this.label_meeting.Size = new System.Drawing.Size(59, 16);
            this.label_meeting.TabIndex = 1;
            this.label_meeting.Text = "Meeting:";
            // 
            // label_started
            // 
            this.label_started.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_started.AutoSize = true;
            this.label_started.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_started.Location = new System.Drawing.Point(4, 39);
            this.label_started.Name = "label_started";
            this.label_started.Size = new System.Drawing.Size(54, 16);
            this.label_started.TabIndex = 2;
            this.label_started.Text = "Started:";
            this.label_started.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_ended
            // 
            this.label_ended.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_ended.AutoSize = true;
            this.label_ended.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ended.Location = new System.Drawing.Point(4, 67);
            this.label_ended.Name = "label_ended";
            this.label_ended.Size = new System.Drawing.Size(51, 16);
            this.label_ended.TabIndex = 3;
            this.label_ended.Text = "Ended:";
            this.label_ended.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_ip
            // 
            this.label_ip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label_ip.AutoSize = true;
            this.label_ip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ip.Location = new System.Drawing.Point(4, 95);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(23, 16);
            this.label_ip.TabIndex = 4;
            this.label_ip.Text = "IP:";
            this.label_ip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_udp_packts
            // 
            this.label_udp_packts.AutoSize = true;
            this.label_udp_packts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_udp_packts.Location = new System.Drawing.Point(273, 8);
            this.label_udp_packts.Name = "label_udp_packts";
            this.label_udp_packts.Size = new System.Drawing.Size(81, 16);
            this.label_udp_packts.TabIndex = 5;
            this.label_udp_packts.Text = "UDP Packts";
            // 
            // label_inbound
            // 
            this.label_inbound.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_inbound.AutoSize = true;
            this.label_inbound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_inbound.Location = new System.Drawing.Point(270, 38);
            this.label_inbound.Name = "label_inbound";
            this.label_inbound.Size = new System.Drawing.Size(23, 16);
            this.label_inbound.TabIndex = 6;
            this.label_inbound.Text = "---:";
            this.label_inbound.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_total
            // 
            this.label_total.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_total.Location = new System.Drawing.Point(273, 98);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(23, 16);
            this.label_total.TabIndex = 8;
            this.label_total.Text = "---:";
            this.label_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // startedTxt
            // 
            this.startedTxt.AutoSize = true;
            this.startedTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startedTxt.Location = new System.Drawing.Point(64, 41);
            this.startedTxt.Name = "startedTxt";
            this.startedTxt.Size = new System.Drawing.Size(95, 13);
            this.startedTxt.TabIndex = 9;
            this.startedTxt.Text = "02/24 11:29:56";
            // 
            // EnedTxt
            // 
            this.EnedTxt.AutoSize = true;
            this.EnedTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnedTxt.Location = new System.Drawing.Point(61, 70);
            this.EnedTxt.Name = "EnedTxt";
            this.EnedTxt.Size = new System.Drawing.Size(95, 13);
            this.EnedTxt.TabIndex = 10;
            this.EnedTxt.Text = "02/24 11:29:56";
            // 
            // IpTxt
            // 
            this.IpTxt.AutoSize = true;
            this.IpTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IpTxt.Location = new System.Drawing.Point(33, 98);
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
            this.InboundTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InboundTxt.Location = new System.Drawing.Point(336, 41);
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
            this.OutboundTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutboundTxt.Location = new System.Drawing.Point(336, 70);
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
            this.TotalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTxt.Location = new System.Drawing.Point(336, 100);
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
            this.Status.Location = new System.Drawing.Point(0, 311);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(16, 13);
            this.Status.TabIndex = 15;
            this.Status.Text = "---";
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 39);
            this.button1.TabIndex = 16;
            this.button1.Text = "Test notify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Dev_LabelMode
            // 
            this.Dev_LabelMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dev_LabelMode.AutoSize = true;
            this.Dev_LabelMode.Location = new System.Drawing.Point(291, 311);
            this.Dev_LabelMode.Name = "Dev_LabelMode";
            this.Dev_LabelMode.Size = new System.Drawing.Size(73, 13);
            this.Dev_LabelMode.TabIndex = 17;
            this.Dev_LabelMode.Text = "Mode: Normal";
            // 
            // devGroupBox
            // 
            this.devGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.devGroupBox.Controls.Add(this.Dev_TestGoogle);
            this.devGroupBox.Controls.Add(this.Dev_Config);
            this.devGroupBox.Controls.Add(this.Dev_helpButton);
            this.devGroupBox.Controls.Add(this.Dev_ButtonTeste);
            this.devGroupBox.Controls.Add(this.Dev_ClearConfigs);
            this.devGroupBox.Controls.Add(this.button2);
            this.devGroupBox.Controls.Add(this.button1);
            this.devGroupBox.Enabled = false;
            this.devGroupBox.Location = new System.Drawing.Point(7, 145);
            this.devGroupBox.Name = "devGroupBox";
            this.devGroupBox.Size = new System.Drawing.Size(337, 142);
            this.devGroupBox.TabIndex = 18;
            this.devGroupBox.TabStop = false;
            this.devGroupBox.Text = "Developer mode";
            this.devGroupBox.Visible = false;
            // 
            // Dev_TestGoogle
            // 
            this.Dev_TestGoogle.Location = new System.Drawing.Point(52, 86);
            this.Dev_TestGoogle.Name = "Dev_TestGoogle";
            this.Dev_TestGoogle.Size = new System.Drawing.Size(56, 39);
            this.Dev_TestGoogle.TabIndex = 20;
            this.Dev_TestGoogle.Text = "Google Test";
            this.Dev_TestGoogle.UseVisualStyleBackColor = true;
            this.Dev_TestGoogle.Click += new System.EventHandler(this.Dev_TestGoogle_Click);
            // 
            // Dev_Config
            // 
            this.Dev_Config.Location = new System.Drawing.Point(185, 86);
            this.Dev_Config.Name = "Dev_Config";
            this.Dev_Config.Size = new System.Drawing.Size(78, 40);
            this.Dev_Config.TabIndex = 19;
            this.Dev_Config.Text = "TEST LANGUAGE";
            this.Dev_Config.UseVisualStyleBackColor = true;
            this.Dev_Config.Click += new System.EventHandler(this.Dev_Config_Click);
            // 
            // Dev_helpButton
            // 
            this.Dev_helpButton.Location = new System.Drawing.Point(266, 18);
            this.Dev_helpButton.Name = "Dev_helpButton";
            this.Dev_helpButton.Size = new System.Drawing.Size(65, 39);
            this.Dev_helpButton.TabIndex = 19;
            this.Dev_helpButton.Text = "Test Help Dialog";
            this.Dev_helpButton.UseVisualStyleBackColor = true;
            this.Dev_helpButton.Click += new System.EventHandler(this.Dev_helpButton_Click);
            // 
            // Dev_ButtonTeste
            // 
            this.Dev_ButtonTeste.Location = new System.Drawing.Point(185, 18);
            this.Dev_ButtonTeste.Name = "Dev_ButtonTeste";
            this.Dev_ButtonTeste.Size = new System.Drawing.Size(75, 38);
            this.Dev_ButtonTeste.TabIndex = 19;
            this.Dev_ButtonTeste.Text = "TESTE";
            this.Dev_ButtonTeste.UseVisualStyleBackColor = true;
            this.Dev_ButtonTeste.Click += new System.EventHandler(this.Dev_ButtonTeste_Click);
            // 
            // Dev_ClearConfigs
            // 
            this.Dev_ClearConfigs.Location = new System.Drawing.Point(269, 87);
            this.Dev_ClearConfigs.Name = "Dev_ClearConfigs";
            this.Dev_ClearConfigs.Size = new System.Drawing.Size(62, 39);
            this.Dev_ClearConfigs.TabIndex = 18;
            this.Dev_ClearConfigs.Text = "Clear configs";
            this.Dev_ClearConfigs.UseVisualStyleBackColor = true;
            this.Dev_ClearConfigs.Click += new System.EventHandler(this.Dev_ClearConfigs_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 39);
            this.button2.TabIndex = 17;
            this.button2.Text = "Stop all";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label_outbound
            // 
            this.label_outbound.AutoSize = true;
            this.label_outbound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label_outbound.Location = new System.Drawing.Point(273, 67);
            this.label_outbound.Name = "label_outbound";
            this.label_outbound.Size = new System.Drawing.Size(19, 16);
            this.label_outbound.TabIndex = 19;
            this.label_outbound.Text = "--:";
            this.label_outbound.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(366, 324);
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
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Virtual Meeting Monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDoubleClick);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.contextMenuStrip.ResumeLayout(false);
            this.devGroupBox.ResumeLayout(false);
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
    }
}

