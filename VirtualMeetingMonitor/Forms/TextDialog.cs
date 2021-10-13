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
        }

        private void TextDialog_Load(object sender, EventArgs e)
        {

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
