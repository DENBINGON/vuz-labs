using System.Collections.Generic;

namespace d3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    class Line
    {
        public List<double[]> list = new List<double[]>(); 
        public Line(double[] arr)
        {
            foreach (double i in arr)
            { 
                list.Add(new double[] { list.Count, i });
            }
        }
    }
}