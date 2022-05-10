using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Runtime.InteropServices;
using System.Windows.Forms.DataVisualization.Charting;


namespace CourseworkASD
{
    public partial class MainWindow : MaterialForm
    {
        private readonly List<(string word, int hash)> _data;
        private readonly Random _random = new Random();
        private WordGenerator _wordGenerator;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (int nLeftRect, int nTopRect, int nRightRect,
            int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public MainWindow()
        {
            InitializeComponent();

            _data = new List<(string word, int hash)>();

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
        }

        private void SortData()
        {
            for (int externalCounter = 0; externalCounter < _data.Count; externalCounter++)
            {
                for (int internalCounter = 0; internalCounter < _data.Count - 1; internalCounter++)
                {
                    if (_data[internalCounter].hash > _data[internalCounter + 1].hash)
                        (_data[internalCounter], _data[internalCounter + 1]) =
                            (_data[internalCounter + 1], _data[internalCounter]);
                }
            }
        }

        private void RefreshDataAtGrid()
        {
            SortData();
            dataGridViewWords.Rows.Clear();
            for (int counter = 0; counter < _data.Count; counter++)
            {
                dataGridViewWords.Rows.Add(_data[counter].word);
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
            Process.Start("https://github.com/DENBINGON/vuzLabs/tree/main/%D0%90%D0%B8%D0%A1%D0%94/CourseworkASD");
        }

        private void materialButtonGenerate_Click(object sender, EventArgs e)
        {
            if (materialSliderCount.Value == 0) materialSliderCount.Value = 1;
            if (materialSliderLenght.Value == 0) materialSliderLenght.Value = 1;

            _wordGenerator = new WordGenerator(materialSliderLenght.Value,
                materialCheckboxSymbols.Checked, materialCheckboxUppers.Checked);
            _data.Clear();

            for (int counter = 1; counter < materialSliderCount.Value * 100 + 1; counter++)
            {
                (string word, int hash) temp = _wordGenerator.GetWord(_random);
                if (_data.IndexOf(temp) == -1) _data.Add(temp);
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
            (string word, int hash) temp = (materialTextBoxHandAdd.Text, materialTextBoxHandAdd.Text.GetHashCode());
            if (_data.IndexOf(temp) == -1) _data.Add(temp);
            RefreshDataAtGrid();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(materialTextBoxDel.Text);
                if (index < _data.Count) _data.RemoveAt(index);
                RefreshDataAtGrid();
            }
            finally
            {

            }
        }

        private void materialButtonClear_Click(object sender, EventArgs e)
        {
            _data.Clear();
            dataGridViewWords.Rows.Clear();
        }

        private void materialComboBoxSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (materialComboBoxSelect.SelectedIndex)
            {
                case 0:
                    materialCardBinarySearch.Hide();
                    materialCardLinealSearch.Show();
                    if (materialCheckboxRefresh.Checked)
                    {
                        RefreshStats(chartLineal, materialTextBoxLinealIterCount, materialTextBoxLinealMinTime,
                            materialTextBoxLinealMaxTime, materialTextBoxLinealTotalTime, 0);
                    }

                    break;
                case 1:
                    materialCardLinealSearch.Hide();
                    materialCardBinarySearch.Show();
                    if (materialCheckboxRefresh.Checked)
                    {
                        RefreshStats(chartBinary, materialTextBoxBinaryIterCount, materialTextBoxBinaryMinTime,
                            materialTextBoxBinaryMaxTime, materialTextBoxBinaryTotalTime, 1);
                    }

                    break;
                default:
                    materialCardLinealSearch.Hide();
                    materialCardBinarySearch.Hide();
                    break;
            }
        }

        private void RefreshStats(Chart chart, MaterialTextBox2 iterCount, MaterialTextBox2 minTime,
            MaterialTextBox2 maxTime, MaterialTextBox2 totalTime, int varEng)
        {
            TimeSpan tsMinTime = TimeSpan.MaxValue;
            TimeSpan tsMaxTime = TimeSpan.Zero;
            TimeSpan tsTotalTime = TimeSpan.Zero;
            int iterationsCount = 0;
            int chartCounter = 1;
            Stopwatch timer = new Stopwatch();
            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();
            ISearch search;

            switch (varEng)
            {
                case 0:
                    search = new LinealSearch(_data);
                    break;
                default:
                    search = new BinarySearch(_data);
                    break;
            }

            foreach ((string word, int hash) word in _data)
            {
                timer.Start();
                (bool exist, int iterCount) temp = search.Find(word.word);
                timer.Stop();
                if (tsMinTime > timer.Elapsed) tsMinTime = timer.Elapsed;
                if (tsMaxTime < timer.Elapsed) tsMaxTime = timer.Elapsed;
                iterationsCount += temp.iterCount;
                tsTotalTime += timer.Elapsed;
                chart.Series[0].Points.AddXY(chartCounter, timer.Elapsed.TotalMilliseconds);
                chart.Series[1].Points.AddXY(chartCounter, temp.iterCount);
                chartCounter++;
            }

            minTime.Text = tsMinTime.ToString();
            maxTime.Text = tsMaxTime.ToString();
            totalTime.Text = tsTotalTime.ToString();
            iterCount.Text = iterationsCount.ToString();
        }

        private void materialButtonLinealRefresh_Click(object sender, EventArgs e) =>
            RefreshStats(chartLineal, materialTextBoxLinealIterCount, materialTextBoxLinealMinTime,
                materialTextBoxLinealMaxTime, materialTextBoxLinealTotalTime, 0);

        private void materialButtonBinaryRefresh_Click(object sender, EventArgs e) =>
            RefreshStats(chartBinary, materialTextBoxBinaryIterCount, materialTextBoxBinaryMinTime,
                materialTextBoxBinaryMaxTime, materialTextBoxBinaryTotalTime, 1);

        private void materialCheckboxRefresh_CheckedChanged(object sender, EventArgs e)
        {
            switch (materialCheckboxRefresh.Checked)
            {
                case true:
                    materialButtonBinaryRefresh.Hide();
                    materialButtonLinealRefresh.Hide();
                    break;
                case false:
                    materialButtonBinaryRefresh.Show();
                    materialButtonLinealRefresh.Show();
                    break;
            }
        }

        private void SaveChart(Chart chart)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = @"Сохранить изображение как ...";
                sfd.Filter = @"*.bmp|*.bmp;|*.png|*.png;|*.jpg|*.jpg";
                sfd.AddExtension = true;
                sfd.FileName = "graphicImage";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    switch (sfd.FilterIndex)
                    {
                        case 1:
                            chart.SaveImage(sfd.FileName, ChartImageFormat.Bmp);
                            break;
                        case 2:
                            chart.SaveImage(sfd.FileName, ChartImageFormat.Png);
                            break;
                        case 3:
                            chart.SaveImage(sfd.FileName, ChartImageFormat.Jpeg);
                            break;
                    }
                }
            }
        }


        private void materialButtonSave_Click(object sender, EventArgs e)
        {
            switch (materialComboBoxSelectChart.SelectedIndex)
            {
                case 0: SaveChart(chartLineal); break;
                case 1: SaveChart(chartBinary); break;
            }
        }
    }
}