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
    public partial class CustomDataGrid : UserControl
    {
        public int ColumnCount { get; set; } = 0;
        
        public CustomDataGrid()
        {
            InitializeComponent();
            Globals.CustomDataGrids = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.Columns.Add($"{ColumnCount}", $"C: {ColumnCount}");
            if(dataGridView1.Columns.Count == 1)
            {
                dataGridView1.Rows.Add(1);
            }
            ColumnCount++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ColumnCount > 0)
            {
                dataGridView1.Columns.RemoveAt(ColumnCount - 1);
                if (dataGridView1.Columns.Count == 0)
                {
                    dataGridView1.Rows.Clear();
                }
                ColumnCount--;

            }
           
        }

        private void CustomDataGrid_Load(object sender, EventArgs e)
        {
           
               
            
         }
    }
}
