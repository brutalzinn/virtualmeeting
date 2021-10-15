using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualMeetingMonitor
{
    public partial class PackageInfo : UserControl
    {
        public PackageInfo()
        {
            InitializeComponent();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            Core.Editor.OpenPackage(new Package(Package.ArchivePath));
        }

        private void runButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Core.Editor.OpenPackage(new Package(Package.ArchivePath));

        }
    }
}
