using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string output = "";
            StreamWriter writer = new StreamWriter("1.txt");
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                output +=
                   $"ФИО: {dataGridView1["ColumnFIO", i].Value}\n" +
                   $"МОИ: {dataGridView1["ColumnMOI", i].Value}\n" +
                   $"ОМЛ: {dataGridView1["ColumnOML", i].Value}\n\n";
            }
            writer.Write(output);
            writer.Close();
        }
    }
}
