using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    { 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form = new Form1();
            Application.Run(form);
        }
    }

    class Item
    {
        public string itemTitle;
        public string productMaterial;
        public bool stored;

        public Item(string itemTitle,
            string productMaterial,
            bool stored)
        {
            this.itemTitle = itemTitle;
            this.productMaterial = productMaterial;
            this.stored = stored;
        }
    }
}

