//Лаболаторная работа 4

using System;
using System.Collections.Generic;
namespace labs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 5, 6, -1, -6, -1, 7, 8, 0, 3, 5, 7, 0, 5, 42, -55, 0, 6, 8, 9, 0, 2, 5, 7 };
            int con = 0;
            List<int> indexes = new List<int>();
            int l = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0) { con++; }
                if (array[i] == 0) { indexes.Add(i); }
            }
            int indexLastZero = indexes[indexes.Count - 1];
            int sum = 0;
            while (indexLastZero < array.Length)
            {
                sum += array[indexLastZero];
                indexLastZero++;
            }
            List<int> sorting = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                sorting.Add(array[i]);
            }
            sorting.Sort();
            Console.Write(con + " " + sum + " \n\n");
            for (int i = 0; i < sorting.Count; i++)
            {
                Console.Write($"{sorting[i]},");
            }
        }
    }
}