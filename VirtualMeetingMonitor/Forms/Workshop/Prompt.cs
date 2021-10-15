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
    public partial class Prompt : System.Windows.Forms.Form
    {
        public Prompt()
        {
            InitializeComponent();
        }

        private void promptEntryBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                PromptSubmit.PerformClick();

                e.Handled = true;
            }
        }

        private void promptSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
