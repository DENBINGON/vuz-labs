using System.Collections.Generic;

namespace d1
{
    public class CircledList
    {
        private List<object> circledList;

        public void Add(object obj) => circledList.Add(obj);

        private object GetAt(int index) => circledList[index % circledList.Count];

        public void RemoveAt(int index) => circledList.RemoveAt(index % circledList.Count);

        public object this[int index] => GetAt(index);
        
        public int Count() => circledList.Count;

        public void Clear() => circledList.Clear();

        public CircledList() => circledList = new List<object>();
        
        public CircledList(object[] objArray) => circledList = new List<object>(objArray);
        
        public CircledList(List<object> objList) => circledList = new List<object>(objList);

    }
}