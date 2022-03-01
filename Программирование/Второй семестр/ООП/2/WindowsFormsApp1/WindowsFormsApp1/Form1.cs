using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Runtime.InteropServices;


namespace WindowsFormsApp1
{
    public partial class Form1 : MaterialForm
    {
        List<Item> S = new List<Item>();
        bool rest = false;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (int nLeftRect, int nTopRect, int nRightRect,    
         int nBottomRect, int nWidthEllipse, int nHeightEllipse);


        public Form1()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue800, Primary.LightBlue900, Primary.LightBlue500, Accent.LightBlue200, TextShade.WHITE);

            S.Add(new Item("OSB-3 ULTRALAM 8 мм 2500x1250 мм 3.125 м²", "Ель/Сосна", true));
            S.Add(new Item("OSB-3 ULTRALAM 8 мм 2500x1250 мм 3.125 м²", "Ель/Сосна", false));
            S.Add(new Item("OSB-3 ULTRALAM 8 мм 2500x1250 мм 3.125 м²", "Ель/Сосна", true));
            refresh(rest);
        }
        public void refresh(bool r)
        {
            materialMultiLineTextBox1.ResetText();
            string s = "";
            foreach (var i in S)
            {
                if (r == true)
                {
                    if (i.stored == true)
                            s+=i.itemTitle + " " + i.productMaterial + Environment.NewLine;
                }
                else s += i.itemTitle + " " + i.productMaterial + Environment.NewLine;
            }
            materialMultiLineTextBox1.Text = s;
        }
        private void Form1_Load(object sender, EventArgs e) {}
        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            rest = materialCheckbox1.Checked;
            refresh(rest);
        }
        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (materialTextBox1.Text + materialTextBox2.Text != "")
            {
                S.Add(new Item(materialTextBox1.Text, materialTextBox2.Text, materialSwitch1.Checked));
                refresh(rest);
            }
        }
        private void materialLabel1_Click(object sender, EventArgs e) {}
        private void materialSwitch1_CheckedChanged(object sender, EventArgs e) {}
    }
}
