
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
            this.chk_devmode = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label_timeout
            // 
            this.label_timeout.AutoSize = true;
            this.label_timeout.Location = new System.Drawing.Point(28, 92);
            this.label_timeout.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_timeout.Name = "label_timeout";
            this.label_timeout.Size = new System.Drawing.Size(54, 15);
            this.label_timeout.TabIndex = 0;
            this.label_timeout.Text = "Timeout:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 89);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(377, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // button_ok
            // 
            this.button_ok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ok.Location = new System.Drawing.Point(374, 230);
            this.button_ok.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(98, 53);
            this.button_ok.TabIndex = 2;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_cancel.Location = new System.Drawing.Point(260, 230);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(106, 53);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "CANCEL";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(102, 119);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // label_language
            // 
            this.label_language.AutoSize = true;
            this.label_language.Location = new System.Drawing.Point(28, 122);
            this.label_language.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_language.Name = "label_language";
            this.label_language.Size = new System.Drawing.Size(62, 15);
            this.label_language.TabIndex = 5;
            this.label_language.Text = "Language:";
            // 
            // textBoxCustomTimer
            // 
            this.textBoxCustomTimer.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.textBoxCustomTimer.ImeMode = System.Windows.Forms.ImeMode.AlphaFull;
            this.textBoxCustomTimer.Location = new System.Drawing.Point(116, 226);
            this.textBoxCustomTimer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCustomTimer.Name = "textBoxCustomTimer";
            this.textBoxCustomTimer.ShowUpDown = true;
            this.textBoxCustomTimer.Size = new System.Drawing.Size(90, 23);
            this.textBoxCustomTimer.TabIndex = 13;
            this.textBoxCustomTimer.Value = new System.DateTime(2021, 10, 5, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 230);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Custom time:";
            // 
            // cbxProfile
            // 
            this.cbxProfile.FormattingEnabled = true;
            this.cbxProfile.Location = new System.Drawing.Point(91, 57);
            this.cbxProfile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxProfile.Name = "cbxProfile";
            this.cbxProfile.Size = new System.Drawing.Size(212, 23);
            this.cbxProfile.TabIndex = 15;
            this.cbxProfile.SelectedIndexChanged += new System.EventHandler(this.cbxProfile_SelectedIndexChanged);
            // 
            // label_profile
            // 
            this.label_profile.AutoSize = true;
            this.label_profile.Location = new System.Drawing.Point(29, 60);
            this.label_profile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_profile.Name = "label_profile";
            this.label_profile.Size = new System.Drawing.Size(44, 15);
            this.label_profile.TabIndex = 16;
            this.label_profile.Text = "Profile:";
            // 
            // label_profile_name
            // 
            this.label_profile_name.AutoSize = true;
            this.label_profile_name.Location = new System.Drawing.Point(30, 27);
            this.label_profile_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_profile_name.Name = "label_profile_name";
            this.label_profile_name.Size = new System.Drawing.Size(82, 15);
            this.label_profile_name.TabIndex = 17;
            this.label_profile_name.Text = "Profile:{name}";
            // 
            // ADD
            // 
            this.ADD.Location = new System.Drawing.Point(310, 53);
            this.ADD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(38, 29);
            this.ADD.TabIndex = 18;
            this.ADD.Text = "+";
            this.ADD.UseVisualStyleBackColor = true;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // DEL
            // 
            this.DEL.Location = new System.Drawing.Point(430, 52);
            this.DEL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DEL.Name = "DEL";
            this.DEL.Size = new System.Drawing.Size(38, 29);
            this.DEL.TabIndex = 19;
            this.DEL.Text = "-";
            this.DEL.UseVisualStyleBackColor = true;
            this.DEL.Click += new System.EventHandler(this.DEL_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 55);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 25);
            this.button1.TabIndex = 20;
            this.button1.Text = "Rename";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.Location = new System.Drawing.Point(20, 256);
            this.btnSaveProfile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(124, 37);
            this.btnSaveProfile.TabIndex = 21;
            this.btnSaveProfile.Text = "SAVE PROFILE";
            this.btnSaveProfile.UseVisualStyleBackColor = true;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // btn_config_action
            // 
            this.btn_config_action.Location = new System.Drawing.Point(350, 162);
            this.btn_config_action.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_config_action.Name = "btn_config_action";
            this.btn_config_action.Size = new System.Drawing.Size(111, 37);
            this.btn_config_action.TabIndex = 22;
            this.btn_config_action.Text = "Config actions";
            this.btn_config_action.UseVisualStyleBackColor = true;
            this.btn_config_action.Click += new System.EventHandler(this.btn_config_action_Click);
            // 
            // chk_devmode
            // 
            this.chk_devmode.AutoSize = true;
            this.chk_devmode.Location = new System.Drawing.Point(24, 180);
            this.chk_devmode.Name = "chk_devmode";
            this.chk_devmode.Size = new System.Drawing.Size(113, 19);
            this.chk_devmode.TabIndex = 23;
            this.chk_devmode.Text = "Developer mode";
            this.chk_devmode.UseVisualStyleBackColor = true;
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 318);
            this.Controls.Add(this.chk_devmode);
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
            this.Controls.Add(this.label_language);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_timeout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
        private System.Windows.Forms.CheckBox chk_devmode;
    }
}