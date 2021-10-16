using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualMeetingMonitor.pluginUtils;
using VirtualMeetingMonitor.Utils;
using VisualMeetingPluginInterface;

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
        private void SavePluginsConfig()
        {
            foreach (var loader in Globals.loaders)
            {
                foreach (var pluginType in loader
                    .LoadDefaultAssembly()
                    .GetTypes()
                    .Where(t => typeof(IPlugin).IsAssignableFrom(t) && !t.IsAbstract))
                {
                    // This assumes the implementation of IPlugin has a parameterless constructor
                    var plugin = Activator.CreateInstance(pluginType) as IPlugin;
                    var configData = plugin.getConfigData();
                    Debug.WriteLine($"CONFIG SAVED {configData}");
                    if (configData != null)
                    {
                        PluginUtils.saveData(CurrentProfile,configData, plugin.GetName());
                    }

                }

            }
        }
        private void CloseForm(DialogResult result)
        {
            SavePluginsConfig();
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
        private void LoadPluginsControllers()
        {
            foreach (var loader in Globals.loaders)
            {
                foreach (var pluginType in loader
                    .LoadDefaultAssembly()
                    .GetTypes()
                    .Where(t => typeof(IPlugin).IsAssignableFrom(t) && !t.IsAbstract))
                {
                    // This assumes the implementation of IPlugin has a parameterless constructor
                    var plugin = Activator.CreateInstance(pluginType) as IPlugin;
                    Dictionary<string, Func<object, dynamic>> interfaces = plugin.Interfaces();
                    if (interfaces != null)
                    {
                     
                         Debug.WriteLine($"plugin usercontroll '{plugin?.GetName()}'.");
                        foreach (KeyValuePair<string, Func<object, dynamic>> p in interfaces)
                        {
                            TabPage tp = new TabPage { };
                            tp.Text = p.Key;
                            

                            UserControl controller = p.Value(null) as UserControl;

                            dynamic pluginConfig = PluginUtils.loadData(CurrentProfile, plugin.GetName());
                            if (pluginConfig != null)
                            {
                                controller = p.Value(pluginConfig) as UserControl;
                            }

                            tp.Controls.Add(controller);
                            tabControl1.TabPages.Add(tp);
                        
                        
                        }
                       
                        
                    }
                }

            }
        }
        private void Actions_Load(object sender, EventArgs e)
        {
            if (!CurrentProfile.DevMode)
            {
                tabControl1.TabPages.Remove(tab_test);
            }
           
            LoadCustomDataGrid();
            LoadCustomDays();
            LoadPluginsControllers();
        }
    }
}
