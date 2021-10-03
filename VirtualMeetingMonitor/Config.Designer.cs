
namespace VirtualMeetingMonitor
{
    partial class Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.label_timeout = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_language = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_timeout
            // 
            this.label_timeout.AutoSize = true;
            this.label_timeout.Location = new System.Drawing.Point(12, 43);
            this.label_timeout.Name = "label_timeout";
            this.label_timeout.Size = new System.Drawing.Size(48, 13);
            this.label_timeout.TabIndex = 0;
            this.label_timeout.Text = "Timeout:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button_ok
            // 
            this.button_ok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ok.Location = new System.Drawing.Point(322, 142);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(80, 46);
            this.button_ok.TabIndex = 2;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.Location = new System.Drawing.Point(229, 142);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(87, 46);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "CANCEL";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(76, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label_language
            // 
            this.label_language.AutoSize = true;
            this.label_language.Location = new System.Drawing.Point(12, 69);
            this.label_language.Name = "label_language";
            this.label_language.Size = new System.Drawing.Size(58, 13);
            this.label_language.TabIndex = 5;
            this.label_language.Text = "Language:";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 196);
            this.Controls.Add(this.label_language);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_timeout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "{title} - Config";
            this.Load += new System.EventHandler(this.Status_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_timeout;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_language;
    }
}