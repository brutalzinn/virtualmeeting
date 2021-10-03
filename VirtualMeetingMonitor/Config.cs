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
            textBox1.Text = Properties.Settings.Default.timeout.ToString();
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
       
        private void button1_Click(object sender, EventArgs e)
        {
          
            Globals.CurrentLanguage = (Language)comboBox1.SelectedItem;
            Globals.CurrentLanguage.LanguageChanged += Globals.form.LanguageChangedEvent;
            Globals.CurrentLanguage.readLanguage();
            Globals.CurrentLanguage.updateLanguage();
            Properties.Settings.Default.language = Globals.CurrentLanguage.getFileName();
            Properties.Settings.Default.timeout = Convert.ToInt32(textBox1.Text);
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
    }
}
