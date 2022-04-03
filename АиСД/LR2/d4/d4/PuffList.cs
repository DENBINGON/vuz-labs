using System;
using System.Collections.Generic;
using System.IO;

namespace d4
{
    public class PuffList
    {
        //Разделенный писок 
        private List<(string Name, int Number)> puffList;

        //Добавление элемента и сортировка
        public void Add((string Name, int Number) tuple)
        {
            puffList.Add(tuple);
            puffList.Sort();
        }

        //Очистка
        public void Clear() => puffList.Clear();

        //Индексатор
        public (string Name, int Number) this[int index] => puffList[index];

        //Перегрузка удаления поля по имени
        public void RemoveAt(string Name)
        {
            for (int i = 0; i<puffList.Count; i++) if (puffList[i].Name == Name) puffList.RemoveAt(i);
        }
        
        //Перегрузка удаления поля по номеру
        public void RemoveAt(int Number)
        {
            for (int i = 0; i<puffList.Count; i++) if (puffList[i].Number == Number) puffList.RemoveAt(i);
        }

        //Перегрузка поиска по имени
        public (string Name, int Number) Find(string Name)
        {
            for (int i = 0; i<puffList.Count; i++) if (puffList[i].Name == Name) return puffList[i];
            return ("None", 0);
        }   
        
        //Перегрузка поиска по номеру
        public (string Name, int Number) Find(int Number)
        {
            for (int i = 0; i<puffList.Count; i++) if (puffList[i].Number == Number) return puffList[i];
            return ("None", 0);
        }

        //Вывод всех элементов
        public void Show()
        {
            Console.Write(String.Join("\n", puffList));
        }
        
        /*Создание и первичное заполнение из файла
         Структура файла:
         NAME1 NUMBER1
         NAME2 NUMBER2
         ...
         NAMEn NUMBERn*/
        public PuffList(StreamReader sr)
        {
            puffList = new List<(string Name, int Number)>();
            foreach (string str in sr.ReadToEnd().Split(Convert.ToChar("\n")))
            {
                string[] str_split = str.Split(Convert.ToChar(" "));
                puffList.Add((str_split[0], Convert.ToInt32(str_split[1])));
            }
            puffList.Sort();
        }
        
    }
}