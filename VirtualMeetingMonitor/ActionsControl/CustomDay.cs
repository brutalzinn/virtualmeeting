using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualMeetingMonitor.ActionsControl
{
    public partial class CustomDay : UserControl
    {
        public List<int> days = new List<int>();
        public string NoDaysMessage { get; set; }

        public string DaysMessage { get; set; }
        public CustomDay()
        {
            InitializeComponent();
            Globals.CustomDays = this;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
     
        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {



            if (checkedListBox1.GetItemChecked(e.Index))
            {
                days.Remove(e.Index + 1);
            }
            else
            {
               days.Add(e.Index + 1);
            }
        
            // Console.WriteLine(e.Index);
        }

        private void CustomDay_Load(object sender, EventArgs e)
        {

            //PreviewResult();
        }
        private void PreviewResult()
        {
            lbl_preview.Text = $"No custom day: {Globals.Formater.Format(NoDaysMessage)} \n Custom Days:{Globals.Formater.Format(DaysMessage)}";
        }
        private void rich_normal_days_TextChanged(object sender, EventArgs e)
        {
            NoDaysMessage = rich_normal_days.Text;
            PreviewResult();
        }

        private void rich_custom_days_TextChanged(object sender, EventArgs e)
        {
            DaysMessage = rich_custom_days.Text;
            PreviewResult();

        }
    }
}
