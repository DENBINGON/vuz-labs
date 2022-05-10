using System.ComponentModel;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.materialCardHandle = new MaterialSkin.Controls.MaterialCard();
            this.materialButtonDel = new MaterialSkin.Controls.MaterialButton();
            this.materialLabelDel = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBoxDel = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButtonHandAdd = new MaterialSkin.Controls.MaterialButton();
            this.materialLabelHandAdd = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBoxHandAdd = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCardAuto = new MaterialSkin.Controls.MaterialCard();
            this.materialButtonClear = new MaterialSkin.Controls.MaterialButton();
            this.materialCheckboxUppers = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckboxSymbols = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialSliderLenght = new MaterialSkin.Controls.MaterialSlider();
            this.materialSliderCount = new MaterialSkin.Controls.MaterialSlider();
            this.materialButtonGenerate = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSwitchHandle = new MaterialSkin.Controls.MaterialSwitch();
            this.dataGridViewWords = new System.Windows.Forms.DataGridView();
            this.Значение = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageCharts = new System.Windows.Forms.TabPage();
            this.materialCardLinealSearch = new MaterialSkin.Controls.MaterialCard();
            this.materialTextBoxLinealTotalTime = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBoxLinealMaxTime = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBoxLinealMinTime = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBoxLinealIterCount = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButtonLinealRefresh = new MaterialSkin.Controls.MaterialButton();
            this.chartLineal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.materialCardBinarySearch = new MaterialSkin.Controls.MaterialCard();
            this.materialTextBoxBinaryTotalTime = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBoxBinaryMaxTime = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBoxBinaryMinTime = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTextBoxBinaryIterCount = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButtonBinaryRefresh = new MaterialSkin.Controls.MaterialButton();
            this.chartBinary = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.materialComboBoxSelect = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCheckboxRefresh = new MaterialSkin.Controls.MaterialCheckbox();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
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
            this.materialTabControlMainWindow.SuspendLayout();
            this.tabPageDevelop.SuspendLayout();
            this.materialCardHandle.SuspendLayout();
            this.materialCardAuto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWords)).BeginInit();
            this.tabPageCharts.SuspendLayout();
            this.materialCardLinealSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLineal)).BeginInit();
            this.materialCardBinarySearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBinary)).BeginInit();
            this.tabPageSettings.SuspendLayout();
            this.materialCardSave.SuspendLayout();
            this.tabPageInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControlMainWindow
            // 
            this.materialTabControlMainWindow.Controls.Add(this.tabPageDevelop);
            this.materialTabControlMainWindow.Controls.Add(this.tabPageCharts);
            this.materialTabControlMainWindow.Controls.Add(this.tabPageSettings);
            this.materialTabControlMainWindow.Controls.Add(this.tabPageInfo);
            this.materialTabControlMainWindow.Depth = 0;
            this.materialTabControlMainWindow.ImageList = this.imageListMenu;
            this.materialTabControlMainWindow.Location = new System.Drawing.Point(0, 64);
            this.materialTabControlMainWindow.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControlMainWindow.Multiline = true;
            this.materialTabControlMainWindow.Name = "materialTabControlMainWindow";
            this.materialTabControlMainWindow.SelectedIndex = 0;
            this.materialTabControlMainWindow.Size = new System.Drawing.Size(798, 383);
            this.materialTabControlMainWindow.TabIndex = 0;
            // 
            // tabPageDevelop
            // 
            this.tabPageDevelop.BackColor = System.Drawing.Color.White;
            this.tabPageDevelop.Controls.Add(this.materialCardHandle);
            this.tabPageDevelop.Controls.Add(this.materialCardAuto);
            this.tabPageDevelop.Controls.Add(this.materialLabel2);
            this.tabPageDevelop.Controls.Add(this.materialLabel1);
            this.tabPageDevelop.Controls.Add(this.materialSwitchHandle);
            this.tabPageDevelop.Controls.Add(this.dataGridViewWords);
            this.tabPageDevelop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageDevelop.ImageKey = "file-document-edit-outline.png";
            this.tabPageDevelop.Location = new System.Drawing.Point(4, 39);
            this.tabPageDevelop.Name = "tabPageDevelop";
            this.tabPageDevelop.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDevelop.Size = new System.Drawing.Size(790, 340);
            this.tabPageDevelop.TabIndex = 0;
            this.tabPageDevelop.Text = "Разработка";
            // 
            // materialCardHandle
            // 
            this.materialCardHandle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardHandle.Controls.Add(this.materialButtonDel);
            this.materialCardHandle.Controls.Add(this.materialLabelDel);
            this.materialCardHandle.Controls.Add(this.materialTextBoxDel);
            this.materialCardHandle.Controls.Add(this.materialButtonHandAdd);
            this.materialCardHandle.Controls.Add(this.materialLabelHandAdd);
            this.materialCardHandle.Controls.Add(this.materialTextBoxHandAdd);
            this.materialCardHandle.Depth = 0;
            this.materialCardHandle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardHandle.Location = new System.Drawing.Point(69, 70);
            this.materialCardHandle.Margin = new System.Windows.Forms.Padding(14);
            this.materialCardHandle.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardHandle.Name = "materialCardHandle";
            this.materialCardHandle.Padding = new System.Windows.Forms.Padding(14);
            this.materialCardHandle.Size = new System.Drawing.Size(477, 310);
            this.materialCardHandle.TabIndex = 8;
            this.materialCardHandle.Visible = false;
            // 
            // materialButtonDel
            // 
            this.materialButtonDel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonDel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonDel.Depth = 0;
            this.materialButtonDel.HighEmphasis = true;
            this.materialButtonDel.Icon = null;
            this.materialButtonDel.Location = new System.Drawing.Point(306, 225);
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
            this.materialButtonDel.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialLabelDel
            // 
            this.materialLabelDel.Depth = 0;
            this.materialLabelDel.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelDel.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabelDel.Location = new System.Drawing.Point(254, 33);
            this.materialLabelDel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelDel.Name = "materialLabelDel";
            this.materialLabelDel.Size = new System.Drawing.Size(206, 42);
            this.materialLabelDel.TabIndex = 4;
            this.materialLabelDel.Text = "Удаление";
            this.materialLabelDel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.materialTextBoxDel.Location = new System.Drawing.Point(253, 127);
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
            this.materialButtonHandAdd.Location = new System.Drawing.Point(69, 225);
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
            // materialLabelHandAdd
            // 
            this.materialLabelHandAdd.Depth = 0;
            this.materialLabelHandAdd.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelHandAdd.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabelHandAdd.Location = new System.Drawing.Point(17, 33);
            this.materialLabelHandAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelHandAdd.Name = "materialLabelHandAdd";
            this.materialLabelHandAdd.Size = new System.Drawing.Size(206, 42);
            this.materialLabelHandAdd.TabIndex = 1;
            this.materialLabelHandAdd.Text = "Добавление";
            this.materialLabelHandAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.materialTextBoxHandAdd.Location = new System.Drawing.Point(16, 127);
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
            // materialCardAuto
            // 
            this.materialCardAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardAuto.Controls.Add(this.materialButtonClear);
            this.materialCardAuto.Controls.Add(this.materialCheckboxUppers);
            this.materialCardAuto.Controls.Add(this.materialCheckboxSymbols);
            this.materialCardAuto.Controls.Add(this.materialSliderLenght);
            this.materialCardAuto.Controls.Add(this.materialSliderCount);
            this.materialCardAuto.Controls.Add(this.materialButtonGenerate);
            this.materialCardAuto.Depth = 0;
            this.materialCardAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardAuto.Location = new System.Drawing.Point(69, 70);
            this.materialCardAuto.Margin = new System.Windows.Forms.Padding(14);
            this.materialCardAuto.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardAuto.Name = "materialCardAuto";
            this.materialCardAuto.Padding = new System.Windows.Forms.Padding(14);
            this.materialCardAuto.Size = new System.Drawing.Size(477, 310);
            this.materialCardAuto.TabIndex = 7;
            // 
            // materialButtonClear
            // 
            this.materialButtonClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonClear.Depth = 0;
            this.materialButtonClear.HighEmphasis = true;
            this.materialButtonClear.Icon = null;
            this.materialButtonClear.Location = new System.Drawing.Point(370, 264);
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
            this.materialCheckboxUppers.Location = new System.Drawing.Point(9, 206);
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
            this.materialCheckboxSymbols.Location = new System.Drawing.Point(9, 154);
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
            this.materialSliderLenght.Location = new System.Drawing.Point(16, 82);
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
            this.materialSliderCount.Location = new System.Drawing.Point(16, 20);
            this.materialSliderCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSliderCount.Name = "materialSliderCount";
            this.materialSliderCount.Size = new System.Drawing.Size(443, 40);
            this.materialSliderCount.TabIndex = 2;
            this.materialSliderCount.Text = "Количество ";
            this.materialSliderCount.Value = 1;
            this.materialSliderCount.ValueMax = 100;
            this.materialSliderCount.ValueSuffix = "00";
            // 
            // materialButtonGenerate
            // 
            this.materialButtonGenerate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonGenerate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonGenerate.Depth = 0;
            this.materialButtonGenerate.HighEmphasis = true;
            this.materialButtonGenerate.Icon = null;
            this.materialButtonGenerate.Location = new System.Drawing.Point(9, 264);
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
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(94, 22);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(136, 27);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Загрузка данных:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(236, 22);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(131, 27);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Автоматическая";
            // 
            // materialSwitchHandle
            // 
            this.materialSwitchHandle.BackColor = System.Drawing.Color.White;
            this.materialSwitchHandle.Depth = 0;
            this.materialSwitchHandle.Location = new System.Drawing.Point(375, 18);
            this.materialSwitchHandle.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitchHandle.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitchHandle.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitchHandle.Name = "materialSwitchHandle";
            this.materialSwitchHandle.Ripple = true;
            this.materialSwitchHandle.Size = new System.Drawing.Size(135, 27);
            this.materialSwitchHandle.TabIndex = 4;
            this.materialSwitchHandle.Text = "Ручная";
            this.materialSwitchHandle.UseVisualStyleBackColor = false;
            this.materialSwitchHandle.CheckedChanged += new System.EventHandler(this.materialSwitchHandle_CheckedChanged);
            // 
            // dataGridViewWords
            // 
            this.dataGridViewWords.AllowUserToAddRows = false;
            this.dataGridViewWords.AllowUserToDeleteRows = false;
            this.dataGridViewWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Значение });
            this.dataGridViewWords.Location = new System.Drawing.Point(552, 6);
            this.dataGridViewWords.Name = "dataGridViewWords";
            this.dataGridViewWords.ReadOnly = true;
            this.dataGridViewWords.Size = new System.Drawing.Size(243, 374);
            this.dataGridViewWords.TabIndex = 0;
            // 
            // Значение
            // 
            this.Значение.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Значение.DefaultCellStyle = dataGridViewCellStyle1;
            this.Значение.Frozen = true;
            this.Значение.HeaderText = "Массив данных";
            this.Значение.MinimumWidth = 200;
            this.Значение.Name = "Значение";
            this.Значение.ReadOnly = true;
            this.Значение.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Значение.Width = 200;
            // 
            // tabPageCharts
            // 
            this.tabPageCharts.BackColor = System.Drawing.Color.White;
            this.tabPageCharts.Controls.Add(this.materialCardLinealSearch);
            this.tabPageCharts.Controls.Add(this.materialCardBinarySearch);
            this.tabPageCharts.Controls.Add(this.materialComboBoxSelect);
            this.tabPageCharts.Controls.Add(this.materialCheckboxRefresh);
            this.tabPageCharts.ImageKey = "chart-line.png";
            this.tabPageCharts.Location = new System.Drawing.Point(4, 39);
            this.tabPageCharts.Name = "tabPageCharts";
            this.tabPageCharts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCharts.Size = new System.Drawing.Size(790, 340);
            this.tabPageCharts.TabIndex = 1;
            this.tabPageCharts.Text = "Статистика";
            // 
            // materialCardLinealSearch
            // 
            this.materialCardLinealSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.materialCardLinealSearch.Size = new System.Drawing.Size(750, 330);
            this.materialCardLinealSearch.TabIndex = 2;
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
            this.chartLineal.Text = "chartLineal";
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title1.Name = "Скорость линейного поиска";
            this.chartLineal.Titles.Add(title1);
            // 
            // materialCardBinarySearch
            // 
            this.materialCardBinarySearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
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
            this.materialCardBinarySearch.Size = new System.Drawing.Size(750, 330);
            this.materialCardBinarySearch.TabIndex = 7;
            this.materialCardBinarySearch.Visible = false;
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
            this.chartBinary.Text = "chart1";
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
            this.materialComboBoxSelect.Items.AddRange(new object[] { "Линейный поиск", "Бинарный поиск" });
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
            this.materialCheckboxRefresh.Location = new System.Drawing.Point(337, 6);
            this.materialCheckboxRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckboxRefresh.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckboxRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckboxRefresh.Name = "materialCheckboxRefresh";
            this.materialCheckboxRefresh.ReadOnly = false;
            this.materialCheckboxRefresh.Ripple = true;
            this.materialCheckboxRefresh.Size = new System.Drawing.Size(296, 35);
            this.materialCheckboxRefresh.TabIndex = 1;
            this.materialCheckboxRefresh.Text = "Обновлять расчеты при выборе";
            this.materialCheckboxRefresh.UseVisualStyleBackColor = true;
            this.materialCheckboxRefresh.CheckedChanged += new System.EventHandler(this.materialCheckboxRefresh_CheckedChanged);
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.BackColor = System.Drawing.Color.White;
            this.tabPageSettings.Controls.Add(this.materialCardSave);
            this.tabPageSettings.Controls.Add(this.materialSwitchTheme);
            this.tabPageSettings.ImageKey = "cog-outline.png";
            this.tabPageSettings.Location = new System.Drawing.Point(4, 39);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(790, 340);
            this.tabPageSettings.TabIndex = 2;
            this.tabPageSettings.Text = "Настройки";
            // 
            // materialCardSave
            // 
            this.materialCardSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardSave.Controls.Add(this.materialButtonSave);
            this.materialCardSave.Controls.Add(this.materialLabel3);
            this.materialCardSave.Controls.Add(this.materialComboBoxSelectChart);
            this.materialCardSave.Depth = 0;
            this.materialCardSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardSave.Location = new System.Drawing.Point(280, 17);
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
            this.materialButtonSave.Location = new System.Drawing.Point(340, 85);
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
            this.materialLabel3.Location = new System.Drawing.Point(93, 7);
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
            this.tabPageInfo.Size = new System.Drawing.Size(790, 340);
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
            this.materialLabelSubject.Text = "Исследование линейного, индексного и бинарного поисков";
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
            this.materialLabelInfo.Text = "Выполнил: Соловьев Р.А.\r\nГруппа: 21-КБ-ПИ1\r\nКубГТУ 2022";
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
            this.imageListMenu.Images.SetKeyName(1, "cog-outline.png");
            this.imageListMenu.Images.SetKeyName(2, "file-document-edit-outline.png");
            this.imageListMenu.Images.SetKeyName(3, "information-outline.png");
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.materialTabControlMainWindow);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControlMainWindow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(801, 450);
            this.MinimumSize = new System.Drawing.Size(801, 450);
            this.Name = "MainWindow";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 3, 3);
            this.Sizable = false;
            this.Text = "Анализ поисков";
            this.materialTabControlMainWindow.ResumeLayout(false);
            this.tabPageDevelop.ResumeLayout(false);
            this.materialCardHandle.ResumeLayout(false);
            this.materialCardHandle.PerformLayout();
            this.materialCardAuto.ResumeLayout(false);
            this.materialCardAuto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWords)).EndInit();
            this.tabPageCharts.ResumeLayout(false);
            this.materialCardLinealSearch.ResumeLayout(false);
            this.materialCardLinealSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLineal)).EndInit();
            this.materialCardBinarySearch.ResumeLayout(false);
            this.materialCardBinarySearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBinary)).EndInit();
            this.tabPageSettings.ResumeLayout(false);
            this.materialCardSave.ResumeLayout(false);
            this.materialCardSave.PerformLayout();
            this.tabPageInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoLogo)).EndInit();
            this.ResumeLayout(false);
        }

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

        private MaterialSkin.Controls.MaterialCard materialCardHandle;

        private MaterialSkin.Controls.MaterialCheckbox materialCheckboxUppers;

        private MaterialSkin.Controls.MaterialCheckbox materialCheckboxSymbols;

        private MaterialSkin.Controls.MaterialSlider materialSliderCount;

        private MaterialSkin.Controls.MaterialCard materialCardAuto;

        private MaterialSkin.Controls.MaterialLabel materialLabel2;

        private MaterialSkin.Controls.MaterialLabel materialLabel1;

        private MaterialSkin.Controls.MaterialSwitch materialSwitchHandle;

        private MaterialSkin.Controls.MaterialButton materialButtonGenerate;
        private MaterialSkin.Controls.MaterialSlider materialSliderLenght;

        private System.Windows.Forms.DataGridViewTextBoxColumn Значение;

        private System.Windows.Forms.DataGridView dataGridViewWords;

        private System.Windows.Forms.ImageList imageListGit;

        private System.Windows.Forms.LinkLabel linkLabelGitHub;

        private MaterialSkin.Controls.MaterialLabel materialLabelSubject;
        
        private MaterialSkin.Controls.MaterialLabel materialLabelKR;

        private MaterialSkin.Controls.MaterialLabel materialLabelInfo;

        private System.Windows.Forms.PictureBox pictureBoxInfoLogo;

        private MaterialSkin.Controls.MaterialSwitch materialSwitchTheme;
        
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TabPage tabPageInfo;

        private MaterialSkin.Controls.MaterialTabControl materialTabControlMainWindow;
        private System.Windows.Forms.TabPage tabPageDevelop;
        private System.Windows.Forms.TabPage tabPageCharts;

        #endregion

        private System.Windows.Forms.ImageList imageListMenu;
    }
}