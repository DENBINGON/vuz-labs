using System;
using System.Windows.Forms;
using System.Drawing;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Runtime.InteropServices;


namespace CourseworkASD
{
    public partial class MainWindow : MaterialForm
    {
        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (int nLeftRect, int nTopRect, int nRightRect,    
            int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        
        public MainWindow()
        {
            InitializeComponent();
            
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue600, 
                Primary.Blue700,
                Primary.Blue700, 
                Accent.LightBlue400, 
                TextShade.WHITE
            );
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
            System.Diagnostics.Process.Start("");
        }
    }
}