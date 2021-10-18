using System.Windows.Forms;

namespace VirtualMeetingMonitor.Forms.WorshopForms
{
    partial class Prompt
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
            this.promptMessage = new System.Windows.Forms.Label();
            this.promptEntryBox = new System.Windows.Forms.TextBox();
            this.promptSubmit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // promptMessage
            // 
            this.promptMessage.AutoSize = true;
            this.promptMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.promptMessage.Location = new System.Drawing.Point(4, 3);
            this.promptMessage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.promptMessage.Name = "promptMessage";
            this.promptMessage.Size = new System.Drawing.Size(236, 15);
            this.promptMessage.TabIndex = 0;
            this.promptMessage.Text = "Message";
            this.promptMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // promptEntryBox
            // 
            this.promptEntryBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.promptEntryBox.Location = new System.Drawing.Point(4, 24);
            this.promptEntryBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.promptEntryBox.Name = "promptEntryBox";
            this.promptEntryBox.Size = new System.Drawing.Size(236, 23);
            this.promptEntryBox.TabIndex = 1;
            this.promptEntryBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.promptEntryBox_KeyPress);
            // 
            // promptSubmit
            // 
            this.promptSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.promptSubmit.Location = new System.Drawing.Point(4, 53);
            this.promptSubmit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.promptSubmit.Name = "promptSubmit";
            this.promptSubmit.Size = new System.Drawing.Size(236, 38);
            this.promptSubmit.TabIndex = 2;
            this.promptSubmit.Text = "Submit";
            this.promptSubmit.UseVisualStyleBackColor = true;
            this.promptSubmit.Click += new System.EventHandler(this.promptSubmit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.promptMessage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.promptSubmit, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.promptEntryBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(242, 94);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Prompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(250, 100);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Prompt";
            this.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Text = "ScribeBot - Prompt";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label promptMessage;
        private System.Windows.Forms.TextBox promptEntryBox;
        private Button promptSubmit;
        private TableLayoutPanel tableLayoutPanel1;

        public Label PromptMessage { get => promptMessage; set => promptMessage = value; }
        public TextBox PromptEntryBox { get => promptEntryBox; set => promptEntryBox = value; }
        public Button PromptSubmit { get => promptSubmit; set => promptSubmit = value; }
    }
}