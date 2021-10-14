
namespace VirtualMeetingMonitor.ActionsControl
{
    partial class CustomDay
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.rich_custom_days = new System.Windows.Forms.RichTextBox();
            this.rich_normal_days = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Segunda",
            "Terça",
            "Quarta",
            "Quinta",
            "Sexta",
            "Sábado",
            "Domingo"});
            this.checkedListBox1.Location = new System.Drawing.Point(304, 77);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(163, 109);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // rich_custom_days
            // 
            this.rich_custom_days.Location = new System.Drawing.Point(55, 168);
            this.rich_custom_days.Name = "rich_custom_days";
            this.rich_custom_days.Size = new System.Drawing.Size(188, 53);
            this.rich_custom_days.TabIndex = 1;
            this.rich_custom_days.Text = "";
            this.rich_custom_days.TextChanged += new System.EventHandler(this.rich_custom_days_TextChanged);
            // 
            // rich_normal_days
            // 
            this.rich_normal_days.Location = new System.Drawing.Point(55, 77);
            this.rich_normal_days.Name = "rich_normal_days";
            this.rich_normal_days.Size = new System.Drawing.Size(188, 45);
            this.rich_normal_days.TabIndex = 2;
            this.rich_normal_days.Text = "";
            this.rich_normal_days.TextChanged += new System.EventHandler(this.rich_normal_days_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Unchecked Days";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Days checkeds";
            // 
            // CustomDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rich_normal_days);
            this.Controls.Add(this.rich_custom_days);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "CustomDay";
            this.Size = new System.Drawing.Size(500, 272);
            this.Load += new System.EventHandler(this.CustomDay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckedListBox checkedListBox1;
        public System.Windows.Forms.RichTextBox rich_custom_days;
        public System.Windows.Forms.RichTextBox rich_normal_days;
    }
}
