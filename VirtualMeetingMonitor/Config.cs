using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualMeetingMonitor.Forms;
using VirtualMeetingMonitor.profile;

namespace VirtualMeetingMonitor
{
    public partial class Config : System.Windows.Forms.Form
    {

        public Config()
        {
            InitializeComponent();
            this.Text = Globals.getAppName(Globals.getKey("form_config_text"));
            Translate();
            //textbox_googleSheetsID.Text = Properties.Settings.Default.googlesheetsID;
            //textBox1.Text = Properties.Settings.Default.timeout.ToString();
            //textBoxCustomTimer.Text = Properties.Settings.Default.customtimer;
            //textbox_sheetname.Text = Properties.Settings.Default.sheetName;
        }

        private void LoadProfilesCbx()
        {
            cbxProfile.Items.Clear();
            foreach (Profile _profile in Globals.ProfileUtil.profiles)
            {
                cbxProfile.Items.Add(_profile);
            }
        }
        private void Status_Load(object sender, EventArgs e)
        {
            LoadProfilesCbx();

            if (Globals.languages.Count > 0)
            {
                foreach (Language _lang in Globals.languages)
                {
                    _lang.readLanguage();
                    comboBox1.Items.Add(_lang);
                }
             
            }
            //if (Globals.CurrentLanguage != null)
            //{
            //    comboBox1.SelectedIndex = comboBox1.FindStringExact(Globals.CurrentLanguage.ToString());
            //}

            ChangeProfile(Globals.ProfileUtil.CurrentProfile);



        }
        private void Translate()
        {
            label_profile.Text = Globals.getKey("form_config_label_profile");
            label_timeout.Text = Globals.getKey("form_config_label_timeout");
            label_language.Text = Globals.getKey("form_config_label_language");
            label_sheetname.Text = Globals.getKey("form_config_sheets_name");
            label_sheets_id.Text = Globals.getKey("form_config_sheets_id");
            button_paste_googlesheets.Text = Globals.getKey("form_config_paste_button");
            label_link_howto.Text = Globals.getKey("form_config_how_to_link");
            btnSaveProfile.Text = Globals.getKey("form_config_button_save_profile");
            button_ok.Text = Globals.getKey("button_ok");
            button_cancel.Text = Globals.getKey("button_cancel");
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Globals.CurrentLanguage = (Language)comboBox1.SelectedItem;
            Globals.CurrentLanguage.LanguageChanged += Globals.form.LanguageChangedEvent;
            //Globals.CurrentLanguage.readLanguage();
            //Globals.CurrentLanguage.updateLanguage();
            //Properties.Settings.Default.language = Globals.CurrentLanguage.getFileName();
            //Properties.Settings.Default.timeout = Convert.ToInt32(textBox1.Text);
            //Properties.Settings.Default.googlesheetsID = textbox_googleSheetsID.Text;
            //Properties.Settings.Default.sheetName = textbox_sheetname.Text;
            //Properties.Settings.Default.customtimer = textBoxCustomTimer.Text;
            //Properties.Settings.Default.Save();
            string path = Application.StartupPath + @"\config.json";
            Globals.ProfileUtil.CurrentProfile = (Profile)cbxProfile.SelectedItem;
            
            Globals.ProfileUtil.CurrentProfile.Language = Globals.CurrentLanguage.getFileName();
            Globals.ProfileUtil.CurrentProfile.Timeout = Convert.ToInt32(textBox1.Text);
            Globals.ProfileUtil.CurrentProfile.GoogleKey = textbox_googleSheetsID.Text;
            Globals.ProfileUtil.CurrentProfile.SheetId = textbox_sheetname.Text;
            Globals.ProfileUtil.CurrentProfile.CustomTime = textBoxCustomTimer.Text;
            Globals.ProfileUtil.CallUpdateProfile();
            string output = JsonConvert.SerializeObject(Globals.ProfileUtil, Formatting.Indented);
            File.WriteAllText(path, output);
            this.Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void button_paste_googlesheets_Click(object sender, EventArgs e)
        {
            string google_sheets_url = Clipboard.GetText();
            Array googleUrlArray = google_sheets_url.Split('/');
            if (googleUrlArray.Length >= 2)
            {
                string googleSheetsID = google_sheets_url.Split('/')[googleUrlArray.Length - 2];
                textbox_googleSheetsID.Text = googleSheetsID;
            }
        }
        private void SaveProfile(Profile _profile)
        {
            _profile.GoogleKey = textbox_googleSheetsID.Text;
           _profile.Timeout = Convert.ToInt32(textBox1.Text);
            _profile.CustomTime = textBoxCustomTimer.Text;
             _profile.SheetId = textbox_sheetname.Text;
            if (comboBox1.SelectedItem != null)
            {
                Language _lang = (Language)comboBox1.SelectedItem;
                _profile.Language = _lang.getFileName();
            }
        }
        private void ChangeProfile(Profile _profile)
        {
            label_profile_name.Text = $"{Globals.getKey("form_config_label_profile")} {_profile}";
       //     Globals.CurrentLanguage = (Language)comboBox1.SelectedItem;
            cbxProfile.SelectedIndex = cbxProfile.FindStringExact(_profile.Name);

            textbox_googleSheetsID.Text = _profile.GoogleKey;
            textBox1.Text = _profile.Timeout.ToString();
            textBoxCustomTimer.Text = _profile.CustomTime ;
            textbox_sheetname.Text = _profile.SheetId ;
           comboBox1.SelectedIndex = comboBox1.FindStringExact(Globals.languages.Find((lang) => lang.getFileName() == _profile.Language).ToString());
        }
        private void cbxProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
      //     SaveProfile((Profile)cbxProfile.SelectedItem);
            ChangeProfile((Profile)cbxProfile.SelectedItem);
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            Profile _default = new Profile("default " + cbxProfile.Items.Count, "", "", "", 0, "English");
            Globals.ProfileUtil.profiles.Add(_default);
            LoadProfilesCbx();


        }

        private void DEL_Click(object sender, EventArgs e)
        {
            if (Globals.ProfileUtil.profiles.Count > 1)
            {
                Profile _cbxProfile = (Profile)cbxProfile.SelectedItem;
                Globals.ProfileUtil.profiles.RemoveAll((prof) => prof.UniqueId == _cbxProfile.UniqueId);
                LoadProfilesCbx();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Profile _cbxProfile = (Profile)cbxProfile.SelectedItem;

            TextDialog _textDialog = new TextDialog();
            _textDialog.textField = _cbxProfile.Name;
            _textDialog.ShowDialog();
            if(_textDialog.DialogResult == DialogResult.OK)
            {
                Globals.ProfileUtil.profiles.First((prof) => prof.UniqueId == _cbxProfile.UniqueId).Name = _textDialog.textField;
                LoadProfilesCbx();
            }
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            Profile _currentProfile = (Profile)cbxProfile.SelectedItem;

            SaveProfile(_currentProfile);
        }

        private void label_link_howto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Globals.showHelper("https://raw.githubusercontent.com/wiki/brutalzinn/zoom-monitor-googlesheets/How-to-connect-to-google-sheets-api.md");

        }
    }
}
