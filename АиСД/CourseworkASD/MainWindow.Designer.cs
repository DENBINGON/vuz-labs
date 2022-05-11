﻿using System.ComponentModel;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
namespace CourseworkASD
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.materialTabControlMainWindow = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageDevelop = new System.Windows.Forms.TabPage();
            this.materialTabControlDev = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageAuto = new System.Windows.Forms.TabPage();
            this.materialProgressBarDev = new MaterialSkin.Controls.MaterialProgressBar();
            this.materialCardAuto = new MaterialSkin.Controls.MaterialCard();
            this.materialCheckboxGenerated = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialButtonClear = new MaterialSkin.Controls.MaterialButton();
            this.materialCheckboxUppers = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckboxSymbols = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialSliderLenght = new MaterialSkin.Controls.MaterialSlider();
            this.materialSliderCount = new MaterialSkin.Controls.MaterialSlider();
            this.materialButtonGenerate = new MaterialSkin.Controls.MaterialButton();
            this.tabPageHandle = new System.Windows.Forms.TabPage();
            this.materialCardHandle = new MaterialSkin.Controls.MaterialCard();
            this.materialButtonDel = new MaterialSkin.Controls.MaterialButton();
            this.materialLabelHandAdd = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelDel = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBoxHandAdd = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBoxDel = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButtonHandAdd = new MaterialSkin.Controls.MaterialButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialListBoxData = new MaterialSkin.Controls.MaterialListBox();
            this.tabPageCharts = new System.Windows.Forms.TabPage();
            this.materialProgressBarStat = new MaterialSkin.Controls.MaterialProgressBar();
            this.materialCardHandleSearch = new MaterialSkin.Controls.MaterialCard();
            this.materialTextBoxHandleQuestion = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialComboBoxHandleSeach = new MaterialSkin.Controls.MaterialComboBox();
            this.materialTextBoxHandleFindWord = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBoxHandleTime = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBoxHandleIterCount = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButtonHandleSearch = new MaterialSkin.Controls.MaterialButton();
            this.materialCardLinealSearch = new MaterialSkin.Controls.MaterialCard();
            this.materialCheckboxLinealCount = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckboxLinealTime = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialTextBoxLinealTotalTime = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBoxLinealMaxTime = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBoxLinealMinTime = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBoxLinealIterCount = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButtonLinealRefresh = new MaterialSkin.Controls.MaterialButton();
            this.chartLineal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.materialCardBinarySearch = new MaterialSkin.Controls.MaterialCard();
            this.materialCheckboxBinaryCount = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckboxBinaryTime = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialTextBoxBinaryTotalTime = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBoxBinaryMaxTime = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBoxBinaryMinTime = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBoxBinaryIterCount = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButtonBinaryRefresh = new MaterialSkin.Controls.MaterialButton();
            this.chartBinary = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.materialComboBoxSelect = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCheckboxRefresh = new MaterialSkin.Controls.MaterialCheckbox();
            this.tabPageSpec = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabelSaveXlsx = new MaterialSkin.Controls.MaterialLabel();
            this.materialButtonSaveXlsx = new MaterialSkin.Controls.MaterialButton();
            this.materialComboBoxSelectChartToXlsx = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCardSave = new MaterialSkin.Controls.MaterialCard();
            this.materialButtonSave = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBoxSelectChart = new MaterialSkin.Controls.MaterialComboBox();
            this.materialSwitchTheme = new MaterialSkin.Controls.MaterialSwitch();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
            this.imageListGit = new System.Windows.Forms.ImageList(this.components);
            this.materialLabelSubject = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelKR = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelInfo = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBoxInfoLogo = new System.Windows.Forms.PictureBox();
            this.imageListMenu = new System.Windows.Forms.ImageList(this.components);
            this.imageListSelector = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControlMainWindow.SuspendLayout();
            this.tabPageDevelop.SuspendLayout();
            this.materialTabControlDev.SuspendLayout();
            this.tabPageAuto.SuspendLayout();
            this.materialCardAuto.SuspendLayout();
            this.tabPageHandle.SuspendLayout();
            this.materialCardHandle.SuspendLayout();
            this.tabPageCharts.SuspendLayout();
            this.materialCardHandleSearch.SuspendLayout();
            this.materialCardLinealSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLineal)).BeginInit();
            this.materialCardBinarySearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBinary)).BeginInit();
            this.tabPageSpec.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCardSave.SuspendLayout();
            this.tabPageInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControlMainWindow
            // 
            this.materialTabControlMainWindow.Controls.Add(this.tabPageDevelop);
            this.materialTabControlMainWindow.Controls.Add(this.tabPageCharts);
            this.materialTabControlMainWindow.Controls.Add(this.tabPageSpec);
            this.materialTabControlMainWindow.Controls.Add(this.tabPageInfo);
            this.materialTabControlMainWindow.Depth = 0;
            this.materialTabControlMainWindow.ImageList = this.imageListMenu;
            this.materialTabControlMainWindow.Location = new System.Drawing.Point(0, 64);
            this.materialTabControlMainWindow.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControlMainWindow.Multiline = true;
            this.materialTabControlMainWindow.Name = "materialTabControlMainWindow";
            this.materialTabControlMainWindow.SelectedIndex = 0;
            this.materialTabControlMainWindow.Size = new System.Drawing.Size(952, 526);
            this.materialTabControlMainWindow.TabIndex = 0;
            // 
            // tabPageDevelop
            // 
            this.tabPageDevelop.BackColor = System.Drawing.Color.White;
            this.tabPageDevelop.Controls.Add(this.materialTabControlDev);
            this.tabPageDevelop.Controls.Add(this.materialTabSelector1);
            this.tabPageDevelop.Controls.Add(this.materialListBoxData);
            this.tabPageDevelop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageDevelop.ImageKey = "file-document-edit-outline.png";
            this.tabPageDevelop.Location = new System.Drawing.Point(4, 39);
            this.tabPageDevelop.Name = "tabPageDevelop";
            this.tabPageDevelop.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDevelop.Size = new System.Drawing.Size(944, 483);
            this.tabPageDevelop.TabIndex = 0;
            this.tabPageDevelop.Text = "Исходые данные";
            // 
            // materialTabControlDev
            // 
            this.materialTabControlDev.Controls.Add(this.tabPageAuto);
            this.materialTabControlDev.Controls.Add(this.tabPageHandle);
            this.materialTabControlDev.Depth = 0;
            this.materialTabControlDev.ItemSize = new System.Drawing.Size(240, 18);
            this.materialTabControlDev.Location = new System.Drawing.Point(66, 45);
            this.materialTabControlDev.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControlDev.Multiline = true;
            this.materialTabControlDev.Name = "materialTabControlDev";
            this.materialTabControlDev.SelectedIndex = 0;
            this.materialTabControlDev.Size = new System.Drawing.Size(485, 375);
            this.materialTabControlDev.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.materialTabControlDev.TabIndex = 9;
            // 
            // tabPageAuto
            // 
            this.tabPageAuto.Controls.Add(this.materialProgressBarDev);
            this.tabPageAuto.Controls.Add(this.materialCardAuto);
            this.tabPageAuto.ImageKey = "refresh-auto.png";
            this.tabPageAuto.Location = new System.Drawing.Point(4, 22);
            this.tabPageAuto.Name = "tabPageAuto";
            this.tabPageAuto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAuto.Size = new System.Drawing.Size(477, 349);
            this.tabPageAuto.TabIndex = 0;
            this.tabPageAuto.Text = "Генератор слов";
            this.tabPageAuto.UseVisualStyleBackColor = true;
            // 
            // materialProgressBarDev
            // 
            this.materialProgressBarDev.Depth = 0;
            this.materialProgressBarDev.Location = new System.Drawing.Point(19, 321);
            this.materialProgressBarDev.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBarDev.Name = "materialProgressBarDev";
            this.materialProgressBarDev.Size = new System.Drawing.Size(442, 5);
            this.materialProgressBarDev.TabIndex = 8;
            // 
            // materialCardAuto
            // 
            this.materialCardAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardAuto.Controls.Add(this.materialCheckboxGenerated);
            this.materialCardAuto.Controls.Add(this.materialButtonClear);
            this.materialCardAuto.Controls.Add(this.materialCheckboxUppers);
            this.materialCardAuto.Controls.Add(this.materialCheckboxSymbols);
            this.materialCardAuto.Controls.Add(this.materialSliderLenght);
            this.materialCardAuto.Controls.Add(this.materialSliderCount);
            this.materialCardAuto.Controls.Add(this.materialButtonGenerate);
            this.materialCardAuto.Depth = 0;
            this.materialCardAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardAuto.Location = new System.Drawing.Point(3, 0);
            this.materialCardAuto.Margin = new System.Windows.Forms.Padding(14);
            this.materialCardAuto.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardAuto.Name = "materialCardAuto";
            this.materialCardAuto.Padding = new System.Windows.Forms.Padding(14);
            this.materialCardAuto.Size = new System.Drawing.Size(477, 310);
            this.materialCardAuto.TabIndex = 7;
            // 
            // materialCheckboxGenerated
            // 
            this.materialCheckboxGenerated.Checked = true;
            this.materialCheckboxGenerated.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckboxGenerated.Depth = 0;
            this.materialCheckboxGenerated.Location = new System.Drawing.Point(165, 259);
            this.materialCheckboxGenerated.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckboxGenerated.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckboxGenerated.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckboxGenerated.Name = "materialCheckboxGenerated";
            this.materialCheckboxGenerated.ReadOnly = true;
            this.materialCheckboxGenerated.Ripple = true;
            this.materialCheckboxGenerated.Size = new System.Drawing.Size(37, 29);
            this.materialCheckboxGenerated.TabIndex = 7;
            this.materialCheckboxGenerated.UseVisualStyleBackColor = true;
            // 
            // materialButtonClear
            // 
            this.materialButtonClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonClear.Depth = 0;
            this.materialButtonClear.HighEmphasis = true;
            this.materialButtonClear.Icon = null;
            this.materialButtonClear.Location = new System.Drawing.Point(368, 259);
            this.materialButtonClear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonClear.Name = "materialButtonClear";
            this.materialButtonClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonClear.Size = new System.Drawing.Size(99, 36);
            this.materialButtonClear.TabIndex = 6;
            this.materialButtonClear.Text = "Очистить";
            this.materialButtonClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButtonClear.UseAccentColor = false;
            this.materialButtonClear.UseVisualStyleBackColor = true;
            this.materialButtonClear.Click += new System.EventHandler(this.materialButtonClear_Click);
            // 
            // materialCheckboxUppers
            // 
            this.materialCheckboxUppers.Depth = 0;
            this.materialCheckboxUppers.Location = new System.Drawing.Point(9, 198);
            this.materialCheckboxUppers.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckboxUppers.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckboxUppers.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckboxUppers.Name = "materialCheckboxUppers";
            this.materialCheckboxUppers.ReadOnly = false;
            this.materialCheckboxUppers.Ripple = true;
            this.materialCheckboxUppers.Size = new System.Drawing.Size(348, 37);
            this.materialCheckboxUppers.TabIndex = 5;
            this.materialCheckboxUppers.Text = "Использовать верхний регистр";
            this.materialCheckboxUppers.UseVisualStyleBackColor = true;
            // 
            // materialCheckboxSymbols
            // 
            this.materialCheckboxSymbols.Depth = 0;
            this.materialCheckboxSymbols.Location = new System.Drawing.Point(9, 147);
            this.materialCheckboxSymbols.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckboxSymbols.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckboxSymbols.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckboxSymbols.Name = "materialCheckboxSymbols";
            this.materialCheckboxSymbols.ReadOnly = false;
            this.materialCheckboxSymbols.Ripple = true;
            this.materialCheckboxSymbols.Size = new System.Drawing.Size(220, 37);
            this.materialCheckboxSymbols.TabIndex = 4;
            this.materialCheckboxSymbols.Text = "Специальные символы";
            this.materialCheckboxSymbols.UseVisualStyleBackColor = true;
            // 
            // materialSliderLenght
            // 
            this.materialSliderLenght.Depth = 0;
            this.materialSliderLenght.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSliderLenght.Location = new System.Drawing.Point(16, 86);
            this.materialSliderLenght.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSliderLenght.Name = "materialSliderLenght";
            this.materialSliderLenght.Size = new System.Drawing.Size(443, 40);
            this.materialSliderLenght.TabIndex = 3;
            this.materialSliderLenght.Text = "Длина           ";
            this.materialSliderLenght.Value = 1;
            this.materialSliderLenght.ValueMax = 100;
            this.materialSliderLenght.ValueSuffix = " сим.";
            // 
            // materialSliderCount
            // 
            this.materialSliderCount.Depth = 0;
            this.materialSliderCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSliderCount.Location = new System.Drawing.Point(16, 29);
            this.materialSliderCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSliderCount.Name = "materialSliderCount";
            this.materialSliderCount.RangeMax = 10000;
            this.materialSliderCount.Size = new System.Drawing.Size(443, 40);
            this.materialSliderCount.TabIndex = 2;
            this.materialSliderCount.Text = "Количество ";
            this.materialSliderCount.Value = 1;
            this.materialSliderCount.ValueMax = 10000;
            this.materialSliderCount.ValueSuffix = "    ";
            // 
            // materialButtonGenerate
            // 
            this.materialButtonGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonGenerate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonGenerate.Depth = 0;
            this.materialButtonGenerate.HighEmphasis = true;
            this.materialButtonGenerate.Icon = null;
            this.materialButtonGenerate.Location = new System.Drawing.Point(9, 259);
            this.materialButtonGenerate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonGenerate.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonGenerate.Name = "materialButtonGenerate";
            this.materialButtonGenerate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonGenerate.Size = new System.Drawing.Size(143, 36);
            this.materialButtonGenerate.TabIndex = 1;
            this.materialButtonGenerate.Text = "Сгенерировать";
            this.materialButtonGenerate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonGenerate.UseAccentColor = false;
            this.materialButtonGenerate.UseVisualStyleBackColor = true;
            this.materialButtonGenerate.Click += new System.EventHandler(this.materialButtonGenerate_Click);
            // 
            // tabPageHandle
            // 
            this.tabPageHandle.Controls.Add(this.materialCardHandle);
            this.tabPageHandle.ImageKey = "gesture-tap.png";
            this.tabPageHandle.Location = new System.Drawing.Point(4, 22);
            this.tabPageHandle.Name = "tabPageHandle";
            this.tabPageHandle.Size = new System.Drawing.Size(477, 349);
            this.tabPageHandle.TabIndex = 1;
            this.tabPageHandle.Text = "Ручной ввод";
            this.tabPageHandle.UseVisualStyleBackColor = true;
            // 
            // materialCardHandle
            // 
            this.materialCardHandle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardHandle.Controls.Add(this.materialButtonDel);
            this.materialCardHandle.Controls.Add(this.materialLabelHandAdd);
            this.materialCardHandle.Controls.Add(this.materialLabelDel);
            this.materialCardHandle.Controls.Add(this.materialTextBoxHandAdd);
            this.materialCardHandle.Controls.Add(this.materialTextBoxDel);
            this.materialCardHandle.Controls.Add(this.materialButtonHandAdd);
            this.materialCardHandle.Depth = 0;
            this.materialCardHandle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardHandle.Location = new System.Drawing.Point(3, 0);
            this.materialCardHandle.Margin = new System.Windows.Forms.Padding(14);
            this.materialCardHandle.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardHandle.Name = "materialCardHandle";
            this.materialCardHandle.Padding = new System.Windows.Forms.Padding(14);
            this.materialCardHandle.Size = new System.Drawing.Size(477, 332);
            this.materialCardHandle.TabIndex = 8;
            // 
            // materialButtonDel
            // 
            this.materialButtonDel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonDel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonDel.Depth = 0;
            this.materialButtonDel.HighEmphasis = true;
            this.materialButtonDel.Icon = null;
            this.materialButtonDel.Location = new System.Drawing.Point(305, 232);
            this.materialButtonDel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonDel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonDel.Name = "materialButtonDel";
            this.materialButtonDel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonDel.Size = new System.Drawing.Size(91, 36);
            this.materialButtonDel.TabIndex = 5;
            this.materialButtonDel.Text = "Удалить";
            this.materialButtonDel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonDel.UseAccentColor = false;
            this.materialButtonDel.UseVisualStyleBackColor = true;
            this.materialButtonDel.Click += new System.EventHandler(this.materialButtonDel_Click);
            // 
            // materialLabelHandAdd
            // 
            this.materialLabelHandAdd.Depth = 0;
            this.materialLabelHandAdd.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelHandAdd.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabelHandAdd.Location = new System.Drawing.Point(16, 40);
            this.materialLabelHandAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelHandAdd.Name = "materialLabelHandAdd";
            this.materialLabelHandAdd.Size = new System.Drawing.Size(206, 42);
            this.materialLabelHandAdd.TabIndex = 1;
            this.materialLabelHandAdd.Text = "Добавить";
            this.materialLabelHandAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // materialLabelDel
            // 
            this.materialLabelDel.Depth = 0;
            this.materialLabelDel.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelDel.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabelDel.Location = new System.Drawing.Point(253, 40);
            this.materialLabelDel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelDel.Name = "materialLabelDel";
            this.materialLabelDel.Size = new System.Drawing.Size(206, 42);
            this.materialLabelDel.TabIndex = 4;
            this.materialLabelDel.Text = "Удалить";
            this.materialLabelDel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // materialTextBoxHandAdd
            // 
            this.materialTextBoxHandAdd.AnimateReadOnly = false;
            this.materialTextBoxHandAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxHandAdd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxHandAdd.Depth = 0;
            this.materialTextBoxHandAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxHandAdd.HideSelection = true;
            this.materialTextBoxHandAdd.Hint = "Введите значение";
            this.materialTextBoxHandAdd.LeadingIcon = null;
            this.materialTextBoxHandAdd.Location = new System.Drawing.Point(15, 134);
            this.materialTextBoxHandAdd.MaxLength = 32767;
            this.materialTextBoxHandAdd.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxHandAdd.Name = "materialTextBoxHandAdd";
            this.materialTextBoxHandAdd.PasswordChar = '\0';
            this.materialTextBoxHandAdd.PrefixSuffixText = "Введите значение";
            this.materialTextBoxHandAdd.ReadOnly = false;
            this.materialTextBoxHandAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxHandAdd.SelectedText = "";
            this.materialTextBoxHandAdd.SelectionLength = 0;
            this.materialTextBoxHandAdd.SelectionStart = 0;
            this.materialTextBoxHandAdd.ShortcutsEnabled = true;
            this.materialTextBoxHandAdd.Size = new System.Drawing.Size(207, 48);
            this.materialTextBoxHandAdd.TabIndex = 0;
            this.materialTextBoxHandAdd.TabStop = false;
            this.materialTextBoxHandAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.materialTextBoxHandAdd.TrailingIcon = null;
            this.materialTextBoxHandAdd.UseSystemPasswordChar = false;
            // 
            // materialTextBoxDel
            // 
            this.materialTextBoxDel.AnimateReadOnly = false;
            this.materialTextBoxDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxDel.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxDel.Depth = 0;
            this.materialTextBoxDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxDel.HideSelection = true;
            this.materialTextBoxDel.Hint = "Введите индекс";
            this.materialTextBoxDel.LeadingIcon = null;
            this.materialTextBoxDel.Location = new System.Drawing.Point(252, 134);
            this.materialTextBoxDel.MaxLength = 32767;
            this.materialTextBoxDel.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxDel.Name = "materialTextBoxDel";
            this.materialTextBoxDel.PasswordChar = '\0';
            this.materialTextBoxDel.PrefixSuffixText = null;
            this.materialTextBoxDel.ReadOnly = false;
            this.materialTextBoxDel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxDel.SelectedText = "";
            this.materialTextBoxDel.SelectionLength = 0;
            this.materialTextBoxDel.SelectionStart = 0;
            this.materialTextBoxDel.ShortcutsEnabled = true;
            this.materialTextBoxDel.Size = new System.Drawing.Size(207, 48);
            this.materialTextBoxDel.TabIndex = 3;
            this.materialTextBoxDel.TabStop = false;
            this.materialTextBoxDel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.materialTextBoxDel.TrailingIcon = null;
            this.materialTextBoxDel.UseSystemPasswordChar = false;
            // 
            // materialButtonHandAdd
            // 
            this.materialButtonHandAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonHandAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonHandAdd.Depth = 0;
            this.materialButtonHandAdd.HighEmphasis = true;
            this.materialButtonHandAdd.Icon = null;
            this.materialButtonHandAdd.Location = new System.Drawing.Point(68, 232);
            this.materialButtonHandAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonHandAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonHandAdd.Name = "materialButtonHandAdd";
            this.materialButtonHandAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonHandAdd.Size = new System.Drawing.Size(100, 36);
            this.materialButtonHandAdd.TabIndex = 2;
            this.materialButtonHandAdd.Text = "Добавить";
            this.materialButtonHandAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonHandAdd.UseAccentColor = false;
            this.materialButtonHandAdd.UseVisualStyleBackColor = true;
            this.materialButtonHandAdd.Click += new System.EventHandler(this.materialButtonHandAdd_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControlDev;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTabSelector1.Location = new System.Drawing.Point(122, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(371, 45);
            this.materialTabSelector1.TabIndex = 9;
            this.materialTabSelector1.Text = "materialTabSelectorDev";
            // 
            // materialListBoxData
            // 
            this.materialListBoxData.BackColor = System.Drawing.Color.White;
            this.materialListBoxData.BorderColor = System.Drawing.Color.LightGray;
            this.materialListBoxData.Depth = 0;
            this.materialListBoxData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialListBoxData.Location = new System.Drawing.Point(552, 6);
            this.materialListBoxData.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialListBoxData.MultiSelect = true;
            this.materialListBoxData.Name = "materialListBoxData";
            this.materialListBoxData.SelectedIndex = -1;
            this.materialListBoxData.SelectedItem = null;
            this.materialListBoxData.Size = new System.Drawing.Size(243, 373);
            this.materialListBoxData.TabIndex = 9;
            // 
            // tabPageCharts
            // 
            this.tabPageCharts.BackColor = System.Drawing.Color.White;
            this.tabPageCharts.Controls.Add(this.materialProgressBarStat);
            this.tabPageCharts.Controls.Add(this.materialCardHandleSearch);
            this.tabPageCharts.Controls.Add(this.materialCardLinealSearch);
            this.tabPageCharts.Controls.Add(this.materialCardBinarySearch);
            this.tabPageCharts.Controls.Add(this.materialComboBoxSelect);
            this.tabPageCharts.Controls.Add(this.materialCheckboxRefresh);
            this.tabPageCharts.ImageKey = "chart-line.png";
            this.tabPageCharts.Location = new System.Drawing.Point(4, 39);
            this.tabPageCharts.Name = "tabPageCharts";
            this.tabPageCharts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCharts.Size = new System.Drawing.Size(944, 483);
            this.tabPageCharts.TabIndex = 1;
            this.tabPageCharts.Text = "Статистика";
            // 
            // materialProgressBarStat
            // 
            this.materialProgressBarStat.Depth = 0;
            this.materialProgressBarStat.Location = new System.Drawing.Point(633, 22);
            this.materialProgressBarStat.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBarStat.Name = "materialProgressBarStat";
            this.materialProgressBarStat.Size = new System.Drawing.Size(146, 5);
            this.materialProgressBarStat.TabIndex = 10;
            // 
            // materialCardHandleSearch
            // 
            this.materialCardHandleSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardHandleSearch.Controls.Add(this.materialTextBoxHandleQuestion);
            this.materialCardHandleSearch.Controls.Add(this.materialComboBoxHandleSeach);
            this.materialCardHandleSearch.Controls.Add(this.materialTextBoxHandleFindWord);
            this.materialCardHandleSearch.Controls.Add(this.materialTextBoxHandleTime);
            this.materialCardHandleSearch.Controls.Add(this.materialTextBoxHandleIterCount);
            this.materialCardHandleSearch.Controls.Add(this.materialButtonHandleSearch);
            this.materialCardHandleSearch.Depth = 0;
            this.materialCardHandleSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardHandleSearch.Location = new System.Drawing.Point(69, 48);
            this.materialCardHandleSearch.Margin = new System.Windows.Forms.Padding(14);
            this.materialCardHandleSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardHandleSearch.Name = "materialCardHandleSearch";
            this.materialCardHandleSearch.Padding = new System.Windows.Forms.Padding(14);
            this.materialCardHandleSearch.Size = new System.Drawing.Size(725, 330);
            this.materialCardHandleSearch.TabIndex = 9;
            this.materialCardHandleSearch.Visible = false;
            // 
            // materialTextBoxHandleQuestion
            // 
            this.materialTextBoxHandleQuestion.AnimateReadOnly = true;
            this.materialTextBoxHandleQuestion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxHandleQuestion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxHandleQuestion.Depth = 0;
            this.materialTextBoxHandleQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxHandleQuestion.HideSelection = true;
            this.materialTextBoxHandleQuestion.Hint = "Найден?";
            this.materialTextBoxHandleQuestion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialTextBoxHandleQuestion.LeadingIcon = null;
            this.materialTextBoxHandleQuestion.Location = new System.Drawing.Point(302, 81);
            this.materialTextBoxHandleQuestion.MaxLength = 32767;
            this.materialTextBoxHandleQuestion.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxHandleQuestion.Name = "materialTextBoxHandleQuestion";
            this.materialTextBoxHandleQuestion.PasswordChar = '\0';
            this.materialTextBoxHandleQuestion.PrefixSuffixText = null;
            this.materialTextBoxHandleQuestion.ReadOnly = true;
            this.materialTextBoxHandleQuestion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxHandleQuestion.SelectedText = "";
            this.materialTextBoxHandleQuestion.SelectionLength = 0;
            this.materialTextBoxHandleQuestion.SelectionStart = 0;
            this.materialTextBoxHandleQuestion.ShortcutsEnabled = true;
            this.materialTextBoxHandleQuestion.Size = new System.Drawing.Size(120, 48);
            this.materialTextBoxHandleQuestion.TabIndex = 9;
            this.materialTextBoxHandleQuestion.TabStop = false;
            this.materialTextBoxHandleQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxHandleQuestion.TrailingIcon = null;
            this.materialTextBoxHandleQuestion.UseSystemPasswordChar = false;
            // 
            // materialComboBoxHandleSeach
            // 
            this.materialComboBoxHandleSeach.AutoResize = false;
            this.materialComboBoxHandleSeach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxHandleSeach.Depth = 0;
            this.materialComboBoxHandleSeach.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxHandleSeach.DropDownHeight = 174;
            this.materialComboBoxHandleSeach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxHandleSeach.DropDownWidth = 121;
            this.materialComboBoxHandleSeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxHandleSeach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxHandleSeach.FormattingEnabled = true;
            this.materialComboBoxHandleSeach.Hint = "Выберите";
            this.materialComboBoxHandleSeach.IntegralHeight = false;
            this.materialComboBoxHandleSeach.ItemHeight = 43;
            this.materialComboBoxHandleSeach.Items.AddRange(new object[] { "Линейный поиск", "Бинарный поиск" });
            this.materialComboBoxHandleSeach.Location = new System.Drawing.Point(12, 48);
            this.materialComboBoxHandleSeach.MaxDropDownItems = 4;
            this.materialComboBoxHandleSeach.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxHandleSeach.Name = "materialComboBoxHandleSeach";
            this.materialComboBoxHandleSeach.Size = new System.Drawing.Size(238, 49);
            this.materialComboBoxHandleSeach.StartIndex = 0;
            this.materialComboBoxHandleSeach.TabIndex = 8;
            // 
            // materialTextBoxHandleFindWord
            // 
            this.materialTextBoxHandleFindWord.AnimateReadOnly = false;
            this.materialTextBoxHandleFindWord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxHandleFindWord.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxHandleFindWord.Depth = 0;
            this.materialTextBoxHandleFindWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxHandleFindWord.HideSelection = true;
            this.materialTextBoxHandleFindWord.Hint = "Введите значение";
            this.materialTextBoxHandleFindWord.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialTextBoxHandleFindWord.LeadingIcon = null;
            this.materialTextBoxHandleFindWord.Location = new System.Drawing.Point(12, 115);
            this.materialTextBoxHandleFindWord.MaxLength = 32767;
            this.materialTextBoxHandleFindWord.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxHandleFindWord.Name = "materialTextBoxHandleFindWord";
            this.materialTextBoxHandleFindWord.PasswordChar = '\0';
            this.materialTextBoxHandleFindWord.PrefixSuffixText = null;
            this.materialTextBoxHandleFindWord.ReadOnly = false;
            this.materialTextBoxHandleFindWord.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxHandleFindWord.SelectedText = "";
            this.materialTextBoxHandleFindWord.SelectionLength = 0;
            this.materialTextBoxHandleFindWord.SelectionStart = 0;
            this.materialTextBoxHandleFindWord.ShortcutsEnabled = true;
            this.materialTextBoxHandleFindWord.Size = new System.Drawing.Size(238, 48);
            this.materialTextBoxHandleFindWord.TabIndex = 7;
            this.materialTextBoxHandleFindWord.TabStop = false;
            this.materialTextBoxHandleFindWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxHandleFindWord.TrailingIcon = null;
            this.materialTextBoxHandleFindWord.UseSystemPasswordChar = false;
            // 
            // materialTextBoxHandleTime
            // 
            this.materialTextBoxHandleTime.AnimateReadOnly = true;
            this.materialTextBoxHandleTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxHandleTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxHandleTime.Depth = 0;
            this.materialTextBoxHandleTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxHandleTime.HideSelection = true;
            this.materialTextBoxHandleTime.Hint = "Время";
            this.materialTextBoxHandleTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialTextBoxHandleTime.LeadingIcon = null;
            this.materialTextBoxHandleTime.Location = new System.Drawing.Point(475, 115);
            this.materialTextBoxHandleTime.MaxLength = 32767;
            this.materialTextBoxHandleTime.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxHandleTime.Name = "materialTextBoxHandleTime";
            this.materialTextBoxHandleTime.PasswordChar = '\0';
            this.materialTextBoxHandleTime.PrefixSuffixText = null;
            this.materialTextBoxHandleTime.ReadOnly = true;
            this.materialTextBoxHandleTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxHandleTime.SelectedText = "";
            this.materialTextBoxHandleTime.SelectionLength = 0;
            this.materialTextBoxHandleTime.SelectionStart = 0;
            this.materialTextBoxHandleTime.ShortcutsEnabled = true;
            this.materialTextBoxHandleTime.Size = new System.Drawing.Size(238, 48);
            this.materialTextBoxHandleTime.TabIndex = 6;
            this.materialTextBoxHandleTime.TabStop = false;
            this.materialTextBoxHandleTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxHandleTime.TrailingIcon = null;
            this.materialTextBoxHandleTime.UseSystemPasswordChar = false;
            // 
            // materialTextBoxHandleIterCount
            // 
            this.materialTextBoxHandleIterCount.AnimateReadOnly = true;
            this.materialTextBoxHandleIterCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxHandleIterCount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxHandleIterCount.Depth = 0;
            this.materialTextBoxHandleIterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxHandleIterCount.HideSelection = true;
            this.materialTextBoxHandleIterCount.Hint = "Количество итераций";
            this.materialTextBoxHandleIterCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialTextBoxHandleIterCount.LeadingIcon = null;
            this.materialTextBoxHandleIterCount.Location = new System.Drawing.Point(475, 48);
            this.materialTextBoxHandleIterCount.MaxLength = 32767;
            this.materialTextBoxHandleIterCount.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxHandleIterCount.Name = "materialTextBoxHandleIterCount";
            this.materialTextBoxHandleIterCount.PasswordChar = '\0';
            this.materialTextBoxHandleIterCount.PrefixSuffixText = null;
            this.materialTextBoxHandleIterCount.ReadOnly = true;
            this.materialTextBoxHandleIterCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxHandleIterCount.SelectedText = "";
            this.materialTextBoxHandleIterCount.SelectionLength = 0;
            this.materialTextBoxHandleIterCount.SelectionStart = 0;
            this.materialTextBoxHandleIterCount.ShortcutsEnabled = true;
            this.materialTextBoxHandleIterCount.Size = new System.Drawing.Size(238, 48);
            this.materialTextBoxHandleIterCount.TabIndex = 2;
            this.materialTextBoxHandleIterCount.TabStop = false;
            this.materialTextBoxHandleIterCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxHandleIterCount.TrailingIcon = null;
            this.materialTextBoxHandleIterCount.UseSystemPasswordChar = false;
            // 
            // materialButtonHandleSearch
            // 
            this.materialButtonHandleSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonHandleSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonHandleSearch.Depth = 0;
            this.materialButtonHandleSearch.HighEmphasis = true;
            this.materialButtonHandleSearch.Icon = null;
            this.materialButtonHandleSearch.Location = new System.Drawing.Point(325, 228);
            this.materialButtonHandleSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonHandleSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonHandleSearch.Name = "materialButtonHandleSearch";
            this.materialButtonHandleSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonHandleSearch.Size = new System.Drawing.Size(71, 36);
            this.materialButtonHandleSearch.TabIndex = 1;
            this.materialButtonHandleSearch.Text = "Найти";
            this.materialButtonHandleSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonHandleSearch.UseAccentColor = false;
            this.materialButtonHandleSearch.UseVisualStyleBackColor = true;
            this.materialButtonHandleSearch.Click += new System.EventHandler(this.materialButtonHandleSearch_Click);
            // 
            // materialCardLinealSearch
            // 
            this.materialCardLinealSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardLinealSearch.Controls.Add(this.materialCheckboxLinealCount);
            this.materialCardLinealSearch.Controls.Add(this.materialCheckboxLinealTime);
            this.materialCardLinealSearch.Controls.Add(this.materialTextBoxLinealTotalTime);
            this.materialCardLinealSearch.Controls.Add(this.materialTextBoxLinealMaxTime);
            this.materialCardLinealSearch.Controls.Add(this.materialTextBoxLinealMinTime);
            this.materialCardLinealSearch.Controls.Add(this.materialTextBoxLinealIterCount);
            this.materialCardLinealSearch.Controls.Add(this.materialButtonLinealRefresh);
            this.materialCardLinealSearch.Controls.Add(this.chartLineal);
            this.materialCardLinealSearch.Depth = 0;
            this.materialCardLinealSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardLinealSearch.Location = new System.Drawing.Point(69, 48);
            this.materialCardLinealSearch.Margin = new System.Windows.Forms.Padding(14);
            this.materialCardLinealSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardLinealSearch.Name = "materialCardLinealSearch";
            this.materialCardLinealSearch.Padding = new System.Windows.Forms.Padding(14);
            this.materialCardLinealSearch.Size = new System.Drawing.Size(725, 330);
            this.materialCardLinealSearch.TabIndex = 2;
            // 
            // materialCheckboxLinealCount
            // 
            this.materialCheckboxLinealCount.Checked = true;
            this.materialCheckboxLinealCount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckboxLinealCount.Depth = 0;
            this.materialCheckboxLinealCount.Location = new System.Drawing.Point(567, 238);
            this.materialCheckboxLinealCount.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckboxLinealCount.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckboxLinealCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckboxLinealCount.Name = "materialCheckboxLinealCount";
            this.materialCheckboxLinealCount.ReadOnly = false;
            this.materialCheckboxLinealCount.Ripple = true;
            this.materialCheckboxLinealCount.Size = new System.Drawing.Size(146, 37);
            this.materialCheckboxLinealCount.TabIndex = 8;
            this.materialCheckboxLinealCount.Text = "Количество";
            this.materialCheckboxLinealCount.UseVisualStyleBackColor = true;
            this.materialCheckboxLinealCount.CheckedChanged += new System.EventHandler(this.materialCheckboxLinealCount_CheckedChanged);
            // 
            // materialCheckboxLinealTime
            // 
            this.materialCheckboxLinealTime.Checked = true;
            this.materialCheckboxLinealTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckboxLinealTime.Depth = 0;
            this.materialCheckboxLinealTime.Location = new System.Drawing.Point(463, 238);
            this.materialCheckboxLinealTime.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckboxLinealTime.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckboxLinealTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckboxLinealTime.Name = "materialCheckboxLinealTime";
            this.materialCheckboxLinealTime.ReadOnly = false;
            this.materialCheckboxLinealTime.Ripple = true;
            this.materialCheckboxLinealTime.Size = new System.Drawing.Size(104, 37);
            this.materialCheckboxLinealTime.TabIndex = 7;
            this.materialCheckboxLinealTime.Text = "Время";
            this.materialCheckboxLinealTime.UseVisualStyleBackColor = true;
            this.materialCheckboxLinealTime.CheckedChanged += new System.EventHandler(this.materialCheckboxLinealTime_CheckedChanged);
            // 
            // materialTextBoxLinealTotalTime
            // 
            this.materialTextBoxLinealTotalTime.AnimateReadOnly = true;
            this.materialTextBoxLinealTotalTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxLinealTotalTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxLinealTotalTime.Depth = 0;
            this.materialTextBoxLinealTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxLinealTotalTime.HideSelection = true;
            this.materialTextBoxLinealTotalTime.Hint = "Общее время";
            this.materialTextBoxLinealTotalTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialTextBoxLinealTotalTime.LeadingIcon = null;
            this.materialTextBoxLinealTotalTime.Location = new System.Drawing.Point(464, 179);
            this.materialTextBoxLinealTotalTime.MaxLength = 32767;
            this.materialTextBoxLinealTotalTime.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxLinealTotalTime.Name = "materialTextBoxLinealTotalTime";
            this.materialTextBoxLinealTotalTime.PasswordChar = '\0';
            this.materialTextBoxLinealTotalTime.PrefixSuffixText = null;
            this.materialTextBoxLinealTotalTime.ReadOnly = true;
            this.materialTextBoxLinealTotalTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxLinealTotalTime.SelectedText = "";
            this.materialTextBoxLinealTotalTime.SelectionLength = 0;
            this.materialTextBoxLinealTotalTime.SelectionStart = 0;
            this.materialTextBoxLinealTotalTime.ShortcutsEnabled = true;
            this.materialTextBoxLinealTotalTime.Size = new System.Drawing.Size(250, 48);
            this.materialTextBoxLinealTotalTime.TabIndex = 6;
            this.materialTextBoxLinealTotalTime.TabStop = false;
            this.materialTextBoxLinealTotalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxLinealTotalTime.TrailingIcon = null;
            this.materialTextBoxLinealTotalTime.UseSystemPasswordChar = false;
            // 
            // materialTextBoxLinealMaxTime
            // 
            this.materialTextBoxLinealMaxTime.AnimateReadOnly = true;
            this.materialTextBoxLinealMaxTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxLinealMaxTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxLinealMaxTime.Depth = 0;
            this.materialTextBoxLinealMaxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxLinealMaxTime.HideSelection = true;
            this.materialTextBoxLinealMaxTime.Hint = "Максимальное время";
            this.materialTextBoxLinealMaxTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialTextBoxLinealMaxTime.LeadingIcon = null;
            this.materialTextBoxLinealMaxTime.Location = new System.Drawing.Point(463, 125);
            this.materialTextBoxLinealMaxTime.MaxLength = 32767;
            this.materialTextBoxLinealMaxTime.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxLinealMaxTime.Name = "materialTextBoxLinealMaxTime";
            this.materialTextBoxLinealMaxTime.PasswordChar = '\0';
            this.materialTextBoxLinealMaxTime.PrefixSuffixText = null;
            this.materialTextBoxLinealMaxTime.ReadOnly = true;
            this.materialTextBoxLinealMaxTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxLinealMaxTime.SelectedText = "";
            this.materialTextBoxLinealMaxTime.SelectionLength = 0;
            this.materialTextBoxLinealMaxTime.SelectionStart = 0;
            this.materialTextBoxLinealMaxTime.ShortcutsEnabled = true;
            this.materialTextBoxLinealMaxTime.Size = new System.Drawing.Size(250, 48);
            this.materialTextBoxLinealMaxTime.TabIndex = 5;
            this.materialTextBoxLinealMaxTime.TabStop = false;
            this.materialTextBoxLinealMaxTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxLinealMaxTime.TrailingIcon = null;
            this.materialTextBoxLinealMaxTime.UseSystemPasswordChar = false;
            // 
            // materialTextBoxLinealMinTime
            // 
            this.materialTextBoxLinealMinTime.AnimateReadOnly = true;
            this.materialTextBoxLinealMinTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxLinealMinTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxLinealMinTime.Depth = 0;
            this.materialTextBoxLinealMinTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxLinealMinTime.HideSelection = true;
            this.materialTextBoxLinealMinTime.Hint = "Минимальное время";
            this.materialTextBoxLinealMinTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialTextBoxLinealMinTime.LeadingIcon = null;
            this.materialTextBoxLinealMinTime.Location = new System.Drawing.Point(463, 71);
            this.materialTextBoxLinealMinTime.MaxLength = 32767;
            this.materialTextBoxLinealMinTime.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxLinealMinTime.Name = "materialTextBoxLinealMinTime";
            this.materialTextBoxLinealMinTime.PasswordChar = '\0';
            this.materialTextBoxLinealMinTime.PrefixSuffixText = null;
            this.materialTextBoxLinealMinTime.ReadOnly = true;
            this.materialTextBoxLinealMinTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxLinealMinTime.SelectedText = "";
            this.materialTextBoxLinealMinTime.SelectionLength = 0;
            this.materialTextBoxLinealMinTime.SelectionStart = 0;
            this.materialTextBoxLinealMinTime.ShortcutsEnabled = true;
            this.materialTextBoxLinealMinTime.Size = new System.Drawing.Size(250, 48);
            this.materialTextBoxLinealMinTime.TabIndex = 3;
            this.materialTextBoxLinealMinTime.TabStop = false;
            this.materialTextBoxLinealMinTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxLinealMinTime.TrailingIcon = null;
            this.materialTextBoxLinealMinTime.UseSystemPasswordChar = false;
            // 
            // materialTextBoxLinealIterCount
            // 
            this.materialTextBoxLinealIterCount.AnimateReadOnly = true;
            this.materialTextBoxLinealIterCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxLinealIterCount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxLinealIterCount.Depth = 0;
            this.materialTextBoxLinealIterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxLinealIterCount.HideSelection = true;
            this.materialTextBoxLinealIterCount.Hint = "Количество итераций";
            this.materialTextBoxLinealIterCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialTextBoxLinealIterCount.LeadingIcon = null;
            this.materialTextBoxLinealIterCount.Location = new System.Drawing.Point(463, 17);
            this.materialTextBoxLinealIterCount.MaxLength = 32767;
            this.materialTextBoxLinealIterCount.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxLinealIterCount.Name = "materialTextBoxLinealIterCount";
            this.materialTextBoxLinealIterCount.PasswordChar = '\0';
            this.materialTextBoxLinealIterCount.PrefixSuffixText = null;
            this.materialTextBoxLinealIterCount.ReadOnly = true;
            this.materialTextBoxLinealIterCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxLinealIterCount.SelectedText = "";
            this.materialTextBoxLinealIterCount.SelectionLength = 0;
            this.materialTextBoxLinealIterCount.SelectionStart = 0;
            this.materialTextBoxLinealIterCount.ShortcutsEnabled = true;
            this.materialTextBoxLinealIterCount.Size = new System.Drawing.Size(250, 48);
            this.materialTextBoxLinealIterCount.TabIndex = 2;
            this.materialTextBoxLinealIterCount.TabStop = false;
            this.materialTextBoxLinealIterCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxLinealIterCount.TrailingIcon = null;
            this.materialTextBoxLinealIterCount.UseSystemPasswordChar = false;
            // 
            // materialButtonLinealRefresh
            // 
            this.materialButtonLinealRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonLinealRefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonLinealRefresh.Depth = 0;
            this.materialButtonLinealRefresh.HighEmphasis = true;
            this.materialButtonLinealRefresh.Icon = null;
            this.materialButtonLinealRefresh.Location = new System.Drawing.Point(529, 281);
            this.materialButtonLinealRefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonLinealRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonLinealRefresh.Name = "materialButtonLinealRefresh";
            this.materialButtonLinealRefresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonLinealRefresh.Size = new System.Drawing.Size(120, 36);
            this.materialButtonLinealRefresh.TabIndex = 1;
            this.materialButtonLinealRefresh.Text = "Подсчитать";
            this.materialButtonLinealRefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonLinealRefresh.UseAccentColor = false;
            this.materialButtonLinealRefresh.UseVisualStyleBackColor = true;
            this.materialButtonLinealRefresh.Click += new System.EventHandler(this.materialButtonLinealRefresh_Click);
            // 
            // chartLineal
            // 
            chartArea1.Name = "ChartArea1";
            this.chartLineal.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.IsDockedInsideChartArea = false;
            legend1.MaximumAutoSize = 20F;
            legend1.Name = "LegendLineal";
            legend1.Title = "Скорость линейного поиска";
            this.chartLineal.Legends.Add(legend1);
            this.chartLineal.Location = new System.Drawing.Point(-13, 0);
            this.chartLineal.Name = "chartLineal";
            this.chartLineal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "LegendLineal";
            series1.MarkerBorderWidth = 3;
            series1.MarkerSize = 1;
            series1.Name = "Время";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "LegendLineal";
            series2.Name = "Количество операций";
            this.chartLineal.Series.Add(series1);
            this.chartLineal.Series.Add(series2);
            this.chartLineal.Size = new System.Drawing.Size(471, 352);
            this.chartLineal.TabIndex = 0;
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title1.Name = "Скорость линейного поиска";
            this.chartLineal.Titles.Add(title1);
            // 
            // materialCardBinarySearch
            // 
            this.materialCardBinarySearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardBinarySearch.Controls.Add(this.materialCheckboxBinaryCount);
            this.materialCardBinarySearch.Controls.Add(this.materialCheckboxBinaryTime);
            this.materialCardBinarySearch.Controls.Add(this.materialTextBoxBinaryTotalTime);
            this.materialCardBinarySearch.Controls.Add(this.materialTextBoxBinaryMaxTime);
            this.materialCardBinarySearch.Controls.Add(this.materialTextBoxBinaryMinTime);
            this.materialCardBinarySearch.Controls.Add(this.materialTextBoxBinaryIterCount);
            this.materialCardBinarySearch.Controls.Add(this.materialButtonBinaryRefresh);
            this.materialCardBinarySearch.Controls.Add(this.chartBinary);
            this.materialCardBinarySearch.Depth = 0;
            this.materialCardBinarySearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardBinarySearch.Location = new System.Drawing.Point(69, 48);
            this.materialCardBinarySearch.Margin = new System.Windows.Forms.Padding(14);
            this.materialCardBinarySearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardBinarySearch.Name = "materialCardBinarySearch";
            this.materialCardBinarySearch.Padding = new System.Windows.Forms.Padding(14);
            this.materialCardBinarySearch.Size = new System.Drawing.Size(725, 330);
            this.materialCardBinarySearch.TabIndex = 7;
            this.materialCardBinarySearch.Visible = false;
            // 
            // materialCheckboxBinaryCount
            // 
            this.materialCheckboxBinaryCount.Checked = true;
            this.materialCheckboxBinaryCount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckboxBinaryCount.Depth = 0;
            this.materialCheckboxBinaryCount.Location = new System.Drawing.Point(567, 238);
            this.materialCheckboxBinaryCount.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckboxBinaryCount.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckboxBinaryCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckboxBinaryCount.Name = "materialCheckboxBinaryCount";
            this.materialCheckboxBinaryCount.ReadOnly = false;
            this.materialCheckboxBinaryCount.Ripple = true;
            this.materialCheckboxBinaryCount.Size = new System.Drawing.Size(146, 37);
            this.materialCheckboxBinaryCount.TabIndex = 11;
            this.materialCheckboxBinaryCount.Text = "Количество";
            this.materialCheckboxBinaryCount.UseVisualStyleBackColor = true;
            this.materialCheckboxBinaryCount.CheckedChanged += new System.EventHandler(this.materialCheckboxBinaryCount_CheckedChanged);
            // 
            // materialCheckboxBinaryTime
            // 
            this.materialCheckboxBinaryTime.Checked = true;
            this.materialCheckboxBinaryTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckboxBinaryTime.Depth = 0;
            this.materialCheckboxBinaryTime.Location = new System.Drawing.Point(463, 238);
            this.materialCheckboxBinaryTime.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckboxBinaryTime.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckboxBinaryTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckboxBinaryTime.Name = "materialCheckboxBinaryTime";
            this.materialCheckboxBinaryTime.ReadOnly = false;
            this.materialCheckboxBinaryTime.Ripple = true;
            this.materialCheckboxBinaryTime.Size = new System.Drawing.Size(104, 37);
            this.materialCheckboxBinaryTime.TabIndex = 10;
            this.materialCheckboxBinaryTime.Text = "Время";
            this.materialCheckboxBinaryTime.UseVisualStyleBackColor = true;
            this.materialCheckboxBinaryTime.CheckedChanged += new System.EventHandler(this.materialCheckboxBinaryTime_CheckedChanged);
            // 
            // materialTextBoxBinaryTotalTime
            // 
            this.materialTextBoxBinaryTotalTime.AnimateReadOnly = true;
            this.materialTextBoxBinaryTotalTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxBinaryTotalTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxBinaryTotalTime.Depth = 0;
            this.materialTextBoxBinaryTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxBinaryTotalTime.HideSelection = true;
            this.materialTextBoxBinaryTotalTime.Hint = "Общее время";
            this.materialTextBoxBinaryTotalTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialTextBoxBinaryTotalTime.LeadingIcon = null;
            this.materialTextBoxBinaryTotalTime.Location = new System.Drawing.Point(464, 179);
            this.materialTextBoxBinaryTotalTime.MaxLength = 32767;
            this.materialTextBoxBinaryTotalTime.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxBinaryTotalTime.Name = "materialTextBoxBinaryTotalTime";
            this.materialTextBoxBinaryTotalTime.PasswordChar = '\0';
            this.materialTextBoxBinaryTotalTime.PrefixSuffixText = null;
            this.materialTextBoxBinaryTotalTime.ReadOnly = true;
            this.materialTextBoxBinaryTotalTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxBinaryTotalTime.SelectedText = "";
            this.materialTextBoxBinaryTotalTime.SelectionLength = 0;
            this.materialTextBoxBinaryTotalTime.SelectionStart = 0;
            this.materialTextBoxBinaryTotalTime.ShortcutsEnabled = true;
            this.materialTextBoxBinaryTotalTime.Size = new System.Drawing.Size(250, 48);
            this.materialTextBoxBinaryTotalTime.TabIndex = 6;
            this.materialTextBoxBinaryTotalTime.TabStop = false;
            this.materialTextBoxBinaryTotalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxBinaryTotalTime.TrailingIcon = null;
            this.materialTextBoxBinaryTotalTime.UseSystemPasswordChar = false;
            // 
            // materialTextBoxBinaryMaxTime
            // 
            this.materialTextBoxBinaryMaxTime.AnimateReadOnly = true;
            this.materialTextBoxBinaryMaxTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxBinaryMaxTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxBinaryMaxTime.Depth = 0;
            this.materialTextBoxBinaryMaxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxBinaryMaxTime.HideSelection = true;
            this.materialTextBoxBinaryMaxTime.Hint = "Максимальное время";
            this.materialTextBoxBinaryMaxTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialTextBoxBinaryMaxTime.LeadingIcon = null;
            this.materialTextBoxBinaryMaxTime.Location = new System.Drawing.Point(463, 125);
            this.materialTextBoxBinaryMaxTime.MaxLength = 32767;
            this.materialTextBoxBinaryMaxTime.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxBinaryMaxTime.Name = "materialTextBoxBinaryMaxTime";
            this.materialTextBoxBinaryMaxTime.PasswordChar = '\0';
            this.materialTextBoxBinaryMaxTime.PrefixSuffixText = null;
            this.materialTextBoxBinaryMaxTime.ReadOnly = true;
            this.materialTextBoxBinaryMaxTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxBinaryMaxTime.SelectedText = "";
            this.materialTextBoxBinaryMaxTime.SelectionLength = 0;
            this.materialTextBoxBinaryMaxTime.SelectionStart = 0;
            this.materialTextBoxBinaryMaxTime.ShortcutsEnabled = true;
            this.materialTextBoxBinaryMaxTime.Size = new System.Drawing.Size(250, 48);
            this.materialTextBoxBinaryMaxTime.TabIndex = 5;
            this.materialTextBoxBinaryMaxTime.TabStop = false;
            this.materialTextBoxBinaryMaxTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxBinaryMaxTime.TrailingIcon = null;
            this.materialTextBoxBinaryMaxTime.UseSystemPasswordChar = false;
            // 
            // materialTextBoxBinaryMinTime
            // 
            this.materialTextBoxBinaryMinTime.AnimateReadOnly = true;
            this.materialTextBoxBinaryMinTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxBinaryMinTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxBinaryMinTime.Depth = 0;
            this.materialTextBoxBinaryMinTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxBinaryMinTime.HideSelection = true;
            this.materialTextBoxBinaryMinTime.Hint = "Минимальное время";
            this.materialTextBoxBinaryMinTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialTextBoxBinaryMinTime.LeadingIcon = null;
            this.materialTextBoxBinaryMinTime.Location = new System.Drawing.Point(463, 71);
            this.materialTextBoxBinaryMinTime.MaxLength = 32767;
            this.materialTextBoxBinaryMinTime.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxBinaryMinTime.Name = "materialTextBoxBinaryMinTime";
            this.materialTextBoxBinaryMinTime.PasswordChar = '\0';
            this.materialTextBoxBinaryMinTime.PrefixSuffixText = null;
            this.materialTextBoxBinaryMinTime.ReadOnly = true;
            this.materialTextBoxBinaryMinTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxBinaryMinTime.SelectedText = "";
            this.materialTextBoxBinaryMinTime.SelectionLength = 0;
            this.materialTextBoxBinaryMinTime.SelectionStart = 0;
            this.materialTextBoxBinaryMinTime.ShortcutsEnabled = true;
            this.materialTextBoxBinaryMinTime.Size = new System.Drawing.Size(250, 48);
            this.materialTextBoxBinaryMinTime.TabIndex = 3;
            this.materialTextBoxBinaryMinTime.TabStop = false;
            this.materialTextBoxBinaryMinTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxBinaryMinTime.TrailingIcon = null;
            this.materialTextBoxBinaryMinTime.UseSystemPasswordChar = false;
            // 
            // materialTextBoxBinaryIterCount
            // 
            this.materialTextBoxBinaryIterCount.AnimateReadOnly = true;
            this.materialTextBoxBinaryIterCount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.materialTextBoxBinaryIterCount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxBinaryIterCount.Depth = 0;
            this.materialTextBoxBinaryIterCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxBinaryIterCount.HideSelection = true;
            this.materialTextBoxBinaryIterCount.Hint = "Количество итераций";
            this.materialTextBoxBinaryIterCount.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.materialTextBoxBinaryIterCount.LeadingIcon = null;
            this.materialTextBoxBinaryIterCount.Location = new System.Drawing.Point(463, 17);
            this.materialTextBoxBinaryIterCount.MaxLength = 32767;
            this.materialTextBoxBinaryIterCount.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxBinaryIterCount.Name = "materialTextBoxBinaryIterCount";
            this.materialTextBoxBinaryIterCount.PasswordChar = '\0';
            this.materialTextBoxBinaryIterCount.PrefixSuffixText = null;
            this.materialTextBoxBinaryIterCount.ReadOnly = true;
            this.materialTextBoxBinaryIterCount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxBinaryIterCount.SelectedText = "";
            this.materialTextBoxBinaryIterCount.SelectionLength = 0;
            this.materialTextBoxBinaryIterCount.SelectionStart = 0;
            this.materialTextBoxBinaryIterCount.ShortcutsEnabled = true;
            this.materialTextBoxBinaryIterCount.Size = new System.Drawing.Size(250, 48);
            this.materialTextBoxBinaryIterCount.TabIndex = 2;
            this.materialTextBoxBinaryIterCount.TabStop = false;
            this.materialTextBoxBinaryIterCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxBinaryIterCount.TrailingIcon = null;
            this.materialTextBoxBinaryIterCount.UseSystemPasswordChar = false;
            // 
            // materialButtonBinaryRefresh
            // 
            this.materialButtonBinaryRefresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonBinaryRefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonBinaryRefresh.Depth = 0;
            this.materialButtonBinaryRefresh.HighEmphasis = true;
            this.materialButtonBinaryRefresh.Icon = null;
            this.materialButtonBinaryRefresh.Location = new System.Drawing.Point(529, 281);
            this.materialButtonBinaryRefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonBinaryRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonBinaryRefresh.Name = "materialButtonBinaryRefresh";
            this.materialButtonBinaryRefresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonBinaryRefresh.Size = new System.Drawing.Size(120, 36);
            this.materialButtonBinaryRefresh.TabIndex = 1;
            this.materialButtonBinaryRefresh.Text = "Подсчитать";
            this.materialButtonBinaryRefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonBinaryRefresh.UseAccentColor = false;
            this.materialButtonBinaryRefresh.UseVisualStyleBackColor = true;
            this.materialButtonBinaryRefresh.Click += new System.EventHandler(this.materialButtonBinaryRefresh_Click);
            // 
            // chartBinary
            // 
            chartArea2.Name = "ChartArea1";
            this.chartBinary.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.IsDockedInsideChartArea = false;
            legend2.MaximumAutoSize = 20F;
            legend2.Name = "LegendLineal";
            legend2.Title = "Скорость бинарного поиска";
            this.chartBinary.Legends.Add(legend2);
            this.chartBinary.Location = new System.Drawing.Point(-13, 0);
            this.chartBinary.Name = "chartBinary";
            this.chartBinary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "LegendLineal";
            series3.MarkerBorderWidth = 3;
            series3.MarkerSize = 1;
            series3.Name = "Время";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "LegendLineal";
            series4.Name = "Количество операций";
            this.chartBinary.Series.Add(series3);
            this.chartBinary.Series.Add(series4);
            this.chartBinary.Size = new System.Drawing.Size(471, 352);
            this.chartBinary.TabIndex = 0;
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title2.Name = "Скорость линейного поиска";
            this.chartBinary.Titles.Add(title2);
            // 
            // materialComboBoxSelect
            // 
            this.materialComboBoxSelect.AutoResize = false;
            this.materialComboBoxSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxSelect.Depth = 0;
            this.materialComboBoxSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxSelect.DropDownHeight = 118;
            this.materialComboBoxSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxSelect.DropDownWidth = 121;
            this.materialComboBoxSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxSelect.FormattingEnabled = true;
            this.materialComboBoxSelect.Hint = "Выберите";
            this.materialComboBoxSelect.IntegralHeight = false;
            this.materialComboBoxSelect.ItemHeight = 29;
            this.materialComboBoxSelect.Items.AddRange(new object[] { "Линейный поиск", "Бинарный поиск", "Единичный поиск" });
            this.materialComboBoxSelect.Location = new System.Drawing.Point(69, 6);
            this.materialComboBoxSelect.MaxDropDownItems = 4;
            this.materialComboBoxSelect.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxSelect.Name = "materialComboBoxSelect";
            this.materialComboBoxSelect.Size = new System.Drawing.Size(238, 35);
            this.materialComboBoxSelect.StartIndex = 0;
            this.materialComboBoxSelect.TabIndex = 3;
            this.materialComboBoxSelect.UseTallSize = false;
            this.materialComboBoxSelect.SelectedIndexChanged += new System.EventHandler(this.materialComboBoxSelect_SelectedIndexChanged);
            // 
            // materialCheckboxRefresh
            // 
            this.materialCheckboxRefresh.Depth = 0;
            this.materialCheckboxRefresh.Location = new System.Drawing.Point(329, 6);
            this.materialCheckboxRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckboxRefresh.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckboxRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckboxRefresh.Name = "materialCheckboxRefresh";
            this.materialCheckboxRefresh.ReadOnly = false;
            this.materialCheckboxRefresh.Ripple = true;
            this.materialCheckboxRefresh.Size = new System.Drawing.Size(292, 35);
            this.materialCheckboxRefresh.TabIndex = 1;
            this.materialCheckboxRefresh.Text = "Обновлять расчеты при выборе";
            this.materialCheckboxRefresh.UseVisualStyleBackColor = true;
            // 
            // tabPageSpec
            // 
            this.tabPageSpec.BackColor = System.Drawing.Color.White;
            this.tabPageSpec.Controls.Add(this.materialCard1);
            this.tabPageSpec.Controls.Add(this.materialCardSave);
            this.tabPageSpec.Controls.Add(this.materialSwitchTheme);
            this.tabPageSpec.ImageKey = "human-handsdown.png";
            this.tabPageSpec.Location = new System.Drawing.Point(4, 39);
            this.tabPageSpec.Name = "tabPageSpec";
            this.tabPageSpec.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSpec.Size = new System.Drawing.Size(944, 483);
            this.tabPageSpec.TabIndex = 2;
            this.tabPageSpec.Text = "Возможности";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabelSaveXlsx);
            this.materialCard1.Controls.Add(this.materialButtonSaveXlsx);
            this.materialCard1.Controls.Add(this.materialComboBoxSelectChartToXlsx);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(279, 197);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(510, 181);
            this.materialCard1.TabIndex = 5;
            // 
            // materialLabelSaveXlsx
            // 
            this.materialLabelSaveXlsx.Depth = 0;
            this.materialLabelSaveXlsx.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelSaveXlsx.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabelSaveXlsx.Location = new System.Drawing.Point(59, 14);
            this.materialLabelSaveXlsx.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelSaveXlsx.Name = "materialLabelSaveXlsx";
            this.materialLabelSaveXlsx.Size = new System.Drawing.Size(384, 40);
            this.materialLabelSaveXlsx.TabIndex = 3;
            this.materialLabelSaveXlsx.Text = "Выгрузить данные в XLSX";
            this.materialLabelSaveXlsx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialButtonSaveXlsx
            // 
            this.materialButtonSaveXlsx.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSaveXlsx.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSaveXlsx.Depth = 0;
            this.materialButtonSaveXlsx.HighEmphasis = true;
            this.materialButtonSaveXlsx.Icon = null;
            this.materialButtonSaveXlsx.Location = new System.Drawing.Point(340, 91);
            this.materialButtonSaveXlsx.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonSaveXlsx.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSaveXlsx.Name = "materialButtonSaveXlsx";
            this.materialButtonSaveXlsx.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSaveXlsx.Size = new System.Drawing.Size(109, 36);
            this.materialButtonSaveXlsx.TabIndex = 4;
            this.materialButtonSaveXlsx.Text = "Сохранить";
            this.materialButtonSaveXlsx.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSaveXlsx.UseAccentColor = false;
            this.materialButtonSaveXlsx.UseVisualStyleBackColor = true;
            this.materialButtonSaveXlsx.Click += new System.EventHandler(this.materialButtonSaveXlsx_Click);
            // 
            // materialComboBoxSelectChartToXlsx
            // 
            this.materialComboBoxSelectChartToXlsx.AutoResize = false;
            this.materialComboBoxSelectChartToXlsx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxSelectChartToXlsx.Depth = 0;
            this.materialComboBoxSelectChartToXlsx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxSelectChartToXlsx.DropDownHeight = 174;
            this.materialComboBoxSelectChartToXlsx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxSelectChartToXlsx.DropDownWidth = 121;
            this.materialComboBoxSelectChartToXlsx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxSelectChartToXlsx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxSelectChartToXlsx.FormattingEnabled = true;
            this.materialComboBoxSelectChartToXlsx.Hint = "Выберите график";
            this.materialComboBoxSelectChartToXlsx.IntegralHeight = false;
            this.materialComboBoxSelectChartToXlsx.ItemHeight = 43;
            this.materialComboBoxSelectChartToXlsx.Items.AddRange(new object[] { "Линейный", "Бинарный" });
            this.materialComboBoxSelectChartToXlsx.Location = new System.Drawing.Point(59, 78);
            this.materialComboBoxSelectChartToXlsx.MaxDropDownItems = 4;
            this.materialComboBoxSelectChartToXlsx.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxSelectChartToXlsx.Name = "materialComboBoxSelectChartToXlsx";
            this.materialComboBoxSelectChartToXlsx.Size = new System.Drawing.Size(196, 49);
            this.materialComboBoxSelectChartToXlsx.StartIndex = 0;
            this.materialComboBoxSelectChartToXlsx.TabIndex = 2;
            // 
            // materialCardSave
            // 
            this.materialCardSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardSave.Controls.Add(this.materialButtonSave);
            this.materialCardSave.Controls.Add(this.materialLabel3);
            this.materialCardSave.Controls.Add(this.materialComboBoxSelectChart);
            this.materialCardSave.Depth = 0;
            this.materialCardSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardSave.Location = new System.Drawing.Point(279, 9);
            this.materialCardSave.Margin = new System.Windows.Forms.Padding(14);
            this.materialCardSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardSave.Name = "materialCardSave";
            this.materialCardSave.Padding = new System.Windows.Forms.Padding(14);
            this.materialCardSave.Size = new System.Drawing.Size(510, 181);
            this.materialCardSave.TabIndex = 3;
            // 
            // materialButtonSave
            // 
            this.materialButtonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSave.Depth = 0;
            this.materialButtonSave.HighEmphasis = true;
            this.materialButtonSave.Icon = null;
            this.materialButtonSave.Location = new System.Drawing.Point(340, 91);
            this.materialButtonSave.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButtonSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSave.Name = "materialButtonSave";
            this.materialButtonSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSave.Size = new System.Drawing.Size(109, 36);
            this.materialButtonSave.TabIndex = 5;
            this.materialButtonSave.Text = "Сохранить";
            this.materialButtonSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSave.UseAccentColor = false;
            this.materialButtonSave.UseVisualStyleBackColor = true;
            this.materialButtonSave.Click += new System.EventHandler(this.materialButtonSave_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.Location = new System.Drawing.Point(92, 14);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(337, 40);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Сохранить график";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialComboBoxSelectChart
            // 
            this.materialComboBoxSelectChart.AutoResize = false;
            this.materialComboBoxSelectChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxSelectChart.Depth = 0;
            this.materialComboBoxSelectChart.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxSelectChart.DropDownHeight = 174;
            this.materialComboBoxSelectChart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxSelectChart.DropDownWidth = 121;
            this.materialComboBoxSelectChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxSelectChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxSelectChart.FormattingEnabled = true;
            this.materialComboBoxSelectChart.Hint = "Выберите график";
            this.materialComboBoxSelectChart.IntegralHeight = false;
            this.materialComboBoxSelectChart.ItemHeight = 43;
            this.materialComboBoxSelectChart.Items.AddRange(new object[] { "Линейный", "Бинарный" });
            this.materialComboBoxSelectChart.Location = new System.Drawing.Point(59, 78);
            this.materialComboBoxSelectChart.MaxDropDownItems = 4;
            this.materialComboBoxSelectChart.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxSelectChart.Name = "materialComboBoxSelectChart";
            this.materialComboBoxSelectChart.Size = new System.Drawing.Size(196, 49);
            this.materialComboBoxSelectChart.StartIndex = 0;
            this.materialComboBoxSelectChart.TabIndex = 2;
            // 
            // materialSwitchTheme
            // 
            this.materialSwitchTheme.Depth = 0;
            this.materialSwitchTheme.Location = new System.Drawing.Point(83, 17);
            this.materialSwitchTheme.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitchTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitchTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitchTheme.Name = "materialSwitchTheme";
            this.materialSwitchTheme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialSwitchTheme.Ripple = true;
            this.materialSwitchTheme.Size = new System.Drawing.Size(183, 47);
            this.materialSwitchTheme.TabIndex = 1;
            this.materialSwitchTheme.Text = " Тёмная тема";
            this.materialSwitchTheme.UseVisualStyleBackColor = true;
            this.materialSwitchTheme.CheckedChanged += new System.EventHandler(this.materialSwitchTheme_CheckedChanged);
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.BackColor = System.Drawing.Color.White;
            this.tabPageInfo.Controls.Add(this.linkLabelGitHub);
            this.tabPageInfo.Controls.Add(this.materialLabelSubject);
            this.tabPageInfo.Controls.Add(this.materialLabelKR);
            this.tabPageInfo.Controls.Add(this.materialLabelInfo);
            this.tabPageInfo.Controls.Add(this.pictureBoxInfoLogo);
            this.tabPageInfo.ImageKey = "information-outline.png";
            this.tabPageInfo.Location = new System.Drawing.Point(4, 39);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInfo.Size = new System.Drawing.Size(944, 483);
            this.tabPageInfo.TabIndex = 3;
            this.tabPageInfo.Text = "Справка";
            // 
            // linkLabelGitHub
            // 
            this.linkLabelGitHub.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabelGitHub.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabelGitHub.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.linkLabelGitHub.ImageKey = "github.png";
            this.linkLabelGitHub.ImageList = this.imageListGit;
            this.linkLabelGitHub.LinkColor = System.Drawing.Color.Black;
            this.linkLabelGitHub.Location = new System.Drawing.Point(423, 296);
            this.linkLabelGitHub.Name = "linkLabelGitHub";
            this.linkLabelGitHub.Size = new System.Drawing.Size(336, 58);
            this.linkLabelGitHub.TabIndex = 4;
            this.linkLabelGitHub.TabStop = true;
            this.linkLabelGitHub.Text = "Исходный код приложения на GitHub";
            this.linkLabelGitHub.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.linkLabelGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGitHub_LinkClicked);
            // 
            // imageListGit
            // 
            this.imageListGit.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListGit.ImageStream")));
            this.imageListGit.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListGit.Images.SetKeyName(0, "github.png");
            // 
            // materialLabelSubject
            // 
            this.materialLabelSubject.Depth = 0;
            this.materialLabelSubject.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelSubject.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabelSubject.Location = new System.Drawing.Point(423, 101);
            this.materialLabelSubject.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelSubject.Name = "materialLabelSubject";
            this.materialLabelSubject.Size = new System.Drawing.Size(336, 89);
            this.materialLabelSubject.TabIndex = 3;
            this.materialLabelSubject.Text = "Исследование линейного, индексного и линейного поисков";
            this.materialLabelSubject.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // materialLabelKR
            // 
            this.materialLabelKR.Depth = 0;
            this.materialLabelKR.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelKR.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabelKR.Location = new System.Drawing.Point(423, 43);
            this.materialLabelKR.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelKR.Name = "materialLabelKR";
            this.materialLabelKR.Size = new System.Drawing.Size(336, 58);
            this.materialLabelKR.TabIndex = 2;
            this.materialLabelKR.Text = "Курсовая работа";
            this.materialLabelKR.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // materialLabelInfo
            // 
            this.materialLabelInfo.Depth = 0;
            this.materialLabelInfo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelInfo.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabelInfo.Location = new System.Drawing.Point(423, 213);
            this.materialLabelInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelInfo.Name = "materialLabelInfo";
            this.materialLabelInfo.Size = new System.Drawing.Size(336, 66);
            this.materialLabelInfo.TabIndex = 1;
            this.materialLabelInfo.Text = "Выполнил: Соловьев Р,А,\r\nГруппа: 21-КБ-ПИ1\r\nКубГТУ 2022\r\n";
            this.materialLabelInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBoxInfoLogo
            // 
            this.pictureBoxInfoLogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxInfoLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxInfoLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxInfoLogo.Image")));
            this.pictureBoxInfoLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxInfoLogo.InitialImage")));
            this.pictureBoxInfoLogo.Location = new System.Drawing.Point(113, 54);
            this.pictureBoxInfoLogo.Name = "pictureBoxInfoLogo";
            this.pictureBoxInfoLogo.Size = new System.Drawing.Size(272, 260);
            this.pictureBoxInfoLogo.TabIndex = 0;
            this.pictureBoxInfoLogo.TabStop = false;
            // 
            // imageListMenu
            // 
            this.imageListMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMenu.ImageStream")));
            this.imageListMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMenu.Images.SetKeyName(0, "chart-line.png");
            this.imageListMenu.Images.SetKeyName(1, "human-handsdown.png");
            this.imageListMenu.Images.SetKeyName(2, "file-document-edit-outline.png");
            this.imageListMenu.Images.SetKeyName(3, "information-outline.png");
            // 
            // imageListSelector
            // 
            this.imageListSelector.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSelector.ImageStream")));
            this.imageListSelector.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSelector.Images.SetKeyName(0, "gesture-tap.png");
            this.imageListSelector.Images.SetKeyName(1, "refresh-auto.png");
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.materialTabControlMainWindow);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControlMainWindow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(801, 450);
            this.MinimumSize = new System.Drawing.Size(801, 450);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 3, 3);
            this.Sizable = false;
            this.Text = "Исследование поисков";
            this.materialTabControlMainWindow.ResumeLayout(false);
            this.tabPageDevelop.ResumeLayout(false);
            this.materialTabControlDev.ResumeLayout(false);
            this.tabPageAuto.ResumeLayout(false);
            this.materialCardAuto.ResumeLayout(false);
            this.materialCardAuto.PerformLayout();
            this.tabPageHandle.ResumeLayout(false);
            this.materialCardHandle.ResumeLayout(false);
            this.materialCardHandle.PerformLayout();
            this.tabPageCharts.ResumeLayout(false);
            this.materialCardHandleSearch.ResumeLayout(false);
            this.materialCardHandleSearch.PerformLayout();
            this.materialCardLinealSearch.ResumeLayout(false);
            this.materialCardLinealSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLineal)).EndInit();
            this.materialCardBinarySearch.ResumeLayout(false);
            this.materialCardBinarySearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBinary)).EndInit();
            this.tabPageSpec.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCardSave.ResumeLayout(false);
            this.materialCardSave.PerformLayout();
            this.tabPageInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoLogo)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ImageList imageListSelector;

        private MaterialSkin.Controls.MaterialCard materialCardHandle;

        private System.Windows.Forms.TabPage tabPageHandle;

        private MaterialSkin.Controls.MaterialTabControl materialTabControlDev;
        private System.Windows.Forms.TabPage tabPageAuto;

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;

        private MaterialSkin.Controls.MaterialListBox materialListBoxData;

        private MaterialSkin.Controls.MaterialProgressBar materialProgressBarStat;

        private MaterialSkin.Controls.MaterialProgressBar materialProgressBarDev;

        private MaterialSkin.Controls.MaterialCheckbox materialCheckboxGenerated;

        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxHandleQuestion;

        private MaterialSkin.Controls.MaterialComboBox materialComboBoxHandleSeach;

        private MaterialSkin.Controls.MaterialCard materialCardHandleSearch;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxHandleTime;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxHandleFindWord;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxHandleIterCount;
        private MaterialSkin.Controls.MaterialButton materialButtonHandleSearch;

        private MaterialSkin.Controls.MaterialCheckbox materialCheckboxBinaryCount;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckboxBinaryTime;

        private MaterialSkin.Controls.MaterialCheckbox materialCheckboxLinealTime;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckboxLinealCount;

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabelSaveXlsx;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxSelectChartToXlsx;

        private MaterialSkin.Controls.MaterialButton materialButtonSaveXlsx;

        private MaterialSkin.Controls.MaterialButton materialButtonSave;

        private MaterialSkin.Controls.MaterialComboBox materialComboBoxSelectChart;

        private MaterialSkin.Controls.MaterialCard materialCardSave;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;

        private MaterialSkin.Controls.MaterialCard materialCardBinarySearch;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxBinaryTotalTime;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxBinaryMaxTime;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxBinaryMinTime;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxBinaryIterCount;
        private MaterialSkin.Controls.MaterialButton materialButtonBinaryRefresh;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartBinary;

        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxLinealTotalTime;

        private MaterialSkin.Controls.MaterialButton materialButtonLinealRefresh;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxLinealIterCount;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxLinealMinTime;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxLinealMaxTime;

        private System.Windows.Forms.DataVisualization.Charting.Chart chartLineal;

        private MaterialSkin.Controls.MaterialComboBox materialComboBoxSelect;

        private MaterialSkin.Controls.MaterialCard materialCardLinealSearch;

        private MaterialSkin.Controls.MaterialCheckbox materialCheckboxRefresh;

        private MaterialSkin.Controls.MaterialButton materialButtonClear;

        private MaterialSkin.Controls.MaterialButton materialButtonHandAdd;

        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxHandAdd;
        private MaterialSkin.Controls.MaterialLabel materialLabelHandAdd;

        private MaterialSkin.Controls.MaterialButton materialButtonDel;

        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxDel;
        private MaterialSkin.Controls.MaterialLabel materialLabelDel;

        private MaterialSkin.Controls.MaterialCheckbox materialCheckboxUppers;

        private MaterialSkin.Controls.MaterialCheckbox materialCheckboxSymbols;

        private MaterialSkin.Controls.MaterialSlider materialSliderCount;

        private MaterialSkin.Controls.MaterialCard materialCardAuto;

        private MaterialSkin.Controls.MaterialButton materialButtonGenerate;
        private MaterialSkin.Controls.MaterialSlider materialSliderLenght;

        private System.Windows.Forms.ImageList imageListGit;

        private System.Windows.Forms.LinkLabel linkLabelGitHub;

        private MaterialSkin.Controls.MaterialLabel materialLabelSubject;
        
        private MaterialSkin.Controls.MaterialLabel materialLabelKR;

        private MaterialSkin.Controls.MaterialLabel materialLabelInfo;

        private System.Windows.Forms.PictureBox pictureBoxInfoLogo;

        private MaterialSkin.Controls.MaterialSwitch materialSwitchTheme;
        
        private System.Windows.Forms.TabPage tabPageSpec;
        private System.Windows.Forms.TabPage tabPageInfo;

        private MaterialSkin.Controls.MaterialTabControl materialTabControlMainWindow;
        private System.Windows.Forms.TabPage tabPageDevelop;
        private System.Windows.Forms.TabPage tabPageCharts;

        #endregion

        private System.Windows.Forms.ImageList imageListMenu;
    }
}