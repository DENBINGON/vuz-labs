using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Runtime.InteropServices;
using System.Windows.Forms.DataVisualization.Charting;
using OfficeOpenXml;


namespace CourseworkASD
{
    public partial class MainWindow : MaterialForm
    {
        private List<(string word, int hash)> _data;
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

            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            skinManager.ColorScheme = new ColorScheme(
                Primary.Blue600,
                Primary.Blue700,
                Primary.Blue700,
                Accent.LightBlue400,
                TextShade.WHITE
            );
        }

        private void RefreshDataAtGrid()
        {
            QuickSort quickSort = new QuickSort();
            _data = quickSort.Sort(_data, 0, _data.Count - 1);
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
                MaterialSkinManager skinManager = MaterialSkinManager.Instance;
                skinManager.AddFormToManage(this);
                skinManager.Theme = MaterialSkinManager.Themes.DARK;
                skinManager.ColorScheme = new ColorScheme(
                    Primary.Blue600,
                    Primary.Blue700,
                    Primary.Blue700,
                    Accent.LightBlue400,
                    TextShade.BLACK
                );
            }
            else
            {
                MaterialSkinManager skinManager = MaterialSkinManager.Instance;
                skinManager.AddFormToManage(this);
                skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                skinManager.ColorScheme = new ColorScheme(
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

        private void materialButtonDel_Click(object sender, EventArgs e)
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
                    materialCardHandleSearch.Hide();
                    materialCardLinealSearch.Show();
                    if (materialCheckboxRefresh.Checked)
                    {
                        RefreshStats(chartLineal, materialTextBoxLinealIterCount, materialTextBoxLinealMinTime,
                            materialTextBoxLinealMaxTime, materialTextBoxLinealTotalTime, 0);
                    }

                    break;
                case 1:
                    materialCardLinealSearch.Hide();
                    materialCardHandleSearch.Hide();
                    materialCardBinarySearch.Show();
                    if (materialCheckboxRefresh.Checked)
                    {
                        RefreshStats(chartBinary, materialTextBoxBinaryIterCount, materialTextBoxBinaryMinTime,
                            materialTextBoxBinaryMaxTime, materialTextBoxBinaryTotalTime, 1);
                    }

                    break;
                case 2:
                    materialCardLinealSearch.Hide();
                    materialCardBinarySearch.Hide();
                    materialCardHandleSearch.Show();
                    if (materialCheckboxRefresh.Checked)
                    {
                        materialButtonHandleSearch_Click(sender, e);
                    }
                    break;
                default:
                    materialCardLinealSearch.Hide();
                    materialCardBinarySearch.Hide();
                    materialCardHandleSearch.Hide();
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
                timer.Reset();
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

        private void SaveData(int searchId)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = @"Сохранить таблицу как...";
                sfd.Filter = @"*.xlsx|*.xlsx";
                sfd.AddExtension = true;
                sfd.FileName = "dataBook";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExcelPackage package = new ExcelPackage();
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("DATA");
                    worksheet.Cells["A1"].Value = "WORD";
                    worksheet.Cells["B1"].Value = "HASH";
                    worksheet.Cells["C1"].Value = "TIME";
                    worksheet.Cells["D1"].Value = "ITER";
                    Stopwatch stopwatch = new Stopwatch();
                    ISearch search;
                    int counter = 1;
                    switch (searchId)
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
                        counter++;
                        stopwatch.Start();
                        int iter = search.Find(word.word).iterCount;
                        stopwatch.Stop();
                        worksheet.Cells[$"A{counter}"].Value = word.word;
                        worksheet.Cells[$"B{counter}"].Value = word.hash;
                        worksheet.Cells[$"C{counter}"].Value = stopwatch.Elapsed.TotalMilliseconds;
                        worksheet.Cells[$"D{counter}"].Value = iter;
                        stopwatch.Reset();
                    }

                    File.WriteAllBytes(sfd.FileName, package.GetAsByteArray());
                }
            }
        }

        private void materialButtonSave_Click(object sender, EventArgs e)
        {
            switch (materialComboBoxSelectChart.SelectedIndex)
            {
                case 0:
                    SaveChart(chartLineal);
                    break;
                case 1:
                    SaveChart(chartBinary);
                    break;
            }
        }

        private void materialButtonSaveXlsx_Click(object sender, EventArgs e)
        {
            switch (materialComboBoxSelectChartToXlsx.SelectedIndex)
            {
                case 0:
                    SaveData(0);
                    break;
                case 1:
                    SaveData(1);
                    break;
            }
        }

        private void materialCheckboxLinealTime_CheckedChanged(object sender, EventArgs e) =>
            chartLineal.Series[0].Enabled = materialCheckboxLinealTime.Checked;

        private void materialCheckboxLinealCount_CheckedChanged(object sender, EventArgs e) =>
            chartLineal.Series[1].Enabled = materialCheckboxLinealCount.Checked;

        private void materialCheckboxBinaryTime_CheckedChanged(object sender, EventArgs e) =>
            chartBinary.Series[0].Enabled = materialCheckboxBinaryTime.Checked;

        private void materialCheckboxBinaryCount_CheckedChanged(object sender, EventArgs e) =>
            chartBinary.Series[1].Enabled = materialCheckboxBinaryCount.Checked;

        private void materialButtonHandleSearch_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            ISearch search;
            switch (materialComboBoxHandleSeach.SelectedIndex)
            {
                case 0:
                    search = new LinealSearch(_data);
                    break;
                default:
                    search = new BinarySearch(_data);
                    break;
            }

            stopwatch.Start();
            (bool exist, int iter) data = search.Find(materialTextBoxHandleFindWord.Text);
            stopwatch.Stop();
            materialTextBoxHandleQuestion.Text = data.exist.ToString();
            materialTextBoxHandleIterCount.Text = data.iter.ToString();
            materialTextBoxHandleTime.Text = stopwatch.Elapsed.ToString();
        }
    }
}