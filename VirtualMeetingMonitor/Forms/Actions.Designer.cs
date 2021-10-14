
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
            this.btn_ok = new System.Windows.Forms.Button();
            this.customDayList = new VirtualMeetingMonitor.ActionsControl.CustomDay();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 323);
            this.tabControl1.TabIndex = 0;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(670, 341);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(114, 46);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // customDayList
            // 
            this.customDayList.DaysMessage = null;
            this.customDayList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customDayList.Location = new System.Drawing.Point(3, 3);
            this.customDayList.Name = "customDayList";
            this.customDayList.NoDaysMessage = null;
            this.customDayList.Size = new System.Drawing.Size(762, 291);
            this.customDayList.TabIndex = 0;
            this.customDayList.Load += new System.EventHandler(this.customDayList_Load);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.customDayList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 297);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Custom Days";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Actions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 399);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tabControl1);
            this.Name = "Actions";
            this.Text = "Actions";
            this.Load += new System.EventHandler(this.Actions_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TabPage tabPage1;
        private ActionsControl.CustomDay customDayList;
    }
}