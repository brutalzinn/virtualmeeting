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

        }

        private void Helper_Load(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = Markdown.ToHtml(markdown); ;

        }
    }
}
