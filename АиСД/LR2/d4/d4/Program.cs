using System.IO;

namespace d4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PuffList pl = new PuffList(new StreamReader(File.Open("1.txt",FileMode.Open, FileAccess.Read)));
            pl.Show();
        }
    }
}