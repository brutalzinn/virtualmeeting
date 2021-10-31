namespace VirtualMeetingMonitor.ActionsControl.Services
{
    partial class ServiceMinimal
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
            this.ckb_service_enabled = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ckb_service_enabled
            // 
            this.ckb_service_enabled.AutoSize = true;
            this.ckb_service_enabled.Location = new System.Drawing.Point(26, 9);
            this.ckb_service_enabled.Name = "ckb_service_enabled";
            this.ckb_service_enabled.Size = new System.Drawing.Size(83, 19);
            this.ckb_service_enabled.TabIndex = 0;
            this.ckb_service_enabled.Text = "checkBox1";
            this.ckb_service_enabled.UseVisualStyleBackColor = true;
            // 
            // ServiceMinimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ckb_service_enabled);
            this.Name = "ServiceMinimal";
            this.Size = new System.Drawing.Size(143, 40);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox ckb_service_enabled;
    }
}
