using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PluginExampleWithInterface.Views
{
    public partial class ControlConfig : UserControl
    {
        public ControlConfig(Config data)
        {
            InitializeComponent();
            if (data != null)
            {
                textBox1.Text = data.TextBoxValue;
            }
            if (Globals._Config != null)
            {
                textBox1.Text = Globals._Config.TextBoxValue;
            }
        }

        private void ControlConfig_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
            var config = new Config();
            config.TextBoxValue = textBox1.Text;
            Globals.saveConfig(config);
         
        }
    }
}
