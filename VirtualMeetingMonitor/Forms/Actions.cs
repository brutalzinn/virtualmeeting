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
            SaveDataGrid();
            DialogResult = result;
            Close();
        }
        private void SaveDataGrid()
        {

                Dictionary<int,string> list = new Dictionary<int, string>();
                for (int i = 0; i < Globals.CustomDataGrids.ColumnCount; i++)
                {
                   list.Add(i, Globals.CustomDataGrids.dataGridView1.Rows[0].Cells[i].Value.ToString());
                  //  Console.WriteLine($"teste DataGrid: {Globals.CustomDataGrids.dataGridView1.Rows[0].Cells[i].Value}");
                }
                var datagridUtils = new CustomDataGridUtils(list,Globals.CustomDataGrids.checkBox1.Checked);
                CurrentProfile.CustomDataGrid = datagridUtils;


        }
        private void SaveCustomDays()
        {
        
            var controlDays = Globals.CustomDays;
            var _customdays = new CustomDaysUtils(controlDays.days, controlDays.NoDaysMessage, controlDays.DaysMessage, controlDays.Enabled);
            CurrentProfile.CustomDays = _customdays;
           
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {

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
        private void LoadCustomDataGrid()
        {
            if (CurrentProfile.CustomDataGrid != null)
            {
                Globals.CustomDataGrids.checkBox1.Checked = CurrentProfile.CustomDataGrid.Enabled;
                int i = 0;
                int index = 0;
                foreach (var item in CurrentProfile.CustomDataGrid.List)
                {
                    Globals.CustomDataGrids.dataGridView1.Columns.Add(item.Key.ToString(),$"C: {item.Key}");
                    if (i == 0)
                    {
                         index = Globals.CustomDataGrids.dataGridView1.Rows.Add();
                    }
                    Globals.CustomDataGrids.dataGridView1.Rows[index].Cells[item.Key.ToString()].Value = item.Value;
                    i++;
                }

                Globals.CustomDataGrids.ColumnCount = CurrentProfile.CustomDataGrid.List.Count;
            }
        }
        private void LoadCustomDays()
        {
            if (CurrentProfile.CustomDays != null)
            {
                Globals.CustomDays.rich_custom_days.Text = CurrentProfile.CustomDays.DaysMessage;
                Globals.CustomDays.rich_normal_days.Text = CurrentProfile.CustomDays.NoDaysMessage;
                Globals.CustomDays.ckb_check.Checked = CurrentProfile.CustomDays.Enabled;
                SelecionaTodos();
            }
        }
        private void Actions_Load(object sender, EventArgs e)
        {
            LoadCustomDataGrid();
            LoadCustomDays();
        }
    }
}
