using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
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
                Primary.Blue700,
                Primary.Blue600,
                Primary.Blue800,
                Accent.Pink200,
                TextShade.WHITE
            );
        }

        private async void ClearDataAtListBoxAsync()
        {
            await Task.Run(() =>
            {
                while (materialListBoxData.Count != 0)
                {
                    materialListBoxData.Invoke(new Action(() => materialListBoxData.RemoveItemAt(0)));
                }
            });
        }

        private async void RefreshDataAtListBoxAsync()
        {
            QuickSort quickSort = new QuickSort();
            _data = quickSort.Sort(_data, 0, _data.Count - 1);
            ClearDataAtListBoxAsync();
            await Task.Run(() =>
            {
                materialProgressBarDev.Invoke(new Action(() => materialProgressBarDev.Value = 0));
                for (int counter = 0; counter < _data.Count; counter++)
                {
                    materialListBoxData.Invoke(new Action(() => 
                        materialListBoxData.Items.Add(new MaterialListBoxItem(_data[counter].word))));
                    materialProgressBarDev.Invoke(new Action(() =>
                        materialProgressBarDev.Value = Convert.ToInt32((double)counter / (double)_data.Count * 100)));
                }
            });
            materialProgressBarDev.Invoke(new Action(() => materialProgressBarDev.Value = 0));
            materialCheckboxGenerated.Invoke(new Action(() => materialCheckboxGenerated.Checked = true));
            materialButtonGenerate.Enabled = materialCheckboxGenerated.Checked;
            materialButtonClear.Enabled = materialCheckboxGenerated.Checked;

            materialButtonSave.Enabled = materialCheckboxGenerated.Checked;
            materialButtonSaveXlsx.Enabled = materialCheckboxGenerated.Checked;
            materialButtonLinealRefresh.Enabled = materialCheckboxGenerated.Checked;
            materialButtonBinaryRefresh.Enabled = materialCheckboxGenerated.Checked;
            materialButtonHandleSearch.Enabled = materialCheckboxGenerated.Checked;
            materialCheckboxRefresh.Enabled = materialCheckboxGenerated.Checked;
        }

        private void materialSwitchTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitchTheme.Checked)
            {
                MaterialSkinManager skinManager = MaterialSkinManager.Instance;
                skinManager.AddFormToManage(this);
                skinManager.Theme = MaterialSkinManager.Themes.DARK;
            }
            else
            {
                MaterialSkinManager skinManager = MaterialSkinManager.Instance;
                skinManager.AddFormToManage(this);
                skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            }
        }

        private void linkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/DENBINGON/vuzLabs/tree/main/%D0%90%D0%B8%D0%A1%D0%94/CourseworkASD");
        }

        private async void materialButtonGenerate_Click(object sender, EventArgs e)
        {
            if (materialSliderCount.Value == 0) materialSliderCount.Value = 1;
            if (materialSliderLenght.Value == 0) materialSliderLenght.Value = 1;
            materialCheckboxGenerated.Checked = false;
            materialButtonGenerate.Enabled = materialCheckboxGenerated.Checked;
            materialButtonClear.Enabled = materialCheckboxGenerated.Checked;

            materialButtonSave.Enabled = materialCheckboxGenerated.Checked;
            materialButtonSaveXlsx.Enabled = materialCheckboxGenerated.Checked;
            materialButtonLinealRefresh.Enabled = materialCheckboxGenerated.Checked;
            materialButtonBinaryRefresh.Enabled = materialCheckboxGenerated.Checked;
            materialButtonHandleSearch.Enabled = materialCheckboxGenerated.Checked;
            materialCheckboxRefresh.Enabled = materialCheckboxGenerated.Checked;
            materialCheckboxRefresh.Checked = materialCheckboxGenerated.Checked;

            _wordGenerator = new WordGenerator(materialSliderLenght.Value,
                materialCheckboxSymbols.Checked, materialCheckboxUppers.Checked);
            _data.Clear();
            materialProgressBarDev.Value = 0;
            await Task.Run(() =>
            {
                for (int counter = 1; counter < materialSliderCount.Value + 1; counter++)
                {
                    (string word, int hash) temp = _wordGenerator.GetWord(_random);
                    if (_data.IndexOf(temp) == -1) _data.Add(temp);
                    materialProgressBarDev.Invoke(new Action(() =>
                        materialProgressBarDev.Value =
                            Convert.ToInt32((double)counter / (double)(materialSliderCount.Value + 1) * 100)));
                }
            });
            await Task.Run(RefreshDataAtListBoxAsync);
        }

        

        private void materialButtonHandAdd_Click(object sender, EventArgs e)
        {
            (string word, int hash) temp = (materialTextBoxHandAdd.Text, materialTextBoxHandAdd.Text.GetHashCode());
            if (_data.IndexOf(temp) == -1) _data.Add(temp);
            RefreshDataAtListBoxAsync();
        }

        private void materialButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(materialTextBoxDel.Text);
                if (index < _data.Count) _data.RemoveAt(index);
                RefreshDataAtListBoxAsync();
            }
            finally
            {

            }
        }

        private void materialButtonClear_Click(object sender, EventArgs e)
        {
            _data.Clear();
            materialListBoxData.Clear();
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
                        RefreshStatsAsync(chartLineal, materialTextBoxLinealIterCount, materialTextBoxLinealMinTime,
                            materialTextBoxLinealMaxTime, materialTextBoxLinealTotalTime, 0);
                    }

                    break;
                case 1:
                    materialCardLinealSearch.Hide();
                    materialCardHandleSearch.Hide();
                    materialCardBinarySearch.Show();
                    if (materialCheckboxRefresh.Checked)
                    {
                        RefreshStatsAsync(chartBinary, materialTextBoxBinaryIterCount, materialTextBoxBinaryMinTime,
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

        private async void RefreshStatsAsync(Chart chart, MaterialTextBox2 iterCount, MaterialTextBox2 minTime,
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

            await Task.Run(() =>
            {
                foreach ((string word, int hash) word in _data)
                {
                    timer.Start();
                    (bool exist, int iterCount) temp = search.Find(word.word);
                    timer.Stop();
                    if (tsMinTime > timer.Elapsed) tsMinTime = timer.Elapsed;
                    if (tsMaxTime < timer.Elapsed) tsMaxTime = timer.Elapsed;
                    iterationsCount += temp.iterCount;
                    tsTotalTime += timer.Elapsed;
                    chart.Invoke(new Action(() =>
                        chart.Series[0].Points.AddXY(chartCounter, timer.Elapsed.TotalMilliseconds)));
                    chart.Invoke(new Action(() => chart.Series[1].Points.AddXY(chartCounter, temp.iterCount)));
                    timer.Reset();
                    materialProgressBarStat.Invoke(new Action(() =>
                        materialProgressBarStat.Value =
                            Convert.ToInt32((double)chartCounter / (double)_data.Count * 100)));
                    chartCounter++;
                }
            });

            minTime.Text = tsMinTime.ToString();
            maxTime.Text = tsMaxTime.ToString();
            totalTime.Text = tsTotalTime.ToString();
            iterCount.Text = iterationsCount.ToString();
            materialProgressBarStat.Value = 0;
        }

        private void materialButtonLinealRefresh_Click(object sender, EventArgs e) =>
            RefreshStatsAsync(chartLineal, materialTextBoxLinealIterCount, materialTextBoxLinealMinTime,
                materialTextBoxLinealMaxTime, materialTextBoxLinealTotalTime, 0);

        private void materialButtonBinaryRefresh_Click(object sender, EventArgs e) =>
            RefreshStatsAsync(chartBinary, materialTextBoxBinaryIterCount, materialTextBoxBinaryMinTime,
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

        private async void SaveDataAsync(int searchId)
        {

            SaveFileDialog sfd = new SaveFileDialog();

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

                await Task.Run(() =>
                {

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

                });

                File.WriteAllBytes(sfd.FileName, await package.GetAsByteArrayAsync());

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
                    SaveDataAsync(0);
                    break;
                case 1:
                    SaveDataAsync(1);
                    break;
            }
        }

        private async void materialCheckboxLinealTime_CheckedChanged(object sender, EventArgs e) =>
            await Task.Run(() => chartLineal.Series[0].Enabled = materialCheckboxLinealTime.Checked);

        private async void materialCheckboxLinealCount_CheckedChanged(object sender, EventArgs e) =>
            await Task.Run(() => chartLineal.Series[1].Enabled = materialCheckboxLinealCount.Checked);

        private async void materialCheckboxBinaryTime_CheckedChanged(object sender, EventArgs e) =>
            await Task.Run(() => chartBinary.Series[0].Enabled = materialCheckboxBinaryTime.Checked);

        private async void materialCheckboxBinaryCount_CheckedChanged(object sender, EventArgs e) =>
            await Task.Run(() => chartBinary.Series[1].Enabled = materialCheckboxBinaryCount.Checked);

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