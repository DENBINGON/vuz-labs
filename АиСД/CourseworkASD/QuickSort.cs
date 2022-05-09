using System.Collections.Generic;

namespace CourseworkASD
{
    public class QuickSort
    {
        public List<(string word, int hash)> Sort(List<(string word, int hash)> array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }

            int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

            Sort(array, minIndex, pivotIndex - 1);
            Sort(array, pivotIndex + 1, maxIndex);

            return array;
        }

        private int GetPivotIndex(List<(string word, int hash)> array, int minIndex, int maxIndex)
        {
            int pivot = minIndex - 1;

            for (int i = minIndex; i <= maxIndex; i++)
            {
                if (array[i].hash < array[maxIndex].hash)
                {
                    pivot++;
                    (array[pivot], array[i]) = (array[i], array[pivot]);
                }
            }

            pivot++;

            (array[pivot], array[maxIndex]) = (array[maxIndex], array[pivot]);

            return pivot;
        }
    }
}