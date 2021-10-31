
namespace VirtualMeetingMonitor.Forms
{
    partial class Actions
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_test = new System.Windows.Forms.TabPage();
            this.customTagsTest1 = new VirtualMeetingMonitor.ActionsControl.CustomTagsTest();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.customDataGrid1 = new VirtualMeetingMonitor.ActionsControl.CustomDataGrid();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.customDayList = new VirtualMeetingMonitor.ActionsControl.CustomDay();
            this.btn_ok = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tab_test.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_test);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(14, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(905, 373);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_test
            // 
            this.tab_test.Controls.Add(this.customTagsTest1);
            this.tab_test.Location = new System.Drawing.Point(4, 24);
            this.tab_test.Name = "tab_test";
            this.tab_test.Padding = new System.Windows.Forms.Padding(3);
            this.tab_test.Size = new System.Drawing.Size(897, 345);
            this.tab_test.TabIndex = 2;
            this.tab_test.Text = "Test";
            this.tab_test.UseVisualStyleBackColor = true;
            // 
            // customTagsTest1
            // 
            this.customTagsTest1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customTagsTest1.Location = new System.Drawing.Point(3, 3);
            this.customTagsTest1.Name = "customTagsTest1";
            this.customTagsTest1.Size = new System.Drawing.Size(891, 339);
            this.customTagsTest1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.customDataGrid1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(897, 345);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cells";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // customDataGrid1
            // 
            this.customDataGrid1.ColumnCount = 0;
            this.customDataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customDataGrid1.Location = new System.Drawing.Point(4, 3);
            this.customDataGrid1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customDataGrid1.Name = "customDataGrid1";
            this.customDataGrid1.Size = new System.Drawing.Size(889, 339);
            this.customDataGrid1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.customDayList);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(897, 345);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Custom Days";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // customDayList
            // 
            this.customDayList.DaysMessage = null;
            this.customDayList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customDayList.Location = new System.Drawing.Point(4, 3);
            this.customDayList.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.customDayList.Name = "customDayList";
            this.customDayList.NoDaysMessage = null;
            this.customDayList.Size = new System.Drawing.Size(889, 339);
            this.customDayList.TabIndex = 0;
            this.customDayList.Load += new System.EventHandler(this.customDayList_Load);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(782, 393);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(133, 53);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(897, 345);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Services";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Actions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 460);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Actions";
            this.Text = "Actions";
            this.Load += new System.EventHandler(this.Actions_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_test.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TabPage tabPage1;
        private ActionsControl.CustomDay customDayList;
        private System.Windows.Forms.TabPage tabPage2;
        private ActionsControl.CustomDataGrid customDataGrid1;
        private System.Windows.Forms.TabPage tab_test;
        private ActionsControl.CustomTagsTest customTagsTest1;
        private System.Windows.Forms.TabPage tabPage3;
    }
}