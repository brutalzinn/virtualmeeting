namespace PluginServiceExample.Views
{
    partial class ServiceView
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label_sheetname = new System.Windows.Forms.Label();
            this.textbox_sheetname = new System.Windows.Forms.TextBox();
            this.button_paste_googlesheets = new System.Windows.Forms.Button();
            this.textbox_googleSheetsID = new System.Windows.Forms.TextBox();
            this.label_sheets_id = new System.Windows.Forms.Label();
            this.label_link_howto = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 88);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label_sheetname
            // 
            this.label_sheetname.AutoSize = true;
            this.label_sheetname.Location = new System.Drawing.Point(14, 53);
            this.label_sheetname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_sheetname.Name = "label_sheetname";
            this.label_sheetname.Size = new System.Drawing.Size(79, 15);
            this.label_sheetname.TabIndex = 15;
            this.label_sheetname.Text = "Sheets Name:";
            // 
            // textbox_sheetname
            // 
            this.textbox_sheetname.Location = new System.Drawing.Point(107, 50);
            this.textbox_sheetname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox_sheetname.Name = "textbox_sheetname";
            this.textbox_sheetname.Size = new System.Drawing.Size(233, 23);
            this.textbox_sheetname.TabIndex = 14;
            this.textbox_sheetname.TextChanged += new System.EventHandler(this.textbox_sheetname_TextChanged);
            // 
            // button_paste_googlesheets
            // 
            this.button_paste_googlesheets.AutoSize = true;
            this.button_paste_googlesheets.Location = new System.Drawing.Point(348, 13);
            this.button_paste_googlesheets.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_paste_googlesheets.Name = "button_paste_googlesheets";
            this.button_paste_googlesheets.Size = new System.Drawing.Size(86, 35);
            this.button_paste_googlesheets.TabIndex = 13;
            this.button_paste_googlesheets.Text = "PASTE";
            this.button_paste_googlesheets.UseVisualStyleBackColor = true;
            this.button_paste_googlesheets.Click += new System.EventHandler(this.button_paste_googlesheets_Click);
            // 
            // textbox_googleSheetsID
            // 
            this.textbox_googleSheetsID.Location = new System.Drawing.Point(87, 20);
            this.textbox_googleSheetsID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox_googleSheetsID.Name = "textbox_googleSheetsID";
            this.textbox_googleSheetsID.Size = new System.Drawing.Size(254, 23);
            this.textbox_googleSheetsID.TabIndex = 12;
            this.textbox_googleSheetsID.TextChanged += new System.EventHandler(this.textbox_sheetname_TextChanged);
            // 
            // label_sheets_id
            // 
            this.label_sheets_id.AutoSize = true;
            this.label_sheets_id.Location = new System.Drawing.Point(13, 23);
            this.label_sheets_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_sheets_id.Name = "label_sheets_id";
            this.label_sheets_id.Size = new System.Drawing.Size(58, 15);
            this.label_sheets_id.TabIndex = 11;
            this.label_sheets_id.Text = "Sheets ID:";
            // 
            // label_link_howto
            // 
            this.label_link_howto.AutoSize = true;
            this.label_link_howto.Location = new System.Drawing.Point(14, 121);
            this.label_link_howto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_link_howto.Name = "label_link_howto";
            this.label_link_howto.Size = new System.Drawing.Size(176, 15);
            this.label_link_howto.TabIndex = 16;
            this.label_link_howto.TabStop = true;
            this.label_link_howto.Text = "How to configure google sheets";
            // 
            // ServiceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_link_howto);
            this.Controls.Add(this.label_sheetname);
            this.Controls.Add(this.textbox_sheetname);
            this.Controls.Add(this.button_paste_googlesheets);
            this.Controls.Add(this.textbox_googleSheetsID);
            this.Controls.Add(this.label_sheets_id);
            this.Controls.Add(this.checkBox1);
            this.Name = "ServiceView";
            this.Size = new System.Drawing.Size(447, 151);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label_sheetname;
        private System.Windows.Forms.TextBox textbox_sheetname;
        private System.Windows.Forms.Button button_paste_googlesheets;
        private System.Windows.Forms.TextBox textbox_googleSheetsID;
        private System.Windows.Forms.Label label_sheets_id;
        private System.Windows.Forms.LinkLabel label_link_howto;
    }
}
