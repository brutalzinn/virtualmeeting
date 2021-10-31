namespace VirtualMeetingMonitor.ActionsControl
{
    partial class ServiceActionControl
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
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_services;
            flowLayoutPanel_services = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel_services
            // 
            flowLayoutPanel_services.Location = new System.Drawing.Point(14, 19);
            flowLayoutPanel_services.Name = "flowLayoutPanel_services";
            flowLayoutPanel_services.Size = new System.Drawing.Size(330, 225);
            flowLayoutPanel_services.TabIndex = 0;
            // 
            // ServiceActionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(flowLayoutPanel_services);
            this.Name = "ServiceActionControl";
            this.Size = new System.Drawing.Size(359, 263);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
