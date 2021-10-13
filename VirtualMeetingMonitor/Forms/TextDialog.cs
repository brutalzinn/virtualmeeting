using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualMeetingMonitor.Forms
{
    public partial class TextDialog : System.Windows.Forms.Form
    {
        public string textField { get; set; }
        public TextDialog()
        {
            InitializeComponent();
            Text = Globals.getAppName(Globals.getKey("form_textdialog_text"));
        }

        private void TextDialog_Load(object sender, EventArgs e)
        {
            if (textField != null)
            {
                textBox1.Text = textField;
            }
            lblProfileName.Text = Globals.getKey("form_textdialog_label");
            button1.Text = Globals.getKey("button_ok");
            button2.Text = Globals.getKey("button_cancel");
        }
        private void CloseForm(DialogResult result)
        {
            textField = textBox1.Text;
            DialogResult = result;
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        { 
            CloseForm(DialogResult.OK);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CloseForm(DialogResult.Cancel);
        }
    }
}
