using System.ComponentModel;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
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
            this.materialTabControlMainWindow = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageDevelop = new System.Windows.Forms.TabPage();
            this.materialTabControlDev = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageAuto = new System.Windows.Forms.TabPage();
            this.materialCardAuto = new MaterialSkin.Controls.MaterialCard();
            this.materialProgressBarDev = new MaterialSkin.Controls.MaterialProgressBar();
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
            this.tabPageImport = new System.Windows.Forms.TabPage();
            this.materialCardImport = new MaterialSkin.Controls.MaterialCard();
            this.materialCheckBoxDop = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialButtonImportClearPath = new MaterialSkin.Controls.MaterialButton();
            this.materialLabelImportError = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBoxImportSelectedFile = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButtonImportSelect = new MaterialSkin.Controls.MaterialButton();
            this.materialLabelImport = new MaterialSkin.Controls.MaterialLabel();
            this.materialButtonImport = new MaterialSkin.Controls.MaterialButton();
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
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSwitchUseAsync = new MaterialSkin.Controls.MaterialSwitch();
            this.materialSwitchWrapChartAsync = new MaterialSkin.Controls.MaterialSwitch();
            this.materialSwitchSaveDataAsync = new MaterialSkin.Controls.MaterialSwitch();
            this.materialSwitchGenWordAsync = new MaterialSkin.Controls.MaterialSwitch();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSwitchTheme = new MaterialSkin.Controls.MaterialSwitch();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialComboBoxSaveDataType = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabelSaveXlsx = new MaterialSkin.Controls.MaterialLabel();
            this.materialButtonSaveXlsx = new MaterialSkin.Controls.MaterialButton();
            this.materialComboBoxSelectChartToXlsx = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCardSave = new MaterialSkin.Controls.MaterialCard();
            this.materialButtonSave = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBoxSelectChart = new MaterialSkin.Controls.MaterialComboBox();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.materialCardLogo = new MaterialSkin.Controls.MaterialCard();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabelGitHub = new System.Windows.Forms.LinkLabel();
            this.imageListGit = new System.Windows.Forms.ImageList(this.components);
            this.materialLabelSubject = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelKR = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabelInfo = new MaterialSkin.Controls.MaterialLabel();
            this.imageListMenu = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControlMainWindow.SuspendLayout();
            this.tabPageDevelop.SuspendLayout();
            this.materialTabControlDev.SuspendLayout();
            this.tabPageAuto.SuspendLayout();
            this.materialCardAuto.SuspendLayout();
            this.tabPageHandle.SuspendLayout();
            this.materialCardHandle.SuspendLayout();
            this.tabPageImport.SuspendLayout();
            this.materialCardImport.SuspendLayout();
            this.tabPageCharts.SuspendLayout();
            this.materialCardHandleSearch.SuspendLayout();
            this.materialCardLinealSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLineal)).BeginInit();
            this.materialCardBinarySearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartBinary)).BeginInit();
            this.tabPageSpec.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCardSave.SuspendLayout();
            this.tabPageInfo.SuspendLayout();
            this.materialCardLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControlMainWindow
            // 
            resources.ApplyResources(this.materialTabControlMainWindow, "materialTabControlMainWindow");
            this.materialTabControlMainWindow.Controls.Add(this.tabPageDevelop);
            this.materialTabControlMainWindow.Controls.Add(this.tabPageCharts);
            this.materialTabControlMainWindow.Controls.Add(this.tabPageSpec);
            this.materialTabControlMainWindow.Controls.Add(this.tabPageInfo);
            this.materialTabControlMainWindow.Depth = 0;
            this.materialTabControlMainWindow.ImageList = this.imageListMenu;
            this.materialTabControlMainWindow.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControlMainWindow.Multiline = true;
            this.materialTabControlMainWindow.Name = "materialTabControlMainWindow";
            this.materialTabControlMainWindow.SelectedIndex = 0;
            // 
            // tabPageDevelop
            // 
            resources.ApplyResources(this.tabPageDevelop, "tabPageDevelop");
            this.tabPageDevelop.BackColor = System.Drawing.Color.White;
            this.tabPageDevelop.Controls.Add(this.materialTabControlDev);
            this.tabPageDevelop.Controls.Add(this.materialTabSelector1);
            this.tabPageDevelop.Controls.Add(this.materialListBoxData);
            this.tabPageDevelop.Name = "tabPageDevelop";
            // 
            // materialTabControlDev
            // 
            resources.ApplyResources(this.materialTabControlDev, "materialTabControlDev");
            this.materialTabControlDev.Controls.Add(this.tabPageAuto);
            this.materialTabControlDev.Controls.Add(this.tabPageHandle);
            this.materialTabControlDev.Controls.Add(this.tabPageImport);
            this.materialTabControlDev.Depth = 0;
            this.materialTabControlDev.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControlDev.Multiline = true;
            this.materialTabControlDev.Name = "materialTabControlDev";
            this.materialTabControlDev.SelectedIndex = 0;
            this.materialTabControlDev.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            // 
            // tabPageAuto
            // 
            resources.ApplyResources(this.tabPageAuto, "tabPageAuto");
            this.tabPageAuto.Controls.Add(this.materialCardAuto);
            this.tabPageAuto.Name = "tabPageAuto";
            this.tabPageAuto.UseVisualStyleBackColor = true;
            // 
            // materialCardAuto
            // 
            resources.ApplyResources(this.materialCardAuto, "materialCardAuto");
            this.materialCardAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardAuto.Controls.Add(this.materialProgressBarDev);
            this.materialCardAuto.Controls.Add(this.materialCheckboxGenerated);
            this.materialCardAuto.Controls.Add(this.materialButtonClear);
            this.materialCardAuto.Controls.Add(this.materialCheckboxUppers);
            this.materialCardAuto.Controls.Add(this.materialCheckboxSymbols);
            this.materialCardAuto.Controls.Add(this.materialSliderLenght);
            this.materialCardAuto.Controls.Add(this.materialSliderCount);
            this.materialCardAuto.Controls.Add(this.materialButtonGenerate);
            this.materialCardAuto.Depth = 0;
            this.materialCardAuto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardAuto.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardAuto.Name = "materialCardAuto";
            // 
            // materialProgressBarDev
            // 
            resources.ApplyResources(this.materialProgressBarDev, "materialProgressBarDev");
            this.materialProgressBarDev.Depth = 0;
            this.materialProgressBarDev.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBarDev.Name = "materialProgressBarDev";
            // 
            // materialCheckboxGenerated
            // 
            resources.ApplyResources(this.materialCheckboxGenerated, "materialCheckboxGenerated");
            this.materialCheckboxGenerated.Checked = true;
            this.materialCheckboxGenerated.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckboxGenerated.Depth = 0;
            this.materialCheckboxGenerated.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckboxGenerated.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckboxGenerated.Name = "materialCheckboxGenerated";
            this.materialCheckboxGenerated.ReadOnly = true;
            this.materialCheckboxGenerated.Ripple = true;
            this.materialCheckboxGenerated.UseVisualStyleBackColor = true;
            // 
            // materialButtonClear
            // 
            resources.ApplyResources(this.materialButtonClear, "materialButtonClear");
            this.materialButtonClear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonClear.Depth = 0;
            this.materialButtonClear.HighEmphasis = true;
            this.materialButtonClear.Icon = ((System.Drawing.Image)(resources.GetObject("materialButtonClear.Icon")));
            this.materialButtonClear.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonClear.Name = "materialButtonClear";
            this.materialButtonClear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonClear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButtonClear.UseAccentColor = false;
            this.materialButtonClear.UseVisualStyleBackColor = true;
            this.materialButtonClear.Click += new System.EventHandler(this.materialButtonClear_Click);
            // 
            // materialCheckboxUppers
            // 
            resources.ApplyResources(this.materialCheckboxUppers, "materialCheckboxUppers");
            this.materialCheckboxUppers.Depth = 0;
            this.materialCheckboxUppers.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckboxUppers.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckboxUppers.Name = "materialCheckboxUppers";
            this.materialCheckboxUppers.ReadOnly = false;
            this.materialCheckboxUppers.Ripple = true;
            this.materialCheckboxUppers.UseVisualStyleBackColor = true;
            // 
            // materialCheckboxSymbols
            // 
            resources.ApplyResources(this.materialCheckboxSymbols, "materialCheckboxSymbols");
            this.materialCheckboxSymbols.Depth = 0;
            this.materialCheckboxSymbols.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckboxSymbols.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckboxSymbols.Name = "materialCheckboxSymbols";
            this.materialCheckboxSymbols.ReadOnly = false;
            this.materialCheckboxSymbols.Ripple = true;
            this.materialCheckboxSymbols.UseVisualStyleBackColor = true;
            // 
            // materialSliderLenght
            // 
            resources.ApplyResources(this.materialSliderLenght, "materialSliderLenght");
            this.materialSliderLenght.Depth = 0;
            this.materialSliderLenght.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSliderLenght.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSliderLenght.Name = "materialSliderLenght";
            this.materialSliderLenght.Value = 1;
            this.materialSliderLenght.ValueMax = 100;
            this.materialSliderLenght.ValueSuffix = " сим.";
            // 
            // materialSliderCount
            // 
            resources.ApplyResources(this.materialSliderCount, "materialSliderCount");
            this.materialSliderCount.Depth = 0;
            this.materialSliderCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSliderCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSliderCount.Name = "materialSliderCount";
            this.materialSliderCount.RangeMax = 10000;
            this.materialSliderCount.Value = 1;
            this.materialSliderCount.ValueMax = 10000;
            this.materialSliderCount.ValueSuffix = "    ";
            // 
            // materialButtonGenerate
            // 
            resources.ApplyResources(this.materialButtonGenerate, "materialButtonGenerate");
            this.materialButtonGenerate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonGenerate.Depth = 0;
            this.materialButtonGenerate.HighEmphasis = true;
            this.materialButtonGenerate.Icon = ((System.Drawing.Image)(resources.GetObject("materialButtonGenerate.Icon")));
            this.materialButtonGenerate.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonGenerate.Name = "materialButtonGenerate";
            this.materialButtonGenerate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonGenerate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonGenerate.UseAccentColor = false;
            this.materialButtonGenerate.UseVisualStyleBackColor = true;
            this.materialButtonGenerate.Click += new System.EventHandler(this.materialButtonGenerate_Click);
            // 
            // tabPageHandle
            // 
            resources.ApplyResources(this.tabPageHandle, "tabPageHandle");
            this.tabPageHandle.Controls.Add(this.materialCardHandle);
            this.tabPageHandle.Name = "tabPageHandle";
            this.tabPageHandle.UseVisualStyleBackColor = true;
            // 
            // materialCardHandle
            // 
            resources.ApplyResources(this.materialCardHandle, "materialCardHandle");
            this.materialCardHandle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardHandle.Controls.Add(this.materialButtonDel);
            this.materialCardHandle.Controls.Add(this.materialLabelHandAdd);
            this.materialCardHandle.Controls.Add(this.materialLabelDel);
            this.materialCardHandle.Controls.Add(this.materialTextBoxHandAdd);
            this.materialCardHandle.Controls.Add(this.materialTextBoxDel);
            this.materialCardHandle.Controls.Add(this.materialButtonHandAdd);
            this.materialCardHandle.Depth = 0;
            this.materialCardHandle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardHandle.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardHandle.Name = "materialCardHandle";
            // 
            // materialButtonDel
            // 
            resources.ApplyResources(this.materialButtonDel, "materialButtonDel");
            this.materialButtonDel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonDel.Depth = 0;
            this.materialButtonDel.HighEmphasis = true;
            this.materialButtonDel.Icon = ((System.Drawing.Image)(resources.GetObject("materialButtonDel.Icon")));
            this.materialButtonDel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonDel.Name = "materialButtonDel";
            this.materialButtonDel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonDel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonDel.UseAccentColor = false;
            this.materialButtonDel.UseVisualStyleBackColor = true;
            this.materialButtonDel.Click += new System.EventHandler(this.materialButtonDel_Click);
            // 
            // materialLabelHandAdd
            // 
            resources.ApplyResources(this.materialLabelHandAdd, "materialLabelHandAdd");
            this.materialLabelHandAdd.Depth = 0;
            this.materialLabelHandAdd.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabelHandAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelHandAdd.Name = "materialLabelHandAdd";
            // 
            // materialLabelDel
            // 
            resources.ApplyResources(this.materialLabelDel, "materialLabelDel");
            this.materialLabelDel.Depth = 0;
            this.materialLabelDel.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabelDel.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelDel.Name = "materialLabelDel";
            // 
            // materialTextBoxHandAdd
            // 
            resources.ApplyResources(this.materialTextBoxHandAdd, "materialTextBoxHandAdd");
            this.materialTextBoxHandAdd.AnimateReadOnly = false;
            this.materialTextBoxHandAdd.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxHandAdd.Depth = 0;
            this.materialTextBoxHandAdd.HideSelection = true;
            this.materialTextBoxHandAdd.LeadingIcon = null;
            this.materialTextBoxHandAdd.MaxLength = 32767;
            this.materialTextBoxHandAdd.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxHandAdd.Name = "materialTextBoxHandAdd";
            this.materialTextBoxHandAdd.PasswordChar = '\0';
            this.materialTextBoxHandAdd.ReadOnly = false;
            this.materialTextBoxHandAdd.SelectedText = "";
            this.materialTextBoxHandAdd.SelectionLength = 0;
            this.materialTextBoxHandAdd.SelectionStart = 0;
            this.materialTextBoxHandAdd.ShortcutsEnabled = true;
            this.materialTextBoxHandAdd.TabStop = false;
            this.materialTextBoxHandAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.materialTextBoxHandAdd.TrailingIcon = null;
            this.materialTextBoxHandAdd.UseSystemPasswordChar = false;
            // 
            // materialTextBoxDel
            // 
            resources.ApplyResources(this.materialTextBoxDel, "materialTextBoxDel");
            this.materialTextBoxDel.AnimateReadOnly = false;
            this.materialTextBoxDel.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxDel.Depth = 0;
            this.materialTextBoxDel.HideSelection = true;
            this.materialTextBoxDel.LeadingIcon = null;
            this.materialTextBoxDel.MaxLength = 32767;
            this.materialTextBoxDel.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxDel.Name = "materialTextBoxDel";
            this.materialTextBoxDel.PasswordChar = '\0';
            this.materialTextBoxDel.ReadOnly = false;
            this.materialTextBoxDel.SelectedText = "";
            this.materialTextBoxDel.SelectionLength = 0;
            this.materialTextBoxDel.SelectionStart = 0;
            this.materialTextBoxDel.ShortcutsEnabled = true;
            this.materialTextBoxDel.TabStop = false;
            this.materialTextBoxDel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.materialTextBoxDel.TrailingIcon = null;
            this.materialTextBoxDel.UseSystemPasswordChar = false;
            // 
            // materialButtonHandAdd
            // 
            resources.ApplyResources(this.materialButtonHandAdd, "materialButtonHandAdd");
            this.materialButtonHandAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonHandAdd.Depth = 0;
            this.materialButtonHandAdd.HighEmphasis = true;
            this.materialButtonHandAdd.Icon = ((System.Drawing.Image)(resources.GetObject("materialButtonHandAdd.Icon")));
            this.materialButtonHandAdd.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonHandAdd.Name = "materialButtonHandAdd";
            this.materialButtonHandAdd.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonHandAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonHandAdd.UseAccentColor = false;
            this.materialButtonHandAdd.UseVisualStyleBackColor = true;
            this.materialButtonHandAdd.Click += new System.EventHandler(this.materialButtonHandAdd_Click);
            // 
            // tabPageImport
            // 
            resources.ApplyResources(this.tabPageImport, "tabPageImport");
            this.tabPageImport.Controls.Add(this.materialCardImport);
            this.tabPageImport.Name = "tabPageImport";
            this.tabPageImport.UseVisualStyleBackColor = true;
            // 
            // materialCardImport
            // 
            resources.ApplyResources(this.materialCardImport, "materialCardImport");
            this.materialCardImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardImport.Controls.Add(this.materialCheckBoxDop);
            this.materialCardImport.Controls.Add(this.materialButtonImportClearPath);
            this.materialCardImport.Controls.Add(this.materialLabelImportError);
            this.materialCardImport.Controls.Add(this.materialTextBoxImportSelectedFile);
            this.materialCardImport.Controls.Add(this.materialButtonImportSelect);
            this.materialCardImport.Controls.Add(this.materialLabelImport);
            this.materialCardImport.Controls.Add(this.materialButtonImport);
            this.materialCardImport.Depth = 0;
            this.materialCardImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardImport.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardImport.Name = "materialCardImport";
            // 
            // materialCheckBoxDop
            // 
            resources.ApplyResources(this.materialCheckBoxDop, "materialCheckBoxDop");
            this.materialCheckBoxDop.Depth = 0;
            this.materialCheckBoxDop.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckBoxDop.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckBoxDop.Name = "materialCheckBoxDop";
            this.materialCheckBoxDop.ReadOnly = false;
            this.materialCheckBoxDop.Ripple = true;
            this.materialCheckBoxDop.UseVisualStyleBackColor = true;
            // 
            // materialButtonImportClearPath
            // 
            resources.ApplyResources(this.materialButtonImportClearPath, "materialButtonImportClearPath");
            this.materialButtonImportClearPath.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonImportClearPath.Depth = 0;
            this.materialButtonImportClearPath.HighEmphasis = true;
            this.materialButtonImportClearPath.Icon = ((System.Drawing.Image)(resources.GetObject("materialButtonImportClearPath.Icon")));
            this.materialButtonImportClearPath.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonImportClearPath.Name = "materialButtonImportClearPath";
            this.materialButtonImportClearPath.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonImportClearPath.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonImportClearPath.UseAccentColor = true;
            this.materialButtonImportClearPath.UseVisualStyleBackColor = true;
            this.materialButtonImportClearPath.Click += new System.EventHandler(this.materialButtonImportClearPath_Click);
            // 
            // materialLabelImportError
            // 
            resources.ApplyResources(this.materialLabelImportError, "materialLabelImportError");
            this.materialLabelImportError.BackColor = System.Drawing.Color.White;
            this.materialLabelImportError.Depth = 0;
            this.materialLabelImportError.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabelImportError.ForeColor = System.Drawing.Color.Black;
            this.materialLabelImportError.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelImportError.Name = "materialLabelImportError";
            // 
            // materialTextBoxImportSelectedFile
            // 
            resources.ApplyResources(this.materialTextBoxImportSelectedFile, "materialTextBoxImportSelectedFile");
            this.materialTextBoxImportSelectedFile.AnimateReadOnly = true;
            this.materialTextBoxImportSelectedFile.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxImportSelectedFile.Depth = 0;
            this.materialTextBoxImportSelectedFile.HideSelection = true;
            this.materialTextBoxImportSelectedFile.LeadingIcon = null;
            this.materialTextBoxImportSelectedFile.MaxLength = 32767;
            this.materialTextBoxImportSelectedFile.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxImportSelectedFile.Name = "materialTextBoxImportSelectedFile";
            this.materialTextBoxImportSelectedFile.PasswordChar = '\0';
            this.materialTextBoxImportSelectedFile.ReadOnly = true;
            this.materialTextBoxImportSelectedFile.SelectedText = "";
            this.materialTextBoxImportSelectedFile.SelectionLength = 0;
            this.materialTextBoxImportSelectedFile.SelectionStart = 0;
            this.materialTextBoxImportSelectedFile.ShortcutsEnabled = true;
            this.materialTextBoxImportSelectedFile.TabStop = false;
            this.materialTextBoxImportSelectedFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxImportSelectedFile.TrailingIcon = null;
            this.materialTextBoxImportSelectedFile.UseSystemPasswordChar = false;
            this.materialTextBoxImportSelectedFile.UseTallSize = false;
            // 
            // materialButtonImportSelect
            // 
            resources.ApplyResources(this.materialButtonImportSelect, "materialButtonImportSelect");
            this.materialButtonImportSelect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonImportSelect.Depth = 0;
            this.materialButtonImportSelect.HighEmphasis = true;
            this.materialButtonImportSelect.Icon = ((System.Drawing.Image)(resources.GetObject("materialButtonImportSelect.Icon")));
            this.materialButtonImportSelect.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonImportSelect.Name = "materialButtonImportSelect";
            this.materialButtonImportSelect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonImportSelect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonImportSelect.UseAccentColor = false;
            this.materialButtonImportSelect.UseVisualStyleBackColor = true;
            this.materialButtonImportSelect.Click += new System.EventHandler(this.materialButtonImportSelect_Click);
            // 
            // materialLabelImport
            // 
            resources.ApplyResources(this.materialLabelImport, "materialLabelImport");
            this.materialLabelImport.Depth = 0;
            this.materialLabelImport.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabelImport.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelImport.Name = "materialLabelImport";
            // 
            // materialButtonImport
            // 
            resources.ApplyResources(this.materialButtonImport, "materialButtonImport");
            this.materialButtonImport.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonImport.Depth = 0;
            this.materialButtonImport.HighEmphasis = true;
            this.materialButtonImport.Icon = ((System.Drawing.Image)(resources.GetObject("materialButtonImport.Icon")));
            this.materialButtonImport.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonImport.Name = "materialButtonImport";
            this.materialButtonImport.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonImport.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonImport.UseAccentColor = false;
            this.materialButtonImport.UseVisualStyleBackColor = true;
            this.materialButtonImport.Click += new System.EventHandler(this.materialButtonImport_Click);
            // 
            // materialTabSelector1
            // 
            resources.ApplyResources(this.materialTabSelector1, "materialTabSelector1");
            this.materialTabSelector1.BaseTabControl = this.materialTabControlDev;
            this.materialTabSelector1.CharacterCasing = MaterialSkin.Controls.MaterialTabSelector.CustomCharacterCasing.Normal;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            // 
            // materialListBoxData
            // 
            resources.ApplyResources(this.materialListBoxData, "materialListBoxData");
            this.materialListBoxData.BackColor = System.Drawing.Color.White;
            this.materialListBoxData.BorderColor = System.Drawing.Color.LightGray;
            this.materialListBoxData.Depth = 0;
            this.materialListBoxData.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialListBoxData.MultiSelect = true;
            this.materialListBoxData.Name = "materialListBoxData";
            this.materialListBoxData.SelectedIndex = -1;
            this.materialListBoxData.SelectedItem = null;
            // 
            // tabPageCharts
            // 
            resources.ApplyResources(this.tabPageCharts, "tabPageCharts");
            this.tabPageCharts.BackColor = System.Drawing.Color.White;
            this.tabPageCharts.Controls.Add(this.materialProgressBarStat);
            this.tabPageCharts.Controls.Add(this.materialCardHandleSearch);
            this.tabPageCharts.Controls.Add(this.materialCardLinealSearch);
            this.tabPageCharts.Controls.Add(this.materialCardBinarySearch);
            this.tabPageCharts.Controls.Add(this.materialComboBoxSelect);
            this.tabPageCharts.Controls.Add(this.materialCheckboxRefresh);
            this.tabPageCharts.Name = "tabPageCharts";
            // 
            // materialProgressBarStat
            // 
            resources.ApplyResources(this.materialProgressBarStat, "materialProgressBarStat");
            this.materialProgressBarStat.Depth = 0;
            this.materialProgressBarStat.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBarStat.Name = "materialProgressBarStat";
            // 
            // materialCardHandleSearch
            // 
            resources.ApplyResources(this.materialCardHandleSearch, "materialCardHandleSearch");
            this.materialCardHandleSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardHandleSearch.Controls.Add(this.materialTextBoxHandleQuestion);
            this.materialCardHandleSearch.Controls.Add(this.materialComboBoxHandleSeach);
            this.materialCardHandleSearch.Controls.Add(this.materialTextBoxHandleFindWord);
            this.materialCardHandleSearch.Controls.Add(this.materialTextBoxHandleTime);
            this.materialCardHandleSearch.Controls.Add(this.materialTextBoxHandleIterCount);
            this.materialCardHandleSearch.Controls.Add(this.materialButtonHandleSearch);
            this.materialCardHandleSearch.Depth = 0;
            this.materialCardHandleSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardHandleSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardHandleSearch.Name = "materialCardHandleSearch";
            // 
            // materialTextBoxHandleQuestion
            // 
            resources.ApplyResources(this.materialTextBoxHandleQuestion, "materialTextBoxHandleQuestion");
            this.materialTextBoxHandleQuestion.AnimateReadOnly = true;
            this.materialTextBoxHandleQuestion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxHandleQuestion.Depth = 0;
            this.materialTextBoxHandleQuestion.HideSelection = true;
            this.materialTextBoxHandleQuestion.LeadingIcon = null;
            this.materialTextBoxHandleQuestion.MaxLength = 32767;
            this.materialTextBoxHandleQuestion.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxHandleQuestion.Name = "materialTextBoxHandleQuestion";
            this.materialTextBoxHandleQuestion.PasswordChar = '\0';
            this.materialTextBoxHandleQuestion.ReadOnly = true;
            this.materialTextBoxHandleQuestion.SelectedText = "";
            this.materialTextBoxHandleQuestion.SelectionLength = 0;
            this.materialTextBoxHandleQuestion.SelectionStart = 0;
            this.materialTextBoxHandleQuestion.ShortcutsEnabled = true;
            this.materialTextBoxHandleQuestion.TabStop = false;
            this.materialTextBoxHandleQuestion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxHandleQuestion.TrailingIcon = null;
            this.materialTextBoxHandleQuestion.UseSystemPasswordChar = false;
            // 
            // materialComboBoxHandleSeach
            // 
            resources.ApplyResources(this.materialComboBoxHandleSeach, "materialComboBoxHandleSeach");
            this.materialComboBoxHandleSeach.AutoResize = false;
            this.materialComboBoxHandleSeach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxHandleSeach.Depth = 0;
            this.materialComboBoxHandleSeach.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxHandleSeach.DropDownHeight = 174;
            this.materialComboBoxHandleSeach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxHandleSeach.DropDownWidth = 121;
            this.materialComboBoxHandleSeach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxHandleSeach.FormattingEnabled = true;
            this.materialComboBoxHandleSeach.Items.AddRange(new object[] { resources.GetString("materialComboBoxHandleSeach.Items"), resources.GetString("materialComboBoxHandleSeach.Items1") });
            this.materialComboBoxHandleSeach.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxHandleSeach.Name = "materialComboBoxHandleSeach";
            this.materialComboBoxHandleSeach.StartIndex = 0;
            // 
            // materialTextBoxHandleFindWord
            // 
            resources.ApplyResources(this.materialTextBoxHandleFindWord, "materialTextBoxHandleFindWord");
            this.materialTextBoxHandleFindWord.AnimateReadOnly = false;
            this.materialTextBoxHandleFindWord.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxHandleFindWord.Depth = 0;
            this.materialTextBoxHandleFindWord.HideSelection = true;
            this.materialTextBoxHandleFindWord.LeadingIcon = null;
            this.materialTextBoxHandleFindWord.MaxLength = 32767;
            this.materialTextBoxHandleFindWord.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxHandleFindWord.Name = "materialTextBoxHandleFindWord";
            this.materialTextBoxHandleFindWord.PasswordChar = '\0';
            this.materialTextBoxHandleFindWord.ReadOnly = false;
            this.materialTextBoxHandleFindWord.SelectedText = "";
            this.materialTextBoxHandleFindWord.SelectionLength = 0;
            this.materialTextBoxHandleFindWord.SelectionStart = 0;
            this.materialTextBoxHandleFindWord.ShortcutsEnabled = true;
            this.materialTextBoxHandleFindWord.TabStop = false;
            this.materialTextBoxHandleFindWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxHandleFindWord.TrailingIcon = null;
            this.materialTextBoxHandleFindWord.UseSystemPasswordChar = false;
            // 
            // materialTextBoxHandleTime
            // 
            resources.ApplyResources(this.materialTextBoxHandleTime, "materialTextBoxHandleTime");
            this.materialTextBoxHandleTime.AnimateReadOnly = true;
            this.materialTextBoxHandleTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxHandleTime.Depth = 0;
            this.materialTextBoxHandleTime.HideSelection = true;
            this.materialTextBoxHandleTime.LeadingIcon = null;
            this.materialTextBoxHandleTime.MaxLength = 32767;
            this.materialTextBoxHandleTime.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxHandleTime.Name = "materialTextBoxHandleTime";
            this.materialTextBoxHandleTime.PasswordChar = '\0';
            this.materialTextBoxHandleTime.ReadOnly = true;
            this.materialTextBoxHandleTime.SelectedText = "";
            this.materialTextBoxHandleTime.SelectionLength = 0;
            this.materialTextBoxHandleTime.SelectionStart = 0;
            this.materialTextBoxHandleTime.ShortcutsEnabled = true;
            this.materialTextBoxHandleTime.TabStop = false;
            this.materialTextBoxHandleTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxHandleTime.TrailingIcon = null;
            this.materialTextBoxHandleTime.UseSystemPasswordChar = false;
            // 
            // materialTextBoxHandleIterCount
            // 
            resources.ApplyResources(this.materialTextBoxHandleIterCount, "materialTextBoxHandleIterCount");
            this.materialTextBoxHandleIterCount.AnimateReadOnly = true;
            this.materialTextBoxHandleIterCount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxHandleIterCount.Depth = 0;
            this.materialTextBoxHandleIterCount.HideSelection = true;
            this.materialTextBoxHandleIterCount.LeadingIcon = null;
            this.materialTextBoxHandleIterCount.MaxLength = 32767;
            this.materialTextBoxHandleIterCount.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxHandleIterCount.Name = "materialTextBoxHandleIterCount";
            this.materialTextBoxHandleIterCount.PasswordChar = '\0';
            this.materialTextBoxHandleIterCount.ReadOnly = true;
            this.materialTextBoxHandleIterCount.SelectedText = "";
            this.materialTextBoxHandleIterCount.SelectionLength = 0;
            this.materialTextBoxHandleIterCount.SelectionStart = 0;
            this.materialTextBoxHandleIterCount.ShortcutsEnabled = true;
            this.materialTextBoxHandleIterCount.TabStop = false;
            this.materialTextBoxHandleIterCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxHandleIterCount.TrailingIcon = null;
            this.materialTextBoxHandleIterCount.UseSystemPasswordChar = false;
            // 
            // materialButtonHandleSearch
            // 
            resources.ApplyResources(this.materialButtonHandleSearch, "materialButtonHandleSearch");
            this.materialButtonHandleSearch.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonHandleSearch.Depth = 0;
            this.materialButtonHandleSearch.HighEmphasis = true;
            this.materialButtonHandleSearch.Icon = ((System.Drawing.Image)(resources.GetObject("materialButtonHandleSearch.Icon")));
            this.materialButtonHandleSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonHandleSearch.Name = "materialButtonHandleSearch";
            this.materialButtonHandleSearch.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonHandleSearch.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonHandleSearch.UseAccentColor = false;
            this.materialButtonHandleSearch.UseVisualStyleBackColor = true;
            this.materialButtonHandleSearch.Click += new System.EventHandler(this.materialButtonHandleSearch_Click);
            // 
            // materialCardLinealSearch
            // 
            resources.ApplyResources(this.materialCardLinealSearch, "materialCardLinealSearch");
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
            this.materialCardLinealSearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardLinealSearch.Name = "materialCardLinealSearch";
            // 
            // materialCheckboxLinealCount
            // 
            resources.ApplyResources(this.materialCheckboxLinealCount, "materialCheckboxLinealCount");
            this.materialCheckboxLinealCount.Checked = true;
            this.materialCheckboxLinealCount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckboxLinealCount.Depth = 0;
            this.materialCheckboxLinealCount.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckboxLinealCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckboxLinealCount.Name = "materialCheckboxLinealCount";
            this.materialCheckboxLinealCount.ReadOnly = false;
            this.materialCheckboxLinealCount.Ripple = true;
            this.materialCheckboxLinealCount.UseVisualStyleBackColor = true;
            this.materialCheckboxLinealCount.CheckedChanged += new System.EventHandler(this.materialCheckboxLinealCount_CheckedChanged);
            // 
            // materialCheckboxLinealTime
            // 
            resources.ApplyResources(this.materialCheckboxLinealTime, "materialCheckboxLinealTime");
            this.materialCheckboxLinealTime.Checked = true;
            this.materialCheckboxLinealTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckboxLinealTime.Depth = 0;
            this.materialCheckboxLinealTime.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckboxLinealTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckboxLinealTime.Name = "materialCheckboxLinealTime";
            this.materialCheckboxLinealTime.ReadOnly = false;
            this.materialCheckboxLinealTime.Ripple = true;
            this.materialCheckboxLinealTime.UseVisualStyleBackColor = true;
            this.materialCheckboxLinealTime.CheckedChanged += new System.EventHandler(this.materialCheckboxLinealTime_CheckedChanged);
            // 
            // materialTextBoxLinealTotalTime
            // 
            resources.ApplyResources(this.materialTextBoxLinealTotalTime, "materialTextBoxLinealTotalTime");
            this.materialTextBoxLinealTotalTime.AnimateReadOnly = true;
            this.materialTextBoxLinealTotalTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxLinealTotalTime.Depth = 0;
            this.materialTextBoxLinealTotalTime.HideSelection = true;
            this.materialTextBoxLinealTotalTime.LeadingIcon = null;
            this.materialTextBoxLinealTotalTime.MaxLength = 32767;
            this.materialTextBoxLinealTotalTime.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxLinealTotalTime.Name = "materialTextBoxLinealTotalTime";
            this.materialTextBoxLinealTotalTime.PasswordChar = '\0';
            this.materialTextBoxLinealTotalTime.ReadOnly = true;
            this.materialTextBoxLinealTotalTime.SelectedText = "";
            this.materialTextBoxLinealTotalTime.SelectionLength = 0;
            this.materialTextBoxLinealTotalTime.SelectionStart = 0;
            this.materialTextBoxLinealTotalTime.ShortcutsEnabled = true;
            this.materialTextBoxLinealTotalTime.TabStop = false;
            this.materialTextBoxLinealTotalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxLinealTotalTime.TrailingIcon = null;
            this.materialTextBoxLinealTotalTime.UseSystemPasswordChar = false;
            // 
            // materialTextBoxLinealMaxTime
            // 
            resources.ApplyResources(this.materialTextBoxLinealMaxTime, "materialTextBoxLinealMaxTime");
            this.materialTextBoxLinealMaxTime.AnimateReadOnly = true;
            this.materialTextBoxLinealMaxTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxLinealMaxTime.Depth = 0;
            this.materialTextBoxLinealMaxTime.HideSelection = true;
            this.materialTextBoxLinealMaxTime.LeadingIcon = null;
            this.materialTextBoxLinealMaxTime.MaxLength = 32767;
            this.materialTextBoxLinealMaxTime.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxLinealMaxTime.Name = "materialTextBoxLinealMaxTime";
            this.materialTextBoxLinealMaxTime.PasswordChar = '\0';
            this.materialTextBoxLinealMaxTime.ReadOnly = true;
            this.materialTextBoxLinealMaxTime.SelectedText = "";
            this.materialTextBoxLinealMaxTime.SelectionLength = 0;
            this.materialTextBoxLinealMaxTime.SelectionStart = 0;
            this.materialTextBoxLinealMaxTime.ShortcutsEnabled = true;
            this.materialTextBoxLinealMaxTime.TabStop = false;
            this.materialTextBoxLinealMaxTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxLinealMaxTime.TrailingIcon = null;
            this.materialTextBoxLinealMaxTime.UseSystemPasswordChar = false;
            // 
            // materialTextBoxLinealMinTime
            // 
            resources.ApplyResources(this.materialTextBoxLinealMinTime, "materialTextBoxLinealMinTime");
            this.materialTextBoxLinealMinTime.AnimateReadOnly = true;
            this.materialTextBoxLinealMinTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxLinealMinTime.Depth = 0;
            this.materialTextBoxLinealMinTime.HideSelection = true;
            this.materialTextBoxLinealMinTime.LeadingIcon = null;
            this.materialTextBoxLinealMinTime.MaxLength = 32767;
            this.materialTextBoxLinealMinTime.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxLinealMinTime.Name = "materialTextBoxLinealMinTime";
            this.materialTextBoxLinealMinTime.PasswordChar = '\0';
            this.materialTextBoxLinealMinTime.ReadOnly = true;
            this.materialTextBoxLinealMinTime.SelectedText = "";
            this.materialTextBoxLinealMinTime.SelectionLength = 0;
            this.materialTextBoxLinealMinTime.SelectionStart = 0;
            this.materialTextBoxLinealMinTime.ShortcutsEnabled = true;
            this.materialTextBoxLinealMinTime.TabStop = false;
            this.materialTextBoxLinealMinTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxLinealMinTime.TrailingIcon = null;
            this.materialTextBoxLinealMinTime.UseSystemPasswordChar = false;
            // 
            // materialTextBoxLinealIterCount
            // 
            resources.ApplyResources(this.materialTextBoxLinealIterCount, "materialTextBoxLinealIterCount");
            this.materialTextBoxLinealIterCount.AnimateReadOnly = true;
            this.materialTextBoxLinealIterCount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxLinealIterCount.Depth = 0;
            this.materialTextBoxLinealIterCount.HideSelection = true;
            this.materialTextBoxLinealIterCount.LeadingIcon = null;
            this.materialTextBoxLinealIterCount.MaxLength = 32767;
            this.materialTextBoxLinealIterCount.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxLinealIterCount.Name = "materialTextBoxLinealIterCount";
            this.materialTextBoxLinealIterCount.PasswordChar = '\0';
            this.materialTextBoxLinealIterCount.ReadOnly = true;
            this.materialTextBoxLinealIterCount.SelectedText = "";
            this.materialTextBoxLinealIterCount.SelectionLength = 0;
            this.materialTextBoxLinealIterCount.SelectionStart = 0;
            this.materialTextBoxLinealIterCount.ShortcutsEnabled = true;
            this.materialTextBoxLinealIterCount.TabStop = false;
            this.materialTextBoxLinealIterCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxLinealIterCount.TrailingIcon = null;
            this.materialTextBoxLinealIterCount.UseSystemPasswordChar = false;
            // 
            // materialButtonLinealRefresh
            // 
            resources.ApplyResources(this.materialButtonLinealRefresh, "materialButtonLinealRefresh");
            this.materialButtonLinealRefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonLinealRefresh.Depth = 0;
            this.materialButtonLinealRefresh.HighEmphasis = true;
            this.materialButtonLinealRefresh.Icon = ((System.Drawing.Image)(resources.GetObject("materialButtonLinealRefresh.Icon")));
            this.materialButtonLinealRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonLinealRefresh.Name = "materialButtonLinealRefresh";
            this.materialButtonLinealRefresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonLinealRefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonLinealRefresh.UseAccentColor = false;
            this.materialButtonLinealRefresh.UseVisualStyleBackColor = true;
            this.materialButtonLinealRefresh.Click += new System.EventHandler(this.materialButtonLinealRefresh_Click);
            // 
            // chartLineal
            // 
            resources.ApplyResources(this.chartLineal, "chartLineal");
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 90F;
            chartArea1.InnerPlotPosition.Width = 95F;
            chartArea1.InnerPlotPosition.X = 3F;
            chartArea1.InnerPlotPosition.Y = 4F;
            chartArea1.Name = "ChartArea1";
            this.chartLineal.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.IsDockedInsideChartArea = false;
            legend1.MaximumAutoSize = 20F;
            legend1.Name = "LegendLineal";
            legend1.Title = "Скорость линейного поиска";
            this.chartLineal.Legends.Add(legend1);
            this.chartLineal.Name = "chartLineal";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "LegendLineal";
            series1.MarkerBorderWidth = 3;
            series1.MarkerSize = 1;
            series1.Name = "Время";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "LegendLineal";
            series2.Name = "Количество операций";
            this.chartLineal.Series.Add(series1);
            this.chartLineal.Series.Add(series2);
            title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title1.Name = "Скорость линейного поиска";
            this.chartLineal.Titles.Add(title1);
            // 
            // materialCardBinarySearch
            // 
            resources.ApplyResources(this.materialCardBinarySearch, "materialCardBinarySearch");
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
            this.materialCardBinarySearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardBinarySearch.Name = "materialCardBinarySearch";
            // 
            // materialCheckboxBinaryCount
            // 
            resources.ApplyResources(this.materialCheckboxBinaryCount, "materialCheckboxBinaryCount");
            this.materialCheckboxBinaryCount.Checked = true;
            this.materialCheckboxBinaryCount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckboxBinaryCount.Depth = 0;
            this.materialCheckboxBinaryCount.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckboxBinaryCount.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckboxBinaryCount.Name = "materialCheckboxBinaryCount";
            this.materialCheckboxBinaryCount.ReadOnly = false;
            this.materialCheckboxBinaryCount.Ripple = true;
            this.materialCheckboxBinaryCount.UseVisualStyleBackColor = true;
            this.materialCheckboxBinaryCount.CheckedChanged += new System.EventHandler(this.materialCheckboxBinaryCount_CheckedChanged);
            // 
            // materialCheckboxBinaryTime
            // 
            resources.ApplyResources(this.materialCheckboxBinaryTime, "materialCheckboxBinaryTime");
            this.materialCheckboxBinaryTime.Checked = true;
            this.materialCheckboxBinaryTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialCheckboxBinaryTime.Depth = 0;
            this.materialCheckboxBinaryTime.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckboxBinaryTime.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckboxBinaryTime.Name = "materialCheckboxBinaryTime";
            this.materialCheckboxBinaryTime.ReadOnly = false;
            this.materialCheckboxBinaryTime.Ripple = true;
            this.materialCheckboxBinaryTime.UseVisualStyleBackColor = true;
            this.materialCheckboxBinaryTime.CheckedChanged += new System.EventHandler(this.materialCheckboxBinaryTime_CheckedChanged);
            // 
            // materialTextBoxBinaryTotalTime
            // 
            resources.ApplyResources(this.materialTextBoxBinaryTotalTime, "materialTextBoxBinaryTotalTime");
            this.materialTextBoxBinaryTotalTime.AnimateReadOnly = true;
            this.materialTextBoxBinaryTotalTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxBinaryTotalTime.Depth = 0;
            this.materialTextBoxBinaryTotalTime.HideSelection = true;
            this.materialTextBoxBinaryTotalTime.LeadingIcon = null;
            this.materialTextBoxBinaryTotalTime.MaxLength = 32767;
            this.materialTextBoxBinaryTotalTime.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxBinaryTotalTime.Name = "materialTextBoxBinaryTotalTime";
            this.materialTextBoxBinaryTotalTime.PasswordChar = '\0';
            this.materialTextBoxBinaryTotalTime.ReadOnly = true;
            this.materialTextBoxBinaryTotalTime.SelectedText = "";
            this.materialTextBoxBinaryTotalTime.SelectionLength = 0;
            this.materialTextBoxBinaryTotalTime.SelectionStart = 0;
            this.materialTextBoxBinaryTotalTime.ShortcutsEnabled = true;
            this.materialTextBoxBinaryTotalTime.TabStop = false;
            this.materialTextBoxBinaryTotalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxBinaryTotalTime.TrailingIcon = null;
            this.materialTextBoxBinaryTotalTime.UseSystemPasswordChar = false;
            // 
            // materialTextBoxBinaryMaxTime
            // 
            resources.ApplyResources(this.materialTextBoxBinaryMaxTime, "materialTextBoxBinaryMaxTime");
            this.materialTextBoxBinaryMaxTime.AnimateReadOnly = true;
            this.materialTextBoxBinaryMaxTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxBinaryMaxTime.Depth = 0;
            this.materialTextBoxBinaryMaxTime.HideSelection = true;
            this.materialTextBoxBinaryMaxTime.LeadingIcon = null;
            this.materialTextBoxBinaryMaxTime.MaxLength = 32767;
            this.materialTextBoxBinaryMaxTime.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxBinaryMaxTime.Name = "materialTextBoxBinaryMaxTime";
            this.materialTextBoxBinaryMaxTime.PasswordChar = '\0';
            this.materialTextBoxBinaryMaxTime.ReadOnly = true;
            this.materialTextBoxBinaryMaxTime.SelectedText = "";
            this.materialTextBoxBinaryMaxTime.SelectionLength = 0;
            this.materialTextBoxBinaryMaxTime.SelectionStart = 0;
            this.materialTextBoxBinaryMaxTime.ShortcutsEnabled = true;
            this.materialTextBoxBinaryMaxTime.TabStop = false;
            this.materialTextBoxBinaryMaxTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxBinaryMaxTime.TrailingIcon = null;
            this.materialTextBoxBinaryMaxTime.UseSystemPasswordChar = false;
            // 
            // materialTextBoxBinaryMinTime
            // 
            resources.ApplyResources(this.materialTextBoxBinaryMinTime, "materialTextBoxBinaryMinTime");
            this.materialTextBoxBinaryMinTime.AnimateReadOnly = true;
            this.materialTextBoxBinaryMinTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxBinaryMinTime.Depth = 0;
            this.materialTextBoxBinaryMinTime.HideSelection = true;
            this.materialTextBoxBinaryMinTime.LeadingIcon = null;
            this.materialTextBoxBinaryMinTime.MaxLength = 32767;
            this.materialTextBoxBinaryMinTime.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxBinaryMinTime.Name = "materialTextBoxBinaryMinTime";
            this.materialTextBoxBinaryMinTime.PasswordChar = '\0';
            this.materialTextBoxBinaryMinTime.ReadOnly = true;
            this.materialTextBoxBinaryMinTime.SelectedText = "";
            this.materialTextBoxBinaryMinTime.SelectionLength = 0;
            this.materialTextBoxBinaryMinTime.SelectionStart = 0;
            this.materialTextBoxBinaryMinTime.ShortcutsEnabled = true;
            this.materialTextBoxBinaryMinTime.TabStop = false;
            this.materialTextBoxBinaryMinTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxBinaryMinTime.TrailingIcon = null;
            this.materialTextBoxBinaryMinTime.UseSystemPasswordChar = false;
            // 
            // materialTextBoxBinaryIterCount
            // 
            resources.ApplyResources(this.materialTextBoxBinaryIterCount, "materialTextBoxBinaryIterCount");
            this.materialTextBoxBinaryIterCount.AnimateReadOnly = true;
            this.materialTextBoxBinaryIterCount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.materialTextBoxBinaryIterCount.Depth = 0;
            this.materialTextBoxBinaryIterCount.HideSelection = true;
            this.materialTextBoxBinaryIterCount.LeadingIcon = null;
            this.materialTextBoxBinaryIterCount.MaxLength = 32767;
            this.materialTextBoxBinaryIterCount.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxBinaryIterCount.Name = "materialTextBoxBinaryIterCount";
            this.materialTextBoxBinaryIterCount.PasswordChar = '\0';
            this.materialTextBoxBinaryIterCount.ReadOnly = true;
            this.materialTextBoxBinaryIterCount.SelectedText = "";
            this.materialTextBoxBinaryIterCount.SelectionLength = 0;
            this.materialTextBoxBinaryIterCount.SelectionStart = 0;
            this.materialTextBoxBinaryIterCount.ShortcutsEnabled = true;
            this.materialTextBoxBinaryIterCount.TabStop = false;
            this.materialTextBoxBinaryIterCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.materialTextBoxBinaryIterCount.TrailingIcon = null;
            this.materialTextBoxBinaryIterCount.UseSystemPasswordChar = false;
            // 
            // materialButtonBinaryRefresh
            // 
            resources.ApplyResources(this.materialButtonBinaryRefresh, "materialButtonBinaryRefresh");
            this.materialButtonBinaryRefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonBinaryRefresh.Depth = 0;
            this.materialButtonBinaryRefresh.HighEmphasis = true;
            this.materialButtonBinaryRefresh.Icon = ((System.Drawing.Image)(resources.GetObject("materialButtonBinaryRefresh.Icon")));
            this.materialButtonBinaryRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonBinaryRefresh.Name = "materialButtonBinaryRefresh";
            this.materialButtonBinaryRefresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonBinaryRefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonBinaryRefresh.UseAccentColor = false;
            this.materialButtonBinaryRefresh.UseVisualStyleBackColor = true;
            this.materialButtonBinaryRefresh.Click += new System.EventHandler(this.materialButtonBinaryRefresh_Click);
            // 
            // chartBinary
            // 
            resources.ApplyResources(this.chartBinary, "chartBinary");
            chartArea2.InnerPlotPosition.Auto = false;
            chartArea2.InnerPlotPosition.Height = 90F;
            chartArea2.InnerPlotPosition.Width = 95F;
            chartArea2.InnerPlotPosition.X = 3F;
            chartArea2.InnerPlotPosition.Y = 4F;
            chartArea2.Name = "ChartArea1";
            this.chartBinary.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.IsDockedInsideChartArea = false;
            legend2.MaximumAutoSize = 20F;
            legend2.Name = "LegendLineal";
            legend2.Title = "Скорость бинарного поиска";
            this.chartBinary.Legends.Add(legend2);
            this.chartBinary.Name = "chartBinary";
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
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title2.Name = "Скорость линейного поиска";
            this.chartBinary.Titles.Add(title2);
            // 
            // materialComboBoxSelect
            // 
            resources.ApplyResources(this.materialComboBoxSelect, "materialComboBoxSelect");
            this.materialComboBoxSelect.AutoResize = false;
            this.materialComboBoxSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxSelect.Depth = 0;
            this.materialComboBoxSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxSelect.DropDownHeight = 118;
            this.materialComboBoxSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxSelect.DropDownWidth = 121;
            this.materialComboBoxSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxSelect.FormattingEnabled = true;
            this.materialComboBoxSelect.Items.AddRange(new object[] { resources.GetString("materialComboBoxSelect.Items"), resources.GetString("materialComboBoxSelect.Items1"), resources.GetString("materialComboBoxSelect.Items2") });
            this.materialComboBoxSelect.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxSelect.Name = "materialComboBoxSelect";
            this.materialComboBoxSelect.StartIndex = 0;
            this.materialComboBoxSelect.UseTallSize = false;
            this.materialComboBoxSelect.SelectedIndexChanged += new System.EventHandler(this.materialComboBoxSelect_SelectedIndexChanged);
            // 
            // materialCheckboxRefresh
            // 
            resources.ApplyResources(this.materialCheckboxRefresh, "materialCheckboxRefresh");
            this.materialCheckboxRefresh.Depth = 0;
            this.materialCheckboxRefresh.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckboxRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckboxRefresh.Name = "materialCheckboxRefresh";
            this.materialCheckboxRefresh.ReadOnly = false;
            this.materialCheckboxRefresh.Ripple = true;
            this.materialCheckboxRefresh.UseVisualStyleBackColor = true;
            // 
            // tabPageSpec
            // 
            resources.ApplyResources(this.tabPageSpec, "tabPageSpec");
            this.tabPageSpec.BackColor = System.Drawing.Color.White;
            this.tabPageSpec.Controls.Add(this.materialCard3);
            this.tabPageSpec.Controls.Add(this.materialCard2);
            this.tabPageSpec.Controls.Add(this.materialCard1);
            this.tabPageSpec.Controls.Add(this.materialCardSave);
            this.tabPageSpec.Name = "tabPageSpec";
            // 
            // materialCard3
            // 
            resources.ApplyResources(this.materialCard3, "materialCard3");
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialLabel2);
            this.materialCard3.Controls.Add(this.materialSwitchUseAsync);
            this.materialCard3.Controls.Add(this.materialSwitchWrapChartAsync);
            this.materialCard3.Controls.Add(this.materialSwitchSaveDataAsync);
            this.materialCard3.Controls.Add(this.materialSwitchGenWordAsync);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            // 
            // materialLabel2
            // 
            resources.ApplyResources(this.materialLabel2, "materialLabel2");
            this.materialLabel2.Depth = 0;
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            // 
            // materialSwitchUseAsync
            // 
            resources.ApplyResources(this.materialSwitchUseAsync, "materialSwitchUseAsync");
            this.materialSwitchUseAsync.Checked = true;
            this.materialSwitchUseAsync.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialSwitchUseAsync.Depth = 0;
            this.materialSwitchUseAsync.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitchUseAsync.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitchUseAsync.Name = "materialSwitchUseAsync";
            this.materialSwitchUseAsync.Ripple = true;
            this.materialSwitchUseAsync.UseVisualStyleBackColor = true;
            this.materialSwitchUseAsync.CheckedChanged += new System.EventHandler(this.materialSwitchUseAsync_CheckedChanged);
            // 
            // materialSwitchWrapChartAsync
            // 
            resources.ApplyResources(this.materialSwitchWrapChartAsync, "materialSwitchWrapChartAsync");
            this.materialSwitchWrapChartAsync.Checked = true;
            this.materialSwitchWrapChartAsync.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialSwitchWrapChartAsync.Depth = 0;
            this.materialSwitchWrapChartAsync.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitchWrapChartAsync.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitchWrapChartAsync.Name = "materialSwitchWrapChartAsync";
            this.materialSwitchWrapChartAsync.Ripple = true;
            this.materialSwitchWrapChartAsync.UseVisualStyleBackColor = true;
            // 
            // materialSwitchSaveDataAsync
            // 
            resources.ApplyResources(this.materialSwitchSaveDataAsync, "materialSwitchSaveDataAsync");
            this.materialSwitchSaveDataAsync.Checked = true;
            this.materialSwitchSaveDataAsync.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialSwitchSaveDataAsync.Depth = 0;
            this.materialSwitchSaveDataAsync.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitchSaveDataAsync.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitchSaveDataAsync.Name = "materialSwitchSaveDataAsync";
            this.materialSwitchSaveDataAsync.Ripple = true;
            this.materialSwitchSaveDataAsync.UseVisualStyleBackColor = true;
            // 
            // materialSwitchGenWordAsync
            // 
            resources.ApplyResources(this.materialSwitchGenWordAsync, "materialSwitchGenWordAsync");
            this.materialSwitchGenWordAsync.Checked = true;
            this.materialSwitchGenWordAsync.CheckState = System.Windows.Forms.CheckState.Checked;
            this.materialSwitchGenWordAsync.Depth = 0;
            this.materialSwitchGenWordAsync.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitchGenWordAsync.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitchGenWordAsync.Name = "materialSwitchGenWordAsync";
            this.materialSwitchGenWordAsync.Ripple = true;
            this.materialSwitchGenWordAsync.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            resources.ApplyResources(this.materialCard2, "materialCard2");
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialLabel1);
            this.materialCard2.Controls.Add(this.materialSwitchTheme);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            // 
            // materialLabel1
            // 
            resources.ApplyResources(this.materialLabel1, "materialLabel1");
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            // 
            // materialSwitchTheme
            // 
            resources.ApplyResources(this.materialSwitchTheme, "materialSwitchTheme");
            this.materialSwitchTheme.Depth = 0;
            this.materialSwitchTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitchTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitchTheme.Name = "materialSwitchTheme";
            this.materialSwitchTheme.Ripple = true;
            this.materialSwitchTheme.UseVisualStyleBackColor = true;
            this.materialSwitchTheme.CheckedChanged += new System.EventHandler(this.materialSwitchTheme_CheckedChanged);
            // 
            // materialCard1
            // 
            resources.ApplyResources(this.materialCard1, "materialCard1");
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialComboBoxSaveDataType);
            this.materialCard1.Controls.Add(this.materialLabelSaveXlsx);
            this.materialCard1.Controls.Add(this.materialButtonSaveXlsx);
            this.materialCard1.Controls.Add(this.materialComboBoxSelectChartToXlsx);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            // 
            // materialComboBoxSaveDataType
            // 
            resources.ApplyResources(this.materialComboBoxSaveDataType, "materialComboBoxSaveDataType");
            this.materialComboBoxSaveDataType.AutoResize = false;
            this.materialComboBoxSaveDataType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxSaveDataType.Depth = 0;
            this.materialComboBoxSaveDataType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxSaveDataType.DropDownHeight = 174;
            this.materialComboBoxSaveDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxSaveDataType.DropDownWidth = 121;
            this.materialComboBoxSaveDataType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxSaveDataType.FormattingEnabled = true;
            this.materialComboBoxSaveDataType.Items.AddRange(new object[] { resources.GetString("materialComboBoxSaveDataType.Items"), resources.GetString("materialComboBoxSaveDataType.Items1") });
            this.materialComboBoxSaveDataType.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxSaveDataType.Name = "materialComboBoxSaveDataType";
            this.materialComboBoxSaveDataType.StartIndex = 0;
            // 
            // materialLabelSaveXlsx
            // 
            resources.ApplyResources(this.materialLabelSaveXlsx, "materialLabelSaveXlsx");
            this.materialLabelSaveXlsx.Depth = 0;
            this.materialLabelSaveXlsx.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabelSaveXlsx.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelSaveXlsx.Name = "materialLabelSaveXlsx";
            // 
            // materialButtonSaveXlsx
            // 
            resources.ApplyResources(this.materialButtonSaveXlsx, "materialButtonSaveXlsx");
            this.materialButtonSaveXlsx.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSaveXlsx.Depth = 0;
            this.materialButtonSaveXlsx.HighEmphasis = true;
            this.materialButtonSaveXlsx.Icon = ((System.Drawing.Image)(resources.GetObject("materialButtonSaveXlsx.Icon")));
            this.materialButtonSaveXlsx.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSaveXlsx.Name = "materialButtonSaveXlsx";
            this.materialButtonSaveXlsx.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSaveXlsx.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSaveXlsx.UseAccentColor = false;
            this.materialButtonSaveXlsx.UseVisualStyleBackColor = true;
            this.materialButtonSaveXlsx.Click += new System.EventHandler(this.materialButtonSaveXlsx_Click);
            // 
            // materialComboBoxSelectChartToXlsx
            // 
            resources.ApplyResources(this.materialComboBoxSelectChartToXlsx, "materialComboBoxSelectChartToXlsx");
            this.materialComboBoxSelectChartToXlsx.AutoResize = false;
            this.materialComboBoxSelectChartToXlsx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxSelectChartToXlsx.Depth = 0;
            this.materialComboBoxSelectChartToXlsx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxSelectChartToXlsx.DropDownHeight = 174;
            this.materialComboBoxSelectChartToXlsx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxSelectChartToXlsx.DropDownWidth = 121;
            this.materialComboBoxSelectChartToXlsx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxSelectChartToXlsx.FormattingEnabled = true;
            this.materialComboBoxSelectChartToXlsx.Items.AddRange(new object[] { resources.GetString("materialComboBoxSelectChartToXlsx.Items"), resources.GetString("materialComboBoxSelectChartToXlsx.Items1") });
            this.materialComboBoxSelectChartToXlsx.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxSelectChartToXlsx.Name = "materialComboBoxSelectChartToXlsx";
            this.materialComboBoxSelectChartToXlsx.StartIndex = 0;
            // 
            // materialCardSave
            // 
            resources.ApplyResources(this.materialCardSave, "materialCardSave");
            this.materialCardSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardSave.Controls.Add(this.materialButtonSave);
            this.materialCardSave.Controls.Add(this.materialLabel3);
            this.materialCardSave.Controls.Add(this.materialComboBoxSelectChart);
            this.materialCardSave.Depth = 0;
            this.materialCardSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardSave.Name = "materialCardSave";
            // 
            // materialButtonSave
            // 
            resources.ApplyResources(this.materialButtonSave, "materialButtonSave");
            this.materialButtonSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonSave.Depth = 0;
            this.materialButtonSave.HighEmphasis = true;
            this.materialButtonSave.Icon = ((System.Drawing.Image)(resources.GetObject("materialButtonSave.Icon")));
            this.materialButtonSave.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonSave.Name = "materialButtonSave";
            this.materialButtonSave.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonSave.UseAccentColor = false;
            this.materialButtonSave.UseVisualStyleBackColor = true;
            this.materialButtonSave.Click += new System.EventHandler(this.materialButtonSave_Click);
            // 
            // materialLabel3
            // 
            resources.ApplyResources(this.materialLabel3, "materialLabel3");
            this.materialLabel3.Depth = 0;
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            // 
            // materialComboBoxSelectChart
            // 
            resources.ApplyResources(this.materialComboBoxSelectChart, "materialComboBoxSelectChart");
            this.materialComboBoxSelectChart.AutoResize = false;
            this.materialComboBoxSelectChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxSelectChart.Depth = 0;
            this.materialComboBoxSelectChart.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxSelectChart.DropDownHeight = 174;
            this.materialComboBoxSelectChart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxSelectChart.DropDownWidth = 121;
            this.materialComboBoxSelectChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxSelectChart.FormattingEnabled = true;
            this.materialComboBoxSelectChart.Items.AddRange(new object[] { resources.GetString("materialComboBoxSelectChart.Items"), resources.GetString("materialComboBoxSelectChart.Items1") });
            this.materialComboBoxSelectChart.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxSelectChart.Name = "materialComboBoxSelectChart";
            this.materialComboBoxSelectChart.StartIndex = 0;
            // 
            // tabPageInfo
            // 
            resources.ApplyResources(this.tabPageInfo, "tabPageInfo");
            this.tabPageInfo.BackColor = System.Drawing.Color.White;
            this.tabPageInfo.Controls.Add(this.materialCardLogo);
            this.tabPageInfo.Controls.Add(this.linkLabelGitHub);
            this.tabPageInfo.Controls.Add(this.materialLabelSubject);
            this.tabPageInfo.Controls.Add(this.materialLabelKR);
            this.tabPageInfo.Controls.Add(this.materialLabelInfo);
            this.tabPageInfo.Name = "tabPageInfo";
            // 
            // materialCardLogo
            // 
            resources.ApplyResources(this.materialCardLogo, "materialCardLogo");
            this.materialCardLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCardLogo.Controls.Add(this.pictureBox1);
            this.materialCardLogo.Depth = 0;
            this.materialCardLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCardLogo.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCardLogo.Name = "materialCardLogo";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // linkLabelGitHub
            // 
            resources.ApplyResources(this.linkLabelGitHub, "linkLabelGitHub");
            this.linkLabelGitHub.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabelGitHub.ImageList = this.imageListGit;
            this.linkLabelGitHub.LinkColor = System.Drawing.Color.Black;
            this.linkLabelGitHub.Name = "linkLabelGitHub";
            this.linkLabelGitHub.TabStop = true;
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
            resources.ApplyResources(this.materialLabelSubject, "materialLabelSubject");
            this.materialLabelSubject.Depth = 0;
            this.materialLabelSubject.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabelSubject.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelSubject.Name = "materialLabelSubject";
            // 
            // materialLabelKR
            // 
            resources.ApplyResources(this.materialLabelKR, "materialLabelKR");
            this.materialLabelKR.Depth = 0;
            this.materialLabelKR.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabelKR.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelKR.Name = "materialLabelKR";
            // 
            // materialLabelInfo
            // 
            resources.ApplyResources(this.materialLabelInfo, "materialLabelInfo");
            this.materialLabelInfo.Depth = 0;
            this.materialLabelInfo.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabelInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelInfo.Name = "materialLabelInfo";
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
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.materialTabControlMainWindow);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControlMainWindow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Sizable = false;
            this.materialTabControlMainWindow.ResumeLayout(false);
            this.tabPageDevelop.ResumeLayout(false);
            this.materialTabControlDev.ResumeLayout(false);
            this.tabPageAuto.ResumeLayout(false);
            this.materialCardAuto.ResumeLayout(false);
            this.materialCardAuto.PerformLayout();
            this.tabPageHandle.ResumeLayout(false);
            this.materialCardHandle.ResumeLayout(false);
            this.materialCardHandle.PerformLayout();
            this.tabPageImport.ResumeLayout(false);
            this.materialCardImport.ResumeLayout(false);
            this.materialCardImport.PerformLayout();
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
            this.materialCard3.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.materialCardSave.ResumeLayout(false);
            this.materialCardSave.PerformLayout();
            this.tabPageInfo.ResumeLayout(false);
            this.materialCardLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private MaterialSkin.Controls.MaterialCheckbox materialCheckBoxDop;

        private MaterialSkin.Controls.MaterialButton materialButtonImportClearPath;

        private MaterialSkin.Controls.MaterialLabel materialLabelImportError;

        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxImportSelectedFile;

        private MaterialSkin.Controls.MaterialButton materialButtonImportSelect;

        private MaterialSkin.Controls.MaterialLabel materialLabelImport;

        private MaterialSkin.Controls.MaterialButton materialButtonImport;

        private MaterialSkin.Controls.MaterialCard materialCardImport;

        private System.Windows.Forms.TabPage tabPageImport;

        private MaterialSkin.Controls.MaterialComboBox materialComboBoxSaveDataType;

        private System.Windows.Forms.PictureBox pictureBox1;

        private MaterialSkin.Controls.MaterialCard materialCardLogo;

        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSwitch materialSwitchUseAsync;

        private MaterialSkin.Controls.MaterialCard materialCard3;

        private MaterialSkin.Controls.MaterialLabel materialLabel1;

        private MaterialSkin.Controls.MaterialCard materialCard2;

        private MaterialSkin.Controls.MaterialSwitch materialSwitchWrapChartAsync;
        private MaterialSkin.Controls.MaterialSwitch materialSwitchSaveDataAsync;
        private MaterialSkin.Controls.MaterialSwitch materialSwitchGenWordAsync;

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