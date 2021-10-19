namespace VirtualMeetingMonitor.Forms.WorshopForms.UserControllers
{
    partial class PluginManager
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_pluginInfo = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_pluginInfo
            // 
            this.lbl_pluginInfo.AutoSize = true;
            this.lbl_pluginInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_pluginInfo.Location = new System.Drawing.Point(0, 0);
            this.lbl_pluginInfo.Name = "lbl_pluginInfo";
            this.lbl_pluginInfo.Size = new System.Drawing.Size(38, 15);
            this.lbl_pluginInfo.TabIndex = 1;
            this.lbl_pluginInfo.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(71, 182);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Upload";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PluginManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbl_pluginInfo);
            this.Controls.Add(this.button1);
            this.Name = "PluginManager";
            this.Size = new System.Drawing.Size(316, 236);
            this.Load += new System.EventHandler(this.PluginManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label lbl_pluginInfo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}
