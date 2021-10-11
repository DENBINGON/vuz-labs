//Лаболаторная работа 5

using System;
using System.Collections.Generic;
namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввод матрицы
            double[,] matrix = new double[3, 3] { { -1, 3, 10 }, { 3, -1, 1 }, { -4, -2, -3 } };
            //double[,] matrix = new double[2, 2] { { -2, 1 }, { -4, -1 } };
            //double[,] matrix = new double[4, 4] { {2, 3, 0, 10 },{ 0, 3, 4, 8 },{ 0, 1, 5, 7 },{ 2, 3, 4, 5 } };
            //double[,] matrix = new double[4, 4] { { 2, 3, 0, 10 }, { -3, -1, -7, -3 }, { 0, 1, 5, 7 }, { 2, 3, 4, 5 } };
            List<string> MatrixDynamic = new List<string>();
            //Некоторые значения
            double razm = matrix.Length;
            razm = Math.Sqrt(razm);
            int r = Convert.ToInt32(razm);
            double[] ind = new double[3];
            ind[0] = -999;
            double q;
            double[,] matrix_ = new double[r, r];
            for (int i = 0; i < r; i++) { for (int j = 0; j < r; j++) { matrix_[i, j] = matrix[i, j]; } }
            //It's magic
            for (int p = 0; p < r; p++)
            {
                string re = Convert.ToString(p);
                for (int i = 0; i < r; i++)
                {
                    for (int j = 0; j < r; j++)
                    {
                        string m = Convert.ToString(i);
                        string n = Convert.ToString(j);
                        if (matrix[i, j] > ind[0] && MatrixDynamic.IndexOf(m + n) == -1)
                        {
                            ind[0] = matrix[i, j];
                            ind[1] = i;
                            ind[2] = j;
                        }
                    }
                }
                MatrixDynamic.Add(re + re);
                q = matrix[p, p];
                matrix[p, p] = ind[0];
                matrix[(int)ind[1], (int)ind[2]] = q;
                ind[0] = -999;
            }
            //Вывод
            string k = "+";
            for (int i = 0; i < r * 6 + 2; i++) { k += "-"; }
            k += "+";
            for (int i = 0; i < r; i++)
            {
                Console.Write(k + "\n");
                Console.Write("|");
                for (int j = 0; j < r; j++) { Console.Write(String.Format("{0,3}  |", matrix[i, j]) + " "); }
                Console.Write("\n");
            }
            Console.Write(k + "\n\n\n");
            bool o;
            bool z = true;
            for (int i = 0; i < r; i++)
            {
                o = true;
                for (int j = 0; j < r; j++)
                { if (matrix_[i, j] > 0) { o = false; } }
                if (o == true)
                {
                    Console.WriteLine(i + 1);
                    z = false;
                    break;
                }
            }
            if (z) { Console.Write("Нету такой строки"); }
        }
    }
}