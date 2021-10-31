using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PluginServiceExample.Views
{
    public partial class ServiceView : UserControl
    {
        public Config config { get; set; } = new Config();
        public ServiceView(Config data)
        {
            InitializeComponent();
            if (data != null)
            {
                checkBox1.Checked = data.Enabled;
                textbox_googleSheetsID.Text = data.SpreadsheetId;
                textbox_sheetname.Text = data.sheet;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SaveConfig();
        }
        private void SaveConfig()
        {  
            config.Enabled = checkBox1.Checked;
            config.SpreadsheetId = textbox_googleSheetsID.Text;
            config.sheet = textbox_sheetname.Text;
            Globals.saveConfig(config);
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
        //all text box changed event is tracked here
        private void textbox_sheetname_TextChanged(object sender, EventArgs e)
        {
            SaveConfig();
        }
    }
}
