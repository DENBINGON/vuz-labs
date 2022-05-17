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
using System.Xml.Serialization.Configuration;
using OfficeOpenXml;
using OfficeOpenXml.Attributes;


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

        private async void ClearListBox()
        {
            if (materialSwitchGenWordAsync.Checked)
            {
                await Task.Run(() =>
                {
                    while (materialListBoxData.Count != 0)
                    {
                        materialListBoxData.RemoveItemAt(0);
                    }
                });
            }
            else materialListBoxData.Clear();
        }

        private async void RefreshDataAtListBox()
        {
            materialButtonGenerate.Enabled =
                materialButtonClear.Enabled =
                    materialButtonSave.Enabled =
                        materialButtonSaveXlsx.Enabled =
                            materialButtonLinealRefresh.Enabled =
                                materialButtonBinaryRefresh.Enabled =
                                    materialCheckboxRefresh.Enabled =
                                        materialCheckboxGenerated.Checked = false;

            QuickSort quickSort = new QuickSort();
            _data = quickSort.Sort(_data, 0, _data.Count - 1);
            materialListBoxData.Clear();
            if (materialSwitchGenWordAsync.Checked)
            {
                await Task.Run(() =>
                {
                    materialProgressBarDev.Invoke(new Action(() => materialProgressBarDev.Value = 0));
                    for (int counter = 0; counter < _data.Count; counter++)
                    {
                        materialListBoxData.Invoke(new Action(() =>
                            materialListBoxData.Items.Add(new MaterialListBoxItem(_data[counter].word))));
                        materialProgressBarDev.Invoke(new Action(() =>
                            materialProgressBarDev.Value =
                                Convert.ToInt32((double)counter / (double)_data.Count * 100)));
                    }
                });
            }
            else
            {
                materialProgressBarDev.Invoke(new Action(() => materialProgressBarDev.Value = 0));
                for (int counter = 0; counter < _data.Count; counter++)
                {
                    materialListBoxData.Invoke(new Action(() =>
                        materialListBoxData.Items.Add(new MaterialListBoxItem(_data[counter].word))));
                    materialProgressBarDev.Invoke(new Action(() =>
                        materialProgressBarDev.Value =
                            Convert.ToInt32((double)counter / (double)_data.Count * 100)));
                }
            }

            materialProgressBarDev.Invoke(new Action(() => materialProgressBarDev.Value = 0));
            materialCheckboxGenerated.Invoke(new Action(() => materialCheckboxGenerated.Checked = true));

            materialButtonHandleSearch.Invoke(
                new Action(() => materialButtonHandleSearch.Enabled = materialCheckboxGenerated.Checked));

            materialButtonGenerate.Enabled =
                materialButtonClear.Enabled =
                    materialButtonSave.Enabled =
                        materialButtonSaveXlsx.Enabled =
                            materialButtonLinealRefresh.Enabled =
                                materialButtonBinaryRefresh.Enabled =
                                    materialCheckboxRefresh.Enabled = materialCheckboxGenerated.Checked;
        }

        private void materialSwitchTheme_CheckedChanged(object sender, EventArgs e)
        {
            if (materialSwitchTheme.Checked)
            {
                MaterialSkinManager skinManager = MaterialSkinManager.Instance;
                skinManager.AddFormToManage(this);
                skinManager.Theme = MaterialSkinManager.Themes.DARK;
                linkLabelGitHub.LinkColor = Color.White;
                linkLabelGitHub.ForeColor = Color.White;
            }
            else
            {
                MaterialSkinManager skinManager = MaterialSkinManager.Instance;
                skinManager.AddFormToManage(this);
                skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                linkLabelGitHub.LinkColor = Color.Black;
                linkLabelGitHub.ForeColor = Color.Black;
            }
        }

        private void linkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) =>
            Process.Start("https://github.com/DENBINGON/vuzLabs/tree/main/%D0%90%D0%B8%D0%A1%D0%94/CourseworkASD");

        private async void materialButtonGenerate_Click(object sender, EventArgs e)
        {
            if (materialSliderCount.Value == 0) materialSliderCount.Value = 1;
            if (materialSliderLenght.Value == 0) materialSliderLenght.Value = 1;
            materialCheckboxGenerated.Checked =
                materialButtonGenerate.Enabled =
                    materialButtonClear.Enabled =
                        materialButtonSave.Enabled =
                            materialButtonSaveXlsx.Enabled =
                                materialButtonLinealRefresh.Enabled =
                                    materialButtonBinaryRefresh.Enabled =
                                        materialButtonHandleSearch.Enabled =
                                            materialCheckboxRefresh.Enabled =
                                                materialCheckboxRefresh.Checked = false;

            _wordGenerator = new WordGenerator(materialSliderLenght.Value,
                materialCheckboxSymbols.Checked, materialCheckboxUppers.Checked);
            _data.Clear();
            materialProgressBarDev.Value = 0;
            if (materialSwitchGenWordAsync.Checked)
            {
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
                await Task.Run(RefreshDataAtListBox);
            }
            else
            {
                for (int counter = 1; counter < materialSliderCount.Value + 1; counter++)
                {
                    (string word, int hash) temp = _wordGenerator.GetWord(_random);
                    if (_data.IndexOf(temp) == -1) _data.Add(temp);
                    materialProgressBarDev.Invoke(new Action(() =>
                        materialProgressBarDev.Value =
                            Convert.ToInt32((double)counter / (double)(materialSliderCount.Value + 1) * 100)));
                }

                RefreshDataAtListBox();
            }
        }

        private void materialButtonHandAdd_Click(object sender, EventArgs e)
        {
            (string word, int hash) temp = (materialTextBoxHandAdd.Text, materialTextBoxHandAdd.Text.GetHashCode());
            if (_data.IndexOf(temp) == -1) _data.Add(temp);
            RefreshDataAtListBox();
            materialTextBoxHandAdd.Clear();
        }

        private void materialButtonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (materialTextBoxDel.Text != "")
                {
                    int index = Convert.ToInt32(materialTextBoxDel.Text);
                    if (index < _data.Count) _data.RemoveAt(index);
                    RefreshDataAtListBox();
                }

                materialTextBoxDel.Clear();
            }
            catch
            {
                // ignored
            }
        }

        private void materialButtonClear_Click(object sender, EventArgs e)
        {
            _data.Clear();
            ClearListBox();
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

        private async void RefreshStats(Chart chart, MaterialTextBox2 iterCount, MaterialTextBox2 minTime,
            MaterialTextBox2 maxTime, MaterialTextBox2 totalTime, int varEng)
        {
            materialButtonSave.Enabled =
                materialButtonSaveXlsx.Enabled =
                    materialButtonLinealRefresh.Enabled =
                        materialButtonBinaryRefresh.Enabled =
                            materialButtonHandleSearch.Enabled =
                                materialCheckboxRefresh.Enabled =
                                    materialCheckboxRefresh.Checked = false;

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

            if (!materialSwitchWrapChartAsync.Checked)
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
                    chart.Series[0].Points.AddXY(chartCounter, timer.Elapsed.TotalMilliseconds);
                    chart.Series[1].Points.AddXY(chartCounter, temp.iterCount);
                    timer.Reset();
                    materialProgressBarStat.Value = Convert.ToInt32((double)chartCounter / (double)_data.Count * 100);
                    chartCounter++;
                }
            }
            else
            {
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
                        minTime.Text = tsMinTime.ToString();
                        maxTime.Text = tsMaxTime.ToString();
                        totalTime.Text = tsTotalTime.ToString();
                        iterCount.Text = iterationsCount.ToString();
                    }
                });
            }

            minTime.Text = tsMinTime.ToString();
            maxTime.Text = tsMaxTime.ToString();
            totalTime.Text = tsTotalTime.ToString();
            iterCount.Text = iterationsCount.ToString();
            materialProgressBarStat.Value = 0;
            materialButtonSave.Enabled =
                materialButtonSaveXlsx.Enabled =
                    materialButtonLinealRefresh.Enabled =
                        materialButtonBinaryRefresh.Enabled =
                            materialButtonHandleSearch.Enabled =
                                materialCheckboxRefresh.Enabled = true;
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
                sfd.Filter = @"|*.png|*.png;*.bmp|*.bmp;|*.jpg|*.jpg";
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

        private async void SaveDataAsync(int searchId, int saveType)
        {

            SaveFileDialog sfd = new SaveFileDialog();
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

            switch (saveType)
            {
                case 0:
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

                    break;

                case 1:
                    sfd.Title = @"Сохранить текстовый файл как...";
                    sfd.Filter = @"*.txt|*.txt";
                    sfd.AddExtension = true;
                    sfd.FileName = "dataFile";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter writer = new StreamWriter(sfd.FileName);
                        await Task.Run(() =>
                        {
                            foreach ((string word, int hash) word in _data)
                            {
                                counter++;
                                stopwatch.Start();
                                int iter = search.Find(word.word).iterCount;
                                stopwatch.Stop();
                                writer.WriteLine(
                                    $"{word.word} {word.hash} {stopwatch.Elapsed.TotalMilliseconds} {iter}");
                            }
                        });
                        writer.Close();
                    }

                    break;
            }
        }

        private void SaveData(int searchId, int saveType)
        {
            SaveFileDialog sfd = new SaveFileDialog();
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

            switch (saveType)
            {
                case 0:
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

                    break;

                case 1:
                    sfd.Title = @"Сохранить текстовый файл как...";
                    sfd.Filter = @"*.txt|*.txt";
                    sfd.AddExtension = true;
                    sfd.FileName = "dataFile";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter writer = new StreamWriter(sfd.FileName);

                        foreach ((string word, int hash) word in _data)
                        {
                            counter++;
                            stopwatch.Start();
                            int iter = search.Find(word.word).iterCount;
                            stopwatch.Stop();
                            writer.WriteLine(
                                $"{word.word} {word.hash} {stopwatch.Elapsed.TotalMilliseconds} {iter}");
                        }

                        writer.Close();
                    }

                    break;
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
            switch (materialComboBoxSaveDataType.SelectedIndex)
            {
                case 0:
                    switch (materialComboBoxSelectChartToXlsx.SelectedIndex)
                    {
                        case 0:
                            if (materialSwitchSaveDataAsync.Checked) SaveDataAsync(0, 0);
                            else SaveData(0, 0);
                            break;
                        case 1:
                            if (materialSwitchSaveDataAsync.Checked) SaveDataAsync(1, 0);
                            else SaveData(1, 0);
                            break;
                    }

                    break;
                case 1:
                    switch (materialComboBoxSelectChartToXlsx.SelectedIndex)
                    {
                        case 0:
                            if (materialSwitchSaveDataAsync.Checked) SaveDataAsync(0, 1);
                            else SaveData(0, 1);
                            break;
                        case 1:
                            if (materialSwitchSaveDataAsync.Checked) SaveDataAsync(1, 1);
                            else SaveData(1, 1);
                            break;
                    }

                    break;
            }
        }

        private async void materialCheckboxLinealTime_CheckedChanged(object sender, EventArgs e) =>
            await Task.Run(() => chartLineal.Invoke(
                new Action(() => chartLineal.Series[0].Enabled = materialCheckboxLinealTime.Checked)));

        private async void materialCheckboxLinealCount_CheckedChanged(object sender, EventArgs e) =>
            await Task.Run(() => chartLineal.Invoke(
                new Action(() => chartLineal.Series[1].Enabled = materialCheckboxLinealCount.Checked)));

        private async void materialCheckboxBinaryTime_CheckedChanged(object sender, EventArgs e) =>
            await Task.Run(() => chartBinary.Invoke(
                new Action(() => chartBinary.Series[0].Enabled = materialCheckboxBinaryTime.Checked)));

        private async void materialCheckboxBinaryCount_CheckedChanged(object sender, EventArgs e) =>
            await Task.Run(() => chartBinary.Invoke(
                new Action(() => chartBinary.Series[1].Enabled = materialCheckboxBinaryCount.Checked)));

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

        private void materialSwitchUseAsync_CheckedChanged(object sender, EventArgs e)
        {
            materialSwitchGenWordAsync.Checked = materialSwitchUseAsync.Checked;
            materialSwitchWrapChartAsync.Checked = materialSwitchUseAsync.Checked;
            materialSwitchSaveDataAsync.Checked = materialSwitchUseAsync.Checked;
        }


        private void materialButtonImportSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = @"*.xlsx|*.xlsx|*.txt|*.txt";
            ofd.Title = "Выберите файл...";
            if (ofd.ShowDialog() == DialogResult.OK)
                materialTextBoxImportSelectedFile.Text = ofd.FileName;
        }

        private void materialButtonImportClearPath_Click(object sender, EventArgs e) =>
            materialTextBoxImportSelectedFile.Clear();

        private void materialButtonImport_Click(object sender, EventArgs e)
        {
            if (materialTextBoxImportSelectedFile.Text == "") materialLabelImportError.Show();
            else
            {
                materialLabelImportError.Hide();
                try
                {
                    string param = materialTextBoxImportSelectedFile.Text.Split(Convert.ToChar("."))[1];
                    if (!materialCheckBoxDop.Checked) _data.Clear();
                    switch (param)
                    {
                        case "txt":
                            if (materialSwitchSaveDataAsync.Checked)
                                ImportTxtAsync(materialTextBoxImportSelectedFile.Text);
                            else ImportTxt(materialTextBoxImportSelectedFile.Text);
                            break;
                        case "xlsx":
                            if (materialSwitchSaveDataAsync.Checked)
                                ImportXlsxAsync(materialTextBoxImportSelectedFile.Text);
                            else ImportXlsx(materialTextBoxImportSelectedFile.Text);
                            break;
                    }

                    RefreshDataAtListBox();
                }
                catch
                {
                    materialLabelImportError.Show();
                }
            }
        }

        private void ImportTxt(string path)
        {
            StreamReader reader = new StreamReader(path);
            foreach (string word in reader.ReadToEnd().Split(Convert.ToChar("\n")))
            {
                try
                {
                    if (_data.IndexOf((word, word.GetHashCode())) == -1) _data.Add((word, word.GetHashCode()));
                }
                catch
                {
                }
            }

            reader.Close();
        }

        private void ImportXlsx(string path)
        {
            int counter = 0;
            FileStream fs = new FileStream(path, FileMode.Open);
            ExcelPackage package = new ExcelPackage(fs);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
            while (true)
            {
                try
                {
                    counter++;
                    string word = worksheet.Cells["A" + counter.ToString()].Value.ToString();
                    if (word == "") break;
                    if (_data.IndexOf((word, word.GetHashCode())) == -1) _data.Add((word, word.GetHashCode()));
                }
                catch
                {
                    break;

                }
            }

            fs.Close();
        }

        private async void ImportTxtAsync(string path)
        {
            StreamReader reader = new StreamReader(path);
            await Task.Run(() =>
            {
                foreach (string word in reader.ReadToEnd().Split(Convert.ToChar("\n")))
                {
                    try
                    {
                        if (_data.IndexOf((word, word.GetHashCode())) == -1) _data.Add((word, word.GetHashCode()));
                    }
                    catch
                    {
                    }
                }
            });
            reader.Close();
        }

        private async void ImportXlsxAsync(string path)
        {
            int counter = 0;
            FileStream fs = new FileStream(path, FileMode.Open);
            ExcelPackage package = new ExcelPackage(fs);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
            await Task.Run(() =>
            {
                while (true)
                {
                    try
                    {
                        counter++;
                        string word = worksheet.Cells["A" + counter.ToString()].Value.ToString();
                        if (word == "") break;
                        if (_data.IndexOf((word, word.GetHashCode())) == -1) _data.Add((word, word.GetHashCode()));
                    }
                    catch
                    {
                        break;
                    }
                }
            });
            fs.Close();
        }
    }
}