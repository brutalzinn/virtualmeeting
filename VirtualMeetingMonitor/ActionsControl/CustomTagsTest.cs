using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualMeetingMonitor.formater;

namespace VirtualMeetingMonitor.ActionsControl
{
    public partial class CustomTagsTest : UserControl
    {
        private string TestMessage { get; set; }

        public CustomTagsTest()
        {
            InitializeComponent();
        }
        private void PreviewResult()
        {
            label1.Text = $"Result: {Formatter.Format(TestMessage)}";
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
          
            TestMessage = richTextBox1.Text;
            PreviewResult();
        }
    }
}
