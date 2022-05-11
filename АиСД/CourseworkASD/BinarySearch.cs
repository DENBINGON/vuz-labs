using System;
using System.Collections.Generic;

namespace CourseworkASD
{
    public class BinarySearch : ISearch
    {
        private readonly List<(string word, int hash)> _data;
        public BinarySearch(List<(string word, int hash)> data) => _data = data;

        public (bool exist, int iterCount) Find(string item)
        {
            bool exist = false;
            int iterCount = 0;
            int hash = item.GetHashCode();
            int rightPointer = _data.Count - 1;
            int leftPointer = 0;
            int middlePointer = Convert.ToInt32(Math.Round(Convert.ToDouble(rightPointer / 2)));
            while (!exist && rightPointer != leftPointer && rightPointer - leftPointer != 1)
            {
                iterCount++;
                int localHash = _data[middlePointer].hash;
                if (hash > localHash)
                {
                    leftPointer = middlePointer;
                    middlePointer = Convert.ToInt32(Math.Round(Convert.ToDouble((rightPointer + leftPointer) / 2)));
                }
                else if (hash < localHash)
                {
                    rightPointer = middlePointer;
                    middlePointer = Convert.ToInt32(Math.Round(Convert.ToDouble((rightPointer + leftPointer) / 2)));
                }
                else exist = true;
            }
            
            if (rightPointer == leftPointer && _data[rightPointer].hash == hash) exist = true;
            if (rightPointer - leftPointer == 1 &&
                (_data[rightPointer].hash == hash || _data[leftPointer].hash == hash)) exist = true;
            
            return (exist, iterCount);
        }
    }
}