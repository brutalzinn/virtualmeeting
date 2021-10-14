
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
            this.label_sheets_id = new System.Windows.Forms.Label();
            this.textbox_googleSheetsID = new System.Windows.Forms.TextBox();
            this.button_paste_googlesheets = new System.Windows.Forms.Button();
            this.textbox_sheetname = new System.Windows.Forms.TextBox();
            this.label_sheetname = new System.Windows.Forms.Label();
            this.label_link_howto = new System.Windows.Forms.LinkLabel();
            this.textBoxCustomTimer = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxProfile = new System.Windows.Forms.ComboBox();
            this.label_profile = new System.Windows.Forms.Label();
            this.label_profile_name = new System.Windows.Forms.Label();
            this.ADD = new System.Windows.Forms.Button();
            this.DEL = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.btn_config_action = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_timeout
            // 
            this.label_timeout.AutoSize = true;
            this.label_timeout.Location = new System.Drawing.Point(24, 80);
            this.label_timeout.Name = "label_timeout";
            this.label_timeout.Size = new System.Drawing.Size(48, 13);
            this.label_timeout.TabIndex = 0;
            this.label_timeout.Text = "Timeout:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button_ok
            // 
            this.button_ok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ok.Location = new System.Drawing.Point(322, 298);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(84, 46);
            this.button_ok.TabIndex = 2;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.Location = new System.Drawing.Point(229, 298);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(91, 46);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "CANCEL";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(87, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label_language
            // 
            this.label_language.AutoSize = true;
            this.label_language.Location = new System.Drawing.Point(24, 106);
            this.label_language.Name = "label_language";
            this.label_language.Size = new System.Drawing.Size(58, 13);
            this.label_language.TabIndex = 5;
            this.label_language.Text = "Language:";
            // 
            // label_sheets_id
            // 
            this.label_sheets_id.AutoSize = true;
            this.label_sheets_id.Location = new System.Drawing.Point(24, 133);
            this.label_sheets_id.Name = "label_sheets_id";
            this.label_sheets_id.Size = new System.Drawing.Size(57, 13);
            this.label_sheets_id.TabIndex = 6;
            this.label_sheets_id.Text = "Sheets ID:";
            // 
            // textbox_googleSheetsID
            // 
            this.textbox_googleSheetsID.Location = new System.Drawing.Point(87, 130);
            this.textbox_googleSheetsID.Name = "textbox_googleSheetsID";
            this.textbox_googleSheetsID.Size = new System.Drawing.Size(218, 20);
            this.textbox_googleSheetsID.TabIndex = 7;
            // 
            // button_paste_googlesheets
            // 
            this.button_paste_googlesheets.AutoSize = true;
            this.button_paste_googlesheets.Location = new System.Drawing.Point(311, 124);
            this.button_paste_googlesheets.Name = "button_paste_googlesheets";
            this.button_paste_googlesheets.Size = new System.Drawing.Size(74, 30);
            this.button_paste_googlesheets.TabIndex = 8;
            this.button_paste_googlesheets.Text = "PASTE";
            this.button_paste_googlesheets.UseVisualStyleBackColor = true;
            this.button_paste_googlesheets.Click += new System.EventHandler(this.button_paste_googlesheets_Click);
            // 
            // textbox_sheetname
            // 
            this.textbox_sheetname.Location = new System.Drawing.Point(105, 156);
            this.textbox_sheetname.Name = "textbox_sheetname";
            this.textbox_sheetname.Size = new System.Drawing.Size(200, 20);
            this.textbox_sheetname.TabIndex = 9;
            // 
            // label_sheetname
            // 
            this.label_sheetname.AutoSize = true;
            this.label_sheetname.Location = new System.Drawing.Point(25, 159);
            this.label_sheetname.Name = "label_sheetname";
            this.label_sheetname.Size = new System.Drawing.Size(74, 13);
            this.label_sheetname.TabIndex = 10;
            this.label_sheetname.Text = "Sheets Name:";
            // 
            // label_link_howto
            // 
            this.label_link_howto.AutoSize = true;
            this.label_link_howto.Location = new System.Drawing.Point(25, 190);
            this.label_link_howto.Name = "label_link_howto";
            this.label_link_howto.Size = new System.Drawing.Size(157, 13);
            this.label_link_howto.TabIndex = 11;
            this.label_link_howto.TabStop = true;
            this.label_link_howto.Text = "How to configure google sheets";
            this.label_link_howto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label_link_howto_LinkClicked);
            // 
            // textBoxCustomTimer
            // 
            this.textBoxCustomTimer.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.textBoxCustomTimer.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.textBoxCustomTimer.Location = new System.Drawing.Point(111, 229);
            this.textBoxCustomTimer.Name = "textBoxCustomTimer";
            this.textBoxCustomTimer.ShowUpDown = true;
            this.textBoxCustomTimer.Size = new System.Drawing.Size(78, 20);
            this.textBoxCustomTimer.TabIndex = 13;
            this.textBoxCustomTimer.Value = new System.DateTime(2021, 10, 5, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Custom time:";
            // 
            // cbxProfile
            // 
            this.cbxProfile.FormattingEnabled = true;
            this.cbxProfile.Location = new System.Drawing.Point(78, 49);
            this.cbxProfile.Name = "cbxProfile";
            this.cbxProfile.Size = new System.Drawing.Size(182, 21);
            this.cbxProfile.TabIndex = 15;
            this.cbxProfile.SelectedIndexChanged += new System.EventHandler(this.cbxProfile_SelectedIndexChanged);
            // 
            // label_profile
            // 
            this.label_profile.AutoSize = true;
            this.label_profile.Location = new System.Drawing.Point(25, 52);
            this.label_profile.Name = "label_profile";
            this.label_profile.Size = new System.Drawing.Size(39, 13);
            this.label_profile.TabIndex = 16;
            this.label_profile.Text = "Profile:";
            // 
            // label_profile_name
            // 
            this.label_profile_name.AutoSize = true;
            this.label_profile_name.Location = new System.Drawing.Point(26, 23);
            this.label_profile_name.Name = "label_profile_name";
            this.label_profile_name.Size = new System.Drawing.Size(73, 13);
            this.label_profile_name.TabIndex = 17;
            this.label_profile_name.Text = "Profile:{name}";
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(266, 46);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(33, 25);
            this.ADD.TabIndex = 18;
            this.ADD.Text = "+";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // DEL
            // 
            this.DEL.Location = new System.Drawing.Point(369, 45);
            this.DEL.Name = "DEL";
            this.DEL.Size = new System.Drawing.Size(33, 25);
            this.DEL.TabIndex = 19;
            this.DEL.Text = "-";
            this.DEL.UseVisualStyleBackColor = true;
            this.DEL.Click += new System.EventHandler(this.DEL_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 22);
            this.button1.TabIndex = 20;
            this.button1.Text = "Rename";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.Location = new System.Drawing.Point(29, 255);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(106, 32);
            this.btnSaveProfile.TabIndex = 21;
            this.btnSaveProfile.Text = "SAVE PROFILE";
            this.btnSaveProfile.UseVisualStyleBackColor = true;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // btn_config_action
            // 
            this.btn_config_action.Location = new System.Drawing.Point(307, 180);
            this.btn_config_action.Name = "btn_config_action";
            this.btn_config_action.Size = new System.Drawing.Size(95, 32);
            this.btn_config_action.TabIndex = 22;
            this.btn_config_action.Text = "Config actions";
            this.btn_config_action.UseVisualStyleBackColor = true;
            this.btn_config_action.Click += new System.EventHandler(this.btn_config_action_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 352);
            this.Controls.Add(this.btn_config_action);
            this.Controls.Add(this.btnSaveProfile);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DEL);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.label_profile_name);
            this.Controls.Add(this.label_profile);
            this.Controls.Add(this.cbxProfile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCustomTimer);
            this.Controls.Add(this.label_link_howto);
            this.Controls.Add(this.label_sheetname);
            this.Controls.Add(this.textbox_sheetname);
            this.Controls.Add(this.button_paste_googlesheets);
            this.Controls.Add(this.textbox_googleSheetsID);
            this.Controls.Add(this.label_sheets_id);
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
        private System.Windows.Forms.Label label_sheets_id;
        private System.Windows.Forms.TextBox textbox_googleSheetsID;
        private System.Windows.Forms.Button button_paste_googlesheets;
        private System.Windows.Forms.TextBox textbox_sheetname;
        private System.Windows.Forms.Label label_sheetname;
        private System.Windows.Forms.LinkLabel label_link_howto;
        private System.Windows.Forms.DateTimePicker textBoxCustomTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxProfile;
        private System.Windows.Forms.Label label_profile;
        private System.Windows.Forms.Label label_profile_name;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.Button DEL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.Button btn_config_action;
    }
}