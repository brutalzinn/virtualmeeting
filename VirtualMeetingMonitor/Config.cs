using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualMeetingMonitor
{
    public partial class Config : System.Windows.Forms.Form
    {

        public Config()
        {
            InitializeComponent();
            this.Text = Globals.getAppName(Globals.getKey("form_config_text"));
            Translate();
            textbox_googleSheetsID.Text = Properties.Settings.Default.googlesheetsID;
            textBox1.Text = Properties.Settings.Default.timeout.ToString();
            textBoxCustomTimer.Text = Properties.Settings.Default.customtimer;
            textbox_sheetname.Text = Properties.Settings.Default.sheetName;
        }

        private void Status_Load(object sender, EventArgs e)
        {
            if (Globals.languages.Count > 0)
            {
                foreach (Language _lang in Globals.languages)
                {
                    _lang.readLanguage();
                    comboBox1.Items.Add(_lang);
                }
             
            }
            if (Globals.CurrentLanguage != null)
            {
                comboBox1.SelectedIndex = comboBox1.FindStringExact(Globals.CurrentLanguage.ToString());
            }



        }
       private void Translate()
        {
            label_timeout.Text = Globals.getKey("form_config_label_timeout");
            label_language.Text = Globals.getKey("form_config_label_language");
            label_sheetname.Text = Globals.getKey("form_config_sheets_name");
            label_sheets_id.Text = Globals.getKey("form_config_sheets_id");
            button_paste_googlesheets.Text = Globals.getKey("form_config_paste_button");
            label_link_howto.Text = Globals.getKey("form_config_how_to_link");


            button_ok.Text = Globals.getKey("button_ok");
            button_cancel.Text = Globals.getKey("button_cancel");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            Globals.CurrentLanguage = (Language)comboBox1.SelectedItem;
            Globals.CurrentLanguage.LanguageChanged += Globals.form.LanguageChangedEvent;
            Globals.CurrentLanguage.readLanguage();
            Globals.CurrentLanguage.updateLanguage();
            Properties.Settings.Default.language = Globals.CurrentLanguage.getFileName();
            Properties.Settings.Default.timeout = Convert.ToInt32(textBox1.Text);
            Properties.Settings.Default.googlesheetsID = textbox_googleSheetsID.Text;
            Properties.Settings.Default.sheetName = textbox_sheetname.Text;
            Properties.Settings.Default.customtimer = textBoxCustomTimer.Text;
            Properties.Settings.Default.Save();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            string google_sheets_url = Clipboard.GetText();
         

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
    }
}
