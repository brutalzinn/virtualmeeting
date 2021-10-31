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
        public ServiceView(Config data)
        {
            InitializeComponent();
            if (data != null)
            {
                checkBox1.Checked = data.Enabled;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var config = new Config();
            config.Enabled = checkBox1.Checked;
            Globals.saveConfig(config);
        }
    }
}
