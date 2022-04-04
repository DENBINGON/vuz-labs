using System;
using System.Collections.Generic;

namespace d1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>();
            while (true)
            {
                Console.Write("1. Добавить студента\n2. Показать двоечников\n->");
                int q = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (q == 1 || q == 2)
                {
                    if (q == 1)
                    {
                        Console.Write("Имя: ");
                        string name = Console.ReadLine();
                        Console.Write("\nГруппа: ");
                        string group = Console.ReadLine();
                        Console.Write("Оценки: \n");
                        int[] arr = new int[5];
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write("\n" + i.ToString() + ". -> ");
                            arr[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        studentsList.Add(new Student(name, group, arr));
                        studentsList.Sort();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Двоечники:\n");
                        int i = 0;
                        foreach (Student student in studentsList)
                        {
                            if (student.GetD()) Console.WriteLine(i++.ToString() +". " +student.GetName()+"\n");
                        }

                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                else continue;
            }
        }
    }

    class Student
    {
        private string name;
        private string group;
        private int[] usp;

        public bool GetD()
        {
            for (int i = 0; i < 5; i++)
                if (usp[i] == 2)
                    return true;
            return false;
        }

        public string GetName()
        {
            return name;
        }
        
        public Student (string name , string group, int[] usp)
        {
            this.group = group;
            this.name = name;
            this.usp = usp;
        }
        

    }
}