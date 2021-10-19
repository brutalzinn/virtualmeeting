﻿using System.Drawing;
using System.Windows.Forms;

namespace VirtualMeetingMonitor.Forms.WorshopForms
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.consolePanel = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.consoleInput = new System.Windows.Forms.TextBox();
            this.consoleRun = new System.Windows.Forms.Button();
            this.consoleContainer = new System.Windows.Forms.Panel();
            this.consoleOutput = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ColorDisplay = new System.Windows.Forms.Label();
            this.consoleClearButton = new System.Windows.Forms.Button();
            this.CursorPosDisplay = new System.Windows.Forms.Label();
            this.layoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.optionsPanel = new System.Windows.Forms.TabControl();
            this.scriptsPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.scriptStop = new System.Windows.Forms.Button();
            this.openPackagesFolderButton = new System.Windows.Forms.Button();
            this.installedPackagesPanel = new System.Windows.Forms.Panel();
            this.installedPackagesList = new System.Windows.Forms.TableLayoutPanel();
            this.workshopPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.workshopFetchButton = new System.Windows.Forms.Button();
            this.browserPackagePanel = new System.Windows.Forms.Panel();
            this.browserPackageList = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.packageCreateFolder = new System.Windows.Forms.Button();
            this.packageSelectFolder = new System.Windows.Forms.Button();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.packageName = new System.Windows.Forms.TextBox();
            this.packageAuthors = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.packageDescription = new System.Windows.Forms.TextBox();
            this.linkLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ok = new System.Windows.Forms.Button();
            this.packageFolderSelectDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.consolePanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.consoleContainer.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.layoutPanel.SuspendLayout();
            this.optionsPanel.SuspendLayout();
            this.scriptsPage.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.installedPackagesPanel.SuspendLayout();
            this.workshopPage.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.browserPackagePanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // consolePanel
            // 
            this.consolePanel.Controls.Add(this.tableLayoutPanel3);
            this.consolePanel.Controls.Add(this.consoleContainer);
            this.consolePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consolePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consolePanel.Location = new System.Drawing.Point(5, 5);
            this.consolePanel.Margin = new System.Windows.Forms.Padding(5);
            this.consolePanel.Name = "consolePanel";
            this.consolePanel.Padding = new System.Windows.Forms.Padding(5);
            this.consolePanel.Size = new System.Drawing.Size(490, 605);
            this.consolePanel.TabIndex = 0;
            this.consolePanel.TabStop = false;
            this.consolePanel.Text = "Console";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel3.Controls.Add(this.consoleInput, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.consoleRun, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 521);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(462, 23);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // consoleInput
            // 
            this.consoleInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleInput.Location = new System.Drawing.Point(0, 0);
            this.consoleInput.Margin = new System.Windows.Forms.Padding(0);
            this.consoleInput.Name = "consoleInput";
            this.consoleInput.Size = new System.Drawing.Size(332, 23);
            this.consoleInput.TabIndex = 1;
            this.consoleInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.consoleInput_KeyDown);
            this.consoleInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.consoleInput_KeyPress);
            // 
            // consoleRun
            // 
            this.consoleRun.BackColor = System.Drawing.Color.Transparent;
            this.consoleRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleRun.Image = ((System.Drawing.Image)(resources.GetObject("consoleRun.Image")));
            this.consoleRun.Location = new System.Drawing.Point(332, 0);
            this.consoleRun.Margin = new System.Windows.Forms.Padding(0);
            this.consoleRun.Name = "consoleRun";
            this.consoleRun.Size = new System.Drawing.Size(130, 23);
            this.consoleRun.TabIndex = 2;
            this.consoleRun.Text = "Run";
            this.consoleRun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.consoleRun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.consoleRun.UseVisualStyleBackColor = true;
            this.consoleRun.Click += new System.EventHandler(this.consoleRun_Click);
            // 
            // consoleContainer
            // 
            this.consoleContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.consoleContainer.Controls.Add(this.consoleOutput);
            this.consoleContainer.Controls.Add(this.tableLayoutPanel2);
            this.consoleContainer.Location = new System.Drawing.Point(10, 23);
            this.consoleContainer.Margin = new System.Windows.Forms.Padding(5);
            this.consoleContainer.Name = "consoleContainer";
            this.consoleContainer.Size = new System.Drawing.Size(462, 488);
            this.consoleContainer.TabIndex = 3;
            // 
            // consoleOutput
            // 
            this.consoleOutput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.consoleOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleOutput.DetectUrls = false;
            this.consoleOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.consoleOutput.ForeColor = System.Drawing.Color.Black;
            this.consoleOutput.Location = new System.Drawing.Point(0, 0);
            this.consoleOutput.Margin = new System.Windows.Forms.Padding(0);
            this.consoleOutput.Name = "consoleOutput";
            this.consoleOutput.ReadOnly = true;
            this.consoleOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.consoleOutput.Size = new System.Drawing.Size(460, 453);
            this.consoleOutput.TabIndex = 0;
            this.consoleOutput.Text = "";
            this.consoleOutput.TextChanged += new System.EventHandler(this.consoleOutput_TextChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Controls.Add(this.ColorDisplay, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.consoleClearButton, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.CursorPosDisplay, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 454);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(460, 32);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // ColorDisplay
            // 
            this.ColorDisplay.AutoSize = true;
            this.ColorDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorDisplay.Location = new System.Drawing.Point(142, 0);
            this.ColorDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.ColorDisplay.Name = "ColorDisplay";
            this.ColorDisplay.Size = new System.Drawing.Size(142, 32);
            this.ColorDisplay.TabIndex = 3;
            this.ColorDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // consoleClearButton
            // 
            this.consoleClearButton.BackColor = System.Drawing.Color.Transparent;
            this.consoleClearButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consoleClearButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.consoleClearButton.ForeColor = System.Drawing.SystemColors.InfoText;
            this.consoleClearButton.Image = ((System.Drawing.Image)(resources.GetObject("consoleClearButton.Image")));
            this.consoleClearButton.Location = new System.Drawing.Point(426, 0);
            this.consoleClearButton.Margin = new System.Windows.Forms.Padding(0);
            this.consoleClearButton.Name = "consoleClearButton";
            this.consoleClearButton.Size = new System.Drawing.Size(34, 32);
            this.consoleClearButton.TabIndex = 1;
            this.consoleClearButton.UseVisualStyleBackColor = false;
            this.consoleClearButton.Click += new System.EventHandler(this.consoleClearButton_Click);
            // 
            // CursorPosDisplay
            // 
            this.CursorPosDisplay.AutoSize = true;
            this.CursorPosDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CursorPosDisplay.Location = new System.Drawing.Point(0, 0);
            this.CursorPosDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.CursorPosDisplay.Name = "CursorPosDisplay";
            this.CursorPosDisplay.Size = new System.Drawing.Size(142, 32);
            this.CursorPosDisplay.TabIndex = 2;
            this.CursorPosDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // layoutPanel
            // 
            this.layoutPanel.ColumnCount = 2;
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.layoutPanel.Controls.Add(this.consolePanel, 0, 0);
            this.layoutPanel.Controls.Add(this.optionsPanel, 1, 0);
            this.layoutPanel.Controls.Add(this.btn_ok, 1, 1);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.RowCount = 3;
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.layoutPanel.Size = new System.Drawing.Size(792, 686);
            this.layoutPanel.TabIndex = 1;
            // 
            // optionsPanel
            // 
            this.optionsPanel.Controls.Add(this.scriptsPage);
            this.optionsPanel.Controls.Add(this.workshopPage);
            this.optionsPanel.Controls.Add(this.tabPage1);
            this.optionsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.optionsPanel.Location = new System.Drawing.Point(505, 5);
            this.optionsPanel.Margin = new System.Windows.Forms.Padding(5);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.SelectedIndex = 0;
            this.optionsPanel.Size = new System.Drawing.Size(282, 605);
            this.optionsPanel.TabIndex = 1;
            this.optionsPanel.Visible = false;
            this.optionsPanel.SelectedIndexChanged += new System.EventHandler(this.optionsPanel_SelectedIndexChanged);
            // 
            // scriptsPage
            // 
            this.scriptsPage.Controls.Add(this.tableLayoutPanel5);
            this.scriptsPage.Controls.Add(this.installedPackagesPanel);
            this.scriptsPage.Location = new System.Drawing.Point(4, 24);
            this.scriptsPage.Margin = new System.Windows.Forms.Padding(0);
            this.scriptsPage.Name = "scriptsPage";
            this.scriptsPage.Padding = new System.Windows.Forms.Padding(10);
            this.scriptsPage.Size = new System.Drawing.Size(274, 577);
            this.scriptsPage.TabIndex = 0;
            this.scriptsPage.Text = "Packages";
            this.scriptsPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel5.Controls.Add(this.scriptStop, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.openPackagesFolderButton, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(8, 486);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(258, 32);
            this.tableLayoutPanel5.TabIndex = 8;
            // 
            // scriptStop
            // 
            this.scriptStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scriptStop.Image = ((System.Drawing.Image)(resources.GetObject("scriptStop.Image")));
            this.scriptStop.Location = new System.Drawing.Point(32, 0);
            this.scriptStop.Margin = new System.Windows.Forms.Padding(0);
            this.scriptStop.Name = "scriptStop";
            this.scriptStop.Size = new System.Drawing.Size(226, 32);
            this.scriptStop.TabIndex = 2;
            this.scriptStop.Text = "Stop";
            this.scriptStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.scriptStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.scriptStop, "Use \'BREAK\' button to stop script at any time.");
            this.scriptStop.UseVisualStyleBackColor = true;
            this.scriptStop.Click += new System.EventHandler(this.scriptStop_Click);
            // 
            // openPackagesFolderButton
            // 
            this.openPackagesFolderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openPackagesFolderButton.Image = ((System.Drawing.Image)(resources.GetObject("openPackagesFolderButton.Image")));
            this.openPackagesFolderButton.Location = new System.Drawing.Point(0, 0);
            this.openPackagesFolderButton.Margin = new System.Windows.Forms.Padding(0);
            this.openPackagesFolderButton.Name = "openPackagesFolderButton";
            this.openPackagesFolderButton.Size = new System.Drawing.Size(32, 32);
            this.openPackagesFolderButton.TabIndex = 0;
            this.openPackagesFolderButton.UseVisualStyleBackColor = true;
            this.openPackagesFolderButton.Click += new System.EventHandler(this.openPackagesFolderButton_Click);
            // 
            // installedPackagesPanel
            // 
            this.installedPackagesPanel.BackColor = System.Drawing.SystemColors.Control;
            this.installedPackagesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.installedPackagesPanel.Controls.Add(this.installedPackagesList);
            this.installedPackagesPanel.Location = new System.Drawing.Point(8, 8);
            this.installedPackagesPanel.Margin = new System.Windows.Forms.Padding(0);
            this.installedPackagesPanel.Name = "installedPackagesPanel";
            this.installedPackagesPanel.Size = new System.Drawing.Size(258, 472);
            this.installedPackagesPanel.TabIndex = 7;
            // 
            // installedPackagesList
            // 
            this.installedPackagesList.AutoScroll = true;
            this.installedPackagesList.BackColor = System.Drawing.Color.Transparent;
            this.installedPackagesList.ColumnCount = 1;
            this.installedPackagesList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.installedPackagesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.installedPackagesList.Location = new System.Drawing.Point(0, 0);
            this.installedPackagesList.Margin = new System.Windows.Forms.Padding(0);
            this.installedPackagesList.Name = "installedPackagesList";
            this.installedPackagesList.RowCount = 1;
            this.installedPackagesList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.installedPackagesList.Size = new System.Drawing.Size(256, 470);
            this.installedPackagesList.TabIndex = 0;
            // 
            // workshopPage
            // 
            this.workshopPage.Controls.Add(this.tableLayoutPanel6);
            this.workshopPage.Location = new System.Drawing.Point(4, 24);
            this.workshopPage.Name = "workshopPage";
            this.workshopPage.Padding = new System.Windows.Forms.Padding(5);
            this.workshopPage.Size = new System.Drawing.Size(274, 577);
            this.workshopPage.TabIndex = 1;
            this.workshopPage.Text = "Workshop";
            this.workshopPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.browserPackagePanel, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.groupBox1, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.linkLayoutPanel, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 4;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(264, 567);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.workshopFetchButton, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 274);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(258, 27);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // workshopFetchButton
            // 
            this.workshopFetchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.workshopFetchButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.workshopFetchButton.Location = new System.Drawing.Point(0, 0);
            this.workshopFetchButton.Margin = new System.Windows.Forms.Padding(0);
            this.workshopFetchButton.Name = "workshopFetchButton";
            this.workshopFetchButton.Size = new System.Drawing.Size(258, 27);
            this.workshopFetchButton.TabIndex = 2;
            this.workshopFetchButton.Text = "Fetch";
            this.workshopFetchButton.UseVisualStyleBackColor = true;
            this.workshopFetchButton.Click += new System.EventHandler(this.workshopFetchButton_Click);
            // 
            // browserPackagePanel
            // 
            this.browserPackagePanel.BackColor = System.Drawing.SystemColors.Control;
            this.browserPackagePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.browserPackagePanel.Controls.Add(this.browserPackageList);
            this.browserPackagePanel.Location = new System.Drawing.Point(5, 5);
            this.browserPackagePanel.Margin = new System.Windows.Forms.Padding(5);
            this.browserPackagePanel.Name = "browserPackagePanel";
            this.browserPackagePanel.Size = new System.Drawing.Size(254, 231);
            this.browserPackagePanel.TabIndex = 2;
            // 
            // browserPackageList
            // 
            this.browserPackageList.AutoScroll = true;
            this.browserPackageList.AutoSize = true;
            this.browserPackageList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.browserPackageList.BackColor = System.Drawing.Color.Transparent;
            this.browserPackageList.ColumnCount = 1;
            this.browserPackageList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.browserPackageList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.browserPackageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserPackageList.Location = new System.Drawing.Point(0, 0);
            this.browserPackageList.Margin = new System.Windows.Forms.Padding(0);
            this.browserPackageList.Name = "browserPackageList";
            this.browserPackageList.RowCount = 1;
            this.browserPackageList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.browserPackageList.Size = new System.Drawing.Size(252, 229);
            this.browserPackageList.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(5, 309);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(254, 253);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Package";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(10, 23);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(234, 200);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.packageCreateFolder, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.packageSelectFolder, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 168);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(234, 32);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // packageCreateFolder
            // 
            this.packageCreateFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packageCreateFolder.Enabled = false;
            this.packageCreateFolder.Location = new System.Drawing.Point(32, 0);
            this.packageCreateFolder.Margin = new System.Windows.Forms.Padding(0);
            this.packageCreateFolder.Name = "packageCreateFolder";
            this.packageCreateFolder.Size = new System.Drawing.Size(202, 32);
            this.packageCreateFolder.TabIndex = 0;
            this.packageCreateFolder.Text = "Create";
            this.packageCreateFolder.UseVisualStyleBackColor = true;
            this.packageCreateFolder.Click += new System.EventHandler(this.packageCreateFolder_Click);
            // 
            // packageSelectFolder
            // 
            this.packageSelectFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packageSelectFolder.Image = ((System.Drawing.Image)(resources.GetObject("packageSelectFolder.Image")));
            this.packageSelectFolder.Location = new System.Drawing.Point(0, 0);
            this.packageSelectFolder.Margin = new System.Windows.Forms.Padding(0);
            this.packageSelectFolder.Name = "packageSelectFolder";
            this.packageSelectFolder.Size = new System.Drawing.Size(32, 32);
            this.packageSelectFolder.TabIndex = 0;
            this.packageSelectFolder.UseVisualStyleBackColor = true;
            this.packageSelectFolder.Click += new System.EventHandler(this.packageSelectFolder_Click);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.packageName, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.packageAuthors, 1, 1);
            this.tableLayoutPanel9.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel9.Controls.Add(this.packageDescription, 1, 3);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 4;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(234, 168);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(5, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Authors:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // packageName
            // 
            this.packageName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packageName.Location = new System.Drawing.Point(85, 5);
            this.packageName.Margin = new System.Windows.Forms.Padding(5);
            this.packageName.Name = "packageName";
            this.packageName.Size = new System.Drawing.Size(144, 23);
            this.packageName.TabIndex = 2;
            // 
            // packageAuthors
            // 
            this.packageAuthors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packageAuthors.Location = new System.Drawing.Point(85, 38);
            this.packageAuthors.Margin = new System.Windows.Forms.Padding(5);
            this.packageAuthors.Name = "packageAuthors";
            this.packageAuthors.Size = new System.Drawing.Size(144, 23);
            this.packageAuthors.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(5, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 92);
            this.label4.TabIndex = 5;
            this.label4.Text = "Description:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // packageDescription
            // 
            this.packageDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packageDescription.Location = new System.Drawing.Point(85, 71);
            this.packageDescription.Margin = new System.Windows.Forms.Padding(5);
            this.packageDescription.Multiline = true;
            this.packageDescription.Name = "packageDescription";
            this.packageDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.packageDescription.Size = new System.Drawing.Size(144, 92);
            this.packageDescription.TabIndex = 7;
            // 
            // linkLayoutPanel
            // 
            this.linkLayoutPanel.AutoSize = true;
            this.linkLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.linkLayoutPanel.ColumnCount = 3;
            this.linkLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.linkLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.linkLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.linkLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.linkLayoutPanel.Location = new System.Drawing.Point(3, 244);
            this.linkLayoutPanel.Name = "linkLayoutPanel";
            this.linkLayoutPanel.RowCount = 1;
            this.linkLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.linkLayoutPanel.Size = new System.Drawing.Size(258, 24);
            this.linkLayoutPanel.TabIndex = 4;
            // 
            // btn_ok
            // 
            this.btn_ok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ok.Location = new System.Drawing.Point(503, 618);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(286, 45);
            this.btn_ok.TabIndex = 9;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // packageFolderSelectDialog
            // 
            this.packageFolderSelectDialog.RootFolder = System.Environment.SpecialFolder.Startup;
            // 
            // toolTip
            // 
            this.toolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip_Popup);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(274, 577);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Login";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Window
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(792, 686);
            this.Controls.Add(this.layoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "{name}";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Window_FormClosing);
            this.Load += new System.EventHandler(this.Window_Load);
            this.consolePanel.ResumeLayout(false);
            this.consolePanel.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.consoleContainer.ResumeLayout(false);
            this.consoleContainer.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.layoutPanel.ResumeLayout(false);
            this.optionsPanel.ResumeLayout(false);
            this.scriptsPage.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.installedPackagesPanel.ResumeLayout(false);
            this.workshopPage.ResumeLayout(false);
            this.workshopPage.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.browserPackagePanel.ResumeLayout(false);
            this.browserPackagePanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox consolePanel;
        private System.Windows.Forms.TableLayoutPanel layoutPanel;
        private RichTextBox consoleOutput;
        private TextBox consoleInput;
        private Button consoleRun;
        private Panel consoleContainer;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button consoleClearButton;
        private FolderBrowserDialog packageFolderSelectDialog;
        private ToolTip toolTip;
        private NotifyIcon notifyIcon1;
        public Label CursorPosDisplay;
        public Label ColorDisplay;
        private TabControl optionsPanel;
        private TabPage scriptsPage;
        private TableLayoutPanel tableLayoutPanel5;
        private Button scriptStop;
        private Button openPackagesFolderButton;
        private Panel installedPackagesPanel;
        private TableLayoutPanel installedPackagesList;
        private TabPage workshopPage;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private Button workshopFetchButton;
        private Panel browserPackagePanel;
        private TableLayoutPanel browserPackageList;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel8;
        private Button packageCreateFolder;
        private Button packageSelectFolder;
        private TableLayoutPanel tableLayoutPanel9;
        private Label label1;
        private Label label2;
        private TextBox packageName;
        private TextBox packageAuthors;
        private Label label4;
        private TextBox packageDescription;
        private TableLayoutPanel linkLayoutPanel;
        private Button btn_ok;
        private TabPage tabPage1;

        public RichTextBox ConsoleOutput { get => consoleOutput; set => consoleOutput = value; }
        public TextBox ConsoleInput { get => consoleInput; set => consoleInput = value; }
        public Button ConsoleRun { get => consoleRun; set => consoleRun = value; }
        public Button ScriptStop { get => scriptStop; set => scriptStop = value; }
        public Button ConsoleClearButton { get => consoleClearButton; set => consoleClearButton = value; }
        public Button WorkshopFetchButton { get => workshopFetchButton; set => workshopFetchButton = value; }
        public TableLayoutPanel InstalledPackagesList { get => installedPackagesList; set => installedPackagesList = value; }
        public TableLayoutPanel BrowserPackageList { get => browserPackageList; set => browserPackageList = value; }
        public Button PackageCreateFolder { get => packageCreateFolder; set => packageCreateFolder = value; }
        public Button PackageSelectFolder { get => packageSelectFolder; set => packageSelectFolder = value; }
        public TextBox PackageName { get => packageName; set => packageName = value; }
        public TextBox PackageAuthors { get => packageAuthors; set => packageAuthors = value; }
        public TextBox PackageDescription { get => packageDescription; set => packageDescription = value; }
        public FolderBrowserDialog PackageFolderSelectDialog { get => packageFolderSelectDialog; set => packageFolderSelectDialog = value; }
        //public Label InfoVersion { get => infoVersion; set => infoVersion = value; }
    }
}