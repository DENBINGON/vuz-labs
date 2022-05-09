using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Runtime.InteropServices;


namespace CourseworkASD
{
    public partial class MainWindow : MaterialForm
    {
        private readonly List<(string word, int hash)> data;
        private readonly Random _random = new Random();
        private WordGenerator wordGenerator;
        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (int nLeftRect, int nTopRect, int nRightRect,    
            int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        
        public MainWindow()
        {
            InitializeComponent();
            
            data = new List<(string word, int hash)>();
            
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, 
                Primary.Blue700,
                Primary.Blue700, 
                Accent.LightBlue400, 
                TextShade.WHITE
            );
            materialCardHandle.Hide();
        }

        private void SortData()
        {
            for (int counter_ = 0; counter_ < data.Count; counter_++)
            {
                for (int counter = 0; counter < data.Count - 1; counter++)
                {
                    if (data[counter].hash > data[counter + 1].hash)
                        (data[counter], data[counter + 1]) = (data[counter + 1], data[counter]);
                }
            }
        }
        
        private void RefreshDataAtGrid()
        {
            SortData();
            dataGridViewWords.Rows.Clear();
            for (int counter = 0; counter < data.Count; counter++)
            {
                dataGridViewWords.Rows.Add(data[counter].word);
            }
        }
        
        private void materialSwitchTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitchTheme.Checked)
            {
                MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.Blue600, 
                    Primary.Blue700,
                    Primary.Blue700, 
                    Accent.LightBlue400, 
                    TextShade.BLACK
                );
            }
            else
            {
                MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(
                    Primary.Blue600, 
                    Primary.Blue700,
                    Primary.Blue700, 
                    Accent.LightBlue400, 
                    TextShade.WHITE
                );
            }
        }

        private void linkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DENBINGON/vuzLabs/tree/main/%D0%90%D0%B8%D0%A1%D0%94/CourseworkASD");
        }

        private void materialButtonGenerate_Click(object sender, EventArgs e)
        {
            wordGenerator = new WordGenerator(materialSliderLenght.Value, 
                materialCheckboxSymbols.Checked, materialCheckboxUppers.Checked);
            data.Clear();
            for (int counter = 1; counter < materialSliderCount.Value * 100 + 1; counter++)
            {
                (string word, int hash) temp = wordGenerator.GetWord(_random);
                if (data.IndexOf(temp) == -1) data.Add(temp);
                materialProgressBar.Value = Convert.ToInt32(counter / (materialSliderCount.Value * 100 + 1) * 100);
            }
            RefreshDataAtGrid();
        }

        private void materialSwitchHandle_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitchHandle.Checked)
            {
                materialCardAuto.Hide();
                materialCardHandle.Show();
            }
            else
            {
                materialCardAuto.Show();
                materialCardHandle.Hide();
            }
        }

        private void materialButtonHandAdd_Click(object sender, EventArgs e)
        {
            (string word, int hash) temp = (materialTextBoxHandAdd.Text,materialTextBoxHandAdd.Text.GetHashCode());
            if (data.IndexOf(temp) == -1) data.Add(temp); 
            RefreshDataAtGrid();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(materialTextBoxDel.Text);
                if (index < data.Count) data.RemoveAt(index);
                RefreshDataAtGrid();
            }
            catch {}
        }

        private void materialButtonClear_Click(object sender, EventArgs e)
        {
            data.Clear();
            dataGridViewWords.Rows.Clear();
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            BinarySearch bs = new BinarySearch(data);
            materialLabel3.Text = bs.Find("3").ToString();
        }
    }
}