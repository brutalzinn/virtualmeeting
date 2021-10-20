namespace VirtualMeetingMonitor.Forms.WorkshopForms.UserControllers
{
    partial class PluginUser
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
            this.browserPackageList = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // browserPackageList
            // 
            this.browserPackageList.ColumnCount = 1;
            this.browserPackageList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.browserPackageList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.browserPackageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browserPackageList.Location = new System.Drawing.Point(0, 0);
            this.browserPackageList.Name = "browserPackageList";
            this.browserPackageList.RowCount = 1;
            this.browserPackageList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.browserPackageList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.browserPackageList.Size = new System.Drawing.Size(262, 479);
            this.browserPackageList.TabIndex = 0;
            // 
            // PluginUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.browserPackageList);
            this.Name = "PluginUser";
            this.Size = new System.Drawing.Size(262, 479);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel browserPackageList;
    }
}
