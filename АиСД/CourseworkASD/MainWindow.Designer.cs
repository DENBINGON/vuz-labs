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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.materialTabControlMainWindow = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPageDevelop = new System.Windows.Forms.TabPage();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialSwitch1 = new MaterialSkin.Controls.MaterialSwitch();
            this.materialProgressBar1 = new MaterialSkin.Controls.MaterialProgressBar();
            this.materialSlider1 = new MaterialSkin.Controls.MaterialSlider();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Значение = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageCharts = new System.Windows.Forms.TabPage();
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.materialTabControlMainWindow.SuspendLayout();
            this.tabPageDevelop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPageCharts.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.tabPageInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
            this.tabPageDevelop.Controls.Add(this.materialLabel2);
            this.tabPageDevelop.Controls.Add(this.materialLabel1);
            this.tabPageDevelop.Controls.Add(this.materialSwitch1);
            this.tabPageDevelop.Controls.Add(this.materialProgressBar1);
            this.tabPageDevelop.Controls.Add(this.materialSlider1);
            this.tabPageDevelop.Controls.Add(this.materialButton1);
            this.tabPageDevelop.Controls.Add(this.dataGridView1);
            this.tabPageDevelop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageDevelop.ImageKey = "file-document-edit-outline.png";
            this.tabPageDevelop.Location = new System.Drawing.Point(4, 39);
            this.tabPageDevelop.Name = "tabPageDevelop";
            this.tabPageDevelop.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDevelop.Size = new System.Drawing.Size(790, 340);
            this.tabPageDevelop.TabIndex = 0;
            this.tabPageDevelop.Text = "Разработка";
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
            // materialSwitch1
            // 
            this.materialSwitch1.BackColor = System.Drawing.Color.White;
            this.materialSwitch1.Depth = 0;
            this.materialSwitch1.Location = new System.Drawing.Point(366, 29);
            this.materialSwitch1.Margin = new System.Windows.Forms.Padding(0);
            this.materialSwitch1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialSwitch1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSwitch1.Name = "materialSwitch1";
            this.materialSwitch1.Ripple = true;
            this.materialSwitch1.Size = new System.Drawing.Size(135, 27);
            this.materialSwitch1.TabIndex = 4;
            this.materialSwitch1.Text = "Ручная";
            this.materialSwitch1.UseVisualStyleBackColor = false;
            // 
            // materialProgressBar1
            // 
            this.materialProgressBar1.Depth = 0;
            this.materialProgressBar1.Location = new System.Drawing.Point(69, 6);
            this.materialProgressBar1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialProgressBar1.Name = "materialProgressBar1";
            this.materialProgressBar1.Size = new System.Drawing.Size(477, 5);
            this.materialProgressBar1.TabIndex = 3;
            // 
            // materialSlider1
            // 
            this.materialSlider1.Depth = 0;
            this.materialSlider1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialSlider1.Location = new System.Drawing.Point(581, 50);
            this.materialSlider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSlider1.Name = "materialSlider1";
            this.materialSlider1.Size = new System.Drawing.Size(304, 40);
            this.materialSlider1.TabIndex = 2;
            this.materialSlider1.Text = "Количество ";
            this.materialSlider1.Value = 1;
            this.materialSlider1.ValueMax = 100;
            this.materialSlider1.ValueSuffix = " тыс.";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(581, 99);
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
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Значение });
            this.dataGridView1.Location = new System.Drawing.Point(552, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(243, 374);
            this.dataGridView1.TabIndex = 0;
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
            this.tabPageCharts.Controls.Add(this.chart1);
            this.tabPageCharts.ImageKey = "chart-line.png";
            this.tabPageCharts.Location = new System.Drawing.Point(4, 39);
            this.tabPageCharts.Name = "tabPageCharts";
            this.tabPageCharts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCharts.Size = new System.Drawing.Size(790, 340);
            this.tabPageCharts.TabIndex = 1;
            this.tabPageCharts.Text = "Статистика";
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
            this.linkLabelGitHub.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.linkLabelGitHub.ImageKey = "github.png";
            this.linkLabelGitHub.ImageList = this.imageListGit;
            this.linkLabelGitHub.LinkColor = System.Drawing.Color.Black;
            this.linkLabelGitHub.Location = new System.Drawing.Point(423, 293);
            this.linkLabelGitHub.Name = "linkLabelGitHub";
            this.linkLabelGitHub.Size = new System.Drawing.Size(336, 32);
            this.linkLabelGitHub.TabIndex = 4;
            this.linkLabelGitHub.TabStop = true;
            this.linkLabelGitHub.Text = "Исходный код приложения на GitHub";
            this.linkLabelGitHub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(79, 17);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(518, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
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
            this.tabPageDevelop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPageCharts.ResumeLayout(false);
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInfoLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;

        private MaterialSkin.Controls.MaterialLabel materialLabel2;

        private MaterialSkin.Controls.MaterialLabel materialLabel1;

        private MaterialSkin.Controls.MaterialSwitch materialSwitch1;

        private MaterialSkin.Controls.MaterialProgressBar materialProgressBar1;

        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialSlider materialSlider1;

        private System.Windows.Forms.DataGridViewTextBoxColumn Значение;

        private System.Windows.Forms.DataGridView dataGridView1;

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