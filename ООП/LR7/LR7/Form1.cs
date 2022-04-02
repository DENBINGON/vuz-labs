using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form win = new Form2();
            win.Show();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
	/*
        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog q = new OpenFileDialog();
            q.ShowDialog();
            string PATH = q.FileName;
        }*/
    }
}
