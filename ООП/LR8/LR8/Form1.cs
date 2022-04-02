using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();
            for (int i = 0; i<dataGridView1.Rows.Count-1; i++)
            {
                list.Add(Convert.ToInt32(dataGridView1["inp", i].Value));
            }
            list.Sort();
            foreach (int i in list)
            {
                if (i %2 == 0)
                {
                    dataGridView3.RowCount++;
                    dataGridView3["ch", dataGridView3.RowCount - 1].Value = i;
                }
                else
                {
                    dataGridView2.RowCount++;
                    dataGridView2["nch", dataGridView2.RowCount - 1].Value = i;
                }
            }

        }
    }
}
