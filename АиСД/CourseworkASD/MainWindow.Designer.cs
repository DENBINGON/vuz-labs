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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.materialTabControlMainWindow = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageDevelop = new System.Windows.Forms.TabPage();
            this.materialCardAuto = new MaterialSkin.Controls.MaterialCard();
            this.materialButtonClear = new MaterialSkin.Controls.MaterialButton();
            this.materialCheckboxUppers = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckboxSymbols = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialSliderLenght = new MaterialSkin.Controls.MaterialSlider();
            this.materialSliderCount = new MaterialSkin.Controls.MaterialSlider();
            this.materialButtonGenerate = new MaterialSkin.Controls.MaterialButton();
            this.materialCardHandle = new MaterialSkin.Controls.MaterialCard();
            this.materialButtonDel = new MaterialSkin.Controls.MaterialButton();
            this.materialLabelDel = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBoxDel = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButtonHandAdd = new MaterialSkin.Controls.MaterialButton();
            this.materialLabelHandAdd = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBoxHandAdd = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSwitchHandle = new MaterialSkin.Controls.MaterialSwitch();
            this.materialProgressBar = new MaterialSkin.Controls.MaterialProgressBar();
            this.dataGridViewWords = new System.Windows.Forms.DataGridView();
            this.Значение = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageCharts = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.materialSwitchTheme = new MaterialSkin.Controls.MaterialSwitch();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
            this.imageListGit = new System.Windows.Forms.ImageList(this.components);
            this.materialLabelSubject = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelKR = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelInfo = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBoxInfoLogo = new System.Windows.Forms.PictureBox();
            this.imageListMenu = new System.Windows.Forms.ImageList(this.components);
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControlMainWindow.SuspendLayout();
            this.tabPageDevelop.SuspendLayout();
            this.materialCardAuto.SuspendLayout();
            this.materialCardHandle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWords)).BeginInit();
            this.tabPageCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPageSettings.SuspendLayout();
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
            this.tabPageDevelop.Controls.Add(this.materialCardAuto);
            this.tabPageDevelop.Controls.Add(this.materialCardHandle);
            this.tabPageDevelop.Controls.Add(this.materialLabel2);
            this.tabPageDevelop.Controls.Add(this.materialLabel1);
            this.tabPageDevelop.Controls.Add(this.materialSwitchHandle);
            this.tabPageDevelop.Controls.Add(this.materialProgressBar);
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
            this.materialTextBoxDel.Text = "Введите индекс";
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
            this.materialTextBoxHandAdd.LeadingIcon = null;
            this.materialTextBoxHandAdd.Location = new System.Drawing.Point(16, 127);
            this.materialTextBoxHandAdd.MaxLength = 32767;
            this.materialTextBoxHandAdd.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxHandAdd.Name = "materialTextBoxHandAdd";
            this.materialTextBoxHandAdd.PasswordChar = '\0';
            this.materialTextBoxHandAdd.PrefixSuffixText = null;
            this.materialTextBoxHandAdd.ReadOnly = false;
            this.materialTextBoxHandAdd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materialTextBoxHandAdd.SelectedText = "";
            this.materialTextBoxHandAdd.SelectionLength = 0;
            this.materialTextBoxHandAdd.SelectionStart = 0;
            this.materialTextBoxHandAdd.ShortcutsEnabled = true;
            this.materialTextBoxHandAdd.Size = new System.Drawing.Size(207, 48);
            this.materialTextBoxHandAdd.TabIndex = 0;
            this.materialTextBoxHandAdd.TabStop = false;
            this.materialTextBoxHandAdd.Text = "Введите значение";
            this.materialTextBoxHandAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.materialTextBoxHandAdd.TrailingIcon = null;
            this.materialTextBoxHandAdd.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(85, 33);
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
            this.materialLabel1.Location = new System.Drawing.Point(227, 33);
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
            this.materialSwitchHandle.Location = new System.Drawing.Point(366, 29);
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
            // materialProgressBar
            // 
            this.materialProgressBar.Depth = 0;
            this.materialProgressBar.Location = new System.Drawing.Point(69, 6);
            this.materialProgressBar.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar.Name = "materialProgressBar";
            this.materialProgressBar.Size = new System.Drawing.Size(477, 5);
            this.materialProgressBar.TabIndex = 3;
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
            this.tabPageCharts.Controls.Add(this.materialLabel3);
            this.tabPageCharts.Controls.Add(this.materialButton1);
            this.tabPageCharts.Controls.Add(this.chart1);
            this.tabPageCharts.ImageKey = "chart-line.png";
            this.tabPageCharts.Location = new System.Drawing.Point(4, 39);
            this.tabPageCharts.Name = "tabPageCharts";
            this.tabPageCharts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCharts.Size = new System.Drawing.Size(790, 340);
            this.tabPageCharts.TabIndex = 1;
            this.tabPageCharts.Text = "Статистика";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(518, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.BackColor = System.Drawing.Color.White;
            this.tabPageSettings.Controls.Add(this.materialSwitchTheme);
            this.tabPageSettings.ImageKey = "cog-outline.png";
            this.tabPageSettings.Location = new System.Drawing.Point(4, 39);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(790, 340);
            this.tabPageSettings.TabIndex = 2;
            this.tabPageSettings.Text = "Настройки";
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
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(581, 270);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(158, 36);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "materialButton1";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click_1);
            // 
            // materialLabel3
            // 
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(583, 171);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(156, 23);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "materialLabel3";
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
            this.materialCardAuto.ResumeLayout(false);
            this.materialCardAuto.PerformLayout();
            this.materialCardHandle.ResumeLayout(false);
            this.materialCardHandle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWords)).EndInit();
            this.tabPageCharts.ResumeLayout(false);
            this.tabPageCharts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoLogo)).EndInit();
            this.ResumeLayout(false);
        }

        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;

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

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;

        private MaterialSkin.Controls.MaterialLabel materialLabel2;

        private MaterialSkin.Controls.MaterialLabel materialLabel1;

        private MaterialSkin.Controls.MaterialSwitch materialSwitchHandle;

        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar;

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