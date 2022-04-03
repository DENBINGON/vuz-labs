using System;
using System.Collections.Generic;

namespace d1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Распределенные
            List<Tuple<string, int>> tuples = new List<Tuple<string, int>>();

            //Числа пересчета 
            int E = 13; //Билетов
            int K = 1; //Учащихся
            
            //Кольцевые списки
            CircledList students = new CircledList(new string[] { "Петров","Иванов", "Смирнов"}); //Учащиеся 
            CircledList tickets = new CircledList(new object[] {1, 2, 3, 4, 5, 6, 7, 8}); //Билеты

            //Мешаем и объединяем кортежем
            for (int i = 0, j = 0; i<students.Count() * K ; i+=K, j+=E)
            {
                tuples.Add(new Tuple<string, int>((string) students[i],(int) tickets[j]));
            }
            //Наводим красоту
            tuples.Sort();
            
            //Выводим результат
            foreach (var person in tuples)
            {
                Console.WriteLine(person);
            }
        }
    }
}