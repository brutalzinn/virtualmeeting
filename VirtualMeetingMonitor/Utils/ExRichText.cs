using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualMeetingMonitor.Utils
{
    public class ExRichText : RichTextBox
    {
        [DllImport("kernel32.dll", EntryPoint = "LoadLibraryW", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern IntPtr LoadLibraryW(string path);

        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                LoadLibraryW("MsftEdit.dll");
                cp.ClassName = "RichEdit50W";
                return cp;
            }
        }
    }
}
