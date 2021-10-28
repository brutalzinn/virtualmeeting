namespace VirtualMeetingMonitor.Forms.WorkshopForms.Package
{
    partial class PackageManageForm
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
            this.lbl_package_info = new System.Windows.Forms.Label();
            this.pluginManager1 = new VirtualMeetingMonitor.Forms.WorshopForms.UserControllers.PluginManager();
            this.SuspendLayout();
            // 
            // lbl_package_info
            // 
            this.lbl_package_info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_package_info.AutoSize = true;
            this.lbl_package_info.Location = new System.Drawing.Point(134, 9);
            this.lbl_package_info.Name = "lbl_package_info";
            this.lbl_package_info.Size = new System.Drawing.Size(38, 15);
            this.lbl_package_info.TabIndex = 0;
            this.lbl_package_info.Text = "label1";
            // 
            // pluginManager1
            // 
            this.pluginManager1.AutoSize = true;
            this.pluginManager1.Location = new System.Drawing.Point(-2, 45);
            this.pluginManager1.Name = "pluginManager1";
            this.pluginManager1.Size = new System.Drawing.Size(326, 404);
            this.pluginManager1.TabIndex = 1;
            this.pluginManager1.Load += new System.EventHandler(this.pluginManager1_Load_1);
            // 
            // PackageManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 461);
            this.Controls.Add(this.pluginManager1);
            this.Controls.Add(this.lbl_package_info);
            this.Name = "PackageManageForm";
            this.Text = "PackageMangeForm - Edit";
            this.Load += new System.EventHandler(this.PackageManageForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_package_info;
        private WorshopForms.UserControllers.PluginManager pluginManager1;
    }
}