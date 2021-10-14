using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualMeetingMonitor.Utils;

namespace VirtualMeetingMonitor.Forms
{
    public partial class Actions : System.Windows.Forms.Form
    {
        public Profile CurrentProfile { get; set; }
        public Actions(Profile profile)
        {
            InitializeComponent();
            CurrentProfile = profile;
        }

        private void customDayList_Load(object sender, EventArgs e)
        {

        }

        private void CloseForm(DialogResult result)
        {
            SaveCustomDays();
            DialogResult = result;
            Close();
        }

        private void SaveCustomDays()
        {
            foreach (int element in Globals.CustomDays.days)
            {
                Console.Write($" LISTDAY: {element} ");
            }
            var controlDays = Globals.CustomDays;
            var _customdays = new CustomDaysUtils(controlDays.days, controlDays.NoDaysMessage, controlDays.DaysMessage);
            CurrentProfile.CustomDays = _customdays;
            Console.WriteLine(_customdays.checkToday());
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            Console.WriteLine("WRITEO K BUTTON");

            CloseForm(DialogResult.OK);

        }
        private void SelecionaTodos()
        {
            for (int i = 0; i <= (Globals.CustomDays.checkedListBox1.Items.Count - 1); i++)
            {
                if (CurrentProfile.CustomDays.Days.Contains(i + 1))
                {
                     Globals.CustomDays.checkedListBox1.SetItemCheckState(i, CheckState.Checked);
                }
              
            }
        }
        private void LoadCustomDays()
        {
            if (CurrentProfile.CustomDays != null)
            {
                Globals.CustomDays.rich_custom_days.Text = CurrentProfile.CustomDays.DaysMessage;
                Globals.CustomDays.rich_normal_days.Text = CurrentProfile.CustomDays.NoDaysMessage;
                SelecionaTodos();
            }
        }
        private void Actions_Load(object sender, EventArgs e)
        {
            LoadCustomDays();
        }
    }
}
