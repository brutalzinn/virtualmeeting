using Markdig;
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
    public partial class Helper : System.Windows.Forms.Form
    {
        public string markdown { get; set; }
        public Helper()
        {
            InitializeComponent();
            this.Text = Globals.getAppName(Globals.getKey("form_help_text"));


        }

        private void Helper_Load(object sender, EventArgs e)
        {
            byte[] bytes = Encoding.Default.GetBytes(markdown);
            string myString = Encoding.UTF8.GetString(bytes);
            webBrowser1.DocumentText = Markdown.ToHtml(myString);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
